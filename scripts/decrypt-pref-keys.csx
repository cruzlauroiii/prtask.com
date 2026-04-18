using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["field 1"] = "25e222c31ae5b8e08e58cff8e1d317b2c4d3de22b5051df8e9a18a8b07824cda0986173c401c151adb6febf534",
    ["field 2"] = "93b7b5d111a53a753255a5d46d2c56e8d20d6907de0ddfa196f7435117898c24f5f00a027a87ec",
    ["property name"] = "30a7df1205e6044386f6d4824906a882c218b117ca02260a90b4dfd9af9be778770ea50a3c2d5302a5",
    ["property type"] = "34a3c3b568e5b7ee6b969399a9c9c5adb27aa2fb93913b0a04903a5714f07c6402f67422b188a0a1a7b3fb90",
    ["isShowNfcSpot key"] = "d7d595c8d09d99436dbc972a99eedc271b1ca225d759ab2df68876c25b52b8fbe92b5f09511205f86bb059d93a",
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
