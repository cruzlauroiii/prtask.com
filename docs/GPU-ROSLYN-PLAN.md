# GPU + CPU Roslyn Compilation Plan

## 1. Current Roslyn Architecture

### 1.1 Compilation Pipeline Phases

The C# compiler executes in five sequential phases:

```
Parse -> Declare -> Bind -> Lower -> Emit
```

**Phase 1: Parse** (`CSharpCompiler.cs` lines 58-89)
- Converts source text into syntax trees via `LanguageParser`
- ALREADY PARALLELIZED: `RoslynParallel.For` over source files when `ConcurrentBuild=true`
- CPU bound, I/O bound on file reads
- Each file parsed independently

**Phase 2: Declare** (`SourceNamespaceSymbol_Completion.cs` lines 59-65)
- Builds symbol table from syntax trees
- ALREADY PARALLELIZED: `RoslynParallel.For` over namespace members when `ConcurrentBuild=true`
- Forces completion of all symbols in parallel

**Phase 3: Bind + Lower + Emit per Method** (`MethodCompiler.cs` -- 2527 lines, the core file)
- This is the DOMINANT phase, processing all 62,996 methods
- ALREADY PARALLELIZED at type level via `Task.Run` fork/join:
  - `VisitNamedType` pushes `CompileNamedTypeAsync` tasks onto `ConcurrentStack<Task>`
  - `WaitForWorkers` drains the stack
- For each method within a type (SEQUENTIAL within type):
  1. **Bind**: `BindMethodBody` -- semantic analysis, type checking
  2. **Flow Analysis**: `FlowAnalysisPass.Rewrite` -- definite assignment, nullable
  3. **Lower**: `LowerBodyOrInitializer` -- six sub-passes:
     - `LocalRewriter.Rewrite` -- desugar language features
     - `ExtensionMethodBodyRewriter` -- extension method transforms
     - `AsyncExceptionHandlerRewriter` -- await in catch/finally
     - `ClosureConversion.Rewrite` -- lambda capture
     - `IteratorRewriter.Rewrite` -- yield state machines
     - `AsyncRewriter.Rewrite` -- async state machines
  4. **Emit IL**: `GenerateMethodBody` -> `CodeGenerator.Generate` -> `ILBuilder.Realize`
  5. **Store**: `moduleBeingBuiltOpt.SetMethodBody` into `ConcurrentDictionary<IMethodSymbolInternal, IMethodBody>`

**Phase 4: Serialize** (`MetadataWriter.cs` line 2970, `PeWriter.cs`)
- NOT PARALLELIZED -- sequential `foreach` over all method definitions
- Line 3002 has a TODO comment: `"consider parallelizing these"`
- Writes IL bytes into `BlobBuilder`, writes metadata tables
- Single-threaded PE file generation

### 1.2 Current Parallelism Model

| Component | Parallelism | Mechanism |
|-----------|-------------|-----------|
| `RoslynParallel.For` | `Environment.ProcessorCount` | `Parallel.For` with `MaxDegreeOfParallelism` |
| `MethodCompiler` type-level | Unbounded `Task.Run` | `ConcurrentStack<Task>` fork/join |
| `MethodCompiler` method-level | NONE (sequential within type) | Direct calls |
| `MetadataWriter.SerializeMethodBodies` | NONE | Sequential foreach |
| `PeWriter.WritePeToStream` | NONE | Sequential |

### 1.3 Key Data Structures

- `ConcurrentDictionary<IMethodSymbolInternal, IMethodBody> _methodBodyMap` -- stores compiled IL bodies (thread-safe)
- `ConcurrentStack<Task> _compilerTasks` -- tracks forked compilation tasks
- `TypeCompilationState` -- per-type mutable state, NOT thread-safe across methods of same type
- `BindingDiagnosticBag` -- collects diagnostics, thread-safe via `ConcurrentSet<AssemblySymbol>`
- `ILBuilder` -- per-method IL emission, NOT thread-safe (created fresh per method)

### 1.4 Memory Model Analysis (597MB / 62,996 Methods / 11GB OOM)

Root causes of memory pressure:

1. **All method bodies retained simultaneously**: `_methodBodyMap` holds `ImmutableArray<byte>` for every method's IL until PE serialization completes
2. **BoundTree retention**: Each method's bound tree (AST after binding) exists in memory during lowering + codegen
3. **Symbol table**: Full symbol table for all referenced assemblies stays in memory
4. **Pooled objects**: `ArrayBuilder`, `PooledDictionary` etc. are reused but their backing arrays grow
5. **Task parallelism overhead**: Each `Task.Run` captures closures, allocates on heap
6. **No streaming emit**: All IL is buffered in `BlobBuilder` before any bytes hit disk

For a 597MB assembly with 62,996 methods:
- Average ~9.5KB of IL per method
- Total IL alone: ~600MB
- Bound trees + lowered trees: ~2-4x IL size = ~1.2-2.4GB
- Symbol tables for referenced assemblies: ~1-3GB
- Peak: bound tree + lowered tree + IL coexist for parallel methods

## 2. Where to Add GPU Acceleration

### 2.1 GPU-Suitable Phases

The compilation pipeline has three categories of work:

**Category A: Embarrassingly Parallel, Data-Parallel (GPU CANDIDATE)**
- Lexing/tokenization of source files (SIMD-like character classification)
- Constant folding across independent expressions
- String interning / hash computation
- IL byte sequence optimization (peephole patterns)
- PE metadata hash computation (SHA256 for strong naming)

**Category B: Task-Parallel but Graph-Dependent (CPU CANDIDATE)**
- Method body compilation (bind + lower + emit per method)
- Type completion (dependency graph between types)
- Overload resolution (complex branching logic)
- Flow analysis (control flow graph traversal)

**Category C: Sequential (NEITHER)**
- PE serialization (metadata tables require sequential token assignment)
- Debug info writing (sequential PDB stream)

### 2.2 Specific GPU Acceleration Points

#### Point 1: Parallel Lexing on GPU
**Files**: `src/Compilers/CSharp/Portable/Parser/Lexer.cs`, `QuickScanner.cs`
**What**: Tokenize all source files simultaneously on GPU. Character classification (identifier vs keyword vs operator) is a lookup-table operation perfect for GPU.
**Estimated Speedup**: 5-10x for parse phase (currently ~5% of total time)

#### Point 2: Constant Expression Evaluation on GPU
**Files**: `src/Compilers/CSharp/Portable/Binder/Binder_Operators.cs`
**What**: Evaluate compile-time constant expressions (arithmetic, string concat) in bulk on GPU.
**Estimated Speedup**: Marginal -- constant folding is <1% of time.

#### Point 3: IL Peephole Optimization on GPU
**Files**: `src/Compilers/Core/Portable/CodeGen/ILBuilder.cs` (`RealizeBlocks` at line 862)
**What**: After IL generation, apply pattern-matching optimizations across all method bodies in parallel. Each method's IL is an independent byte array -- perfect for GPU data parallelism.
**Implementation**: Upload all `RealizedIL` byte arrays to GPU, run peephole patterns (nop elimination, branch shortening, load/store fusion) as compute shaders.
**Estimated Speedup**: 2-3x for the IL realization sub-phase.

#### Point 4: SHA256/Hash Computation on GPU
**Files**: `src/Compilers/Core/Portable/PEWriter/PeWriter.cs`
**What**: Strong name signing, PDB checksums, content hashing.
**Estimated Speedup**: 10x+ for hash operations but they are a tiny fraction of total time.

#### Point 5: Method Body IL Serialization on GPU
**Files**: `src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs` (line 2970)
**What**: The `SerializeMethodBodies` loop is sequential. Pre-serialize all method bodies in parallel on GPU (each body is independent encoding), then stream results to the BlobBuilder.
**Estimated Speedup**: 3-5x for serialization phase.

### 2.3 Realistic Assessment

The dominant cost is Phase 3 (Bind + Lower + Emit), which accounts for ~80-90% of compilation time. This phase is inherently CPU-bound with complex object graph traversal (bound trees, symbol resolution, type inference). GPUs cannot efficiently execute:
- Recursive tree visitors (BoundTreeRewriter pattern)
- Hash table lookups with pointer chasing (symbol resolution)
- Complex branching (overload resolution, type inference)
- Garbage-collected heap allocation (BoundNode creation)

**The GPU provides the most value for bulk data-parallel operations on flat arrays**, not tree-structured compilation.

## 3. How to Maximize CPU Core Usage (All 8 Threads)

### 3.1 Current Bottleneck: Method-Level Parallelism

Currently, `MethodCompiler` parallelizes at the **type** level -- each type is a separate `Task.Run`. Methods within a type are compiled sequentially. For a project where most code lives in a few large types, this is a severe bottleneck.

### 3.2 Fix: Method-Level Parallelism in CompileNamedType

**File**: `src/Compilers/CSharp/Portable/Compiler/MethodCompiler.cs`
**Method**: `CompileNamedType` (line 455)

Current code compiles methods sequentially in a `for` loop (line 509):
```csharp
for (int MemberOrdinal = 0; MemberOrdinal < Members.Length; MemberOrdinal++)
{
    // ... sequential CompileMethod calls
}
```

**Modification**: After binding field initializers (which must be sequential), fork each method's compilation:

```csharp
if (_compilation.Options.ConcurrentBuild)
{
    RoslynParallel.For(0, IndependentMethods.Length, i =>
    {
        var PerMethodState = new TypeCompilationState(ContainingType, _compilation, _moduleBeingBuiltOpt);
        CompileMethod(IndependentMethods[i].Method, IndependentMethods[i].Ordinal,
                      ref IndependentMethods[i].Initializers, SynthesizedSubmissionFields, PerMethodState);
        PerMethodState.Free();
    }, _cancellationToken);
}
```

**Challenge**: `TypeCompilationState` is mutable and shared. Each parallel method needs its own `TypeCompilationState`. The `SynthesizedMethods` list must be merged after all methods complete.

### 3.3 Fix: Increase MaxDegreeOfParallelism

**File**: `src/Compilers/Core/Portable/InternalUtilities/RoslynParallel.cs`

Currently hardcoded to `Environment.ProcessorCount`. For GPU+CPU mode, set to `Environment.ProcessorCount * 2` to keep CPU saturated while GPU handles data-parallel work.

### 3.4 Fix: Parallelize MetadataWriter.SerializeMethodBodies

**File**: `src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs` (line 2970)

The existing TODO at line 3002 says: `"consider parallelizing these"`. Implementation:

1. Pre-serialize all method bodies into per-method byte arrays in parallel
2. Assign method tokens sequentially (required for metadata consistency)
3. Copy pre-serialized IL into the final BlobBuilder sequentially

## 4. How to Use ComputeSharp (DirectX 12)

### 4.1 Package Reference

Add to `src/Compilers/Core/Portable/Microsoft.CodeAnalysis.csproj`:
```xml
<PackageReference Include="ComputeSharp" Version="3.0.0" />
```

### 4.2 GPU Kernel: IL Peephole Optimizer

```csharp
[ThreadGroupSize(DefaultThreadGroupSizes.X)]
[GeneratedComputeShaderDescriptor]
internal readonly partial struct IlPeepholeKernel(
    ReadWriteBuffer<byte> IlBodies,
    ReadOnlyBuffer<int> MethodOffsets,
    ReadOnlyBuffer<int> MethodLengths,
    ReadWriteBuffer<int> OutputLengths) : IComputeShader
{
    public void Execute()
    {
        var MethodIndex = ThreadIds.X;
        var Offset = MethodOffsets[MethodIndex];
        var Length = MethodLengths[MethodIndex];
        var NewLength = Length;

        for (var I = Offset; I < Offset + Length - 1; I++)
        {
            if (IlBodies[I] == 0x00)
            {
                IlBodies[I] = 0xFE;
                NewLength--;
            }
        }

        OutputLengths[MethodIndex] = NewLength;
    }
}
```

### 4.3 GPU Kernel: Bulk Hash Computation

```csharp
[ThreadGroupSize(DefaultThreadGroupSizes.X)]
[GeneratedComputeShaderDescriptor]
internal readonly partial struct HashKernel(
    ReadOnlyBuffer<byte> InputData,
    ReadOnlyBuffer<int> ChunkOffsets,
    ReadOnlyBuffer<int> ChunkLengths,
    ReadWriteBuffer<uint> Hashes) : IComputeShader
{
    public void Execute()
    {
        var ChunkIndex = ThreadIds.X;
        var Offset = ChunkOffsets[ChunkIndex];
        var Length = ChunkLengths[ChunkIndex];
        uint Hash = 2166136261u;

        for (var I = Offset; I < Offset + Length; I++)
        {
            Hash ^= InputData[I];
            Hash *= 16777619u;
        }

        Hashes[ChunkIndex] = Hash;
    }
}
```

### 4.4 Integration Point in MethodCompiler

After all method bodies are compiled (after `WaitForWorkers` at line 184), before serialization:

```csharp
if (GpuCompilationEngine.IsAvailable)
{
    GpuCompilationEngine.OptimizeMethodBodies(_moduleBeingBuiltOpt);
}
```

## 5. Making GPU+CPU a Build REQUIREMENT

### 5.1 GPU Detection at Startup

**File to modify**: `src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs` (in `RunCore`, line 867)

```csharp
internal static class GpuRequirement
{
    internal static void Enforce()
    {
        try
        {
            using var Device = GraphicsDevice.GetDefault();
            if (Device is null)
            {
                throw new InvalidOperationException(
                    "GPU compilation required but no DirectX 12 GPU found. " +
                    "Install a GPU with DX12 support or set /p:RequireGpu=false");
            }
        }
        catch (Exception Ex)
        {
            throw new InvalidOperationException(
                $"GPU compilation required but GPU initialization failed: {Ex.Message}");
        }
    }
}
```

### 5.2 MSBuild Property Integration

**File**: `src/Compilers/CSharp/csc/AnyCpu/csc.csproj` and MSBuild targets

Add a property `<RequireGpu>true</RequireGpu>` that is checked before compilation begins.

### 5.3 CPU Core Requirement

```csharp
internal static class CpuRequirement
{
    internal static void Enforce()
    {
        var CoreCount = Environment.ProcessorCount;
        if (CoreCount < 8)
        {
            throw new InvalidOperationException(
                $"Compilation requires minimum 8 logical processors. Found: {CoreCount}");
        }
    }
}
```

## 6. Estimated Speedup for 597MB / 62,996 Method Case

### 6.1 Current Phase Breakdown (Estimated)

| Phase | % of Total Time | Parallelism |
|-------|-----------------|-------------|
| Parse | 5% | Parallel (files) |
| Declare | 5% | Parallel (namespaces) |
| Bind + Lower | 50% | Parallel (types), sequential (methods within type) |
| CodeGen (IL) | 25% | Parallel (types), sequential (methods within type) |
| Serialize PE | 15% | Sequential |

### 6.2 With Modifications

| Phase | Current | Modified | Speedup |
|-------|---------|----------|---------|
| Parse | 5% | GPU lexing: 0.5% | 10x |
| Declare | 5% | Already parallel: 5% | 1x |
| Bind + Lower | 50% | Method-level parallel (8 cores): 12.5% | 4x |
| CodeGen (IL) | 25% | Method-level parallel (8 cores): 6.25% | 4x |
| IL Optimization | 0% | GPU peephole: 0.5% | New |
| Serialize PE | 15% | Pre-serialize parallel: 5% | 3x |

### 6.3 Net Speedup Estimate

- **Current total**: 100 units
- **Modified total**: 0.5 + 5 + 12.5 + 6.25 + 0.5 + 5 = ~30 units
- **Estimated speedup**: ~3.3x

The real gain comes from method-level CPU parallelism (not GPU). GPU contributes marginal speedup for compilation because the workload is tree-structured, not data-parallel.

### 6.4 Memory Impact

Method-level parallelism will INCREASE memory usage because multiple methods' bound trees coexist simultaneously. For the 597MB case that OOMs at 11GB:
- 8 methods in flight simultaneously instead of 1 per type
- Each method's working set: ~100-500KB (bound tree + lowered tree + IL builder)
- Additional peak memory: ~4-32MB (negligible vs 11GB limit)
- The real memory pressure comes from the SYMBOL TABLE and REFERENCED ASSEMBLIES, not per-method state

## 7. Step-by-Step Implementation Tasks

### Task 1: Add ComputeSharp Dependency
- Add NuGet reference to `Microsoft.CodeAnalysis.csproj`
- Verify build on all target frameworks (netstandard2.0, net8.0)
- ComputeSharp requires .NET 8+, may need conditional compilation

### Task 2: Create GpuCompilationEngine Class
- **New file**: `src/Compilers/Core/Portable/Emit/GpuCompilationEngine.cs`
- Handles GPU device initialization, shader compilation, buffer management
- Exposes `IsAvailable`, `OptimizeMethodBodies`, `BulkHash` methods
- Lazy initialization to avoid GPU startup cost when not needed

### Task 3: Add GPU/CPU Requirement Checks
- **Modify**: `src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs`
- Add `GpuRequirement.Enforce()` and `CpuRequirement.Enforce()` at start of `RunCore`
- Add `/requiregpu` command-line argument
- Emit error CS9999 if GPU not found

### Task 4: Parallelize Method Compilation Within Types
- **Modify**: `src/Compilers/CSharp/Portable/Compiler/MethodCompiler.cs`
- Change `CompileNamedType` (line 455) to use `RoslynParallel.For` over methods
- Make `TypeCompilationState` cloneable for per-method instances
- Merge synthesized methods after parallel completion
- Keep field initializer binding sequential (has ordering dependency)

### Task 5: Implement GPU IL Peephole Optimizer
- **New file**: `src/Compilers/Core/Portable/CodeGen/GpuIlOptimizer.cs`
- Collect all `RealizedIL` arrays after `WaitForWorkers`
- Upload to GPU, run peephole patterns, download results
- Replace original IL arrays

### Task 6: Parallelize MetadataWriter.SerializeMethodBodies
- **Modify**: `src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs`
- Pre-encode all method bodies in parallel (line 2970)
- Assign tokens sequentially
- Copy pre-encoded bodies into final stream

### Task 7: GPU Lexer Kernel
- **New file**: `src/Compilers/CSharp/Portable/Parser/GpuLexer.cs`
- Upload source text to GPU
- Character classification kernel (letter/digit/whitespace/operator)
- Token boundary detection kernel
- Download token array, convert to SyntaxTokens

### Task 8: Increase RoslynParallel Limits
- **Modify**: `src/Compilers/Core/Portable/InternalUtilities/RoslynParallel.cs`
- Set `MaxDegreeOfParallelism` to `Environment.ProcessorCount` (already correct)
- Remove any throttling that limits concurrent tasks

### Task 9: Memory Optimization for Parallel Methods
- After each method's IL is generated and stored in `_methodBodyMap`, null out the bound tree
- Implement streaming emit: serialize method bodies to disk as they complete, memory-map for final PE writing
- Pool ILBuilder instances across methods

### Task 10: Integration Tests
- Test with 62,996 method assembly
- Verify GPU detection and failure mode
- Verify CPU core utilization (all 8 threads at 100%)
- Benchmark before/after compilation times
- Verify identical output (bit-for-bit determinism)

## 8. Key Source Files Reference

| File | Role |
|------|------|
| `src/Compilers/CSharp/Portable/Compiler/MethodCompiler.cs` | Central pipeline: bind + lower + emit per method |
| `src/Compilers/CSharp/Portable/Compilation/CSharpCompilation.cs` | Top-level `CompileMethods` and `Emit` entry points |
| `src/Compilers/CSharp/Portable/CodeGen/CodeGenerator.cs` | IL code generation from bound trees |
| `src/Compilers/Core/Portable/CodeGen/ILBuilder.cs` | IL byte stream construction and realization |
| `src/Compilers/Core/Portable/Emit/CommonPEModuleBuilder.cs` | `_methodBodyMap` (ConcurrentDictionary storing IL) |
| `src/Compilers/Core/Portable/PEWriter/MetadataWriter.cs` | Sequential method body serialization (line 2970) |
| `src/Compilers/Core/Portable/PEWriter/PeWriter.cs` | PE file output |
| `src/Compilers/Core/Portable/InternalUtilities/RoslynParallel.cs` | Parallel.For wrapper with ProcessorCount limit |
| `src/Compilers/CSharp/Portable/CommandLine/CSharpCompiler.cs` | Parallel file parsing (line 58) |
| `src/Compilers/Core/Portable/CommandLine/CommonCompiler.cs` | `RunCore` and `CompileAndEmit` entry points |
| `src/Compilers/CSharp/Portable/Parser/LanguageParser.cs` | Recursive descent parser |
| `src/Compilers/CSharp/Portable/Parser/Lexer.cs` | Tokenizer/lexer |
| `src/Compilers/CSharp/Portable/Lowering/LocalRewriter/*.cs` | Local rewriting (desugaring) |
| `src/Compilers/CSharp/Portable/CodeGen/Optimizer.cs` | Stack optimizer (two-pass) |
| `src/Compilers/CSharp/Portable/Symbols/Source/SourceNamespaceSymbol_Completion.cs` | Parallel declaration completion |
