# GPU-Accelerated x86-64 to WASM Transpiler - Implementation Plan

## Machine Profile

| Component | Value |
|-----------|-------|
| CPU | Intel Core i7-8650U (4 cores / 8 threads, 1.90 GHz) |
| RAM | 15.8 GB |
| GPU | Intel UHD Graphics 620 (1 GB shared, DirectX 12, OpenCL 2.1, Shader Model 5.1) |
| OS | Windows 11 Pro |
| .NET | 11.0.100-dev |
| Node.js | v25.8.1 |
| CUDA | NOT AVAILABLE (no NVIDIA GPU) |
| Vulkan SDK | NOT INSTALLED |
| LLVM/Clang | NOT ON PATH (Emscripten source at c:\work\emscripten) |
| Binaryen | Source at c:\work\binaryen (no prebuilt executables) |
| WABT | Source at c:\work\wabt (no prebuilt executables) |

## Problem Statement

The current PrTask.Transpiler decodes x86-64 PE binaries using Iced and emits C# methods.
For claude.exe, this produced:
- 597 MB of C# source
- 62,996 methods
- 12.4 million lines of code
- Roslyn OOM at 11 GB after 14 hours of CPU, never finished

Roslyn is a single-process, single-threaded-per-file compiler with no GPU acceleration.
The C# output cannot be compiled into a runnable artifact at this scale.

## Key Insight: Change the Emit Target

**Stop emitting C#. Emit C instead.**

C compilers (Clang/GCC) are orders of magnitude faster than Roslyn and can:
1. Compile individual .c files fully independently (no header dependency graph)
2. Parallelize across all CPU cores with make -j / ninja
3. Target wasm32 directly via `clang --target=wasm32`
4. Link with wasm-ld into a single .wasm module
5. Be further optimized with Binaryen's wasm-opt

This eliminates Roslyn entirely from the pipeline.

---

## Architecture: End-to-End Pipeline

```
PE Binary (.exe)
       |
       v
[STAGE 1] Iced Decode (existing C# code)
  - Decode x86-64 instructions
  - Recursive descent from entry + exports
  - Build function/block map
  - Build dispatch table for indirect calls
       |
       v
[STAGE 2] Emit C (NEW - replaces C# emission)
  - One .c file per function (63K files)
  - One shared header (cpu_state.h) with:
    - Register globals (rax..r15, rip)
    - Flag globals (cf, zf, sf, of, pf)
    - Memory array + read/write helpers
    - Push/Pop/UpdateFlags macros
  - GPU-accelerated emission via ComputeSharp
       |
       v
[STAGE 3] Parallel Compile (NEW)
  - clang --target=wasm32 -O2 -c each .c file
  - 8 parallel jobs (one per logical core)
  - Each produces a .o (wasm object file)
       |
       v
[STAGE 4] Link
  - wasm-ld links all .o files into one .wasm
  - Exports: entry point + named exports
       |
       v
[STAGE 5] Optimize
  - Binaryen wasm-opt -O3 on final .wasm
       |
       v
Output: single .wasm file, runnable in browser
```

---

## 1. GPU Usage: Where and How

### The GPU Bottleneck is STAGE 2 (Emission)

Emitting 63,000 .c files from decoded instructions is a massively parallel
text-generation task. Each function's emission is independent: it reads from a
shared instruction map and writes a string of C source code. This is a perfect
fit for GPU compute shaders.

### GPU API: DirectX 12 Compute via ComputeSharp

**Why ComputeSharp:**
- Works on Intel UHD 620 (DirectX 12 + WARP fallback)
- C# NuGet package, integrates directly into PrTask.Transpiler
- No CUDA required, no Vulkan SDK required
- Production-ready, used on millions of devices
- If GPU is too weak, WARP software rasterizer provides fallback

**Why NOT CUDA:** No NVIDIA GPU on this machine.
**Why NOT Vulkan:** No SDK installed, requires SPIR-V compilation pipeline.
**Why NOT WebGPU:** Requires browser runtime, adds unnecessary complexity.
**Why NOT OpenCL:** Weaker tooling on Windows, ComputeSharp is better integrated.

### How GPU Emission Works

```
CPU Side:
  1. Decode all instructions with Iced (sequential, fast)
  2. Pack instruction data into a StructuredBuffer<InstrData>
     - Each entry: { Mnemonic, Op0Kind, Op0Reg, Op1Kind, Op1Reg, Immediate, MemBase, MemDisp, BlockId, FuncId }
  3. Allocate output ReadWriteBuffer<uint> for character data
  4. Dispatch compute shader with [numthreads(64,1,1)]

GPU Shader (HLSL via ComputeSharp):
  Per-function (one workgroup per function):
  1. Read instruction range for this function from index buffer
  2. For each instruction in range:
     - Switch on mnemonic enum
     - Write C code characters to output buffer
     - Atomic increment write pointer
  3. Each function writes to a separate region (pre-allocated)

CPU Side (readback):
  4. Copy GPU buffer back to CPU
  5. Split into per-function char arrays
  6. Write each as a .c file
```

### Memory Budget

- 63K functions * ~200 instructions avg = ~12.6M instructions
- Each InstrData struct: ~64 bytes = 806 MB input buffer
- Output: 597 MB of text (same as current C# output, but in C syntax)
- Intel UHD 620: 1 GB shared VRAM, so we batch:
  - Process 8,000 functions per GPU dispatch
  - 8 batches total
  - Each batch: ~100 MB input, ~75 MB output

### GPU Performance Estimate

Intel UHD 620 has 24 execution units, ~192 shader cores.
At ~300 MHz effective compute clock:
- Text emission is memory-bandwidth bound, not compute-bound
- Shared memory bandwidth: ~15 GB/s (from system RAM)
- 597 MB output / 15 GB/s = ~0.04 seconds for pure writes
- With mnemonic switch overhead: ~2-5 seconds total
- vs CPU serial emission: ~60-120 seconds for 597 MB

**Even on this weak iGPU, 10-30x speedup on emission is realistic.**

### Fallback: CPU Parallel Emission

If ComputeSharp GPU dispatch fails or is slower than expected:
- Use Parallel.ForEach with MaxDegreeOfParallelism = 8
- Each thread gets a function range and emits C text
- Still 4-8x faster than current serial StringBuilder approach

---

## 2. Emit C Instead of C# - Design

### cpu_state.h (shared header, ~100 lines)

```c
#pragma once
#include <stdint.h>
#include <string.h>

// 256 MB flat memory
#define MEM_SIZE (256 * 1024 * 1024)
extern uint8_t g_mem[MEM_SIZE];

// Registers
extern uint64_t g_rax, g_rbx, g_rcx, g_rdx;
extern uint64_t g_rsi, g_rdi, g_rsp, g_rbp;
extern uint64_t g_r8, g_r9, g_r10, g_r11;
extern uint64_t g_r12, g_r13, g_r14, g_r15;
extern uint64_t g_rip;

// Flags
extern int g_cf, g_zf, g_sf, g_of, g_pf;

// Memory access (offset from image base)
static inline uint8_t  read_byte(uint64_t a)  { uint32_t i=(uint32_t)a; return (i<MEM_SIZE)?g_mem[i]:0; }
static inline uint16_t read_word(uint64_t a)  { return read_byte(a)|(read_byte(a+1)<<8); }
static inline uint32_t read_dword(uint64_t a) { return read_byte(a)|(read_byte(a+1)<<8)|(read_byte(a+2)<<16)|(read_byte(a+3)<<24); }
static inline uint64_t read_qword(uint64_t a) { return (uint64_t)read_dword(a)|((uint64_t)read_dword(a+4)<<32); }

static inline void write_byte(uint64_t a, uint8_t v)  { uint32_t i=(uint32_t)a; if(i<MEM_SIZE) g_mem[i]=v; }
static inline void write_word(uint64_t a, uint16_t v)  { write_byte(a,v); write_byte(a+1,v>>8); }
static inline void write_dword(uint64_t a, uint32_t v) { write_byte(a,v); write_byte(a+1,v>>8); write_byte(a+2,v>>16); write_byte(a+3,v>>24); }
static inline void write_qword(uint64_t a, uint64_t v) { write_dword(a,(uint32_t)v); write_dword(a+4,(uint32_t)(v>>32)); }

// Stack
static inline void push(uint64_t v) { g_rsp-=8; write_qword(g_rsp,v); }
static inline uint64_t pop(void)    { uint64_t v=read_qword(g_rsp); g_rsp+=8; return v; }

// Flags update
static inline void update_flags(uint64_t r, uint64_t a, uint64_t b, int sz) {
    uint64_t mask = (sz==1)?0xFFULL:(sz==2)?0xFFFFULL:(sz==4)?0xFFFFFFFFULL:~0ULL;
    uint64_t m = r & mask;
    g_zf = (m == 0);
    g_sf = (m >> (sz*8-1)) & 1;
    g_cf = (r > mask);
    g_of = ((a^r)&(b^r)&(1ULL<<(sz*8-1))) != 0;
    g_pf = (__builtin_popcountll(m & 0xFF) & 1) == 0;
}

// Dispatch table (for indirect calls)
typedef void (*func_ptr)(void);
extern func_ptr g_dispatch[];
extern const uint64_t g_dispatch_addrs[];
extern const int g_dispatch_count;
void call_indirect(uint64_t addr);
```

### Per-function .c file example (func_00001000.c)

```c
#include "cpu_state.h"

void block_1000(void);
void block_1020(void);

void func_00001000(void) {
    block_1000();
}

void block_1000(void) {
    push(g_rbp);
    g_rbp = g_rsp;
    g_rsp = g_rsp - 0x20ULL;
    update_flags(g_rsp + 0x20ULL, g_rsp + 0x20ULL, 0x20ULL, 8);
    // mov rcx, [rbp+0x10]
    g_rcx = read_qword(g_rbp + 0x10ULL);
    // cmp rcx, 0
    { uint64_t _t = g_rcx - 0ULL; update_flags(_t, g_rcx, 0ULL, 8); }
    // je block_1020
    if (g_zf) { block_1020(); return; }
    // call block_1050
    push(g_rip);
    call_indirect(0x1050ULL);
    block_1020();
}

void block_1020(void) {
    g_rsp = g_rbp;
    g_rbp = pop();
    return;
}
```

### dispatch.c (single file, generated)

```c
#include "cpu_state.h"

uint8_t g_mem[MEM_SIZE];
uint64_t g_rax, g_rbx, g_rcx, g_rdx;
uint64_t g_rsi, g_rdi, g_rsp, g_rbp;
uint64_t g_r8, g_r9, g_r10, g_r11;
uint64_t g_r12, g_r13, g_r14, g_r15;
uint64_t g_rip;
int g_cf, g_zf, g_sf, g_of, g_pf;

// Forward declarations for all 63K functions
void func_00001000(void);
void func_00001050(void);
// ... 63K entries ...

// Dispatch table
const uint64_t g_dispatch_addrs[] = { 0x1000, 0x1050, /* ... */ };
func_ptr g_dispatch[] = { func_00001000, func_00001050, /* ... */ };
const int g_dispatch_count = 63000;

void call_indirect(uint64_t addr) {
    // Binary search dispatch_addrs for addr
    int lo=0, hi=g_dispatch_count-1;
    while (lo<=hi) {
        int mid=(lo+hi)/2;
        if (g_dispatch_addrs[mid]==addr) { g_dispatch[mid](); return; }
        if (g_dispatch_addrs[mid]<addr) lo=mid+1; else hi=mid-1;
    }
}

// Entry point (exported to WASM)
__attribute__((export_name("entry")))
void entry(void) {
    g_rsp = MEM_SIZE - 0x10000ULL;
    g_rbp = g_rsp;
    // TODO: load PE sections into g_mem
    func_00001000(); // entry point RVA
}
```

---

## 3. 64-Bit Handling

### Register Model
The C emission uses `uint64_t` for all general-purpose registers (rax..r15, rip).
This maps directly to wasm's i64 type. No truncation issues.

### RIP-Relative Addressing
Already resolved at transpile time in the current Iced decoder. The decoder resolves
RIP-relative addresses to absolute virtual addresses during decoding. The C emitter
outputs the resolved absolute address as a constant.

### WASM Memory Model: wasm32 (NOT memory64)
- Target: `wasm32-unknown-unknown` (standard, widest browser support)
- WASM memory64 has 10-100% performance penalty and only recently standardized
- The 256 MB flat memory array fits within wasm32's 4 GB address space
- Registers are local i64 values (WASM has native i64 support even in wasm32)
- Memory addresses are converted: `uint64_t addr` -> `(uint32_t)(addr - IMAGE_BASE)` as index into g_mem
- This works because x86-64 binaries typically use <4 GB of virtual address space for code+data

### Why NOT wasm64/memory64:
- Chrome/Firefox only support up to 16 GB with memory64
- 10-100% performance penalty documented by SpiderMonkey team
- Our memory needs are <256 MB, well within wasm32 limits
- i64 arithmetic is fully supported in wasm32 for register operations

---

## 4. Compilation Pipeline (STAGE 3 + 4 + 5)

### Install WASI SDK

```powershell
# Download WASI SDK (includes clang + wasm-ld for wasm32)
Invoke-WebRequest -Uri "https://github.com/WebAssembly/wasi-sdk/releases/download/wasi-sdk-25/wasi-sdk-25.0-x86_64-windows.tar.gz" -OutFile wasi-sdk.tar.gz
tar xzf wasi-sdk.tar.gz -C C:\work\
```

### Build Binaryen (for wasm-opt)

```powershell
cd C:\work\binaryen
cmake -G Ninja -DCMAKE_BUILD_TYPE=Release .
ninja wasm-opt
```

### Parallel Compilation with Ninja

Generate a build.ninja file from the transpiler:

```ninja
# build.ninja (generated by transpiler)
cc = C:/work/wasi-sdk-25.0/bin/clang.exe
cflags = --target=wasm32-unknown-wasi --sysroot=C:/work/wasi-sdk-25.0/share/wasi-sysroot -O2 -flto -I.

rule cc
  command = $cc $cflags -c $in -o $out

rule link
  command = C:/work/wasi-sdk-25.0/bin/wasm-ld.exe --lto-O3 --no-entry --export=entry $in -o $out

rule opt
  command = C:/work/binaryen/bin/wasm-opt -O3 $in -o $out

# 63,000 compile rules
build obj/func_00001000.o: cc src/func_00001000.c
build obj/func_00001050.o: cc src/func_00001050.c
# ... (63K entries, generated) ...
build obj/dispatch.o: cc src/dispatch.c

# Link all objects
build output/app.wasm: link obj/func_00001000.o obj/func_00001050.o ... obj/dispatch.o

# Optimize
build output/app.opt.wasm: opt output/app.wasm
```

Ninja automatically parallelizes across all 8 logical cores.

### Compilation Time Estimate

| Step | Estimated Time | Notes |
|------|---------------|-------|
| Iced decode | 5-10 sec | Existing, fast |
| GPU emit C | 2-5 sec | 63K functions, batched on iGPU |
| clang compile (8 parallel) | 30-60 min | ~63K files at ~50ms each, /8 cores |
| wasm-ld link | 2-5 min | LTO pass on ~63K objects |
| wasm-opt | 1-3 min | Final optimization |
| **TOTAL** | **~35-70 min** | vs **NEVER** with Roslyn |

### Reducing Compile Time Further

**Strategy: Merge functions into batched .c files**

Instead of 63K individual .c files (filesystem overhead, linker overhead):
- Group functions by proximity: 100 functions per .c file
- 630 .c files instead of 63,000
- Each file ~1 MB
- Clang compile time: ~1-2 sec per file * 630 / 8 cores = **~2-3 minutes total**
- Link time: 630 objects instead of 63K = much faster

This is the recommended approach. Estimated pipeline:

| Step | Estimated Time |
|------|---------------|
| Iced decode | 5-10 sec |
| GPU emit C (batched) | 2-5 sec |
| clang compile (630 files, 8 cores) | 2-4 min |
| wasm-ld link | 30-60 sec |
| wasm-opt | 30-60 sec |
| **TOTAL** | **~4-7 minutes** |

---

## 5. Implementation Steps

### Phase 1: C Emitter (replaces C# emitter)

**Task 1.1: Create X86ToCConverter.cs**
- Copy structure from X86ToSharpConverter.cs
- Change all emission methods to emit C syntax instead of C#
- Emit `cpu_state.h` header file
- Emit `dispatch.c` with globals and dispatch table
- Dependency: None
- Files: `src/PrTask.Transpiler/X86ToCConverter.cs`

**Task 1.2: Batch function grouping**
- Group decoded functions into batches of 100
- Each batch becomes one .c file
- Forward-declare all functions in each .c file
- Dependency: Task 1.1
- Files: `src/PrTask.Transpiler/X86ToCConverter.cs`

**Task 1.3: Generate build.ninja**
- After emitting .c files, generate a Ninja build file
- Include compile, link, and optimize rules
- Dependency: Task 1.2
- Files: `src/PrTask.Transpiler/NinjaBuildGenerator.cs`

**Task 1.4: Update Program.cs**
- Add command-line option to select C vs C# output
- Default to C output for new transpilations
- Dependency: Task 1.1
- Files: `src/PrTask.Transpiler/Program.cs`

### Phase 2: GPU-Accelerated Emission

**Task 2.1: Add ComputeSharp NuGet**
- Add `ComputeSharp` package to PrTask.Transpiler.csproj
- Verify it initializes on Intel UHD 620
- Dependency: None
- Files: `src/PrTask.Transpiler/PrTask.Transpiler.csproj`

**Task 2.2: Create instruction data structures**
- Define `InstrData` struct for GPU buffer
- Serialize Iced instructions to flat array
- Pack mnemonic, operand kinds, registers, immediates into uint fields
- Dependency: Task 2.1
- Files: `src/PrTask.Transpiler/GpuEmitter.cs`

**Task 2.3: Implement HLSL compute shader**
- ComputeSharp allows writing shaders in C# syntax
- Shader reads InstrData[], writes char[] output
- Switch on mnemonic, emit C text characters
- One thread group per function batch
- Dependency: Task 2.2
- Files: `src/PrTask.Transpiler/Shaders/EmitCShader.cs`

**Task 2.4: GPU dispatch and readback**
- Batch 8K functions per dispatch
- Copy results back to CPU
- Split into .c file contents
- Write to disk
- Dependency: Task 2.3
- Files: `src/PrTask.Transpiler/GpuEmitter.cs`

**Task 2.5: CPU fallback path**
- If GPU unavailable or slower, use Parallel.ForEach
- Same emission logic, runs on CPU with 8 threads
- Dependency: Task 2.4
- Files: `src/PrTask.Transpiler/CpuEmitter.cs`

### Phase 3: Toolchain Setup

**Task 3.1: Install WASI SDK**
- Download and extract wasi-sdk-25 to c:\work\wasi-sdk
- Verify clang --target=wasm32-unknown-wasi works
- Dependency: None

**Task 3.2: Build Binaryen**
- Build wasm-opt from c:\work\binaryen source
- Dependency: None

**Task 3.3: Install Ninja**
- Download ninja.exe to c:\work\bin or PATH
- Dependency: None

### Phase 4: Integration

**Task 4.1: End-to-end test with small binary**
- Transpile a small PE binary (e.g., hello.exe)
- Verify: decode -> emit C -> compile wasm -> run in browser
- Dependency: Phase 1 + Phase 3

**Task 4.2: Test with claude.exe**
- Full pipeline on the 597 MB binary
- Measure: decode time, emit time, compile time, link time
- Measure: final .wasm size
- Dependency: Task 4.1

**Task 4.3: Browser runtime**
- HTML page that loads .wasm
- Provides JS implementations for Win32 API stubs
- Maps PE sections into WASM memory on startup
- Dependency: Task 4.2
- Files: `src/PrTask.Client/wwwroot/wasm-runner.html`, `src/PrTask.Client/wwwroot/Js/wasm-loader.js`

### Phase 5: Optimization

**Task 5.1: sccache integration**
- Install sccache for compilation caching
- Subsequent builds only recompile changed functions
- Dependency: Task 4.2

**Task 5.2: Incremental transpilation**
- Hash each function's instruction bytes
- Only re-emit .c files for functions whose hash changed
- Skip unchanged .o files during recompile
- Dependency: Task 5.1

**Task 5.3: wasm-opt profile-guided optimization**
- Run profiling pass to identify hot functions
- Apply stronger optimization to hot paths
- Dependency: Task 4.2

---

## 6. Expected Results

### Compilation Performance

| Metric | Current (Roslyn) | New (Clang WASM) |
|--------|------------------|-------------------|
| Emit time | ~60 sec (CPU serial) | ~3 sec (GPU) or ~8 sec (CPU parallel) |
| Compile time | NEVER (OOM at 11 GB) | ~3-7 min |
| Peak memory | >11 GB (OOM) | ~2 GB (parallel clang, 8 processes * 250 MB) |
| Output | NONE | ~50-100 MB .wasm |
| Incremental rebuild | N/A | ~30 sec (only changed functions) |

### Output Characteristics

| Metric | Estimate |
|--------|----------|
| .wasm file size (uncompressed) | 50-100 MB |
| .wasm file size (brotli compressed) | 10-20 MB |
| Number of WASM functions | ~63,000 |
| WASM memory usage | 256 MB linear memory |
| Browser load time | 2-5 sec (with streaming compilation) |
| Runtime performance | ~30-50% of native x86 (typical for AOT recompilation) |

### Risk Assessment

| Risk | Impact | Mitigation |
|------|--------|------------|
| Intel iGPU too weak for GPU emission | Low: emission is small part of total time | CPU parallel fallback (Task 2.5) |
| wasm-ld OOM with 63K objects | Medium | Batch into 630 files (Task 1.2) |
| Clang wasm32 codegen bugs with i64 | Low | Test with small binaries first (Task 4.1) |
| Dispatch table too large for WASM | Low | Binary search, no function pointer overhead |
| Win32 API stubs incomplete | High | Incremental: stub only called APIs |

---

## 7. Existing Assets at c:\work

### Directly Usable

| Path | Purpose |
|------|---------|
| `c:\work\iced` | Iced NuGet source (already used for decoding) |
| `c:\work\binaryen` | Binaryen source (build wasm-opt from it) |
| `c:\work\wabt` | WebAssembly Binary Toolkit (wat2wasm, wasm2wat for debugging) |
| `c:\work\emscripten` | Emscripten source (reference, may contain usable clang) |
| `c:\work\v86` | x86 emulator in browser (reference for Win32 stubs) |
| `c:\work\retrowin32` | Win32 emulator (reference for API implementations) |
| `c:\work\Win32Emu` | Win32 emulator (6548 files, rich API stubs) |

### Reference for Recompilation Patterns

| Path | Purpose |
|------|---------|
| `c:\work\N64Recomp` | Static recompiler: MIPS -> C -> native (exact same pattern!) |
| `c:\work\MarathonRecomp` | Game recompilation |
| `c:\work\PS2Recomp` | PS2 recompilation |
| `c:\work\UnleashedRecomp` | Game recompilation |
| `c:\work\Zelda64Recomp` | Zelda 64 recompilation |
| `c:\work\ia32rtools` | x86 recompilation tools |
| `c:\work\recompiler` | General recompiler framework |

### Reference for Binary Lifting

| Path | Purpose |
|------|---------|
| `c:\work\elfconv` | ELF -> LLVM IR -> WASM translator |
| `c:\work\remill` | Machine code -> LLVM IR lifter |
| `c:\work\mcsema` | x86/x64 -> LLVM IR lifter |
| `c:\work\retdec` | Retargetable decompiler |
| `c:\work\reko` | Binary -> C decompiler |
| `c:\work\rellic` | LLVM IR -> C decompiler |
| `c:\work\llvm-mctoll` | Binary -> LLVM IR lifter |

### Particularly Relevant: N64Recomp Pattern

N64Recomp does exactly what we need but for MIPS instead of x86-64:
1. Reads binary (N64 ROM)
2. Decodes MIPS instructions
3. Emits C code with a CPU context struct (`ctx->r4 = ADD32(ctx->r4, 0X20)`)
4. Compiles C with any C compiler
5. Links into native executable

Our pipeline is identical, just:
- Input: x86-64 PE binary (instead of MIPS ROM)
- Output: WASM (instead of native x86)
- Addition: GPU-accelerated emission step

---

## 8. Summary of Decisions

1. **Emit language**: C (not C#, not LLVM IR, not WASM text)
2. **C compiler**: Clang from WASI SDK (targets wasm32 directly)
3. **GPU API**: ComputeSharp (DirectX 12 compute, works on Intel iGPU)
4. **GPU task**: Text emission only (not compilation itself)
5. **WASM target**: wasm32 (not memory64, for performance + compatibility)
6. **Parallelism**: Ninja for build, GPU for emission, sccache for caching
7. **File strategy**: Batch 100 functions per .c file (630 files, not 63K)
8. **Linking**: wasm-ld with LTO
9. **Optimization**: Binaryen wasm-opt -O3
10. **Pattern**: Identical to N64Recomp but for x86-64 -> WASM

Sources:
- [ComputeSharp - .NET GPU via DirectX 12](https://github.com/Sergio0694/ComputeSharp)
- [WASM 3.0 - Memory64 standardized](https://webassembly.org/news/2025-09-17-wasm-3.0/)
- [Memory64 performance penalty](https://spidermonkey.dev/blog/2025/01/15/is-memory64-actually-worth-using.html)
- [N64Recomp - static recompiler to C](https://github.com/N64Recomp/N64Recomp)
- [elfconv - binary to WASM translator](https://github.com/yomaytk/elfconv)
- [Remill - machine code to LLVM IR](https://github.com/lifting-bits/remill)
- [WASI SDK](https://github.com/WebAssembly/wasi-sdk)
- [Emscripten module splitting](https://emscripten.org/docs/optimizing/Module-Splitting.html)
- [Emscripten codegen bottleneck](https://github.com/emscripten-core/emscripten/issues/5509)
- [LLVM 20.1 GPU advances](https://www.webpronews.com/llvm-20-1-arrives-with-major-c-and-gpu-advances-setting-the-stage-for-the-next-era-of-compiler-infrastructure/)
- [wasm-ld documentation](https://lld.llvm.org/WebAssembly.html)
- [WebGPU compute fundamentals](https://webgpufundamentals.org/webgpu/lessons/webgpu-compute-shaders.html)
- [DirectX Compute Shader overview](https://learn.microsoft.com/en-us/windows/win32/direct3d11/direct3d-11-advanced-stages-compute-shader)
- [Compile C to WASM without Emscripten](https://surma.dev/things/c-to-webassembly/)
- [WASM indirect calls](https://eli.thegreenplace.net/2023/playing-with-indirect-calls-in-webassembly/)
- [Practical x86 binary recompilation](https://mp2.dk/blog/blog/2014/04/14/practical-and-portable-binary-recompilation/)
- [GPU driven text output](https://jorenjoestar.github.io/post/gpu_driven_text/gpu_driven_text/)
- [Vulkan compute shaders](https://docs.vulkan.org/tutorial/latest/11_Compute_Shader.html)
- [NVIDIA CUDA LLVM compiler](https://developer.nvidia.com/cuda-llvm-compiler)
- [distcc distributed compilation](https://en.wikipedia.org/wiki/Distcc)
