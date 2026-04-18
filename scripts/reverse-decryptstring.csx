using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var OutputPath = @"C:\work\prtask.com\docs\decryptstring-reversed.md";

var Sb = new StringBuilder();
Sb.AppendLine("# DecryptString Reverse Engineering");
Sb.AppendLine();
Sb.AppendLine($"Generated: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC");
Sb.AppendLine();

var Zip = ZipFile.OpenRead(ApkPath);
var DexEntries = Zip.Entries.Where(E => E.Name.EndsWith(".dex", StringComparison.OrdinalIgnoreCase)).OrderBy(E => E.Name).ToList();

Console.WriteLine($"Found {DexEntries.Count} DEX files");

foreach (var Entry in DexEntries)
{
    Console.WriteLine($"Processing {Entry.Name} ({Entry.Length} bytes)...");

    var Ms = new MemoryStream();
    var Es = Entry.Open(); Es.CopyTo(Ms); Es.Dispose();
    var Data = Ms.ToArray();

    if (Data.Length < 112 || Encoding.ASCII.GetString(Data, 0, 3) != "dex")
    {
        Console.WriteLine($"  Skipping {Entry.Name} - not valid DEX");
        continue;
    }

    var StringIdsSize = R32(Data, 56);
    var StringIdsOff = R32(Data, 60);
    var TypeIdsSize = R32(Data, 64);
    var TypeIdsOff = R32(Data, 68);
    var ProtoIdsSize = R32(Data, 72);
    var ProtoIdsOff = R32(Data, 76);
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

    var MethodIds = new (int ClassIdx, int ProtoIdx, int NameIdx)[MethodIdsSize];
    for (var I = 0; I < MethodIdsSize; I++)
    {
        var Base = MethodIdsOff + (I * 8);
        MethodIds[I] = (R16(Data, Base), R16(Data, Base + 2), R32(Data, Base + 4));
    }

    var ProtoIds = new (int ShortyIdx, int RetTypeIdx, int ParamsOff)[ProtoIdsSize];
    for (var I = 0; I < ProtoIdsSize; I++)
    {
        var Base = ProtoIdsOff + (I * 12);
        ProtoIds[I] = (R32(Data, Base), R32(Data, Base + 4), R32(Data, Base + 8));
    }

    // Find DecryptString method indices
    var DecryptMethodIdxSet = new HashSet<int>();
    var DecryptMethodIdx = -1;
    for (var I = 0; I < MethodIdsSize; I++)
    {
        var ClassTypeIdx = MethodIds[I].ClassIdx;
        var NameIdx = MethodIds[I].NameIdx;
        if (ClassTypeIdx < TypeNames.Length && NameIdx < Strings.Length)
        {
            var TypeDesc = TypeNames[ClassTypeIdx];
            var MName = Strings[NameIdx];
            if (TypeDesc.Contains("decryptstringmanager") && MName == "decryptString")
            {
                DecryptMethodIdxSet.Add(I);
                DecryptMethodIdx = I;
                Console.WriteLine($"  Found decryptString at method index {I}");
                Console.WriteLine($"    Class: {TypeDesc}");
                Console.WriteLine($"    Proto idx: {MethodIds[I].ProtoIdx}");
                if (MethodIds[I].ProtoIdx < ProtoIdsSize)
                {
                    var P = ProtoIds[MethodIds[I].ProtoIdx];
                    Console.WriteLine($"    Return type idx: {P.RetTypeIdx} = {(P.RetTypeIdx < TypeNames.Length ? TypeNames[P.RetTypeIdx] : "?")}");
                }
            }
        }
    }

    // Find DecryptString class def and extract bytecode
    for (var I = 0; I < ClassDefsSize; I++)
    {
        var Base = ClassDefsOff + (I * 32);
        var ClassIdx = R32(Data, Base);
        if (ClassIdx >= TypeNames.Length) continue;
        var ClassName = TypeNames[ClassIdx];
        if (!ClassName.Contains("decryptstringmanager")) continue;

        Console.WriteLine($"  Found class: {ClassName}");
        Sb.AppendLine($"## Class: {ClassName} (in {Entry.Name})");
        Sb.AppendLine();

        var ClassDataOff = R32(Data, Base + 24);
        if (ClassDataOff <= 0 || ClassDataOff >= Data.Length) continue;

        var Pos = ClassDataOff;
        var StaticFieldsSize = ReadUleb128(Data, ref Pos);
        var InstanceFieldsSize = ReadUleb128(Data, ref Pos);
        var DirectMethodsSize = ReadUleb128(Data, ref Pos);
        var VirtualMethodsSize = ReadUleb128(Data, ref Pos);

        Console.WriteLine($"    Static fields: {StaticFieldsSize}, Instance fields: {InstanceFieldsSize}");
        Console.WriteLine($"    Direct methods: {DirectMethodsSize}, Virtual methods: {VirtualMethodsSize}");

        // Skip fields
        var FIdx = 0;
        for (var J = 0; J < StaticFieldsSize; J++) { FIdx += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }
        FIdx = 0;
        for (var J = 0; J < InstanceFieldsSize; J++) { FIdx += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }

        // Parse methods
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

            Console.WriteLine($"    Method: {MName} (code offset: {CodeOff})");
            Sb.AppendLine($"### Method: {MName}");
            Sb.AppendLine();

            if (CodeOff > 0 && CodeOff + 16 <= Data.Length)
            {
                var RegistersSize = R16(Data, CodeOff);
                var InsSize = R16(Data, CodeOff + 2);
                var OutsSize = R16(Data, CodeOff + 4);
                var TriesSize = R16(Data, CodeOff + 6);
                var InsnsSize = R32(Data, CodeOff + 12);
                var InsnsOff = CodeOff + 16;

                Console.WriteLine($"      Registers: {RegistersSize}, Ins: {InsSize}, Outs: {OutsSize}, InsnsSize: {InsnsSize}");
                Sb.AppendLine($"- Registers: {RegistersSize}, Ins: {InsSize}, Outs: {OutsSize}");
                Sb.AppendLine($"- Instructions: {InsnsSize} code units");
                Sb.AppendLine();

                // Dump full bytecode with disassembly
                Sb.AppendLine("```");
                var BcPos = 0;
                while (BcPos < InsnsSize && InsnsOff + ((BcPos + 1) * 2) <= Data.Length)
                {
                    var Unit = R16(Data, InsnsOff + (BcPos * 2));
                    var Op = Unit & 0xFF;
                    var InsnStr = DisassembleInsn(Data, Strings, TypeNames, MethodIds, Strings, InsnsOff, BcPos, InsnsSize, MethodIdsSize);
                    Sb.AppendLine($"  {BcPos:X4}: {InsnStr}");
                    BcPos += GetInsnWidth(Op, Data, InsnsOff, BcPos, InsnsSize);
                }
                Sb.AppendLine("```");
                Sb.AppendLine();
            }
        }
    }

    // Now find all callers of DecryptString.decryptString and extract their encrypted strings
    if (DecryptMethodIdxSet.Count > 0)
    {
        Console.WriteLine($"  Scanning for callers of decryptString (method idx {DecryptMethodIdx})...");
        Sb.AppendLine("## Encrypted String References");
        Sb.AppendLine();

        var EncryptedStrings = new List<(string CallerClass, string CallerMethod, string HexString)>();

        for (var I = 0; I < ClassDefsSize; I++)
        {
            var Base = ClassDefsOff + (I * 32);
            var ClassIdx = R32(Data, Base);
            if (ClassIdx >= TypeNames.Length) continue;
            var ClassName = TypeNames[ClassIdx];

            var ClassDataOff = R32(Data, Base + 24);
            if (ClassDataOff <= 0 || ClassDataOff >= Data.Length) continue;

            var Pos = ClassDataOff;
            var StaticFieldsSize = ReadUleb128(Data, ref Pos);
            var InstanceFieldsSize = ReadUleb128(Data, ref Pos);
            var DirectMethodsSize = ReadUleb128(Data, ref Pos);
            var VirtualMethodsSize = ReadUleb128(Data, ref Pos);

            var FIdx = 0;
            for (var J = 0; J < StaticFieldsSize; J++) { FIdx += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }
            FIdx = 0;
            for (var J = 0; J < InstanceFieldsSize; J++) { FIdx += ReadUleb128(Data, ref Pos); ReadUleb128(Data, ref Pos); }

            var MIdx = 0;
            for (var J = 0; J < DirectMethodsSize + VirtualMethodsSize; J++)
            {
                if (J == DirectMethodsSize) MIdx = 0;
                MIdx += ReadUleb128(Data, ref Pos);
                var MAcc = ReadUleb128(Data, ref Pos);
                var CodeOff = ReadUleb128(Data, ref Pos);

                if (CodeOff <= 0 || CodeOff + 16 > Data.Length || MIdx >= MethodIdsSize) continue;

                var MNameIdx = MethodIds[MIdx].NameIdx;
                var CallerMName = MNameIdx < Strings.Length ? Strings[MNameIdx] : "?";

                var InsnsSize2 = R32(Data, CodeOff + 12);
                var InsnsOff2 = CodeOff + 16;
                if (InsnsSize2 == 0 || InsnsOff2 + (InsnsSize2 * 2) > Data.Length) continue;

                // Scan for const-string followed by invoke with DecryptMethodIdx
                var LastStringIdx = -1;
                var LastStringVal = "";
                var BcPos2 = 0;
                while (BcPos2 < InsnsSize2)
                {
                    var Unit2 = R16(Data, InsnsOff2 + (BcPos2 * 2));
                    var Op2 = Unit2 & 0xFF;

                    if (Op2 == 0x1A) // const-string
                    {
                        var SIdx = R16(Data, InsnsOff2 + ((BcPos2 + 1) * 2));
                        if (SIdx < Strings.Length)
                        {
                            LastStringIdx = SIdx;
                            LastStringVal = Strings[SIdx];
                        }
                    }
                    else if (Op2 == 0x1B) // const-string/jumbo
                    {
                        var SIdx = R32(Data, InsnsOff2 + ((BcPos2 + 1) * 2));
                        if (SIdx >= 0 && SIdx < Strings.Length)
                        {
                            LastStringIdx = SIdx;
                            LastStringVal = Strings[SIdx];
                        }
                    }
                    else if (Op2 >= 0x6E && Op2 <= 0x72) // invoke-*
                    {
                        var CallMIdx = R16(Data, InsnsOff2 + ((BcPos2 + 1) * 2));
                        if (DecryptMethodIdxSet.Contains(CallMIdx) && LastStringVal.Length > 0)
                        {
                            EncryptedStrings.Add((ClassName, CallerMName, LastStringVal));
                        }
                    }
                    else if (Op2 >= 0x74 && Op2 <= 0x78) // invoke-*/range
                    {
                        var CallMIdx = R16(Data, InsnsOff2 + ((BcPos2 + 1) * 2));
                        if (DecryptMethodIdxSet.Contains(CallMIdx) && LastStringVal.Length > 0)
                        {
                            EncryptedStrings.Add((ClassName, CallerMName, LastStringVal));
                        }
                    }

                    BcPos2 += GetInsnWidth(Op2, Data, InsnsOff2, BcPos2, InsnsSize2);
                }
            }
        }

        Console.WriteLine($"  Found {EncryptedStrings.Count} encrypted strings");
        Sb.AppendLine($"Total encrypted strings found: {EncryptedStrings.Count}");
        Sb.AppendLine();

        // Try common decryption approaches
        Sb.AppendLine("### Encrypted Strings (raw hex)");
        Sb.AppendLine();
        Sb.AppendLine("| Caller Class | Method | Encrypted Hex |");
        Sb.AppendLine("|---|---|---|");
        foreach (var (Caller, Method, Hex) in EncryptedStrings.Take(100))
        {
            var ShortCaller = Caller.Length > 50 ? "..." + Caller.Substring(Caller.Length - 47) : Caller;
            var ShortHex = Hex.Length > 60 ? Hex.Substring(0, 57) + "..." : Hex;
            Sb.AppendLine($"| `{ShortCaller}` | `{Method}` | `{ShortHex}` |");
        }
        Sb.AppendLine();

        // Try to find the key in string pool
        Sb.AppendLine("### Key Search");
        Sb.AppendLine();

        // Look for common crypto-related strings in the same DEX
        var CryptoStrings = new List<(int Idx, string Val)>();
        for (var S = 0; S < Strings.Length; S++)
        {
            var Sv = Strings[S];
            if (Sv == "AES" || Sv == "DES" || Sv == "DESede" || Sv == "Blowfish" ||
                Sv.Contains("AES/") || Sv.Contains("DES/") || Sv.Contains("DESede/") ||
                Sv == "SHA-256" || Sv == "SHA-1" || Sv == "MD5" ||
                Sv == "UTF-8" || Sv == "UTF8" ||
                Sv.Contains("PKCS5Padding") || Sv.Contains("NoPadding") || Sv.Contains("PKCS7") ||
                Sv.Contains("CBC") || Sv.Contains("ECB") || Sv.Contains("CTR") || Sv.Contains("GCM") ||
                Sv == "SecretKeySpec" || Sv == "IvParameterSpec" ||
                Sv.Contains("Cipher") || Sv.Contains("MessageDigest"))
            {
                CryptoStrings.Add((S, Sv));
            }
        }

        Sb.AppendLine("Crypto-related strings in string pool:");
        Sb.AppendLine();
        foreach (var (Idx, Val) in CryptoStrings)
        {
            Sb.AppendLine($"- `[{Idx}]` = `{Val}`");
        }
        Sb.AppendLine();

        // Now attempt decryption with various approaches
        // First, try simple XOR or DES/AES with keys found near DecryptString

        // Search for 8 or 16 byte keys in strings near the DecryptString class strings
        var PotentialKeys = new List<string>();
        for (var S = 0; S < Strings.Length; S++)
        {
            var Sv = Strings[S];
            if ((Sv.Length == 8 || Sv.Length == 16 || Sv.Length == 24 || Sv.Length == 32) &&
                Sv.All(C => (C >= 'a' && C <= 'z') || (C >= 'A' && C <= 'Z') || (C >= '0' && C <= '9') || C == '!' || C == '@' || C == '#' || C == '$' || C == '%'))
            {
                PotentialKeys.Add(Sv);
            }
        }

        Sb.AppendLine($"Potential keys (8/16/24/32 char alphanumeric): {PotentialKeys.Count}");
        Sb.AppendLine();
        foreach (var K in PotentialKeys.Take(50))
        {
            Sb.AppendLine($"- `{K}`");
        }
        Sb.AppendLine();

        // Try decrypting with each potential key using DES/ECB, DES/CBC, AES/ECB, AES/CBC
        Sb.AppendLine("### Decryption Attempts");
        Sb.AppendLine();

        var TestHex = EncryptedStrings.Count > 0 ? EncryptedStrings[0].HexString : "";
        if (TestHex.Length > 0)
        {
            var TestBytes = HexToBytes(TestHex);
            if (TestBytes != null)
            {
                Sb.AppendLine($"Test ciphertext: `{TestHex}` ({TestBytes.Length} bytes)");
                Sb.AppendLine();

                foreach (var Key in PotentialKeys)
                {
                    var KeyBytes = Encoding.UTF8.GetBytes(Key);

                    // Try DES/ECB
                    if (KeyBytes.Length == 8)
                    {
                        var Result = TryDesEcb(TestBytes, KeyBytes);
                        if (Result != null)
                        {
                            Sb.AppendLine($"**DES/ECB with key `{Key}` = `{Result}`**");
                            Console.WriteLine($"  DECRYPTED (DES/ECB, key={Key}): {Result}");
                        }

                        Result = TryDesCbc(TestBytes, KeyBytes, new byte[8]);
                        if (Result != null)
                        {
                            Sb.AppendLine($"**DES/CBC/ZeroIV with key `{Key}` = `{Result}`**");
                            Console.WriteLine($"  DECRYPTED (DES/CBC/0IV, key={Key}): {Result}");
                        }
                    }

                    // Try AES/ECB
                    if (KeyBytes.Length == 16 || KeyBytes.Length == 24 || KeyBytes.Length == 32)
                    {
                        var Result = TryAesEcb(TestBytes, KeyBytes);
                        if (Result != null)
                        {
                            Sb.AppendLine($"**AES/ECB with key `{Key}` = `{Result}`**");
                            Console.WriteLine($"  DECRYPTED (AES/ECB, key={Key}): {Result}");
                        }

                        Result = TryAesCbc(TestBytes, KeyBytes, new byte[16]);
                        if (Result != null)
                        {
                            Sb.AppendLine($"**AES/CBC/ZeroIV with key `{Key}` = `{Result}`**");
                            Console.WriteLine($"  DECRYPTED (AES/CBC/0IV, key={Key}): {Result}");
                        }
                    }
                }

                // Also try if the key is embedded in the class as a hardcoded byte sequence
                // Common pattern: key derived from class name or package name
                var CommonKeys = new[] { "decryptstring", "DecryptString", "pocketpay", "PocketPay", "softpos", "SoftPos" };
                foreach (var Ck in CommonKeys)
                {
                    var KeyBytes2 = Encoding.UTF8.GetBytes(Ck);
                    if (KeyBytes2.Length == 8)
                    {
                        var Result = TryDesEcb(TestBytes, KeyBytes2);
                        if (Result != null) { Sb.AppendLine($"**DES/ECB with key `{Ck}` = `{Result}`**"); Console.WriteLine($"  DECRYPTED: {Result}"); }
                    }
                    // Pad/truncate to 8 for DES
                    var DesKey = new byte[8];
                    Array.Copy(KeyBytes2, DesKey, Math.Min(KeyBytes2.Length, 8));
                    var R1 = TryDesEcb(TestBytes, DesKey);
                    if (R1 != null) { Sb.AppendLine($"**DES/ECB with padded key `{Ck}` = `{R1}`**"); Console.WriteLine($"  DECRYPTED (padded DES): {R1}"); }

                    // MD5 of key for AES-128
                    var Md5 = MD5.Create();
                    var Md5Key = Md5.ComputeHash(KeyBytes2);
                    var R2 = TryAesEcb(TestBytes, Md5Key);
                    if (R2 != null) { Sb.AppendLine($"**AES/ECB with MD5({Ck}) = `{R2}`**"); Console.WriteLine($"  DECRYPTED (AES/MD5): {R2}"); }
                }
            }
        }
    }
}

File.WriteAllText(OutputPath, Sb.ToString());
Console.WriteLine($"\nResults written to {OutputPath}");

// Helper functions
static int R16(byte[] D, int Off) => Off + 1 < D.Length ? BitConverter.ToUInt16(D, Off) : 0;
static int R32(byte[] D, int Off) => Off + 3 < D.Length ? BitConverter.ToInt32(D, Off) : 0;

static int ReadUleb128(byte[] D, ref int Pos)
{
    var Result = 0; var Shift = 0;
    while (Pos < D.Length)
    {
        var B = D[Pos++];
        Result |= (B & 0x7F) << Shift;
        if ((B & 0x80) == 0) break;
        Shift += 7;
    }
    return Result;
}

static string ReadMutf8(byte[] D, int Offset)
{
    var Pos = Offset;
    while (Pos < D.Length && (D[Pos] & 0x80) != 0) Pos++;
    Pos++;
    var Sb2 = new StringBuilder();
    while (Pos < D.Length && D[Pos] != 0)
    {
        var B = D[Pos];
        if ((B & 0x80) == 0) { Sb2.Append((char)B); Pos++; }
        else if ((B & 0xE0) == 0xC0 && Pos + 1 < D.Length) { Sb2.Append((char)(((B & 0x1F) << 6) | (D[Pos + 1] & 0x3F))); Pos += 2; }
        else if ((B & 0xF0) == 0xE0 && Pos + 2 < D.Length) { Sb2.Append((char)(((B & 0x0F) << 12) | ((D[Pos + 1] & 0x3F) << 6) | (D[Pos + 2] & 0x3F))); Pos += 3; }
        else Pos++;
    }
    return Sb2.ToString();
}

static byte[] HexToBytes(string Hex)
{
    try
    {
        if (Hex.Length % 2 != 0) return null;
        var Bytes = new byte[Hex.Length / 2];
        for (var I = 0; I < Bytes.Length; I++)
            Bytes[I] = byte.Parse(Hex.Substring(I * 2, 2), NumberStyles.HexNumber);
        return Bytes;
    }
    catch { return null; }
}

static string TryDesEcb(byte[] Cipher, byte[] Key)
{
    try
    {
        var Des = System.Security.Cryptography.DES.Create();
        Des.Key = Key; Des.Mode = CipherMode.ECB; Des.Padding = PaddingMode.PKCS7;
        var Dec = Des.CreateDecryptor();
        var Plain = Dec.TransformFinalBlock(Cipher, 0, Cipher.Length);
        var S = Encoding.UTF8.GetString(Plain);
        return IsPrintable(S) ? S : null;
    }
    catch { return null; }
}

static string TryDesCbc(byte[] Cipher, byte[] Key, byte[] Iv)
{
    try
    {
        var Des = System.Security.Cryptography.DES.Create();
        Des.Key = Key; Des.IV = Iv; Des.Mode = CipherMode.CBC; Des.Padding = PaddingMode.PKCS7;
        var Dec = Des.CreateDecryptor();
        var Plain = Dec.TransformFinalBlock(Cipher, 0, Cipher.Length);
        var S = Encoding.UTF8.GetString(Plain);
        return IsPrintable(S) ? S : null;
    }
    catch { return null; }
}

static string TryAesEcb(byte[] Cipher, byte[] Key)
{
    try
    {
        if (Cipher.Length % 16 != 0) return null;
        var Aes2 = System.Security.Cryptography.Aes.Create();
        Aes2.Key = Key; Aes2.Mode = CipherMode.ECB; Aes2.Padding = PaddingMode.PKCS7;
        var Dec = Aes2.CreateDecryptor();
        var Plain = Dec.TransformFinalBlock(Cipher, 0, Cipher.Length);
        var S = Encoding.UTF8.GetString(Plain);
        return IsPrintable(S) ? S : null;
    }
    catch { return null; }
}

static string TryAesCbc(byte[] Cipher, byte[] Key, byte[] Iv)
{
    try
    {
        if (Cipher.Length % 16 != 0) return null;
        var Aes2 = System.Security.Cryptography.Aes.Create();
        Aes2.Key = Key; Aes2.IV = Iv; Aes2.Mode = CipherMode.CBC; Aes2.Padding = PaddingMode.PKCS7;
        var Dec = Aes2.CreateDecryptor();
        var Plain = Dec.TransformFinalBlock(Cipher, 0, Cipher.Length);
        var S = Encoding.UTF8.GetString(Plain);
        return IsPrintable(S) ? S : null;
    }
    catch { return null; }
}

static bool IsPrintable(string S)
{
    if (string.IsNullOrEmpty(S)) return false;
    foreach (var C in S)
    {
        if (C < 0x20 && C != '\n' && C != '\r' && C != '\t') return false;
        if (C == 0xFFFD) return false;
    }
    return true;
}

static string DisassembleInsn(byte[] Data, string[] Strings, string[] TypeNames, (int ClassIdx, int ProtoIdx, int NameIdx)[] MethodIds, string[] AllStrings, int InsnsOff, int Pos, int InsnsSize, int MethodIdsSize)
{
    if (InsnsOff + ((Pos + 1) * 2) > Data.Length) return "???";
    var Unit = R16(Data, InsnsOff + (Pos * 2));
    var Op = Unit & 0xFF;
    var A = (Unit >> 8) & 0xF;
    var B = (Unit >> 12) & 0xF;
    var AA = (Unit >> 8) & 0xFF;

    switch (Op)
    {
        case 0x00: return "nop";
        case 0x01: return $"move v{A}, v{B}";
        case 0x0E: return "return-void";
        case 0x0F: return $"return v{AA}";
        case 0x10: return $"return-wide v{AA}";
        case 0x11: return $"return-object v{AA}";
        case 0x12: return $"const/4 v{A}, #{B}";
        case 0x13: { var V = (short)R16(Data, InsnsOff + ((Pos + 1) * 2)); return $"const/16 v{AA}, #{V}"; }
        case 0x14: { var V = R32(Data, InsnsOff + ((Pos + 1) * 2)); return $"const v{AA}, #{V}"; }
        case 0x1A:
        {
            var SIdx = R16(Data, InsnsOff + ((Pos + 1) * 2));
            var SVal = SIdx < AllStrings.Length ? AllStrings[SIdx] : "?";
            if (SVal.Length > 80) SVal = SVal.Substring(0, 77) + "...";
            return $"const-string v{AA}, \"{SVal}\"";
        }
        case 0x1B:
        {
            var SIdx = R32(Data, InsnsOff + ((Pos + 1) * 2));
            var SVal = SIdx < AllStrings.Length ? AllStrings[SIdx] : "?";
            if (SVal.Length > 80) SVal = SVal.Substring(0, 77) + "...";
            return $"const-string/jumbo v{AA}, \"{SVal}\"";
        }
        case 0x1C:
        {
            var TIdx = R16(Data, InsnsOff + ((Pos + 1) * 2));
            return $"const-class v{AA}, {(TIdx < TypeNames.Length ? TypeNames[TIdx] : "?")}";
        }
        case 0x22:
        {
            var TIdx = R16(Data, InsnsOff + ((Pos + 1) * 2));
            return $"new-instance v{AA}, {(TIdx < TypeNames.Length ? TypeNames[TIdx] : "?")}";
        }
        case 0x54: case 0x55: case 0x56: case 0x57: case 0x58: case 0x59: case 0x5A: case 0x5B: case 0x5C: case 0x5D: case 0x5E: case 0x5F:
        {
            var Names = new[] { "iget", "iget-wide", "iget-object", "iget-boolean", "iget-byte", "iget-char", "iget-short", "iput", "iput-wide", "iput-object", "iput-boolean", "iput-byte" };
            return $"{Names[Op - 0x54]} v{A}, v{B}, field@{R16(Data, InsnsOff + ((Pos + 1) * 2))}";
        }
        case 0x60: case 0x61: case 0x62: case 0x63: case 0x64: case 0x65: case 0x66: case 0x67: case 0x68: case 0x69: case 0x6A: case 0x6B: case 0x6C: case 0x6D:
        {
            var Names = new[] { "sget", "sget-wide", "sget-object", "sget-boolean", "sget-byte", "sget-char", "sget-short", "sput", "sput-wide", "sput-object", "sput-boolean", "sput-byte", "sput-char", "sput-short" };
            return $"{Names[Op - 0x60]} v{AA}, field@{R16(Data, InsnsOff + ((Pos + 1) * 2))}";
        }
        case 0x6E: case 0x6F: case 0x70: case 0x71: case 0x72:
        {
            var Names = new[] { "invoke-virtual", "invoke-super", "invoke-direct", "invoke-static", "invoke-interface" };
            var MIdx = R16(Data, InsnsOff + ((Pos + 1) * 2));
            var MDesc = "?";
            if (MIdx < MethodIdsSize)
            {
                var CIdx = MethodIds[MIdx].ClassIdx;
                var NIdx = MethodIds[MIdx].NameIdx;
                var CName = CIdx < TypeNames.Length ? TypeNames[CIdx] : "?";
                var MName = NIdx < AllStrings.Length ? AllStrings[NIdx] : "?";
                MDesc = $"{CName}.{MName}";
            }
            return $"{Names[Op - 0x6E]} {MDesc}";
        }
        case 0x74: case 0x75: case 0x76: case 0x77: case 0x78:
        {
            var Names = new[] { "invoke-virtual/range", "invoke-super/range", "invoke-direct/range", "invoke-static/range", "invoke-interface/range" };
            var MIdx = R16(Data, InsnsOff + ((Pos + 1) * 2));
            var MDesc = "?";
            if (MIdx < MethodIdsSize)
            {
                var CIdx = MethodIds[MIdx].ClassIdx;
                var NIdx = MethodIds[MIdx].NameIdx;
                var CName = CIdx < TypeNames.Length ? TypeNames[CIdx] : "?";
                var MName = NIdx < AllStrings.Length ? AllStrings[NIdx] : "?";
                MDesc = $"{CName}.{MName}";
            }
            return $"{Names[Op - 0x74]} {MDesc}";
        }
        case >= 0x90 and <= 0xAF:
        {
            var Ops = new[] { "add-int", "sub-int", "mul-int", "div-int", "rem-int", "and-int", "or-int", "xor-int", "shl-int", "shr-int", "ushr-int",
                "add-long", "sub-long", "mul-long", "div-long", "rem-long", "and-long", "or-long", "xor-long", "shl-long", "shr-long", "ushr-long",
                "add-float", "sub-float", "mul-float", "div-float", "rem-float",
                "add-double", "sub-double", "mul-double", "div-double", "rem-double" };
            return $"{Ops[Op - 0x90]} v{AA}";
        }
        case >= 0xB0 and <= 0xCF:
        {
            return $"binop/2addr op={Op:X2} v{A}, v{B}";
        }
        case >= 0xD0 and <= 0xD8:
        {
            return $"binop/lit16 op={Op:X2} v{A}, v{B}";
        }
        case >= 0xD9 and <= 0xE2:
        {
            return $"binop/lit8 op={Op:X2} v{AA}";
        }
        case 0x28: return $"goto +{(sbyte)AA}";
        case 0x29: { var Off = (short)R16(Data, InsnsOff + ((Pos + 1) * 2)); return $"goto/16 +{Off}"; }
        case >= 0x32 and <= 0x37:
        {
            var Names = new[] { "if-eq", "if-ne", "if-lt", "if-ge", "if-gt", "if-le" };
            var Off = (short)R16(Data, InsnsOff + ((Pos + 1) * 2));
            return $"{Names[Op - 0x32]} v{A}, v{B}, +{Off}";
        }
        case >= 0x38 and <= 0x3D:
        {
            var Names = new[] { "if-eqz", "if-nez", "if-ltz", "if-gez", "if-gtz", "if-lez" };
            var Off = (short)R16(Data, InsnsOff + ((Pos + 1) * 2));
            return $"{Names[Op - 0x38]} v{AA}, +{Off}";
        }
        case >= 0x7B and <= 0x8F:
        {
            return $"unop op={Op:X2} v{A}, v{B}";
        }
        default:
            return $"op={Op:X2} raw={Unit:X4}";
    }
}

static int GetInsnWidth(int Op, byte[] Data, int InsnsOff, int Pos, int InsnsSize)
{
    switch (Op)
    {
        case 0x00:
        {
            // Check for packed-switch/fill-array payload
            if (Pos + 1 < InsnsSize)
            {
                var Next = R16(Data, InsnsOff + ((Pos) * 2));
                if ((Next & 0xFF) == 0x00 && (Next >> 8) == 0x01) // packed-switch payload
                    return 1; // just skip NOP
                if ((Next & 0xFF) == 0x00 && (Next >> 8) == 0x02) // sparse-switch payload
                    return 1;
                if ((Next & 0xFF) == 0x00 && (Next >> 8) == 0x03) // fill-array payload
                    return 1;
            }
            return 1;
        }
        case 0x01: case 0x02: case 0x03: case 0x04: case 0x05: case 0x06: case 0x07: return 1;
        case 0x08: case 0x09: return 2;
        case 0x0A: case 0x0B: case 0x0C: case 0x0D: return 1;
        case 0x0E: return 1;
        case 0x0F: case 0x10: case 0x11: return 1;
        case 0x12: return 1;
        case 0x13: return 2;
        case 0x14: return 3;
        case 0x15: return 2;
        case 0x16: return 2;
        case 0x17: return 3;
        case 0x18: return 5;
        case 0x19: return 2;
        case 0x1A: return 2;
        case 0x1B: return 3;
        case 0x1C: return 2;
        case 0x1D: case 0x1E: return 1;
        case 0x1F: return 2;
        case 0x20: return 2;
        case 0x21: return 1;
        case 0x22: return 2;
        case 0x23: return 2;
        case 0x24: case 0x25: return 3;
        case 0x26: return 3;
        case 0x27: return 1;
        case 0x28: return 1;
        case 0x29: return 2;
        case 0x2A: return 3;
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
