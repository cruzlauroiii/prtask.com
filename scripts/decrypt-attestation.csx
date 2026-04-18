using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["activation complete"] = "93e56be46465d73b026838a6d992f8c83fbb11c4179d9c2ecadf69308d234e22",
    ["confirm complete"] = "0fa7d9bca3526294969acb41e542b3cc7d3ed80b72a61fa9d88f2d8804a72c31",
    ["to attested mode"] = "1260aaf82fdad9448ca90d39d12d0aa8e773a9888c8d83545053a3b573fa910e",
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
