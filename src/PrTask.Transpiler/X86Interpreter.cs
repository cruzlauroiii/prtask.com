using Iced.Intel;

namespace PrTask.Transpiler;

public sealed partial class X86Interpreter
{
    private readonly CpuState State;
    private readonly VirtualMemory Mem;
    private readonly Win32Dispatcher Dispatcher;
    private readonly Dictionary<ulong, (string Dll, string Func)> IatMap;

    public X86Interpreter(CpuState State, VirtualMemory Mem, Win32Dispatcher Dispatcher,
        Dictionary<ulong, (string Dll, string Func)> IatMap)
    {
        this.State = State;
        this.Mem = Mem;
        this.Dispatcher = Dispatcher;
        this.IatMap = IatMap;
    }

    public enum StopReason
    {
        Returned,
        MaxInstructions,
        UnknownInstruction,
        Halted,
    }

    public StopReason Execute(ulong StartAddr, int MaxInstructions)
    {
        State.Rip = StartAddr;
        for (var I = 0; I < MaxInstructions; I++)
        {
            var CodeBytes = Mem.ReadBytes(State.Rip, 15);
            var Decoder = Iced.Intel.Decoder.Create(64, CodeBytes, State.Rip);
            Decoder.Decode(out var Instr);
            if (Instr.IsInvalid)
            {
                return StopReason.UnknownInstruction;
            }

            State.Rip = Instr.NextIP;
            var Result = Dispatch(ref Instr);
            if (Result is not null)
            {
                return Result.Value;
            }
        }

        return StopReason.MaxInstructions;
    }

    private StopReason? Dispatch(ref Instruction Instr)
    {
        switch (Instr.Mnemonic)
        {
            case Mnemonic.Nop:
            case Mnemonic.Endbr64:
            case Mnemonic.Cld:
            case Mnemonic.Std:
            case Mnemonic.Int3:
            case Mnemonic.Ud2:
                return null;
            case Mnemonic.Mov: ExecMov(ref Instr); return null;
            case Mnemonic.Lea: ExecLea(ref Instr); return null;
            case Mnemonic.Push: ExecPush(ref Instr); return null;
            case Mnemonic.Pop: ExecPop(ref Instr); return null;
            case Mnemonic.Add: ExecArith(ref Instr, ArithOp.Add); return null;
            case Mnemonic.Sub: ExecArith(ref Instr, ArithOp.Sub); return null;
            case Mnemonic.And: ExecArith(ref Instr, ArithOp.And); return null;
            case Mnemonic.Or: ExecArith(ref Instr, ArithOp.Or); return null;
            case Mnemonic.Xor: ExecXor(ref Instr); return null;
            case Mnemonic.Inc: ExecInc(ref Instr); return null;
            case Mnemonic.Dec: ExecDec(ref Instr); return null;
            case Mnemonic.Not: ExecNot(ref Instr); return null;
            case Mnemonic.Neg: ExecNeg(ref Instr); return null;
            case Mnemonic.Shl: ExecShift(ref Instr, ShiftOp.Shl); return null;
            case Mnemonic.Shr: ExecShift(ref Instr, ShiftOp.Shr); return null;
            case Mnemonic.Sar: ExecShift(ref Instr, ShiftOp.Sar); return null;
            case Mnemonic.Cmp: ExecCmp(ref Instr); return null;
            case Mnemonic.Test: ExecTest(ref Instr); return null;
            case Mnemonic.Jmp: return ExecJmp(ref Instr);
            case Mnemonic.Je: ExecJcc(ref Instr, State.Zf); return null;
            case Mnemonic.Jne: ExecJcc(ref Instr, !State.Zf); return null;
            case Mnemonic.Jl: ExecJcc(ref Instr, State.Sf != State.Of); return null;
            case Mnemonic.Jge: ExecJcc(ref Instr, State.Sf == State.Of); return null;
            case Mnemonic.Jle: ExecJcc(ref Instr, State.Zf || State.Sf != State.Of); return null;
            case Mnemonic.Jg: ExecJcc(ref Instr, !State.Zf && State.Sf == State.Of); return null;
            case Mnemonic.Jb: ExecJcc(ref Instr, State.Cf); return null;
            case Mnemonic.Jae: ExecJcc(ref Instr, !State.Cf); return null;
            case Mnemonic.Jbe: ExecJcc(ref Instr, State.Cf || State.Zf); return null;
            case Mnemonic.Ja: ExecJcc(ref Instr, !State.Cf && !State.Zf); return null;
            case Mnemonic.Js: ExecJcc(ref Instr, State.Sf); return null;
            case Mnemonic.Jns: ExecJcc(ref Instr, !State.Sf); return null;
            case Mnemonic.Call: return ExecCall(ref Instr);
            case Mnemonic.Ret: return StopReason.Returned;
            case Mnemonic.Imul: ExecImul(ref Instr); return null;
            case Mnemonic.Mul: ExecMul(ref Instr); return null;
            case Mnemonic.Div: ExecDiv(ref Instr, false); return null;
            case Mnemonic.Idiv: ExecDiv(ref Instr, true); return null;
            case Mnemonic.Movzx: ExecMovzx(ref Instr); return null;
            case Mnemonic.Movsx: ExecMovsx(ref Instr); return null;
            case Mnemonic.Movsxd: ExecMovsx(ref Instr); return null;
            case Mnemonic.Cdq: State.Rdx = (ulong)((long)State.Rax >> 32); return null;
            case Mnemonic.Cqo: State.Rdx = (ulong)((long)State.Rax >> 63); return null;
            case Mnemonic.Cbw: State.Rax = (State.Rax & 0xFFFFFFFFFFFF0000UL) | (ushort)(sbyte)State.Rax; return null;
            case Mnemonic.Cwde: State.Rax = (ulong)(uint)(int)(short)State.Rax; return null;
            case Mnemonic.Cdqe: State.Rax = (ulong)(long)(int)State.Rax; return null;
            case Mnemonic.Adc: ExecAdc(ref Instr); return null;
            case Mnemonic.Sbb: ExecSbb(ref Instr); return null;
            case Mnemonic.Xchg: ExecXchg(ref Instr); return null;
            case Mnemonic.Rol: ExecRotate(ref Instr, true); return null;
            case Mnemonic.Ror: ExecRotate(ref Instr, false); return null;
            case Mnemonic.Bt: ExecBt(ref Instr); return null;
            case Mnemonic.Bts: ExecBts(ref Instr); return null;
            case Mnemonic.Btr: ExecBtr(ref Instr); return null;
            case Mnemonic.Bsf: ExecBsf(ref Instr); return null;
            case Mnemonic.Bsr: ExecBsr(ref Instr); return null;
            case Mnemonic.Lzcnt: ExecLzcnt(ref Instr); return null;
            case Mnemonic.Tzcnt: ExecTzcnt(ref Instr); return null;
            case Mnemonic.Popcnt: ExecPopcnt(ref Instr); return null;
            case Mnemonic.Cmove: ExecCmov(ref Instr, State.Zf); return null;
            case Mnemonic.Cmovne: ExecCmov(ref Instr, !State.Zf); return null;
            case Mnemonic.Cmovl: ExecCmov(ref Instr, State.Sf != State.Of); return null;
            case Mnemonic.Cmovge: ExecCmov(ref Instr, State.Sf == State.Of); return null;
            case Mnemonic.Cmovle: ExecCmov(ref Instr, State.Zf || State.Sf != State.Of); return null;
            case Mnemonic.Cmovg: ExecCmov(ref Instr, !State.Zf && State.Sf == State.Of); return null;
            case Mnemonic.Cmovb: ExecCmov(ref Instr, State.Cf); return null;
            case Mnemonic.Cmovae: ExecCmov(ref Instr, !State.Cf); return null;
            case Mnemonic.Cmovbe: ExecCmov(ref Instr, State.Cf || State.Zf); return null;
            case Mnemonic.Cmova: ExecCmov(ref Instr, !State.Cf && !State.Zf); return null;
            case Mnemonic.Cmovs: ExecCmov(ref Instr, State.Sf); return null;
            case Mnemonic.Cmovns: ExecCmov(ref Instr, !State.Sf); return null;
            case Mnemonic.Sete: ExecSetcc(ref Instr, State.Zf); return null;
            case Mnemonic.Setne: ExecSetcc(ref Instr, !State.Zf); return null;
            case Mnemonic.Setl: ExecSetcc(ref Instr, State.Sf != State.Of); return null;
            case Mnemonic.Setge: ExecSetcc(ref Instr, State.Sf == State.Of); return null;
            case Mnemonic.Setle: ExecSetcc(ref Instr, State.Zf || State.Sf != State.Of); return null;
            case Mnemonic.Setg: ExecSetcc(ref Instr, !State.Zf && State.Sf == State.Of); return null;
            case Mnemonic.Setb: ExecSetcc(ref Instr, State.Cf); return null;
            case Mnemonic.Setae: ExecSetcc(ref Instr, !State.Cf); return null;
            case Mnemonic.Setbe: ExecSetcc(ref Instr, State.Cf || State.Zf); return null;
            case Mnemonic.Seta: ExecSetcc(ref Instr, !State.Cf && !State.Zf); return null;
            case Mnemonic.Sets: ExecSetcc(ref Instr, State.Sf); return null;
            case Mnemonic.Setns: ExecSetcc(ref Instr, !State.Sf); return null;
            case Mnemonic.Stc: State.Cf = true; return null;
            case Mnemonic.Clc: State.Cf = false; return null;
            case Mnemonic.Cmc: State.Cf = !State.Cf; return null;
            default: return StopReason.UnknownInstruction;
        }
    }

    private bool TryDispatchIat(ulong MemAddr)
    {
        if (IatMap.TryGetValue(MemAddr, out var Entry))
        {
            Dispatcher.Dispatch(Entry.Dll, Entry.Func, State);
            return true;
        }

        return false;
    }
}
