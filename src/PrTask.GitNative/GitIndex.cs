using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using PrTask.GitNative.Models;

namespace PrTask.GitNative;

#pragma warning disable SA1600
public static class GitIndex
{
    private const uint IndexSignature = 0x44495243; // "DIRC"
    private const int EntryBaseSize = 62; // Fixed fields before path

    public static List<GitIndexEntry> ReadIndex(string GitDir)
    {
        var IndexPath = Path.Combine(GitDir, "index");
        if (!File.Exists(IndexPath))
        {
            return new List<GitIndexEntry>();
        }

        var Data = File.ReadAllBytes(IndexPath);
        return ParseIndex(Data);
    }

    public static void WriteIndex(string GitDir, List<GitIndexEntry> Entries)
    {
        var IndexPath = Path.Combine(GitDir, "index");
        var Data = SerializeIndex(Entries);
        File.WriteAllBytes(IndexPath, Data);
    }

    public static List<GitIndexEntry> ParseIndex(byte[] Data)
    {
        var Entries = new List<GitIndexEntry>();
        if (Data.Length < 12)
        {
            return Entries;
        }

        var Offset = 0;

        // Header: 4-byte signature, 4-byte version, 4-byte entry count
        var Signature = ReadUInt32BE(Data, Offset);
        Offset += 4;
        if (Signature != IndexSignature)
        {
            return Entries;
        }

        var Version = ReadUInt32BE(Data, Offset);
        Offset += 4;

        var EntryCount = ReadUInt32BE(Data, Offset);
        Offset += 4;

        for (uint I = 0; I < EntryCount && Offset < Data.Length - 20; I++)
        {
            var EntryStart = Offset;

            // ctime seconds (4) + ctime nanoseconds (4)
            var CtimeSeconds = ReadUInt32BE(Data, Offset);
            Offset += 8; // skip ctime sec + nsec

            // mtime seconds (4) + mtime nanoseconds (4)
            var MtimeSeconds = ReadUInt32BE(Data, Offset);
            Offset += 8; // skip mtime sec + nsec

            // dev (4) + ino (4)
            Offset += 8;

            // mode (4)
            var Mode = (int)ReadUInt32BE(Data, Offset);
            Offset += 4;

            // uid (4) + gid (4)
            Offset += 8;

            // file size (4)
            var FileSize = ReadUInt32BE(Data, Offset);
            Offset += 4;

            // SHA-1 hash (20 bytes)
            var HashBytes = new byte[20];
            Buffer.BlockCopy(Data, Offset, HashBytes, 0, 20);
            var Hash = Convert.ToHexStringLower(HashBytes);
            Offset += 20;

            // flags (2): 1-bit assume-valid, 1-bit extended, 2-bit stage, 12-bit name length
            var Flags = ReadUInt16BE(Data, Offset);
            Offset += 2;

            var Stage = (Flags >> 12) & 0x3;
            var NameLength = Flags & 0xFFF;

            // Extended flags for version >= 3
            if (Version >= 3 && (Flags & 0x4000) != 0)
            {
                Offset += 2; // Skip extended flags
            }

            // Path name (variable length, null-terminated, padded to 8-byte boundary)
            var PathEnd = Array.IndexOf(Data, (byte)0, Offset);
            if (PathEnd < 0)
            {
                break;
            }

            var Path = Encoding.UTF8.GetString(Data, Offset, PathEnd - Offset);

            // Calculate padding to next 8-byte boundary
            var EntryLength = PathEnd - EntryStart + 1;
            var PaddedLength = (EntryLength + 7) & ~7;
            if (PaddedLength == EntryLength)
            {
                PaddedLength += 8;
            }

            Offset = EntryStart + PaddedLength;

            var ModifiedTime = DateTimeOffset.FromUnixTimeSeconds(MtimeSeconds);

            Entries.Add(new GitIndexEntry
            {
                Path = Path,
                Hash = Hash,
                Mode = Mode,
                Stage = Stage,
                FileSize = FileSize,
                ModifiedTime = ModifiedTime,
            });
        }

        return Entries;
    }

    public static byte[] SerializeIndex(List<GitIndexEntry> Entries)
    {
        var SortedEntries = Entries
            .OrderBy(E => E.Path, StringComparer.Ordinal)
            .ToList();

        using var Stream = new MemoryStream();

        // Write header
        WriteUInt32BE(Stream, IndexSignature);
        WriteUInt32BE(Stream, 2); // Version 2
        WriteUInt32BE(Stream, (uint)SortedEntries.Count);

        foreach (var Entry in SortedEntries)
        {
            var EntryStart = (int)Stream.Position;
            var Epoch = Entry.ModifiedTime.ToUnixTimeSeconds();

            // ctime (sec + nsec)
            WriteUInt32BE(Stream, (uint)Epoch);
            WriteUInt32BE(Stream, 0);

            // mtime (sec + nsec)
            WriteUInt32BE(Stream, (uint)Epoch);
            WriteUInt32BE(Stream, 0);

            // dev + ino
            WriteUInt32BE(Stream, 0);
            WriteUInt32BE(Stream, 0);

            // mode
            WriteUInt32BE(Stream, (uint)Entry.Mode);

            // uid + gid
            WriteUInt32BE(Stream, 0);
            WriteUInt32BE(Stream, 0);

            // file size
            WriteUInt32BE(Stream, (uint)Entry.FileSize);

            // SHA-1 hash
            var HashBytes = Convert.FromHexString(Entry.Hash);
            Stream.Write(HashBytes, 0, 20);

            // Flags: stage in bits 12-13, name length capped at 0xFFF in bits 0-11
            var PathBytes = Encoding.UTF8.GetBytes(Entry.Path);
            var NameLen = Math.Min(PathBytes.Length, 0xFFF);
            var Flags = (ushort)((Entry.Stage << 12) | NameLen);
            WriteUInt16BE(Stream, Flags);

            // Path (null-terminated, padded to 8-byte boundary)
            Stream.Write(PathBytes, 0, PathBytes.Length);
            Stream.WriteByte(0);

            // Pad to 8-byte boundary
            var EntryLength = (int)Stream.Position - EntryStart;
            var PaddedLength = (EntryLength + 7) & ~7;
            if (PaddedLength == EntryLength)
            {
                PaddedLength += 8;
            }

            var PadBytes = PaddedLength - EntryLength;
            for (var P = 0; P < PadBytes; P++)
            {
                Stream.WriteByte(0);
            }
        }

        // Compute and write SHA-1 checksum of everything before this point
        var Content = Stream.ToArray();
        var Checksum = SHA1.HashData(Content);
        Stream.Write(Checksum, 0, Checksum.Length);

        return Stream.ToArray();
    }

    public static void AddEntry(List<GitIndexEntry> Entries, GitIndexEntry NewEntry)
    {
        // Remove existing entry with same path and stage
        Entries.RemoveAll(E => E.Path == NewEntry.Path && E.Stage == NewEntry.Stage);
        Entries.Add(NewEntry);
    }

    public static void RemoveEntry(List<GitIndexEntry> Entries, string Path)
    {
        Entries.RemoveAll(E => E.Path == Path);
    }

    public static GitIndexEntry? FindEntry(List<GitIndexEntry> Entries, string Path)
    {
        return Entries.Find(E => E.Path == Path && E.Stage == 0);
    }

    private static uint ReadUInt32BE(byte[] Data, int Offset)
    {
        return ((uint)Data[Offset] << 24) |
               ((uint)Data[Offset + 1] << 16) |
               ((uint)Data[Offset + 2] << 8) |
               Data[Offset + 3];
    }

    private static ushort ReadUInt16BE(byte[] Data, int Offset)
    {
        return (ushort)((Data[Offset] << 8) | Data[Offset + 1]);
    }

    private static void WriteUInt32BE(Stream Stream, uint Value)
    {
        Stream.WriteByte((byte)(Value >> 24));
        Stream.WriteByte((byte)(Value >> 16));
        Stream.WriteByte((byte)(Value >> 8));
        Stream.WriteByte((byte)Value);
    }

    private static void WriteUInt16BE(Stream Stream, ushort Value)
    {
        Stream.WriteByte((byte)(Value >> 8));
        Stream.WriteByte((byte)Value);
    }
}
#pragma warning restore SA1600
