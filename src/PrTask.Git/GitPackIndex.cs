using System.Security.Cryptography;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600, CA5350
public static class GitPackIndex
{
    public static IDictionary<string, PackIndexEntry> ReadIndex(string IdxPath)
    {
        var Index = new Dictionary<string, PackIndexEntry>(StringComparer.Ordinal);
        var Data = File.ReadAllBytes(IdxPath);
        if (Data.Length < GitConstants.MtimeSecOffset)
        {
            return Index;
        }

        var Magic = GitPack.ReadInt32BE(Data, 0);
        if (Magic != GitConstants.IdxSignature)
        {
            return Index;
        }

        var IdxVersion = GitPack.ReadInt32BE(Data, GitConstants.CtimeNsecOffset);
        if (IdxVersion != GitConstants.IdxVersion)
        {
            return Index;
        }

        const int FanoutOffset = GitConstants.MtimeSecOffset;
        var Fanout = new uint[GitConstants.FanoutSize];
        for (var I = 0; I < GitConstants.FanoutSize; I++)
        {
            Fanout[I] = GitPack.ReadUInt32BE(Data, FanoutOffset + (I * GitConstants.FanoutEntrySize));
        }

        var TotalObjects = Fanout[GitConstants.FanoutSize - 1];

        const int Sha1TableOffset = FanoutOffset + (GitConstants.FanoutSize * GitConstants.FanoutEntrySize);
        var CrcTableOffset = Sha1TableOffset + ((int)TotalObjects * GitConstants.Sha1ByteSize);
        var Offset32TableOffset = CrcTableOffset + ((int)TotalObjects * GitConstants.CrcEntrySize);

        for (uint I = 0; I < TotalObjects; I++)
        {
            var HashBytes = new byte[GitConstants.Sha1ByteSize];
            Buffer.BlockCopy(Data, Sha1TableOffset + ((int)I * GitConstants.Sha1ByteSize), HashBytes, 0, GitConstants.Sha1ByteSize);
            var Hash = Convert.ToHexStringLower(HashBytes);

            var Crc = GitPack.ReadUInt32BE(Data, CrcTableOffset + ((int)I * GitConstants.CrcEntrySize));
            var PackOffset = GitPack.ReadUInt32BE(Data, Offset32TableOffset + ((int)I * GitConstants.Offset32EntrySize));

            if ((PackOffset & GitConstants.PackOffset64Bit) != 0)
            {
                var Idx64 = (int)(PackOffset & GitConstants.PackOffset64Mask);
                var Offset64TableOffset = Offset32TableOffset + ((int)TotalObjects * GitConstants.Offset32EntrySize);
                if (Offset64TableOffset + (Idx64 * GitConstants.Offset64EntrySize) + GitConstants.Offset64EntrySize <= Data.Length)
                {
                    var Low = GitPack.ReadUInt32BE(Data, Offset64TableOffset + (Idx64 * GitConstants.Offset64EntrySize) + GitConstants.Offset32EntrySize);
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

    public static byte[] WriteIndex(string PackPath)
    {
        var Objects = GitPack.ReadPack(PackPath);
        var PackData = File.ReadAllBytes(PackPath);
        var Entries = new List<(string Hash, uint Offset, uint Crc32)>();
        var Offset = GitConstants.PackHeaderSize;

        for (var I = 0; I < Objects.Count; I++)
        {
            var StartOffset = (uint)Offset;
            var Obj = GitPack.ReadPackObject(PackData, ref Offset);
            if (Obj is not null)
            {
                var Hash = GitObjects.ComputeHash(Obj.Type, Obj.Data);
                Entries.Add((Hash, StartOffset, 0));
            }
        }

        Entries.Sort((A, B) => StringComparer.Ordinal.Compare(A.Hash, B.Hash));

        using var Stream = new MemoryStream();

        GitPack.WriteInt32BE(Stream, GitConstants.IdxSignature);
        GitPack.WriteInt32BE(Stream, GitConstants.IdxVersion);

        var Fanout = new uint[GitConstants.FanoutSize];
        foreach (var Entry in Entries)
        {
            var FirstByte = Convert.FromHexString(Entry.Hash[..2])[0];
            for (var I = (int)FirstByte; I < GitConstants.FanoutSize; I++)
            {
                Fanout[I]++;
            }
        }

        for (var I = 0; I < GitConstants.FanoutSize; I++)
        {
            GitPack.WriteUInt32BE(Stream, Fanout[I]);
        }

        foreach (var Entry in Entries)
        {
            var HashBytes = Convert.FromHexString(Entry.Hash);
            Stream.Write(HashBytes, 0, GitConstants.Sha1ByteSize);
        }

        foreach (var Entry in Entries)
        {
            GitPack.WriteUInt32BE(Stream, Entry.Crc32);
        }

        foreach (var Entry in Entries)
        {
            GitPack.WriteUInt32BE(Stream, Entry.Offset);
        }

        var PackChecksum = SHA1.HashData(PackData);
        Stream.Write(PackChecksum, 0, PackChecksum.Length);

        var IdxContent = Stream.ToArray();
        var IdxChecksum = SHA1.HashData(IdxContent);
        Stream.Write(IdxChecksum, 0, IdxChecksum.Length);

        return Stream.ToArray();
    }
}
#pragma warning restore SA1600, CA5350
