using System.Numerics;
using System.Runtime.CompilerServices;
using Iced.Intel;

namespace PrTask.Transpiler;

public enum ArithOp
{
    Add,
    Sub,
    And,
    Or,
}

public enum ShiftOp
{
    Shl,
    Shr,
    Sar,
}

public sealed partial class X86Interpreter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ulong ReadOperand(ref Instruction Instr, int OpIdx)
    {
        var Kind = Instr.GetOpKind(OpIdx);
        return Kind switch
        {
            OpKind.Register => ReadReg(Instr.GetOpRegister(OpIdx)),
            OpKind.Memory => ReadMem(ref Instr, GetOperandSize(ref Instr, OpIdx)),
            OpKind.Immediate8 or OpKind.Immediate8_2nd or OpKind.Immediate16 or
            OpKind.Immediate32 or OpKind.Immediate64 or OpKind.Immediate8to16 or
            OpKind.Immediate8to32 or OpKind.Immediate8to64 or OpKind.Immediate32to64
                => Instr.GetImmediate(OpIdx),
            _ => 0UL,
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void WriteOperand(ref Instruction Instr, int OpIdx, ulong Value)
    {
        var Kind = Instr.GetOpKind(OpIdx);
        if (Kind == OpKind.Register)
        {
            WriteReg(Instr.GetOpRegister(OpIdx), Value);
        }
        else if (Kind == OpKind.Memory)
        {
            WriteMem(ref Instr, GetOperandSize(ref Instr, OpIdx), Value);
        }
    }

    private ulong GetBase(Register Reg)
    {
        return Reg switch
        {
            Register.AL or Register.AH or Register.AX or Register.EAX or Register.RAX => State.Rax,
            Register.CL or Register.CH or Register.CX or Register.ECX or Register.RCX => State.Rcx,
            Register.DL or Register.DH or Register.DX or Register.EDX or Register.RDX => State.Rdx,
            Register.BL or Register.BH or Register.BX or Register.EBX or Register.RBX => State.Rbx,
            Register.SPL or Register.SP or Register.ESP or Register.RSP => State.Rsp,
            Register.BPL or Register.BP or Register.EBP or Register.RBP => State.Rbp,
            Register.SIL or Register.SI or Register.ESI or Register.RSI => State.Rsi,
            Register.DIL or Register.DI or Register.EDI or Register.RDI => State.Rdi,
            Register.R8 or Register.R8D or Register.R8W or Register.R8L => State.R8,
            Register.R9 or Register.R9D or Register.R9W or Register.R9L => State.R9,
            Register.R10 or Register.R10D or Register.R10W or Register.R10L => State.R10,
            Register.R11 or Register.R11D or Register.R11W or Register.R11L => State.R11,
            Register.R12 or Register.R12D or Register.R12W or Register.R12L => State.R12,
            Register.R13 or Register.R13D or Register.R13W or Register.R13L => State.R13,
            Register.R14 or Register.R14D or Register.R14W or Register.R14L => State.R14,
            Register.R15 or Register.R15D or Register.R15W or Register.R15L => State.R15,
            Register.RIP or Register.EIP => State.Rip,
            _ => 0UL,
        };
    }

    private void SetBase(Register Reg, ulong Value)
    {
        switch (Reg)
        {
            case Register.AL or Register.AH or Register.AX or Register.EAX or Register.RAX: State.Rax = Value; break;
            case Register.CL or Register.CH or Register.CX or Register.ECX or Register.RCX: State.Rcx = Value; break;
            case Register.DL or Register.DH or Register.DX or Register.EDX or Register.RDX: State.Rdx = Value; break;
            case Register.BL or Register.BH or Register.BX or Register.EBX or Register.RBX: State.Rbx = Value; break;
            case Register.SPL or Register.SP or Register.ESP or Register.RSP: State.Rsp = Value; break;
            case Register.BPL or Register.BP or Register.EBP or Register.RBP: State.Rbp = Value; break;
            case Register.SIL or Register.SI or Register.ESI or Register.RSI: State.Rsi = Value; break;
            case Register.DIL or Register.DI or Register.EDI or Register.RDI: State.Rdi = Value; break;
            case Register.R8 or Register.R8D or Register.R8W or Register.R8L: State.R8 = Value; break;
            case Register.R9 or Register.R9D or Register.R9W or Register.R9L: State.R9 = Value; break;
            case Register.R10 or Register.R10D or Register.R10W or Register.R10L: State.R10 = Value; break;
            case Register.R11 or Register.R11D or Register.R11W or Register.R11L: State.R11 = Value; break;
            case Register.R12 or Register.R12D or Register.R12W or Register.R12L: State.R12 = Value; break;
            case Register.R13 or Register.R13D or Register.R13W or Register.R13L: State.R13 = Value; break;
            case Register.R14 or Register.R14D or Register.R14W or Register.R14L: State.R14 = Value; break;
            case Register.R15 or Register.R15D or Register.R15W or Register.R15L: State.R15 = Value; break;
            case Register.RIP or Register.EIP: State.Rip = Value; break;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ulong ReadReg(Register Reg)
    {
        return Reg switch
        {
            Register.AH => (byte)(State.Rax >> 8),
            Register.CH => (byte)(State.Rcx >> 8),
            Register.DH => (byte)(State.Rdx >> 8),
            Register.BH => (byte)(State.Rbx >> 8),
            _ => GetRegSize(Reg) switch
            {
                1 => (byte)GetBase(Reg),
                2 => (ushort)GetBase(Reg),
                4 => (uint)GetBase(Reg),
                _ => GetBase(Reg),
            },
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void WriteReg(Register Reg, ulong Value)
    {
        var Size = GetRegSize(Reg);
        if (Size == 8)
        {
            SetBase(Reg, Value);
            return;
        }

        if (Size == 4)
        {
            SetBase(Reg, unchecked((ulong)(uint)Value));
            return;
        }

        var Base = GetBase(Reg);
        if (Size == 2)
        {
            SetBase(Reg, (Base & 0xFFFFFFFFFFFF0000UL) | (ushort)Value);
            return;
        }

        if (Reg is Register.AH or Register.CH or Register.DH or Register.BH)
        {
            SetBase(Reg, (Base & 0xFFFFFFFFFFFF00FFUL) | ((ulong)(byte)Value << 8));
        }
        else
        {
            SetBase(Reg, (Base & 0xFFFFFFFFFFFFFF00UL) | (byte)Value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ulong ComputeMemAddr(ref Instruction Instr)
    {
        if (Instr.IsIPRelativeMemoryOperand)
        {
            return Instr.IPRelativeMemoryAddress;
        }

        ulong Addr = 0;
        if (Instr.MemoryBase != Register.None)
        {
            Addr += ReadReg(Instr.MemoryBase);
        }

        if (Instr.MemoryIndex != Register.None)
        {
            Addr += ReadReg(Instr.MemoryIndex) * (ulong)Instr.MemoryIndexScale;
        }

        Addr += Instr.MemoryDisplacement64;
        return Addr;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private ulong ReadMem(ref Instruction Instr, int Size)
    {
        var Addr = ComputeMemAddr(ref Instr);
        return Size switch
        {
            1 => Mem.Read8(Addr),
            2 => Mem.Read16(Addr),
            4 => Mem.Read32(Addr),
            _ => Mem.Read64(Addr),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void WriteMem(ref Instruction Instr, int Size, ulong Value)
    {
        var Addr = ComputeMemAddr(ref Instr);
        switch (Size)
        {
            case 1: Mem.Write8(Addr, (byte)Value); break;
            case 2: Mem.Write16(Addr, (ushort)Value); break;
            case 4: Mem.Write32(Addr, (uint)Value); break;
            default: Mem.Write64(Addr, Value); break;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetOperandSize(ref Instruction Instr, int OpIdx)
    {
        var Kind = Instr.GetOpKind(OpIdx);
        if (Kind == OpKind.Register)
        {
            return GetRegSize(Instr.GetOpRegister(OpIdx));
        }

        if (Kind == OpKind.Memory)
        {
            return Instr.MemorySize switch
            {
                MemorySize.UInt8 or MemorySize.Int8 => 1,
                MemorySize.UInt16 or MemorySize.Int16 => 2,
                MemorySize.UInt32 or MemorySize.Int32 or MemorySize.Float32 => 4,
                _ => 8,
            };
        }

        return 4;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetRegSize(Register Reg)
    {
        if (Reg is >= Register.AL and <= Register.R15L)
        {
            return 1;
        }

        if (Reg is Register.AH or Register.CH or Register.DH or Register.BH)
        {
            return 1;
        }

        if (Reg is >= Register.AX and <= Register.R15W)
        {
            return 2;
        }

        if (Reg is >= Register.EAX and <= Register.R15D)
        {
            return 4;
        }

        return 8;
    }

    private void ExecMov(ref Instruction Instr) =>
        WriteOperand(ref Instr, 0, ReadOperand(ref Instr, 1));

    private void ExecLea(ref Instruction Instr) =>
        WriteOperand(ref Instr, 0, ComputeMemAddr(ref Instr));

    private void ExecPush(ref Instruction Instr) =>
        State.Push(ReadOperand(ref Instr, 0));

    private void ExecPop(ref Instruction Instr) =>
        WriteOperand(ref Instr, 0, State.Pop());

    private void ExecArith(ref Instruction Instr, ArithOp Op)
    {
        var A = ReadOperand(ref Instr, 0);
        var B = ReadOperand(ref Instr, 1);
        var R = Op switch
        {
            ArithOp.Add => A + B,
            ArithOp.Sub => A - B,
            ArithOp.And => A & B,
            ArithOp.Or => A | B,
            _ => A + B,
        };
        State.UpdateFlags(R, A, B, GetOperandSize(ref Instr, 0));
        WriteOperand(ref Instr, 0, R);
    }

    private void ExecXor(ref Instruction Instr)
    {
        if (Instr.Op0Kind == OpKind.Register && Instr.Op1Kind == OpKind.Register &&
            Instr.Op0Register == Instr.Op1Register)
        {
            WriteReg(Instr.Op0Register, 0);
            State.Zf = true;
            State.Sf = false;
            State.Cf = false;
            State.Of = false;
            return;
        }

        var A = ReadOperand(ref Instr, 0);
        var B = ReadOperand(ref Instr, 1);
        var R = A ^ B;
        State.UpdateFlags(R, A, B, GetOperandSize(ref Instr, 0));
        WriteOperand(ref Instr, 0, R);
    }

    private void ExecInc(ref Instruction Instr)
    {
        var A = ReadOperand(ref Instr, 0);
        State.UpdateFlags(A + 1, A, 1, GetOperandSize(ref Instr, 0));
        WriteOperand(ref Instr, 0, A + 1);
    }

    private void ExecDec(ref Instruction Instr)
    {
        var A = ReadOperand(ref Instr, 0);
        State.UpdateFlags(A - 1, A, 1, GetOperandSize(ref Instr, 0));
        WriteOperand(ref Instr, 0, A - 1);
    }

    private void ExecNot(ref Instruction Instr) =>
        WriteOperand(ref Instr, 0, ~ReadOperand(ref Instr, 0));

    private void ExecNeg(ref Instruction Instr) =>
        WriteOperand(ref Instr, 0, (ulong)-(long)ReadOperand(ref Instr, 0));

    private void ExecShift(ref Instruction Instr, ShiftOp Op)
    {
        var A = ReadOperand(ref Instr, 0);
        var Shift = (int)ReadOperand(ref Instr, 1);
        var R = Op switch
        {
            ShiftOp.Shl => A << Shift,
            ShiftOp.Shr => A >> Shift,
            ShiftOp.Sar => (ulong)((long)A >> Shift),
            _ => A,
        };
        WriteOperand(ref Instr, 0, R);
    }

    private void ExecCmp(ref Instruction Instr)
    {
        var A = ReadOperand(ref Instr, 0);
        var B = ReadOperand(ref Instr, 1);
        State.UpdateFlags(A - B, A, B, GetOperandSize(ref Instr, 0));
    }

    private void ExecTest(ref Instruction Instr)
    {
        var R = ReadOperand(ref Instr, 0) & ReadOperand(ref Instr, 1);
        var Size = GetOperandSize(ref Instr, 0);
        State.Zf = R == 0;
        State.Sf = (R & (1UL << ((Size * 8) - 1))) != 0;
        State.Cf = false;
        State.Of = false;
    }

    private void ExecMovzx(ref Instruction Instr) =>
        WriteOperand(ref Instr, 0, ReadOperand(ref Instr, 1));

    private void ExecMovsx(ref Instruction Instr)
    {
        var SrcSize = GetOperandSize(ref Instr, 1);
        var Src = ReadOperand(ref Instr, 1);
        var Signed = SrcSize switch
        {
            1 => (long)(sbyte)(byte)Src,
            2 => (long)(short)(ushort)Src,
            _ => (long)(int)(uint)Src,
        };
        WriteOperand(ref Instr, 0, (ulong)Signed);
    }

    private void ExecCmov(ref Instruction Instr, bool Condition)
    {
        if (Condition)
        {
            WriteOperand(ref Instr, 0, ReadOperand(ref Instr, 1));
        }
    }

    private void ExecSetcc(ref Instruction Instr, bool Condition) =>
        WriteOperand(ref Instr, 0, Condition ? 1UL : 0UL);
}
