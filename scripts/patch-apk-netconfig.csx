using System.IO.Compression;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var PatchedPath = @"C:\work\pocketpay-apk\base-patched.apk";

Console.WriteLine("Patching PocketPay APK to trust user CA certificates...");

File.Copy(ApkPath, PatchedPath, true);

var Archive = ZipFile.Open(PatchedPath, ZipArchiveMode.Update);

var NetSecConfig = Archive.GetEntry("res/xml/network_security_config.xml");

if (NetSecConfig != null)
{
    Console.WriteLine("Found existing network_security_config.xml");
    using var Reader = new StreamReader(NetSecConfig.Open());
    var Content = Reader.ReadToEnd();
    Console.WriteLine("Current: " + Content.Substring(0, Math.Min(200, Content.Length)));
}
else
{
    Console.WriteLine("No network_security_config.xml found — checking for binary XML...");
}

var Manifest = Archive.GetEntry("AndroidManifest.xml");
if (Manifest != null)
{
    using var Ms = new MemoryStream();
    using (var S = Manifest.Open()) S.CopyTo(Ms);
    var Bytes = Ms.ToArray();
    Console.WriteLine($"AndroidManifest.xml: {Bytes.Length} bytes (binary AXML format)");

    var Text = System.Text.Encoding.UTF8.GetString(Bytes);
    if (Text.Contains("network_security_config"))
    {
        Console.WriteLine("  References network_security_config");
    }
    else
    {
        Console.WriteLine("  No network_security_config reference");
    }
}

Console.WriteLine("\nAPK entries related to network/security:");
foreach (var Entry in Archive.Entries)
{
    if (Entry.FullName.Contains("network") || Entry.FullName.Contains("security_config") || Entry.FullName.Contains("xml/"))
    {
        Console.WriteLine($"  {Entry.FullName} ({Entry.Length} bytes)");
    }
}

File.Delete(PatchedPath);
Console.WriteLine("\nDone scanning.");
