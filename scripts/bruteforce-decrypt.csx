using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PasswordChars = Password.ToCharArray();
var PasswordBytes = Encoding.UTF8.GetBytes(Password);

// Sample encrypted hex strings from the APK
var Samples = new[]
{
    "eeff43bf3b6fbf44db4638071c443f812ed8fc20db53b4daf01308eb3e",
    "92fcdb0094711ad4d5106ef4235417633e8b2a1bbb04312d3368399adb",
    "1a80035cbf405cebce18c0cbfc4c3ee0208e5b16b869ed90a07483f80d",
    "660c28f2842fd442809fc41a47ad2f3b46c4be33952a20604e564963f9",
    "6766ca8fa0ae50ff83ec9b71debd3929c434023c9e638e5288f7dbc78a",
    "ab928934b4d466adfc61b0a40234b07a9497a22e155ff1d7713aeeca4f",
    "79556ae9859031853f808c59d700798a42a84b94908a3e2722e455fb5b",
    "7bfc92c3920bb30fb767cf4fa3f120d7af539e60a386048c9e90538680",
    "d08c2ebe22c38f14531e73084529fbed2c50e8a03cba3ce6e5c2d51932",
    "81e58fa8bf19576b805ca7bd78bddbb4025f87b139e5bb49944de52fdf",
};

foreach (var Hex in Samples)
{
    var CipherBytes = HexToBytes(Hex);
    if (CipherBytes == null) continue;
    Console.WriteLine($"\nTesting: {Hex} ({CipherBytes.Length} bytes)");

    // Structure variations:
    // A: salt[0:22] + iv[22:34] + ciphertext+tag[34:]  -- total must be >= 34+16=50 bytes min
    // B: iv[0:12] + salt[12:34] + ciphertext+tag[34:]
    // C: iv[0:12] + ciphertext+tag[12:] (salt = password bytes itself or fixed)
    // D: salt[0:16] + iv[16:28] + ciphertext+tag[28:]

    // These ciphertexts are only 28-30 bytes, meaning plaintext is very short (0-2 bytes after 12 IV + 16 tag = 28)
    // So with structure C: 12 IV + rest = 16-18 bytes of ciphertext+tag
    // GCM tag is 16 bytes, so plaintext would be 0-2 bytes
    // That means these short strings decrypt to 0-2 character strings!

    // Let's try: IV = first 12 bytes, ciphertext+tag = rest (very short plaintext)
    // with PBKDF2 using password as salt or fixed salt
    if (CipherBytes.Length >= 28)
    {
        var Iv12 = new byte[12];
        Array.Copy(CipherBytes, 0, Iv12, 0, 12);
        var Ct = new byte[CipherBytes.Length - 12];
        Array.Copy(CipherBytes, 12, Ct, 0, Ct.Length);

        // Try with password itself as salt
        foreach (var Iters in new[] { 1, 2, 10, 22, 100, 1000, 10000, 65536 })
        {
            try
            {
                var Key = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, PasswordBytes, Iters, HashAlgorithmName.SHA1, 32);
                var Result = TryAesGcm(Ct, Key, Iv12);
                if (Result != null) Console.WriteLine($"  C+pwd-salt iters={Iters}: {Result}");
            }
            catch {}
        }

        // Try with empty salt
        foreach (var Iters in new[] { 1, 22, 1000, 10000, 65536 })
        {
            try
            {
                var EmptySalt = new byte[22];
                var Key = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, EmptySalt, Iters, HashAlgorithmName.SHA1, 32);
                var Result = TryAesGcm(Ct, Key, Iv12);
                if (Result != null) Console.WriteLine($"  C+empty-salt iters={Iters}: {Result}");
            }
            catch {}
        }

        // Try direct key (first 32 bytes of SHA-256(password))
        try
        {
            var Sha256Key = SHA256.Create().ComputeHash(PasswordBytes);
            var Result = TryAesGcm(Ct, Sha256Key, Iv12);
            if (Result != null) Console.WriteLine($"  C+SHA256: {Result}");
        }
        catch {}

        // Try raw password bytes as key
        try
        {
            var Result = TryAesGcm(Ct, PasswordBytes, Iv12);
            if (Result != null) Console.WriteLine($"  C+raw-key: {Result}");
        }
        catch {}
    }

    // Maybe the "22" in bytecode means: first 2 chars are salt-length indicator?
    // Or maybe it's PBKDF2 iterations = 22?
    // Let's try the most common android string obfuscation pattern:
    // Entire hex -> bytes, then XOR with key
    {
        var Xored = new byte[CipherBytes.Length];
        for (var I = 0; I < CipherBytes.Length; I++)
            Xored[I] = (byte)(CipherBytes[I] ^ PasswordBytes[I % PasswordBytes.Length]);
        var S = Encoding.UTF8.GetString(Xored);
        if (IsPrintable(S)) Console.WriteLine($"  XOR: {S}");
    }

    // Simple DES with first 8 bytes of password
    if (CipherBytes.Length % 8 == 0)
    {
        try
        {
            var DesKey = new byte[8];
            Array.Copy(PasswordBytes, 0, DesKey, 0, 8);
            var Des = System.Security.Cryptography.DES.Create();
            Des.Key = DesKey; Des.Mode = CipherMode.ECB; Des.Padding = PaddingMode.PKCS7;
            var Dec = Des.CreateDecryptor();
            var Plain = Dec.TransformFinalBlock(CipherBytes, 0, CipherBytes.Length);
            var S = Encoding.UTF8.GetString(Plain);
            if (IsPrintable(S)) Console.WriteLine($"  DES/ECB: {S}");
        }
        catch {}
    }

    // AES-CBC with password bytes, IV = first 16 bytes
    if (CipherBytes.Length > 16 && (CipherBytes.Length - 16) % 16 == 0)
    {
        try
        {
            var Iv16 = new byte[16];
            Array.Copy(CipherBytes, 0, Iv16, 0, 16);
            var Ct16 = new byte[CipherBytes.Length - 16];
            Array.Copy(CipherBytes, 16, Ct16, 0, Ct16.Length);
            var Aes = System.Security.Cryptography.Aes.Create();
            Aes.Key = PasswordBytes; Aes.IV = Iv16; Aes.Mode = CipherMode.CBC; Aes.Padding = PaddingMode.PKCS7;
            var Dec = Aes.CreateDecryptor();
            var Plain = Dec.TransformFinalBlock(Ct16, 0, Ct16.Length);
            var S = Encoding.UTF8.GetString(Plain);
            if (IsPrintable(S)) Console.WriteLine($"  AES-CBC: {S}");
        }
        catch {}
    }

    // AES-ECB
    if (CipherBytes.Length % 16 == 0)
    {
        try
        {
            var Aes = System.Security.Cryptography.Aes.Create();
            Aes.Key = PasswordBytes; Aes.Mode = CipherMode.ECB; Aes.Padding = PaddingMode.PKCS7;
            var Dec = Aes.CreateDecryptor();
            var Plain = Dec.TransformFinalBlock(CipherBytes, 0, CipherBytes.Length);
            var S = Encoding.UTF8.GetString(Plain);
            if (IsPrintable(S)) Console.WriteLine($"  AES-ECB: {S}");
        }
        catch {}
    }
}

Console.WriteLine("\nDone.");

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

static string TryAesGcm(byte[] CipherTextWithTag, byte[] Key, byte[] Nonce)
{
    try
    {
        if (Key.Length != 16 && Key.Length != 24 && Key.Length != 32) return null;
        if (CipherTextWithTag.Length < 16) return null;
        var TagSize = 16;
        var CipherLen = CipherTextWithTag.Length - TagSize;
        if (CipherLen < 0) return null;
        var Cipher = new byte[CipherLen];
        var Tag = new byte[TagSize];
        Array.Copy(CipherTextWithTag, 0, Cipher, 0, CipherLen);
        Array.Copy(CipherTextWithTag, CipherLen, Tag, 0, TagSize);
        var Plain = new byte[CipherLen];
        var Gcm = new AesGcm(Key, TagSize);
        Gcm.Decrypt(Nonce, Cipher, Tag, Plain);
        var S = Encoding.UTF8.GetString(Plain);
        return IsPrintable(S) ? S : null;
    }
    catch { return null; }
}

static bool IsPrintable(string S)
{
    if (string.IsNullOrEmpty(S)) return true; // empty is valid for 0-length plaintext
    foreach (var C in S)
    {
        if (C < 0x20 && C != '\n' && C != '\r' && C != '\t') return false;
    }
    return true;
}
