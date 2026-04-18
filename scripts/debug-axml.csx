using System.IO.Compression;

var ApkPath = @"C:\work\pocketpay-apk\base.apk";
var Zip = ZipFile.OpenRead(ApkPath);
var E = Zip.GetEntry("res/layout/fragment_launcher.xml");
var Stream = E.Open();
var Ms = new MemoryStream();
Stream.CopyTo(Ms);
var Data = Ms.ToArray();
Stream.Dispose();

Console.WriteLine($"File size: {Data.Length}");
Console.WriteLine($"Magic: 0x{BitConverter.ToInt32(Data, 0):X8}");
Console.WriteLine($"File size field: {BitConverter.ToInt32(Data, 4)}");

var Pos = 8;
while (Pos + 8 <= Data.Length)
{
    var ChunkType = BitConverter.ToUInt16(Data, Pos);
    var HeaderSize = BitConverter.ToUInt16(Data, Pos + 2);
    var ChunkSize = BitConverter.ToInt32(Data, Pos + 4);

    Console.WriteLine($"  Chunk at {Pos}: type=0x{ChunkType:X4} headerSize={HeaderSize} chunkSize={ChunkSize}");

    if (ChunkSize <= 0 || Pos + ChunkSize > Data.Length)
    {
        Console.WriteLine($"  INVALID chunk size, breaking");
        break;
    }

    if (ChunkType == 0x0001)
    {
        var StringCount = BitConverter.ToInt32(Data, Pos + 8);
        Console.WriteLine($"    String pool: {StringCount} strings");

        var Flags = BitConverter.ToInt32(Data, Pos + 16);
        var IsUtf8 = (Flags & (1 << 8)) != 0;
        Console.WriteLine($"    Flags: 0x{Flags:X8} isUtf8={IsUtf8}");
    }
    else if (ChunkType == 0x0180)
    {
        Console.WriteLine($"    Resource IDs chunk");
    }
    else if (ChunkType == 0x0100)
    {
        Console.WriteLine($"    XML namespace start");
    }
    else if (ChunkType == 0x0101)
    {
        Console.WriteLine($"    XML namespace end");
    }
    else if (ChunkType == 0x0102)
    {
        Console.WriteLine($"    XML element start");
    }
    else if (ChunkType == 0x0103)
    {
        Console.WriteLine($"    XML element end");
    }

    Pos += ChunkSize;
}

Zip.Dispose();
