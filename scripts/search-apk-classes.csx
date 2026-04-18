using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Keywords = new[] { "softpos", "payment", "acquir", "terminal", "kernel", "emv", "cryptogram", "cipher", "encrypt", "nfc", "tap", "DecryptString", "gateway", "banking", "card" };

var Zip = ZipFile.OpenRead(ApkPath);
foreach (var Entry in Zip.Entries.Where(E => E.Name.EndsWith(".dex")))
{
    var Stream = Entry.Open();
    var Ms = new MemoryStream();
    Stream.CopyTo(Ms);
    var Bytes = Ms.ToArray();
    var Text = System.Text.Encoding.UTF8.GetString(Bytes);

    foreach (var Kw in Keywords)
    {
        var Idx = 0;
        while ((Idx = Text.IndexOf(Kw, Idx, StringComparison.OrdinalIgnoreCase)) >= 0)
        {
            var Start = Math.Max(0, Idx - 50);
            var End = Math.Min(Text.Length, Idx + Kw.Length + 50);
            var Context = Text.Substring(Start, End - Start).Replace("\0", ".").Replace("\n", " ").Replace("\r", "");
            if (Context.Contains("com.") || Context.Contains("org.") || Context.Contains("/"))
                Console.WriteLine($"[{Entry.Name}] {Context}");
            Idx += Kw.Length;
        }
    }
}
