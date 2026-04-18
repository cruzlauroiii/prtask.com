using System.Diagnostics;
using System.Globalization;
using ComputeSharp;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Transpiler.Shaders;

namespace PrTask.Transpiler;

public sealed class GpuEmitter : IGpuEmitter
{
    private readonly GraphicsDevice? Device;

    public bool IsGpuAvailable { get; }
    public string DeviceName { get; }

    public GpuEmitter()
    {
        try
        {
            Device = GraphicsDevice.GetDefault();
            IsGpuAvailable = Device is not null;
            DeviceName = Device?.Name ?? string.Empty;
        }
        catch
        {
            Device = null;
            IsGpuAvailable = false;
            DeviceName = string.Empty;
        }
    }

    public byte[][] TranslateBlocks(uint[] InstructionData, int[] BlockOffsets, int[] BlockLengths)
    {
        var BlockCount = BlockOffsets.Length;
        var OutputOffsets = new int[BlockCount];
        var TotalOutputSize = 0;

        for (var I = 0; I < BlockCount; I++)
        {
            OutputOffsets[I] = TotalOutputSize;
            TotalOutputSize += BlockLengths[I] * GpuConstants.MaxIlBytesPerBlock / GpuConstants.MaxInstructionsPerBlock;
        }

        if (TotalOutputSize == 0)
        {
            TotalOutputSize = BlockCount * GpuConstants.MaxIlBytesPerBlock;
            for (var I = 0; I < BlockCount; I++)
            {
                OutputOffsets[I] = I * GpuConstants.MaxIlBytesPerBlock;
            }
        }

        if (IsGpuAvailable && Device is not null)
        {
            return TranslateOnGpu(Device, InstructionData, BlockOffsets, BlockLengths, OutputOffsets, TotalOutputSize, BlockCount);
        }

        return TranslateOnCpu(InstructionData, BlockOffsets, BlockLengths, OutputOffsets, TotalOutputSize, BlockCount);
    }

    private static byte[][] TranslateOnGpu(
        GraphicsDevice Device,
        uint[] InstructionData,
        int[] BlockOffsets,
        int[] BlockLengths,
        int[] OutputOffsets,
        int TotalOutputSize,
        int BlockCount)
    {
        Console.WriteLine(string.Format(
            CultureInfo.InvariantCulture,
            GpuConstants.GpuDispatchFormat,
            BlockCount,
            Device.Name));

        var Timer = Stopwatch.StartNew();

        using var GpuInstructionData = Device.AllocateReadWriteBuffer(InstructionData);
        using var GpuOutputIlBytes = Device.AllocateReadWriteBuffer<uint>(TotalOutputSize);
        using var GpuBlockOffsets = Device.AllocateReadWriteBuffer(BlockOffsets);
        using var GpuBlockLengths = Device.AllocateReadWriteBuffer(BlockLengths);
        using var GpuOutputOffsets = Device.AllocateReadWriteBuffer(OutputOffsets);
        var OutputLengths = new int[BlockCount];
        using var GpuOutputLengths = Device.AllocateReadWriteBuffer(OutputLengths);

        Device.For(
            BlockCount,
            new IlGenKernel(
                GpuInstructionData,
                GpuOutputIlBytes,
                GpuBlockOffsets,
                GpuBlockLengths,
                GpuOutputOffsets,
                GpuOutputLengths));

        GpuOutputLengths.CopyTo(OutputLengths);
        var RawOutputUints = new uint[TotalOutputSize];
        GpuOutputIlBytes.CopyTo(RawOutputUints);
        var RawOutput = new byte[TotalOutputSize];
        for (var I = 0; I < TotalOutputSize; I++)
        {
            RawOutput[I] = (byte)(RawOutputUints[I] & 0xFF);
        }

        Timer.Stop();

        Console.WriteLine(string.Format(
            CultureInfo.InvariantCulture,
            GpuConstants.GpuCompleteFormat,
            BlockCount,
            Timer.ElapsedMilliseconds));

        return ExtractBlockResults(RawOutput, OutputOffsets, OutputLengths, BlockCount);
    }

    private static byte[][] TranslateOnCpu(
        uint[] InstructionData,
        int[] BlockOffsets,
        int[] BlockLengths,
        int[] OutputOffsets,
        int TotalOutputSize,
        int BlockCount)
    {
        Console.WriteLine(GpuConstants.GpuFallbackMessage);
        var Timer = Stopwatch.StartNew();

        var RawOutput = new byte[TotalOutputSize];
        var OutputLengths = new int[BlockCount];

        Parallel.For(0, BlockCount, ThreadId =>
        {
            var InstrOffset = BlockOffsets[ThreadId];
            var InstrCount = BlockLengths[ThreadId];
            var OutOffset = OutputOffsets[ThreadId];
            var OutPos = 0;

            for (var I = 0; I < InstrCount; I++)
            {
                var Base = InstrOffset + (I * GpuConstants.InstructionStrideUints);
                var MnemonicRaw = InstructionData[Base + GpuConstants.MnemonicField];

                OutPos += TranslateSingleInstruction(
                    RawOutput,
                    MnemonicRaw,
                    InstructionData[Base + GpuConstants.Op0KindField],
                    InstructionData[Base + GpuConstants.Op1KindField],
                    InstructionData[Base + GpuConstants.Op0RegField],
                    InstructionData[Base + GpuConstants.Op1RegField],
                    InstructionData[Base + GpuConstants.ImmLoField],
                    InstructionData[Base + GpuConstants.ImmHiField],
                    OutOffset,
                    OutPos);
            }

            OutputLengths[ThreadId] = OutPos;
        });

        Timer.Stop();

        Console.WriteLine(string.Format(
            CultureInfo.InvariantCulture,
            GpuConstants.CpuFallbackFormat,
            BlockCount,
            Timer.ElapsedMilliseconds));

        return ExtractBlockResults(RawOutput, OutputOffsets, OutputLengths, BlockCount);
    }

    private static int TranslateSingleInstruction(
        byte[] Output,
        uint Mnemonic,
        uint Op0Kind,
        uint Op1Kind,
        uint Op0Reg,
        uint Op1Reg,
        uint ImmLo,
        uint ImmHi,
        int OutOffset,
        int OutPos)
    {
        switch ((int)Mnemonic)
        {
            case GpuConstants.MnemonicIdNop:
            case GpuConstants.MnemonicIdEndbr64:
                Output[OutOffset + OutPos] = GpuConstants.IlOpNop;
                return 1;

            case GpuConstants.MnemonicIdMov:
                return EmitMovCpu(Output, Op0Kind, Op1Kind, Op0Reg, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdAdd:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpAdd, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdSub:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpSub, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdAnd:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpAnd, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdOr:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpOr, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdXor:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpXor, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdShl:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpShl, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdShr:
            case GpuConstants.MnemonicIdSar:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpShr, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdImul:
                return EmitBinaryOpCpu(Output, GpuConstants.IlOpMul, Op0Reg, Op1Kind, Op1Reg, ImmLo, ImmHi, OutOffset, OutPos);

            case GpuConstants.MnemonicIdNot:
                return EmitUnaryOpCpu(Output, GpuConstants.IlOpNot, Op0Reg, OutOffset, OutPos);

            case GpuConstants.MnemonicIdNeg:
                return EmitUnaryOpCpu(Output, GpuConstants.IlOpNeg, Op0Reg, OutOffset, OutPos);

            case GpuConstants.MnemonicIdInc:
                return EmitIncDecCpu(Output, GpuConstants.IlOpAdd, Op0Reg, OutOffset, OutPos);

            case GpuConstants.MnemonicIdDec:
                return EmitIncDecCpu(Output, GpuConstants.IlOpSub, Op0Reg, OutOffset, OutPos);

            case GpuConstants.MnemonicIdRet:
                Output[OutOffset + OutPos] = GpuConstants.IlOpRet;
                return 1;

            default:
                Output[OutOffset + OutPos] = GpuConstants.IlOpNop;
                return 1;
        }
    }

    private static int EmitMovCpu(byte[] Output, uint Op0Kind, uint Op1Kind,
        uint Op0Reg, uint Op1Reg, uint ImmLo, uint ImmHi, int OutOffset, int OutPos)
    {
        var Pos = 0;

        if (Op1Kind == GpuConstants.OpKindRegister)
        {
            Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdsfld;
            Pos++;
            WriteUint32Cpu(Output, OutOffset + OutPos + Pos, Op1Reg);
            Pos += 4;
        }
        else if (Op1Kind == GpuConstants.OpKindImmediate)
        {
            Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdcI8;
            Pos++;
            WriteUint32Cpu(Output, OutOffset + OutPos + Pos, ImmLo);
            Pos += 4;
            WriteUint32Cpu(Output, OutOffset + OutPos + Pos, ImmHi);
            Pos += 4;
        }
        else
        {
            Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpNop;
            return 1;
        }

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpStsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, Op0Reg);
        Pos += 4;

        return Pos;
    }

    private static int EmitBinaryOpCpu(byte[] Output, int OpCode, uint DstReg,
        uint SrcKind, uint SrcReg, uint ImmLo, uint ImmHi, int OutOffset, int OutPos)
    {
        var Pos = 0;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, DstReg);
        Pos += 4;

        if (SrcKind == GpuConstants.OpKindRegister)
        {
            Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdsfld;
            Pos++;
            WriteUint32Cpu(Output, OutOffset + OutPos + Pos, SrcReg);
            Pos += 4;
        }
        else if (SrcKind == GpuConstants.OpKindImmediate)
        {
            Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdcI8;
            Pos++;
            WriteUint32Cpu(Output, OutOffset + OutPos + Pos, ImmLo);
            Pos += 4;
            WriteUint32Cpu(Output, OutOffset + OutPos + Pos, ImmHi);
            Pos += 4;
        }

        Output[OutOffset + OutPos + Pos] = (byte)OpCode;
        Pos++;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpStsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, DstReg);
        Pos += 4;

        return Pos;
    }

    private static int EmitUnaryOpCpu(byte[] Output, int OpCode, uint Reg, int OutOffset, int OutPos)
    {
        var Pos = 0;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, Reg);
        Pos += 4;

        Output[OutOffset + OutPos + Pos] = (byte)OpCode;
        Pos++;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpStsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, Reg);
        Pos += 4;

        return Pos;
    }

    private static int EmitIncDecCpu(byte[] Output, int OpCode, uint Reg, int OutOffset, int OutPos)
    {
        var Pos = 0;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, Reg);
        Pos += 4;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpLdcI4One;
        Pos++;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpConvU8;
        Pos++;

        Output[OutOffset + OutPos + Pos] = (byte)OpCode;
        Pos++;

        Output[OutOffset + OutPos + Pos] = GpuConstants.IlOpStsfld;
        Pos++;
        WriteUint32Cpu(Output, OutOffset + OutPos + Pos, Reg);
        Pos += 4;

        return Pos;
    }

    private static void WriteUint32Cpu(byte[] Output, int Offset, uint Value)
    {
        Output[Offset] = (byte)(Value & 0xFF);
        Output[Offset + 1] = (byte)((Value >> 8) & 0xFF);
        Output[Offset + 2] = (byte)((Value >> 16) & 0xFF);
        Output[Offset + 3] = (byte)((Value >> 24) & 0xFF);
    }

    private static byte[][] ExtractBlockResults(byte[] RawOutput, int[] OutputOffsets, int[] OutputLengths, int BlockCount)
    {
        var Results = new byte[BlockCount][];

        for (var I = 0; I < BlockCount; I++)
        {
            var Length = OutputLengths[I];
            if (Length <= 0)
            {
                Results[I] = [GpuConstants.IlOpRet];
                continue;
            }

            Results[I] = new byte[Length];
            Array.Copy(RawOutput, OutputOffsets[I], Results[I], 0, Length);
        }

        return Results;
    }
}
