using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Salt = System.Text.Encoding.UTF8.GetBytes(Password);
var Key = Rfc2898DeriveBytes.Pbkdf2(Password, Salt, 128, HashAlgorithmName.SHA1, 32);

var Strings = new Dictionary<string, string>
{
    ["getBaseUrl PROD"] = "de095734a7aa9b1fbcee7ca023b243564227308cfce3f10d24a679514a482330155cd7d5842a484c5b339fd35243949298cf44013fb1",
    ["getBaseUrl TEST"] = "273288ab896283d85534fd9864dad8476130a65b66d54ec171868c38bc1448e61c9536efc71b4b48b6de4e489394be6d99372c95c2f45004901cce",
    ["getGCashUrl PROD"] = "a06a4bb90b0e77529a48fdc201fe39b0de41fcf5dc5c18f9460fe644bbffcc5d5dd2cc85fc5e86ef5fe386c0046b4d57e64996f4e98a0a",
    ["getGCashUrl TEST"] = "85b247a60ec438396973b0f978bdca136ac153ba887ccdee5b7ed11ae12cf33c6090f941012cecfdc85061395999f49951ce90c4e61b14499f1a24",
    ["getMarketBaseUrl PROD"] = "2bc866757a521faf40742fedde6ac1529bdfb36e8adcf9eb8aef09eaee271b2e7545a71c3fe97b6cf3cbd322bf19aeee4b7522",
    ["getMarketBaseUrl TEST"] = "312f8c473a1e76e8865d95b1ab5dea0725a15e94946cf1beeb96a53436d1686b6e333eebc5fd8252a6b2ec53d1cb2d3a1dcf4bdb295cf6f5",
    ["getPsrUrl PROD"] = "cfd984763867a43a0987f00da1fb4ff6f701bbd3a90a89b5b6b0ae63bdc1859daa1c20b7a0a6383a8ca55ecd9e8e7d",
    ["getPsrUrl TEST"] = "c6ab80b5cbd5126c4ca3d7889c78ee2a5184a3b40dc1341ee529b92981474cc5b5f142029bb4d0503b2515aac145943b5755219c",
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
