using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["p06ad009f prefs name 1"] = "8307a0f278e597a0fca1c2f5454f10ea6c8869582b8425e30ba92c63aab2b0dab0f1d6051bc35057ad82f2",
    ["p06ad009f prefs name 2"] = "4c3402fc409b923223209f5044e8f07164e256c7112dea4e95367634afe8f85d1e64aae909e369",
    ["p06ad009f prefs name 3"] = "7e814862264d038e2eebd53d71751c88dc746f96d4cf41c1dbf85aefbf8743116e9c0b658b4f2b",
    ["isActivated key"] = "0df82579efbbf89d876889524e43fae5890ad0b52eba449aadcfef485267473f14fd65aa07f432b30230c6",
    ["pf941ddb7 prefs name"] = "9d8c0ccf2f515ce670fea6bd61d029f6df18108600a11e67f597e746442a1d81563b9782fc0a08",
    ["tapOnPhoneMid"] = "41f5cc14e77fc2c4574a96240b1fec2cae92f6cebf16069713ef3915275b082e7902c69f",
    ["tapOnPhoneTid"] = "79e94a633b702dead90139f887fb1d8b7346c6e722c30a96600012d7cf8f9a610266c5ad",
    ["tapOnPhoneIsQrEnabled"] = "a334cd86334bafb889b30e1d0cf8721fd28f7f9c175bff94b11e4365d28f982ec67af779631db227a693a0e0a791",
    ["tapOnPhoneQrMid"] = "c4edcf5f63fba90dd741d0faec725ca565ef5476404714f5384064ec1627f1c5aaf469f1f7427d",
    ["tapOnPhoneQrTid"] = "7e6df1c57bac234d2b8bd46f0a177156766e5705915c29de03ef96dbbded93da0cf4ff21ccb401",
    ["tapOnPhoneQrName"] = "f49aac733b806813966d794f4faf0a5def4bf9e1ddeed65df9ff9c1da7dc41882e6e675a8b9fca13",
    ["tapOnPhoneQrBannerType"] = "19c8fc2e207422913a499c13f66738347c3b05764a6ed3fd261f472175af608a05ba2f7b85b3e4f72c91325c4927f2",
    ["enum param"] = "bba2c8010b459a172a6def4133ce6929274bd3dc1c024c8312f947688d1dae5a",
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
