using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PasswordBytes = Encoding.UTF8.GetBytes(Password);

var Samples = new[]
{
    "eeff43bf3b6fbf44db4638071c443f812ed8fc20db53b4daf01308eb3e",
    "92fcdb0094711ad4d5106ef4235417633e8b2a1bbb04312d3368399adb",
    "7bfc92c3920bb30fb767cf4fa3f120d7af539e60a386048c9e90538680",
    "0d75d30fe467febbee2793a71571fc622c68cc26ea3daf59c0f85d108c7ece3a4e97df8e80618c56fd1b1b51b2",
};

// 29-byte ciphertext: 12 nonce + 1 data + 16 tag = 29
// So with 22 iterations, password as salt source

// The decipher method may use a FIXED salt derived from the password
// Let's try: salt = first 22 bytes of password, or password bytes, or SHA-1(password)
var SaltOptions = new (string Name, byte[] Salt)[]
{
    ("pwd-first-22", PasswordBytes[..22]),
    ("pwd-first-16", PasswordBytes[..16]),
    ("pwd-all-32", PasswordBytes),
    ("sha1-pwd", SHA1.Create().ComputeHash(PasswordBytes)),
    ("sha256-pwd", SHA256.Create().ComputeHash(PasswordBytes)),
    ("empty-8", new byte[8]),
    ("empty-16", new byte[16]),
    ("empty-22", new byte[22]),
};

var IterOptions = new[] { 1, 2, 10, 22, 100, 256, 1000, 10000, 65536, 100000 };

foreach (var Hex in Samples)
{
    var AllBytes = HexToBytes(Hex);
    if (AllBytes == null) continue;
    Console.WriteLine($"\nHex: {Hex} ({AllBytes.Length} bytes)");

    foreach (var (SaltName, Salt) in SaltOptions)
    {
        foreach (var Iters in IterOptions)
        {
            try
            {
                var Key = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, Salt, Iters, HashAlgorithmName.SHA1, 32);

                // Try nonce = first 12 bytes
                var Nonce = new byte[12];
                Array.Copy(AllBytes, 0, Nonce, 0, 12);
                var CtTag = new byte[AllBytes.Length - 12];
                Array.Copy(AllBytes, 12, CtTag, 0, CtTag.Length);

                var Result = TryAesGcm(CtTag, Key, Nonce);
                if (Result != null)
                {
                    Console.WriteLine($"  HIT! salt={SaltName} iters={Iters} nonce=first12: \"{Result}\"");
                    goto NextSample;
                }

                // Try nonce = last 12 bytes
                Array.Copy(AllBytes, AllBytes.Length - 12, Nonce, 0, 12);
                CtTag = new byte[AllBytes.Length - 12];
                Array.Copy(AllBytes, 0, CtTag, 0, CtTag.Length);

                Result = TryAesGcm(CtTag, Key, Nonce);
                if (Result != null)
                {
                    Console.WriteLine($"  HIT! salt={SaltName} iters={Iters} nonce=last12: \"{Result}\"");
                    goto NextSample;
                }
            }
            catch {}
        }
    }

    // Also try: FIRST byte is salt length? e.g. if AllBytes[0] tells us how many subsequent bytes are salt
    for (var SaltLen = 1; SaltLen <= Math.Min(20, AllBytes.Length - 28); SaltLen++)
    {
        var Salt = new byte[SaltLen];
        Array.Copy(AllBytes, 0, Salt, 0, SaltLen);
        var Nonce = new byte[12];
        Array.Copy(AllBytes, SaltLen, Nonce, 0, 12);
        var CtTag = new byte[AllBytes.Length - SaltLen - 12];
        Array.Copy(AllBytes, SaltLen + 12, CtTag, 0, CtTag.Length);

        foreach (var Iters in new[] { 1, 22, 100, 1000, 10000, 65536 })
        {
            try
            {
                var Key = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, Salt, Iters, HashAlgorithmName.SHA1, 32);
                var Result = TryAesGcm(CtTag, Key, Nonce);
                if (Result != null)
                {
                    Console.WriteLine($"  HIT! inline-salt[0:{SaltLen}] iters={Iters}: \"{Result}\"");
                    goto NextSample;
                }
            }
            catch {}
        }
    }

    // Try: nonce from first 12, salt from next N, rest is ct+tag
    for (var SaltLen = 1; SaltLen <= Math.Min(20, AllBytes.Length - 28); SaltLen++)
    {
        var Nonce = new byte[12];
        Array.Copy(AllBytes, 0, Nonce, 0, 12);
        var Salt = new byte[SaltLen];
        Array.Copy(AllBytes, 12, Salt, 0, SaltLen);
        var CtTag = new byte[AllBytes.Length - 12 - SaltLen];
        Array.Copy(AllBytes, 12 + SaltLen, CtTag, 0, CtTag.Length);

        foreach (var Iters in new[] { 1, 22, 100, 1000, 10000, 65536 })
        {
            try
            {
                var Key = Rfc2898DeriveBytes.Pbkdf2(PasswordBytes, Salt, Iters, HashAlgorithmName.SHA1, 32);
                var Result = TryAesGcm(CtTag, Key, Nonce);
                if (Result != null)
                {
                    Console.WriteLine($"  HIT! nonce[0:12]+salt[12:{12+SaltLen}] iters={Iters}: \"{Result}\"");
                    goto NextSample;
                }
            }
            catch {}
        }
    }

    Console.WriteLine("  No match found.");
    NextSample:;
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
        var S = CipherLen > 0 ? Encoding.UTF8.GetString(Plain) : "";
        return S; // return even empty strings
    }
    catch { return null; }
}
