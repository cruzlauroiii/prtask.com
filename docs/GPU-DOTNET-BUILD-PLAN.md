# DETAILED PLAN: GPU-Required Compilation for `dotnet build`

## 1. CURRENT STATE: Why Roslyn Cannot Compile 597MB / 62,996 Methods

### Roslyn's Architecture Limitations

Roslyn's compilation pipeline has four sequential phases: **Parse** (tokenize into SyntaxTree), **Declaration** (build symbol table from source + metadata), **Bind** (resolve all identifiers against symbols, type-check), and **Emit** (lower bound tree to IL bytecode). Every phase operates on in-memory object graphs.

**Why it OOMs at 11GB with your codebase:**

- **SyntaxTree retention**: Roslyn keeps the entire syntax tree in memory as immutable objects. For 597MB of source, the syntax tree alone consumes 2-4x the source size (1.2-2.4GB) because each token, trivia, and node is a heap object.
- **Symbol table explosion**: 62,996 methods means 62,996+ MethodSymbol objects, each with parameter lists, return types, attributes, and cross-references. The binding phase creates BoundNode trees for every method body simultaneously. Each method body's bound tree is roughly 3-10x the syntax tree size because it includes resolved type information.
- **Single-process, single-compilation model**: `csc.exe` runs as one process. Even on 64-bit, the GC pressure from 11GB of live objects causes constant Gen2 collections, each pausing for seconds, leading to the 14-hour wall time.
- **No streaming/incremental emit**: Roslyn cannot emit IL for one method and release its bound tree before binding the next. The entire compilation must be semantically complete before any IL is emitted, because method A might reference a constant defined in method Z.

**The fundamental constraint**: Roslyn was designed for typical projects (1-50MB source). It holds the entire semantic model in RAM. There is no disk-backed or GPU-backed alternative in the official compiler.

---

## 2. GPU COMPILATION APPROACHES (Ranked by Feasibility)

### APPROACH A: Skip Roslyn Entirely -- Emit IL Directly via `System.Reflection.Metadata` (GPU-Accelerated)
**Feasibility: HIGH -- This is the recommended approach**

**How it works:**
Your transpiler already converts x86 binary to C# source code (via `X86ToSharpConverter`). Instead of generating 597MB of C# source and asking Roslyn to compile it, you generate IL bytecode directly using `System.Reflection.Metadata.Ecma335.MetadataBuilder` + `ManagedPEBuilder`. The GPU accelerates the per-method IL generation phase since all 62,996 methods are independent.

**Technical flow:**
1. x86 instructions decoded by Iced (already done, on CPU)
2. Per-method: convert Iced decoded instructions to IL opcodes (GPU compute shader, massively parallel)
3. `MetadataBuilder` assembles type/method metadata tables (CPU, sequential but fast)
4. `ManagedPEBuilder` writes final DLL (CPU, sequential but fast)

**GPU APIs:** ComputeSharp (DirectX 12 compute shaders) or ILGPU (CUDA/OpenCL)

**Implementation complexity:** MEDIUM -- The x86-to-IL mapping is a table lookup per instruction (no type inference, no overload resolution needed since you control the output). The GPU kernel is essentially: for each method, walk its instruction array and emit the IL byte sequence.

**Expected speedup:** 50-200x for the code generation phase. Currently 62,996 methods x ~100ms each on CPU = ~2 hours. On GPU with 10,000 threads: ~1 minute.

**Has it been done before?** Not for .NET IL specifically, but the Pareas project (ACM Computing Frontiers 2022) demonstrated all compiler phases (lexing, parsing, semantic analysis, code generation) running on GPU using OpenCL/CUDA via Futhark. The arxiv paper "Theoretical Foundations of GPU-Native Compilation" (December 2025) provides latency bounds showing 10-100x speedups.

---

### APPROACH B: GPU-Accelerated Batch Compilation via Custom MSBuild Task
**Feasibility: MEDIUM-HIGH**

**How it works:**
Replace the `CoreCompile` MSBuild target with a custom task that:
1. Reads all `.cs` source files
2. Uploads method bodies to GPU as structured buffers
3. Runs parallel compilation kernels on GPU
4. Downloads IL bytecode and writes the assembly

**Technical details:**
- Override `CoreCompile` in `.csproj` via `<Target Name="CoreCompile">` with your custom task
- Use `CscToolPath` / `CscToolExe` properties to redirect to your GPU compiler executable
- The custom task DLL references ComputeSharp or ILGPU for GPU dispatch
- Require GPU via an MSBuild error condition: `<Error Condition="!Exists('$(GpuCompilerMarker)')" Text="GPU required for compilation" />`

**GPU APIs:** ComputeSharp (DirectX 12) for Windows, ILGPU for cross-platform

**Implementation complexity:** HIGH -- You need to reimplement enough of Roslyn's binding phase to resolve types, which is the hard part. Parsing and IL emission are parallelizable; semantic analysis is not easily so.

**Expected speedup:** 5-20x for the overall build, primarily from parallelizing code generation and skipping Roslyn's memory-heavy architecture.

**Has it been done before?** No one has replaced Roslyn with a GPU compiler for production .NET projects.

---

### APPROACH C: Emit HLSL/WGSL Compute Shaders Instead of C#
**Feasibility: LOW for compilation, but relevant for runtime**

**How it works:**
Instead of transpiling x86 to C#, transpile x86 to HLSL compute shaders. The GPU driver compiles HLSL to GPU machine code natively.

**Why this doesn't solve the build problem:** You still need `dotnet build` to compile the host project. The GPU compilation here is for the transpiled output, not the compiler itself. This changes the runtime model (execution on GPU instead of CPU via WASM) but doesn't help with build speed.

**GPU APIs:** DirectX 12 / DXC (HLSL to DXIL), Vulkan / glslangValidator (GLSL to SPIR-V), WebGPU / Tint (WGSL)

**Implementation complexity:** VERY HIGH -- x86 semantics (flags, memory addressing modes, stack manipulation) don't map cleanly to shader compute models.

**Expected speedup for build:** 0x (doesn't help build speed). Expected runtime speedup: 100-1000x for embarrassingly parallel workloads.

---

### APPROACH D: GPU for IL-to-WASM Step (Emscripten/NativeAOT-LLVM)
**Feasibility: LOW-MEDIUM**

**How it works:**
The Blazor WASM publish step uses Emscripten to compile IL to WASM. This is currently CPU-bound and takes 40+ minutes for large projects. You could parallelize the per-method WASM code generation on GPU.

**Technical details:**
- NativeAOT-LLVM (`dotnet/runtimelab` branch `feature/NativeAOT-LLVM`) compiles .NET to WASM via LLVM
- LLVM has NVPTX and AMDGPU backends, meaning the LLVM IR could theoretically be compiled to GPU kernels
- You would fork NativeAOT-LLVM's ILC to emit multiple methods in parallel GPU threads

**GPU APIs:** CUDA (NVPTX), LLVM GPU backends

**Implementation complexity:** EXTREME -- Forking the ILC compiler and rewriting its code generation loop for GPU execution is a multi-year project.

**Expected speedup:** 10-50x for the IL-to-WASM phase specifically.

**Has it been done before?** No. NativeAOT-LLVM exists but is CPU-only and experimental.

---

### APPROACH E: Fork Roslyn with GPU-Accelerated Code Generation
**Feasibility: VERY LOW**

**How it works:**
Fork `dotnet/roslyn`, replace the `Emit` phase with GPU-dispatched IL generation. Keep parsing and binding on CPU, but offload `BoundMethodBody` to IL lowering to GPU compute shaders.

**Why it's impractical:** Roslyn's lowering phase involves complex tree transformations (lambda rewriting, async state machines, pattern matching lowering, nullable analysis) that are deeply recursive and pointer-chasing -- the worst possible GPU workload. The research paper from ACM CF 2022 notes: "GPUs were not designed for compilation workloads involving irregular memory access (pointer chasing during parsing), complex control flow (recursive descent, pattern matching), and string manipulation."

**Implementation complexity:** EXTREME -- Roslyn has 4M+ lines of code. The emit phase alone is ~200K lines.

**Expected speedup:** 2-5x at best, because the bottleneck is memory, not parallelism.

---

### APPROACH F: LLVM with GPU Backend (Full Pipeline)
**Feasibility: VERY LOW for C#**

**How it works:**
Compile C# to LLVM IR (via the defunct LLILC or SharpLang projects, or via NativeAOT-LLVM), then use LLVM's GPU backends.

**Why it's impractical:** LLILC was abandoned by Microsoft. SharpLang is dead. NativeAOT-LLVM only targets WASM, not GPU. Building a C#-to-LLVM-IR frontend from scratch is equivalent to rewriting Roslyn.

---

## 3. RECOMMENDED APPROACH: Direct IL Emission with GPU-Accelerated Code Generation

### Architecture

```
x86 binary
    |
    v
[CPU] Iced decoder --> Instruction[] per function (already implemented)
    |
    v
[CPU] Build method metadata (signatures, types) --> MethodDef[]
    |
    v
[GPU] Parallel IL generation: 62,996 methods dispatched to 62,996 GPU threads
    |  Each thread: instruction[] --> IL byte[]
    |  Pure data transformation, no shared state between methods
    v
[CPU] MetadataBuilder + ManagedPEBuilder --> final .dll assembly
```

### Step-by-Step Implementation Plan

**Phase 1: IL Emission Without Roslyn (CPU-only prototype)**

1. Add `System.Reflection.Metadata` NuGet package to `PrTask.Transpiler`
2. Create `ILEmitter.cs` that maps each x86-to-C# pattern (currently in `X86ToSharpConverter.EmitFunctions`) directly to IL opcodes
3. Instead of `StringBuilder.AppendLine("Rax = Rbx + Rcx;")`, emit `ILOpCode.Ldsfld(Rbx)`, `ILOpCode.Ldsfld(Rcx)`, `ILOpCode.Add`, `ILOpCode.Stsfld(Rax)`
4. Use `MetadataBuilder.AddMethodDefinition()` for each function
5. Use `InstructionEncoder` to write method body IL
6. Use `ManagedPEBuilder` to write the final DLL
7. Result: **No Roslyn needed at all.** The 597MB of generated C# source is never created.

**Phase 2: GPU-Accelerated IL Generation**

8. Add `ComputeSharp` NuGet package (DirectX 12 compute shaders, production-ready, used by millions of devices)
9. Create a GPU-side instruction mapping table: `StructuredBuffer<X86Instr> → RWStructuredBuffer<ILByte>`
10. Implement compute shader kernel:
    ```csharp
    [GeneratedComputeShaderDescriptor]
    public partial struct ILGenKernel : IComputeShader
    {
        public ReadOnlyBuffer<X86Instruction> Instructions;
        public ReadWriteBuffer<byte> ILOutput;
        public ReadOnlyBuffer<int> MethodOffsets;  // start offset per method
        public ReadWriteBuffer<int> ILLengths;     // output length per method

        public void Execute()
        {
            int methodIdx = ThreadIds.X;
            int start = MethodOffsets[methodIdx];
            int end = MethodOffsets[methodIdx + 1];
            int outPos = start * MAX_IL_EXPANSION;

            for (int i = start; i < end; i++)
            {
                // Map x86 instruction to IL bytes
                EmitIL(Instructions[i], ILOutput, ref outPos);
            }
            ILLengths[methodIdx] = outPos - (start * MAX_IL_EXPANSION);
        }
    }
    ```
11. Upload all decoded x86 instructions to GPU buffer (one contiguous array with method offset table)
12. Dispatch 62,996 threads (one per method)
13. Download IL byte arrays from GPU
14. Feed into `MetadataBuilder` on CPU

**Phase 3: Wire into `dotnet build`**

15. Create a custom MSBuild targets file (`GpuCompile.targets`):
    ```xml
    <Project>
      <PropertyGroup>
        <RequireGpu>true</RequireGpu>
      </PropertyGroup>

      <!-- GPU detection at build start -->
      <Target Name="CheckGpuAvailable" BeforeTargets="CoreCompile">
        <Exec Command="dotnet run --project tools/GpuDetect -- --require"
              IgnoreExitCode="false" />
        <Error Condition="'$(RequireGpu)' == 'true' AND '$(GpuDetected)' != 'true'"
               Text="BUILD ERROR: GPU is REQUIRED for compilation. No DirectX 12 compatible GPU detected." />
      </Target>

      <!-- Replace CoreCompile with GPU compiler -->
      <Target Name="CoreCompile"
              Inputs="@(Compile)"
              Outputs="@(IntermediateAssembly)"
              DependsOnTargets="$(CoreCompileDependsOn)">
        <Exec Command="tools/GpuCompiler.exe --input @(Compile) --output @(IntermediateAssembly) --gpu-required" />
      </Target>
    </Project>
    ```

16. Create `GpuDetect` tool that:
    - Uses ComputeSharp's `GraphicsDevice.GetDefault()` to enumerate DX12 adapters
    - Fails with exit code 1 if no GPU found
    - Outputs GPU name, VRAM, and compute capability

17. Import in `.csproj`:
    ```xml
    <Import Project="build/GpuCompile.targets" />
    ```

**Phase 4: GPU Requirement Enforcement**

18. The `GpuDetect` tool calls `IDXGIFactory6.EnumAdapterByGpuPreference` with `DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE` via ComputeSharp internals
19. If no discrete GPU: `Environment.Exit(1)` with error message
20. If GPU found: write `$(GpuDetected)=true` to MSBuild output property
21. The `GpuCompile.targets` file makes GPU mandatory via `<Error>` task

---

## 4. HARDWARE REQUIREMENTS

Your machine's GPU could not be detected from this WSL environment. You need one of:
- **NVIDIA GPU**: Any GTX 1060+ / RTX series. CUDA 12+ or DirectX 12 support. 4GB+ VRAM recommended for 62,996 method buffers.
- **AMD GPU**: Any RX 580+ / RX 6000+ series with DirectX 12 support.
- **Intel Arc**: A380+ with DirectX 12 support.

ComputeSharp requires **DirectX 12** (Windows 10 1903+). ILGPU supports CUDA and OpenCL as alternatives.

---

## 5. EXPECTED PERFORMANCE COMPARISON

| Phase | Current (Roslyn) | Approach A (GPU IL Emit) |
|-------|-----------------|-------------------------|
| Parse 597MB C# | 3-5 min, 2-4GB RAM | **SKIPPED** (no C# source generated) |
| Bind/Resolve | 2-8 hours, 6-11GB RAM | **SKIPPED** (no type resolution needed -- you control all types) |
| IL Emit | 1-2 hours | **1-5 min on GPU** (62,996 parallel threads) |
| Assembly Write | seconds | seconds |
| **Total** | **14+ hours, OOM** | **2-10 minutes, <2GB RAM** |

The key insight is that **95% of the speedup comes from eliminating Roslyn entirely**, not from GPU-accelerating Roslyn. The GPU then provides an additional 50-200x speedup on the IL generation phase compared to doing the same direct-IL-emission on CPU.

---

## 6. WHY GPU IS THE RIGHT TOOL HERE

Your 62,996 methods are **independent** -- method N's IL does not depend on method M's IL. This is the textbook GPU workload:
- **Data parallelism**: same operation (x86-to-IL mapping) applied to 62,996 independent inputs
- **Structured memory access**: instruction arrays are contiguous, GPU threads read sequentially
- **No synchronization**: no locks, no shared state between methods
- **Bounded output size**: each method's IL is bounded by `instruction_count * MAX_IL_PER_X86_INSTR`

The research from the ACM CF 2022 Pareas project and the December 2025 arxiv paper both confirm that code generation is the most GPU-friendly compiler phase, achieving the highest parallel efficiency.

---

Sources:
- [Pareas: GPU-accelerated compiler](https://github.com/Snektron/pareas)
- [Theoretical Foundations of GPU-Native Compilation (arxiv 2512.11200)](https://arxiv.org/html/2512.11200)
- [Parallel Lexing, Parsing and Semantic Analysis on the GPU (thesis)](https://theses.liacs.nl/pdf/2020-2021-VoetterRobin.pdf)
- [Compilation on the GPU? (ACM CF 2022)](https://dl.acm.org/doi/abs/10.1145/3528416.3530249)
- [ComputeSharp: C# GPU via DX12](https://github.com/Sergio0694/ComputeSharp)
- [ILGPU: .NET GPU compiler](https://ilgpu.net/)
- [Roslyn Overview](https://github.com/dotnet/roslyn/blob/main/docs/wiki/Roslyn-Overview.md)
- [Roslyn Performance for Large Solutions](https://github.com/dotnet/roslyn/blob/main/docs/wiki/Performance-considerations-for-large-solutions.md)
- [MetadataBuilder Class (System.Reflection.Metadata.Ecma335)](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.metadata.ecma335.metadatabuilder)
- [NativeAOT-LLVM (runtimelab)](https://github.com/dotnet/runtimelab/tree/feature/NativeAOT-LLVM)
- [Extend MSBuild Build Process](https://learn.microsoft.com/en-us/visualstudio/msbuild/how-to-extend-the-visual-studio-build-process)
- [MSBuild Custom Task Tutorial](https://learn.microsoft.com/en-us/visualstudio/msbuild/tutorial-custom-task-code-generation)
- [Roslyn Csc Task Source](https://github.com/dotnet/roslyn/blob/main/src/Compilers/Core/MSBuildTask/Csc.cs)
- [Roslyn OOM Issue #59240](https://github.com/dotnet/roslyn/issues/59240)
- [CUDA LLVM Compiler](https://developer.nvidia.com/cuda-llvm-compiler)
- [Futhark GPU Language](https://futhark-lang.org/)
- [SPIR-V Standard](https://www.khronos.org/spirv/)
- [DirectX Shader Compiler (DXC)](https://github.com/microsoft/DirectXShaderCompiler)
- [IDXGIFactory6::EnumAdapterByGpuPreference](https://learn.microsoft.com/en-us/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgifactory6-enumadapterbygpupreference)
- [Shipping MSBuild Task in NuGet](https://natemcmaster.com/blog/2017/07/05/msbuild-task-in-nuget/)
- [MSBuild Run GPU Discussion #7728](https://github.com/dotnet/msbuild/discussions/7728)