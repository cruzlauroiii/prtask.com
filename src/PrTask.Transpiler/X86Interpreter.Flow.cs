using System.Numerics;
using System.Runtime.CompilerServices;
using Iced.Intel;

namespace PrTask.Transpiler;

public sealed partial class X86Interpreter
{
    private void ExecJcc(ref Instruction Instr, bool Condition)
    {
        if (!Condition)
        {
            return;
        }

        var Target = GetBranchTarget(ref Instr);
        if (Target != 0)
        {
            State.Rip = Target;
        }
    }

    private StopReason? ExecJmp(ref Instruction Instr)
    {
        var Target = GetBranchTarget(ref Instr);
        if (Target != 0)
        {
            State.Rip = Target;
            return null;
        }

        if (Instr.Op0Kind == OpKind.Register)
        {
            State.Rip = ReadReg(Instr.Op0Register);
            return null;
        }

        if (Instr.Op0Kind == OpKind.Memory)
        {
            var MemAddr = ComputeMemAddr(ref Instr);
            if (TryDispatchIat(MemAddr))
            {
                return StopReason.Returned;
            }

            State.Rip = Mem.Read64(MemAddr);
            return null;
        }

        return StopReason.UnknownInstruction;
    }

    private StopReason? ExecCall(ref Instruction Instr)
    {
        if (Instr.Op0Kind == OpKind.Memory && Instr.IsIPRelativeMemoryOperand)
        {
            var MemAddr = Instr.IPRelativeMemoryAddress;
            if (TryDispatchIat(MemAddr))
            {
                return null;
            }
        }
        else if (Instr.Op0Kind == OpKind.Memory)
        {
            var MemAddr = ComputeMemAddr(ref Instr);
            if (TryDispatchIat(MemAddr))
            {
                return null;
            }
        }

        var Target = GetBranchTarget(ref Instr);
        if (Target == 0)
        {
            if (Instr.Op0Kind == OpKind.Register)
            {
                Target = ReadReg(Instr.Op0Register);
            }
            else if (Instr.Op0Kind == OpKind.Memory)
            {
                Target = Mem.Read64(ComputeMemAddr(ref Instr));
            }
        }

        if (Target == 0)
        {
            return null;
        }

        State.Push(State.Rip);
        var Result = Execute(Target, 100_000);
        if (Result == StopReason.Returned)
        {
            return null;
        }

        return Result;
    }

    private void ExecImul(ref Instruction Instr)
    {
        if (Instr.OpCount == 3)
        {
            var B = ReadOperand(ref Instr, 1);
            var C = ReadOperand(ref Instr, 2);
            WriteOperand(ref Instr, 0, B * C);
        }
        else if (Instr.OpCount == 2)
        {
            var A = ReadOperand(ref Instr, 0);
            var B = ReadOperand(ref Instr, 1);
            WriteOperand(ref Instr, 0, A * B);
        }
    }

    private void ExecMul(ref Instruction Instr)
    {
        var Size = GetOperandSize(ref Instr, 0);
        var Op = ReadOperand(ref Instr, 0);
        if (Size == 8)
        {
            var V = (UInt128)State.Rax * (UInt128)Op;
            State.Rax = (ulong)V;
            State.Rdx = (ulong)(V >> 64);
        }
        else
        {
            var V = (ulong)(uint)State.Rax * Op;
            State.Rax = (State.Rax & 0xFFFFFFFF00000000UL) | (uint)V;
            State.Rdx = (State.Rdx & 0xFFFFFFFF00000000UL) | (uint)(V >> 32);
        }
    }

    private void ExecDiv(ref Instruction Instr, bool IsSigned)
    {
        var Size = GetOperandSize(ref Instr, 0);
        var Op = ReadOperand(ref Instr, 0);
        if (Op == 0)
        {
            return;
        }

        if (IsSigned)
        {
            if (Size == 8)
            {
                var D = (long)Op;
                State.Rax = (ulong)((long)State.Rax / D);
                State.Rdx = (ulong)((long)State.Rax % D);
            }
            else
            {
                var D = (int)Op;
                State.Rax = unchecked((ulong)(uint)((int)State.Rax / D));
                State.Rdx = unchecked((ulong)(uint)((int)State.Rax % D));
            }
        }
        else if (Size == 8)
        {
            State.Rax /= Op;
            State.Rdx = State.Rax % Op;
        }
        else
        {
            var D = (uint)Op;
            State.Rax = unchecked((ulong)((uint)State.Rax / D));
            State.Rdx = unchecked((ulong)((uint)State.Rax % D));
        }
    }

    private void ExecAdc(ref Instruction Instr)
    {
        var A = ReadOperand(ref Instr, 0);
        var B = ReadOperand(ref Instr, 1);
        var R = A + B + (State.Cf ? 1UL : 0UL);
        State.UpdateFlags(R, A, B, GetOperandSize(ref Instr, 0));
        WriteOperand(ref Instr, 0, R);
    }

    private void ExecSbb(ref Instruction Instr)
    {
        var A = ReadOperand(ref Instr, 0);
        var B = ReadOperand(ref Instr, 1);
        var R = A - B - (State.Cf ? 1UL : 0UL);
        State.UpdateFlags(R, A, B, GetOperandSize(ref Instr, 0));
        WriteOperand(ref Instr, 0, R);
    }

    private void ExecXchg(ref Instruction Instr)
    {
        var A = ReadOperand(ref Instr, 0);
        var B = ReadOperand(ref Instr, 1);
        WriteOperand(ref Instr, 0, B);
        WriteOperand(ref Instr, 1, A);
    }

    private void ExecRotate(ref Instruction Instr, bool IsLeft)
    {
        var Val = ReadOperand(ref Instr, 0);
        var Shift = (int)ReadOperand(ref Instr, 1);
        var Size = GetOperandSize(ref Instr, 0);
        var Bits = Size * 8;
        Shift &= Bits - 1;
        ulong R;
        if (IsLeft)
        {
            R = (Val << Shift) | (Val >> (Bits - Shift));
        }
        else
        {
            R = (Val >> Shift) | (Val << (Bits - Shift));
        }

        WriteOperand(ref Instr, 0, R);
    }

    private void ExecBt(ref Instruction Instr)
    {
        var Val = ReadOperand(ref Instr, 0);
        var Bit = ReadOperand(ref Instr, 1);
        State.Cf = (Val & (1UL << (int)Bit)) != 0;
    }

    private void ExecBts(ref Instruction Instr)
    {
        ExecBt(ref Instr);
        var Val = ReadOperand(ref Instr, 0);
        var Bit = ReadOperand(ref Instr, 1);
        WriteOperand(ref Instr, 0, Val | (1UL << (int)Bit));
    }

    private void ExecBtr(ref Instruction Instr)
    {
        ExecBt(ref Instr);
        var Val = ReadOperand(ref Instr, 0);
        var Bit = ReadOperand(ref Instr, 1);
        WriteOperand(ref Instr, 0, Val & ~(1UL << (int)Bit));
    }

    private void ExecBsf(ref Instruction Instr)
    {
        var V = ReadOperand(ref Instr, 1);
        State.Zf = V == 0;
        WriteOperand(ref Instr, 0, V == 0 ? 0UL : (ulong)BitOperations.TrailingZeroCount(V));
    }

    private void ExecBsr(ref Instruction Instr)
    {
        var V = ReadOperand(ref Instr, 1);
        State.Zf = V == 0;
        WriteOperand(ref Instr, 0, V == 0 ? 0UL : (ulong)(63 - BitOperations.LeadingZeroCount(V)));
    }

    private void ExecLzcnt(ref Instruction Instr)
    {
        WriteOperand(ref Instr, 0, (ulong)BitOperations.LeadingZeroCount(ReadOperand(ref Instr, 1)));
    }

    private void ExecTzcnt(ref Instruction Instr)
    {
        WriteOperand(ref Instr, 0, (ulong)BitOperations.TrailingZeroCount(ReadOperand(ref Instr, 1)));
    }

    private void ExecPopcnt(ref Instruction Instr)
    {
        WriteOperand(ref Instr, 0, (ulong)BitOperations.PopCount(ReadOperand(ref Instr, 1)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ulong GetBranchTarget(ref Instruction Instr)
    {
        for (var I = 0; I < Instr.OpCount; I++)
        {
            var Kind = Instr.GetOpKind(I);
            if (Kind is OpKind.NearBranch16 or OpKind.NearBranch32 or OpKind.NearBranch64)
            {
                return Instr.NearBranchTarget;
            }
        }

        return 0;
    }
}
