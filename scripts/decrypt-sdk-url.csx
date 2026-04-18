using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["SDK getUrl (2C2P base)"] = "cd6624262b687510ee4fa64ca52935b63d72589fcd67b1a4b6c11f90393c60560a260eaab02f724cf4090631473b261a7234e6a57d2255fa3645421de8",
    ["SDK getUrlPin"] = "e6fffba35249256b1fc024c4bef8988cc7daeb7408d7b92523aa777d20dc59525982aba7e242f9dda78f7fc6d73fd84a6a161da9fcc413c4bbb3dc2da6",
    ["SDK getPulsarTestBaseUrl"] = "99456fdf4f91a3e35a82d7e5bcf0d3dd5774ec81be100d7506fd9458202830ac8861caaa770584805be461ac566fe05c9c2e579df04b797bb1e421",
    ["SDK getUserAgent"] = "7a9ade94c4f0a6f888c779f0adb0e218653a1b37c6d95561b61668851ae9ba129a8e83400902f2826c8ab3676b63bd688bcb",
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
    catch (Exception Ex)
    {
        Console.WriteLine($"{Kv.Key}: ERROR - {Ex.Message}");
    }
}
