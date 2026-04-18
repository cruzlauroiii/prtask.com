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

var AltKeys = new Dictionary<string, byte[]>
{
    ["pbkdf2-128-salt=pwd"] = DerivedKey,
    ["pbkdf2-128-salt=empty"] = Rfc2898DeriveBytes.Pbkdf2(PB, Array.Empty<byte>(), 128, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-128-salt=pwd16"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB[..16], 128, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-1-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 1, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-64-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 64, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-256-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 256, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-512-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 512, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-1000-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 1000, HashAlgorithmName.SHA1, 32),
    ["pbkdf2-128-sha256-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 128, HashAlgorithmName.SHA256, 32),
    ["pbkdf2-1000-sha256-salt=pwd"] = Rfc2898DeriveBytes.Pbkdf2(PB, PB, 1000, HashAlgorithmName.SHA256, 32),
    ["sha256-direct"] = SHA256.HashData(PB),
    ["pwd-direct"] = PB,
};

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var OutputPath = @"C:\work\prtask.com\docs\pocketpay-decrypted-complete.md";

var PriorityPatterns = new[] { "mobilecashier", "toph", "payment", "auth", "token", "com/d/c" };

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

var Decrypted = new Dictionary<string, (string Plain, string Method)>();
var RawHexConstants = new Dictionary<string, string>();
var StillFailed = new List<string>();

foreach (var Hex in Unique)
{
    if (TryStandardDecrypt(Hex, out var Plain))
    {
        Decrypted[Hex] = (Plain, "pbkdf2-128-salt=pwd,iv=12");
        continue;
    }

    if (Hex.Length % 2 != 0)
    {
        StillFailed.Add(Hex);
        continue;
    }

    byte[] D;
    try { D = Convert.FromHexString(Hex); } catch { StillFailed.Add(Hex); continue; }

    if (IsLikelyRawConstant(D, Hex))
    {
        RawHexConstants[Hex] = ClassifyRawHex(D, Hex);
        continue;
    }

    var Found = false;
    foreach (var IvLen in new[] { 12, 16 })
    {
        if (Found) break;
        if (D.Length < IvLen + 17) continue;
        var Iv = D[..IvLen];
        var Rest = D[IvLen..];
        var Tag = Rest[^16..];
        var Ct = Rest[..^16];

        foreach (var Kv in AltKeys)
        {
            if (Kv.Value.Length != 32 && Kv.Value.Length != 16 && Kv.Value.Length != 24) continue;
            try
            {
                var P = new byte[Ct.Length];
                new AesGcm(Kv.Value, 16).Decrypt(Iv[..12], Ct, Tag, P);
                var S = Encoding.UTF8.GetString(P);
                if (IsValidPlaintext(S))
                {
                    Decrypted[Hex] = (S, $"{Kv.Key},iv={IvLen}");
                    Found = true;
                    break;
                }
            }
            catch {}
        }
    }

    if (!Found)
    {
        if (D.Length >= 28)
        {
            foreach (var Kv in AltKeys)
            {
                if (Kv.Value.Length < 16) continue;
                var Tag = D[^16..];
                var Ct = D[..^16];
                try
                {
                    var P = new byte[Ct.Length];
                    new AesGcm(Kv.Value, 16).Decrypt(PB[..12], Ct, Tag, P);
                    var S = Encoding.UTF8.GetString(P);
                    if (IsValidPlaintext(S))
                    {
                        Decrypted[Hex] = (S, $"{Kv.Key},iv=pwd12");
                        Found = true;
                        break;
                    }
                }
                catch {}
            }
        }
    }

    if (!Found)
    {
        if (TryAesCbc(D, out var CbcPlain, out var CbcMethod))
        {
            Decrypted[Hex] = (CbcPlain, CbcMethod);
            Found = true;
        }
    }

    if (!Found) StillFailed.Add(Hex);
}

Console.WriteLine($"\nDecrypted: {Decrypted.Count}");
Console.WriteLine($"Raw hex constants: {RawHexConstants.Count}");
Console.WriteLine($"Still failed: {StillFailed.Count}");

var PriorityClasses = AllEncrypted
    .Where(E => PriorityPatterns.Any(P => E.CallerClass.Contains(P, StringComparison.OrdinalIgnoreCase)))
    .ToList();

Console.WriteLine($"\nPriority class references: {PriorityClasses.Count}");
var PriorityFailed = PriorityClasses.Where(E => StillFailed.Contains(E.Hex)).ToList();
Console.WriteLine($"Priority class FAILED: {PriorityFailed.Count}");
foreach (var F in PriorityFailed.Select(E => (E.CallerClass, E.Hex)).Distinct().Take(20))
    Console.WriteLine($"  {F.CallerClass}: {F.Hex.Substring(0, Math.Min(60, F.Hex.Length))}...");

var Sb = new StringBuilder();
Sb.AppendLine("# PocketPay Decrypted Strings - Complete");
Sb.AppendLine();
Sb.AppendLine("## Statistics");
Sb.AppendLine();
Sb.AppendLine($"- Total encrypted references: {AllEncrypted.Count}");
Sb.AppendLine($"- Unique encrypted strings: {Unique.Count}");
Sb.AppendLine($"- Successfully decrypted: {Decrypted.Count}");
Sb.AppendLine($"- Raw hex constants (not encrypted): {RawHexConstants.Count}");
Sb.AppendLine($"- Still failed: {StillFailed.Count}");
Sb.AppendLine();

var ApiEndpoints = Decrypted.Values.Where(V => V.Plain.Contains("http") || V.Plain.Contains("://") || V.Plain.Contains(".com") || V.Plain.Contains(".ph")).Select(V => V.Plain).Distinct().OrderBy(V => V).ToList();
if (ApiEndpoints.Count > 0)
{
    Sb.AppendLine("## API Endpoints & URLs");
    Sb.AppendLine();
    foreach (var E in ApiEndpoints) Sb.AppendLine($"- `{E}`");
    Sb.AppendLine();
}

var PaymentStrings = Decrypted.Values.Where(V =>
    V.Plain.Contains("pay", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("merchant", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("transaction", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("gateway", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("amount", StringComparison.OrdinalIgnoreCase))
    .Select(V => V.Plain).Distinct().OrderBy(V => V).ToList();
if (PaymentStrings.Count > 0)
{
    Sb.AppendLine("## Payment/Transaction Strings");
    Sb.AppendLine();
    foreach (var S in PaymentStrings) Sb.AppendLine($"- `{S}`");
    Sb.AppendLine();
}

var KeyStrings = Decrypted.Values.Where(V =>
    V.Plain.Contains("key", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("secret", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("token", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("auth", StringComparison.OrdinalIgnoreCase) ||
    V.Plain.Contains("api", StringComparison.OrdinalIgnoreCase))
    .Select(V => V.Plain).Distinct().OrderBy(V => V).ToList();
if (KeyStrings.Count > 0)
{
    Sb.AppendLine("## Key/Secret/Token/Auth/API Strings");
    Sb.AppendLine();
    foreach (var S in KeyStrings) Sb.AppendLine($"- `{S}`");
    Sb.AppendLine();
}

Sb.AppendLine("## Priority Classes (mobilecashier, toph, payment, auth, token, com.d.c)");
Sb.AppendLine();
var PriorityDecrypted = AllEncrypted
    .Where(E => PriorityPatterns.Any(P => E.CallerClass.Contains(P, StringComparison.OrdinalIgnoreCase)) && Decrypted.ContainsKey(E.Hex))
    .GroupBy(E => E.CallerClass)
    .OrderBy(G => G.Key);
foreach (var G in PriorityDecrypted)
{
    var ShortClass = G.Key.TrimStart('L').TrimEnd(';').Replace('/', '.');
    Sb.AppendLine($"### `{ShortClass}`");
    Sb.AppendLine();
    foreach (var E in G.Select(E => (E.CallerMethod, Decrypted[E.Hex].Plain)).Distinct())
        Sb.AppendLine($"- `{E.CallerMethod}`: `{E.Plain}`");
    Sb.AppendLine();
}

Sb.AppendLine("## All Decrypted Strings by Class");
Sb.AppendLine();
var ByCaller = AllEncrypted
    .Where(E => Decrypted.ContainsKey(E.Hex))
    .GroupBy(E => E.CallerClass)
    .OrderBy(G => G.Key);
foreach (var G in ByCaller)
{
    var ShortClass = G.Key.TrimStart('L').TrimEnd(';').Replace('/', '.');
    Sb.AppendLine($"### `{ShortClass}`");
    Sb.AppendLine();
    foreach (var E in G.Select(E => (E.CallerMethod, Decrypted[E.Hex].Plain, Decrypted[E.Hex].Method)).Distinct())
        Sb.AppendLine($"- `{E.CallerMethod}`: `{E.Plain}` *({E.Method})*");
    Sb.AppendLine();
}

if (RawHexConstants.Count > 0)
{
    Sb.AppendLine("## Raw Hex Constants (Not Encrypted)");
    Sb.AppendLine();
    Sb.AppendLine("| Hex | Classification |");
    Sb.AppendLine("|---|---|");
    foreach (var Kv in RawHexConstants.OrderBy(K => K.Value))
    {
        var Short = Kv.Key.Length > 40 ? Kv.Key.Substring(0, 37) + "..." : Kv.Key;
        Sb.AppendLine($"| `{Short}` | {Kv.Value} |");
    }
    Sb.AppendLine();
}

if (StillFailed.Count > 0)
{
    Sb.AppendLine("## Still Failed");
    Sb.AppendLine();
    Sb.AppendLine($"Total: {StillFailed.Count}");
    Sb.AppendLine();
    var FailedByClass = AllEncrypted
        .Where(E => StillFailed.Contains(E.Hex))
        .GroupBy(E => E.CallerClass)
        .OrderBy(G => G.Key);
    foreach (var G in FailedByClass)
    {
        var ShortClass = G.Key.TrimStart('L').TrimEnd(';').Replace('/', '.');
        Sb.AppendLine($"### `{ShortClass}`");
        foreach (var E in G.Select(E => E.Hex).Distinct())
            Sb.AppendLine($"- `{(E.Length > 80 ? E.Substring(0, 77) + "..." : E)}` ({E.Length / 2}B)");
        Sb.AppendLine();
    }
}

Sb.AppendLine("## Full Decryption Table");
Sb.AppendLine();
Sb.AppendLine("| Encrypted (first 40) | Decrypted | Method |");
Sb.AppendLine("|---|---|---|");
foreach (var Kv in Decrypted.OrderBy(K => K.Value.Plain))
{
    var Short = Kv.Key.Length > 40 ? Kv.Key.Substring(0, 37) + "..." : Kv.Key;
    Sb.AppendLine($"| `{Short}` | `{Kv.Value.Plain.Replace("|", "\\|")}` | {Kv.Value.Method} |");
}

File.WriteAllText(OutputPath, Sb.ToString());
Console.WriteLine($"\nResults written to {OutputPath}");

bool TryStandardDecrypt(string Hex, out string Plain)
{
    Plain = "";
    if (Hex.Length % 2 != 0 || Hex.Length < 56) return false;
    try
    {
        var D = Convert.FromHexString(Hex);
        if (D.Length < 28) return false;
        var Iv = D[..12];
        var CtTag = D[12..];
        var Ct = CtTag[..^16];
        var Tag = CtTag[^16..];
        var P = new byte[Ct.Length];
        new AesGcm(DerivedKey, 16).Decrypt(Iv, Ct, Tag, P);
        Plain = Encoding.UTF8.GetString(P);
        return true;
    }
    catch { return false; }
}

bool IsLikelyRawConstant(byte[] D, string Hex)
{
    if (Hex.Length < 2 || Hex.Length > 32) return true;
    if (D.Length <= 4) return true;
    if (Hex.All(C => "0123456789ABCDEFabcdef".Contains(C)) && D.Length <= 16)
    {
        if (Hex.Length <= 8) return true;
    }
    return false;
}

string ClassifyRawHex(byte[] D, string Hex)
{
    if (D.Length <= 2) return $"Short constant (tag/flag): 0x{Hex.ToUpperInvariant()}";
    if (D.Length <= 4) return $"EMV/TLV tag or short constant: 0x{Hex.ToUpperInvariant()}";
    if (D.Length <= 8) return $"Possible EMV tag/constant: 0x{Hex.ToUpperInvariant()}";
    return $"Hex constant ({D.Length}B)";
}

bool IsValidPlaintext(string S)
{
    if (string.IsNullOrEmpty(S)) return false;
    return S.All(C => !char.IsControl(C) || C == '\n' || C == '\r' || C == '\t');
}

bool TryAesCbc(byte[] D, out string Plain, out string Method)
{
    Plain = ""; Method = "";
    foreach (var Key in AltKeys)
    {
        if (Key.Value.Length != 16 && Key.Value.Length != 24 && Key.Value.Length != 32) continue;
        if (D.Length < 32 || (D.Length - 16) % 16 != 0) continue;
        try
        {
            var Aes = System.Security.Cryptography.Aes.Create();
            Aes.Key = Key.Value; Aes.IV = D[..16]; Aes.Mode = CipherMode.CBC; Aes.Padding = PaddingMode.PKCS7;
            var Dec = Aes.CreateDecryptor();
            var P = Dec.TransformFinalBlock(D, 16, D.Length - 16);
            var S = Encoding.UTF8.GetString(P);
            if (IsValidPlaintext(S) && S.Length > 0)
            {
                Plain = S; Method = $"AES-CBC,{Key.Key}"; return true;
            }
        }
        catch {}
    }
    return false;
}

static int R16(byte[] D, int O) => O + 1 < D.Length ? BitConverter.ToUInt16(D, O) : 0;
static int R32(byte[] D, int O) => O + 3 < D.Length ? BitConverter.ToInt32(D, O) : 0;
static int ReadUleb128(byte[] D, ref int P) { var R = 0; var S = 0; while (P < D.Length) { var B = D[P++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int O) { var P = O; while (P < D.Length && (D[P] & 0x80) != 0) P++; P++; var S = new StringBuilder(); while (P < D.Length && D[P] != 0) { var B = D[P]; if ((B & 0x80) == 0) { S.Append((char)B); P++; } else if ((B & 0xE0) == 0xC0 && P + 1 < D.Length) { S.Append((char)(((B & 0x1F) << 6) | (D[P+1] & 0x3F))); P += 2; } else if ((B & 0xF0) == 0xE0 && P + 2 < D.Length) { S.Append((char)(((B & 0x0F) << 12) | ((D[P+1] & 0x3F) << 6) | (D[P+2] & 0x3F))); P += 3; } else P++; } return S.ToString(); }
static int GIW(int O) { return O switch { 0x00 => 1, >= 0x01 and <= 0x07 => O >= 0x02 ? 2 : 1, 0x08 or 0x09 => 2, >= 0x0A and <= 0x11 => 1, 0x12 => 1, 0x13 => 2, 0x14 => 3, 0x15 => 2, 0x16 => 2, 0x17 => 3, 0x18 => 5, 0x19 => 2, 0x1A => 2, 0x1B => 3, 0x1C => 2, 0x1D or 0x1E => 1, 0x1F => 2, 0x20 => 2, 0x21 => 1, 0x22 => 2, 0x23 => 2, 0x24 or 0x25 => 3, 0x26 => 3, 0x27 => 1, 0x28 => 1, 0x29 => 2, 0x2A => 3, 0x2B or 0x2C => 3, >= 0x2D and <= 0x31 => 2, >= 0x32 and <= 0x3D => 2, >= 0x44 and <= 0x51 => 2, >= 0x52 and <= 0x6D => 2, >= 0x6E and <= 0x72 => 3, >= 0x74 and <= 0x78 => 3, >= 0x7B and <= 0x8F => 1, >= 0x90 and <= 0xAF => 2, >= 0xB0 and <= 0xCF => 1, >= 0xD0 and <= 0xE2 => 2, >= 0xFA => 4, _ => 1 }; }
