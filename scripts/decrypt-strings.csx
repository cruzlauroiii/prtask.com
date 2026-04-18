using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Samples = new[] { "6ac56c1f6eeb1db9b1148e85ece92c6b6ebfcd279e95e826388e85dad28232480245d124e286d4397dbce2", "78335b7d52bb1f72709eb891b9c1582322e220c17169efa46e4e12a0f11ac808bf3ebe78e6cb", "e7f633d9be279098f5d2f792355786e7bcde5a9a6c2a98a7ad0188b7959e503d1a6327e010354e9492dbcf0d89c9d4812", "04e9fad57aef65d04a9def454f8295ceb46431b0adce76677c0f7bbe6aa477406c", "48e7d385e5e0d6b01ff730d377515783e514216cc5226a035ed4b4ff5a04575f9d775f" };
int[] SaltLengths = { 8, 16, 22, 32 };
int[] IvLengths = { 12, 16 };
int[] Iterations = { 1, 100, 1000, 10000, 65536 };
foreach (var Sample in Samples) {
    var Data = Convert.FromHexString(Sample);
    Console.WriteLine("Input " + Data.Length + "B: " + Sample.Substring(0, Math.Min(40, Sample.Length)));
    foreach (var SaltLen in SaltLengths) foreach (var IvLen in IvLengths) foreach (var Iter in Iterations) {
        if (SaltLen + IvLen + 16 >= Data.Length) continue;
        try {
            var Salt = new byte[SaltLen]; Array.Copy(Data, 0, Salt, 0, SaltLen);
            var Iv = new byte[IvLen]; Array.Copy(Data, SaltLen, Iv, 0, IvLen);
            var CtLen = Data.Length - SaltLen - IvLen - 16; if (CtLen <= 0) continue;
            var Ct = new byte[CtLen]; Array.Copy(Data, SaltLen + IvLen, Ct, 0, CtLen);
            var Tag = new byte[16]; Array.Copy(Data, Data.Length - 16, Tag, 0, 16);
            using var Kdf = new Rfc2898DeriveBytes(Password, Salt, Iter, HashAlgorithmName.SHA1);
            var Key = Kdf.GetBytes(32);
            using var Aes = new AesGcm(Key, 16);
            var Plain = new byte[CtLen];
            Aes.Decrypt(Iv, Ct, Tag, Plain);
            var Text = System.Text.Encoding.UTF8.GetString(Plain);
            if (Text.Length > 0 && !Text.Any(c => c < 32 || c > 126))
                Console.WriteLine("  OK salt=" + SaltLen + " iv=" + IvLen + " iter=" + Iter + ": " + Text);
        } catch {} }
    Console.WriteLine();
}