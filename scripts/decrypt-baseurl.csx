using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new[]
{
    ("baseUrl1", "de095734a7aa9b1fbcee7ca023b243564227308cfce3f10d24a679514a482330155cd7d5842a484c5b339fd35243949298cf44013fb1"),
    ("baseUrl2", "273288ab896283d85534fd9864dad8476130a65b66d54ec171868c38bc1448e61c9536efc71b4b48b6de4e489394be6d99372c95c2f45004901cce"),
};

foreach (var (Label, Hex) in Strings)
{
    var Data = Convert.FromHexString(Hex);
    var Iv = new byte[12]; Array.Copy(Data, 0, Iv, 0, 12);
    var Ct = new byte[Data.Length - 12 - 16]; Array.Copy(Data, 12, Ct, 0, Ct.Length);
    var Tag = new byte[16]; Array.Copy(Data, Data.Length - 16, Tag, 0, 16);
    var Gcm = new AesGcm(Key, 16);
    var Plain = new byte[Ct.Length];
    Gcm.Decrypt(Iv, Ct, Tag, Plain);
    Console.WriteLine(Label + " = " + System.Text.Encoding.UTF8.GetString(Plain));
}
