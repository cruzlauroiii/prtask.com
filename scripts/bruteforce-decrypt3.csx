using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PasswordBytes = Encoding.UTF8.GetBytes(Password);
var PasswordChars = Password.ToCharArray();

// Get FULL untruncated hex strings from DEX files
var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var AllEncrypted = new List<(string CallerClass, string Hex)>();

var Zip = ZipFile.OpenRead(ApkPath);
// Use classes11.dex which had 460 matches
var Entry = Zip.GetEntry("classes11.dex");
var Ms = new MemoryStream();
var Esm = Entry.Open(); Esm.CopyTo(Ms); Esm.Dispose();
var Data = Ms.ToArray();

var StringIdsSize = R32(Data, 56);
var StringIdsOff = R32(Data, 60);
var TypeIdsSize = R32(Data, 64);
var TypeIdsOff = R32(Data, 68);
var MethodIdsSize = R32(Data, 88);
var MethodIdsOff = R32(Data, 92);
var ClassDefsSize = R32(Data, 96);
var ClassDefsOff = R32(Data, 100);

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

// Scan for encrypted strings - get FULL hex values
for (var I = 0; I < ClassDefsSize; I++)
{
    var Base = ClassDefsOff + (I * 32);
    var ClassIdx = R32(Data, Base);
    if (ClassIdx >= TypeNames.Length) continue;
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
            else if ((O >= 0x6E && O <= 0x72) || (O >= 0x74 && O <= 0x78)) { var CM = R16(Data, IO + ((BP+1)*2)); if (DecryptIdxSet.Contains(CM) && LastStr.Length > 0) AllEncrypted.Add((TypeNames[ClassIdx], LastStr)); }
            BP += GIW(O);
        }
    }
}

var Unique = AllEncrypted.Select(E => E.Hex).Distinct().OrderBy(H => H.Length).ToList();
Console.WriteLine($"Found {Unique.Count} unique encrypted strings");
Console.WriteLine($"Lengths: {string.Join(", ", Unique.Select(H => H.Length).Distinct().OrderBy(L => L).Take(20))}");
Console.WriteLine();

// Show some samples by length
foreach (var G in Unique.GroupBy(H => H.Length).OrderBy(G => G.Key).Take(10))
{
    Console.WriteLine($"Length {G.Key} ({G.Key/2} bytes): {G.Count()} strings");
    foreach (var H in G.Take(3))
        Console.WriteLine($"  {H}");
}

Console.WriteLine();

// Now try decryption on various length strings
// The algorithm is AES-256-GCM with PBKDF2WithHmacSHA1
// Key: derived from password "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg"
// Structure from bytecode analysis:
//   cipherData = toByte(hexString)  -- hex to byte[]
//   const #22 appears -- could be salt length
//   const #12 -- IV length
//   GCM tag 128 bits (16 bytes)
//   PBKDF2 key length 256 bits (32 bytes)
//
// Possible data layout: [salt(22)] [iv(12)] [ciphertext] [gcm_tag(16)]
// OR: [iv(12)] [salt(22)] [ciphertext] [gcm_tag(16)]

// Try PBKDF2 with many iteration counts
// The iteration count was NOT visible as a constant in the bytecode
// Maybe it's computed from the obfuscated arithmetic?
// From decipher: add-int, rem-int, sub-int, const #22...

// Let me also try: the GCM tag is PREPENDED (Java default appends it, but some libraries prepend)

foreach (var TestHex in Unique.Where(H => H.Length >= 80).Take(5))
{
    var CB = HexToBytes(TestHex);
    if (CB == null) continue;
    Console.WriteLine($"\nTesting {TestHex.Substring(0, 60)}... ({CB.Length} bytes)");

    // Layout A: salt[0:22] + iv[22:34] + encrypted[34:] (encrypted includes GCM tag at end)
    // Layout B: iv[0:12] + salt[12:34] + encrypted[34:]
    // Layout C: iv[0:12] + encrypted[12:] (salt from password itself or fixed)

    foreach (var Layout in new[] { "A", "B", "C" })
    {
        byte[] Iv, Salt, CtTag;
        if (Layout == "A" && CB.Length >= 50)
        {
            Salt = CB[..22]; Iv = CB[22..34]; CtTag = CB[34..];
        }
        else if (Layout == "B" && CB.Length >= 50)
        {
            Iv = CB[..12]; Salt = CB[12..34]; CtTag = CB[34..];
        }
        else if (Layout == "C" && CB.Length >= 28)
        {
            Iv = CB[..12]; Salt = PasswordBytes[..22]; CtTag = CB[12..];
        }
        else continue;

        if (CtTag.Length < 16) continue;

        foreach (var Iters in new[] { 1, 2, 10, 22, 100, 128, 256, 1000, 4096, 10000, 65536, 100000 })
        {
            try
            {
                var Key = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, Salt, Iters, HashAlgorithmName.SHA1, 32);

                // GCM tag at end (Java default)
                var TagSize = 16;
                var CipherLen = CtTag.Length - TagSize;
                if (CipherLen < 0) continue;
                var Cipher = CtTag[..CipherLen];
                var Tag = CtTag[CipherLen..];
                var Plain = new byte[CipherLen];

                var Gcm = new AesGcm(Key, TagSize);
                Gcm.Decrypt(Iv, Cipher, Tag, Plain);

                var S = Encoding.UTF8.GetString(Plain);
                if (S.All(C => C >= 0x20 || C == '\n' || C == '\r' || C == '\t'))
                {
                    Console.WriteLine($"  DECRYPTED! Layout={Layout} iters={Iters}: \"{S}\"");

                    // Now decrypt ALL strings with this config
                    Console.WriteLine($"\n  === BATCH DECRYPTING ALL {Unique.Count} STRINGS ===\n");
                    var Decrypted = 0;
                    var Results = new List<(string Hex, string Plain2)>();
                    foreach (var H in Unique)
                    {
                        var B2 = HexToBytes(H);
                        if (B2 == null || B2.Length < 28) continue;
                        byte[] Iv2, Salt2, CtTag2;
                        if (Layout == "A" && B2.Length >= 50) { Salt2 = B2[..22]; Iv2 = B2[22..34]; CtTag2 = B2[34..]; }
                        else if (Layout == "B" && B2.Length >= 50) { Iv2 = B2[..12]; Salt2 = B2[12..34]; CtTag2 = B2[34..]; }
                        else if (Layout == "C") { Iv2 = B2[..12]; Salt2 = PasswordBytes[..22]; CtTag2 = B2[12..]; }
                        else continue;
                        if (CtTag2.Length < 16) continue;
                        try
                        {
                            var K2 = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, Salt2, Iters, HashAlgorithmName.SHA1, 32);
                            var CL2 = CtTag2.Length - 16;
                            var C2 = CtTag2[..CL2]; var T2 = CtTag2[CL2..]; var P2 = new byte[CL2];
                            new AesGcm(K2, 16).Decrypt(Iv2, C2, T2, P2);
                            var S2 = Encoding.UTF8.GetString(P2);
                            if (S2.All(C => C >= 0x20 || C == '\n' || C == '\r' || C == '\t'))
                            {
                                Decrypted++;
                                Results.Add((H, S2));
                            }
                        }
                        catch {}
                    }
                    Console.WriteLine($"  Decrypted {Decrypted}/{Unique.Count}");
                    foreach (var (Hx, Pl) in Results.Where(R => R.Plain2.Contains("http") || R.Plain2.Contains("api") || R.Plain2.Contains("url") || R.Plain2.Contains("endpoint") || R.Plain2.Contains("gateway") || R.Plain2.Contains(".com") || R.Plain2.Contains(".ph") || R.Plain2.Contains("payment") || R.Plain2.Contains("token") || R.Plain2.Contains("key") || R.Plain2.Contains("secret")).Take(50))
                        Console.WriteLine($"    API: {Pl}");
                    foreach (var (Hx, Pl) in Results.Take(100))
                        Console.WriteLine($"    {Hx.Substring(0, Math.Min(30, Hx.Length))}... = \"{Pl}\"");

                    // Write to output file
                    var OutSb = new StringBuilder();
                    OutSb.AppendLine("# DecryptString - Decrypted Strings");
                    OutSb.AppendLine();
                    OutSb.AppendLine($"Algorithm: AES/GCM/NoPadding, PBKDF2WithHmacSHA1");
                    OutSb.AppendLine($"Password: `{Password}`");
                    OutSb.AppendLine($"Data layout: {Layout} (salt={22}, iv={12}, gcm_tag={16})");
                    OutSb.AppendLine($"PBKDF2 iterations: {Iters}");
                    OutSb.AppendLine($"Key length: 256 bits");
                    OutSb.AppendLine();
                    OutSb.AppendLine($"## Results ({Decrypted}/{Unique.Count} decrypted from classes11.dex)");
                    OutSb.AppendLine();
                    OutSb.AppendLine("| Encrypted (first 40) | Decrypted |");
                    OutSb.AppendLine("|---|---|");
                    foreach (var (Hx, Pl) in Results)
                    {
                        var Short = Hx.Length > 40 ? Hx.Substring(0, 37) + "..." : Hx;
                        OutSb.AppendLine($"| `{Short}` | `{Pl.Replace("|", "\\|")}` |");
                    }
                    File.WriteAllText(@"C:\work\prtask.com\docs\decryptstring-reversed.md", OutSb.ToString());
                    Console.WriteLine($"\nResults written to decryptstring-reversed.md");
                    return;
                }
            }
            catch {}
        }
    }
}

Console.WriteLine("\nNo decryption succeeded.");

static int R16(byte[] D, int O) => O + 1 < D.Length ? BitConverter.ToUInt16(D, O) : 0;
static int R32(byte[] D, int O) => O + 3 < D.Length ? BitConverter.ToInt32(D, O) : 0;
static int ReadUleb128(byte[] D, ref int P) { var R = 0; var S = 0; while (P < D.Length) { var B = D[P++]; R |= (B & 0x7F) << S; if ((B & 0x80) == 0) break; S += 7; } return R; }
static string ReadMutf8(byte[] D, int O) { var P = O; while (P < D.Length && (D[P] & 0x80) != 0) P++; P++; var S = new StringBuilder(); while (P < D.Length && D[P] != 0) { var B = D[P]; if ((B & 0x80) == 0) { S.Append((char)B); P++; } else if ((B & 0xE0) == 0xC0 && P + 1 < D.Length) { S.Append((char)(((B & 0x1F) << 6) | (D[P+1] & 0x3F))); P += 2; } else if ((B & 0xF0) == 0xE0 && P + 2 < D.Length) { S.Append((char)(((B & 0x0F) << 12) | ((D[P+1] & 0x3F) << 6) | (D[P+2] & 0x3F))); P += 3; } else P++; } return S.ToString(); }
static byte[] HexToBytes(string H) { try { if (H.Length % 2 != 0) return null; var B = new byte[H.Length / 2]; for (var I = 0; I < B.Length; I++) B[I] = byte.Parse(H.Substring(I * 2, 2), NumberStyles.HexNumber); return B; } catch { return null; } }
static int GIW(int O) { return O switch { 0x00 => 1, >= 0x01 and <= 0x07 => O >= 0x02 ? 2 : 1, 0x08 or 0x09 => 2, >= 0x0A and <= 0x11 => 1, 0x12 => 1, 0x13 => 2, 0x14 => 3, 0x15 => 2, 0x16 => 2, 0x17 => 3, 0x18 => 5, 0x19 => 2, 0x1A => 2, 0x1B => 3, 0x1C => 2, 0x1D or 0x1E => 1, 0x1F => 2, 0x20 => 2, 0x21 => 1, 0x22 => 2, 0x23 => 2, 0x24 or 0x25 => 3, 0x26 => 3, 0x27 => 1, 0x28 => 1, 0x29 => 2, 0x2A => 3, 0x2B or 0x2C => 3, >= 0x2D and <= 0x31 => 2, >= 0x32 and <= 0x3D => 2, >= 0x44 and <= 0x51 => 2, >= 0x52 and <= 0x6D => 2, >= 0x6E and <= 0x72 => 3, >= 0x74 and <= 0x78 => 3, >= 0x7B and <= 0x8F => 1, >= 0x90 and <= 0xAF => 2, >= 0xB0 and <= 0xCF => 1, >= 0xD0 and <= 0xE2 => 2, >= 0xFA => 4, _ => 1 }; }
