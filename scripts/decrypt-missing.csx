using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["Authorization header name"] = "54e48780062fa42132cf792cae13e8039c0ef7bff8030912df3bb287665ea147c645485c56ee074196",
    ["Additional header"] = "993b62855f6d89aa12850f7aacec670cb7d69a68ee40246f98b89935f8b057d5a19f6a0fd5b8",
    ["fe2d93295 value"] = "9208c189206ed8e3ebb9ad109ad7ab33f5ac23f335fac118f6030d4a2426351e52731fe22a4c894ea802753c0bd61e69dd95deb021cb403b1cd94a7b6bf612f4f8a4aa94d16ec971e53adb",
};

foreach (var Kv in Strings)
{
    try
    {
        var Data = Convert.FromHexString(Kv.Value);
        var Iv = new byte[12]; Array.Copy(Data, 0, Iv, 0, 12);
        var Ct = new byte[Data.Length - 12 - 16]; Array.Copy(Data, 12, Ct, 0, Ct.Length);
        var Tag = new byte[16]; Array.Copy(Data, Data.Length - 16, Tag, 0, 16);
        var Gcm = new AesGcm(Key, 16);
        var Plain = new byte[Ct.Length];
        Gcm.Decrypt(Iv, Ct, Tag, Plain);
        Console.WriteLine($"{Kv.Key}: {System.Text.Encoding.UTF8.GetString(Plain)}");
    }
    catch (Exception Ex) { Console.WriteLine($"{Kv.Key}: ERROR - {Ex.Message}"); }
}
