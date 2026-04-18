# Transpiler Plan: Bun Standalone EXE to Blazor WASM

x86-64 PE Executable (Bun Standalone) to dotnet 11 Blazor WebAssembly Standalone C# Project

## 1. Executive Summary

`claude.exe` (231 MB, x86-64 PE) is a **Bun standalone executable** built with `bun build --compile`. The binary contains the Bun runtime (written in Zig, compiled via LLVM to native x86-64) plus a `.bun` PE section (121,768,627 bytes / 116 MB) containing the bundled JavaScript bytecode and source. The application source is a ~12 MB minified JavaScript bundle (`cli.js`) that is a React/Ink terminal UI application calling the Anthropic Messages API.

The transpiler extracts the embedded JS bundle from the EXE, deminifies it, converts it to C# via AST transformation, and generates a Blazor WASM project. For x86 native code blocks, IL bytecode is emitted directly via `System.Reflection.Metadata` APIs with GPU acceleration via ComputeSharp DirectX 12.

Pipeline: PE Parse -> Bundle Extract -> JS Deminify -> JS-to-C# AST Transform + x86-to-IL Emit (GPU+CPU) -> Blazor Project Generation

---

## 2. Binary Analysis Results

### 2.1 PE Section Map

| Section | Virtual Address | Virtual Size | Raw Size | Purpose |
|---------|----------------|-------------|----------|---------|
| `.text` | `0x00001000` | `0x03C9045E` (63 MB) | 63 MB | Bun runtime native code (Zig/LLVM compiled) |
| `.rdata` | `0x03C92000` | `0x02FA4F98` (50 MB) | 50 MB | Read-only data, string literals |
| `.data` | `0x06C37000` | `0x0021F7B8` (2.2 MB) | 170 KB | Mutable globals |
| `.pdata` | `0x06E57000` | `0x0017F664` (1.5 MB) | 1.5 MB | Exception handling tables |
| `.tls` | `0x06FD8000` | `0x004BDF39` (4.9 MB) | 4.9 MB | Thread-local storage (JavaScriptCore TLS) |
| `.bun` | `0x07505000` | `0x07420ABB` (116 MB) | 116 MB | Embedded JS bundle + bytecode |
| `.rsrc` | `0x0749F000` | `0x00030D04` (195 KB) | 195 KB | Windows resources (icon, manifest) |

### 2.2 .bun Section Format (from `C:\work\bun\src\StandaloneModuleGraph.zig`)

```
[8 bytes: uint64 payload_length]  => 121,768,627
[payload bytes: CompiledModuleGraphFile entries + string data + bytecode]
[Offsets struct: byte_count(u64) + modules_ptr(StringPointer) + entry_point_id(u32) + compile_exec_argv_ptr(StringPointer) + flags(u32)]
[16 bytes: "\n---- Bun! ----\n"]   => CONFIRMED PRESENT
```

Entry point: `file:///B:/%7EBUN/root/src/entrypoints/cli.js`

### 2.3 JavaScript Bundle Analysis (`C:\work\claudecode\cli.js`)

| Metric | Value |
|--------|-------|
| File size | 12,436,206 bytes (11.86 MB) |
| Line count | 15,728 lines (heavily minified) |
| React references | 907 |
| useState hooks | 619 |
| useEffect hooks | 344 |
| WebSocket references | 261 |
| fetch() calls | 29 |
| EventEmitter | 35 |
| Ink (terminal React renderer) | 45 |
| child_process/spawn/exec | 161 |
| process.env/exit/argv/stdin/stdout | 333 |
| fs read/write/mkdir/exists | 83 |
| Anthropic API references | 871 |
| tool_use/tool_result | 228 |
| tree-sitter references | 5 |
| ripgrep references | 49 |
| dangerouslyAllowBrowser | 7 (already supports browser!) |

### 2.4 Source Repository Structure (`C:\work\claude-code`)

The open-source repo contains only plugins, examples, hooks, and scripts -- **NOT the TypeScript source code**. The actual application source is proprietary and only available as the minified `cli.js` bundle.

Key files in `C:\work\claudecode`:
- `cli.js` -- 12 MB minified bundle (entry point: `#!/usr/bin/env node`)
- `sdk-tools.d.ts` -- 119 KB, 2,823 lines of TypeScript type definitions for all 22 tools
- `resvg.wasm` -- 2.5 MB SVG renderer (already WASM!)
- `vendor/ripgrep/` -- Platform-specific `rg` binaries
- `vendor/tree-sitter-bash/` -- Platform-specific `.node` native addons
- `vendor/audio-capture/` -- Platform-specific `.node` native addons

### 2.5 Node.js/Bun APIs Used

| Category | APIs | Count | Browser Replacement |
|----------|------|-------|-------------------|
| Process | `process.env`, `process.exit`, `process.argv`, `process.stdin`, `process.stdout` | 333 | Browser env shim, Blazor I/O |
| Child Process | `spawn`, `exec`, `execSync`, `fork` | 161 | **CANNOT** run in browser -- needs proxy |
| File System | `readFileSync`, `writeFileSync`, `mkdirSync`, `existsSync` | 83 | File System Access API / virtual FS |
| Network | `fetch`, `WebSocket`, `http`, `https`, `net` | ~330 | Browser native `fetch`/`WebSocket` |
| Crypto | `crypto` | varied | Web Crypto API |
| OS | `os.platform`, `os.homedir`, `os.tmpdir` | varied | Fixed browser values |
| Path | `path.join`, `path.resolve` | varied | Browser `path` polyfill |
| Terminal UI | React/Ink, `readline`, `process.stdin/stdout` | 907+ React | Blazor component rendering |

### 2.6 Existing Transpiler Source Analysis

Current architecture in `C:\work\prtask.com\src\PrTask.Transpiler\`:
- `BinaryToSharpConverter.cs` (416 lines) - Entry point, dispatches managed vs native
- `X86ToSharpConverter.cs` (~1200 lines) - Core x86 decoder + C# source emitter using Iced NuGet
- `CpuState.cs` (95 lines) - 17 registers (Rax-R15, Rip) + 5 flags (Cf, Zf, Sf, Of, Pf)
- `VirtualMemory.cs` (295 lines) - Page-based memory (4KB pages, ConcurrentDictionary)
- `X86Interpreter.cs` / `X86Interpreter.Ops.cs` / `X86Interpreter.Flow.cs` - Runtime interpreter
- `Win32Dispatcher.cs` - Win32 API stub dispatcher
- `Kernel32Stubs.cs` / `MsvcrtStubs.cs` - Win32 function emulation
- `BlazorProjectGenerator.cs` (245 lines) - Generates .csproj, Program.cs, Index.razor, etc.
- `BlazorStreamGenerator.cs` (329 lines) - Window capture streaming variant
- `TsToSharpConverter.cs` (18 KB) - TS-to-C# transpiler (interfaces, functions, enums, consts, type mapping)

Current flow:
1. Read PE with `System.Reflection.PortableExecutable.PEReader`
2. Find .text section, decode x86 instructions with `Iced.Intel.Decoder.Create(64, ...)`
3. Recursive decode: follow CALL/JMP targets from entry point (up to 50,000 blocks)
4. Emit C# source code (StringBuilder) that simulates CPU state (registers, flags, memory)
5. Generate Blazor project files around the emitted code

Problems with current approach:
- Generates C# source (thousands of lines) requiring Roslyn compilation
- Sequential processing of all 62,996+ instruction blocks
- No GPU acceleration
- Magic numbers scattered throughout (0x400000, 256MB memory, etc.)
- No clean architecture separation

### 2.7 System.Reflection.Metadata IL Emission APIs

Location: `C:\work\dotnet\runtime\src\libraries\System.Reflection.Metadata\src\System\Reflection\Metadata\Ecma335\Encoding\`

Key types for direct IL emission (bypass Roslyn entirely):

**MetadataBuilder** (`MetadataBuilder.Tables.cs` line 10):
- `AddAssembly(StringHandle, Version, StringHandle, BlobHandle, AssemblyFlags, AssemblyHashAlgorithm)` - line 387
- `AddTypeDefinition(TypeAttributes, StringHandle, StringHandle, EntityHandle, FieldDefinitionHandle, MethodDefinitionHandle)` - line 460
- `AddMethodDefinition(MethodAttributes, MethodImplAttributes, StringHandle, BlobHandle, int, ParameterHandle)` - line 985
- `AddFieldDefinition(FieldAttributes, StringHandle, BlobHandle)` - defines fields
- `AddModule(int, StringHandle, GuidHandle, GuidHandle, GuidHandle)` - module row
- `GetOrAddString(string)` - string heap
- `GetOrAddBlob(BlobBuilder)` - blob heap
- `GetOrAddGuid(Guid)` - GUID heap

**InstructionEncoder** (`InstructionEncoder.cs` line 11):
- `OpCode(ILOpCode)` - emit any IL opcode
- `LoadConstantI4(int)` / `LoadConstantI8(long)` - push constants
- `LoadLocal(int)` / `StoreLocal(int)` - local variable access
- `LoadArgument(int)` / `StoreArgument(int)` - argument access
- `Call(MethodDefinitionHandle)` / `CallIndirect(StandaloneSignatureHandle)` - method calls
- `Branch(ILOpCode, LabelHandle)` - conditional/unconditional branches
- `DefineLabel()` / `MarkLabel(LabelHandle)` - label management
- `Token(EntityHandle)` - embed metadata tokens
- `LoadString(UserStringHandle)` - ldstr

**MethodBodyStreamEncoder** (`MethodBodyStreamEncoder.cs` line 9):
- `AddMethodBody(int codeSize, int maxStack, int exceptionRegionCount, ...)` - returns `MethodBody`
- `MethodBody.Instructions` - `Blob` for writing IL bytes
- `MethodBody.Offset` - body offset for `AddMethodDefinition`

**BlobEncoder** (`BlobEncoders.cs` line 11):
- `MethodSignature(SignatureCallingConvention, int, bool)` - encode method signatures
- `FieldSignature()` - encode field signatures
- `LocalVariablesSignature(int)` - encode locals signature

**ManagedPEBuilder** (`ManagedPEBuilder.cs` line 12):
- Constructor: `(PEHeaderBuilder, MetadataRootBuilder, BlobBuilder ilStream, ...)`
- `Serialize(BlobBuilder)` - produces final PE/DLL bytes
- Uses `PEHeaderBuilder.CreateLibraryHeader()` for class library output

**ControlFlowBuilder** (`ControlFlowBuilder.cs`):
- Tracks branches and exception handlers
- Required for methods with branches (every transpiled block uses branches)

---

## 3. Self-Sufficient Bundle Extraction

### 3.1 Motivation

The minified source at `C:\work\claudecode\cli.js` will NOT always be available. The transpiler MUST be self-sufficient -- it must extract everything it needs from the `.exe` alone. The known minified source serves only as a verification reference during development.

### 3.2 Bun Standalone Binary Format (from `StandaloneModuleGraph.zig`)

The `.bun` PE section at raw offset `0x0730B400` contains the embedded JS bundle. The extraction algorithm reads the section data and parses the Bun standalone binary format documented in `C:\work\bun\src\StandaloneModuleGraph.zig`.

The `.bun` PE section has this layout:

```
[8 bytes: uint64 PayloadLength]           (little-endian, value = 121,768,627 for claude.exe)
[PayloadLength bytes: Payload]
  [String table: file names, JS source, sourcemaps, bytecode (128-byte aligned)]
  [CompiledModuleGraphFile[] array: module descriptors]
  [Compile exec argv string]
  [Offsets struct: 32 bytes]
  [Trailer: "\n---- Bun! ----\n" (16 bytes)]
```

At runtime, Bun finds the `.bun` PE section via `GetModuleHandleA(NULL)` + PE header walking (see `C:\work\bun\src\bun.js\bindings\c-bindings.cpp` lines 954-995). The first 8 bytes of the section are the `uint64` payload length. The data starts at offset 8 from the section start.

### 3.3 Offsets Struct (32 bytes)

Located at `Payload[PayloadLength - 16 - sizeof(Offsets)]`:

```
extern struct Offsets {
    ByteCount: u64             (total byte count of string data)
    ModulesPtr: StringPointer  (offset: u32, length: u32 -- points to CompiledModuleGraphFile[])
    EntryPointId: u32          (index into module array)
    CompileExecArgvPtr: StringPointer  (offset: u32, length: u32)
    Flags: u32                 (packed: DisableDefaultEnvFiles, DisableAutoloadBunfig, DisableAutoloadTsconfig, DisableAutoloadPackageJson)
}
```

### 3.4 StringPointer (8 bytes)

All data references use `StringPointer` from `C:\work\bun\src\api\schema.zig` line 832:

```
extern struct StringPointer {
    Offset: u32    (byte offset into the payload data region)
    Length: u32    (byte length)
}
```

### 3.5 CompiledModuleGraphFile Struct

Each embedded module is described by (from `StandaloneModuleGraph.zig` line 90):

```
struct CompiledModuleGraphFile {
    Name: StringPointer              (file path, e.g. "B:/~BUN/root/src/entrypoints/cli.js")
    Contents: StringPointer          (JS source code)
    Sourcemap: StringPointer         (serialized source map, zstd-compressed contents)
    Bytecode: StringPointer          (JSC bytecode cache, 128-byte aligned)
    ModuleInfo: StringPointer        (ESM module metadata)
    BytecodeOriginPath: StringPointer (path used during bytecode generation)
    Encoding: u8                     (0=binary, 1=latin1, 2=utf8)
    Loader: u8                       (file type: js, jsx, ts, tsx, etc.)
    ModuleFormat: u8                 (0=none, 1=esm, 2=cjs)
    Side: u8                         (0=server, 1=client)
}
```

### 3.6 Extraction Algorithm

```
1. Open the PE file and walk section headers to find ".bun"
2. Read the first 8 bytes of the section as uint64 PayloadLength
3. PayloadData = SectionData[8 .. 8 + PayloadLength]
4. Verify trailer: PayloadData[PayloadLength - 16 .. PayloadLength] == "\n---- Bun! ----\n"
5. Read Offsets struct: PayloadData[PayloadLength - 16 - 32 .. PayloadLength - 16]
6. ModuleArray = PayloadData[Offsets.ModulesPtr.Offset .. +Offsets.ModulesPtr.Length]
7. Interpret ModuleArray as CompiledModuleGraphFile[] (each entry is 6 * StringPointer + 4 bytes = 52 bytes)
8. For each module, extract Contents by reading PayloadData[Contents.Offset .. +Contents.Length]
9. Entry point is ModuleArray[Offsets.EntryPointId]
10. Output each extracted JS file to disk
```

### 3.7 Platform-Specific Section Access

From `C:\work\bun\src\bun.js\bindings\c-bindings.cpp`:

- **Windows (PE)**: Walk PE section headers, find `.bun` section by name. Section data starts at `(BYTE*)hModule + sectionHeader->VirtualAddress`. First 8 bytes = `uint64` payload size. Data follows at offset 8.
- **macOS (Mach-O)**: Uses `__DATA,__module_graph` segment via `Bun__getStandaloneModuleGraphMachoLength()`. Same 8-byte size header + data format.
- **Linux (ELF)**: Data appended to executable. `PT_LOAD` segment maps it into memory. Format: `[u64 PayloadLength][PayloadData]`.

All three platforms share the same internal payload format (string table + modules + Offsets + trailer).

### 3.8 Comparison with Known Minified Source

During development, the extracted bundle is compared against `C:\work\claudecode\cli.js` (12,436,206 bytes / 11.86 MB minified) to verify extraction completeness:

1. Extract the entry point module's `Contents` from the `.bun` section
2. Load `C:\work\claudecode\cli.js` as the reference
3. Byte-compare the two to confirm they match (or diff to find gaps)
4. Any discrepancy indicates an extraction bug or a format version mismatch

This comparison step is OPTIONAL and only runs when the reference file exists. The transpiler must NOT depend on `C:\work\claudecode` being present.

### 3.9 Bun Source References

| File | Purpose |
|------|---------|
| `C:\work\bun\src\StandaloneModuleGraph.zig` | Standalone binary format definition, serialization/deserialization |
| `C:\work\bun\src\bun.js\bindings\c-bindings.cpp` (lines 946-997) | PE section reader (`initializePESection`, `Bun__getStandaloneModuleGraphPELength/Data`) |
| `C:\work\bun\src\api\schema.zig` (line 832) | `StringPointer` struct definition (`Offset: u32, Length: u32`) |
| `C:\work\bun\src\pe.zig` | PE format handling utilities |
| `C:\work\bun\src\elf.zig` | ELF format handling for Linux standalone |
| `C:\work\bun\src\cli\build_command.zig` | `bun build --compile` entry point |
| `C:\work\bun\src\bundler\bundle_v2.zig` | Bundler that produces the module graph |

---

## 4. Transpiler Pipeline

### 4.1 Full Pipeline

| Step | Input | Output | Required |
|------|-------|--------|----------|
| 1. Extract JS Bundle | `.exe` file (`.bun` PE section) | Raw JS source files | YES (self-sufficient) |
| 2. Verify Extraction | Extracted JS + `C:\work\claudecode\cli.js` | Diff report | NO (development only) |
| 3. Deminify/Parse | Raw minified JS | Formatted AST | YES |
| 4. Convert JS to C# | JS AST + `sdk-tools.d.ts` types | C# source files | YES |
| 5. x86 Native to IL | `.text` PE section (for runtime stubs) | IL DLL via System.Reflection.Metadata | YES (GPU+CPU) |
| 6. Generate Blazor WASM | C# source + IL DLL + Razor templates | Blazor WASM project | YES |

### 4.2 Two Transpilation Tracks

**Track A: JavaScript Source Transpilation (JS to C#)**

Transpile the 12 MB `cli.js` bundle from JavaScript to C#, replacing Node.js/Bun APIs with .NET equivalents, and React/Ink UI with Blazor components. This is the primary track for application logic.

**Track B: x86-64 Binary to IL (Native Runtime Stubs)**

For Win32 API stubs and any native code blocks needed, emit IL bytecode directly via `System.Reflection.Metadata` APIs with GPU acceleration via ComputeSharp. This replaces C# source generation (current `X86ToSharpConverter`) with direct IL byte emission.

---

## 5. Track A: JavaScript Source Transpilation

### 5.1 Bundle Extraction and Deminification

**5.1.1 Extract JS from .bun section** (`src/PrTask.Transpiler/BunSectionExtractor.cs`)

Using the confirmed format from `C:\work\bun\src\StandaloneModuleGraph.zig` and `C:\work\bun\src\bun.js\bindings\c-bindings.cpp`:

```
.bun section layout:
  [u64 payload_size]           -- 8 bytes, little-endian
  [payload]                    -- payload_size bytes
    [module graph files]       -- CompiledModuleGraphFile structs
    [string data]              -- file names, contents, sourcemaps
    [bytecode]                 -- JSC bytecode cache (128-byte aligned)
  [Offsets struct]             -- 32 bytes (byte_count:u64, modules_ptr:StringPointer, entry_point_id:u32, compile_exec_argv_ptr:StringPointer, flags:u32)
  [trailer]                   -- "\n---- Bun! ----\n" (16 bytes)
```

The `CompiledModuleGraphFile` struct (from `StandaloneModuleGraph.zig` line 90):
```zig
pub const CompiledModuleGraphFile = struct {
    name: Schema.StringPointer = .{},
    contents: Schema.StringPointer = .{},
    sourcemap: Schema.StringPointer = .{},
    bytecode: Schema.StringPointer = .{},
    module_info: Schema.StringPointer = .{},
    bytecode_origin_path: Schema.StringPointer = .{},
    encoding: Encoding = .latin1,
    loader: bun.options.Loader = .file,
    module_format: ModuleFormat = .none,
    side: FileSide = .server,
};
```

**5.1.2 Deminify the bundle** (`src/PrTask.Transpiler/JsDeMinifier.cs`)
- Restore whitespace and indentation using brace/bracket matching
- Split single-character variable names to descriptive names using scope analysis
- Reconstruct module boundaries using the `var` clusters and IIFE patterns
- Use the `sdk-tools.d.ts` type definitions to annotate function signatures

**5.1.3 Module graph reconstruction** (`src/PrTask.Transpiler/JsModuleAnalyzer.cs`)
- Parse the deminified JS to identify logical modules
- Map to domain concepts: ApiClient, ToolExecutor, ConversationManager, UiRenderer, etc.
- Extract the React component tree (619 useState = ~619 components or stateful functions)
- Identify the Anthropic SDK integration points (871 references)

### 5.2 JS-to-C# Transpilation Engine

**5.2.1 Enhanced JS Parser** (`src/PrTask.Transpiler/JsParser/`)

Extend the existing `TsToSharpConverter` with full JavaScript support:

```
src/PrTask.Transpiler/JsParser/
    JsLexer.cs
    JsAstNode.cs
    JsParser.cs
    JsScopeAnalyzer.cs
    JsTypeInferencer.cs
```

**5.2.2 C# Code Generator** (`src/PrTask.Transpiler/CSharpGen/`)

```
src/PrTask.Transpiler/CSharpGen/
    CSharpEmitter.cs
    TypeMapper.cs
    AsyncTransformer.cs
    ReactToBlazorMapper.cs
    InkToBlazorMapper.cs
    NodeApiReplacer.cs
```

**5.2.3 Type mapping (extended from TsToSharpConverter)**:

| JavaScript/TypeScript | C# | Notes |
|----------------------|-----|-------|
| `string` | `string` | Direct |
| `number` | `double` | Or `int` when inferred |
| `boolean` | `bool` | Direct |
| `Promise<T>` | `Task<T>` | With async/await |
| `Map<K,V>` | `Dictionary<K,V>` | Direct |
| `Set<T>` | `HashSet<T>` | Direct |
| `Array<T>` / `T[]` | `List<T>` | Direct |
| `Buffer` / `Uint8Array` | `byte[]` | Direct |
| `Date` | `DateTime` | Direct |
| `RegExp` | `Regex` | Direct |
| `Error` | `Exception` | Direct |
| `EventEmitter` | `IObservable<T>` / custom | Rx.NET or custom events |
| `ReadableStream` | `Stream` | System.IO |
| `WebSocket` | `ClientWebSocket` | System.Net.WebSockets |
| `fetch` | `HttpClient` | System.Net.Http |
| `null \| undefined` | `T?` | Nullable reference types |
| `Record<K,V>` | `Dictionary<K,V>` | Direct |
| React component | Blazor component | `.razor` files |
| `useState` | `@bind` / property | Blazor state |
| `useEffect` | `OnAfterRenderAsync` | Blazor lifecycle |
| `useCallback` | method reference | Direct method |
| `useRef` | `ElementReference` | Blazor ref |

### 5.3 Node.js API Polyfill Layer

**5.3.1 Process shim** (`src/PrTask.Claude.Wasm/Polyfills/ProcessShim.cs`)
```csharp
namespace PrTask.Claude.Wasm.Polyfills;

internal static class ProcessShim
{
    internal static Dictionary<string, string> Env { get; } = new(StringComparer.Ordinal);
    internal static string[] Argv { get; set; } = [];
    internal static string Platform => "browser";
    internal static TextWriter Stdout => Console.Out;
    internal static TextWriter Stderr => Console.Error;

    internal static void Exit(int Code) => throw new ApplicationExitException(Code);
}
```

**5.3.2 File system shim** (`src/PrTask.Claude.Wasm/Polyfills/FileSystemShim.cs`)
- In-browser: Use File System Access API via JS interop
- Or: Virtual in-memory file system for config/state
- Map `~/.claude/` to IndexedDB-backed storage

**5.3.3 Child process shim** (`src/PrTask.Claude.Wasm/Polyfills/ChildProcessShim.cs`)
- Browser cannot spawn processes
- Route `Bash` tool calls through WebSocket to a local agent/daemon
- The `BashInput`/`BashOutput` types from `sdk-tools.d.ts` define the interface

**5.3.4 Network shim** (`src/PrTask.Claude.Wasm/Polyfills/NetworkShim.cs`)
- `fetch` -> browser native `fetch` (already works -- `dangerouslyAllowBrowser: true` appears 7 times)
- `WebSocket` -> browser native `WebSocket`
- `http.createServer` -> not needed in browser mode

### 5.4 React/Ink to Blazor UI Transpilation

**5.4.1 Terminal emulator component** (`src/PrTask.Claude.Wasm/Components/TerminalEmulator.razor`)
- Replace Ink's terminal rendering with xterm.js in Blazor
- Map Ink's `<Box>`, `<Text>`, `<Static>` to Blazor div/span equivalents
- Handle ANSI escape sequences via xterm.js

**5.4.2 React component mapping**:

| React/Ink | Blazor | Strategy |
|-----------|--------|----------|
| `useState(initial)` | `private T Field = initial;` + `StateHasChanged()` | Property with notification |
| `useEffect(() => {}, [deps])` | `OnParametersSetAsync()` / `OnAfterRenderAsync()` | Lifecycle methods |
| `useCallback(fn, deps)` | Direct method reference | No memoization needed |
| `useMemo(fn, deps)` | Lazy property or cached computation | Manual cache |
| `useRef(initial)` | `ElementReference` or field | Direct field |
| `<Box flexDirection="column">` | `<div style="display:flex;flex-direction:column">` | CSS flexbox |
| `<Text color="green">` | `<span class="text-green">` | CSS classes |
| `<Spinner>` | `<div class="spinner">` | CSS animation |
| `<TextInput>` | `<input @bind="Value">` | Blazor binding |
| JSX `{condition && <Component>}` | `@if (Condition) { <Component /> }` | Razor conditional |
| JSX `{items.map(x => <Item />)}` | `@foreach (var X in Items) { <Item /> }` | Razor loop |

### 5.5 Anthropic API Client

**5.5.1 Direct API client** (`src/PrTask.Claude.Wasm/Services/AnthropicApiClient.cs`)

The bundle already has `dangerouslyAllowBrowser: true` set 7 times, meaning the Anthropic SDK is already designed to work in browsers.

**5.5.2 Tool execution engine** (`src/PrTask.Claude.Wasm/Services/ToolExecutor.cs`)

From `sdk-tools.d.ts`, the 22 tools to implement:

| Tool | Browser Implementation |
|------|----------------------|
| `Bash` | WebSocket proxy to local daemon |
| `FileRead` | File System Access API / virtual FS |
| `FileWrite` | File System Access API / virtual FS |
| `FileEdit` | In-memory diff/patch |
| `Glob` | Virtual FS glob or WebSocket proxy |
| `Grep` | In-memory regex or WebSocket proxy to `rg` |
| `WebFetch` | Browser `fetch()` direct |
| `WebSearch` | Browser `fetch()` to search API |
| `Agent` | Recursive conversation (in-process) |
| `TaskOutput` | Async task tracking |
| `TodoWrite` | In-memory state |
| `NotebookEdit` | In-memory notebook model |
| `Config` | IndexedDB/localStorage |
| `EnterWorktree` / `ExitWorktree` | WebSocket proxy |
| `McpInput` / MCP resources | WebSocket to MCP servers |
| `AskUserQuestion` | Blazor modal/prompt UI |

---

## 6. Track B: x86-64 Binary to IL Emission

### 6.1 IL Emission over Roslyn

Current approach: Generate ~50,000 lines of C# source -> Roslyn compiles to DLL (slow, memory-heavy).
New approach: Emit IL bytes directly via System.Reflection.Metadata (no Roslyn dependency, no C# parsing, 100x faster).

The `InstructionEncoder` in `C:\work\dotnet\runtime\src\libraries\System.Reflection.Metadata\src\System\Reflection\Metadata\Ecma335\Encoding\InstructionEncoder.cs` provides typed IL opcode emission.

### 6.2 X86 to IL Instruction Mapping

| x86 Mnemonic | Current C# Source Emission | IL Opcode Sequence |
|---|---|---|
| `mov reg, imm` | `Rax = 0x1234UL;` | `ldc.i8 0x1234` / `stsfld Rax` |
| `mov reg, reg` | `Rax = Rbx;` | `ldsfld Rbx` / `stsfld Rax` |
| `mov reg, [mem]` | `Rax = ReadQword(addr);` | `ldsfld addr` / `call ReadQword` / `stsfld Rax` |
| `mov [mem], reg` | `WriteQword(addr, Rax);` | `ldsfld addr` / `ldsfld Rax` / `call WriteQword` |
| `lea reg, [mem]` | `Rax = base + index*scale + disp;` | `ldsfld base` / `ldsfld index` / `ldc.i4 scale` / `mul` / `add` / `ldc.i8 disp` / `add` / `stsfld Rax` |
| `add reg, imm` | `{ var A = Rax; var B = imm; var R = A + B; UpdateFlags(R, A, B, 8); Rax = R; }` | `ldsfld Rax` / `dup` / `ldc.i8 imm` / `dup` / `add` / `dup` / `stsfld Rax` / `call UpdateFlags` |
| `sub reg, imm` | Same pattern with `-` | Same pattern with `sub` |
| `and reg, imm` | Same pattern with `&` | Same pattern with `and` |
| `or reg, imm` | Same pattern with `\|` | Same pattern with `or` |
| `xor reg, reg` (self) | `Rax = 0; Zf = true; Sf = false; Cf = false; Of = false;` | `ldc.i8 0` / `stsfld Rax` / `ldc.i4.1` / `stsfld Zf` / `ldc.i4.0` / `stsfld Sf` / ... |
| `push reg` | `Push(Rax);` | `ldsfld Rax` / `call Push` |
| `pop reg` | `Rax = Pop();` | `call Pop` / `stsfld Rax` |
| `cmp reg, imm` | `{ var A = Rax; var B = imm; var R = A - B; UpdateFlags(R, A, B, 8); }` | Load both / `sub` / `call UpdateFlags` (without store) |
| `test reg, imm` | `{ var R = Rax & imm; Zf = R == 0; ... }` | Load both / `and` / `dup` / `ldc.i8 0` / `ceq` / `stsfld Zf` / ... |
| `jmp target` | `Block_XXXX(); return;` | `call Block_XXXX` / `ret` |
| `je target` | `if (Zf) { Block_XXXX(); return; }` | `ldsfld Zf` / `brtrue label` / (fallthrough) / label: `call Block_XXXX` / `ret` |
| `call target` | `Block_XXXX();` | `call Block_XXXX` |
| `ret` | `return;` | `ret` |
| `shl reg, imm` | `Rax = Rax << (int)imm;` | `ldsfld Rax` / `ldc.i4 imm` / `shl` / `stsfld Rax` |
| `imul reg, reg` | `Rax = Rax * Rbx;` | `ldsfld Rax` / `ldsfld Rbx` / `mul` / `stsfld Rax` |
| `cmovCC reg, reg` | `if (cond) Rax = Rbx;` | `ldsfld cond` / `brfalse skip` / `ldsfld Rbx` / `stsfld Rax` / skip: |
| `setCC reg` | `Rax = cond ? 1 : 0;` | `ldsfld cond` / `conv.u8` / `stsfld Rax` |
| `nop` | (nothing) | `nop` |
| `endbr64` | (nothing) | `nop` |

### 6.3 GPU Acceleration (ComputeSharp DirectX 12)

ComputeSharp provides DirectX 12 compute shaders in C#. The translation kernel runs one thread per instruction block. With 62,996 blocks (typical for a medium-sized .exe), this saturates a modern GPU.

```csharp
[ThreadGroupSize(GpuConstants.ThreadGroupSizeX)]
[GeneratedComputeShaderDescriptor]
internal readonly partial struct IlTranslationKernel(
    ReadWriteBuffer<uint> InstructionData,
    ReadWriteBuffer<byte> OutputIlBytes,
    ReadWriteBuffer<int> BlockOffsets,
    ReadWriteBuffer<int> BlockLengths,
    ReadWriteBuffer<int> OutputOffsets,
    ReadWriteBuffer<int> OutputLengths) : IComputeShader
{
    public void Execute()
    {
        var ThreadId = ThreadIds.X;
        if (ThreadId >= BlockOffsets.Length) return;

        var InstrOffset = BlockOffsets[ThreadId];
        var InstrCount = BlockLengths[ThreadId];
        var OutOffset = OutputOffsets[ThreadId];
        var OutPos = 0;

        for (var I = 0; I < InstrCount; I++)
        {
            var MnemonicRaw = InstructionData[InstrOffset + (I * InstructionsPerStride)];
            OutPos += TranslateOne(MnemonicRaw, ...);
        }

        OutputLengths[ThreadId] = OutPos;
    }
}
```

GPU data layout:
- Flatten all `DecodedInstruction` fields into `uint[]` arrays (GPU cannot use structs with arbitrary layout)
- Each instruction = fixed stride of uint values (mnemonic, op0kind, op1kind, op0reg, op1reg, imm_lo, imm_hi, membase, memindex, memscale, opsize, branchtarget_lo, branchtarget_hi)
- Stride = 13 uints per instruction

For browser builds (Blazor WASM), GPU is NOT available. Use WebGPU via JS interop or WASM SIMD as fallback.

### 6.4 DLL Assembly Output

Using `ManagedPEBuilder`:
```csharp
var PeHeaderBuilder = PEHeaderBuilder.CreateLibraryHeader();
var MetadataRootBuilder = new MetadataRootBuilder(MetadataBuilder, IlConstants.MetadataVersionString);
var IlStream = new BlobBuilder();
var ManagedPe = new ManagedPEBuilder(PeHeaderBuilder, MetadataRootBuilder, IlStream);
var PeBlob = new BlobBuilder();
ManagedPe.Serialize(PeBlob);
File.WriteAllBytes(OutputPath, PeBlob.ToArray());
```

---

## 7. Clean Architecture Project Structure

```
C:\work\prtask.com\src\
  PrTask.Transpiler.Domain\
    Constants\
      PeConstants.cs
      IlConstants.cs
      RegisterConstants.cs
      MemoryConstants.cs
      BlazorConstants.cs
      GpuConstants.cs
      BunConstants.cs
    Enums\
      MnemonicId.cs
      OperandKind.cs
      RegisterId.cs
      SectionKind.cs
      FlowKind.cs
    Models\
      DecodedInstruction.cs
      InstructionBlock.cs
      RegisterState.cs
      MemoryAccess.cs
      PeSection.cs
      ImportEntry.cs
      ExportEntry.cs
      IatEntry.cs
      PeImage.cs
      IlMethodBody.cs
      IlInstruction.cs
      EmittedBlock.cs
      GpuWorkItem.cs
      GpuResult.cs
      TranspileResult.cs
      BlazorProject.cs
      BunModule.cs
      ExtractedBundle.cs
    PrTask.Transpiler.Domain.csproj

  PrTask.Transpiler.Application\
    Interfaces\
      IPeParser.cs
      IBunExtractor.cs
      IBundleVerifier.cs
      IDecoder.cs
      IBlockDiscoverer.cs
      IJsDeMinifier.cs
      IJsParser.cs
      IJsToCSharpConverter.cs
      IIlTranslator.cs
      IGpuIlTranslator.cs
      IAssemblyEmitter.cs
      IProjectGenerator.cs
      IGpuDeviceProvider.cs
    Services\
      PeParseService.cs
      BunExtractionService.cs
      BundleVerificationService.cs
      DecodeService.cs
      BlockDiscoveryService.cs
      JsDeMinificationService.cs
      JsParsingService.cs
      JsToCSharpService.cs
      IlTranslationService.cs
      GpuIlTranslationService.cs
      AssemblyEmitService.cs
      ProjectGenerationService.cs
      TranspilePipeline.cs
    PrTask.Transpiler.Application.csproj

  PrTask.Transpiler.Infrastructure\
    Extraction\
      BunSectionExtractor.cs
      BunModuleParser.cs
      BundleComparer.cs
    Decoding\
      IcedDecoder.cs
      IcedBlockDiscoverer.cs
    JsTranspilation\
      JsLexer.cs
      JsAstNode.cs
      JsParser.cs
      JsScopeAnalyzer.cs
      JsTypeInferencer.cs
      JsDeMinifier.cs
      CSharpEmitter.cs
      TypeMapper.cs
      AsyncTransformer.cs
      ReactToBlazorMapper.cs
      InkToBlazorMapper.cs
      NodeApiReplacer.cs
    Emission\
      MetadataIlEmitter.cs
      MethodBodyEncoder.cs
      X86ToIlMapper.cs
      TypeDefinitionBuilder.cs
      AssemblyBuilder.cs
    Gpu\
      ComputeSharpDevice.cs
      IlTranslationKernel.cs
      GpuBlockAllocator.cs
      GpuResultCollector.cs
    Generation\
      BlazorProjectWriter.cs
      CsprojGenerator.cs
      ProgramCsGenerator.cs
      IndexRazorGenerator.cs
      AppRazorGenerator.cs
      ImportsRazorGenerator.cs
      IndexHtmlGenerator.cs
      CssGenerator.cs
    PrTask.Transpiler.Infrastructure.csproj

  PrTask.Transpiler\
    Program.cs
    PrTask.Transpiler.csproj
```

---

## 8. Domain Layer Constants

### 8.1 PeConstants.cs

- `DefaultImageBase` = 0x140000000UL
- `TextSectionName` = ".text"
- `DataSectionName` = ".data"
- `RdataSectionName` = ".rdata"
- `BssSectionName` = ".bss"
- `BunSectionName` = ".bun"
- `ImportDirectoryEntrySize` = 20
- `IltEntrySize` = 8
- `OrdinalFlag` = 0x8000000000000000UL
- `HintMask` = 0x7FFFFFFFUL
- `MaxExportCount` = 10000
- `MaxBlockCount` = 50000
- `MaxDecodePerTarget` = 4096
- `MaxInstructionLength` = 15

### 8.2 BunConstants.cs

- `TrailerString` = "\n---- Bun! ----\n"
- `TrailerLength` = 16
- `PayloadLengthSize` = 8
- `OffsetsStructSize` = 32
- `StringPointerSize` = 8
- `CompiledModuleGraphFileSize` = 52
- `WindowsBasePath` = "B:\\~BUN\\"
- `WindowsBasePublicPath` = "B:/~BUN/"
- `UnixBasePath` = "/$bunfs/"
- `EncodingBinary` = 0
- `EncodingLatin1` = 1
- `EncodingUtf8` = 2
- `ModuleFormatNone` = 0
- `ModuleFormatEsm` = 1
- `ModuleFormatCjs` = 2
- `SideServer` = 0
- `SideClient` = 1

### 8.3 IlConstants.cs

- `AssemblyName` = "TranspiledBinary"
- `ModuleName` = "TranspiledBinary.dll"
- `TypeNamespace` = "TranspiledBinary"
- `CpuStateTypeName` = "CpuState"
- `MemoryTypeName` = "VirtualMemory"
- `EntryMethodName` = "Entry"
- `BlockMethodPrefix` = "Block_"
- `MetadataVersionString` = "v4.0.30319"
- `DefaultMaxStack` = 8
- `RegisterFieldCount` = 17
- `FlagFieldCount` = 5

### 8.4 RegisterConstants.cs

- `RegisterCount` = 17
- `FlagCount` = 5
- `RaxIndex` = 0 through `RipIndex` = 16
- `CfIndex` = 0 through `PfIndex` = 4
- Register names array: `AllRegisterNames`
- Flag names array: `AllFlagNames`

### 8.5 MemoryConstants.cs

- `PageSizeBits` = 12
- `PageSize` = 4096
- `PageMask` = 4095UL
- `DefaultMemorySize` = 268435456 (256MB)
- `DefaultStackOffset` = 0xFFFF0000UL
- `HeapBase` = 0x20000000UL
- `HeapMaxSize` = 0x10000000UL

### 8.6 BlazorConstants.cs

- `ProjectSdk` = "Microsoft.NET.Sdk.BlazorWebAssembly"
- `TargetFramework` = "net11.0"
- `RootSelector` = "#app"
- `WasmPackageId` = "Microsoft.AspNetCore.Components.WebAssembly"
- `WasmPackageVersion` = "11.0.0-preview.2.26159.112"

### 8.7 GpuConstants.cs

- `ThreadGroupSizeX` = 256
- `MaxParallelBlocks` = 62996
- `MaxIlBytesPerBlock` = 4096
- `MaxInstructionsPerBlock` = 256
- `GpuTimeoutMs` = 30000

---

## 9. Domain Layer Models

### 9.1 DecodedInstruction.cs
```csharp
public readonly record struct DecodedInstruction(
    ulong Address,
    ulong NextAddress,
    MnemonicId Mnemonic,
    FlowKind Flow,
    int OperandCount,
    OperandKind Op0Kind,
    OperandKind Op1Kind,
    OperandKind Op2Kind,
    RegisterId Op0Register,
    RegisterId Op1Register,
    RegisterId Op2Register,
    ulong Immediate,
    ulong MemoryDisplacement,
    RegisterId MemoryBase,
    RegisterId MemoryIndex,
    int MemoryScale,
    int OperandSize,
    ulong BranchTarget,
    bool IsIpRelative,
    ulong IpRelativeAddress);
```

### 9.2 InstructionBlock.cs
```csharp
public sealed class InstructionBlock(
    ulong StartAddress,
    DecodedInstruction[] Instructions,
    ulong[] BranchTargets,
    ulong[] CallTargets);
```

### 9.3 PeImage.cs
```csharp
public sealed class PeImage(
    ulong ImageBase,
    uint EntryPointRva,
    bool Is64Bit,
    PeSection[] Sections,
    ImportEntry[] Imports,
    ExportEntry[] Exports,
    IatEntry[] IatEntries);
```

### 9.4 BunModule.cs
```csharp
public sealed class BunModule(
    string Name,
    string Contents,
    byte Encoding,
    byte Loader,
    byte ModuleFormat,
    byte Side,
    byte[] Bytecode,
    byte[] Sourcemap);
```

### 9.5 ExtractedBundle.cs
```csharp
public sealed class ExtractedBundle(
    BunModule[] Modules,
    int EntryPointId,
    string CompileExecArgv,
    uint Flags);
```

### 9.6 IlMethodBody.cs
```csharp
public sealed class IlMethodBody(
    ulong SourceAddress,
    string MethodName,
    byte[] IlBytes,
    int MaxStack,
    int LocalCount);
```

### 9.7 GpuWorkItem.cs / GpuResult.cs
```csharp
public readonly record struct GpuWorkItem(
    int BlockIndex,
    int InstructionOffset,
    int InstructionCount);

public readonly record struct GpuResult(
    int BlockIndex,
    int IlByteCount,
    int MaxStack);
```

---

## 10. Application Layer Interfaces

```csharp
public interface IPeParser
{
    PeImage Parse(string FilePath);
    PeImage Parse(Stream Stream);
}

public interface IBunExtractor
{
    ExtractedBundle Extract(string ExePath);
    ExtractedBundle Extract(PeImage Image, Stream Stream);
}

public interface IBundleVerifier
{
    bool Verify(ExtractedBundle Bundle, string ReferenceJsPath);
}

public interface IDecoder
{
    DecodedInstruction Decode(ReadOnlySpan<byte> Code, ulong Address);
    DecodedInstruction[] DecodeBlock(ReadOnlySpan<byte> Code, ulong StartAddress, int MaxInstructions);
}

public interface IBlockDiscoverer
{
    InstructionBlock[] DiscoverBlocks(PeImage Image);
}

public interface IJsDeMinifier
{
    string DeMinify(string MinifiedJs);
}

public interface IJsToCSharpConverter
{
    string[] Convert(string DeMinifiedJs, string SdkToolsDts);
}

public interface IIlTranslator
{
    IlMethodBody TranslateBlock(InstructionBlock Block, IReadOnlyDictionary<ulong, string> IatMap);
}

public interface IGpuIlTranslator
{
    IlMethodBody[] TranslateBlocksParallel(InstructionBlock[] Blocks, IReadOnlyDictionary<ulong, string> IatMap);
    bool IsGpuAvailable { get; }
}

public interface IAssemblyEmitter
{
    TranspileResult Emit(IlMethodBody[] Methods, PeImage SourceImage, string OutputPath);
}

public interface IProjectGenerator
{
    BlazorProject Generate(string OutputDir, string Namespace, string AppTitle, TranspileResult TranspileResult);
}

public interface IGpuDeviceProvider
{
    bool HasDirectX12Device { get; }
    int MaxThreadCount { get; }
    string DeviceName { get; }
}
```

---

## 11. Transpile Pipeline Orchestration

```
1. IPeParser.Parse(ExePath) -> PeImage
2. IBunExtractor.Extract(ExePath) -> ExtractedBundle
3. IBundleVerifier.Verify(Bundle, ReferenceJsPath) -> bool (optional, dev only)
4. IJsDeMinifier.DeMinify(Bundle.EntryPoint.Contents) -> string
5. IJsToCSharpConverter.Convert(DeMinifiedJs, SdkToolsDts) -> string[] (C# files)
6. IBlockDiscoverer.DiscoverBlocks(PeImage) -> InstructionBlock[] (for runtime stubs)
7. IGpuIlTranslator.TranslateBlocksParallel(Blocks, IatMap) -> IlMethodBody[]
   (falls back to IIlTranslator.TranslateBlock per block if no GPU)
8. IAssemblyEmitter.Emit(Methods, PeImage, OutputPath) -> TranspileResult
9. IProjectGenerator.Generate(OutDir, Namespace, Title, Result) -> BlazorProject
```

---

## 12. Generated Blazor WASM Project Structure

### 12.1 Application Logic (from Track A: JS to C#)

```
src/PrTask.Claude.Wasm/
    PrTask.Claude.Wasm.csproj
    Program.cs
    wwwroot/
        index.html
        css/
            app.css
        js/
            xterm-interop.js
    Components/
        App.razor
        TerminalView.razor
        ConversationView.razor
        ToolResultView.razor
        InputBar.razor
        StatusBar.razor
        PermissionDialog.razor
    Services/
        AnthropicApiClient.cs
        ConversationManager.cs
        ToolExecutor.cs
        ToolRegistry.cs
        StreamingHandler.cs
        LocalDaemonProxy.cs
    Polyfills/
        ProcessShim.cs
        FileSystemShim.cs
        ChildProcessShim.cs
        PathShim.cs
        OsShim.cs
    Domain/
        Constants/
            ApiConstants.cs
            ToolConstants.cs
            ModelConstants.cs
        Models/
            Message.cs
            ToolUse.cs
            ToolResult.cs
            ContentBlock.cs
            ConversationState.cs
            TokenUsage.cs
    lib/
        TranspiledBinary.dll    <-- GPU-compiled IL assembly (Track B)
```

### 12.2 Clean-Room Domain Architecture (long-term)

```
src/PrTask.Claude.Domain/
    Models/
        Message.cs
        ContentBlock.cs
        ToolUse.cs
        ToolResult.cs
        ConversationState.cs
        SystemPrompt.cs
    Constants/
        ApiConstants.cs
        ToolConstants.cs
        ModelConstants.cs
    Interfaces/
        IAnthropicClient.cs
        IToolExecutor.cs
        IConversationStore.cs

src/PrTask.Claude.Application/
    Services/
        ConversationService.cs
        ToolDispatchService.cs
        SystemPromptBuilder.cs
        PermissionService.cs
        StreamingService.cs
    Handlers/
        BashToolHandler.cs
        FileReadToolHandler.cs
        FileWriteToolHandler.cs
        FileEditToolHandler.cs
        GlobToolHandler.cs
        GrepToolHandler.cs
        WebFetchToolHandler.cs
        WebSearchToolHandler.cs
        AgentToolHandler.cs
        NotebookEditToolHandler.cs

src/PrTask.Claude.Infrastructure/
    Anthropic/
        AnthropicHttpClient.cs
        AnthropicAuthProvider.cs
    LocalDaemon/
        DaemonWebSocketClient.cs
    Storage/
        IndexedDbStore.cs
        FileSystemAccessStore.cs
```

### 12.3 Estimated WASM Bundle Size

| Component | Estimated Size (brotli) |
|-----------|------------------------|
| Mono WASM runtime | 2-4 MB |
| Application assemblies | 500 KB - 2 MB |
| xterm.js | 200 KB |
| Total | 3-6 MB |

Compare to claude.exe at 231 MB -- this is a **38-77x size reduction**.

---

## 13. Key Questions Answered

### Is claude.exe a Node.js SEA?

**NO.** It is a **Bun standalone executable**. Evidence:
- `.bun` PE section containing 116 MB of bundled JS/bytecode
- `bun` string at byte offset 825 in the binary
- `__bun` string at offset 2,379,722
- `file:///B:/%7EBUN/root/src/entrypoints/cli.js` as the entry point path (Bun's virtual filesystem prefix)
- `// @bun @bytecode @bun-cjs` header in the embedded module
- Trailer `\n---- Bun! ----\n` confirmed at end of `.bun` section
- Bun format documented in `C:\work\bun\src\StandaloneModuleGraph.zig`

### Can we extract the JS bundle?

**YES**, confirmed. The extraction algorithm:

1. Parse PE headers to find `.bun` section (raw offset `0x0730B400`, size `0x07420C00`)
2. Read first 8 bytes as `uint64` little-endian payload length (121,768,627 bytes confirmed)
3. Read last 16 bytes of payload to verify trailer (`\n---- Bun! ----\n` confirmed)
4. Read `Offsets` struct (32 bytes before trailer) to get module list pointer
5. Parse `CompiledModuleGraphFile` array to get individual file names and contents
6. Extract each file's source code from the string table

The C code that reads the PE section is in `C:\work\bun\src\bun.js\bindings\c-bindings.cpp` lines 954-995.

### What is the most practical path to running in a browser?

**Track A (JavaScript Source Transpilation)** for application logic, with **Track B (IL Emission)** for native runtime stubs. Long-term: clean-room reimplementation based on the transpiled understanding of the codebase.

**Rationale**:
1. The application is fundamentally an HTTP API client (sends messages to `api.anthropic.com/v1/messages`, processes streaming responses, dispatches tool calls) -- straightforward in C#/.NET.
2. The `dangerouslyAllowBrowser: true` flag appears 7 times in the bundle, confirming browser support.
3. The core conversation loop is ~500 lines of core logic.
4. The `sdk-tools.d.ts` (119 KB) provides a complete, typed specification of every tool's input and output schemas.

---

## 14. Implementation Tasks

### Phase 1: Domain Layer

| # | Task | File |
|---|------|------|
| 1.1 | Create Domain project | `src/PrTask.Transpiler.Domain/PrTask.Transpiler.Domain.csproj` |
| 1.2 | PE constants | `src/PrTask.Transpiler.Domain/Constants/PeConstants.cs` |
| 1.3 | Bun constants | `src/PrTask.Transpiler.Domain/Constants/BunConstants.cs` |
| 1.4 | IL constants | `src/PrTask.Transpiler.Domain/Constants/IlConstants.cs` |
| 1.5 | Register constants | `src/PrTask.Transpiler.Domain/Constants/RegisterConstants.cs` |
| 1.6 | Memory constants | `src/PrTask.Transpiler.Domain/Constants/MemoryConstants.cs` |
| 1.7 | Blazor constants | `src/PrTask.Transpiler.Domain/Constants/BlazorConstants.cs` |
| 1.8 | GPU constants | `src/PrTask.Transpiler.Domain/Constants/GpuConstants.cs` |
| 1.9 | All enums | `src/PrTask.Transpiler.Domain/Enums/MnemonicId.cs` + 4 more |
| 1.10 | All models | `src/PrTask.Transpiler.Domain/Models/DecodedInstruction.cs` + 15 more |

### Phase 2: Application Layer

| # | Task | File |
|---|------|------|
| 2.1 | Create Application project | `src/PrTask.Transpiler.Application/PrTask.Transpiler.Application.csproj` |
| 2.2 | All interfaces | `src/PrTask.Transpiler.Application/Interfaces/IPeParser.cs` + 12 more |
| 2.3 | All services | `src/PrTask.Transpiler.Application/Services/TranspilePipeline.cs` + 11 more |

### Phase 3: Infrastructure -- Bundle Extraction

| # | Task | File |
|---|------|------|
| 3.1 | Create Infrastructure project | `src/PrTask.Transpiler.Infrastructure/PrTask.Transpiler.Infrastructure.csproj` |
| 3.2 | Bun section extractor | `src/PrTask.Transpiler.Infrastructure/Extraction/BunSectionExtractor.cs` |
| 3.3 | Bun module parser | `src/PrTask.Transpiler.Infrastructure/Extraction/BunModuleParser.cs` |
| 3.4 | Bundle comparer | `src/PrTask.Transpiler.Infrastructure/Extraction/BundleComparer.cs` |

### Phase 4: Infrastructure -- JS Transpilation

| # | Task | File |
|---|------|------|
| 4.1 | JS deminifier | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/JsDeMinifier.cs` |
| 4.2 | JS lexer | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/JsLexer.cs` |
| 4.3 | JS AST nodes | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/JsAstNode.cs` |
| 4.4 | JS parser | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/JsParser.cs` |
| 4.5 | Scope analyzer | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/JsScopeAnalyzer.cs` |
| 4.6 | Type inferencer | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/JsTypeInferencer.cs` |
| 4.7 | C# emitter | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/CSharpEmitter.cs` |
| 4.8 | Type mapper | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/TypeMapper.cs` |
| 4.9 | React-to-Blazor mapper | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/ReactToBlazorMapper.cs` |
| 4.10 | Node API replacer | `src/PrTask.Transpiler.Infrastructure/JsTranspilation/NodeApiReplacer.cs` |

### Phase 5: Infrastructure -- x86 Decoding and IL Emission

| # | Task | File |
|---|------|------|
| 5.1 | Iced decoder wrapper | `src/PrTask.Transpiler.Infrastructure/Decoding/IcedDecoder.cs` |
| 5.2 | Block discoverer | `src/PrTask.Transpiler.Infrastructure/Decoding/IcedBlockDiscoverer.cs` |
| 5.3 | Metadata IL emitter | `src/PrTask.Transpiler.Infrastructure/Emission/MetadataIlEmitter.cs` |
| 5.4 | Method body encoder | `src/PrTask.Transpiler.Infrastructure/Emission/MethodBodyEncoder.cs` |
| 5.5 | x86-to-IL mapper | `src/PrTask.Transpiler.Infrastructure/Emission/X86ToIlMapper.cs` |
| 5.6 | Type definition builder | `src/PrTask.Transpiler.Infrastructure/Emission/TypeDefinitionBuilder.cs` |
| 5.7 | Assembly builder | `src/PrTask.Transpiler.Infrastructure/Emission/AssemblyBuilder.cs` |

### Phase 6: Infrastructure -- GPU Acceleration

| # | Task | File |
|---|------|------|
| 6.1 | ComputeSharp device | `src/PrTask.Transpiler.Infrastructure/Gpu/ComputeSharpDevice.cs` |
| 6.2 | IL translation kernel | `src/PrTask.Transpiler.Infrastructure/Gpu/IlTranslationKernel.cs` |
| 6.3 | GPU block allocator | `src/PrTask.Transpiler.Infrastructure/Gpu/GpuBlockAllocator.cs` |
| 6.4 | GPU result collector | `src/PrTask.Transpiler.Infrastructure/Gpu/GpuResultCollector.cs` |

### Phase 7: Infrastructure -- Blazor Project Generation

| # | Task | File |
|---|------|------|
| 7.1 | Blazor project writer | `src/PrTask.Transpiler.Infrastructure/Generation/BlazorProjectWriter.cs` |
| 7.2 | .csproj generator | `src/PrTask.Transpiler.Infrastructure/Generation/CsprojGenerator.cs` |
| 7.3 | Program.cs generator | `src/PrTask.Transpiler.Infrastructure/Generation/ProgramCsGenerator.cs` |
| 7.4 | Index.razor generator | `src/PrTask.Transpiler.Infrastructure/Generation/IndexRazorGenerator.cs` |
| 7.5 | App.razor generator | `src/PrTask.Transpiler.Infrastructure/Generation/AppRazorGenerator.cs` |
| 7.6 | _Imports.razor generator | `src/PrTask.Transpiler.Infrastructure/Generation/ImportsRazorGenerator.cs` |
| 7.7 | index.html generator | `src/PrTask.Transpiler.Infrastructure/Generation/IndexHtmlGenerator.cs` |
| 7.8 | CSS generator | `src/PrTask.Transpiler.Infrastructure/Generation/CssGenerator.cs` |

### Phase 8: Host / Entry Point

| # | Task | File |
|---|------|------|
| 8.1 | Update transpiler entry point | `src/PrTask.Transpiler/Program.cs` |
| 8.2 | Update transpiler .csproj | `src/PrTask.Transpiler/PrTask.Transpiler.csproj` |

### Phase 9: Blazor WASM Application (Clean-Room)

| # | Task | File |
|---|------|------|
| 9.1 | Anthropic API client | `src/PrTask.Claude.Infrastructure/Anthropic/AnthropicHttpClient.cs` |
| 9.2 | Auth provider | `src/PrTask.Claude.Infrastructure/Anthropic/AnthropicAuthProvider.cs` |
| 9.3 | Message models | `src/PrTask.Claude.Domain/Models/` |
| 9.4 | Streaming handler | `src/PrTask.Claude.Application/Services/StreamingService.cs` |
| 9.5 | Tool registry | `src/PrTask.Claude.Application/Services/ToolRegistry.cs` |
| 9.6 | Tool dispatcher | `src/PrTask.Claude.Application/Services/ToolDispatchService.cs` |
| 9.7 | All tool handlers | `src/PrTask.Claude.Application/Handlers/*.cs` |
| 9.8 | Conversation service | `src/PrTask.Claude.Application/Services/ConversationService.cs` |
| 9.9 | System prompt builder | `src/PrTask.Claude.Application/Services/SystemPromptBuilder.cs` |
| 9.10 | Terminal component | `src/PrTask.Claude.Wasm/Components/Terminal.razor` |
| 9.11 | Message renderer | `src/PrTask.Claude.Wasm/Components/MessageList.razor` |
| 9.12 | Input component | `src/PrTask.Claude.Wasm/Components/InputArea.razor` |
| 9.13 | Permission dialog | `src/PrTask.Claude.Wasm/Components/PermissionDialog.razor` |

### Phase 10: Local Daemon

| # | Task | File |
|---|------|------|
| 10.1 | Daemon service | `src/PrTask.Claude.Daemon/` |
| 10.2 | Bash executor | `src/PrTask.Claude.Daemon/Executors/BashExecutor.cs` |
| 10.3 | File system executor | `src/PrTask.Claude.Daemon/Executors/FileSystemExecutor.cs` |
| 10.4 | Security sandbox | `src/PrTask.Claude.Daemon/Security/SandboxPolicy.cs` |

### Phase 11: Testing

| # | Task | File |
|---|------|------|
| 11.1 | Bundle extraction tests | `tests/PrTask.Transpiler.Tests/BunExtractionTests.cs` |
| 11.2 | Bundle comparison tests | `tests/PrTask.Transpiler.Tests/BundleComparisonTests.cs` |
| 11.3 | x86-to-IL mapper tests | `tests/PrTask.Transpiler.Tests/X86ToIlMapperTests.cs` |
| 11.4 | Assembly builder tests | `tests/PrTask.Transpiler.Tests/AssemblyBuilderTests.cs` |
| 11.5 | JS deminifier tests | `tests/PrTask.Transpiler.Tests/JsDeMinifierTests.cs` |
| 11.6 | GPU vs CPU verification | `tests/PrTask.Transpiler.Tests/GpuCpuParityTests.cs` |
| 11.7 | E2E integration test | `tests/PrTask.Claude.E2E/` |
| 11.8 | API client tests | `tests/PrTask.Claude.Tests/` |

### Phase 12: Optimization

| # | Task |
|---|------|
| 12.1 | Profile GPU vs CPU translation throughput |
| 12.2 | Optimize IL emission (minimize stack depth, use short-form opcodes) |
| 12.3 | Dead block elimination (remove unreachable blocks) |
| 12.4 | Constant folding in IL (pre-compute known values at transpile time) |
| 12.5 | WASM bundle size optimization |

---

## 15. NuGet Package References

### PrTask.Transpiler.Infrastructure.csproj
```xml
<PackageReference Include="Iced" Version="1.*" />
<PackageReference Include="ComputeSharp" Version="3.*" />
```

`System.Reflection.Metadata` is included in the .NET 11 SDK (no separate package needed).

### Generated Blazor Project
```xml
<PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="11.0.0-preview.2.26159.112" />
```

---

## 16. Build and Deployment

### Build Command

```powershell
dotnet build src/PrTask.Claude.Wasm -c Release

dotnet publish src/PrTask.Claude.Wasm -c Release -o publish/claude-wasm
```

### Transpiler Invocation

```
dotnet run --project src/PrTask.Transpiler -- C:\Users\user\.local\bin\claude.exe C:\work\prtask.com\src\PrTask.Claude.Wasm\Generated PrTask.Claude.Wasm.Generated
```

This would:
1. Parse PE, find `.bun` section
2. Extract JS bundle from `.bun` section
3. Verify against `C:\work\claudecode\cli.js` (if available)
4. Deminify the extracted JS
5. Parse to AST, reconstruct modules
6. Apply type inference using `sdk-tools.d.ts`
7. Generate C# source files in `Generated/`
8. Generate Blazor `.razor` components
9. Emit IL DLL for native runtime stubs

---

## 17. Code Quality Requirements

All generated and hand-written code MUST follow:

1. **PascalCase everywhere** -- properties, methods, variables, parameters, constants
2. **No magic strings/numbers/string interpolation** -- all values in domain constants classes. String interpolation (`$"..."`) is allowed ONLY inside domain constants classes. Outside constants, always reference domain constants using string interpolation with domain constants only.
3. **Nullable reference types** enabled everywhere
4. **File-scoped namespaces** (`namespace X;` not `namespace X { }`)
5. **Primary constructors** where applicable
6. **`sealed` on all non-inherited classes**
7. **`internal` default visibility** (not `public` unless required)
8. **`readonly` on all immutable fields**

---

## 18. Reference Files Summary

### Claude Code Sources
- `C:\work\claudecode\cli.js` -- 12 MB minified JS bundle (THE application)
- `C:\work\claudecode\sdk-tools.d.ts` -- 119 KB tool type definitions (THE API contract)
- `C:\work\claudecode\package.json` -- Package metadata
- `C:\work\claudecode\resvg.wasm` -- SVG renderer (already WASM)
- `C:\work\claudecode\vendor/` -- Native binaries (ripgrep, tree-sitter, audio-capture)
- `C:\work\claude-code/` -- Open-source plugins, hooks, examples (NOT the app source)

### Bun Binary Format
- `C:\work\bun\src\StandaloneModuleGraph.zig` -- 69 KB, standalone binary format spec
- `C:\work\bun\src\bun.js\bindings\c-bindings.cpp` -- PE section reader (lines 954-995)
- `C:\work\bun\src\api\schema.zig` -- StringPointer definition (line 832)
- `C:\work\bun\src\pe.zig` -- PE format handling
- `C:\work\bun\src\elf.zig` -- ELF format handling
- `C:\work\bun\src\cli\build_command.zig` -- `bun build --compile` entry
- `C:\work\bun\src\bundler\bundle_v2.zig` -- Bundler module graph

### Existing Transpiler
- `C:\work\prtask.com\src\PrTask.Transpiler\X86ToSharpConverter.cs` -- 64 KB, x86-to-C# transpiler
- `C:\work\prtask.com\src\PrTask.Transpiler\TsToSharpConverter.cs` -- 18 KB, TS-to-C# transpiler
- `C:\work\prtask.com\src\PrTask.Transpiler\BinaryToSharpConverter.cs` -- 18 KB, managed/native PE converter
- `C:\work\prtask.com\src\PrTask.Transpiler\BlazorProjectGenerator.cs` -- 11 KB, generates Blazor WASM projects
- `C:\work\prtask.com\src\PrTask.Transpiler\CpuState.cs` -- 2.1 KB, x86 register state
- `C:\work\prtask.com\src\PrTask.Transpiler\VirtualMemory.cs` -- 10 KB, page-based memory emulator

### .NET Framework References
- `C:\work\dotnet\runtime\src\libraries\System.Reflection.Metadata\src\System\Reflection\Metadata\Ecma335\` -- IL emission APIs
- `C:\work\dotnet\runtime\src\mono\browser\` -- Mono WASM runtime (browser target)
- `C:\work\dotnet\aspnetcore\src\Components\WebAssembly\` -- Blazor WASM framework
- `C:\work\dotnet\sdk\` -- Build targets for Blazor WASM publishing

### Target Binary
- `C:\Users\user\.local\bin\claude.exe` -- 231 MB Bun standalone executable
  - `.text` section: 63 MB native code (Bun runtime + JavaScriptCore)
  - `.bun` section: 116 MB embedded JS bundle + JSC bytecode
  - Entry point: `file:///B:/%7EBUN/root/src/entrypoints/cli.js`
  - Trailer: `\n---- Bun! ----\n` (confirmed at end of .bun section)
  - Payload size field: 121,768,627 bytes (confirmed at start of .bun section)

### Source File Cross-Reference

| Component | Current File | New Location | Runtime/Roslyn Reference |
|---|---|---|---|
| PE parsing | X86ToSharpConverter.cs:23-67 | Infrastructure/Decoding/IcedDecoder.cs | System.Reflection.PortableExecutable.PEReader |
| Bundle extraction | (new) | Infrastructure/Extraction/BunSectionExtractor.cs | StandaloneModuleGraph.zig format |
| Export reading | X86ToSharpConverter.cs:99-170 | Application/Services/PeParseService.cs | PEHeaders.PEHeader.ExportTableDirectory |
| Import reading | X86ToSharpConverter.cs:172-274 | Application/Services/PeParseService.cs | PEHeaders.PEHeader.ImportTableDirectory |
| Block discovery | X86ToSharpConverter.cs:354-424 | Infrastructure/Decoding/IcedBlockDiscoverer.cs | Iced.Intel.Decoder.Create |
| Instruction emit | X86ToSharpConverter.cs:580-843 | Infrastructure/Emission/X86ToIlMapper.cs | InstructionEncoder (Ecma335) |
| CPU state | CpuState.cs:1-95 | Domain/Models/RegisterState.cs + Infrastructure/Emission/TypeDefinitionBuilder.cs | MetadataBuilder.AddFieldDefinition |
| Memory | VirtualMemory.cs:1-295 | Emitted in TypeDefinitionBuilder.cs as IL helper methods | InstructionEncoder.OpCode |
| Win32 stubs | Kernel32Stubs.cs, MsvcrtStubs.cs, Win32Dispatcher.cs | Emitted in TypeDefinitionBuilder.cs as IL stub methods | InstructionEncoder.LoadConstantI8 |
| Blazor gen | BlazorProjectGenerator.cs:1-245 | Infrastructure/Generation/BlazorProjectWriter.cs | sdk/src/BlazorWasmSdk targets |
| DLL output | (new) | Infrastructure/Emission/AssemblyBuilder.cs | ManagedPEBuilder, MetadataRootBuilder |
| GPU accel | (new) | Infrastructure/Gpu/IlTranslationKernel.cs | ComputeSharp IComputeShader |
| JS transpile | TsToSharpConverter.cs | Infrastructure/JsTranspilation/ | (new) |
