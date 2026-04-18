using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);
var DexEntry = Zip.GetEntry("classes.dex");
if (DexEntry is null) { Console.WriteLine("No classes.dex"); return; }

var Stream = DexEntry.Open();
var Ms = new MemoryStream();
Stream.CopyTo(Ms);
var Dex = Ms.ToArray();
Stream.Dispose();

Console.WriteLine($"DEX size: {Dex.Length} bytes");
Console.WriteLine($"Magic: {System.Text.Encoding.ASCII.GetString(Dex, 0, 8)}");

var StringIdsSize = BitConverter.ToInt32(Dex, 56);
var StringIdsOff = BitConverter.ToInt32(Dex, 60);
var TypeIdsSize = BitConverter.ToInt32(Dex, 64);
var TypeIdsOff = BitConverter.ToInt32(Dex, 68);

Console.WriteLine($"String IDs: {StringIdsSize}");
Console.WriteLine($"Type IDs: {TypeIdsSize}");

var TypeNames = new List<string>();
for (var I = 0; I < Math.Min(TypeIdsSize, 500); I++)
{
    var DescIdx = BitConverter.ToInt32(Dex, TypeIdsOff + (I * 4));
    var StringOff = BitConverter.ToInt32(Dex, StringIdsOff + (DescIdx * 4));

    var Pos = StringOff;
    while (Pos < Dex.Length && (Dex[Pos] & 0x80) != 0) Pos++;
    Pos++;

    var Sb = new System.Text.StringBuilder();
    while (Pos < Dex.Length && Dex[Pos] != 0) { Sb.Append((char)Dex[Pos]); Pos++; }
    var Name = Sb.ToString();

    if (Name.StartsWith("L") && !Name.Contains("android/") && !Name.Contains("kotlin/") &&
        !Name.Contains("java/") && !Name.Contains("dalvik/") && !Name.Contains("google/") &&
        !Name.Contains("androidx/") && !Name.Contains("okhttp") && !Name.Contains("retrofit") &&
        !Name.Contains("dagger/") && !Name.Contains("javax/"))
    {
        TypeNames.Add(Name.Replace('/', '.').TrimStart('L').TrimEnd(';'));
    }
}

var Grouped = TypeNames
    .Where(N => !N.Contains("$") && N.Contains("."))
    .GroupBy(N => string.Join(".", N.Split('.').SkipLast(1)))
    .OrderBy(G => G.Key)
    .Take(40);

foreach (var G in Grouped)
{
    Console.WriteLine($"\n{G.Key}/ ({G.Count()} classes)");
    foreach (var C in G.Take(8))
    {
        Console.WriteLine($"  {C.Split('.').Last()}");
    }
    if (G.Count() > 8) Console.WriteLine($"  ... +{G.Count() - 8} more");
}

Zip.Dispose();
