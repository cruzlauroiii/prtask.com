using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);

foreach (var Entry in Zip.Entries)
{
    if (!Entry.Name.EndsWith(".dex")) continue;
    var Stream = Entry.Open();
    var Ms = new MemoryStream();
    Stream.CopyTo(Ms);
    var Dex = Ms.ToArray();
    Stream.Dispose();
    if (Dex.Length < 112) continue;

    var StringIdsSize = BitConverter.ToInt32(Dex, 56);
    var StringIdsOff = BitConverter.ToInt32(Dex, 60);

    for (var I = 0; I < StringIdsSize; I++)
    {
        var Off = BitConverter.ToInt32(Dex, StringIdsOff + (I * 4));
        var Pos = Off;
        while (Pos < Dex.Length && (Dex[Pos] & 0x80) != 0) Pos++;
        Pos++;
        var Sb = new System.Text.StringBuilder();
        while (Pos < Dex.Length && Dex[Pos] != 0 && Sb.Length < 300) { Sb.Append((char)Dex[Pos]); Pos++; }
        var Str = Sb.ToString();

        if ((Str.Contains("https://") || Str.Contains("http://")) &&
            !Str.Contains("schemas.android") && !Str.Contains("xmlpull") &&
            !Str.Contains("w3.org") && !Str.Contains("apache.org") &&
            !Str.Contains("google.com") && !Str.Contains("googleapis") &&
            !Str.Contains("gstatic") && !Str.Contains("android.com") &&
            !Str.Contains("mozilla.org") && !Str.Contains("example.") &&
            !Str.Contains("github.com") && !Str.Contains("localhost") &&
            !Str.Contains("play.google"))
        {
            Console.WriteLine($"[{Entry.Name}] {Str}");
        }
    }
}

Zip.Dispose();
