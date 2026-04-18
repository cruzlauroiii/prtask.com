using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);
var Entry = Zip.GetEntry("resources.arsc");
if (Entry is null) { Console.WriteLine("No resources.arsc"); return; }

var Stream = Entry.Open();
var Ms = new MemoryStream();
Stream.CopyTo(Ms);
var Data = Ms.ToArray();
Stream.Dispose();

Console.WriteLine($"resources.arsc: {Data.Length} bytes");
Console.WriteLine($"Magic u16: 0x{BitConverter.ToUInt16(Data, 0):X4}");
Console.WriteLine($"Header size: {BitConverter.ToUInt16(Data, 2)}");
Console.WriteLine($"File size: {BitConverter.ToInt32(Data, 4)}");
Console.WriteLine($"Package count: {BitConverter.ToInt32(Data, 8)}");

// Parse string pool at offset 12
var Pos = 12;
var PoolType = BitConverter.ToUInt16(Data, Pos);
var PoolHeaderSize = BitConverter.ToUInt16(Data, Pos + 2);
var PoolSize = BitConverter.ToInt32(Data, Pos + 4);
var StringCount = BitConverter.ToInt32(Data, Pos + 8);
var PoolFlags = BitConverter.ToInt32(Data, Pos + 16);
var PoolStringsStart = BitConverter.ToInt32(Data, Pos + 20);
var IsUtf8 = (PoolFlags & (1 << 8)) != 0;

Console.WriteLine($"\nGlobal string pool: type=0x{PoolType:X4} size={PoolSize} strings={StringCount} utf8={IsUtf8}");

// Read first 20 strings
for (var I = 0; I < Math.Min(20, StringCount); I++)
{
    var StrOff = BitConverter.ToInt32(Data, Pos + 28 + (I * 4));
    var AbsOff = Pos + PoolStringsStart + StrOff;
    if (AbsOff >= Data.Length) continue;

    string Str;
    if (IsUtf8)
    {
        var P = AbsOff;
        var CharLen = Data[P++]; if ((CharLen & 0x80) != 0) P++;
        var ByteLen = (int)Data[P++]; if ((ByteLen & 0x80) != 0) ByteLen = ((ByteLen & 0x7F) << 8) | Data[P++];
        Str = System.Text.Encoding.UTF8.GetString(Data, P, Math.Min(ByteLen, Data.Length - P));
    }
    else
    {
        var Len = BitConverter.ToUInt16(Data, AbsOff);
        Str = System.Text.Encoding.Unicode.GetString(Data, AbsOff + 2, Math.Min(Len * 2, Data.Length - AbsOff - 2));
    }
    Console.WriteLine($"  [{I}] \"{(Str.Length > 60 ? Str.Substring(0, 57) + "..." : Str)}\"");
}

// Find package chunk
Pos = 12 + PoolSize;
Console.WriteLine($"\nPackage at offset {Pos}");
if (Pos + 12 <= Data.Length)
{
    var PkgType = BitConverter.ToUInt16(Data, Pos);
    var PkgHeaderSize = BitConverter.ToUInt16(Data, Pos + 2);
    var PkgSize = BitConverter.ToInt32(Data, Pos + 4);
    var PkgId = BitConverter.ToInt32(Data, Pos + 8);
    Console.WriteLine($"  type=0x{PkgType:X4} headerSize={PkgHeaderSize} size={PkgSize} id=0x{PkgId:X2}");

    // Package name (128 UTF-16 chars at offset 12)
    var PkgName = System.Text.Encoding.Unicode.GetString(Data, Pos + 12, 256).TrimEnd('\0');
    Console.WriteLine($"  Package: {PkgName}");

    var TypeStringsOff = BitConverter.ToInt32(Data, Pos + 268);
    var KeyStringsOff = BitConverter.ToInt32(Data, Pos + 276);
    Console.WriteLine($"  TypeStrings offset: {TypeStringsOff}");
    Console.WriteLine($"  KeyStrings offset: {KeyStringsOff}");
}

Zip.Dispose();
