using System.Security.Cryptography;

var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["LOG_MERCHANT_API_KEY"] = "2495f9eba1d36b35fdfbf16294efdfed4e8f5641a0885f0756a8312058a9edc5623815ce2cbe7e634e67cae441ed",
    ["PREF_ACCESS_TOKEN"] = "4f61a9f479b093e2b20188beed33171c64b1b57f98b5be6aceae51c1f38d336095af4fb1bf305754bb92a5a1",
    ["LOG_MERCHANT_ID"] = "ea519d7361bca4b27132865da4a96ed8b49d67957846da205af97b9d3909",
    ["PREF_DEVICE_AUTH_PUB_KID"] = "76b3676207bf0b1a986660e12acdae1dfa9767c2d19ef95143760f0181492181a475a970a2514bdad4846814e7f741a298",
    ["PREF_DEVICE_ENC_PUB_KEY"] = "1559608c7285060b0f3634f2f095c5cb3410ed29124ab45e113c44d254f74f7c6c801b0f67ca1691f6e7f0be1704637e",
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
        Console.WriteLine(Kv.Key + " = " + System.Text.Encoding.UTF8.GetString(Plain));
    }
    catch (Exception Ex)
    {
        Console.WriteLine(Kv.Key + " FAILED: " + Ex.Message);
    }
}
