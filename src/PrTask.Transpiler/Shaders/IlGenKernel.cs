using ComputeSharp;

namespace PrTask.Transpiler.Shaders;

[ThreadGroupSize(256, 1, 1)]
[GeneratedComputeShaderDescriptor]
internal readonly partial struct IlGenKernel(
    ReadWriteBuffer<uint> InstructionData,
    ReadWriteBuffer<uint> OutputIlUints,
    ReadWriteBuffer<int> BlockOffsets,
    ReadWriteBuffer<int> BlockLengths,
    ReadWriteBuffer<int> OutputOffsets,
    ReadWriteBuffer<int> OutputLengths) : IComputeShader
{
    private const int Stride = 13;
    private const int FieldMnemonic = 0;
    private const int FieldOp0Kind = 1;
    private const int FieldOp1Kind = 2;
    private const int FieldOp0Reg = 3;
    private const int FieldOp1Reg = 4;
    private const int FieldImmLo = 5;
    private const int FieldImmHi = 6;
    private const uint KindRegister = 0;
    private const uint KindImmediate = 1;
    private const uint OpNop = 0x00;
    private const uint OpLdsfld = 0x7E;
    private const uint OpStsfld = 0x80;
    private const uint OpLdcI8 = 0x21;
    private const uint OpAdd = 0x58;
    private const uint OpSub = 0x59;
    private const uint OpAnd = 0x5F;
    private const uint OpOr = 0x60;
    private const uint OpXor = 0x61;
    private const uint OpShl = 0x62;
    private const uint OpShr = 0x63;
    private const uint OpNot = 0x66;
    private const uint OpNeg = 0x65;
    private const uint OpMul = 0x5A;
    private const uint OpRet = 0x2A;
    private const uint OpLdcI4One = 0x17;
    private const uint OpConvU8 = 0x6E;
    private const uint OpDup = 0x25;
    private const uint OpPop = 0x26;
    private const uint OpLdcI4Zero = 0x16;
    private const uint OpFe = 0xFE;
    private const uint OpCeq = 0x01;
    private const int IdNop = 0;
    private const int IdMov = 1;
    private const int IdAdd = 2;
    private const int IdSub = 3;
    private const int IdAnd = 4;
    private const int IdOr = 5;
    private const int IdXor = 6;
    private const int IdShl = 7;
    private const int IdShr = 8;
    private const int IdNot = 9;
    private const int IdNeg = 10;
    private const int IdRet = 11;
    private const int IdCall = 12;
    private const int IdJmp = 13;
    private const int IdCmp = 14;
    private const int IdTest = 15;
    private const int IdPush = 16;
    private const int IdPop = 17;
    private const int IdLea = 18;
    private const int IdImul = 19;
    private const int IdInc = 20;
    private const int IdDec = 21;
    private const int IdJe = 22;
    private const int IdJne = 23;
    private const int IdJl = 24;
    private const int IdJge = 25;
    private const int IdJle = 26;
    private const int IdJg = 27;
    private const int IdJb = 28;
    private const int IdJae = 29;
    private const int IdJbe = 30;
    private const int IdJa = 31;
    private const int IdSar = 32;
    private const int IdEndbr64 = 33;
    private const int IdSetCC = 34;
    private const int IdCmovCC = 35;

    public void Execute()
    {
        var ThreadId = ThreadIds.X;
        if (ThreadId >= BlockOffsets.Length)
        {
            return;
        }

        var InstrOffset = BlockOffsets[ThreadId];
        var InstrCount = BlockLengths[ThreadId];
        var OutOffset = OutputOffsets[ThreadId];
        var OutPos = 0;

        for (var I = 0; I < InstrCount; I++)
        {
            var Base = InstrOffset + (I * Stride);
            var MnemonicRaw = InstructionData[Base + FieldMnemonic];
            var Op0Kind = InstructionData[Base + FieldOp0Kind];
            var Op1Kind = InstructionData[Base + FieldOp1Kind];
            var Op0Reg = InstructionData[Base + FieldOp0Reg];
            var Op1Reg = InstructionData[Base + FieldOp1Reg];
            var ImmLo = InstructionData[Base + FieldImmLo];
            var ImmHi = InstructionData[Base + FieldImmHi];

            OutPos += TranslateInstruction(
                MnemonicRaw, Op0Kind, Op1Kind, Op0Reg, Op1Reg,
                ImmLo, ImmHi, OutOffset, OutPos);
        }

        OutputLengths[ThreadId] = OutPos;
    }

    private int TranslateInstruction(
        uint Mnemonic, uint Op0Kind, uint Op1Kind,
        uint Op0Reg, uint Op1Reg, uint ImmLo, uint ImmHi,
        int OutOffset, int OutPos)
    {
        var Written = 0;

        switch ((int)Mnemonic)
        {
            case IdNop:
            case IdEndbr64:
                OutputIlUints[OutOffset + OutPos] = OpNop;
                Written = 1;
                break;

            case IdMov:
                Written = EmitMov(Op0Kind, Op1Kind, Op0Reg, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdAdd:
                Written = EmitBinaryOp(OpAdd, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdSub:
                Written = EmitBinaryOp(OpSub, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdAnd:
                Written = EmitBinaryOp(OpAnd, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdOr:
                Written = EmitBinaryOp(OpOr, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdXor:
                Written = EmitBinaryOp(OpXor, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdShl:
                Written = EmitBinaryOp(OpShl, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdShr:
            case IdSar:
                Written = EmitBinaryOp(OpShr, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdImul:
                Written = EmitBinaryOp(OpMul, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdNot:
                Written = EmitUnaryOp(OpNot, Op0Reg, OutOffset, OutPos);
                break;

            case IdNeg:
                Written = EmitUnaryOp(OpNeg, Op0Reg, OutOffset, OutPos);
                break;

            case IdInc:
                Written = EmitIncDec(OpAdd, Op0Reg, OutOffset, OutPos);
                break;

            case IdDec:
                Written = EmitIncDec(OpSub, Op0Reg, OutOffset, OutPos);
                break;

            case IdCmp:
                Written = EmitCompare(Op0Kind, Op1Kind, Op0Reg, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdTest:
                Written = EmitTest(Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);
                break;

            case IdRet:
                OutputIlUints[OutOffset + OutPos] = OpRet;
                Written = 1;
                break;

            case IdPush:
            case IdPop:
            case IdLea:
            case IdCall:
            case IdJmp:
            case IdJe:
            case IdJne:
            case IdJl:
            case IdJge:
            case IdJle:
            case IdJg:
            case IdJb:
            case IdJae:
            case IdJbe:
            case IdJa:
            case IdSetCC:
            case IdCmovCC:
                OutputIlUints[OutOffset + OutPos] = OpNop;
                Written = 1;
                break;

            default:
                OutputIlUints[OutOffset + OutPos] = OpNop;
                Written = 1;
                break;
        }

        return Written;
    }

    private int EmitMov(uint Op0Kind, uint Op1Kind, uint Op0Reg, uint Op1Reg,
        uint ImmLo, uint ImmHi, int OutOffset, int OutPos)
    {
        var Pos = 0;

        if (Op1Kind == KindRegister)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = Op1Reg;
            Pos++;
        }
        else if (Op1Kind == KindImmediate)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI8;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmLo;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmHi;
            Pos++;
        }
        else
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpNop;
            Pos++;
            return Pos;
        }

        OutputIlUints[OutOffset + OutPos + Pos] = OpStsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Op0Reg;
        Pos++;

        return Pos;
    }

    private int EmitBinaryOp(uint OpCode, uint DstReg, uint SrcKind, uint SrcReg,
        uint ImmLo, uint ImmHi, int OutOffset, int OutPos)
    {
        var Pos = 0;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = DstReg;
        Pos++;

        if (SrcKind == KindRegister)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = SrcReg;
            Pos++;
        }
        else if (SrcKind == KindImmediate)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI8;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmLo;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmHi;
            Pos++;
        }

        OutputIlUints[OutOffset + OutPos + Pos] = OpCode;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpStsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = DstReg;
        Pos++;

        return Pos;
    }

    private int EmitUnaryOp(uint OpCode, uint Reg, int OutOffset, int OutPos)
    {
        var Pos = 0;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Reg;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpCode;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpStsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Reg;
        Pos++;

        return Pos;
    }

    private int EmitIncDec(uint OpCode, uint Reg, int OutOffset, int OutPos)
    {
        var Pos = 0;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Reg;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI4One;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpConvU8;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpCode;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpStsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Reg;
        Pos++;

        return Pos;
    }

    private int EmitCompare(uint Op0Kind, uint Op1Kind, uint Op0Reg, uint Op1Reg,
        uint ImmLo, uint ImmHi, int OutOffset, int OutPos)
    {
        var Pos = 0;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Op0Reg;
        Pos++;

        if (Op1Kind == KindRegister)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = Op1Reg;
            Pos++;
        }
        else if (Op1Kind == KindImmediate)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI8;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmLo;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmHi;
            Pos++;
        }

        OutputIlUints[OutOffset + OutPos + Pos] = OpSub;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpDup;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI4Zero;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpConvU8;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpFe;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpCeq;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpPop;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpPop;
        Pos++;

        return Pos;
    }

    private int EmitTest(uint Op0Reg, uint Op1Kind, uint Op1Reg,
        uint ImmLo, uint ImmHi, int OutOffset, int OutPos)
    {
        var Pos = 0;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
        Pos++;
        OutputIlUints[OutOffset + OutPos + Pos] = Op0Reg;
        Pos++;

        if (Op1Kind == KindRegister)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdsfld;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = Op1Reg;
            Pos++;
        }
        else if (Op1Kind == KindImmediate)
        {
            OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI8;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmLo;
            Pos++;
            OutputIlUints[OutOffset + OutPos + Pos] = ImmHi;
            Pos++;
        }

        OutputIlUints[OutOffset + OutPos + Pos] = OpAnd;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpDup;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpLdcI4Zero;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpConvU8;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpFe;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpCeq;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpPop;
        Pos++;

        OutputIlUints[OutOffset + OutPos + Pos] = OpPop;
        Pos++;

        return Pos;
    }
}
