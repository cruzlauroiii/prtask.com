using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

foreach (var Kv in new Dictionary<string, string>
{
    ["request path query key"] = "7bc9b5d1eef3e3d6e4460f8c053e8fd7379d266e7409f61cb835e1896c0294192078d7c7cf5ed14a8c",
    ["f6f904400 SHA algo"] = "53734b6b28699bfd863f6e44994c91bc74d15a7e2b845a85ae84dc59a1d9b248c2395b21c5726405f9f16ee27d67653048824f",
})
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
