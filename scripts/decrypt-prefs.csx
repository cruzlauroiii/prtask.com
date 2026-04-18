using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["SharedPrefs name 1"] = "7e814862264d038e2eebd53d71751c88dc746f96d4cf41c1dbf85aefbf8743116e9c0b658b4f2b",
    ["SharedPrefs name 2"] = "61f2244c9eff157ecb2884284ac69af74997c5b310d1b868b237e9dec306b70abe0cdef9a4c78b",
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
