namespace PrTask.Transpiler;

public sealed class Win32Dispatcher
{
    private const ulong HeapBase = 0x20000000UL;
    private const ulong HeapMaxSize = 0x10000000UL;

    private readonly Dictionary<string, Dictionary<string, Func<CpuState, ulong>>> Table;
    private readonly HashSet<string> UnknownCalls = new(StringComparer.OrdinalIgnoreCase);
    private ulong HeapPointer = HeapBase;

    public Win32Dispatcher()
    {
        Table = new(StringComparer.OrdinalIgnoreCase);
        RegisterKernel32();
        RegisterMsvcrt();
    }

    public ulong Dispatch(string DllName, string FuncName, CpuState State)
    {
        var Normalized = NormalizeDllName(DllName);
        if (Table.TryGetValue(Normalized, out var Module) &&
            Module.TryGetValue(FuncName, out var Handler))
        {
            var Result = Handler(State);
            State.Rax = Result;
            return Result;
        }

        UnknownCalls.Add($"{DllName}!{FuncName}");
        State.Rax = 0;
        return 0;
    }

    public IReadOnlySet<string> UnknownCallSet => UnknownCalls;

    public ulong CurrentLastError { get; private set; }

    public void SetLastError(ulong Code) => CurrentLastError = Code;

    public ulong HeapAllocate(VirtualMemory Memory, ulong Size)
    {
        if (Size == 0)
        {
            Size = 1;
        }

        var Aligned = (Size + 15UL) & ~15UL;
        var Addr = HeapPointer;
        HeapPointer += Aligned;
        if (HeapPointer > HeapBase + HeapMaxSize)
        {
            return 0;
        }

        Memory.Allocate(Addr, (uint)Aligned);
        return Addr;
    }

    public void HeapFree(VirtualMemory Memory, ulong Addr)
    {
        if (Addr >= HeapBase && Addr < HeapBase + HeapMaxSize)
        {
            Memory.Free(Addr);
        }
    }

    private static string NormalizeDllName(string Name)
    {
        var Upper = Name.ToUpperInvariant();
        if (Upper.EndsWith(".DLL", StringComparison.Ordinal))
        {
            return Upper[..^4];
        }

        return Upper;
    }

    private void Register(string DllName, string FuncName, Func<CpuState, ulong> Handler)
    {
        var Normalized = NormalizeDllName(DllName);
        if (!Table.TryGetValue(Normalized, out var Module))
        {
            Module = new(StringComparer.OrdinalIgnoreCase);
            Table[Normalized] = Module;
        }
        Module[FuncName] = Handler;
    }

    private void RegisterKernel32()
    {
        var Stubs = new Kernel32Stubs(this);
        Register(Kernel32Stubs.DllName, "GetModuleHandleW", Stubs.GetModuleHandleW);
        Register(Kernel32Stubs.DllName, "GetProcAddress", Stubs.GetProcAddress);
        Register(Kernel32Stubs.DllName, "LoadLibraryW", Stubs.LoadLibraryW);
        Register(Kernel32Stubs.DllName, "VirtualAlloc", Stubs.VirtualAlloc);
        Register(Kernel32Stubs.DllName, "VirtualFree", Stubs.VirtualFree);
        Register(Kernel32Stubs.DllName, "VirtualProtect", Stubs.VirtualProtect);
        Register(Kernel32Stubs.DllName, "HeapCreate", Stubs.HeapCreate);
        Register(Kernel32Stubs.DllName, "HeapAlloc", Stubs.HeapAlloc);
        Register(Kernel32Stubs.DllName, "HeapFree", Stubs.HeapFree);
        Register(Kernel32Stubs.DllName, "GetProcessHeap", Stubs.GetProcessHeap);
        Register(Kernel32Stubs.DllName, "GetLastError", Stubs.GetLastError);
        Register(Kernel32Stubs.DllName, "SetLastError", Stubs.SetLastError);
        Register(Kernel32Stubs.DllName, "GetCurrentProcessId", Stubs.GetCurrentProcessId);
        Register(Kernel32Stubs.DllName, "GetCurrentThreadId", Stubs.GetCurrentThreadId);
        Register(Kernel32Stubs.DllName, "GetSystemTimeAsFileTime", Stubs.GetSystemTimeAsFileTime);
        Register(Kernel32Stubs.DllName, "QueryPerformanceCounter", Stubs.QueryPerformanceCounter);
        Register(Kernel32Stubs.DllName, "QueryPerformanceFrequency", Stubs.QueryPerformanceFrequency);
        Register(Kernel32Stubs.DllName, "IsProcessorFeaturePresent", Stubs.IsProcessorFeaturePresent);
        Register(Kernel32Stubs.DllName, "InitializeCriticalSection", Stubs.InitializeCriticalSection);
        Register(Kernel32Stubs.DllName, "EnterCriticalSection", Stubs.EnterCriticalSection);
        Register(Kernel32Stubs.DllName, "LeaveCriticalSection", Stubs.LeaveCriticalSection);
        Register(Kernel32Stubs.DllName, "DeleteCriticalSection", Stubs.DeleteCriticalSection);
        Register(Kernel32Stubs.DllName, "TlsAlloc", Stubs.TlsAlloc);
        Register(Kernel32Stubs.DllName, "TlsGetValue", Stubs.TlsGetValue);
        Register(Kernel32Stubs.DllName, "TlsSetValue", Stubs.TlsSetValue);
        Register(Kernel32Stubs.DllName, "ExitProcess", Stubs.ExitProcess);
        Register(Kernel32Stubs.DllName, "GetCommandLineW", Stubs.GetCommandLineW);
        Register(Kernel32Stubs.DllName, "GetStdHandle", Stubs.GetStdHandle);
        Register(Kernel32Stubs.DllName, "WriteFile", Stubs.WriteFile);
        Register(Kernel32Stubs.DllName, "CloseHandle", Stubs.CloseHandle);
        Register(Kernel32Stubs.DllName, "CreateFileW", Stubs.CreateFileW);
    }

    private void RegisterMsvcrt()
    {
        var Stubs = new MsvcrtStubs(this);
        var Names = new[] { "MSVCRT", "UCRTBASE", "API-MS-WIN-CRT-RUNTIME-L1-1-0",
                            "API-MS-WIN-CRT-HEAP-L1-1-0", "API-MS-WIN-CRT-STRING-L1-1-0",
                            "API-MS-WIN-CRT-STDIO-L1-1-0", "API-MS-WIN-CRT-MATH-L1-1-0",
                            "VCRUNTIME140" };
        foreach (var Dll in Names)
        {
            Register(Dll, "malloc", Stubs.Malloc);
            Register(Dll, "free", Stubs.Free);
            Register(Dll, "calloc", Stubs.Calloc);
            Register(Dll, "realloc", Stubs.Realloc);
            Register(Dll, "memset", Stubs.Memset);
            Register(Dll, "memcpy", Stubs.Memcpy);
            Register(Dll, "memmove", Stubs.Memmove);
            Register(Dll, "strlen", Stubs.Strlen);
            Register(Dll, "strcmp", Stubs.Strcmp);
            Register(Dll, "strcpy", Stubs.Strcpy);
            Register(Dll, "printf", Stubs.Printf);
            Register(Dll, "_initterm", Stubs.InitTerm);
            Register(Dll, "_initterm_e", Stubs.InitTermE);
            Register(Dll, "__security_init_cookie", Stubs.SecurityInitCookie);
            Register(Dll, "_set_app_type", Stubs.SetAppType);
            Register(Dll, "_set_new_mode", Stubs.SetNewMode);
            Register(Dll, "exit", Stubs.Exit);
            Register(Dll, "abort", Stubs.Abort);
            Register(Dll, "_cexit", Stubs.Cexit);
        }
    }
}
