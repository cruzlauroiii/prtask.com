using System.Reflection.PortableExecutable;
using System.Text;
using Iced.Intel;

namespace PrTask.Transpiler;

public sealed class X86ToSharpConverter
{
    private readonly string Namespace;
    private const string Prefix = "R";

    public X86ToSharpConverter(string Namespace)
    {
        this.Namespace = Namespace;
    }

    public bool ConvertFile(string FilePath, string OutDir)
    {
        var FileName = Path.GetFileNameWithoutExtension(FilePath);
        var ClassName = ToPascalCase(FileName);

        try
        {
            using var Stream = File.OpenRead(FilePath);
            using var PeReader = new PEReader(Stream);
            var Headers = PeReader.PEHeaders;
            var Is64 = Headers.PEHeader is not null &&
                       Headers.PEHeader.Magic == PEMagic.PE32Plus;
            if (!Is64)
            {
                return false;
            }

            var ImageBase = Headers.PEHeader is not null
                ? unchecked(Headers.PEHeader.ImageBase)
                : 0x400000UL;

            var TextSectionRva = FindTextSectionRva(PeReader);
            var TextSection = FindTextSection(PeReader);
            if (TextSection.Length == 0)
            {
                return false;
            }

            var EntryRva = Headers.PEHeader is not null
                ? (uint)Headers.PEHeader.AddressOfEntryPoint
                : 0u;

            var Exports = ReadExports(PeReader, Headers);
            var Imports = ReadImports(PeReader, Headers);
            var IatMap = BuildIatMap(PeReader, Headers, Imports, ImageBase);

            var Sb = new StringBuilder();
            Sb.Append("namespace ").Append(Namespace).AppendLine(";");
            Sb.AppendLine();
            EmitCpuState(Sb, ClassName, FilePath, ImageBase, Headers);
            EmitFunctions(Sb, ClassName, TextSection, ImageBase, TextSectionRva, EntryRva, Exports, Imports, IatMap);

            var OutputPath = Path.Combine(OutDir, ClassName + ".g.cs");
            File.WriteAllText(OutputPath, Sb.ToString());
            return true;
        }
        catch
        {
            return false;
        }
    }

    private static uint FindTextSectionRva(PEReader PeReader)
    {
        foreach (var Section in PeReader.PEHeaders.SectionHeaders)
        {
            if (Section.Name == ".text")
            {
                return (uint)Section.VirtualAddress;
            }
        }

        return 0;
    }

    private static ReadOnlySpan<byte> FindTextSection(PEReader PeReader)
    {
        foreach (var Section in PeReader.PEHeaders.SectionHeaders)
        {
            if (Section.Name == ".text")
            {
                var Data = PeReader.GetSectionData(Section.VirtualAddress);
                if (Data.Length > 0)
                {
                    return Data.GetContent().AsSpan();
                }
            }
        }

        return ReadOnlySpan<byte>.Empty;
    }

    private static List<ExportEntry> ReadExports(PEReader PeReader, PEHeaders Headers)
    {
        var Result = new List<ExportEntry>();
        var ExportDir = Headers.PEHeader?.ExportTableDirectory;
        if (ExportDir is not { Size: > 0 })
        {
            return Result;
        }

        try
        {
            var SectionData = PeReader.GetSectionData(ExportDir.Value.RelativeVirtualAddress);
            if (SectionData.Length == 0)
            {
                return Result;
            }

            var Reader = SectionData.GetReader();
            Reader.ReadUInt32();
            Reader.ReadUInt32();
            Reader.ReadUInt16();
            Reader.ReadUInt16();
            Reader.ReadInt32();
            var NumberOfFunctions = Reader.ReadInt32();
            var NumberOfNames = Reader.ReadInt32();
            var FunctionRva = Reader.ReadInt32();
            var NamePointerRva = Reader.ReadInt32();
            Reader.ReadInt32();

            if (NumberOfNames <= 0 || NamePointerRva <= 0 || FunctionRva <= 0)
            {
                return Result;
            }

            var NameSection = PeReader.GetSectionData(NamePointerRva);
            var FuncSection = PeReader.GetSectionData(FunctionRva);
            var NameReader = NameSection.GetReader();
            var FuncReader = FuncSection.GetReader();

            var FuncRvas = new uint[NumberOfFunctions];
            for (var I = 0; I < NumberOfFunctions && I < 10000; I++)
            {
                FuncRvas[I] = FuncReader.ReadUInt32();
            }

            var EmittedNames = new HashSet<string>(StringComparer.Ordinal);
            for (var I = 0; I < NumberOfNames && I < 10000; I++)
            {
                var FuncNameRva = NameReader.ReadInt32();
                var FuncNameData = PeReader.GetSectionData(FuncNameRva);
                var FuncNameReader = FuncNameData.GetReader();
                var NameBuilder = new StringBuilder();
                byte B;
                while ((B = FuncNameReader.ReadByte()) is not 0)
                {
                    NameBuilder.Append((char)B);
                }

                var ExportName = NameBuilder.ToString();
                if (ExportName.Length > 0 && char.IsLetter(ExportName[0]) && IsValidExportName(ExportName) && EmittedNames.Add(ExportName))
                {
                    var Rva = I < FuncRvas.Length ? FuncRvas[I] : 0u;
                    Result.Add(new ExportEntry(ExportName, Rva));
                }
            }
        }
        catch
        {
        }

        return Result;
    }

    private static List<ImportEntry> ReadImports(PEReader PeReader, PEHeaders Headers)
    {
        var Result = new List<ImportEntry>();
        var ImportDir = Headers.PEHeader?.ImportTableDirectory;
        if (ImportDir is not { Size: > 0 })
        {
            return Result;
        }

        try
        {
            var SectionData = PeReader.GetSectionData(ImportDir.Value.RelativeVirtualAddress);
            if (SectionData.Length == 0)
            {
                return Result;
            }

            var Reader = SectionData.GetReader();
            while (Reader.RemainingBytes >= 20)
            {
                var IltRva = Reader.ReadInt32();
                Reader.ReadUInt32();
                Reader.ReadUInt32();
                var NameRva = Reader.ReadInt32();
                Reader.ReadUInt32();

                if (NameRva == 0)
                {
                    break;
                }

                var DllNameData = PeReader.GetSectionData(NameRva);
                var DllNameReader = DllNameData.GetReader();
                var DllNameSb = new StringBuilder();
                byte B;
                while (DllNameReader.RemainingBytes > 0 && (B = DllNameReader.ReadByte()) is not 0)
                {
                    DllNameSb.Append((char)B);
                }

                var Funcs = new List<string>();
                if (IltRva > 0)
                {
                    try
                    {
                        var IltData = PeReader.GetSectionData(IltRva);
                        var IltReader = IltData.GetReader();
                        while (IltReader.RemainingBytes >= 8)
                        {
                            var Entry = IltReader.ReadUInt64();
                            if (Entry == 0)
                            {
                                break;
                            }

                            if ((Entry & 0x8000000000000000UL) != 0)
                            {
                                continue;
                            }

                            var HintRva = (int)(Entry & 0x7FFFFFFFUL);
                            try
                            {
                                var HintData = PeReader.GetSectionData(HintRva);
                                var HintReader = HintData.GetReader();
                                HintReader.ReadUInt16();
                                var FuncNameSb = new StringBuilder();
                                while (HintReader.RemainingBytes > 0)
                                {
                                    var Fb = HintReader.ReadByte();
                                    if (Fb == 0)
                                    {
                                        break;
                                    }

                                    FuncNameSb.Append((char)Fb);
                                }

                                var FuncName = FuncNameSb.ToString();
                                if (FuncName.Length > 0 && IsValidExportName(FuncName))
                                {
                                    Funcs.Add(FuncName);
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                Result.Add(new ImportEntry(DllNameSb.ToString(), Funcs));
            }
        }
        catch
        {
        }

        return Result;
    }

    private static void EmitCpuState(StringBuilder Sb, string ClassName, string FilePath, ulong ImageBase, PEHeaders Headers)
    {
        var EscapedPath = FilePath.Replace("\\", "\\\\");
        var MemSize = 256 * 1024 * 1024;
        var StackBase = (ulong)(MemSize - 0x10000);

        Sb.Append("internal static partial class ").AppendLine(ClassName);
        Sb.AppendLine("{");
        Sb.Append("    private const int MemSize = ").Append(MemSize.ToString(System.Globalization.CultureInfo.InvariantCulture)).AppendLine(";");
        Sb.AppendLine("    private static readonly byte[] Mem = new byte[MemSize];");
        Sb.Append("    private const string PePath = @\"").Append(EscapedPath).AppendLine("\";");
        Sb.Append("    private const ulong ImageBase = ").Append(ImageBase.ToString(System.Globalization.CultureInfo.InvariantCulture)).AppendLine("UL;");
        Sb.AppendLine();

        var Regs = new[] { "Rax", "Rbx", "Rcx", "Rdx", "Rsi", "Rdi", "Rsp", "Rbp", "R8", "R9", "R10", "R11", "R12", "R13", "R14", "R15", "Rip" };
        foreach (var Reg in Regs)
        {
            Sb.Append("    private static ulong ").Append(Reg).AppendLine(";");
        }

        Sb.AppendLine();
        Sb.AppendLine("    private static bool Cf;");
        Sb.AppendLine("    private static bool Zf;");
        Sb.AppendLine("    private static bool Sf;");
        Sb.AppendLine("    private static bool Of;");
        Sb.AppendLine("    private static bool Pf;");
        Sb.AppendLine("    private static bool Initialized;");
        Sb.AppendLine();

        Sb.AppendLine("    private static void Init()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (Initialized) return;");
        Sb.AppendLine("        Initialized = true;");
        Sb.Append("        Rsp = ").Append(StackBase.ToString(System.Globalization.CultureInfo.InvariantCulture)).AppendLine("UL;");
        Sb.AppendLine("        Rbp = Rsp;");
        Sb.AppendLine("        if (!global::System.IO.File.Exists(PePath)) return;");
        Sb.AppendLine("        using var Fs = global::System.IO.File.OpenRead(PePath);");
        Sb.AppendLine("        using var Pe = new global::System.Reflection.PortableExecutable.PEReader(Fs);");
        Sb.AppendLine("        foreach (var Sec in Pe.PEHeaders.SectionHeaders)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Data = Pe.GetSectionData(Sec.VirtualAddress);");
        Sb.AppendLine("            if (Data.Length == 0) continue;");
        Sb.AppendLine("            var Content = Data.GetContent();");
        Sb.AppendLine("            var Offset = (int)((ulong)Sec.VirtualAddress);");
        Sb.AppendLine("            var Len = global::System.Math.Min(Content.Length, MemSize - Offset);");
        Sb.AppendLine("            if (Offset >= 0 && Offset < MemSize && Len > 0)");
        Sb.AppendLine("                Content.AsSpan(0, Len).CopyTo(Mem.AsSpan(Offset));");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.AppendLine("    private static void UpdateFlags(ulong Result, ulong A, ulong B, int Size)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Mask = Size switch { 1 => 0xFFUL, 2 => 0xFFFFUL, 4 => 0xFFFFFFFFUL, _ => ulong.MaxValue };");
        Sb.AppendLine("        var Masked = Result & Mask;");
        Sb.AppendLine("        Zf = Masked == 0;");
        Sb.AppendLine("        Sf = (Masked & (1UL << ((Size * 8) - 1))) != 0;");
        Sb.AppendLine("        Cf = Result > Mask;");
        Sb.AppendLine("        var SignBit = 1UL << ((Size * 8) - 1);");
        Sb.AppendLine("        Of = ((A ^ Result) & (B ^ Result) & SignBit) != 0;");
        Sb.AppendLine("        Pf = (global::System.Numerics.BitOperations.PopCount(Masked & 0xFF) & 1) == 0;");
        Sb.AppendLine("    }");
        Sb.AppendLine();

        Sb.AppendLine("    private static byte ReadByte(ulong Addr) { var I = (int)(Addr - ImageBase); return (I >= 0 && I < MemSize) ? Mem[I] : (byte)0; }");
        Sb.AppendLine("    private static ushort ReadWord(ulong Addr) => (ushort)(ReadByte(Addr) | (ReadByte(Addr + 1) << 8));");
        Sb.AppendLine("    private static uint ReadDword(ulong Addr) => (uint)(ReadByte(Addr) | (ReadByte(Addr + 1) << 8) | (ReadByte(Addr + 2) << 16) | (ReadByte(Addr + 3) << 24));");
        Sb.AppendLine("    private static ulong ReadQword(ulong Addr) => (ulong)ReadDword(Addr) | ((ulong)ReadDword(Addr + 4) << 32);");
        Sb.AppendLine("    private static void WriteByte(ulong Addr, byte Val) { var I = (int)(Addr - ImageBase); if (I >= 0 && I < MemSize) Mem[I] = Val; }");
        Sb.AppendLine("    private static void WriteWord(ulong Addr, ushort Val) { WriteByte(Addr, (byte)Val); WriteByte(Addr + 1, (byte)(Val >> 8)); }");
        Sb.AppendLine("    private static void WriteDword(ulong Addr, uint Val) { WriteByte(Addr, (byte)Val); WriteByte(Addr + 1, (byte)(Val >> 8)); WriteByte(Addr + 2, (byte)(Val >> 16)); WriteByte(Addr + 3, (byte)(Val >> 24)); }");
        Sb.AppendLine("    private static void WriteQword(ulong Addr, ulong Val) { WriteDword(Addr, (uint)Val); WriteDword(Addr + 4, (uint)(Val >> 32)); }");
        Sb.AppendLine();
        Sb.AppendLine("    private static void Push(ulong Val) { Rsp -= 8; WriteQword(Rsp, Val); }");
        Sb.AppendLine("    private static ulong Pop() { var V = ReadQword(Rsp); Rsp += 8; return V; }");
        Sb.AppendLine();
    }

    private void EmitFunctions(StringBuilder Sb, string ClassName, ReadOnlySpan<byte> CodeBytes,
        ulong ImageBase, uint TextSectionRva, uint EntryRva, List<ExportEntry> Exports, List<ImportEntry> Imports, Dictionary<ulong, string> IatMap)
    {
        var CodeArray = CodeBytes.ToArray();
        var DecodeBase = ImageBase + TextSectionRva;

        var Visited = new HashSet<ulong>();
        var DecodeQueue = new Queue<ulong>();
        if (EntryRva > 0)
        {
            DecodeQueue.Enqueue(ImageBase + EntryRva);
        }

        foreach (var Exp in Exports)
        {
            if (Exp.Rva > 0)
            {
                DecodeQueue.Enqueue(ImageBase + Exp.Rva);
            }
        }

        var Instructions = new Dictionary<ulong, Instruction>();
        var MaxDecodePerTarget = 4096;
        var MaxTotalBlocks = 50000;

        while (DecodeQueue.Count > 0 && Visited.Count < MaxTotalBlocks)
        {
            var Target = DecodeQueue.Dequeue();
            if (!Visited.Add(Target))
            {
                continue;
            }

            var Offset = (int)(Target - DecodeBase);
            if (Offset < 0 || Offset >= CodeArray.Length)
            {
                continue;
            }

            var SliceLen = Math.Min(MaxDecodePerTarget * 15, CodeArray.Length - Offset);
            var Slice = new byte[SliceLen];
            Array.Copy(CodeArray, Offset, Slice, 0, SliceLen);
            var Decoder = Iced.Intel.Decoder.Create(64, Slice, Target);
            for (var Count = 0; Decoder.IP < Target + (ulong)SliceLen && Count < MaxDecodePerTarget; Count++)
            {
                Decoder.Decode(out var Instr);
                if (Instr.IsInvalid)
                {
                    break;
                }

                if (!Instructions.ContainsKey(Instr.IP))
                {
                    Instructions[Instr.IP] = Instr;
                }

                if (Instr.FlowControl is FlowControl.ConditionalBranch or FlowControl.UnconditionalBranch or FlowControl.Call)
                {
                    var BrTarget = GetBranchTarget(Instr);
                    if (BrTarget > 0 && BrTarget >= DecodeBase && BrTarget < DecodeBase + (ulong)CodeArray.Length && !Visited.Contains(BrTarget))
                    {
                        DecodeQueue.Enqueue(BrTarget);
                    }
                }

                if (Instr.FlowControl is FlowControl.Return or FlowControl.UnconditionalBranch)
                {
                    break;
                }
            }
        }

        var InstrList = Instructions.Values.OrderBy(I => I.IP).ToList();

        foreach (var Imp in Imports)
        {
            var DllConst = ToPascalCase(Path.GetFileNameWithoutExtension(Imp.DllName));
            Sb.Append("    private const string Lib").Append(DllConst).Append(" = \"").Append(Imp.DllName).AppendLine("\";");
        }

        if (Imports.Count > 0)
        {
            Sb.AppendLine();
        }

        var EmittedPInvoke = new HashSet<string>(StringComparer.Ordinal);
        foreach (var Imp in Imports)
        {
            var DllConst = ToPascalCase(Path.GetFileNameWithoutExtension(Imp.DllName));
            foreach (var Func in Imp.Functions)
            {
                var SafeName = ToPascalCase(Func);
                if (!EmittedPInvoke.Add(SafeName))
                {
                    continue;
                }

                Sb.Append("    [global::System.Runtime.InteropServices.DllImport(Lib").Append(DllConst)
                  .Append(", EntryPoint = \"").Append(Func).AppendLine("\", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall)]");
                Sb.Append("    private static extern nint PInvoke").Append(SafeName).AppendLine("(nint A0 = 0, nint A1 = 0, nint A2 = 0, nint A3 = 0, nint A4 = 0, nint A5 = 0, nint A6 = 0, nint A7 = 0);");
                Sb.AppendLine();
            }
        }

        if (EntryRva > 0)
        {
            Sb.AppendLine("    internal static void Entry()");
            Sb.AppendLine("    {");
            Sb.AppendLine("        Init();");
            Sb.Append("        Block_").Append(EntryRva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("();");
            Sb.AppendLine("    }");
            Sb.AppendLine();
        }

        var EmittedExportNames = new HashSet<string>(StringComparer.Ordinal);
        foreach (var Exp in Exports)
        {
            var PascalName = ToPascalCase(Exp.Name);
            if (!EmittedExportNames.Add(PascalName))
            {
                continue;
            }

            var ConstName = string.Concat("Export", PascalName);
            Sb.Append("    internal const string ").Append(ConstName).Append(" = \"").Append(Exp.Name).AppendLine("\";");
            Sb.Append("    internal static void ").Append(PascalName).AppendLine("()");
            Sb.AppendLine("    {");
            Sb.Append("        Block_").Append(Exp.Rva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("();");
            Sb.AppendLine("    }");
            Sb.AppendLine();
        }

        var BranchTargets = new HashSet<ulong>();
        foreach (var Instr in InstrList)
        {
            if (Instr.FlowControl is FlowControl.ConditionalBranch or FlowControl.UnconditionalBranch or FlowControl.Call)
            {
                var Target = GetBranchTarget(Instr);
                if (Target > 0)
                {
                    BranchTargets.Add(Target);
                }
            }
        }

        var BlockStarts = new SortedSet<ulong>();
        if (EntryRva > 0)
        {
            BlockStarts.Add(ImageBase + EntryRva);
        }

        foreach (var Exp in Exports)
        {
            BlockStarts.Add(ImageBase + Exp.Rva);
        }

        foreach (var Target in BranchTargets)
        {
            BlockStarts.Add(Target);
        }

        if (BlockStarts.Count == 0 && Instructions.Count > 0)
        {
            BlockStarts.Add(Instructions[0].IP);
        }

        foreach (var BlockAddr in BlockStarts)
        {
            var Rva = BlockAddr - ImageBase;
            Sb.Append("    private static void Block_").Append(((uint)Rva).ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("()");
            Sb.AppendLine("    {");

            var InBlock = false;
            foreach (var Instr in InstrList)
            {
                if (Instr.IP == BlockAddr)
                {
                    InBlock = true;
                }

                if (!InBlock)
                {
                    continue;
                }

                EmitInstruction(Sb, Instr, ImageBase, IatMap);

                if (Instr.FlowControl is FlowControl.Return or FlowControl.UnconditionalBranch)
                {
                    break;
                }

                if (Instr.FlowControl == FlowControl.ConditionalBranch)
                {
                    var NextAddr = Instr.NextIP;
                    if (BlockStarts.Contains(NextAddr))
                    {
                        var NextRva = (uint)(NextAddr - ImageBase);
                        Sb.Append("        Block_").Append(NextRva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("();");
                        break;
                    }
                }
            }

            Sb.AppendLine("    }");
            Sb.AppendLine();
        }

        Sb.AppendLine("    private static readonly global::System.Collections.Generic.Dictionary<ulong, global::System.Action> Dispatch = new()");
        Sb.AppendLine("    {");
        foreach (var BlockAddr in BlockStarts)
        {
            var Rva = (uint)(BlockAddr - ImageBase);
            Sb.Append("        [").Append(BlockAddr.ToString(System.Globalization.CultureInfo.InvariantCulture))
              .Append("UL] = Block_").Append(Rva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine(",");
        }

        Sb.AppendLine("    };");
        Sb.AppendLine();
        Sb.AppendLine("    private static void CallIndirect(ulong Addr) { if (Dispatch.TryGetValue(Addr, out var Fn)) Fn(); }");
        Sb.AppendLine("    private static void CallIndirectMem(ulong Addr) { CallIndirect(ReadQword(Addr)); }");
        Sb.AppendLine();

        Sb.AppendLine("}");
    }

    private static void EmitInstruction(StringBuilder Sb, Instruction Instr, ulong ImageBase, Dictionary<ulong, string> IatMap)
    {
        switch (Instr.Mnemonic)
        {
            case Mnemonic.Nop:
                break;
            case Mnemonic.Push:
                EmitPush(Sb, Instr);
                break;
            case Mnemonic.Pop:
                EmitStore(Sb, Instr, 0, "Pop()");
                break;
            case Mnemonic.Mov:
                EmitMov(Sb, Instr);
                break;
            case Mnemonic.Lea:
                EmitLea(Sb, Instr);
                break;
            case Mnemonic.Add:
                EmitArith(Sb, Instr, "+");
                break;
            case Mnemonic.Sub:
                EmitArith(Sb, Instr, "-");
                break;
            case Mnemonic.And:
                EmitArith(Sb, Instr, "&");
                break;
            case Mnemonic.Or:
                EmitArith(Sb, Instr, "|");
                break;
            case Mnemonic.Xor:
                EmitXor(Sb, Instr);
                break;
            case Mnemonic.Inc:
                EmitUnary(Sb, Instr, false, "+ 1");
                break;
            case Mnemonic.Dec:
                EmitUnary(Sb, Instr, false, "- 1");
                break;
            case Mnemonic.Not:
                EmitUnary(Sb, Instr, true, "~");
                break;
            case Mnemonic.Neg:
                EmitUnary(Sb, Instr, true, "(ulong)-(long)");
                break;
            case Mnemonic.Shl:
                EmitShift(Sb, Instr, "<<");
                break;
            case Mnemonic.Shr:
            case Mnemonic.Sar:
                EmitShift(Sb, Instr, ">>");
                break;
            case Mnemonic.Cmp:
                EmitCmp(Sb, Instr);
                break;
            case Mnemonic.Test:
                EmitTest(Sb, Instr);
                break;
            case Mnemonic.Jmp:
                EmitJmp(Sb, Instr, ImageBase);
                break;
            case Mnemonic.Je:
                EmitJcc(Sb, Instr, ImageBase, "Zf");
                break;
            case Mnemonic.Jne:
                EmitJcc(Sb, Instr, ImageBase, "!Zf");
                break;
            case Mnemonic.Jl:
                EmitJcc(Sb, Instr, ImageBase, "Sf != Of");
                break;
            case Mnemonic.Jge:
                EmitJcc(Sb, Instr, ImageBase, "Sf == Of");
                break;
            case Mnemonic.Jle:
                EmitJcc(Sb, Instr, ImageBase, "Zf || Sf != Of");
                break;
            case Mnemonic.Jg:
                EmitJcc(Sb, Instr, ImageBase, "!Zf && Sf == Of");
                break;
            case Mnemonic.Jb:
                EmitJcc(Sb, Instr, ImageBase, "Cf");
                break;
            case Mnemonic.Jae:
                EmitJcc(Sb, Instr, ImageBase, "!Cf");
                break;
            case Mnemonic.Jbe:
                EmitJcc(Sb, Instr, ImageBase, "Cf || Zf");
                break;
            case Mnemonic.Ja:
                EmitJcc(Sb, Instr, ImageBase, "!Cf && !Zf");
                break;
            case Mnemonic.Js:
                EmitJcc(Sb, Instr, ImageBase, "Sf");
                break;
            case Mnemonic.Jns:
                EmitJcc(Sb, Instr, ImageBase, "!Sf");
                break;
            case Mnemonic.Call:
                EmitCall(Sb, Instr, ImageBase, IatMap);
                break;
            case Mnemonic.Ret:
                Sb.AppendLine("        return;");
                break;
            case Mnemonic.Imul:
                EmitImul(Sb, Instr);
                break;
            case Mnemonic.Movzx:
                EmitMovzx(Sb, Instr);
                break;
            case Mnemonic.Movsx:
            case Mnemonic.Movsxd:
                EmitMovsx(Sb, Instr);
                break;
            case Mnemonic.Cdq:
                Sb.AppendLine("        Rdx = (ulong)(((long)Rax >> 32));");
                break;
            case Mnemonic.Cqo:
                Sb.AppendLine("        Rdx = (ulong)((long)Rax >> 63);");
                break;
            case Mnemonic.Cbw:
                Sb.AppendLine("        Rax = (Rax & 0xFFFFFFFFFFFF0000UL) | (ushort)(sbyte)Rax;");
                break;
            case Mnemonic.Cwde:
                Sb.AppendLine("        Rax = (ulong)(uint)(int)(short)Rax;");
                break;
            case Mnemonic.Cdqe:
                Sb.AppendLine("        Rax = (ulong)(long)(int)Rax;");
                break;
            case Mnemonic.Mul:
                EmitMul(Sb, Instr);
                break;
            case Mnemonic.Div:
                EmitDiv(Sb, Instr, false);
                break;
            case Mnemonic.Idiv:
                EmitDiv(Sb, Instr, true);
                break;
            case Mnemonic.Adc:
                EmitAdc(Sb, Instr);
                break;
            case Mnemonic.Sbb:
                EmitSbb(Sb, Instr);
                break;
            case Mnemonic.Xchg:
                EmitXchg(Sb, Instr);
                break;
            case Mnemonic.Rol:
                EmitRotate(Sb, Instr, "<<", ">>");
                break;
            case Mnemonic.Ror:
                EmitRotate(Sb, Instr, ">>", "<<");
                break;
            case Mnemonic.Bt:
                EmitBt(Sb, Instr);
                break;
            case Mnemonic.Bts:
                EmitBts(Sb, Instr);
                break;
            case Mnemonic.Btr:
                EmitBtr(Sb, Instr);
                break;
            case Mnemonic.Bsf:
                EmitBsf(Sb, Instr);
                break;
            case Mnemonic.Bsr:
                EmitBsr(Sb, Instr);
                break;
            case Mnemonic.Lzcnt:
                EmitLzcnt(Sb, Instr);
                break;
            case Mnemonic.Tzcnt:
                EmitTzcnt(Sb, Instr);
                break;
            case Mnemonic.Popcnt:
                EmitPopcnt(Sb, Instr);
                break;
            case Mnemonic.Cmove:
                EmitCmov(Sb, Instr, "Zf");
                break;
            case Mnemonic.Cmovne:
                EmitCmov(Sb, Instr, "!Zf");
                break;
            case Mnemonic.Cmovl:
                EmitCmov(Sb, Instr, "Sf != Of");
                break;
            case Mnemonic.Cmovge:
                EmitCmov(Sb, Instr, "Sf == Of");
                break;
            case Mnemonic.Cmovle:
                EmitCmov(Sb, Instr, "Zf || Sf != Of");
                break;
            case Mnemonic.Cmovg:
                EmitCmov(Sb, Instr, "!Zf && Sf == Of");
                break;
            case Mnemonic.Cmovb:
                EmitCmov(Sb, Instr, "Cf");
                break;
            case Mnemonic.Cmovae:
                EmitCmov(Sb, Instr, "!Cf");
                break;
            case Mnemonic.Cmovbe:
                EmitCmov(Sb, Instr, "Cf || Zf");
                break;
            case Mnemonic.Cmova:
                EmitCmov(Sb, Instr, "!Cf && !Zf");
                break;
            case Mnemonic.Cmovs:
                EmitCmov(Sb, Instr, "Sf");
                break;
            case Mnemonic.Cmovns:
                EmitCmov(Sb, Instr, "!Sf");
                break;
            case Mnemonic.Sete:
                EmitSetcc(Sb, Instr, "Zf");
                break;
            case Mnemonic.Setne:
                EmitSetcc(Sb, Instr, "!Zf");
                break;
            case Mnemonic.Setl:
                EmitSetcc(Sb, Instr, "Sf != Of");
                break;
            case Mnemonic.Setge:
                EmitSetcc(Sb, Instr, "Sf == Of");
                break;
            case Mnemonic.Setle:
                EmitSetcc(Sb, Instr, "Zf || Sf != Of");
                break;
            case Mnemonic.Setg:
                EmitSetcc(Sb, Instr, "!Zf && Sf == Of");
                break;
            case Mnemonic.Setb:
                EmitSetcc(Sb, Instr, "Cf");
                break;
            case Mnemonic.Setae:
                EmitSetcc(Sb, Instr, "!Cf");
                break;
            case Mnemonic.Setbe:
                EmitSetcc(Sb, Instr, "Cf || Zf");
                break;
            case Mnemonic.Seta:
                EmitSetcc(Sb, Instr, "!Cf && !Zf");
                break;
            case Mnemonic.Sets:
                EmitSetcc(Sb, Instr, "Sf");
                break;
            case Mnemonic.Setns:
                EmitSetcc(Sb, Instr, "!Sf");
                break;
            case Mnemonic.Stc:
                Sb.AppendLine("        Cf = true;");
                break;
            case Mnemonic.Clc:
                Sb.AppendLine("        Cf = false;");
                break;
            case Mnemonic.Cmc:
                Sb.AppendLine("        Cf = !Cf;");
                break;
            case Mnemonic.Cld:
            case Mnemonic.Std:
            case Mnemonic.Int3:
            case Mnemonic.Ud2:
            case Mnemonic.Endbr64:
                break;
        }
    }

    private static void EmitPush(StringBuilder Sb, Instruction Instr)
    {
        Sb.Append("        Push(");
        if (Instr.Op0Kind == OpKind.Register)
        {
            Sb.Append(MapReg(Instr.Op0Register));
        }
        else
        {
            Sb.Append(GetImmediate(Instr));
        }

        Sb.AppendLine(");");
    }

    private static void EmitMov(StringBuilder Sb, Instruction Instr)
    {
        var ValSb = new StringBuilder();
        EmitOperand(ValSb, Instr, 1);
        EmitStore(Sb, Instr, 0, ValSb.ToString());
    }

    private static void EmitLea(StringBuilder Sb, Instruction Instr)
    {
        var ValSb = new StringBuilder();
        EmitMemoryAddress(ValSb, Instr);
        EmitStore(Sb, Instr, 0, ValSb.ToString());
    }

    private static void EmitArith(StringBuilder Sb, Instruction Instr, string Op)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        var Size = GetOperandSize(Instr, 0);
        Sb.Append("        { var A = (ulong)").Append(Op0Sb);
        Sb.Append("; var B = (ulong)").Append(Op1Sb);
        Sb.Append("; var R = A ").Append(Op).Append(" B; ");
        Sb.Append("UpdateFlags(R, A, B, ").Append(Size.ToString(System.Globalization.CultureInfo.InvariantCulture)).Append("); ");
        var StoreSb = new StringBuilder();
        EmitStore(StoreSb, Instr, 0, "R");
        Sb.Append(StoreSb.ToString().TrimStart()).Append(" }");
        Sb.AppendLine();
    }

    private static void EmitXor(StringBuilder Sb, Instruction Instr)
    {
        if (Instr.Op0Kind == OpKind.Register && Instr.Op1Kind == OpKind.Register &&
            Instr.Op0Register == Instr.Op1Register)
        {
            var BaseName = MapRegBase(Instr.Op0Register);
            Sb.Append("        ").Append(BaseName).AppendLine(" = 0; Zf = true; Sf = false; Cf = false; Of = false;");
            return;
        }

        EmitArith(Sb, Instr, "^");
    }

    private static void EmitUnary(StringBuilder Sb, Instruction Instr, bool IsPrefix, string Op)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Operand = Op0Sb.ToString();
        var Expr = IsPrefix
            ? string.Concat(Op, "(", Operand, ")")
            : string.Concat(Operand, " ", Op);
        EmitStore(Sb, Instr, 0, Expr);
    }

    private static void EmitShift(StringBuilder Sb, Instruction Instr, string Op)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        EmitStore(Sb, Instr, 0, string.Concat(Op0Sb.ToString(), " ", Op, " (int)", Op1Sb.ToString()));
    }

    private static void EmitCmp(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        Sb.Append("        { var A = (ulong)").Append(Op0Sb);
        Sb.Append("; var B = (ulong)").Append(Op1Sb);
        Sb.Append("; var R = A - B; UpdateFlags(R, A, B, ");
        Sb.Append(GetOperandSize(Instr, 0).ToString(System.Globalization.CultureInfo.InvariantCulture));
        Sb.AppendLine("); }");
    }

    private static void EmitTest(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        Sb.Append("        { var R = (ulong)").Append(Op0Sb);
        Sb.Append(" & (ulong)").Append(Op1Sb);
        Sb.Append("; Zf = R == 0; Sf = (R & (1UL << (");
        Sb.Append(((GetOperandSize(Instr, 0) * 8) - 1).ToString(System.Globalization.CultureInfo.InvariantCulture));
        Sb.AppendLine("))) != 0; Cf = false; Of = false; }");
    }

    private static void EmitJmp(StringBuilder Sb, Instruction Instr, ulong ImageBase)
    {
        var Target = GetBranchTarget(Instr);
        if (Target > 0)
        {
            var Rva = (uint)(Target - ImageBase);
            Sb.Append("        Block_").Append(Rva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("(); return;");
        }
        else if (Instr.Op0Kind == OpKind.Register)
        {
            Sb.Append("        CallIndirect(").Append(MapReg(Instr.Op0Register)).AppendLine("); return;");
        }
        else if (Instr.Op0Kind == OpKind.Memory)
        {
            Sb.Append("        CallIndirectMem(");
            EmitMemoryAddress(Sb, Instr);
            Sb.AppendLine("); return;");
        }
        else
        {
            Sb.AppendLine("        return;");
        }
    }

    private static void EmitJcc(StringBuilder Sb, Instruction Instr, ulong ImageBase, string Condition)
    {
        var Target = GetBranchTarget(Instr);
        if (Target > 0)
        {
            var Rva = (uint)(Target - ImageBase);
            Sb.Append("        if (").Append(Condition).Append(") { Block_")
              .Append(Rva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("(); return; }");
        }
    }

    private static void EmitCall(StringBuilder Sb, Instruction Instr, ulong ImageBase, Dictionary<ulong, string> IatMap)
    {
        if (Instr.Op0Kind == OpKind.Memory && Instr.IsIPRelativeMemoryOperand)
        {
            var MemAddr = Instr.IPRelativeMemoryAddress;
            if (IatMap.TryGetValue(MemAddr, out var FuncName))
            {
                var SafeName = ToPascalCase(FuncName);
                if (IsUnsafePInvoke(FuncName))
                {
                    Sb.Append("        Rax = 1;");
                }
                else
                {
                    Sb.Append("        try { Rax = (ulong)PInvoke").Append(SafeName)
                      .Append("((nint)Rcx, (nint)Rdx, (nint)R8, (nint)R9); } catch { Rax = 0; }");
                }

                Sb.AppendLine();
                return;
            }
        }

        var Target = GetBranchTarget(Instr);
        if (Target > 0)
        {
            var Rva = (uint)(Target - ImageBase);
            Sb.Append("        Block_").Append(Rva.ToString("X", System.Globalization.CultureInfo.InvariantCulture)).AppendLine("();");
        }
        else if (Instr.Op0Kind == OpKind.Register)
        {
            Sb.Append("        CallIndirect(").Append(MapReg(Instr.Op0Register)).AppendLine(");");
        }
        else if (Instr.Op0Kind == OpKind.Memory && !Instr.IsIPRelativeMemoryOperand)
        {
            Sb.Append("        CallIndirectMem(");
            EmitMemoryAddress(Sb, Instr);
            Sb.AppendLine(");");
        }
    }

    private static void EmitImul(StringBuilder Sb, Instruction Instr)
    {
        if (Instr.OpCount == 3)
        {
            var Op1Sb = new StringBuilder();
            EmitOperand(Op1Sb, Instr, 1);
            var Op2Sb = new StringBuilder();
            EmitOperand(Op2Sb, Instr, 2);
            EmitStore(Sb, Instr, 0, string.Concat(Op1Sb.ToString(), " * ", Op2Sb.ToString()));
        }
        else if (Instr.OpCount == 2)
        {
            var Op0Sb = new StringBuilder();
            EmitOperand(Op0Sb, Instr, 0);
            var Op1Sb = new StringBuilder();
            EmitOperand(Op1Sb, Instr, 1);
            EmitStore(Sb, Instr, 0, string.Concat(Op0Sb.ToString(), " * ", Op1Sb.ToString()));
        }
    }

    private static void EmitMovzx(StringBuilder Sb, Instruction Instr)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        EmitStore(Sb, Instr, 0, SrcSb.ToString());
    }

    private static void EmitMovsx(StringBuilder Sb, Instruction Instr)
    {
        var SrcSize = GetOperandSize(Instr, 1);
        var SignedType = SrcSize switch { 1 => "(sbyte)", 2 => "(short)", _ => "(int)" };
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        var DstSize = GetOperandSize(Instr, 0);
        var Expr = DstSize == 8
            ? string.Concat("(ulong)(long)", SignedType, "(", SrcSb.ToString(), ")")
            : string.Concat(SignedType, "(", SrcSb.ToString(), ")");
        EmitStore(Sb, Instr, 0, Expr);
    }

    private static void EmitMul(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Size = GetOperandSize(Instr, 0);
        if (Size == 8)
        {
            Sb.Append("        { var V = (global::System.UInt128)Rax * (global::System.UInt128)").Append(Op0Sb).AppendLine("; Rax = (ulong)V; Rdx = (ulong)(V >> 64); }");
        }
        else
        {
            Sb.Append("        { var V = (ulong)(uint)Rax * (ulong)").Append(Op0Sb).AppendLine("; Rax = (Rax & 0xFFFFFFFF00000000UL) | (uint)V; Rdx = (Rdx & 0xFFFFFFFF00000000UL) | (uint)(V >> 32); }");
        }
    }

    private static void EmitDiv(StringBuilder Sb, Instruction Instr, bool IsSigned)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Size = GetOperandSize(Instr, 0);
        if (IsSigned)
        {
            if (Size == 8)
            {
                Sb.Append("        { var D = (long)").Append(Op0Sb).AppendLine("; Rax = (ulong)((long)Rax / D); Rdx = (ulong)((long)Rax % D); }");
            }
            else
            {
                Sb.Append("        { var D = (int)").Append(Op0Sb).AppendLine("; Rax = unchecked((ulong)(uint)((int)Rax / D)); Rdx = unchecked((ulong)(uint)((int)Rax % D)); }");
            }
        }
        else if (Size == 8)
        {
            Sb.Append("        { var D = (ulong)").Append(Op0Sb).AppendLine("; Rax = Rax / D; Rdx = Rax % D; }");
        }
        else
        {
            Sb.Append("        { var D = (uint)").Append(Op0Sb).AppendLine("; Rax = unchecked((ulong)(uint)((uint)Rax / D)); Rdx = unchecked((ulong)(uint)((uint)Rax % D)); }");
        }
    }

    private static void EmitAdc(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        var Size = GetOperandSize(Instr, 0);
        Sb.Append("        { var A = (ulong)").Append(Op0Sb);
        Sb.Append("; var B = (ulong)").Append(Op1Sb);
        Sb.Append("; var R = A + B + (Cf ? 1UL : 0UL); ");
        Sb.Append("UpdateFlags(R, A, B, ").Append(Size.ToString(System.Globalization.CultureInfo.InvariantCulture)).Append("); ");
        var StoreSb = new StringBuilder();
        EmitStore(StoreSb, Instr, 0, "R");
        Sb.Append(StoreSb.ToString().TrimStart()).Append(" }");
        Sb.AppendLine();
    }

    private static void EmitSbb(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        var Size = GetOperandSize(Instr, 0);
        Sb.Append("        { var A = (ulong)").Append(Op0Sb);
        Sb.Append("; var B = (ulong)").Append(Op1Sb);
        Sb.Append("; var R = A - B - (Cf ? 1UL : 0UL); ");
        Sb.Append("UpdateFlags(R, A, B, ").Append(Size.ToString(System.Globalization.CultureInfo.InvariantCulture)).Append("); ");
        var StoreSb = new StringBuilder();
        EmitStore(StoreSb, Instr, 0, "R");
        Sb.Append(StoreSb.ToString().TrimStart()).Append(" }");
        Sb.AppendLine();
    }

    private static void EmitXchg(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        Sb.Append("        { var T = ").Append(Op0Sb).Append("; ");
        var S0 = new StringBuilder();
        EmitStore(S0, Instr, 0, Op1Sb.ToString());
        Sb.Append(S0.ToString().TrimStart()).Append(' ');
        var S1 = new StringBuilder();
        EmitStore(S1, Instr, 1, "T");
        Sb.Append(S1.ToString().TrimStart()).Append(" }");
        Sb.AppendLine();
    }

    private static void EmitRotate(StringBuilder Sb, Instruction Instr, string Dir, string RevDir)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        var Size = GetOperandSize(Instr, 0);
        var Bits = (Size * 8).ToString(System.Globalization.CultureInfo.InvariantCulture);
        var Expr = string.Concat("(", Op0Sb.ToString(), " ", Dir, " (int)", Op1Sb.ToString(), ") | (", Op0Sb.ToString(), " ", RevDir, " (", Bits, " - (int)", Op1Sb.ToString(), "))");
        EmitStore(Sb, Instr, 0, Expr);
    }

    private static void EmitBt(StringBuilder Sb, Instruction Instr)
    {
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        Sb.Append("        Cf = ((ulong)").Append(Op0Sb).Append(" & (1UL << (int)(").Append(Op1Sb).AppendLine("))) != 0;");
    }

    private static void EmitBts(StringBuilder Sb, Instruction Instr)
    {
        EmitBt(Sb, Instr);
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        EmitStore(Sb, Instr, 0, string.Concat(Op0Sb.ToString(), " | (1UL << (int)(", Op1Sb.ToString(), "))"));
    }

    private static void EmitBtr(StringBuilder Sb, Instruction Instr)
    {
        EmitBt(Sb, Instr);
        var Op0Sb = new StringBuilder();
        EmitOperand(Op0Sb, Instr, 0);
        var Op1Sb = new StringBuilder();
        EmitOperand(Op1Sb, Instr, 1);
        EmitStore(Sb, Instr, 0, string.Concat(Op0Sb.ToString(), " & ~(1UL << (int)(", Op1Sb.ToString(), "))"));
    }

    private static void EmitBsf(StringBuilder Sb, Instruction Instr)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        Sb.Append("        { var V = (ulong)").Append(SrcSb).AppendLine("; Zf = V == 0;");
        EmitStore(Sb, Instr, 0, "V == 0 ? 0UL : (ulong)global::System.Numerics.BitOperations.TrailingZeroCount(V)");
        Sb.AppendLine("        }");
    }

    private static void EmitBsr(StringBuilder Sb, Instruction Instr)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        Sb.Append("        { var V = (ulong)").Append(SrcSb).AppendLine("; Zf = V == 0;");
        EmitStore(Sb, Instr, 0, "V == 0 ? 0UL : (ulong)(63 - global::System.Numerics.BitOperations.LeadingZeroCount(V))");
        Sb.AppendLine("        }");
    }

    private static void EmitLzcnt(StringBuilder Sb, Instruction Instr)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        EmitStore(Sb, Instr, 0, string.Concat("(ulong)global::System.Numerics.BitOperations.LeadingZeroCount((ulong)", SrcSb.ToString(), ")"));
    }

    private static void EmitTzcnt(StringBuilder Sb, Instruction Instr)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        EmitStore(Sb, Instr, 0, string.Concat("(ulong)global::System.Numerics.BitOperations.TrailingZeroCount((ulong)", SrcSb.ToString(), ")"));
    }

    private static void EmitPopcnt(StringBuilder Sb, Instruction Instr)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        EmitStore(Sb, Instr, 0, string.Concat("(ulong)global::System.Numerics.BitOperations.PopCount((ulong)", SrcSb.ToString(), ")"));
    }

    private static void EmitCmov(StringBuilder Sb, Instruction Instr, string Condition)
    {
        var SrcSb = new StringBuilder();
        EmitOperand(SrcSb, Instr, 1);
        Sb.Append("        if (").Append(Condition).Append(") { ");
        var StoreSb = new StringBuilder();
        EmitStore(StoreSb, Instr, 0, SrcSb.ToString());
        Sb.Append(StoreSb.ToString().TrimStart()).Append(" }");
        Sb.AppendLine();
    }

    private static void EmitSetcc(StringBuilder Sb, Instruction Instr, string Condition)
    {
        EmitStore(Sb, Instr, 0, string.Concat("(", Condition, ") ? 1UL : 0UL"));
    }

    private static void EmitOperand(StringBuilder Sb, Instruction Instr, int OpIdx)
    {
        var Kind = Instr.GetOpKind(OpIdx);
        switch (Kind)
        {
            case OpKind.Register:
                Sb.Append(MapReg(Instr.GetOpRegister(OpIdx)));
                break;
            case OpKind.Memory:
                var Size = GetOperandSize(Instr, OpIdx);
                var ReadFunc = Size switch { 1 => "ReadByte", 2 => "ReadWord", _ => "ReadDword" };
                Sb.Append(ReadFunc).Append('(');
                EmitMemoryAddress(Sb, Instr);
                Sb.Append(')');
                break;
            case OpKind.Immediate8:
            case OpKind.Immediate8_2nd:
            case OpKind.Immediate16:
            case OpKind.Immediate32:
            case OpKind.Immediate64:
            case OpKind.Immediate8to16:
            case OpKind.Immediate8to32:
            case OpKind.Immediate8to64:
            case OpKind.Immediate32to64:
                Sb.Append(Instr.GetImmediate(OpIdx).ToString(System.Globalization.CultureInfo.InvariantCulture)).Append("UL");
                break;
            default:
                Sb.Append("0UL");
                break;
        }
    }

    private static void EmitMemoryAddress(StringBuilder Sb, Instruction Instr)
    {
        if (Instr.IsIPRelativeMemoryOperand)
        {
            Sb.Append(Instr.IPRelativeMemoryAddress.ToString(System.Globalization.CultureInfo.InvariantCulture)).Append("UL");
            return;
        }

        var HasBase = Instr.MemoryBase != Register.None;
        var HasIndex = Instr.MemoryIndex != Register.None;
        var HasDisp = Instr.MemoryDisplacement64 != 0;
        var Written = false;

        if (HasBase)
        {
            Sb.Append(MapReg(Instr.MemoryBase));
            Written = true;
        }

        if (HasIndex)
        {
            if (Written)
            {
                Sb.Append(" + ");
            }

            Sb.Append(MapReg(Instr.MemoryIndex));
            if (Instr.MemoryIndexScale > 1)
            {
                Sb.Append(" * ").Append(Instr.MemoryIndexScale.ToString(System.Globalization.CultureInfo.InvariantCulture));
            }

            Written = true;
        }

        if (HasDisp)
        {
            if (Written)
            {
                Sb.Append(" + ");
            }

            Sb.Append(Instr.MemoryDisplacement64.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        if (!Written && !HasDisp)
        {
            Sb.Append('0');
        }
    }

    private static void EmitStore(StringBuilder Sb, Instruction Instr, int OpIdx, string ValueExpr)
    {
        var Kind = Instr.GetOpKind(OpIdx);
        if (Kind == OpKind.Register)
        {
            var Reg = Instr.GetOpRegister(OpIdx);
            var BaseName = MapRegBase(Reg);
            var Size = GetOperandSize(Instr, OpIdx);
            if (Size >= 4 && Size < 8)
            {
                if (Size >= 4)
                {
                    Sb.Append("        ").Append(BaseName).Append(" = unchecked((uint)(").Append(ValueExpr).AppendLine("));");
                }
                else if (Size == 2)
                {
                    Sb.Append("        ").Append(BaseName).Append(" = (").Append(BaseName).Append(" & 0xFFFF0000U) | unchecked((ushort)(").Append(ValueExpr).AppendLine("));");
                }
                else if (Reg is Register.AH or Register.CH or Register.DH or Register.BH)
                {
                    Sb.Append("        ").Append(BaseName).Append(" = (").Append(BaseName).Append(" & 0xFFFF00FFU) | ((uint)(byte)(").Append(ValueExpr).AppendLine(") << 8);");
                }
                else
                {
                    Sb.Append("        ").Append(BaseName).Append(" = (").Append(BaseName).Append(" & 0xFFFFFF00U) | (byte)(").Append(ValueExpr).AppendLine(");");
                }
            }
            else if (Size == 8)
            {
                Sb.Append("        ").Append(BaseName).Append(" = ").Append(ValueExpr).AppendLine(";");
            }
            else if (Size == 4)
            {
                Sb.Append("        ").Append(BaseName).Append(" = unchecked((ulong)(uint)(").Append(ValueExpr).AppendLine("));");
            }
            else if (Size == 2)
            {
                Sb.Append("        ").Append(BaseName).Append(" = (").Append(BaseName).Append(" & 0xFFFFFFFFFFFF0000UL) | unchecked((ushort)(").Append(ValueExpr).AppendLine("));");
            }
            else if (Reg is Register.AH or Register.CH or Register.DH or Register.BH)
            {
                Sb.Append("        ").Append(BaseName).Append(" = (").Append(BaseName).Append(" & 0xFFFFFFFFFFFF00FFUL) | ((ulong)(byte)(").Append(ValueExpr).AppendLine(") << 8);");
            }
            else
            {
                Sb.Append("        ").Append(BaseName).Append(" = (").Append(BaseName).Append(" & 0xFFFFFFFFFFFFFF00UL) | (byte)(").Append(ValueExpr).AppendLine(");");
            }
        }
        else if (Kind == OpKind.Memory)
        {
            var Size = GetOperandSize(Instr, OpIdx);
            var WriteFunc = Size switch { 1 => "WriteByte", 2 => "WriteWord", _ => "WriteDword" };
            var Cast = Size switch { 1 => "(byte)", 2 => "(ushort)", _ => "(uint)" };
            Sb.Append("        ").Append(WriteFunc).Append('(');
            EmitMemoryAddress(Sb, Instr);
            Sb.Append(", unchecked(").Append(Cast).Append('(').Append(ValueExpr).AppendLine(")));");
        }
    }

    private static ulong GetBranchTarget(Instruction Instr)
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

    private static ulong GetImmediate(Instruction Instr)
    {
        for (var I = 0; I < Instr.OpCount; I++)
        {
            var Kind = Instr.GetOpKind(I);
            if (Kind is >= OpKind.Immediate8 and <= OpKind.Immediate32to64)
            {
                return Instr.GetImmediate(I);
            }
        }

        return 0;
    }

    private static string MapReg(Register Reg)
    {
        return Reg switch
        {
            Register.AL => "(byte)Rax",
            Register.CL => "(byte)Rcx",
            Register.DL => "(byte)Rdx",
            Register.BL => "(byte)Rbx",
            Register.SPL => "(byte)Rsp",
            Register.BPL => "(byte)Rbp",
            Register.SIL => "(byte)Rsi",
            Register.DIL => "(byte)Rdi",
            Register.R8L => "(byte)R8",
            Register.R9L => "(byte)R9",
            Register.R10L => "(byte)R10",
            Register.R11L => "(byte)R11",
            Register.R12L => "(byte)R12",
            Register.R13L => "(byte)R13",
            Register.R14L => "(byte)R14",
            Register.R15L => "(byte)R15",
            Register.AX => "(ushort)Rax",
            Register.CX => "(ushort)Rcx",
            Register.DX => "(ushort)Rdx",
            Register.BX => "(ushort)Rbx",
            Register.SP => "(ushort)Rsp",
            Register.BP => "(ushort)Rbp",
            Register.SI => "(ushort)Rsi",
            Register.DI => "(ushort)Rdi",
            Register.R8W => "(ushort)R8",
            Register.R9W => "(ushort)R9",
            Register.R10W => "(ushort)R10",
            Register.R11W => "(ushort)R11",
            Register.R12W => "(ushort)R12",
            Register.R13W => "(ushort)R13",
            Register.R14W => "(ushort)R14",
            Register.R15W => "(ushort)R15",
            Register.EAX => "(uint)Rax",
            Register.ECX => "(uint)Rcx",
            Register.EDX => "(uint)Rdx",
            Register.EBX => "(uint)Rbx",
            Register.ESP => "(uint)Rsp",
            Register.EBP => "(uint)Rbp",
            Register.ESI => "(uint)Rsi",
            Register.EDI => "(uint)Rdi",
            Register.R8D => "(uint)R8",
            Register.R9D => "(uint)R9",
            Register.R10D => "(uint)R10",
            Register.R11D => "(uint)R11",
            Register.R12D => "(uint)R12",
            Register.R13D => "(uint)R13",
            Register.R14D => "(uint)R14",
            Register.R15D => "(uint)R15",
            Register.RAX => "Rax",
            Register.RCX => "Rcx",
            Register.RDX => "Rdx",
            Register.RBX => "Rbx",
            Register.RSP => "Rsp",
            Register.RBP => "Rbp",
            Register.RSI => "Rsi",
            Register.RDI => "Rdi",
            Register.R8 => "R8",
            Register.R9 => "R9",
            Register.R10 => "R10",
            Register.R11 => "R11",
            Register.R12 => "R12",
            Register.R13 => "R13",
            Register.R14 => "R14",
            Register.R15 => "R15",
            Register.RIP => "Rip",
            _ => "0UL",
        };
    }

    private static string MapRegBase(Register Reg)
    {
        return Reg switch
        {
            Register.AL or Register.AH or Register.AX or Register.EAX or Register.RAX => "Rax",
            Register.CL or Register.CH or Register.CX or Register.ECX or Register.RCX => "Rcx",
            Register.DL or Register.DH or Register.DX or Register.EDX or Register.RDX => "Rdx",
            Register.BL or Register.BH or Register.BX or Register.EBX or Register.RBX => "Rbx",
            Register.SPL or Register.SP or Register.ESP or Register.RSP => "Rsp",
            Register.BPL or Register.BP or Register.EBP or Register.RBP => "Rbp",
            Register.SIL or Register.SI or Register.ESI or Register.RSI => "Rsi",
            Register.DIL or Register.DI or Register.EDI or Register.RDI => "Rdi",
            Register.R8 or Register.R8D or Register.R8W or Register.R8L => "R8",
            Register.R9 or Register.R9D or Register.R9W or Register.R9L => "R9",
            Register.R10 or Register.R10D or Register.R10W or Register.R10L => "R10",
            Register.R11 or Register.R11D or Register.R11W or Register.R11L => "R11",
            Register.R12 or Register.R12D or Register.R12W or Register.R12L => "R12",
            Register.R13 or Register.R13D or Register.R13W or Register.R13L => "R13",
            Register.R14 or Register.R14D or Register.R14W or Register.R14L => "R14",
            Register.R15 or Register.R15D or Register.R15W or Register.R15L => "R15",
            Register.RIP or Register.EIP => "Rip",
            _ => "Rax",
        };
    }

    private static int GetOperandSize(Instruction Instr, int OpIdx)
    {
        var Kind = Instr.GetOpKind(OpIdx);
        if (Kind == OpKind.Register)
        {
            var Reg = Instr.GetOpRegister(OpIdx);
            if (Reg is >= Register.AL and <= Register.R15L)
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

    private static readonly HashSet<string> UnsafePInvokes = new(StringComparer.OrdinalIgnoreCase)
    {
        "RtlCaptureContext",
        "RtlLookupFunctionEntry",
        "RtlVirtualUnwind",
        "RtlCaptureStackBackTrace",
        "UnhandledExceptionFilter",
        "_set_invalid_parameter_handler",
        "__setusermatherr",
        "_set_new_handler",
        "set_terminate",
        "_seh_filter_exe",
        "_set_abort_behavior",
        "signal",
        "_configure_narrow_argv",
        "_initialize_narrow_environment",
        "_get_narrow_winmain_command_line",
        "_set_app_type",
        "_register_thread_local_exe_atexit_callback",
        "VirtualProtectFromApp",
        "VirtualAllocFromApp",
    };

    private static bool IsUnsafePInvoke(string FuncName) => UnsafePInvokes.Contains(FuncName);

    private static string ToPascalCase(string Input)
    {
        var Sb = new StringBuilder();
        var CapNext = true;
        foreach (var Ch in Input)
        {
            if (Ch is '_' or '-' or '.')
            {
                CapNext = true;
                continue;
            }

            Sb.Append(CapNext ? char.ToUpperInvariant(Ch) : Ch);
            CapNext = false;
        }

        return Sb.ToString();
    }

    private static bool IsValidExportName(string Name)
    {
        foreach (var Ch in Name)
        {
            if (!char.IsLetterOrDigit(Ch) && Ch is not '_')
            {
                return false;
            }
        }

        return true;
    }

    private sealed record ExportEntry(string Name, uint Rva);

    private static Dictionary<ulong, string> BuildIatMap(PEReader PeReader, PEHeaders Headers, List<ImportEntry> Imports, ulong ImageBase)
    {
        var Map = new Dictionary<ulong, string>();
        var IatDir = Headers.PEHeader?.ImportAddressTableDirectory;
        if (IatDir is not { Size: > 0 })
        {
            return Map;
        }

        try
        {
            var ImportDir = Headers.PEHeader?.ImportTableDirectory;
            if (ImportDir is not { Size: > 0 })
            {
                return Map;
            }

            var SectionData = PeReader.GetSectionData(ImportDir.Value.RelativeVirtualAddress);
            var Reader = SectionData.GetReader();
            for (var ImportIdx = 0; Reader.RemainingBytes >= 20 && ImportIdx < Imports.Count; ImportIdx++)
            {
                Reader.ReadInt32();
                Reader.ReadUInt32();
                Reader.ReadUInt32();
                var NameRva = Reader.ReadInt32();
                var IatRva = Reader.ReadInt32();

                if (NameRva == 0)
                {
                    break;
                }

                if (IatRva > 0 && ImportIdx < Imports.Count)
                {
                    var FuncIdx = 0;
                    var IatData = PeReader.GetSectionData(IatRva);
                    var IatReader = IatData.GetReader();
                    while (IatReader.RemainingBytes >= 8)
                    {
                        var Entry = IatReader.ReadUInt64();
                        if (Entry == 0)
                        {
                            break;
                        }

                        var IatAddr = ImageBase + (ulong)IatRva + (ulong)(FuncIdx * 8);
                        if (FuncIdx < Imports[ImportIdx].Functions.Count)
                        {
                            var FuncName = Imports[ImportIdx].Functions[FuncIdx];
                            Map[IatAddr] = FuncName;
                        }

                        FuncIdx++;
                    }
                }
            }
        }
        catch
        {
        }

        return Map;
    }

    private sealed record ImportEntry(string DllName, List<string> Functions);
}
