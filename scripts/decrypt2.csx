using System.Security.Cryptography;
var Password = "HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg";
var Key = System.Text.Encoding.UTF8.GetBytes(Password);
var Samples = new[] { "6ac56c1f6eeb1db9b1148e85ece92c6b6ebfcd279e95e826388e85dad28232480245d124e286d4397dbce2", "78335b7d52bb1f72709eb891b9c1582322e220c17169efa46e4e12a0f11ac808bf3ebe78e6cb", "04e9fad57aef65d04a9def454f8295ceb46431b0adce76677c0f7bbe6aa477406c" };
foreach (var Sample in Samples) {
    var Data = Convert.FromHexString(Sample);
    Console.WriteLine("Input " + Data.Length + "B");
    foreach (var IvLen in new[] { 12, 16 }) {
        if (IvLen + 16 >= Data.Length) continue;
        try {
            var Iv = new byte[IvLen]; Array.Copy(Data, 0, Iv, 0, IvLen);
            var CtLen = Data.Length - IvLen - 16; if (CtLen <= 0) continue;
            var Ct = new byte[CtLen]; Array.Copy(Data, IvLen, Ct, 0, CtLen);
            var Tag = new byte[16]; Array.Copy(Data, Data.Length - 16, Tag, 0, 16);
            using var Aes = new AesGcm(Key, 16);
            var Plain = new byte[CtLen];
            Aes.Decrypt(Iv, Ct, Tag, Plain);
            var Text = System.Text.Encoding.UTF8.GetString(Plain);
            if (Text.Length > 0 && !Text.Any(c => c < 32 || c > 126))
                Console.WriteLine("  DECRYPTED iv=" + IvLen + ": " + Text);
        } catch {} }
    Console.WriteLine();
}