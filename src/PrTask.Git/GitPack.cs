using System.Globalization;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public static class GitPack
{
    private const uint PackSignature = 0x5041434B;
    private const int PackVersion = 2;
    private const int IdxSignature = unchecked((int)0xFF744F63);
    private const int IdxVersion = 2;
    private const int Sha1Size = 20;
    private const int FanoutSize = 256;

    public static List<GitRawObject> ReadPack(string PackPath)
    {
        var Objects = new List<GitRawObject>();
        var Data = File.ReadAllBytes(PackPath);
        if (Data.Length < 12)
        {
            return Objects;
        }

        // Verify header
        var Signature = ReadUInt32BE(Data, 0);
        if (Signature != PackSignature)
        {
            return Objects;
        }

        var Version = ReadUInt32BE(Data, 4);
        var ObjectCount = ReadUInt32BE(Data, 8);
        var Offset = 12;

        for (uint I = 0; I < ObjectCount && Offset < Data.Length - Sha1Size; I++)
        {
            var Obj = ReadPackObject(Data, ref Offset);
            if (Obj is not null)
            {
                Objects.Add(Obj);
            }
        }

        return Objects;
    }

    public static Dictionary<string, PackIndexEntry> ReadIndex(string IdxPath)
    {
        var Index = new Dictionary<string, PackIndexEntry>(StringComparer.Ordinal);
        var Data = File.ReadAllBytes(IdxPath);
        if (Data.Length < 8)
        {
            return Index;
        }

        // Check for v2 index format
        var Magic = ReadInt32BE(Data, 0);
        if (Magic != IdxSignature)
        {
            return Index;
        }

        var Version = ReadInt32BE(Data, 4);
        if (Version != IdxVersion)
        {
            return Index;
        }

        // Read fanout table (256 entries x 4 bytes)
        var FanoutOffset = 8;
        var Fanout = new uint[FanoutSize];
        for (var I = 0; I < FanoutSize; I++)
        {
            Fanout[I] = ReadUInt32BE(Data, FanoutOffset + (I * 4));
        }

        var TotalObjects = Fanout[255];

        // SHA-1 table starts after fanout
        var Sha1TableOffset = FanoutOffset + (FanoutSize * 4);
        var CrcTableOffset = Sha1TableOffset + ((int)TotalObjects * Sha1Size);
        var Offset32TableOffset = CrcTableOffset + ((int)TotalObjects * 4);

        for (uint I = 0; I < TotalObjects; I++)
        {
            var HashBytes = new byte[Sha1Size];
            Buffer.BlockCopy(Data, Sha1TableOffset + ((int)I * Sha1Size), HashBytes, 0, Sha1Size);
            var Hash = Convert.ToHexStringLower(HashBytes);

            var Crc = ReadUInt32BE(Data, CrcTableOffset + ((int)I * 4));
            var PackOffset = ReadUInt32BE(Data, Offset32TableOffset + ((int)I * 4));

            // Check for 64-bit offset (MSB set)
            if ((PackOffset & 0x80000000) != 0)
            {
                var Idx64 = (int)(PackOffset & 0x7FFFFFFF);
                var Offset64TableOffset = Offset32TableOffset + ((int)TotalObjects * 4);
                if (Offset64TableOffset + (Idx64 * 8) + 8 <= Data.Length)
                {
                    var High = ReadUInt32BE(Data, Offset64TableOffset + (Idx64 * 8));
                    var Low = ReadUInt32BE(Data, Offset64TableOffset + (Idx64 * 8) + 4);
                    PackOffset = Low;
                }
            }

            Index[Hash] = new PackIndexEntry
            {
                Hash = Hash,
                Offset = PackOffset,
                Crc32 = Crc,
            };
        }

        return Index;
    }

    public static GitRawObject? ReadObjectFromPack(string PackPath, long Offset)
    {
        var Data = File.ReadAllBytes(PackPath);
        var IntOffset = (int)Offset;
        return ReadPackObject(Data, ref IntOffset);
    }

    public static GitRawObject? FindObjectInPacks(string GitDir, string Hash)
    {
        var PackDir = Path.Combine(GitDir, "objects", "pack");
        if (!Directory.Exists(PackDir))
        {
            return null;
        }

        foreach (var IdxFile in Directory.GetFiles(PackDir, GitConstants.IdxFilePattern))
        {
            var Index = ReadIndex(IdxFile);
            if (Index.TryGetValue(Hash, out var Entry))
            {
                var PackFile = Path.ChangeExtension(IdxFile, GitConstants.PackFileExtension);
                if (File.Exists(PackFile))
                {
                    return ReadObjectFromPack(PackFile, Entry.Offset);
                }
            }
        }

        return null;
    }

    public static byte[] CreatePack(GitRepository Repo, string TipHash, string? BaseHash)
    {
        var Objects = new List<GitRawObject>();
        var Visited = new HashSet<string>(StringComparer.Ordinal);
        var BaseObjects = new HashSet<string>(StringComparer.Ordinal);

        if (BaseHash is not null)
        {
            CollectReachableObjects(Repo, BaseHash, BaseObjects);
        }

        CollectObjectsForPack(Repo, TipHash, Objects, Visited, BaseObjects);

        return WritePack(Objects);
    }

    public static void UnpackObjects(GitRepository Repo, byte[] PackData)
    {
        if (PackData.Length < 12)
        {
            return;
        }

        var Signature = ReadUInt32BE(PackData, 0);
        if (Signature != PackSignature)
        {
            return;
        }

        var ObjectCount = ReadUInt32BE(PackData, 8);
        var Offset = 12;

        for (uint I = 0; I < ObjectCount && Offset < PackData.Length - Sha1Size; I++)
        {
            var Obj = ReadPackObject(PackData, ref Offset);
            if (Obj is not null)
            {
                GitObjects.WriteObject(Repo.GitDir, Obj.Type, Obj.Data);
            }
        }
    }

    public static byte[] WritePack(List<GitRawObject> Objects)
    {
        using var Stream = new MemoryStream();

        // Header
        WriteUInt32BE(Stream, PackSignature);
        WriteUInt32BE(Stream, (uint)PackVersion);
        WriteUInt32BE(Stream, (uint)Objects.Count);

        foreach (var Obj in Objects)
        {
            WritePackObject(Stream, Obj);
        }

        // Checksum
        var Content = Stream.ToArray();
        var Checksum = SHA1.HashData(Content);
        Stream.Write(Checksum, 0, Checksum.Length);

        return Stream.ToArray();
    }

    public static byte[] WriteIndex(string PackPath)
    {
        var Objects = ReadPack(PackPath);
        var PackData = File.ReadAllBytes(PackPath);
        var Entries = new List<(string Hash, uint Offset, uint Crc32)>();
        var Offset = 12;

        for (var I = 0; I < Objects.Count; I++)
        {
            var StartOffset = (uint)Offset;
            var Obj = ReadPackObject(PackData, ref Offset);
            if (Obj is not null)
            {
                var Hash = GitObjects.ComputeHash(Obj.Type, Obj.Data);
                Entries.Add((Hash, StartOffset, 0));
            }
        }

        Entries.Sort((A, B) => string.Compare(A.Hash, B.Hash, StringComparison.Ordinal));

        using var Stream = new MemoryStream();

        // Header
        WriteInt32BE(Stream, IdxSignature);
        WriteInt32BE(Stream, IdxVersion);

        // Fanout table
        var Fanout = new uint[FanoutSize];
        foreach (var Entry in Entries)
        {
            var FirstByte = Convert.FromHexString(Entry.Hash[..2])[0];
            for (var I = FirstByte; I < FanoutSize; I++)
            {
                Fanout[I]++;
            }
        }

        for (var I = 0; I < FanoutSize; I++)
        {
            WriteUInt32BE(Stream, Fanout[I]);
        }

        // SHA-1 table
        foreach (var Entry in Entries)
        {
            var HashBytes = Convert.FromHexString(Entry.Hash);
            Stream.Write(HashBytes, 0, Sha1Size);
        }

        // CRC32 table
        foreach (var Entry in Entries)
        {
            WriteUInt32BE(Stream, Entry.Crc32);
        }

        // 32-bit offset table
        foreach (var Entry in Entries)
        {
            WriteUInt32BE(Stream, Entry.Offset);
        }

        // Pack checksum + index checksum
        var PackChecksum = SHA1.HashData(PackData);
        Stream.Write(PackChecksum, 0, PackChecksum.Length);

        var IdxContent = Stream.ToArray();
        var IdxChecksum = SHA1.HashData(IdxContent);
        Stream.Write(IdxChecksum, 0, IdxChecksum.Length);

        return Stream.ToArray();
    }

    internal static GitRawObject? ReadPackObject(byte[] Data, ref int Offset)
    {
        if (Offset >= Data.Length)
        {
            return null;
        }

        // Read type and size from variable-length header
        var FirstByte = Data[Offset];
        var TypeBits = (FirstByte >> 4) & 0x7;
        var Size = (long)(FirstByte & 0x0F);
        var Shift = 4;
        Offset++;

        while ((Data[Offset - 1] & 0x80) != 0 && Offset < Data.Length)
        {
            Size |= (long)(Data[Offset] & 0x7F) << Shift;
            Shift += 7;
            Offset++;
        }

        var ObjType = TypeBits switch
        {
            1 => GitObjectType.Commit,
            2 => GitObjectType.Tree,
            3 => GitObjectType.Blob,
            4 => GitObjectType.Tag,
            6 => GitObjectType.Blob, // OFS_DELTA
            7 => GitObjectType.Blob, // REF_DELTA
            _ => GitObjectType.Blob,
        };

        // Handle OFS_DELTA
        if (TypeBits == 6)
        {
            var DeltaOffset = ReadOffsetDelta(Data, ref Offset);
            var DecompressedDelta = DecompressData(Data, ref Offset, (int)Size);
            if (DecompressedDelta is not null)
            {
                return new GitRawObject
                {
                    Type = ObjType,
                    Data = DecompressedDelta,
                    Size = DecompressedDelta.Length,
                };
            }

            return null;
        }

        // Handle REF_DELTA
        if (TypeBits == 7)
        {
            if (Offset + Sha1Size > Data.Length)
            {
                return null;
            }

            var BaseHashBytes = new byte[Sha1Size];
            Buffer.BlockCopy(Data, Offset, BaseHashBytes, 0, Sha1Size);
            Offset += Sha1Size;

            var DecompressedDelta = DecompressData(Data, ref Offset, (int)Size);
            if (DecompressedDelta is not null)
            {
                return new GitRawObject
                {
                    Type = ObjType,
                    Data = DecompressedDelta,
                    Size = DecompressedDelta.Length,
                };
            }

            return null;
        }

        // Regular object
        var DecompressedData = DecompressData(Data, ref Offset, (int)Size);
        if (DecompressedData is null)
        {
            return null;
        }

        return new GitRawObject
        {
            Hash = GitObjects.ComputeHash(ObjType, DecompressedData),
            Type = ObjType,
            Data = DecompressedData,
            Size = DecompressedData.Length,
        };
    }

    private static long ReadOffsetDelta(byte[] Data, ref int Offset)
    {
        var Value = (long)(Data[Offset] & 0x7F);
        while ((Data[Offset] & 0x80) != 0)
        {
            Offset++;
            Value = ((Value + 1) << 7) | (Data[Offset] & 0x7F);
        }

        Offset++;
        return Value;
    }

    private static byte[]? DecompressData(byte[] Data, ref int Offset, int ExpectedSize)
    {
        try
        {
            using var Input = new MemoryStream(Data, Offset, Data.Length - Offset);
            using var Deflate = new ZLibStream(Input, CompressionMode.Decompress);
            using var Output = new MemoryStream();
            Deflate.CopyTo(Output);
            var Result = Output.ToArray();

            var Consumed = (int)Input.Position;
            if (Consumed == 0)
            {
                Consumed = Math.Min(Data.Length - Offset, ExpectedSize + 16);
            }

            Offset += Consumed;
            return Result;
        }
        catch
        {
            Offset = Math.Min(Offset + ExpectedSize + 16, Data.Length);
            return null;
        }
    }

    private static void WritePackObject(Stream Stream, GitRawObject Obj)
    {
        var TypeBits = Obj.Type switch
        {
            GitObjectType.Commit => 1,
            GitObjectType.Tree => 2,
            GitObjectType.Blob => 3,
            GitObjectType.Tag => 4,
            _ => 3,
        };

        var Size = (long)Obj.Data.Length;

        // First byte: MSB continuation bit, 3-bit type, 4-bit size
        var FirstByte = (byte)(((Size & 0x0F) | (TypeBits << 4)) & 0x7F);
        Size >>= 4;

        if (Size > 0)
        {
            FirstByte |= 0x80;
        }

        Stream.WriteByte(FirstByte);

        while (Size > 0)
        {
            var NextByte = (byte)(Size & 0x7F);
            Size >>= 7;
            if (Size > 0)
            {
                NextByte |= 0x80;
            }

            Stream.WriteByte(NextByte);
        }

        // Compress data
        using var CompressedStream = new MemoryStream();
        using (var Deflate = new ZLibStream(CompressedStream, CompressionLevel.Optimal, true))
        {
            Deflate.Write(Obj.Data, 0, Obj.Data.Length);
        }

        var Compressed = CompressedStream.ToArray();
        Stream.Write(Compressed, 0, Compressed.Length);
    }

    private static void CollectObjectsForPack(
        GitRepository Repo, string Hash,
        List<GitRawObject> Objects, HashSet<string> Visited, HashSet<string> Exclude)
    {
        if (!Visited.Add(Hash) || Exclude.Contains(Hash))
        {
            return;
        }

        var Obj = Repo.ReadObject(Hash);
        if (Obj is null)
        {
            return;
        }

        Objects.Add(Obj);

        if (Obj.Type == GitObjectType.Commit)
        {
            var Info = GitObjects.ParseCommit(Obj.Data);
            if (Info is not null)
            {
                CollectObjectsForPack(Repo, Info.TreeHash, Objects, Visited, Exclude);
                foreach (var Parent in Info.ParentHashes)
                {
                    CollectObjectsForPack(Repo, Parent, Objects, Visited, Exclude);
                }
            }
        }
        else if (Obj.Type == GitObjectType.Tree)
        {
            var Entries = GitObjects.ParseTree(Obj.Data);
            foreach (var Entry in Entries)
            {
                CollectObjectsForPack(Repo, Entry.Hash, Objects, Visited, Exclude);
            }
        }
    }

    private static void CollectReachableObjects(GitRepository Repo, string Hash, HashSet<string> Visited)
    {
        if (!Visited.Add(Hash))
        {
            return;
        }

        var Obj = Repo.ReadObject(Hash);
        if (Obj is null)
        {
            return;
        }

        if (Obj.Type == GitObjectType.Commit)
        {
            var Info = GitObjects.ParseCommit(Obj.Data);
            if (Info is not null)
            {
                CollectReachableObjects(Repo, Info.TreeHash, Visited);
                foreach (var Parent in Info.ParentHashes)
                {
                    CollectReachableObjects(Repo, Parent, Visited);
                }
            }
        }
        else if (Obj.Type == GitObjectType.Tree)
        {
            var Entries = GitObjects.ParseTree(Obj.Data);
            foreach (var Entry in Entries)
            {
                CollectReachableObjects(Repo, Entry.Hash, Visited);
            }
        }
    }

    internal static uint ReadUInt32BE(byte[] Data, int Offset) =>
        ((uint)Data[Offset] << 24) | ((uint)Data[Offset + 1] << 16) |
        ((uint)Data[Offset + 2] << 8) | Data[Offset + 3];

    internal static int ReadInt32BE(byte[] Data, int Offset) =>
        (Data[Offset] << 24) | (Data[Offset + 1] << 16) |
        (Data[Offset + 2] << 8) | Data[Offset + 3];

    internal static void WriteUInt32BE(Stream Stream, uint Value)
    {
        Stream.WriteByte((byte)(Value >> 24));
        Stream.WriteByte((byte)(Value >> 16));
        Stream.WriteByte((byte)(Value >> 8));
        Stream.WriteByte((byte)Value);
    }

    internal static void WriteInt32BE(Stream Stream, int Value)
    {
        Stream.WriteByte((byte)((Value >> 24) & 0xFF));
        Stream.WriteByte((byte)((Value >> 16) & 0xFF));
        Stream.WriteByte((byte)((Value >> 8) & 0xFF));
        Stream.WriteByte((byte)(Value & 0xFF));
    }
}

public sealed class PackIndexEntry
{
    public string Hash { get; set; } = string.Empty;
    public uint Offset { get; set; }
    public uint Crc32 { get; set; }
}
#pragma warning restore SA1600
