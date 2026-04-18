using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["sendOrder baseUrl"] = "62948502bcd121100d6f33f4a13109760adcb4370557de058652fc0b9003c9a07269522193423c40d697641e3b2e037f0759ca114941f7d8091be404933f0e8eb6e4ec6823335ec363a4a4",
    ["authDevice baseUrl"] = "8ab32d795ee044318f7b130e085850ced8c5160330831ee593bac1b35044985e28e1998ba957645038e0bba640ede7decc8a64699e9e173c82491d217a0c378062ef94",
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
