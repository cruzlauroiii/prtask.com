using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);

var FailedHexes = new HashSet<string>
{
    "5d18582b553447187058444fd8ca62bca6649e2788fc6ba0380ff0e88cac851c9762b8ce6fa9dc87e0901e227fa07b6323",
    "24fd3ae1580ec59dcfcf89258f0afa068c0ddcb2fb332caae8d298401ee7396c08c01fb46571b2ff3db4eaf4386d1288dd",
    "e67fc470deae63d8551439ea9c08344adcd3920c731248128c0a83d6e65a99740cc438855ddfa52fccf680"
};

// Check DecryptAsset secretKey
Console.WriteLine("=== DecryptAsset secretKey ===");
var ClassesEntry = Zip.Entries.First(E => E.Name == "classes.dex");
var Ms2 = new MemoryStream();
var Es2 = ClassesEntry.Open(); Es2.CopyTo(Ms2); Es2.Dispose();
var Data2 = Ms2.ToArray();

var StringIdsSize2 = R32(Data2, 56); var StringIdsOff2 = R32(Data2, 60);
var Strings2 = new string[StringIdsSize2];
for (var I = 0; I < StringIdsSize2; I++) Strings2[I] = ReadMutf8(Data2, R32(Data2, StringIdsOff2 + (I * 4)));

var TypeIdsSize2 = R32(Data2, 64); var TypeIdsOff2 = R32(Data2, 68);
var TypeNames2 = new string[TypeIdsSize2];
for (var I = 0; I < TypeIdsSize2; I++) { var D = R32(Data2, TypeIdsOff2 + (I * 4)); TypeNames2[I] = D < Strings2.Length ? Strings2[D] : "?"; }

var FieldIdsSize2 = R32(Data2, 80); var FieldIdsOff2 = R32(Data2, 84);
var ClassDefsSize2 = R32(Data2, 96); var ClassDefsOff2 = R32(Data2, 100);

for (var I = 0; I < ClassDefsSize2; I++)
{
    var Base = ClassDefsOff2 + (I * 32);
    var ClassIdx = R32(Data2, Base);
    if (ClassIdx >= TypeNames2.Length) continue;
    if (!TypeNames2[ClassIdx].Contains("decryptassetmanager")) continue;

    Console.WriteLine($"DecryptAsset class def found");
    var ClassDataOff = R32(Data2, Base + 24);
    var StaticValuesOff = R32(Data2, Base + 28);
    Console.WriteLine($"  ClassDataOff: 0x{ClassDataOff:X}, StaticValuesOff: 0x{StaticValuesOff:X}");

    if (StaticValuesOff > 0 && StaticValuesOff < Data2.Length)
    {
        var SVPos = StaticValuesOff;
        var Size = ReadUleb128(Data2, ref SVPos);
        Console.WriteLine($"  Static values count: {Size}");
        for (var J = 0; J < Size && SVPos < Data2.Length; J++)
        {
            var ValType = Data2[SVPos] & 0x1F;
            var ValArg = (Data2[SVPos] >> 5) & 0x07;
            SVPos++;
            var ValSize = ValArg + 1;
            if (ValType == 0x17)
            {
                var StrIdx = 0;
                for (var K = 0; K < ValSize && SVPos + K < Data2.Length; K++)
                    StrIdx |= Data2[SVPos + K] << (K * 8);
                SVPos += ValSize;
                if (StrIdx < Strings2.Length)
                    Console.WriteLine($"  Static value[{J}] = string: '{Strings2[StrIdx]}'");
            }
            else
            {
                Console.WriteLine($"  Static value[{J}] type=0x{ValType:X2} arg={ValArg}");
                SVPos += ValSize;
            }
        }
    }
    else
    {
        Console.WriteLine("  No static values (initialized in <clinit>)");
    }
}

// Now look at the bytecode around the failed invocations
// Focus on classes2.dex for PINUtility and classes7.dex for the obfuscated class
Console.WriteLine("\n=== BYTECODE CONTEXT FOR FAILED CALLS ===");

foreach (var TargetDex in new[] { "classes2.dex", "classes7.dex" })
{
    var Entry = Zip.Entries.FirstOrDefault(E => E.Name == TargetDex);
    if (Entry == null) continue;

    var Ms = new MemoryStream();
    var Es = Entry.Open(); Es.CopyTo(Ms); Es.Dispose();
    var Data = Ms.ToArray();
    if (Data.Length < 112) continue;

    var StringIdsSize = R32(Data, 56); var StringIdsOff = R32(Data, 60);
    var TypeIdsSize = R32(Data, 64); var TypeIdsOff = R32(Data, 68);
    var MethodIdsSize = R32(Data, 88); var MethodIdsOff = R32(Data, 92);
    var ClassDefsSize = R32(Data, 96); var ClassDefsOff = R32(Data, 100);

    var Strings = new string[StringIdsSize];
    for (var I = 0; I < StringIdsSize; I++) Strings[I] = ReadMutf8(Data, R32(Data, StringIdsOff + (I * 4)));
    var TypeNames = new string[TypeIdsSize];
    for (var I = 0; I < TypeIdsSize; I++) { var D = R32(Data, TypeIdsOff + (I * 4)); TypeNames[I] = D < Strings.Length ? Strings[D] : "?"; }
    var MIds = new (int C, int P, int N)[MethodIdsSize];
    for (var I = 0; I < MethodIdsSize; I++) { var B = MethodIdsOff + (I * 8); MIds[I] = (R16(Data, B), R16(Data, B+2), R32(Data, B+4)); }

    var DecryptIdxSet = new HashSet<int>();
    for (var I = 0; I < MethodIdsSize; I++)
        if (MIds[I].C < TypeNames.Length && MIds[I].N < Strings.Length && TypeNames[MIds[I].C].Contains("decryptstringmanager") && Strings[MIds[I].N] == "decryptString")
            DecryptIdxSet.Add(I);

    Console.WriteLine($"\n{TargetDex}: DecryptString method indices: {string.Join(", ", DecryptIdxSet)}");

    for (var I = 0; I < ClassDefsSize; I++)
    {
        var Base = ClassDefsOff + (I * 32);
        var ClassIdx = R32(Data, Base);
        if (ClassIdx >= TypeNames.Length) continue;
        var ClassName = TypeNames[ClassIdx];

        // Only look at PINUtility and the obfuscated class
        if (!ClassName.Contains("PINUtility") && !ClassName.Contains("pc8fff9db")) continue;

        var ClassDataOff = R32(Data, Base + 24);
        if (ClassDataOff <= 0 || ClassDataOff >= Data.Length) continue;

        Console.WriteLine($"\n  Class: {ClassName}");

        var Pos = ClassDataOff;
        var SF = ReadUleb128(Data, ref Pos); var IF = ReadUleb128(Data, ref Pos);
        var DM = ReadUleb128(Data, ref Pos); var VM = ReadUleb128(Data, ref Pos);
        var FI = 0; for (var J = 0; J < SF; J++) { FI += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }
        FI = 0; for (var J = 0; J < IF; J++) { FI += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }

        var MI = 0;
        for (var J = 0; J < DM + VM; J++)
        {
            if (J == DM) MI = 0;
            MI += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos);
            var CO = ReadUleb128(Data, ref Pos);
            if (CO <= 0 || CO + 16 > Data.Length || MI >= MethodIdsSize) continue;
            var MNameIdx = MIds[MI].N;
            var CallerMName = MNameIdx < Strings.Length ? Strings[MNameIdx] : "?";
            if (CallerMName != "<clinit>") continue;

            var IS = R32(Data, CO + 12); var IO = CO + 16;
            if (IS == 0 || IO + (IS * 2) > Data.Length) continue;

            Console.WriteLine($"  Method: {CallerMName} (insns_size={IS})");

            // Dump ALL instructions with strings and invokes
            var BP = 0;
            while (BP < IS)
            {
                var U = R16(Data, IO + (BP * 2));
                var O = U & 0xFF;
                if (O == 0x1A)
                {
                    var SI = R16(Data, IO + ((BP+1)*2));
                    var Reg = (U >> 8) & 0xFF;
                    var Str = SI < Strings.Length ? Strings[SI] : "?";
                    var IsFailedHex = FailedHexes.Contains(Str);
                    var Short = Str.Length > 60 ? Str[..57] + "..." : Str;
                    Console.WriteLine($"    [{BP:X4}] const-string v{Reg}, \"{Short}\" {(IsFailedHex ? " *** FAILED ***" : "")}");
                }
                else if (O == 0x1B)
                {
                    var SI = R32(Data, IO + ((BP+1)*2));
                    var Reg = (U >> 8) & 0xFF;
                    var Str = SI >= 0 && SI < Strings.Length ? Strings[SI] : "?";
                    var IsFailedHex = FailedHexes.Contains(Str);
                    var Short = Str.Length > 60 ? Str[..57] + "..." : Str;
                    Console.WriteLine($"    [{BP:X4}] const-string/jumbo v{Reg}, \"{Short}\" {(IsFailedHex ? " *** FAILED ***" : "")}");
                }
                else if ((O >= 0x6E && O <= 0x72) || (O >= 0x74 && O <= 0x78))
                {
                    var CM = R16(Data, IO + ((BP+1)*2));
                    var MethodName = CM < MethodIdsSize && MIds[CM].N < Strings.Length ? Strings[MIds[CM].N] : "?";
                    var MethodClass = CM < MethodIdsSize && MIds[CM].C < TypeNames.Length ? TypeNames[MIds[CM].C] : "?";
                    var IsDecrypt = DecryptIdxSet.Contains(CM);
                    Console.WriteLine($"    [{BP:X4}] invoke v?, {MethodClass}->{MethodName} {(IsDecrypt ? " *** DECRYPT ***" : "")}");
                }
                else if (O == 0x0C)
                {
                    Console.WriteLine($"    [{BP:X4}] move-result-object v{(U >> 8) & 0xF}");
                }
                BP += GIW(O);
            }
        }
    }
}

Zip.Dispose();

static int R16(byte[] D, int O) => O + 1 < D.Length ? BitConverter.ToUInt16(D, O) : 0;
static int R32(byte[] D, int O) => O + 3 < D.Length ? BitConverter.ToInt32(D, O) : 0;
static int ReadUleb128(byte[] D, ref int P) { var R = 0; var S = 0; while (P < D.Length) { var B = D[P++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int O) { var P = O; while (P < D.Length && (D[P] & 0x80) != 0) P++; P++; var S = new StringBuilder(); while (P < D.Length && D[P] != 0) { var B = D[P]; if ((B & 0x80) == 0) { S.Append((char)B); P++; } else if ((B & 0xE0) == 0xC0 && P + 1 < D.Length) { S.Append((char)(((B & 0x1F) << 6) | (D[P+1] & 0x3F))); P += 2; } else if ((B & 0xF0) == 0xE0 && P + 2 < D.Length) { S.Append((char)(((B & 0x0F) << 12) | ((D[P+1] & 0x3F) << 6) | (D[P+2] & 0x3F))); P += 3; } else P++; } return S.ToString(); }
static int GIW(int O) { return O switch { 0x00 => 1, >= 0x01 and <= 0x07 => O >= 0x02 ? 2 : 1, 0x08 or 0x09 => 2, >= 0x0A and <= 0x11 => 1, 0x12 => 1, 0x13 => 2, 0x14 => 3, 0x15 => 2, 0x16 => 2, 0x17 => 3, 0x18 => 5, 0x19 => 2, 0x1A => 2, 0x1B => 3, 0x1C => 2, 0x1D or 0x1E => 1, 0x1F => 2, 0x20 => 2, 0x21 => 1, 0x22 => 2, 0x23 => 2, 0x24 or 0x25 => 3, 0x26 => 3, 0x27 => 1, 0x28 => 1, 0x29 => 2, 0x2A => 3, 0x2B or 0x2C => 3, >= 0x2D and <= 0x31 => 2, >= 0x32 and <= 0x3D => 2, >= 0x44 and <= 0x51 => 2, >= 0x52 and <= 0x6D => 2, >= 0x6E and <= 0x72 => 3, >= 0x74 and <= 0x78 => 3, >= 0x7B and <= 0x8F => 1, >= 0x90 and <= 0xAF => 2, >= 0xB0 and <= 0xCF => 1, >= 0xD0 and <= 0xE2 => 2, >= 0xFA => 4, _ => 1 }; }
