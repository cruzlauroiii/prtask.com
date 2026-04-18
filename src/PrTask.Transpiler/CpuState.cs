using System.Numerics;
using System.Runtime.CompilerServices;

namespace PrTask.Transpiler;

public sealed class CpuState
{
    public ulong Rax { get; set; }

    public ulong Rbx { get; set; }

    public ulong Rcx { get; set; }

    public ulong Rdx { get; set; }

    public ulong Rsi { get; set; }

    public ulong Rdi { get; set; }

    public ulong Rsp { get; set; }

    public ulong Rbp { get; set; }

    public ulong R8 { get; set; }

    public ulong R9 { get; set; }

    public ulong R10 { get; set; }

    public ulong R11 { get; set; }

    public ulong R12 { get; set; }

    public ulong R13 { get; set; }

    public ulong R14 { get; set; }

    public ulong R15 { get; set; }

    public ulong Rip { get; set; }

    public bool Cf { get; set; }

    public bool Zf { get; set; }

    public bool Sf { get; set; }

    public bool Of { get; set; }

    public bool Pf { get; set; }

    public VirtualMemory Memory { get; set; }

    public CpuState(VirtualMemory Memory)
    {
        this.Memory = Memory;
    }

    public ulong GetArg(int Index) => Index switch
    {
        0 => Rcx,
        1 => Rdx,
        2 => R8,
        3 => R9,
        _ => Memory.Read64(Rsp + (ulong)(Index * 8) + 8)
    };

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void UpdateFlags(ulong Result, ulong A, ulong B, int Size)
    {
        var Mask = Size switch { 1 => 0xFFUL, 2 => 0xFFFFUL, 4 => 0xFFFFFFFFUL, _ => ulong.MaxValue };
        var Masked = Result & Mask;
        Zf = Masked == 0;
        Sf = (Masked & (1UL << ((Size * 8) - 1))) != 0;
        Cf = Result > Mask;
        var SignBit = 1UL << ((Size * 8) - 1);
        Of = ((A ^ Result) & (B ^ Result) & SignBit) != 0;
        Pf = (BitOperations.PopCount(Masked & 0xFF) & 1) == 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Push(ulong Val)
    {
        Rsp -= 8;
        Memory.Write64(Rsp, Val);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong Pop()
    {
        var Val = Memory.Read64(Rsp);
        Rsp += 8;
        return Val;
    }
}
