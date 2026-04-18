# GPU+CPU Accelerated ILC (NativeAOT) Compilation Plan

## 1. Current ILC/NativeAOT Architecture

### 1.1 Compilation Pipeline Overview

The ILC (IL Compiler) for NativeAOT follows a multi-phase pipeline:

```
IL Assemblies
    -> TypeSystem Context (load metadata, resolve types)
    -> ILScanner (optional, whole-program analysis via dependency graph)
    -> DependencyGraph.ComputeMarkedNodes() (GC-like mark algorithm)
        -> ComputeDependencyRoutine event fires batches of deferred nodes
            -> RyuJitCompilation.ComputeDependencyNodeDependencies()
                -> Per-method: CorInfoImpl.CompileMethod()
                    -> JitCompileMethod() [P/Invoke into clrjit.dll]
                        -> CILJit::compileMethod() [native C++]
                            -> jitNativeCode() -> Compiler::compCompile()
                                -> ~60 JIT phases per method
    -> FileLayoutOptimizer.ApplyProfilerGuidedMethodSort()
    -> ObjectWriter.EmitObject() (COFF/ELF/Mach-O/WASM output)
```

### 1.2 Key Source Locations

| Component | Path |
|-----------|------|
| Entry point | `ILCompiler\Program.cs` |
| CLI options (--parallelism) | `ILCompiler\ILCompilerRootCommand.cs` |
| Base compilation builder | `tools\Common\Compiler\CompilationBuilder.cs` |
| AOT compilation builder | `ILCompiler.Compiler\Compiler\CompilationBuilder.Aot.cs` |
| RyuJIT compilation | `ILCompiler.RyuJit\Compiler\RyuJitCompilation.cs` |
| RyuJIT builder | `ILCompiler.RyuJit\Compiler\RyuJitCompilationBuilder.cs` |
| CorInfoImpl (JIT interface) | `tools\Common\JitInterface\CorInfoImpl.cs` |
| CorInfoImpl RyuJIT partial | `ILCompiler.RyuJit\JitInterface\CorInfoImpl.RyuJit.cs` |
| IL Scanner | `ILCompiler.Compiler\Compiler\ILScanner.cs` |
| Dependency analyzer | `ILCompiler.DependencyAnalysisFramework\DependencyAnalyzer.cs` |
| Object writer | `tools\Common\Compiler\ObjectWriter\ObjectWriter.cs` |
| JIT wrapper (native) | `jitinterface\jitwrapper.cpp` |
| RyuJIT compiler (native) | `coreclr\jit\compiler.cpp` |
| RyuJIT entry | `coreclr\jit\ee_il_dll.cpp` |

### 1.3 Current Parallelism Model

**Default parallelism**: `Math.Min(24, Environment.ProcessorCount)` (capped at 24 threads).

**RyuJitCompilation.ComputeDependencyNodeDependencies()**:
- Collects `MethodCodeNode` items from the dependency graph batch
- If `_parallelism == 1`: iterates sequentially
- If `_parallelism > 1`: uses `Parallel.ForEach` with `MaxDegreeOfParallelism`
- Each thread gets its own `CorInfoImpl` via `ConditionalWeakTable<Thread, CorInfoImpl>`
- Each `CorInfoImpl` holds its own native JIT handle (`_jit` pointer)

**ILScanner.ComputeDependencyNodeDependencies()**:
- Same pattern: `Parallel.ForEach` for scanning methods

**ReadyToRunCodegenCompilation** (crossgen2):
- Uses manual thread pool with `Thread` objects
- Creates `CorInfoImpl[]` array sized to parallelism
- Lock-based work stealing from shared enumerator

**Key constraint**: Each `CorInfoImpl` instance is NOT thread-safe. One JIT context per thread is required. The native `clrjit.dll` uses thread-local storage (JitTls) internally.

### 1.4 Method Compilation Independence

Each method compilation is **fully independent** after the dependency graph resolves which methods need compilation:

- `CorInfoImpl.CompileMethod(MethodCodeNode)` is self-contained
- It calls `JitCompileMethod()` which P/Invokes into native `clrjit.dll`
- The JIT produces a byte array of native code + relocations
- The output is stored on the `MethodCodeNode` (thread-safe via node design)
- No shared mutable state between method compilations (each CorInfoImpl has its own buffers)

This means **method compilation is embarrassingly parallel** and is the primary target for GPU offload.

### 1.5 JIT Compilation Phases (Per Method)

Inside `Compiler::compCompile()`, each method goes through ~60 phases:

1. **PHASE_PRE_IMPORT** - Pre-import setup
2. **PHASE_IMPORTATION** - IL to IR (GenTree) conversion
3. **PHASE_MORPH_INIT/INLINE/GLOBAL** - Tree morphing, inlining
4. **PHASE_GS_COOKIE** - Security cookie insertion
5. **PHASE_COMPUTE_BLOCK_WEIGHTS** - Profile-guided block weights
6. **PHASE_OPTIMIZE_LAYOUT** - Basic block layout
7. **PHASE_FIND_LOOPS** - Loop detection
8. **PHASE_SSA_BUILD** - SSA construction
9. **PHASE_VN_BASED_DEAD_STORE_REMOVAL** - Value numbering
10. **PHASE_OPTIMIZE_INDEX_CHECKS** - Bounds check elimination
11. **PHASE_CSE** - Common subexpression elimination
12. **PHASE_ASSERTION_PROP** - Assertion propagation
13. **PHASE_IF_CONVERSION** - If-conversion
14. **PHASE_LSRA** - Linear scan register allocation
15. **PHASE_GENERATE_CODE** - Final native code emission

All phases for a single method run sequentially. Cross-method parallelism is the opportunity.

## 2. Where GPU Acceleration Can Be Added

### 2.1 Tier 1: Method-Level Parallelism (Primary Target)

**What**: Dispatch the compilation of independent methods across GPU compute units AND CPU cores simultaneously.

**Why it works**: After dependency analysis identifies the method set, each method compilation is independent. With 62,996 methods, this is a massive parallel workload.

**GPU role**: The GPU does NOT run RyuJIT (which is native C++ code). Instead, the GPU handles the **data-parallel preprocessing and postprocessing** that surrounds method compilation:

- IL bytecode parsing and basic block graph construction (PHASE_IMPORTATION equivalent)
- Instruction encoding and relocation resolution
- Method body hashing for deduplication
- Control flow graph analysis
- Liveness analysis (bit-vector operations across basic blocks)
- Register pressure estimation for scheduling decisions

### 2.2 Tier 2: IL Scanning Acceleration

**What**: The ILScanner (`ILScanner.CompileSingleMethod`) runs `ILImporter.Import()` on each method to discover dependencies. This is IL parsing and type resolution -- highly data-parallel.

**GPU role**: Batch IL bytecode streams to GPU, parse opcodes, extract type/method tokens, resolve dependencies. Return dependency lists to CPU for graph updates.

### 2.3 Tier 3: Object Writing Acceleration

**What**: `ObjectWriter.EmitObject()` iterates all nodes sequentially, calling `node.GetData()` and writing sections.

**GPU role**: Parallel section data assembly, relocation patching, checksum computation.

### 2.4 Tier 4: Dependency Graph Acceleration

**What**: The `DependencyAnalyzer.ProcessMarkStack()` is currently single-threaded (mark-sweep GC-like algorithm with conditional and dynamic edges).

**GPU role**: Batch static dependency resolution. For each newly marked node, resolve all its static dependencies on GPU in parallel. The conditional/dynamic edges still need CPU orchestration.

## 3. How to Parallelize Method Compilation Across GPU+CPU

### 3.1 Architecture: Heterogeneous Work Scheduler

```
                    +-----------------------+
                    |  DependencyAnalyzer   |
                    |  (single-threaded     |
                    |   mark-sweep)         |
                    +-----------+-----------+
                                |
                    ComputeDependencyRoutine event
                                |
                    +-----------v-----------+
                    | HeterogeneousScheduler |
                    | (replaces Parallel.   |
                    |  ForEach)             |
                    +-----------+-----------+
                       /                  \
          +-----------v--+          +-----v-----------+
          | CPU Worker   |          | GPU Batch       |
          | Pool         |          | Pipeline        |
          | (CorInfoImpl |          | (ComputeSharp   |
          |  per thread) |          |  DirectX 12)    |
          +---+-----+---+          +---+-----+-------+
              |     |                  |     |
         RyuJIT  RyuJIT         IlParse  LivenessCalc
         Method1  Method2       Batch    RegPressure
              |     |                  |     |
              v     v                  v     v
          +---+-----+---+          +---+-----+-------+
          | MethodCodeNode|        | PreprocessedData |
          | (native code) |        | (fed back to CPU |
          +---------------+        |  JIT workers)    |
                                   +-----------------+
```

### 3.2 GPU Work Items (ComputeSharp / DirectX 12 Compute)

The GPU cannot run RyuJIT directly (it is a complex C++ compiler with deep call stacks, allocations, and pointer-heavy data structures). Instead, the GPU accelerates **data-parallel preprocessing**:

#### A. IL Bytecode Preprocessing (GPU Compute Shader)

Input: Array of IL method bodies (byte arrays + metadata tokens)
Output: Per-method basic block graphs, opcode histograms, branch targets

```csharp
[ThreadGroupSize(DefaultThreadGroupSizes.X)]
[GeneratedComputeShaderDescriptor]
public readonly partial struct IlParseKernel(
    ReadWriteBuffer<byte> IlBodies,
    ReadWriteBuffer<int> MethodOffsets,
    ReadWriteBuffer<int> MethodLengths,
    ReadWriteBuffer<BasicBlockInfo> OutputBlocks,
    ReadWriteBuffer<int> OutputBlockCounts) : IComputeShader
{
    public void Execute()
    {
        int MethodIndex = ThreadIds.X;
        int Offset = IlBodies[MethodOffsets[MethodIndex]];
        int Length = MethodLengths[MethodIndex];
        int BlockCount = 0;
        // ... parse IL opcodes, identify basic blocks, branch targets
    }
}
```

#### B. Liveness Analysis (GPU Compute Shader)

Input: Basic block graphs with variable references
Output: Live-in/live-out bit vectors per basic block

This is a classic iterative dataflow problem that maps well to GPU:
- Each basic block is a thread
- Iterate until convergence (bit-vector AND/OR across edges)
- GPU handles thousands of blocks across hundreds of methods simultaneously

#### C. Method Body Hashing for Deduplication

Input: Compiled method code bytes
Output: Hash values for `ObjectDataInterner` (method body folding)

```csharp
[ThreadGroupSize(DefaultThreadGroupSizes.X)]
[GeneratedComputeShaderDescriptor]
public readonly partial struct MethodHashKernel(
    ReadWriteBuffer<byte> CodeBodies,
    ReadWriteBuffer<int> CodeOffsets,
    ReadWriteBuffer<int> CodeLengths,
    ReadWriteBuffer<ulong> OutputHashes) : IComputeShader
{
    public void Execute()
    {
        int MethodIndex = ThreadIds.X;
        // FNV-1a or xxHash on code bytes
    }
}
```

#### D. Relocation Resolution (GPU Compute Shader)

Input: Relocation entries from all compiled methods
Output: Patched code with resolved addresses

### 3.3 CPU+GPU Coordination

```csharp
public sealed class HeterogeneousCompilationScheduler
{
    private readonly int _CpuParallelism;
    private readonly GpuDevice _GpuDevice;
    private readonly GraphicsDevice _ComputeDevice;

    public void CompileMethodBatch(List<MethodCodeNode> Methods)
    {
        var GpuPreprocessTask = Task.Run(() => GpuPreprocessBatch(Methods));

        var CpuCompileTask = Task.Run(() =>
        {
            Parallel.ForEach(
                Methods,
                new ParallelOptions { MaxDegreeOfParallelism = _CpuParallelism },
                CompileSingleMethodOnCpu);
        });

        Task.WhenAll(GpuPreprocessTask, CpuCompileTask).Wait();

        var GpuPostprocessTask = Task.Run(() => GpuPostprocessBatch(Methods));
        GpuPostprocessTask.Wait();
    }
}
```

## 4. How to Use ComputeSharp or Direct DirectX 12 Compute

### 4.1 ComputeSharp Approach (Recommended)

ComputeSharp provides a C#-native GPU compute API on top of DirectX 12:

```xml
<PackageReference Include="ComputeSharp" Version="3.0.0" />
```

**Advantages**:
- Pure C# compute shaders (no HLSL files)
- Automatic GPU device selection
- ReadWriteBuffer<T> for data transfer
- Works on Windows with any DirectX 12 GPU
- Source-generated shader compilation

**Integration point**: New project `ILCompiler.Gpu` referenced by `ILCompiler.RyuJit`:

```
ILCompiler.RyuJit.csproj
    -> ILCompiler.Gpu.csproj (new)
        -> ComputeSharp NuGet
```

### 4.2 Direct DirectX 12 Compute (Alternative)

For maximum control, use `TerraFX.Interop.Windows` for raw D3D12 compute:

```xml
<PackageReference Include="TerraFX.Interop.Windows" Version="10.0.26100.3" />
```

This gives direct access to:
- `ID3D12Device::CreateComputePipelineState`
- `ID3D12CommandQueue` for async compute
- `ID3D12Resource` for GPU buffers
- Pre-compiled HLSL compute shaders (.cso files)

### 4.3 Hybrid Approach

Use ComputeSharp for the C# compute shaders, but fall back to CPU if no DirectX 12 GPU is detected. The requirement is that GPU+CPU MUST be used when available.

## 5. Making GPU+CPU a REQUIREMENT

### 5.1 Startup Detection

In `ILCompiler\Program.cs`, before compilation begins:

```csharp
public int Run()
{
    var GpuCapability = GpuDeviceDetector.Detect();
    if (!GpuCapability.HasDirectX12)
        throw new InvalidOperationException(
            "GPU-accelerated compilation requires a DirectX 12 capable GPU. " +
            "No compatible GPU was detected.");

    int CpuParallelism = Environment.ProcessorCount;
    int GpuCoreCount = GpuCapability.ComputeUnits;

    Logger.LogMessage(
        $"Compilation will use {CpuParallelism} CPU cores + " +
        $"{GpuCoreCount} GPU compute units ({GpuCapability.DeviceName})");

    // ... rest of compilation
}
```

### 5.2 New CLI Option

In `ILCompilerRootCommand.cs`:

```csharp
public Option<string> GpuDevice { get; } =
    new("--gpu-device") { Description = "GPU device index for compute acceleration (required)" };

public Option<bool> NoGpu { get; } =
    new("--no-gpu") { Description = "Disable GPU requirement (CPU-only fallback, NOT recommended)" };
```

### 5.3 Build-Time Enforcement

In the MSBuild integration, the NativeAOT publish step must validate GPU availability:

```xml
<Target Name="ValidateGpuForNativeAot" BeforeTargets="RunILCompiler">
  <Error Condition="'$(NativeAotGpuDisabled)' != 'true'"
         Text="NativeAOT compilation requires a DirectX 12 GPU. Set NativeAotGpuDisabled=true to use CPU-only mode." />
</Target>
```

## 6. WASM-Specific Pipeline

### 6.1 Current WASM Support

There is **no ILCompiler.LLVM directory** in this runtime source tree. The LLVM/WASM backend exists in the `dotnet/runtimelab` repository (experimental branch), not in mainline `dotnet/runtime`.

The mainline runtime does have:
- `WasmObjectWriter.cs` in `tools\Common\Compiler\ObjectWriter\` -- writes WASM binary format
- `emitfmtswasm.h` and `emitwasm.h` in `coreclr\jit\` -- JIT emit tables for WASM target
- `Target_Wasm\ImportThunk.cs` in ReadyToRun

### 6.2 WASM Compilation Path (When Available)

The WASM pipeline (from runtimelab) is:
```
IL -> LLVM IR (via ILCompiler.LLVM) -> LLVM Backend -> WASM binary
```

GPU acceleration for WASM:
- **IL to LLVM IR translation**: Data-parallel per method, same as RyuJIT path
- **LLVM optimization passes**: LLVM itself can be parallelized (ThinLTO)
- **WASM code generation**: GPU can assist with instruction encoding

### 6.3 GPU Acceleration for WASM Path

Same `HeterogeneousScheduler` applies. The key difference is that instead of calling `JitCompileMethod()` (RyuJIT native), the WASM path calls LLVM APIs. The GPU preprocessing (IL parsing, liveness, CFG analysis) is identical.

## 7. Estimated Speedup for 62,996 Methods

### 7.1 Current Performance Profile

Typical NativeAOT compilation breakdown (estimated from profiling data):
- **Dependency analysis**: 10-15% of total time (single-threaded graph walk)
- **IL scanning**: 5-10% (parallelizable, currently uses Parallel.ForEach)
- **Method compilation (RyuJIT)**: 60-70% (parallelizable, currently capped at 24 threads)
- **Object writing**: 10-15% (single-threaded sequential write)
- **Other (metadata, layout)**: 5%

### 7.2 With GPU+CPU Acceleration

Assuming a system with 32 CPU cores + GPU with 4096 shader cores:

| Phase | Current (24 threads) | GPU+CPU | Speedup |
|-------|---------------------|---------|---------|
| Dependency analysis | 1.0x (single-threaded) | 1.0x (inherently sequential) | 1.0x |
| IL scanning | ~12x | ~24x (GPU batch IL parse) | 2.0x |
| Method compilation | ~18x (24 threads, overhead) | ~30x (32 CPU cores, no cap) | 1.7x |
| GPU preprocessing | N/A | Runs concurrently with CPU JIT | Free |
| Object writing | 1.0x | ~4x (GPU relocation + hashing) | 4.0x |
| **Overall** | **~8x** | **~14x** | **~1.75x** |

### 7.3 Key Speedup Sources

1. **Remove 24-thread cap**: Current code caps at 24 threads. Modern systems have 32-128 cores. Removing the cap and using all CPU cores gives immediate improvement.

2. **GPU-accelerated IL preprocessing**: Parsing 62,996 IL method bodies on GPU (4096 shader cores) completes in microseconds vs milliseconds on CPU.

3. **GPU-accelerated post-processing**: Relocation patching, hashing for deduplication, section assembly -- all data-parallel.

4. **Pipeline overlap**: GPU preprocessing runs concurrently with CPU JIT compilation. While CPU cores compile methods N through N+32, GPU preprocesses methods N+33 through N+33+4096.

5. **Memory bandwidth**: GPU has 500+ GB/s memory bandwidth vs ~50 GB/s for CPU. Bulk data operations (hashing, copying, patching) benefit enormously.

### 7.4 Conservative Estimate for 62,996 Methods

| Metric | Current | With GPU+CPU |
|--------|---------|-------------|
| Methods compiled | 62,996 | 62,996 |
| Compilation time (est.) | 120s | 70s |
| IL scan time (est.) | 15s | 7s |
| Object write time (est.) | 18s | 5s |
| **Total** | **~160s** | **~90s** |
| **Speedup** | **1.0x** | **~1.8x** |

The speedup is modest because the RyuJIT native code generation (the dominant phase) cannot run on GPU. The GPU accelerates everything around JIT but not JIT itself. The bigger win is removing the 24-thread cap and fully utilizing all CPU cores.

## 8. Step-by-Step Implementation Tasks

### Phase 1: Remove Artificial Parallelism Cap (Week 1)

**Files to modify:**
- `ILCompiler\ILCompilerRootCommand.cs` (line 417): Remove `Math.Min(24, ...)` cap
- `crossgen2\Crossgen2RootCommand.cs` (line 375): Same cap removal

```csharp
private static int MakeParallelism(ArgumentResult Result)
{
    if (Result.Tokens.Count > 0)
        return int.Parse(Result.Tokens[0].Value);

    return Environment.ProcessorCount;
}
```

### Phase 2: Create ILCompiler.Gpu Project (Week 1-2)

Create new project `ILCompiler.Gpu\ILCompiler.Gpu.csproj`:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="ComputeSharp" Version="3.0.0" />
  </ItemGroup>
</Project>
```

Key classes to create:
- `GpuDeviceDetector.cs` - Enumerate DirectX 12 devices
- `GpuCompilationContext.cs` - Manage GPU buffers and dispatch
- `IlParseKernel.cs` - IL bytecode parsing compute shader
- `LivenessKernel.cs` - Liveness analysis compute shader
- `HashKernel.cs` - Method body hashing compute shader
- `RelocationKernel.cs` - Relocation patching compute shader

### Phase 3: Integrate GPU Device Detection (Week 2)

**Files to modify:**
- `ILCompiler\Program.cs`: Add GPU detection at startup
- `ILCompiler\ILCompilerRootCommand.cs`: Add `--gpu-device` and `--no-gpu` options
- `tools\Common\Compiler\CompilationBuilder.cs`: Add `UseGpuDevice()` method

### Phase 4: Implement HeterogeneousScheduler (Week 2-3)

**Files to modify:**
- `ILCompiler.RyuJit\Compiler\RyuJitCompilation.cs`: Replace `CompileMultiThreaded` with GPU+CPU scheduler
- `ILCompiler.Compiler\Compiler\ILScanner.cs`: Replace `CompileMultiThreaded` with GPU+CPU scanner

New `RyuJitCompilation.CompileHeterogeneous()`:

```csharp
private void CompileHeterogeneous(List<MethodCodeNode> MethodsToCompile)
{
    using var GpuContext = new GpuCompilationContext(_GpuDevice);

    var IlBodies = MethodsToCompile
        .Select(M => _compilation.GetMethodIL(M.Method))
        .ToArray();

    var GpuPreprocessTask = Task.Run(() =>
        GpuContext.PreprocessIlBatch(IlBodies));

    Parallel.ForEach(
        MethodsToCompile,
        new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount },
        CompileSingleMethod);

    GpuPreprocessTask.Wait();

    var GpuPostprocessTask = Task.Run(() =>
        GpuContext.PostprocessCodeBatch(MethodsToCompile));

    GpuPostprocessTask.Wait();
}
```

### Phase 5: Implement GPU Compute Kernels (Week 3-4)

#### A. IL Parse Kernel
- Input: Concatenated IL byte arrays with method offset table
- Output: Basic block boundary arrays, branch target arrays, opcode frequency histograms
- Thread mapping: 1 GPU thread per method (up to 62,996 threads)

#### B. Liveness Kernel
- Input: Basic block graphs from IL Parse
- Output: Live-in/live-out bit vectors
- Thread mapping: 1 GPU thread per basic block, iterative convergence

#### C. Hash Kernel
- Input: Compiled native code byte arrays
- Output: 64-bit hash per method for deduplication
- Thread mapping: 1 GPU thread per method

#### D. Relocation Kernel
- Input: Relocation entries + symbol address table
- Output: Patched code bytes
- Thread mapping: 1 GPU thread per relocation entry

### Phase 6: GPU-Accelerated Object Writing (Week 4-5)

**Files to modify:**
- `tools\Common\Compiler\ObjectWriter\ObjectWriter.cs`: Add GPU path in `EmitObject()`

Currently `EmitObject` iterates nodes sequentially. Change to:
1. Batch all `ObjectNode.GetData()` calls (can be parallel on CPU)
2. Send relocation data to GPU for batch patching
3. Use GPU for checksum computation
4. Write sections with GPU-computed data

### Phase 7: GPU-Accelerated IL Scanner (Week 5)

**Files to modify:**
- `ILCompiler.Compiler\Compiler\ILScanner.cs`

The IL scanner's `ILImporter.Import()` does IL parsing and type/method token resolution. The IL parsing portion can be offloaded to GPU, with token resolution remaining on CPU (requires type system access).

### Phase 8: Enforce GPU Requirement (Week 5-6)

**Files to modify:**
- `ILCompiler\Program.cs`: Fail if no GPU detected (unless `--no-gpu`)
- MSBuild targets: Add `ValidateGpuForNativeAot` target
- Documentation: Update NativeAOT docs to list GPU as requirement

### Phase 9: WASM Backend Integration (Week 6-7, if runtimelab available)

If/when the LLVM backend is available:
- Same `HeterogeneousScheduler` for IL-to-LLVM-IR translation
- GPU preprocessing identical to RyuJIT path
- LLVM's own parallelism (ThinLTO) runs on CPU alongside GPU work

### Phase 10: Testing and Benchmarking (Week 7-8)

- Compile the runtime itself (62,996 methods) with GPU+CPU
- Compare against CPU-only baseline
- Profile GPU utilization (should see >80% GPU compute occupancy)
- Test on various GPU configurations (integrated Intel, NVIDIA, AMD)
- Validate correctness: output binaries must be bit-identical to CPU-only compilation

## 9. Risk Analysis

### 9.1 GPU Memory Limits
- 62,996 methods x ~1KB average IL = ~62MB IL data (fits easily in GPU VRAM)
- 62,996 methods x ~4KB average native code = ~252MB (fits in most GPUs)
- Integrated GPUs with shared memory: no issue (uses system RAM)

### 9.2 CPU-GPU Transfer Overhead
- PCIe 4.0 x16: ~25 GB/s bandwidth
- Transferring 62MB of IL data: ~2.5ms
- Transferring 252MB of native code: ~10ms
- Transfer overhead is negligible compared to compilation time

### 9.3 JIT Cannot Run on GPU
- RyuJIT is a complex C++ codebase with deep recursion, malloc, pointer graphs
- GPU shader cores cannot execute this type of code
- The GPU handles only data-parallel preprocessing/postprocessing
- This limits the maximum theoretical speedup

### 9.4 Diminishing Returns
- With 62,996 methods and 32+ CPU cores, each core compiles ~2000 methods
- Adding GPU preprocessing saves ~10-20% per method (IL parse, liveness)
- Net improvement is real but not transformative (1.5-2x overall)
- The biggest immediate win is simply removing the 24-thread cap

## 10. File Manifest (All Files to Create or Modify)

### New Files
| File | Purpose |
|------|---------|
| `ILCompiler.Gpu\ILCompiler.Gpu.csproj` | GPU acceleration project |
| `ILCompiler.Gpu\GpuDeviceDetector.cs` | DirectX 12 device enumeration |
| `ILCompiler.Gpu\GpuCompilationContext.cs` | GPU buffer and dispatch management |
| `ILCompiler.Gpu\Kernels\IlParseKernel.cs` | IL bytecode parsing shader |
| `ILCompiler.Gpu\Kernels\LivenessKernel.cs` | Dataflow liveness analysis shader |
| `ILCompiler.Gpu\Kernels\HashKernel.cs` | Method body hashing shader |
| `ILCompiler.Gpu\Kernels\RelocationKernel.cs` | Relocation patching shader |
| `ILCompiler.Gpu\HeterogeneousScheduler.cs` | CPU+GPU work distribution |

### Modified Files
| File | Change |
|------|--------|
| `ILCompiler\ILCompilerRootCommand.cs` | Remove 24-thread cap, add GPU options |
| `ILCompiler\Program.cs` | GPU detection, GPU requirement enforcement |
| `ILCompiler\ILCompiler.csproj` | Reference ILCompiler.Gpu |
| `ILCompiler.RyuJit\Compiler\RyuJitCompilation.cs` | Replace Parallel.ForEach with HeterogeneousScheduler |
| `ILCompiler.RyuJit\Compiler\RyuJitCompilationBuilder.cs` | Pass GPU context to compilation |
| `ILCompiler.RyuJit\ILCompiler.RyuJit.csproj` | Reference ILCompiler.Gpu |
| `ILCompiler.Compiler\Compiler\ILScanner.cs` | GPU-accelerated IL scanning |
| `ILCompiler.Compiler\Compiler\CompilationBuilder.Aot.cs` | Add UseGpuDevice() |
| `tools\Common\Compiler\CompilationBuilder.cs` | Add GPU device field |
| `tools\Common\Compiler\ObjectWriter\ObjectWriter.cs` | GPU-accelerated object writing |
| `crossgen2\Crossgen2RootCommand.cs` | Remove 24-thread cap |
