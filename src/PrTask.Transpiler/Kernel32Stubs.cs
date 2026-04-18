namespace PrTask.Transpiler;

public sealed class Kernel32Stubs
{
    public const string DllName = "KERNEL32.DLL";

    private const ulong InvalidHandleValue = unchecked((ulong)-1);
    private const ulong DefaultHeapHandle = 0x00010000UL;
    private const ulong ModuleBaseHandle = 0x00400000UL;
    private const ulong StubProcAddr = 0xDEAD0000UL;
    private const ulong StdOutFakeHandle = 0x0000000CUL;
    private const ulong StdErrFakeHandle = 0x00000010UL;
    private const ulong StdInFakeHandle = 0x00000008UL;
    private const ulong UnixEpochTicks = 116444736000000000UL;
    private const ulong PerfFrequency = 10000000UL;

    private readonly Win32Dispatcher Dispatcher;
    private uint NextTlsIndex;
    private readonly Dictionary<uint, ulong> TlsSlots = new();
    private ulong CommandLinePtr;
    private long PerfCounter = 1000000;

    public Kernel32Stubs(Win32Dispatcher Dispatcher)
    {
        this.Dispatcher = Dispatcher;
    }

    public ulong GetModuleHandleW(CpuState S)
    {
        return ModuleBaseHandle;
    }

    public ulong GetProcAddress(CpuState S)
    {
        return StubProcAddr;
    }

    public ulong LoadLibraryW(CpuState S)
    {
        return ModuleBaseHandle + 0x10000;
    }

    public ulong VirtualAlloc(CpuState S)
    {
        var Size = S.GetArg(1);
        if (Size == 0)
        {
            Size = 4096;
        }

        return Dispatcher.HeapAllocate(S.Memory, Size);
    }

    public ulong VirtualFree(CpuState S)
    {
        var Addr = S.GetArg(0);
        Dispatcher.HeapFree(S.Memory, Addr);
        return 1;
    }

    public ulong VirtualProtect(CpuState S)
    {
        var OldProtectPtr = S.GetArg(3);
        if (OldProtectPtr != 0)
        {
            S.Memory.Write32(OldProtectPtr, 0x40);
        }

        return 1;
    }

    public ulong HeapCreate(CpuState S)
    {
        return DefaultHeapHandle;
    }

    public ulong HeapAlloc(CpuState S)
    {
        var Size = S.GetArg(2);
        var Flags = S.GetArg(1);
        if (Size == 0)
        {
            Size = 1;
        }

        var Addr = Dispatcher.HeapAllocate(S.Memory, Size);
        if ((Flags & 0x08) != 0 && Addr != 0)
        {
            for (ulong I = 0; I < Size; I++)
            {
                S.Memory.Write8(Addr + I, 0);
            }
        }

        return Addr;
    }

    public ulong HeapFree(CpuState S)
    {
        var Ptr = S.GetArg(2);
        if (Ptr != 0)
        {
            Dispatcher.HeapFree(S.Memory, Ptr);
        }

        return 1;
    }

    public ulong GetProcessHeap(CpuState S)
    {
        return DefaultHeapHandle;
    }

    public ulong GetLastError(CpuState S)
    {
        return Dispatcher.CurrentLastError;
    }

    public ulong SetLastError(CpuState S)
    {
        Dispatcher.SetLastError(S.GetArg(0));
        return 0;
    }

    public ulong GetCurrentProcessId(CpuState S)
    {
        return 4200;
    }

    public ulong GetCurrentThreadId(CpuState S)
    {
        return 1;
    }

    public ulong GetSystemTimeAsFileTime(CpuState S)
    {
        var Ptr = S.GetArg(0);
        if (Ptr != 0)
        {
            var Ticks = (ulong)DateTimeOffset.UtcNow.Ticks - 621355968000000000UL + UnixEpochTicks;
            S.Memory.Write32(Ptr, (uint)Ticks);
            S.Memory.Write32(Ptr + 4, (uint)(Ticks >> 32));
        }

        return 0;
    }

    public ulong QueryPerformanceCounter(CpuState S)
    {
        var Ptr = S.GetArg(0);
        if (Ptr != 0)
        {
            PerfCounter += 1000;
            S.Memory.Write64(Ptr, (ulong)PerfCounter);
        }

        return 1;
    }

    public ulong QueryPerformanceFrequency(CpuState S)
    {
        var Ptr = S.GetArg(0);
        if (Ptr != 0)
        {
            S.Memory.Write64(Ptr, PerfFrequency);
        }

        return 1;
    }

    public ulong IsProcessorFeaturePresent(CpuState S)
    {
        return 1;
    }

    public ulong InitializeCriticalSection(CpuState S)
    {
        return 0;
    }

    public ulong EnterCriticalSection(CpuState S)
    {
        return 0;
    }

    public ulong LeaveCriticalSection(CpuState S)
    {
        return 0;
    }

    public ulong DeleteCriticalSection(CpuState S)
    {
        return 0;
    }

    public ulong TlsAlloc(CpuState S)
    {
        var Index = NextTlsIndex++;
        TlsSlots[Index] = 0;
        return Index;
    }

    public ulong TlsGetValue(CpuState S)
    {
        var Index = (uint)S.GetArg(0);
        Dispatcher.SetLastError(0);
        return TlsSlots.TryGetValue(Index, out var Val) ? Val : 0;
    }

    public ulong TlsSetValue(CpuState S)
    {
        var Index = (uint)S.GetArg(0);
        var Value = S.GetArg(1);
        TlsSlots[Index] = Value;
        return 1;
    }

    public ulong ExitProcess(CpuState S)
    {
        return 0;
    }

    public ulong GetCommandLineW(CpuState S)
    {
        if (CommandLinePtr == 0)
        {
            CommandLinePtr = Dispatcher.HeapAllocate(S.Memory, 512);
            var Str = "program.exe";
            for (var I = 0; I < Str.Length; I++)
            {
                S.Memory.Write16(CommandLinePtr + (ulong)(I * 2), Str[I]);
            }

            S.Memory.Write16(CommandLinePtr + (ulong)(Str.Length * 2), 0);
        }

        return CommandLinePtr;
    }

    public ulong GetStdHandle(CpuState S)
    {
        var Id = S.GetArg(0);
        return Id switch
        {
            unchecked((ulong)(uint)-10) => StdInFakeHandle,
            unchecked((ulong)(uint)-11) => StdOutFakeHandle,
            unchecked((ulong)(uint)-12) => StdErrFakeHandle,
            _ => InvalidHandleValue
        };
    }

    public ulong WriteFile(CpuState S)
    {
        var Handle = S.GetArg(0);
        var BufPtr = S.GetArg(1);
        var BytesToWrite = (uint)S.GetArg(2);
        var BytesWrittenPtr = S.GetArg(3);
        if (BytesWrittenPtr != 0)
        {
            S.Memory.Write32(BytesWrittenPtr, BytesToWrite);
        }

        if (Handle == StdOutFakeHandle || Handle == StdErrFakeHandle)
        {
            var Buf = S.Memory.ReadBytes(BufPtr, (int)BytesToWrite);
            Console.Write(System.Text.Encoding.UTF8.GetString(Buf));
        }

        return 1;
    }

    public ulong CloseHandle(CpuState S)
    {
        return 1;
    }

    public ulong CreateFileW(CpuState S)
    {
        return InvalidHandleValue;
    }
}
