using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PB = Encoding.UTF8.GetBytes(Password);
var DerivedKey = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 128, HashAlgorithmName.SHA1, 32);

var ApkPath = @"C:\work\pocketpay-apk\base.apk";

var AllEncrypted = new List<(string DexFile, string CallerClass, string CallerMethod, string Hex)>();

var Zip = ZipFile.OpenRead(ApkPath);
var DexEntries = Zip.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();

foreach (var Entry in DexEntries)
{
    var Ms = new MemoryStream();
    var Es = Entry.Open(); Es.CopyTo(Ms); Es.Dispose();
    var Data = Ms.ToArray();
    if (Data.Length < 112 || Encoding.ASCII.GetString(Data, 0, 3) != "dex") continue;

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
    if (DecryptIdxSet.Count == 0) continue;

    for (var I = 0; I < ClassDefsSize; I++)
    {
        var Base = ClassDefsOff + (I * 32);
        var ClassIdx = R32(Data, Base);
        if (ClassIdx >= TypeNames.Length) continue;
        var ClassName = TypeNames[ClassIdx];
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
            var IS = R32(Data, CO + 12); var IO = CO + 16;
            if (IS == 0 || IO + (IS * 2) > Data.Length) continue;

            var LastStr = "";
            var BP = 0;
            while (BP < IS)
            {
                var U = R16(Data, IO + (BP * 2));
                var O = U & 0xFF;
                if (O == 0x1A) { var SI = R16(Data, IO + ((BP+1)*2)); if (SI < Strings.Length) LastStr = Strings[SI]; }
                else if (O == 0x1B) { var SI = R32(Data, IO + ((BP+1)*2)); if (SI >= 0 && SI < Strings.Length) LastStr = Strings[SI]; }
                else if ((O >= 0x6E && O <= 0x72) || (O >= 0x74 && O <= 0x78)) { var CM = R16(Data, IO + ((BP+1)*2)); if (DecryptIdxSet.Contains(CM) && LastStr.Length > 0) AllEncrypted.Add((Entry.Name, ClassName, CallerMName, LastStr)); }
                BP += GIW(O);
            }
        }
    }
}

var Unique = AllEncrypted.Select(E => E.Hex).Distinct().ToList();

var Failed = new List<string>();
foreach (var Hex in Unique)
{
    var IsValidHex = Hex.All(C => "0123456789abcdefABCDEF".Contains(C));
    if (!IsValidHex) continue;
    if (Hex.Length % 2 != 0 || Hex.Length < 56) continue;
    var Result = TryDecrypt(Hex, DerivedKey);
    if (Result == null) Failed.Add(Hex);
}

Console.WriteLine($"=== {Failed.Count} FAILED STRINGS (full hex) ===");
foreach (var Hex in Failed)
{
    Console.WriteLine($"\nHEX ({Hex.Length} chars = {Hex.Length/2} bytes): {Hex}");
    var Bytes = Convert.FromHexString(Hex);
    Console.WriteLine($"  IV (first 12): {BitConverter.ToString(Bytes[..12])}");
    Console.WriteLine($"  Tag (last 16): {BitConverter.ToString(Bytes[^16..])}");
    Console.WriteLine($"  CT length: {Bytes.Length - 28} bytes");

    var Callers = AllEncrypted.Where(E => E.Hex == Hex).Select(E => $"{E.DexFile} -> {E.CallerClass}.{E.CallerMethod}").Distinct();
    foreach (var C in Callers) Console.WriteLine($"  Caller: {C}");
}

Console.WriteLine("\n=== TRYING ALTERNATE APPROACHES ===");

foreach (var Hex in Failed)
{
    var Bytes = Convert.FromHexString(Hex);
    Console.WriteLine($"\n--- {Hex[..20]}... ({Bytes.Length}B) ---");

    // 1. AES-CBC with PKCS7
    Console.WriteLine("  AES-CBC PKCS7:");
    foreach (var IvLen in new[] { 16 })
    {
        if (Bytes.Length < IvLen + 16) continue;
        try
        {
            var Iv = Bytes[..IvLen];
            var Ct = Bytes[IvLen..];
            using var Aes = System.Security.Cryptography.Aes.Create();
            Aes.Key = DerivedKey;
            Aes.IV = Iv;
            Aes.Mode = CipherMode.CBC;
            Aes.Padding = PaddingMode.PKCS7;
            var Dec = Aes.CreateDecryptor().TransformFinalBlock(Ct, 0, Ct.Length);
            var Txt = Encoding.UTF8.GetString(Dec);
            if (Txt.All(C => !char.IsControl(C) || C == '\n' || C == '\r' || C == '\t'))
                Console.WriteLine($"    SUCCESS (iv={IvLen}): {Txt}");
        }
        catch (Exception Ex) { Console.WriteLine($"    Failed (iv={IvLen}): {Ex.Message.Split('\n')[0]}"); }
    }

    // 2. Try as AES-GCM with 16-byte IV
    Console.WriteLine("  AES-GCM 16-byte IV:");
    if (Bytes.Length >= 48)
    {
        try
        {
            var Iv = Bytes[..16];
            var CtTag = Bytes[16..];
            var Ct = CtTag[..^16];
            var Tag = CtTag[^16..];
            var P = new byte[Ct.Length];
            new AesGcm(DerivedKey, 16).Decrypt(Iv, Ct, Tag, P);
            Console.WriteLine($"    SUCCESS: {Encoding.UTF8.GetString(P)}");
        }
        catch (Exception Ex) { Console.WriteLine($"    Failed: {Ex.Message.Split('\n')[0]}"); }
    }

    // 3. Raw AES-ECB
    Console.WriteLine("  AES-ECB:");
    try
    {
        using var Aes = System.Security.Cryptography.Aes.Create();
        Aes.Key = DerivedKey;
        Aes.Mode = CipherMode.ECB;
        Aes.Padding = PaddingMode.None;
        if (Bytes.Length % 16 == 0)
        {
            var Dec = Aes.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            var Txt = Encoding.UTF8.GetString(Dec);
            if (Txt.All(C => !char.IsControl(C) || C == '\n' || C == '\r' || C == '\t'))
                Console.WriteLine($"    SUCCESS: {Txt}");
            else
                Console.WriteLine($"    Decrypted but has control chars");
        }
        else Console.WriteLine($"    Not block-aligned ({Bytes.Length} % 16 = {Bytes.Length % 16})");
    }
    catch (Exception Ex) { Console.WriteLine($"    Failed: {Ex.Message.Split('\n')[0]}"); }

    // 4. Check if it's a hash (SHA-256 = 32B, SHA-384 = 48B, SHA-1 = 20B)
    var KnownHashSizes = new Dictionary<int, string> { {16,"MD5"}, {20,"SHA-1"}, {28,"SHA-224"}, {32,"SHA-256"}, {48,"SHA-384"}, {64,"SHA-512"} };
    if (KnownHashSizes.TryGetValue(Bytes.Length, out var HashName))
        Console.WriteLine($"  ** Length matches {HashName} hash ({Bytes.Length}B) - could be a hash, not encrypted **");

    // 5. Try other passwords found in DEX
    var AltPasswords = new string[]
    {
        "p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p94012bf9",
        "p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p0775d576",
        "p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pfd0b8aa8",
        "p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pa68c9a50",
    };
    Console.WriteLine("  Alt passwords (AES-GCM, PBKDF2-SHA1-128):");
    foreach (var AltPwd in AltPasswords)
    {
        var AltPB = Encoding.UTF8.GetBytes(AltPwd);
        var AltKey = Rfc2898DeriveBytes.Pbkdf2(AltPB, AltPB, 128, HashAlgorithmName.SHA1, 32);
        var R = TryDecrypt(Hex, AltKey);
        if (R != null) Console.WriteLine($"    SUCCESS with '{AltPwd[..20]}...': {R}");
    }

    // 6. Try raw password bytes as key (no PBKDF2)
    Console.WriteLine("  Raw password as key (no PBKDF2):");
    {
        var RawKey = PB; // 32 bytes exactly
        var R = TryDecrypt(Hex, RawKey);
        if (R != null) Console.WriteLine($"    SUCCESS: {R}");
        else Console.WriteLine($"    Failed");
    }

    // 7. Check entropy
    var Entropy = 0.0;
    var Freq = new int[256];
    foreach (var B in Bytes) Freq[B]++;
    foreach (var F in Freq.Where(F => F > 0))
    {
        var P2 = (double)F / Bytes.Length;
        Entropy -= P2 * Math.Log2(P2);
    }
    Console.WriteLine($"  Entropy: {Entropy:F2} bits/byte (random=8.0, text~4.5)");
}

// Search for other encryption/decryption classes
Console.WriteLine("\n=== SEARCHING FOR OTHER ENCRYPT/DECRYPT CLASSES ===");
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

    var Strings = new string[StringIdsSize];
    for (var I = 0; I < StringIdsSize; I++) Strings[I] = ReadMutf8(Data, R32(Data, StringIdsOff + (I * 4)));
    var TypeNames = new string[TypeIdsSize];
    for (var I = 0; I < TypeIdsSize; I++) { var D = R32(Data, TypeIdsOff + (I * 4)); TypeNames[I] = D < Strings.Length ? Strings[D] : "?"; }

    foreach (var T in TypeNames.Where(T => (T.Contains("ecrypt", StringComparison.OrdinalIgnoreCase) || T.Contains("Cipher", StringComparison.OrdinalIgnoreCase) || T.Contains("Crypto", StringComparison.OrdinalIgnoreCase)) && !T.Contains("javax/") && !T.Contains("java/") && !T.Contains("android/") && !T.Contains("bouncy") && !T.Contains("Bouncy") && !T.Contains("spongy") && !T.Contains("org/bouncycastle")))
        Console.WriteLine($"  {Entry.Name}: {T}");

    // Look for 32-char strings that could be passwords
    foreach (var S in Strings.Where(S => S.Length == 32 && S.All(C => char.IsLetterOrDigit(C)) && S != Password))
        Console.WriteLine($"  {Entry.Name} potential password: {S}");
}

// Check for native .so files
Console.WriteLine("\n=== NATIVE .SO FILES ===");
Zip.Dispose();
Zip = ZipFile.OpenRead(ApkPath);
var SoFiles = Zip.Entries.Where(E => E.Name.EndsWith(".so", StringComparison.OrdinalIgnoreCase)).ToList();
foreach (var S in SoFiles) Console.WriteLine($"  {S.FullName} ({S.Length} bytes)");

Zip.Dispose();

static string TryDecrypt(string Hex, byte[] Key)
{
    try
    {
        if (Hex.Length % 2 != 0 || Hex.Length < 56) return null;
        var D = Convert.FromHexString(Hex);
        if (D.Length < 28) return null;
        var Iv = D[..12];
        var CtTag = D[12..];
        var Ct = CtTag[..^16];
        var Tag = CtTag[^16..];
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
static int GIW(int O) { return O switch { 0x00 => 1, >= 0x01 and <= 0x07 => O >= 0x02 ? 2 : 1, 0x08 or 0x09 => 2, >= 0x0A and <= 0x11 => 1, 0x12 => 1, 0x13 => 2, 0x14 => 3, 0x15 => 2, 0x16 => 2, 0x17 => 3, 0x18 => 5, 0x19 => 2, 0x1A => 2, 0x1B => 3, 0x1C => 2, 0x1D or 0x1E => 1, 0x1F => 2, 0x20 => 2, 0x21 => 1, 0x22 => 2, 0x23 => 2, 0x24 or 0x25 => 3, 0x26 => 3, 0x27 => 1, 0x28 => 1, 0x29 => 2, 0x2A => 3, 0x2B or 0x2C => 3, >= 0x2D and <= 0x31 => 2, >= 0x32 and <= 0x3D => 2, >= 0x44 and <= 0x51 => 2, >= 0x52 and <= 0x6D => 2, >= 0x6E and <= 0x72 => 3, >= 0x74 and <= 0x78 => 3, >= 0x7B and <= 0x8F => 1, >= 0x90 and <= 0xAF => 2, >= 0xB0 and <= 0xCF => 1, >= 0xD0 and <= 0xE2 => 2, >= 0xFA => 4, _ => 1 }; }
