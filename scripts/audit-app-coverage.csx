using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var WasmDir = @"C:\work\prtask.com\src\PocketPay.Wasm\Decompiled";

var Zip = ZipFile.OpenRead(ApkPath);
var AppClasses = 0;
var SystemClasses = 0;

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
    var TypeIdsSize = BitConverter.ToInt32(Dex, 64);
    var TypeIdsOff = BitConverter.ToInt32(Dex, 68);
    var ClassDefsSize = BitConverter.ToInt32(Dex, 96);
    var ClassDefsOff = BitConverter.ToInt32(Dex, 100);

    var Strings = new string[StringIdsSize];
    for (var I = 0; I < StringIdsSize; I++)
    {
        var Off = BitConverter.ToInt32(Dex, StringIdsOff + (I * 4));
        var Pos = Off;
        while (Pos < Dex.Length && (Dex[Pos] & 0x80) != 0) Pos++;
        Pos++;
        var Sb = new System.Text.StringBuilder();
        while (Pos < Dex.Length && Dex[Pos] != 0) { Sb.Append((char)Dex[Pos]); Pos++; }
        Strings[I] = Sb.ToString();
    }

    for (var I = 0; I < ClassDefsSize; I++)
    {
        var ClassIdx = BitConverter.ToInt32(Dex, ClassDefsOff + (I * 32));
        var DescIdx = BitConverter.ToInt32(Dex, TypeIdsOff + (ClassIdx * 4));
        var Desc = DescIdx < Strings.Length ? Strings[DescIdx] : "";
        var Name = Desc.Replace('/', '.').TrimStart('L').TrimEnd(';');

        var IsSystem = Name.StartsWith("android.") || Name.StartsWith("java.") || Name.StartsWith("javax.") ||
            Name.StartsWith("kotlin.") || Name.StartsWith("kotlinx.") || Name.StartsWith("androidx.") ||
            Name.StartsWith("com.google.") || Name.StartsWith("okhttp3.") || Name.StartsWith("okio.") ||
            Name.StartsWith("retrofit2.") || Name.StartsWith("dagger.") || Name.StartsWith("io.reactivex.") ||
            Name.StartsWith("com.squareup.") || Name.StartsWith("org.bouncycastle.") ||
            Name.StartsWith("org.conscrypt.") || Name.StartsWith("org.json.") || Name.StartsWith("dalvik.");

        if (IsSystem) SystemClasses++;
        else AppClasses++;
    }
}

var DecompiledFiles = Directory.GetFiles(WasmDir, "*.cs", SearchOption.AllDirectories).Length;
var ServerFiles = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(WasmDir), "PocketPay.Wasm.Server"), "*.cs", SearchOption.AllDirectories).Length;
var AssetFiles = Directory.Exists(Path.Combine(Path.GetDirectoryName(WasmDir), "wwwroot", "assets"))
    ? Directory.GetFiles(Path.Combine(Path.GetDirectoryName(WasmDir), "wwwroot", "assets"), "*", SearchOption.AllDirectories).Length : 0;

Console.WriteLine($"=== APP CLASS COVERAGE ===");
Console.WriteLine($"Total classes in APK:  {AppClasses + SystemClasses}");
Console.WriteLine($"System classes:        {SystemClasses} (excluded by design)");
Console.WriteLine($"App classes:           {AppClasses}");
Console.WriteLine($"Decompiled files:      {DecompiledFiles}");
Console.WriteLine($"App coverage:          {(DecompiledFiles * 100.0 / AppClasses):F1}%");
Console.WriteLine($"Server files:          {ServerFiles}");
Console.WriteLine($"Assets copied:         {AssetFiles}");

Zip.Dispose();
