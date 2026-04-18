#!/usr/bin/env dotnet-script

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

// === CRACKED PARAMETERS ===
// Algorithm: AES/GCM/NoPadding
// Key derivation: PBKDF2WithHmacSHA1
// Password: "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg" (UTF-8 encoded)
// Salt: password bytes themselves (UTF-8)
// Iterations: 128
// Key length: 256 bits
// GCM tag: 128 bits (16 bytes)
// Data format: [IV 12 bytes][ciphertext N bytes][tag 16 bytes]

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var PwdUtf8 = Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(PwdUtf8, PwdUtf8, 128, HashAlgorithmName.SHA1, 32);

Console.WriteLine("=== PocketPay DecryptString Decryptor ===");
Console.WriteLine($"Key: {BitConverter.ToString(Key)}");
Console.WriteLine();

byte[] HexToBytes(string hex) =>
    Enumerable.Range(0, hex.Length / 2).Select(i => Convert.ToByte(hex.Substring(i * 2, 2), 16)).ToArray();

string Decrypt(string hex)
{
    var data = HexToBytes(hex);
    var iv = data[..12];
    var ct = data[12..^16];
    var tag = data[^16..];
    var plain = new byte[ct.Length];
    using var aes = new AesGcm(Key, 16);
    aes.Decrypt(iv, ct, tag, plain);
    return Encoding.UTF8.GetString(plain);
}

var Samples = new Dictionary<string, string>
{
    ["visa1_29b"] = "eeff43bf3b6fbf44db4638071c443f812ed8fc20db53b4daf01308eb3e",
    ["visa2_29b"] = "92fcdb0094711ad4d5106ef4235417633e8b2a1bbb04312d3368399adb",
    ["visa3_29b"] = "1a80035cbf405cebce18c0cbfc4c3ee0208e5b16b869ed90a07483f80d",
    ["visa4_29b"] = "660c28f2842fd442809fc41a47ad2f3b46c4be33952a20604e564963f9",
    ["visa5_29b"] = "6766ca8fa0ae50ff83ec9b71debd3929c434023c9e638e5288f7dbc78a",
    ["visa6_29b"] = "81e58fa8bf19576b805ca7bd78bddbb4025f87b139e5bb49944de52fdf",
    ["pay1_29b"] = "d08c2ebe22c38f14531e73084529fbed2c50e8a03cba3ce6e5c2d51932",
    ["pay2_29b"] = "7bfc92c3920bb30fb767cf4fa3f120d7af539e60a386048c9e90538680",
    ["pay3_29b"] = "9d6bf616c7a85e53c4866c9cf2fadb20ed0f3312e7a9c4ad5d947ea6dc",
    ["pay4_29b"] = "79556ae9859031853f808c59d700798a42a84b94908a3e2722e455fb5b",
    ["pay5_29b"] = "ab928934b4d466adfc61b0a40234b07a9497a22e155ff1d7713aeeca4f",
    ["pay6_30b"] = "f06280576b31eda5d73c4b8541a059b235a2fe730ecab32a002d469686d9",
    ["pay7_30b"] = "334cf95041a39002766527dc45b115c06c589d9d822a91d1a4c10b4873e5",
    ["pay8_30b"] = "1a70558739fdce69f8494bffb31ad779161d2b494b38bfff55eeff07de66",
    ["pay9_30b"] = "e9995935720383ce03360de59813ffd6dfdd89f805667581285ae5924de5",
    ["emv_big_47b"] = "021085E2755381DCCCE3C1557AFA10C2F0C0C2825646C5B34A394CBCFA8BC16B22E7E789E927BE216F02E1FB136A5F",
    ["emv_30b"] = "6A941977BA9F6A435199ACFC51067ED587F519C5ECB541B8E44111DE1D40",
    ["prompt_43b"] = "6ac56c1f6eeb1db9b1148e85ece92c6b6ebfcd279e95e826388e85dad28232480245d124e286d4397dbce2",
    // Additional from payment classes
    ["f06280"] = "f06280576b31eda5d73c4b8541a059b235a2fe730ecab32a002d469686d9",
    ["a878f0"] = "a878f052915dd8e1d2f732113ce720b72655452ffbbb2881a92cce7f0569",
    ["334cf9"] = "334cf95041a39002766527dc45b115c06c589d9d822a91d1a4c10b4873e5",
    ["1a7055"] = "1a70558739fdce69f8494bffb31ad779161d2b494b38bfff55eeff07de66",
    ["e99959"] = "e9995935720383ce03360de59813ffd6dfdd89f805667581285ae5924de5",
    ["d08c2e"] = "d08c2ebe22c38f14531e73084529fbed2c50e8a03cba3ce6e5c2d51932",
    ["7bfc92"] = "7bfc92c3920bb30fb767cf4fa3f120d7af539e60a386048c9e90538680",
    ["9d6bf6"] = "9d6bf616c7a85e53c4866c9cf2fadb20ed0f3312e7a9c4ad5d947ea6dc",
    ["ab9289"] = "ab928934b4d466adfc61b0a40234b07a9497a22e155ff1d7713aeeca4f",
};

// Deduplicate
var unique = Samples.GroupBy(kv => kv.Value).Select(g => g.First()).ToList();

Console.WriteLine($"Decrypting {unique.Count} unique samples...\n");

int ok = 0, fail = 0;
foreach (var (name, hex) in unique)
{
    try
    {
        var pt = Decrypt(hex);
        ok++;
        Console.WriteLine($"  {name}: \"{pt}\"");
    }
    catch (Exception ex)
    {
        fail++;
        Console.WriteLine($"  {name}: FAILED - {ex.Message}");
    }
}

Console.WriteLine($"\n=== Results: {ok} decrypted, {fail} failed ===");
Console.WriteLine();
Console.WriteLine("=== DECRYPTION PARAMETERS ===");
Console.WriteLine("Algorithm: AES/GCM/NoPadding");
Console.WriteLine("Key derivation: PBKDF2WithHmacSHA1");
Console.WriteLine("Password: HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg");
Console.WriteLine("Salt: password bytes (same as password, UTF-8)");
Console.WriteLine("Iterations: 128");
Console.WriteLine("Key length: 256 bits");
Console.WriteLine("GCM tag length: 128 bits");
Console.WriteLine("Data format: [IV 12 bytes][ciphertext][GCM tag 16 bytes]");
