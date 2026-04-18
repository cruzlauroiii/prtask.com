using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";

var Zip = ZipFile.OpenRead(ApkPath);
var ClassesDex = Zip.GetEntry("classes.dex");
var Ms = new MemoryStream();
var Es = ClassesDex.Open(); Es.CopyTo(Ms); Es.Dispose();
var Data = Ms.ToArray();

var StringIdsSize = R32(Data, 56);
var StringIdsOff = R32(Data, 60);
var TypeIdsSize = R32(Data, 64);
var TypeIdsOff = R32(Data, 68);
var FieldIdsSize = R32(Data, 80);
var FieldIdsOff = R32(Data, 84);
var MethodIdsSize = R32(Data, 88);
var MethodIdsOff = R32(Data, 92);
var ClassDefsSize = R32(Data, 96);
var ClassDefsOff = R32(Data, 100);

var Strings = new string[StringIdsSize];
for (var I = 0; I < StringIdsSize; I++)
{
    var Off = R32(Data, StringIdsOff + (I * 4));
    Strings[I] = ReadMutf8(Data, Off);
}

var TypeNames = new string[TypeIdsSize];
for (var I = 0; I < TypeIdsSize; I++)
{
    var DescIdx = R32(Data, TypeIdsOff + (I * 4));
    TypeNames[I] = DescIdx < Strings.Length ? Strings[DescIdx] : "?";
}

var FieldIds = new (int ClassIdx, int TypeIdx, int NameIdx)[FieldIdsSize];
for (var I = 0; I < FieldIdsSize; I++)
{
    var Base = FieldIdsOff + (I * 8);
    FieldIds[I] = (R16(Data, Base), R16(Data, Base + 2), R32(Data, Base + 4));
}

var MethodIds = new (int ClassIdx, int ProtoIdx, int NameIdx)[MethodIdsSize];
for (var I = 0; I < MethodIdsSize; I++)
{
    var Base = MethodIdsOff + (I * 8);
    MethodIds[I] = (R16(Data, Base), R16(Data, Base + 2), R32(Data, Base + 4));
}

// Find DecryptString class and dump EVERYTHING
for (var I = 0; I < ClassDefsSize; I++)
{
    var Base = ClassDefsOff + (I * 32);
    var ClassIdx = R32(Data, Base);
    if (ClassIdx >= TypeNames.Length) continue;
    var ClassName = TypeNames[ClassIdx];
    if (!ClassName.Contains("decryptstringmanager")) continue;

    Console.WriteLine($"Class: {ClassName}");

    // Static values
    var StaticValuesOff = R32(Data, Base + 28);
    Console.WriteLine($"  Static values offset: {StaticValuesOff}");

    var ClassDataOff = R32(Data, Base + 24);
    if (ClassDataOff <= 0) continue;

    var Pos = ClassDataOff;
    var StaticFieldsSize = ReadUleb128(Data, ref Pos);
    var InstanceFieldsSize = ReadUleb128(Data, ref Pos);
    var DirectMethodsSize = ReadUleb128(Data, ref Pos);
    var VirtualMethodsSize = ReadUleb128(Data, ref Pos);

    Console.WriteLine($"  Static fields: {StaticFieldsSize}");

    // Dump static fields
    var FIdx = 0;
    for (var J = 0; J < StaticFieldsSize; J++)
    {
        FIdx += ReadUleb128(Data, ref Pos);
        var FAcc = ReadUleb128(Data, ref Pos);
        if (FIdx < FieldIds.Length)
        {
            var FName = FieldIds[FIdx].NameIdx < Strings.Length ? Strings[FieldIds[FIdx].NameIdx] : "?";
            var FType = FieldIds[FIdx].TypeIdx < TypeNames.Length ? TypeNames[FieldIds[FIdx].TypeIdx] : "?";
            Console.WriteLine($"    Field [{FIdx}]: {FType} {FName} (acc=0x{FAcc:X})");
        }
    }

    FIdx = 0;
    for (var J = 0; J < InstanceFieldsSize; J++)
    {
        FIdx += ReadUleb128(Data, ref Pos);
        ReadUleb128(Data, ref Pos);
    }

    // Focus on decipher and decryptString methods only (the ones with real code)
    var MIdx = 0;
    for (var J = 0; J < DirectMethodsSize + VirtualMethodsSize; J++)
    {
        if (J == DirectMethodsSize) MIdx = 0;
        MIdx += ReadUleb128(Data, ref Pos);
        var MAcc = ReadUleb128(Data, ref Pos);
        var CodeOff = ReadUleb128(Data, ref Pos);

        if (MIdx >= MethodIdsSize) continue;
        var MNameIdx = MethodIds[MIdx].NameIdx;
        var MName = MNameIdx < Strings.Length ? Strings[MNameIdx] : "?";

        // Only dump real methods (not 48-insn obfuscation stubs)
        if (CodeOff <= 0 || CodeOff + 16 > Data.Length) continue;
        var InsnsSize = R32(Data, CodeOff + 12);
        if (InsnsSize == 48 || InsnsSize == 26) continue; // skip obfuscation stubs

        var RegsSize = R16(Data, CodeOff);
        var InsSize = R16(Data, CodeOff + 2);
        var OutsSize = R16(Data, CodeOff + 4);

        Console.WriteLine($"\n  Method: {MName} @ {CodeOff} (regs={RegsSize}, ins={InsSize}, outs={OutsSize}, insns={InsnsSize})");

        // Dump raw bytecode as hex for manual analysis
        var InsnsOff = CodeOff + 16;
        Console.Write("    Raw: ");
        for (var K = 0; K < InsnsSize && InsnsOff + ((K + 1) * 2) <= Data.Length; K++)
        {
            Console.Write($"{R16(Data, InsnsOff + (K * 2)):X4} ");
        }
        Console.WriteLine();

        // Full disassembly with field/method resolution
        Console.WriteLine("    Disasm:");
        var BcPos = 0;
        while (BcPos < InsnsSize && InsnsOff + ((BcPos + 1) * 2) <= Data.Length)
        {
            var Unit = R16(Data, InsnsOff + (BcPos * 2));
            var Op = Unit & 0xFF;
            var Desc = DisasmFull(Data, Strings, TypeNames, MethodIds, FieldIds, InsnsOff, BcPos, InsnsSize, MethodIdsSize, FieldIdsSize);
            Console.WriteLine($"      {BcPos:X4}: {Desc}");
            BcPos += GetInsnWidth(Op);
        }
    }

    // Read static initializer values if present
    if (StaticValuesOff > 0 && StaticValuesOff < Data.Length)
    {
        Console.WriteLine($"\n  Encoded static values at {StaticValuesOff}:");
        var SVPos = StaticValuesOff;
        var SVSize = ReadUleb128(Data, ref SVPos);
        Console.WriteLine($"    Count: {SVSize}");
        for (var J = 0; J < SVSize && J < 10; J++)
        {
            var Byte0 = Data[SVPos];
            var ValueType = Byte0 & 0x1F;
            var ValueArg = (Byte0 >> 5) & 0x07;
            SVPos++;
            Console.Write($"    [{J}] type={ValueType} arg={ValueArg} ");

            var ByteCount = ValueArg + 1;
            if (ValueType == 0x17) // STRING
            {
                long StrIdx = 0;
                for (var K = 0; K < ByteCount && SVPos < Data.Length; K++)
                {
                    StrIdx |= (long)Data[SVPos++] << (K * 8);
                }
                Console.WriteLine($"string[{StrIdx}] = \"{(StrIdx < Strings.Length ? Strings[StrIdx] : "?")}\"");
            }
            else
            {
                var Bytes = new byte[ByteCount];
                for (var K = 0; K < ByteCount && SVPos < Data.Length; K++)
                    Bytes[K] = Data[SVPos++];
                Console.WriteLine($"raw={BitConverter.ToString(Bytes)}");
            }
        }
    }
}

static int R16(byte[] D, int Off) => Off + 1 < D.Length ? BitConverter.ToUInt16(D, Off) : 0;
static int R32(byte[] D, int Off) => Off + 3 < D.Length ? BitConverter.ToInt32(D, Off) : 0;
static int ReadUleb128(byte[] D, ref int Pos) { var R = 0; var S = 0; while (Pos < D.Length) { var B = D[Pos++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int Offset) { var Pos = Offset; while (Pos < D.Length && (D[Pos] & 0x80) != 0) Pos++; Pos++; var Sb = new StringBuilder(); while (Pos < D.Length && D[Pos] != 0) { var B = D[Pos]; if ((B & 0x80) == 0) { Sb.Append((char)B); Pos++; } else if ((B & 0xE0) == 0xC0 && Pos + 1 < D.Length) { Sb.Append((char)(((B & 0x1F) << 6) | (D[Pos + 1] & 0x3F))); Pos += 2; } else if ((B & 0xF0) == 0xE0 && Pos + 2 < D.Length) { Sb.Append((char)(((B & 0x0F) << 12) | ((D[Pos + 1] & 0x3F) << 6) | (D[Pos + 2] & 0x3F))); Pos += 3; } else Pos++; } return Sb.ToString(); }

static string DisasmFull(byte[] Data, string[] Strings, string[] TypeNames, (int ClassIdx, int ProtoIdx, int NameIdx)[] MethodIds, (int ClassIdx, int TypeIdx, int NameIdx)[] FieldIds, int InsnsOff, int Pos, int InsnsSize, int MethodIdsSize, int FieldIdsSize)
{
    var Unit = R16(Data, InsnsOff + (Pos * 2));
    var Op = Unit & 0xFF;
    var A = (Unit >> 8) & 0xF;
    var B = (Unit >> 12) & 0xF;
    var AA = (Unit >> 8) & 0xFF;

    switch (Op)
    {
        case 0x00: return "nop";
        case 0x01: return $"move v{A}, v{B}";
        case 0x02: return $"move/from16 v{AA}, v{R16(Data, InsnsOff + ((Pos+1)*2))}";
        case 0x07: return $"move-object v{A}, v{B}";
        case 0x08: return $"move-object/from16 v{AA}, v{R16(Data, InsnsOff + ((Pos+1)*2))}";
        case 0x0A: return $"move-result v{AA}";
        case 0x0B: return $"move-result-wide v{AA}";
        case 0x0C: return $"move-result-object v{AA}";
        case 0x0D: return $"move-exception v{AA}";
        case 0x0E: return "return-void";
        case 0x0F: return $"return v{AA}";
        case 0x10: return $"return-wide v{AA}";
        case 0x11: return $"return-object v{AA}";
        case 0x12: { var Val = (sbyte)((B << 4) >> 4); return $"const/4 v{A}, #{Val}"; }
        case 0x13: { var V = (short)R16(Data, InsnsOff + ((Pos+1)*2)); return $"const/16 v{AA}, #{V}"; }
        case 0x14: { var V = R32(Data, InsnsOff + ((Pos+1)*2)); return $"const v{AA}, #{V}"; }
        case 0x15: { var V = (short)R16(Data, InsnsOff + ((Pos+1)*2)); return $"const/high16 v{AA}, #{V << 16}"; }
        case 0x1A:
        {
            var SIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            var SVal = SIdx < Strings.Length ? Strings[SIdx] : "?";
            return $"const-string v{AA}, [{SIdx}] \"{SVal}\"";
        }
        case 0x1B:
        {
            var SIdx = R32(Data, InsnsOff + ((Pos+1)*2));
            var SVal = SIdx >= 0 && SIdx < Strings.Length ? Strings[SIdx] : "?";
            return $"const-string/jumbo v{AA}, [{SIdx}] \"{SVal}\"";
        }
        case 0x1C:
        {
            var TIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            return $"const-class v{AA}, {(TIdx < TypeNames.Length ? TypeNames[TIdx] : "?")}";
        }
        case 0x21: return $"array-length v{A}, v{B}";
        case 0x22:
        {
            var TIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            return $"new-instance v{AA}, {(TIdx < TypeNames.Length ? TypeNames[TIdx] : "?")}";
        }
        case 0x23:
        {
            var TIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            return $"new-array v{A}, v{B}, {(TIdx < TypeNames.Length ? TypeNames[TIdx] : "?")}";
        }
        case 0x28: { var Off = (sbyte)AA; return $"goto {Pos + Off:X4}"; }
        case 0x29: { var Off = (short)R16(Data, InsnsOff + ((Pos+1)*2)); return $"goto/16 {Pos + Off:X4}"; }
        case 0x2A: return $"packed-switch v{AA}, +{R32(Data, InsnsOff + ((Pos+1)*2))}";
        case >= 0x32 and <= 0x37:
        {
            var Names = new[] { "if-eq", "if-ne", "if-lt", "if-ge", "if-gt", "if-le" };
            var Off = (short)R16(Data, InsnsOff + ((Pos+1)*2));
            return $"{Names[Op-0x32]} v{A}, v{B}, {Pos+Off:X4}";
        }
        case >= 0x38 and <= 0x3D:
        {
            var Names = new[] { "if-eqz", "if-nez", "if-ltz", "if-gez", "if-gtz", "if-lez" };
            var Off = (short)R16(Data, InsnsOff + ((Pos+1)*2));
            return $"{Names[Op-0x38]} v{AA}, {Pos+Off:X4}";
        }
        case 0x44: return $"aget v{AA}, v{R16(Data, InsnsOff+((Pos+1)*2))&0xFF}, v{R16(Data, InsnsOff+((Pos+1)*2))>>8}";
        case 0x46: return $"aget-object v{AA}, ...";
        case 0x4B: return $"aput v{AA}, ...";
        case 0x4D: return $"aput-object v{AA}, ...";
        case 0x4F: return $"aput-byte v{AA}, ...";
        case >= 0x52 and <= 0x5F:
        {
            var FIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            var FDesc = FIdx < FieldIdsSize ? $"{(FieldIds[FIdx].ClassIdx < TypeNames.Length ? TypeNames[FieldIds[FIdx].ClassIdx] : "?")}.{(FieldIds[FIdx].NameIdx < Strings.Length ? Strings[FieldIds[FIdx].NameIdx] : "?")}" : "?";
            var OpNames = new[] { "iget","iget-wide","iget-object","iget-boolean","iget-byte","iget-char","iget-short","iput","iput-wide","iput-object","iput-boolean","iput-byte","iput-char","iput-short" };
            return $"{OpNames[Op-0x52]} v{A}, v{B}, {FDesc}";
        }
        case >= 0x60 and <= 0x6D:
        {
            var FIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            var FDesc = FIdx < FieldIdsSize ? $"{(FieldIds[FIdx].ClassIdx < TypeNames.Length ? TypeNames[FieldIds[FIdx].ClassIdx] : "?")}.{(FieldIds[FIdx].NameIdx < Strings.Length ? Strings[FieldIds[FIdx].NameIdx] : "?")}" : "?";
            var OpNames = new[] { "sget","sget-wide","sget-object","sget-boolean","sget-byte","sget-char","sget-short","sput","sput-wide","sput-object","sput-boolean","sput-byte","sput-char","sput-short" };
            return $"{OpNames[Op-0x60]} v{AA}, {FDesc}";
        }
        case >= 0x6E and <= 0x72:
        {
            var Names = new[] { "invoke-virtual", "invoke-super", "invoke-direct", "invoke-static", "invoke-interface" };
            var MIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            var ArgWord = R16(Data, InsnsOff + ((Pos+2)*2));
            var ArgCount = (Unit >> 12) & 0xF;
            var MDesc = "?";
            if (MIdx < MethodIdsSize)
            {
                var CIdx = MethodIds[MIdx].ClassIdx;
                var NIdx = MethodIds[MIdx].NameIdx;
                MDesc = $"{(CIdx < TypeNames.Length ? TypeNames[CIdx] : "?")}.{(NIdx < Strings.Length ? Strings[NIdx] : "?")}";
            }
            // Decode register arguments
            var Args = new List<string>();
            if (ArgCount >= 1) Args.Add($"v{ArgWord & 0xF}");
            if (ArgCount >= 2) Args.Add($"v{(ArgWord >> 4) & 0xF}");
            if (ArgCount >= 3) Args.Add($"v{(ArgWord >> 8) & 0xF}");
            if (ArgCount >= 4) Args.Add($"v{(ArgWord >> 12) & 0xF}");
            if (ArgCount >= 5) Args.Add($"v{A}");
            return $"{Names[Op-0x6E]} {{{string.Join(", ", Args)}}}, {MDesc}";
        }
        case >= 0x74 and <= 0x78:
        {
            var Names = new[] { "invoke-virtual/range", "invoke-super/range", "invoke-direct/range", "invoke-static/range", "invoke-interface/range" };
            var MIdx = R16(Data, InsnsOff + ((Pos+1)*2));
            var ArgCount = AA;
            var FirstReg = R16(Data, InsnsOff + ((Pos+2)*2));
            var MDesc = "?";
            if (MIdx < MethodIdsSize)
            {
                var CIdx = MethodIds[MIdx].ClassIdx;
                var NIdx = MethodIds[MIdx].NameIdx;
                MDesc = $"{(CIdx < TypeNames.Length ? TypeNames[CIdx] : "?")}.{(NIdx < Strings.Length ? Strings[NIdx] : "?")}";
            }
            return $"{Names[Op-0x74]} {{v{FirstReg}..v{FirstReg+ArgCount-1}}}, {MDesc}";
        }
        case >= 0x90 and <= 0xAF:
        {
            var Ops = new[] { "add-int","sub-int","mul-int","div-int","rem-int","and-int","or-int","xor-int","shl-int","shr-int","ushr-int","add-long","sub-long","mul-long","div-long","rem-long","and-long","or-long","xor-long","shl-long","shr-long","ushr-long","add-float","sub-float","mul-float","div-float","rem-float","add-double","sub-double","mul-double","div-double","rem-double" };
            var Dest = AA;
            var Src1 = R16(Data, InsnsOff + ((Pos+1)*2)) & 0xFF;
            var Src2 = R16(Data, InsnsOff + ((Pos+1)*2)) >> 8;
            return $"{Ops[Op-0x90]} v{Dest}, v{Src1}, v{Src2}";
        }
        case >= 0xB0 and <= 0xCF:
        {
            var OpName = Op switch { 0xB0 => "add-int/2addr", 0xB1 => "sub-int/2addr", 0xB3 => "div-int/2addr", 0xB7 => "xor-int/2addr", _ => $"binop2addr/{Op:X2}" };
            return $"{OpName} v{A}, v{B}";
        }
        case >= 0xD0 and <= 0xD8:
        {
            var Ops = new[] { "add-int/lit16","rsub-int","mul-int/lit16","div-int/lit16","rem-int/lit16","and-int/lit16","or-int/lit16","xor-int/lit16","shl-int/lit16" };
            var Dest = A;
            var Src = B;
            var Lit = (short)R16(Data, InsnsOff + ((Pos+1)*2));
            return $"{Ops[Op-0xD0]} v{Dest}, v{Src}, #{Lit}";
        }
        case >= 0xD9 and <= 0xE2:
        {
            var Ops = new[] { "add-int/lit8","rsub-int/lit8","mul-int/lit8","div-int/lit8","rem-int/lit8","and-int/lit8","or-int/lit8","xor-int/lit8","shl-int/lit8","shr-int/lit8","ushr-int/lit8" };
            var W2 = R16(Data, InsnsOff + ((Pos+1)*2));
            var Dest = AA;
            var Src = W2 & 0xFF;
            var Lit = (sbyte)(W2 >> 8);
            if (Op - 0xD9 < Ops.Length)
                return $"{Ops[Op-0xD9]} v{Dest}, v{Src}, #{Lit}";
            return $"binop/lit8 op={Op:X2} v{Dest}, v{Src}, #{Lit}";
        }
        case >= 0x7B and <= 0x8F:
        {
            var OpName = Op switch { 0x7B => "neg-int", 0x82 => "int-to-char", 0x83 => "int-to-short", 0x84 => "long-to-int", 0x8D => "int-to-byte", _ => $"unop/{Op:X2}" };
            return $"{OpName} v{A}, v{B}";
        }
        default:
            return $"op={Op:X2} raw={Unit:X4}";
    }
}

static int GetInsnWidth(int Op)
{
    switch (Op)
    {
        case 0x00: case 0x01: case 0x02: case 0x03: case 0x04: case 0x05: case 0x06: case 0x07: return Op <= 0x07 && Op >= 0x02 ? 2 : 1;
        case 0x08: case 0x09: return 2;
        case 0x0A: case 0x0B: case 0x0C: case 0x0D: case 0x0E: case 0x0F: case 0x10: case 0x11: return 1;
        case 0x12: return 1; case 0x13: return 2; case 0x14: return 3; case 0x15: return 2;
        case 0x16: return 2; case 0x17: return 3; case 0x18: return 5; case 0x19: return 2;
        case 0x1A: return 2; case 0x1B: return 3; case 0x1C: return 2;
        case 0x1D: case 0x1E: return 1; case 0x1F: return 2; case 0x20: return 2;
        case 0x21: return 1; case 0x22: return 2; case 0x23: return 2;
        case 0x24: case 0x25: return 3; case 0x26: return 3; case 0x27: return 1;
        case 0x28: return 1; case 0x29: return 2; case 0x2A: return 3;
        case 0x2B: case 0x2C: return 3;
        case >= 0x2D and <= 0x31: return 2;
        case >= 0x32 and <= 0x37: return 2;
        case >= 0x38 and <= 0x3D: return 2;
        case >= 0x44 and <= 0x51: return 2;
        case >= 0x52 and <= 0x5F: return 2;
        case >= 0x60 and <= 0x6D: return 2;
        case >= 0x6E and <= 0x72: return 3;
        case >= 0x74 and <= 0x78: return 3;
        case >= 0x7B and <= 0x8F: return 1;
        case >= 0x90 and <= 0xAF: return 2;
        case >= 0xB0 and <= 0xCF: return 1;
        case >= 0xD0 and <= 0xD8: return 2;
        case >= 0xD9 and <= 0xE2: return 2;
        case 0xFA: case 0xFB: case 0xFC: case 0xFD: case 0xFE: case 0xFF: return 4;
        default: return 1;
    }
}
