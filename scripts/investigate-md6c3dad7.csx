using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);

// Look at classes7.dex for p89be9433.md6c3dad7 method
var Entry7 = Zip.Entries.First(E => E.Name == "classes7.dex");
var Ms = new MemoryStream();
var Es = Entry7.Open(); Es.CopyTo(Ms); Es.Dispose();
var Data = Ms.ToArray();

var StringIdsSize = R32(Data, 56); var StringIdsOff = R32(Data, 60);
var TypeIdsSize = R32(Data, 64); var TypeIdsOff = R32(Data, 68);
var MethodIdsSize = R32(Data, 88); var MethodIdsOff = R32(Data, 92);

var Strings = new string[StringIdsSize];
for (var I = 0; I < StringIdsSize; I++) Strings[I] = ReadMutf8(Data, R32(Data, StringIdsOff + (I * 4)));
var TypeNames = new string[TypeIdsSize];
for (var I = 0; I < TypeIdsSize; I++) { var D2 = R32(Data, TypeIdsOff + (I * 4)); TypeNames[I] = D2 < Strings.Length ? Strings[D2] : "?"; }
var MIds = new (int C, int P, int N)[MethodIdsSize];
for (var I = 0; I < MethodIdsSize; I++) { var B = MethodIdsOff + (I * 8); MIds[I] = (R16(Data, B), R16(Data, B+2), R32(Data, B+4)); }

// Find md6c3dad7 method
Console.WriteLine("=== LOOKING FOR md6c3dad7 ===");
for (var I = 0; I < MethodIdsSize; I++)
{
    if (MIds[I].N < Strings.Length && Strings[MIds[I].N] == "md6c3dad7")
    {
        var ClassName = MIds[I].C < TypeNames.Length ? TypeNames[MIds[I].C] : "?";
        Console.WriteLine($"  Method[{I}]: {ClassName}->md6c3dad7");
    }
}

// Find p89be9433 class
Console.WriteLine("\n=== LOOKING FOR p89be9433 CLASS ===");
for (var I = 0; I < TypeIdsSize; I++)
{
    if (TypeNames[I].Contains("p89be9433"))
        Console.WriteLine($"  Type[{I}]: {TypeNames[I]}");
}

// Now look at the full <clinit> of pc8fff9db more carefully
// The bytecode shows: const-string v0, "e67fc470..." -> invoke md6c3dad7(v0) -> result to v0 -> ... -> invoke decryptString
// So md6c3dad7 transforms the hex string BEFORE passing to decryptString
// This is probably a deobfuscation/transformation step

// Let me dump the FULL <clinit> bytecode with register tracking
Console.WriteLine("\n=== FULL <clinit> of pc8fff9db with register tracking ===");
var ClassDefsSize = R32(Data, 96); var ClassDefsOff = R32(Data, 100);

for (var I = 0; I < ClassDefsSize; I++)
{
    var Base = ClassDefsOff + (I * 32);
    var ClassIdx = R32(Data, Base);
    if (ClassIdx >= TypeNames.Length) continue;
    var ClassName = TypeNames[ClassIdx];
    if (!ClassName.Contains("pc8fff9db")) continue;

    var ClassDataOff = R32(Data, Base + 24);
    if (ClassDataOff <= 0 || ClassDataOff >= Data.Length) continue;

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

        var RegCount = R16(Data, CO);
        var IS = R32(Data, CO + 12); var IO = CO + 16;
        Console.WriteLine($"  registers: {RegCount}, insns_size: {IS}");

        var BP = 0;
        while (BP < IS)
        {
            var RawWord = R16(Data, IO + (BP * 2));
            var O = RawWord & 0xFF;
            var InsnWidth = GIW(O);

            // Dump raw words
            var RawHex = new StringBuilder();
            for (var K = 0; K < InsnWidth && BP + K < IS; K++)
                RawHex.Append($"{R16(Data, IO + ((BP+K)*2)):X4} ");

            var Desc = "";
            if (O == 0x1A)
            {
                var SI = R16(Data, IO + ((BP+1)*2));
                var Reg = (RawWord >> 8) & 0xFF;
                var Str = SI < Strings.Length ? Strings[SI] : "?";
                var Short = Str.Length > 50 ? Str[..47] + "..." : Str;
                Desc = $"const-string v{Reg}, [{SI}] \"{Short}\"";
            }
            else if (O == 0x1B)
            {
                var SI = R32(Data, IO + ((BP+1)*2));
                var Reg = (RawWord >> 8) & 0xFF;
                var Str = SI >= 0 && SI < Strings.Length ? Strings[SI] : "?";
                var Short = Str.Length > 50 ? Str[..47] + "..." : Str;
                Desc = $"const-string/jumbo v{Reg}, [{SI}] \"{Short}\"";
            }
            else if ((O >= 0x6E && O <= 0x72) || (O >= 0x74 && O <= 0x78))
            {
                var CM = R16(Data, IO + ((BP+1)*2));
                var ArgWord = R16(Data, IO + ((BP+2)*2));
                var MethodName = CM < MethodIdsSize && MIds[CM].N < Strings.Length ? Strings[MIds[CM].N] : "?";
                var MethodClass = CM < MethodIdsSize && MIds[CM].C < TypeNames.Length ? TypeNames[MIds[CM].C] : "?";
                var ShortClass = MethodClass.Length > 30 ? "..." + MethodClass[^27..] : MethodClass;
                Desc = $"invoke {ShortClass}->{MethodName} args={ArgWord:X4}";
            }
            else if (O == 0x0C) Desc = $"move-result-object v{(RawWord >> 8) & 0xF}";
            else if (O == 0x0E) Desc = "return-void";
            else if (O == 0x69) Desc = $"sput-object v{(RawWord >> 8) & 0xF}";
            else if (O == 0x12) Desc = $"const/4 v{(RawWord >> 8) & 0xF}, #{(RawWord >> 12) & 0xF}";
            else if (O == 0x00) Desc = "nop";
            else Desc = $"op=0x{O:X2}";

            Console.WriteLine($"    [{BP:X4}] {RawHex.ToString().TrimEnd()}  {Desc}");
            BP += InsnWidth;
        }
    }
}

// Also check PINUtility clinit more carefully - register analysis for the failed strings
Console.WriteLine("\n=== PINUtility$PINFormat <clinit> - REGISTER ANALYSIS ===");
var Entry2 = Zip.Entries.First(E => E.Name == "classes2.dex");
Ms = new MemoryStream();
Es = Entry2.Open(); Es.CopyTo(Ms); Es.Dispose();
Data = Ms.ToArray();

StringIdsSize = R32(Data, 56); StringIdsOff = R32(Data, 60);
TypeIdsSize = R32(Data, 64); TypeIdsOff = R32(Data, 68);
MethodIdsSize = R32(Data, 88); MethodIdsOff = R32(Data, 92);
ClassDefsSize = R32(Data, 96); ClassDefsOff = R32(Data, 100);

Strings = new string[StringIdsSize];
for (var I2 = 0; I2 < StringIdsSize; I2++) Strings[I2] = ReadMutf8(Data, R32(Data, StringIdsOff + (I2 * 4)));
TypeNames = new string[TypeIdsSize];
for (var I2 = 0; I2 < TypeIdsSize; I2++) { var D2 = R32(Data, TypeIdsOff + (I2 * 4)); TypeNames[I2] = D2 < Strings.Length ? Strings[D2] : "?"; }
MIds = new (int C, int P, int N)[MethodIdsSize];
for (var I2 = 0; I2 < MethodIdsSize; I2++) { var B = MethodIdsOff + (I2 * 8); MIds[I2] = (R16(Data, B), R16(Data, B+2), R32(Data, B+4)); }

var DecryptIdx2 = new HashSet<int>();
for (var I2 = 0; I2 < MethodIdsSize; I2++)
    if (MIds[I2].C < TypeNames.Length && MIds[I2].N < Strings.Length && TypeNames[MIds[I2].C].Contains("decryptstringmanager") && Strings[MIds[I2].N] == "decryptString")
        DecryptIdx2.Add(I2);

for (var I2 = 0; I2 < ClassDefsSize; I2++)
{
    var Base = ClassDefsOff + (I2 * 32);
    var ClassIdx2 = R32(Data, Base);
    if (ClassIdx2 >= TypeNames.Length) continue;
    if (!TypeNames[ClassIdx2].Contains("PINFormat")) continue;

    var ClassDataOff = R32(Data, Base + 24);
    if (ClassDataOff <= 0 || ClassDataOff >= Data.Length) continue;

    var Pos = ClassDataOff;
    var SF2 = ReadUleb128(Data, ref Pos); var IF2 = ReadUleb128(Data, ref Pos);
    var DM2 = ReadUleb128(Data, ref Pos); var VM2 = ReadUleb128(Data, ref Pos);
    var FI2 = 0; for (var J = 0; J < SF2; J++) { FI2 += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }
    FI2 = 0; for (var J = 0; J < IF2; J++) { FI2 += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }

    var MI2 = 0;
    for (var J = 0; J < DM2 + VM2; J++)
    {
        if (J == DM2) MI2 = 0;
        MI2 += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos);
        var CO = ReadUleb128(Data, ref Pos);
        if (CO <= 0 || CO + 16 > Data.Length || MI2 >= MethodIdsSize) continue;
        var MNameIdx = MIds[MI2].N;
        var CallerMName = MNameIdx < Strings.Length ? Strings[MNameIdx] : "?";
        if (CallerMName != "<clinit>") continue;

        var IS = R32(Data, CO + 12); var IO = CO + 16;
        // Only dump around the failed hex strings (offsets 0x90-0x170)
        var BP = 0x90;
        while (BP < Math.Min(IS, 0x170))
        {
            var RawWord = R16(Data, IO + (BP * 2));
            var O2 = RawWord & 0xFF;
            var InsnWidth = GIW(O2);

            var Desc = "";
            if (O2 == 0x1A)
            {
                var SI = R16(Data, IO + ((BP+1)*2));
                var Reg = (RawWord >> 8) & 0xFF;
                var Str = SI < Strings.Length ? Strings[SI] : "?";
                var Short = Str.Length > 50 ? Str[..47] + "..." : Str;
                Desc = $"const-string v{Reg}, \"{Short}\"";
            }
            else if (O2 == 0x1B)
            {
                var SI = R32(Data, IO + ((BP+1)*2));
                var Reg = (RawWord >> 8) & 0xFF;
                var Str = SI >= 0 && SI < Strings.Length ? Strings[SI] : "?";
                var Short = Str.Length > 50 ? Str[..47] + "..." : Str;
                Desc = $"const-string/jumbo v{Reg}, \"{Short}\"";
            }
            else if ((O2 >= 0x6E && O2 <= 0x72) || (O2 >= 0x74 && O2 <= 0x78))
            {
                var CM = R16(Data, IO + ((BP+1)*2));
                var MethodName = CM < MethodIdsSize && MIds[CM].N < Strings.Length ? Strings[MIds[CM].N] : "?";
                var MethodClass = CM < MethodIdsSize && MIds[CM].C < TypeNames.Length ? TypeNames[MIds[CM].C] : "?";
                var IsDecrypt = DecryptIdx2.Contains(CM);
                Desc = $"invoke {MethodClass}->{MethodName}{(IsDecrypt ? " ***DECRYPT***" : "")}";
            }
            else if (O2 == 0x0C) Desc = $"move-result-object v{(RawWord >> 8) & 0xF}";
            else if (O2 == 0x12) Desc = $"const/4 v{(RawWord >> 8) & 0xF}, #{(RawWord >> 12) & 0xF}";
            else Desc = $"op=0x{O2:X2}";

            Console.WriteLine($"    [{BP:X4}] {Desc}");
            BP += InsnWidth;
        }
    }
}

Zip.Dispose();

static int R16(byte[] D, int O) => O + 1 < D.Length ? BitConverter.ToUInt16(D, O) : 0;
static int R32(byte[] D, int O) => O + 3 < D.Length ? BitConverter.ToInt32(D, O) : 0;
static int ReadUleb128(byte[] D, ref int P) { var R = 0; var S = 0; while (P < D.Length) { var B = D[P++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int O) { var P = O; while (P < D.Length && (D[P] & 0x80) != 0) P++; P++; var S = new StringBuilder(); while (P < D.Length && D[P] != 0) { var B = D[P]; if ((B & 0x80) == 0) { S.Append((char)B); P++; } else if ((B & 0xE0) == 0xC0 && P + 1 < D.Length) { S.Append((char)(((B & 0x1F) << 6) | (D[P+1] & 0x3F))); P += 2; } else if ((B & 0xF0) == 0xE0 && P + 2 < D.Length) { S.Append((char)(((B & 0x0F) << 12) | ((D[P+1] & 0x3F) << 6) | (D[P+2] & 0x3F))); P += 3; } else P++; } return S.ToString(); }
static int GIW(int O) { return O switch { 0x00 => 1, >= 0x01 and <= 0x07 => O >= 0x02 ? 2 : 1, 0x08 or 0x09 => 2, >= 0x0A and <= 0x11 => 1, 0x12 => 1, 0x13 => 2, 0x14 => 3, 0x15 => 2, 0x16 => 2, 0x17 => 3, 0x18 => 5, 0x19 => 2, 0x1A => 2, 0x1B => 3, 0x1C => 2, 0x1D or 0x1E => 1, 0x1F => 2, 0x20 => 2, 0x21 => 1, 0x22 => 2, 0x23 => 2, 0x24 or 0x25 => 3, 0x26 => 3, 0x27 => 1, 0x28 => 1, 0x29 => 2, 0x2A => 3, 0x2B or 0x2C => 3, >= 0x2D and <= 0x31 => 2, >= 0x32 and <= 0x3D => 2, >= 0x44 and <= 0x51 => 2, >= 0x52 and <= 0x6D => 2, >= 0x6E and <= 0x72 => 3, >= 0x74 and <= 0x78 => 3, >= 0x7B and <= 0x8F => 1, >= 0x90 and <= 0xAF => 2, >= 0xB0 and <= 0xCF => 1, >= 0xD0 and <= 0xE2 => 2, >= 0xFA => 4, _ => 1 }; }
