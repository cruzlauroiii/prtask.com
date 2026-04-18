using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PB = Encoding.UTF8.GetBytes(Password);

// Test with strings of various lengths from classes11.dex
var Samples = new[]
{
    "75a1156ce6eb5ea817505ce0f31250a58f735a4d8651764b94e7dc3245", // 29 bytes
    "000dabdc674aff185f51ff01bc3b3be66eb6c8227660143a579354490a75", // 30 bytes
    "ead206fd275ea5139156bd5a6a85d9f057893a2c08bb5f30a2cacc6880635f", // 31 bytes
    "c360662d3f7add52dfc68a497e5432b14b9e759b31235eba042c0f9ce208dd1f", // 32 bytes
    "b999df6b6918be661dd334941933d7296914853f44b949ceb5c7fda6a4a3e3e71b", // 33 bytes
    "ea241aca7a55eb2b5c55ec731179b28a6c4dafe9e86a2c38558a5bccd9e1817730d940", // 35 bytes
    "3bfc15b1aeba55bf8b3abe85013d96b9e559c5c95b55af3096bd57349d9cfcafc8d69ad2d080351b", // 40 bytes
};

// From decipher bytecode:
// v8 = input hex string
// v8 = toByte(v8)  -> byte array
// const v0, #12  -> IV is 12 bytes
// The structure from PBEKeySpec and GCMParameterSpec:
//   PBEKeySpec(char[] password, byte[] salt, int iterations, int keyLength)
//   GCMParameterSpec(int tagLen, byte[] iv)

// But maybe: NO PBKDF2. The code creates PBEKeySpec then gets SecretKeyFactory,
// generates secret, gets encoded bytes - those become the AES key.
// But ALSO creates SecretKeySpec directly with the password bytes!
// Maybe there are two paths and the packed-switch selects one.

// Let me try: direct AES-GCM with password bytes as key, various IV positions
foreach (var Hex in Samples)
{
    var D = Convert.FromHexString(Hex);
    Console.WriteLine($"\n{Hex.Substring(0, 40)}... ({D.Length}B)");

    // Try: IV at start, rest is ciphertext+tag
    for (var IvLen = 12; IvLen <= 16; IvLen += 4)
    {
        if (D.Length < IvLen + 16) continue;
        var Iv = D[..IvLen];
        var Rest = D[IvLen..];
        var Tag = Rest[^16..];
        var Ct = Rest[..^16];
        try
        {
            var P = new byte[Ct.Length];
            new AesGcm(PB, 16).Decrypt(Iv[..12], Ct, Tag, P);
            Console.WriteLine($"  Direct key, IV[0:{IvLen}]: \"{Encoding.UTF8.GetString(P)}\"");
        }
        catch {}

        // Also try with SHA-256 of password
        try
        {
            var Sha = SHA256.Create().ComputeHash(PB);
            var P = new byte[Ct.Length];
            new AesGcm(Sha, 16).Decrypt(Iv[..12], Ct, Tag, P);
            Console.WriteLine($"  SHA256 key, IV[0:{IvLen}]: \"{Encoding.UTF8.GetString(P)}\"");
        }
        catch {}

        // Try MD5 for AES-128
        try
        {
            var Md5 = MD5.Create().ComputeHash(PB);
            var P = new byte[Ct.Length];
            new AesGcm(Md5, 16).Decrypt(Iv[..12], Ct, Tag, P);
            Console.WriteLine($"  MD5 key, IV[0:{IvLen}]: \"{Encoding.UTF8.GetString(P)}\"");
        }
        catch {}
    }

    // Try: No IV from ciphertext, IV = first 12 bytes of password or zeros
    {
        var Tag = D[^16..];
        var Ct = D[..^16];
        try
        {
            var P = new byte[Ct.Length];
            new AesGcm(PB, 16).Decrypt(PB[..12], Ct, Tag, P);
            Console.WriteLine($"  Direct key, IV=pwd[0:12]: \"{Encoding.UTF8.GetString(P)}\"");
        }
        catch {}
        try
        {
            var P = new byte[Ct.Length];
            new AesGcm(PB, 16).Decrypt(new byte[12], Ct, Tag, P);
            Console.WriteLine($"  Direct key, IV=zeros: \"{Encoding.UTF8.GetString(P)}\"");
        }
        catch {}
    }

    // Try AES-CBC (maybe the GCM is a red herring from obfuscation)
    if ((D.Length - 16) % 16 == 0 && D.Length > 16)
    {
        try
        {
            var Aes = System.Security.Cryptography.Aes.Create();
            Aes.Key = PB; Aes.IV = D[..16]; Aes.Mode = CipherMode.CBC; Aes.Padding = PaddingMode.PKCS7;
            var Dec = Aes.CreateDecryptor();
            var P = Dec.TransformFinalBlock(D, 16, D.Length - 16);
            var S = Encoding.UTF8.GetString(P);
            if (S.All(C => C >= 0x20 || C == '\n' || C == '\r' || C == '\t'))
                Console.WriteLine($"  AES-CBC, IV[0:16]: \"{S}\"");
        }
        catch {}
    }

    // Try AES-ECB
    if (D.Length % 16 == 0)
    {
        try
        {
            var Aes = System.Security.Cryptography.Aes.Create();
            Aes.Key = PB; Aes.Mode = CipherMode.ECB; Aes.Padding = PaddingMode.PKCS7;
            var Dec = Aes.CreateDecryptor();
            var P = Dec.TransformFinalBlock(D, 0, D.Length);
            var S = Encoding.UTF8.GetString(P);
            if (S.All(C => C >= 0x20 || C == '\n' || C == '\r' || C == '\t'))
                Console.WriteLine($"  AES-ECB: \"{S}\"");
        }
        catch {}
    }

    // Try 3DES
    if (D.Length % 8 == 0)
    {
        try
        {
            var Tdes = TripleDES.Create();
            Tdes.Key = PB[..24]; Tdes.Mode = CipherMode.ECB; Tdes.Padding = PaddingMode.PKCS7;
            var Dec = Tdes.CreateDecryptor();
            var P = Dec.TransformFinalBlock(D, 0, D.Length);
            var S = Encoding.UTF8.GetString(P);
            if (S.All(C => C >= 0x20 || C == '\n' || C == '\r' || C == '\t'))
                Console.WriteLine($"  3DES-ECB: \"{S}\"");
        }
        catch {}
    }

    // Try XOR with repeating key
    {
        var X = new byte[D.Length];
        for (var I = 0; I < D.Length; I++) X[I] = (byte)(D[I] ^ PB[I % PB.Length]);
        var S = Encoding.UTF8.GetString(X);
        if (S.All(C => C >= 0x20 && C <= 0x7E))
            Console.WriteLine($"  XOR: \"{S}\"");
    }
}

Console.WriteLine("\nDone.");
