using System.IO;
using System.IO.Compression;

var src = Args[0];
var dst = Args[1];

if (File.Exists(dst)) File.Delete(dst);

var srcZip = ZipFile.OpenRead(src);
var dstStream = File.Create(dst);
var dstZip = new ZipArchive(dstStream, ZipArchiveMode.Create);

foreach (var entry in srcZip.Entries)
{
    var level = entry.FullName.EndsWith(".arsc") || entry.FullName.EndsWith(".so")
        ? CompressionLevel.NoCompression
        : CompressionLevel.Optimal;

    var newEntry = dstZip.CreateEntry(entry.FullName, level);
    newEntry.LastWriteTime = entry.LastWriteTime;

    var reader = entry.Open();
    var writer = newEntry.Open();
    reader.CopyTo(writer);
    writer.Dispose();
    reader.Dispose();
}

dstZip.Dispose();
dstStream.Dispose();
srcZip.Dispose();

Console.WriteLine($"Done: {new FileInfo(dst).Length} bytes");
