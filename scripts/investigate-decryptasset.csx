using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);
var DexEntries = Zip.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();

var FailedHexes = new string[]
{
    "5d18582b553447187058444fd8ca62bca6649e2788fc6ba0380ff0e88cac851c9762b8ce6fa9dc87e0901e227fa07b6323",
    "24fd3ae1580ec59dcfcf89258f0afa068c0ddcb2fb332caae8d298401ee7396c08c01fb46571b2ff3db4eaf4386d1288dd",
    "e67fc470deae63d8551439ea9c08344adcd3920c731248128c0a83d6e65a99740cc438855ddfa52fccf680"
};

// Search for DecryptAsset class and its secretKey field
Console.WriteLine("=== SEARCHING FOR DecryptAsset FIELDS ===");
foreach (var Entry in DexEntries)
{
    var Ms = new MemoryStream();
    var Es = Entry.Open(); Es.CopyTo(Ms); Es.Dispose();
    var Data = Ms.ToArray();
    if (Data.Length < 112 || Encoding.ASCII.GetString(Data, 0, 3) != "dex") continue;

    var StringIdsSize = R32(Data, 56); var StringIdsOff = R32(Data, 60);
    var TypeIdsSize = R32(Data, 64); var TypeIdsOff = R32(Data, 68);

    var Strings = new string[StringIdsSize];
    for (var I = 0; I < StringIdsSize; I++) Strings[I] = ReadMutf8(Data, R32(Data, StringIdsOff + (I * 4)));
    var TypeNames = new string[TypeIdsSize];
    for (var I = 0; I < TypeIdsSize; I++) { var D = R32(Data, TypeIdsOff + (I * 4)); TypeNames[I] = D < Strings.Length ? Strings[D] : "?"; }

    // Find DecryptAsset or DecryptString type indices
    for (var I = 0; I < TypeIdsSize; I++)
    {
        if (TypeNames[I].Contains("decryptstringmanager") || TypeNames[I].Contains("decryptassetmanager"))
        {
            Console.WriteLine($"  {Entry.Name}: type[{I}] = {TypeNames[I]}");
        }
    }

    // Find secretKey strings
    foreach (var S in Strings.Where(S => S == "secretKey" || S == "secretkey" || S == "SecretKey" || S == "SECRET_KEY"))
        Console.WriteLine($"  {Entry.Name}: found string '{S}'");

    // Find ALL 32-char alphanumeric strings that look like they could be crypto keys
    foreach (var S in Strings.Where(S => S.Length == 32 && S.All(C => char.IsLetterOrDigit(C)) && S.Any(C => char.IsUpper(C)) && S.Any(C => char.IsLower(C)) && S.Any(C => char.IsDigit(C))))
        Console.WriteLine($"  {Entry.Name}: potential key: {S}");
}

// The 49-byte strings are odd. 49 = 12 (IV) + 21 (CT) + 16 (tag). 21 bytes CT = 21 chars plaintext.
// The 43-byte string: 43 = 12 (IV) + 15 (CT) + 16 (tag). 15 bytes CT = 15 chars plaintext.
// These are valid AES-GCM sizes. The issue must be the key.

// Try: maybe the hex is 98 chars but the REAL string in the DEX pool has 97 chars (odd)
// and we added a trailing char. Let's try trimming last byte.
Console.WriteLine("\n=== TRY TRIMMING / PADDING HEX ===");
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PB = Encoding.UTF8.GetBytes(Password);
var DerivedKey = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 128, HashAlgorithmName.SHA1, 32);

foreach (var Hex in FailedHexes)
{
    Console.WriteLine($"\n{Hex[..20]}... ({Hex.Length} chars)");
    // Try removing each single char from start/end
    for (var Trim = 1; Trim <= 2; Trim++)
    {
        var TrimFront = Hex[Trim..];
        if (TrimFront.Length % 2 == 0 && TrimFront.Length >= 56)
        {
            var R = TryDecrypt(TrimFront, DerivedKey);
            if (R != null) Console.WriteLine($"  TRIM FRONT {Trim}: {R}");
        }
        var TrimBack = Hex[..^Trim];
        if (TrimBack.Length % 2 == 0 && TrimBack.Length >= 56)
        {
            var R = TryDecrypt(TrimBack, DerivedKey);
            if (R != null) Console.WriteLine($"  TRIM BACK {Trim}: {R}");
        }
    }
    // Try prepending 0
    var Padded = "0" + Hex;
    if (Padded.Length % 2 == 0 && Padded.Length >= 56)
    {
        var R = TryDecrypt(Padded, DerivedKey);
        if (R != null) Console.WriteLine($"  PREPEND 0: {R}");
    }

    // The hex is odd length (98 chars for 49B is even... wait 98 is even. 86 is even too.
    // So these ARE valid hex. But they fail AES-GCM with the standard key.
    // Could be a DIFFERENT DecryptString class instance with different secretKey in a different DEX.
}

// Find which DEX file contains the DecryptString class that classes2 and classes7 reference
Console.WriteLine("\n=== LOOKING FOR secretKey VALUE IN DEX CLASS DATA ===");
Zip.Dispose();
Zip = ZipFile.OpenRead(ApkPath);
DexEntries = Zip.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();

foreach (var Entry in DexEntries)
{
    var Ms = new MemoryStream();
    var Es = Entry.Open(); Es.CopyTo(Ms); Es.Dispose();
    var Data = Ms.ToArray();
    if (Data.Length < 112 || Encoding.ASCII.GetString(Data, 0, 3) != "dex") continue;

    var StringIdsSize = R32(Data, 56); var StringIdsOff = R32(Data, 60);
    var TypeIdsSize = R32(Data, 64); var TypeIdsOff = R32(Data, 68);
    var FieldIdsSize = R32(Data, 80); var FieldIdsOff = R32(Data, 84);
    var ClassDefsSize = R32(Data, 96); var ClassDefsOff = R32(Data, 100);

    var Strings = new string[StringIdsSize];
    for (var I = 0; I < StringIdsSize; I++) Strings[I] = ReadMutf8(Data, R32(Data, StringIdsOff + (I * 4)));
    var TypeNames = new string[TypeIdsSize];
    for (var I = 0; I < TypeIdsSize; I++) { var D = R32(Data, TypeIdsOff + (I * 4)); TypeNames[I] = D < Strings.Length ? Strings[D] : "?"; }

    // Find DecryptString class definitions (not just references)
    for (var I = 0; I < ClassDefsSize; I++)
    {
        var Base = ClassDefsOff + (I * 32);
        var ClassIdx = R32(Data, Base);
        if (ClassIdx >= TypeNames.Length) continue;
        var ClassName = TypeNames[ClassIdx];
        if (!ClassName.Contains("decryptstringmanager") && !ClassName.Contains("decryptassetmanager")) continue;

        Console.WriteLine($"\n  {Entry.Name}: CLASS DEF {ClassName}");
        var ClassDataOff = R32(Data, Base + 24);
        if (ClassDataOff <= 0 || ClassDataOff >= Data.Length) { Console.WriteLine("    No class data"); continue; }

        var Pos = ClassDataOff;
        var SF = ReadUleb128(Data, ref Pos); var IF = ReadUleb128(Data, ref Pos);
        var DM = ReadUleb128(Data, ref Pos); var VM = ReadUleb128(Data, ref Pos);
        Console.WriteLine($"    Static fields: {SF}, Instance fields: {IF}, Direct methods: {DM}, Virtual methods: {VM}");

        // Read static field indices
        var FI = 0;
        for (var J = 0; J < SF; J++)
        {
            FI += ReadUleb128(Data, ref Pos);
            var Access = ReadUleb128(Data, ref Pos);
            if (FI < FieldIdsSize)
            {
                var FB = FieldIdsOff + (FI * 8);
                var FNameIdx = R32(Data, FB + 4);
                var FName = FNameIdx < Strings.Length ? Strings[FNameIdx] : "?";
                Console.WriteLine($"    Static field[{FI}]: {FName} (access=0x{Access:X})");
            }
        }

        // Check static values
        var StaticValuesOff = R32(Data, Base + 28);
        if (StaticValuesOff > 0 && StaticValuesOff < Data.Length)
        {
            Console.WriteLine($"    Static values at offset 0x{StaticValuesOff:X}");
            var SVPos = StaticValuesOff;
            var Size = ReadUleb128(Data, ref SVPos);
            Console.WriteLine($"    Static values count: {Size}");
            for (var J = 0; J < Size && SVPos < Data.Length; J++)
            {
                var ValType = Data[SVPos] & 0x1F;
                var ValArg = (Data[SVPos] >> 5) & 0x07;
                SVPos++;
                var ValSize = ValArg + 1;
                if (ValType == 0x17) // string
                {
                    var StrIdx = 0;
                    for (var K = 0; K < ValSize && SVPos + K < Data.Length; K++)
                        StrIdx |= Data[SVPos + K] << (K * 8);
                    SVPos += ValSize;
                    if (StrIdx < Strings.Length)
                        Console.WriteLine($"    Static value[{J}] = string: '{Strings[StrIdx]}'");
                }
                else
                {
                    Console.WriteLine($"    Static value[{J}] type=0x{ValType:X2} arg={ValArg} size={ValSize}");
                    SVPos += ValSize;
                }
            }
        }
    }
}

Zip.Dispose();

static string TryDecrypt(string Hex, byte[] Key)
{
    try
    {
        if (Hex.Length % 2 != 0 || Hex.Length < 56) return null;
        var D = Convert.FromHexString(Hex);
        if (D.Length < 28) return null;
        var Iv = D[..12]; var CtTag = D[12..]; var Ct = CtTag[..^16]; var Tag = CtTag[^16..];
        var P = new byte[Ct.Length];
        new AesGcm(Key, 16).Decrypt(Iv, Ct, Tag, P);
        var Result = Encoding.UTF8.GetString(P);
        if (Result.Any(C => char.IsControl(C) && C != '\n' && C != '\r' && C != '\t')) return null;
        return Result;
    }
    catch { return null; }
}

static int R16(byte[] D, int O) => O + 1 < D.Length ? BitConverter.ToUInt16(D, O) : 0;
static int R32(byte[] D, int O) => O + 3 < D.Length ? BitConverter.ToInt32(D, O) : 0;
static int ReadUleb128(byte[] D, ref int P) { var R = 0; var S = 0; while (P < D.Length) { var B = D[P++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int O) { var P = O; while (P < D.Length && (D[P] & 0x80) != 0) P++; P++; var S = new StringBuilder(); while (P < D.Length && D[P] != 0) { var B = D[P]; if ((B & 0x80) == 0) { S.Append((char)B); P++; } else if ((B & 0xE0) == 0xC0 && P + 1 < D.Length) { S.Append((char)(((B & 0x1F) << 6) | (D[P+1] & 0x3F))); P += 2; } else if ((B & 0xF0) == 0xE0 && P + 2 < D.Length) { S.Append((char)(((B & 0x0F) << 12) | ((D[P+1] & 0x3F) << 6) | (D[P+2] & 0x3F))); P += 3; } else P++; } return S.ToString(); }
