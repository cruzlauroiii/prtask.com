using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);

var Count = 0;
foreach (var E in Zip.Entries)
{
    if (!E.FullName.StartsWith("res/layout/fragment_tap_on_phone") &&
        !E.FullName.StartsWith("res/layout/fragment_launcher") &&
        !E.FullName.StartsWith("res/layout/fragment_sell_receipt_choose"))
        continue;
    if (!E.Name.EndsWith(".xml")) continue;

    var Stream = E.Open();
    var Ms = new MemoryStream();
    Stream.CopyTo(Ms);
    var Bytes = Ms.ToArray();
    Stream.Dispose();

    Console.WriteLine($"{E.FullName} ({Bytes.Length} bytes)");
    Console.WriteLine($"  First 16 bytes: {BitConverter.ToString(Bytes, 0, Math.Min(16, Bytes.Length))}");
    Console.WriteLine($"  Magic u32: 0x{BitConverter.ToUInt32(Bytes, 0):X8}");
    Console.WriteLine($"  Magic u16: 0x{BitConverter.ToUInt16(Bytes, 0):X4}");

    if (Bytes.Length > 4)
    {
        var AsText = System.Text.Encoding.UTF8.GetString(Bytes, 0, Math.Min(100, Bytes.Length));
        if (AsText.StartsWith("<?xml") || AsText.StartsWith("<"))
            Console.WriteLine($"  Looks like TEXT XML: {AsText.Substring(0, Math.Min(80, AsText.Length))}");
        else
            Console.WriteLine($"  Binary format");
    }

    Count++;
    if (Count >= 5) break;
}

Zip.Dispose();
