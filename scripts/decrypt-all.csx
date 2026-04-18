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
var OutputPath = @"C:\work\prtask.com\docs\decryptstring-reversed.md";

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

Console.WriteLine($"Total encrypted string references: {AllEncrypted.Count}");
var Unique = AllEncrypted.Select(E => E.Hex).Distinct().ToList();
Console.WriteLine($"Unique encrypted strings: {Unique.Count}");

// Decrypt all
var Decrypted = new Dictionary<string, string>();
var Failed = new List<string>();
foreach (var Hex in Unique)
{
    if (Hex.Length % 2 != 0 || Hex.Length < 56) { Failed.Add(Hex); continue; }
    try
    {
        var D = Convert.FromHexString(Hex);
        if (D.Length < 28) { Failed.Add(Hex); continue; }
        var Iv = D[..12];
        var CtTag = D[12..];
        var Ct = CtTag[..^16];
        var Tag = CtTag[^16..];
        var P = new byte[Ct.Length];
        new AesGcm(DerivedKey, 16).Decrypt(Iv, Ct, Tag, P);
        Decrypted[Hex] = Encoding.UTF8.GetString(P);
    }
    catch { Failed.Add(Hex); }
}

Console.WriteLine($"Successfully decrypted: {Decrypted.Count}");
Console.WriteLine($"Failed: {Failed.Count}");

// Find API endpoints and interesting strings
var ApiEndpoints = Decrypted.Values.Where(V => V.Contains("http") || V.Contains("://")).Distinct().OrderBy(V => V).ToList();
var PaymentStrings = Decrypted.Values.Where(V => V.Contains("pay", StringComparison.OrdinalIgnoreCase) || V.Contains("merchant", StringComparison.OrdinalIgnoreCase) || V.Contains("transaction", StringComparison.OrdinalIgnoreCase) || V.Contains("gateway", StringComparison.OrdinalIgnoreCase)).Distinct().OrderBy(V => V).ToList();
var KeySecretStrings = Decrypted.Values.Where(V => V.Contains("key", StringComparison.OrdinalIgnoreCase) || V.Contains("secret", StringComparison.OrdinalIgnoreCase) || V.Contains("token", StringComparison.OrdinalIgnoreCase) || V.Contains("auth", StringComparison.OrdinalIgnoreCase)).Distinct().OrderBy(V => V).ToList();

Console.WriteLine($"\nAPI Endpoints found: {ApiEndpoints.Count}");
foreach (var E in ApiEndpoints) Console.WriteLine($"  {E}");

Console.WriteLine($"\nPayment-related strings: {PaymentStrings.Count}");
foreach (var S in PaymentStrings.Take(30)) Console.WriteLine($"  {S}");

Console.WriteLine($"\nKey/Secret/Token strings: {KeySecretStrings.Count}");
foreach (var S in KeySecretStrings.Take(30)) Console.WriteLine($"  {S}");

// Write output
var Sb = new StringBuilder();
Sb.AppendLine("# DecryptString Reverse Engineering Results");
Sb.AppendLine();
Sb.AppendLine("## Algorithm");
Sb.AppendLine();
Sb.AppendLine("- Class: `com.decryptstringmanager.DecryptString`");
Sb.AppendLine("- Encryption: AES-256-GCM (NoPadding)");
Sb.AppendLine("- Key derivation: PBKDF2WithHmacSHA1");
Sb.AppendLine("- Password: `HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg` (static field `secretKey`)");
Sb.AppendLine("- Salt: password bytes (32 bytes)");
Sb.AppendLine("- Iterations: 128");
Sb.AppendLine("- Key length: 256 bits");
Sb.AppendLine("- GCM tag: 128 bits (16 bytes)");
Sb.AppendLine("- IV/nonce: first 12 bytes of ciphertext");
Sb.AppendLine("- Data layout: `[iv:12][ciphertext:N][gcm_tag:16]`");
Sb.AppendLine();
Sb.AppendLine("## Statistics");
Sb.AppendLine();
Sb.AppendLine($"- Total encrypted references: {AllEncrypted.Count}");
Sb.AppendLine($"- Unique encrypted strings: {Unique.Count}");
Sb.AppendLine($"- Successfully decrypted: {Decrypted.Count}");
Sb.AppendLine($"- Failed: {Failed.Count}");
Sb.AppendLine();

Sb.AppendLine("## Hidden API Endpoints");
Sb.AppendLine();
foreach (var E in ApiEndpoints)
{
    Sb.AppendLine($"- `{E}`");
}
Sb.AppendLine();

Sb.AppendLine("## Payment/Transaction Strings");
Sb.AppendLine();
foreach (var S in PaymentStrings)
{
    Sb.AppendLine($"- `{S}`");
}
Sb.AppendLine();

Sb.AppendLine("## Key/Secret/Token/Auth Strings");
Sb.AppendLine();
foreach (var S in KeySecretStrings)
{
    Sb.AppendLine($"- `{S}`");
}
Sb.AppendLine();

Sb.AppendLine("## All Decrypted Strings by Caller");
Sb.AppendLine();

var ByCaller = AllEncrypted
    .Where(E => Decrypted.ContainsKey(E.Hex))
    .GroupBy(E => E.CallerClass)
    .OrderBy(G => G.Key);

foreach (var G in ByCaller)
{
    var ShortClass = G.Key;
    if (ShortClass.StartsWith("L")) ShortClass = ShortClass[1..];
    if (ShortClass.EndsWith(";")) ShortClass = ShortClass[..^1];
    ShortClass = ShortClass.Replace('/', '.');
    Sb.AppendLine($"### `{ShortClass}`");
    Sb.AppendLine();
    foreach (var E in G.Select(E => (E.CallerMethod, Plain: Decrypted[E.Hex])).Distinct())
    {
        Sb.AppendLine($"- `{E.CallerMethod}`: `{E.Plain}`");
    }
    Sb.AppendLine();
}

Sb.AppendLine("## Full Decryption Table");
Sb.AppendLine();
Sb.AppendLine("| Encrypted (first 40) | Decrypted |");
Sb.AppendLine("|---|---|");
foreach (var Kv in Decrypted.OrderBy(K => K.Value))
{
    var Short = Kv.Key.Length > 40 ? Kv.Key.Substring(0, 37) + "..." : Kv.Key;
    Sb.AppendLine($"| `{Short}` | `{Kv.Value.Replace("|", "\\|")}` |");
}

File.WriteAllText(OutputPath, Sb.ToString());
Console.WriteLine($"\nResults written to {OutputPath}");

static int R16(byte[] D, int O) => O + 1 < D.Length ? BitConverter.ToUInt16(D, O) : 0;
static int R32(byte[] D, int O) => O + 3 < D.Length ? BitConverter.ToInt32(D, O) : 0;
static int ReadUleb128(byte[] D, ref int P) { var R = 0; var S = 0; while (P < D.Length) { var B = D[P++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int O) { var P = O; while (P < D.Length && (D[P] & 0x80) != 0) P++; P++; var S = new StringBuilder(); while (P < D.Length && D[P] != 0) { var B = D[P]; if ((B & 0x80) == 0) { S.Append((char)B); P++; } else if ((B & 0xE0) == 0xC0 && P + 1 < D.Length) { S.Append((char)(((B & 0x1F) << 6) | (D[P+1] & 0x3F))); P += 2; } else if ((B & 0xF0) == 0xE0 && P + 2 < D.Length) { S.Append((char)(((B & 0x0F) << 12) | ((D[P+1] & 0x3F) << 6) | (D[P+2] & 0x3F))); P += 3; } else P++; } return S.ToString(); }
static int GIW(int O) { return O switch { 0x00 => 1, >= 0x01 and <= 0x07 => O >= 0x02 ? 2 : 1, 0x08 or 0x09 => 2, >= 0x0A and <= 0x11 => 1, 0x12 => 1, 0x13 => 2, 0x14 => 3, 0x15 => 2, 0x16 => 2, 0x17 => 3, 0x18 => 5, 0x19 => 2, 0x1A => 2, 0x1B => 3, 0x1C => 2, 0x1D or 0x1E => 1, 0x1F => 2, 0x20 => 2, 0x21 => 1, 0x22 => 2, 0x23 => 2, 0x24 or 0x25 => 3, 0x26 => 3, 0x27 => 1, 0x28 => 1, 0x29 => 2, 0x2A => 3, 0x2B or 0x2C => 3, >= 0x2D and <= 0x31 => 2, >= 0x32 and <= 0x3D => 2, >= 0x44 and <= 0x51 => 2, >= 0x52 and <= 0x6D => 2, >= 0x6E and <= 0x72 => 3, >= 0x74 and <= 0x78 => 3, >= 0x7B and <= 0x8F => 1, >= 0x90 and <= 0xAF => 2, >= 0xB0 and <= 0xCF => 1, >= 0xD0 and <= 0xE2 => 2, >= 0xFA => 4, _ => 1 }; }
