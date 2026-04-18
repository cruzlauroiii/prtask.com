namespace PrTask.Transpiler;

public sealed class MsvcrtStubs
{
    private readonly Win32Dispatcher Dispatcher;
    private readonly ulong SecurityCookie = 0x00002B992DDFA232UL;

    public MsvcrtStubs(Win32Dispatcher Dispatcher)
    {
        this.Dispatcher = Dispatcher;
    }

    public ulong Malloc(CpuState S)
    {
        var Size = S.GetArg(0);
        if (Size == 0)
        {
            Size = 1;
        }

        return Dispatcher.HeapAllocate(S.Memory, Size);
    }

    public ulong Free(CpuState S)
    {
        var Ptr = S.GetArg(0);
        if (Ptr != 0)
        {
            Dispatcher.HeapFree(S.Memory, Ptr);
        }

        return 0;
    }

    public ulong Calloc(CpuState S)
    {
        var Count = S.GetArg(0);
        var Size = S.GetArg(1);
        var Total = Count * Size;
        if (Total == 0)
        {
            Total = 1;
        }

        var Addr = Dispatcher.HeapAllocate(S.Memory, Total);
        if (Addr != 0)
        {
            for (ulong I = 0; I < Total; I++)
            {
                S.Memory.Write8(Addr + I, 0);
            }
        }

        return Addr;
    }

    public ulong Realloc(CpuState S)
    {
        var Ptr = S.GetArg(0);
        var NewSize = S.GetArg(1);
        if (Ptr == 0)
        {
            return Dispatcher.HeapAllocate(S.Memory, NewSize == 0 ? 1 : NewSize);
        }

        if (NewSize == 0)
        {
            Dispatcher.HeapFree(S.Memory, Ptr);
            return 0;
        }

        var NewAddr = Dispatcher.HeapAllocate(S.Memory, NewSize);
        if (NewAddr != 0)
        {
            var Bytes = S.Memory.ReadBytes(Ptr, (int)Math.Min(NewSize, 1048576));
            S.Memory.WriteBytes(NewAddr, Bytes);
        }

        Dispatcher.HeapFree(S.Memory, Ptr);
        return NewAddr;
    }

    public ulong Memset(CpuState S)
    {
        var Dest = S.GetArg(0);
        var Val = (byte)S.GetArg(1);
        var Count = S.GetArg(2);
        for (ulong I = 0; I < Count; I++)
        {
            S.Memory.Write8(Dest + I, Val);
        }

        return Dest;
    }

    public ulong Memcpy(CpuState S)
    {
        var Dest = S.GetArg(0);
        var Src = S.GetArg(1);
        var Count = S.GetArg(2);
        if (Count > 0)
        {
            var Bytes = S.Memory.ReadBytes(Src, (int)Math.Min(Count, 1048576));
            S.Memory.WriteBytes(Dest, Bytes);
        }

        return Dest;
    }

    public ulong Memmove(CpuState S)
    {
        var Dest = S.GetArg(0);
        var Src = S.GetArg(1);
        var Count = S.GetArg(2);
        if (Count > 0)
        {
            var TempBytes = S.Memory.ReadBytes(Src, (int)Math.Min(Count, 1048576));
            var TempCopy = new byte[TempBytes.Length];
            Array.Copy(TempBytes, TempCopy, TempBytes.Length);
            S.Memory.WriteBytes(Dest, TempCopy);
        }

        return Dest;
    }

    public ulong Strlen(CpuState S)
    {
        var Ptr = S.GetArg(0);
        ulong Len = 0;
        while (S.Memory.Read8(Ptr + Len) != 0 && Len < 1048576)
        {
            Len++;
        }

        return Len;
    }

    public ulong Strcmp(CpuState S)
    {
        var A = S.GetArg(0);
        var B = S.GetArg(1);
        for (ulong I = 0; I < 1048576; I++)
        {
            var Ca = S.Memory.Read8(A + I);
            var Cb = S.Memory.Read8(B + I);
            if (Ca != Cb)
            {
                return Ca < Cb ? unchecked((ulong)-1) : 1;
            }

            if (Ca == 0)
            {
                return 0;
            }
        }

        return 0;
    }

    public ulong Strcpy(CpuState S)
    {
        var Dest = S.GetArg(0);
        var Src = S.GetArg(1);
        ulong I = 0;
        byte B;
        do
        {
            B = S.Memory.Read8(Src + I);
            S.Memory.Write8(Dest + I, B);
            I++;
        }
        while (B != 0 && I < 1048576);

        return Dest;
    }

    public ulong Printf(CpuState S)
    {
        var FmtPtr = S.GetArg(0);
        var Builder = new System.Text.StringBuilder();
        ulong Pos = 0;
        byte Ch;
        while ((Ch = S.Memory.Read8(FmtPtr + Pos)) != 0 && Pos < 4096)
        {
            Builder.Append((char)Ch);
            Pos++;
        }

        var Fmt = Builder.ToString();
        Console.Write(Fmt);
        return (ulong)Fmt.Length;
    }

    public ulong InitTerm(CpuState S)
    {
        return 0;
    }

    public ulong InitTermE(CpuState S)
    {
        return 0;
    }

    public ulong SecurityInitCookie(CpuState S)
    {
        return SecurityCookie;
    }

    public ulong SetAppType(CpuState S)
    {
        return 0;
    }

    public ulong SetNewMode(CpuState S)
    {
        return 0;
    }

    public ulong Exit(CpuState S)
    {
        return 0;
    }

    public ulong Abort(CpuState S)
    {
        return 0;
    }

    public ulong Cexit(CpuState S)
    {
        return 0;
    }
}
