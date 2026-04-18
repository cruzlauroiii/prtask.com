using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed class GitIndex
{
    private readonly GitRepository Repo;
    private readonly List<GitIndexEntry> Entries = new();

    public GitIndex(GitRepository Repo)
    {
        this.Repo = Repo;
        Load();
    }

    public IReadOnlyList<GitIndexEntry> GetEntries() => Entries.AsReadOnly();

    public void Stage(string RelativePath)
    {
        var FullPath = Path.Combine(Repo.WorkDir, RelativePath.Replace('/', Path.DirectorySeparatorChar));
        if (!File.Exists(FullPath))
        {
            // File deleted — remove from index
            Entries.RemoveAll(E => E.Path == RelativePath);
            Save();
            return;
        }

        var Content = File.ReadAllBytes(FullPath);
        var Hash = GitObjects.WriteBlob(Repo.GitDir, Content);
        var FileInfo = new System.IO.FileInfo(FullPath);

        var Existing = Entries.FindIndex(E => E.Path == RelativePath);
        var Entry = new GitIndexEntry
        {
            Path = RelativePath,
            Hash = Hash,
            Mode = 0x81A4, // 100644
            Stage = 0,
            FileSize = FileInfo.Length,
            ModifiedTime = FileInfo.LastWriteTimeUtc,
        };

        if (Existing >= 0)
        {
            Entries[Existing] = Entry;
        }
        else
        {
            Entries.Add(Entry);
            Entries.Sort((A, B) => StringComparer.Ordinal.Compare(A.Path, B.Path));
        }

        Save();
    }

    public void StageAll()
    {
        var AllFiles = GetWorkTreeFiles();
        var IndexedPaths = new HashSet<string>(Entries.Select(E => E.Path), StringComparer.Ordinal);

        // Stage new and modified files
        foreach (var File in AllFiles)
        {
            Stage(File);
        }

        // Remove deleted files
        var WorkTreeSet = new HashSet<string>(AllFiles, StringComparer.Ordinal);
        var ToRemove = Entries.Where(E => !WorkTreeSet.Contains(E.Path)).Select(E => E.Path).ToList();
        foreach (var Path in ToRemove)
        {
            Entries.RemoveAll(E => E.Path == Path);
        }

        Save();
    }

    public void Unstage(string RelativePath)
    {
        Entries.RemoveAll(E => E.Path == RelativePath);
        Save();
    }

    public void Clear()
    {
        Entries.Clear();
        Save();
    }

    private List<string> GetWorkTreeFiles()
    {
        var Files = new List<string>();
        CollectFiles(Repo.WorkDir, string.Empty, Files);
        return Files;
    }

    private void CollectFiles(string Dir, string Prefix, List<string> Files)
    {
        foreach (var Entry in Directory.GetFileSystemEntries(Dir))
        {
            var Name = Path.GetFileName(Entry);
            if (Name == ".git" || Name == ".gitignore")
            {
                continue;
            }

            var RelPath = string.IsNullOrEmpty(Prefix) ? Name : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Prefix, Name);

            if (Directory.Exists(Entry))
            {
                CollectFiles(Entry, RelPath, Files);
            }
            else
            {
                Files.Add(RelPath);
            }
        }
    }

    private void Load()
    {
        var IndexPath = Path.Combine(Repo.GitDir, "index");
        if (!File.Exists(IndexPath))
        {
            return;
        }

        var Data = File.ReadAllBytes(IndexPath);
        if (Data.Length < 12)
        {
            return;
        }

        // Verify signature "DIRC"
        if (Data[0] != 'D' || Data[1] != 'I' || Data[2] != 'R' || Data[3] != 'C')
        {
            return;
        }

        var Version = ReadInt32BigEndian(Data, 4);
        var EntryCount = ReadInt32BigEndian(Data, 8);
        var Offset = 12;

        for (var I = 0; I < EntryCount && Offset < Data.Length - 20; I++)
        {
            if (Offset + 62 > Data.Length)
            {
                break;
            }

            var CtimeSec = ReadInt32BigEndian(Data, Offset);
            var CtimeNsec = ReadInt32BigEndian(Data, Offset + 4);
            var MtimeSec = ReadInt32BigEndian(Data, Offset + 8);
            var MtimeNsec = ReadInt32BigEndian(Data, Offset + 12);
            var Dev = ReadInt32BigEndian(Data, Offset + 16);
            var Ino = ReadInt32BigEndian(Data, Offset + 20);
            var Mode = ReadInt32BigEndian(Data, Offset + 24);
            var Uid = ReadInt32BigEndian(Data, Offset + 28);
            var Gid = ReadInt32BigEndian(Data, Offset + 32);
            var FileSize = ReadInt32BigEndian(Data, Offset + 36);

            var HashBytes = new byte[20];
            Buffer.BlockCopy(Data, Offset + 40, HashBytes, 0, 20);
            var Hash = Convert.ToHexStringLower(HashBytes);

            var Flags = ReadUInt16BigEndian(Data, Offset + 60);
            var NameLength = Flags & 0xFFF;
            var Stage = (Flags >> 12) & 3;

            var NameStart = Offset + 62;
            var NameEnd = NameStart;
            while (NameEnd < Data.Length && Data[NameEnd] != 0)
            {
                NameEnd++;
            }

            var EntryPath = Encoding.UTF8.GetString(Data, NameStart, NameEnd - NameStart);

            Entries.Add(new GitIndexEntry
            {
                Path = EntryPath,
                Hash = Hash,
                Mode = Mode,
                Stage = Stage,
                FileSize = FileSize,
                ModifiedTime = DateTimeOffset.FromUnixTimeSeconds(MtimeSec),
            });

            // Entries are padded to 8-byte boundaries
            var EntryLength = 62 + (NameEnd - NameStart) + 1;
            var Padding = (8 - (EntryLength % 8)) % 8;
            Offset = NameEnd + 1 + Padding;
        }
    }

    private void Save()
    {
        using var Stream = new MemoryStream();

        // Header: DIRC, version 2, entry count
        Stream.Write("DIRC"u8);
        WriteInt32BigEndian(Stream, 2);
        WriteInt32BigEndian(Stream, Entries.Count);

        foreach (var Entry in Entries)
        {
            var ModTime = Entry.ModifiedTime.ToUnixTimeSeconds();
            WriteInt32BigEndian(Stream, (int)ModTime); // ctime sec
            WriteInt32BigEndian(Stream, 0); // ctime nsec
            WriteInt32BigEndian(Stream, (int)ModTime); // mtime sec
            WriteInt32BigEndian(Stream, 0); // mtime nsec
            WriteInt32BigEndian(Stream, 0); // dev
            WriteInt32BigEndian(Stream, 0); // ino
            WriteInt32BigEndian(Stream, Entry.Mode); // mode
            WriteInt32BigEndian(Stream, 0); // uid
            WriteInt32BigEndian(Stream, 0); // gid
            WriteInt32BigEndian(Stream, (int)Entry.FileSize); // file size

            var HashBytes = Convert.FromHexString(Entry.Hash);
            Stream.Write(HashBytes, 0, 20);

            var NameBytes = Encoding.UTF8.GetBytes(Entry.Path);
            var NameLen = Math.Min(NameBytes.Length, 0xFFF);
            var Flags = (ushort)((Entry.Stage << 12) | NameLen);
            WriteUInt16BigEndian(Stream, Flags);

            Stream.Write(NameBytes, 0, NameBytes.Length);
            Stream.WriteByte(0); // null terminator

            // Pad to 8-byte boundary
            var EntryLength = 62 + NameBytes.Length + 1;
            var Padding = (8 - (EntryLength % 8)) % 8;
            for (var P = 0; P < Padding; P++)
            {
                Stream.WriteByte(0);
            }
        }

        // Checksum
        var Content = Stream.ToArray();
        var Checksum = SHA1.HashData(Content);
        Stream.Write(Checksum, 0, Checksum.Length);

        var IndexPath = Path.Combine(Repo.GitDir, "index");
        File.WriteAllBytes(IndexPath, Stream.ToArray());
    }

    private static int ReadInt32BigEndian(byte[] Data, int Offset) =>
        (Data[Offset] << 24) | (Data[Offset + 1] << 16) | (Data[Offset + 2] << 8) | Data[Offset + 3];

    private static ushort ReadUInt16BigEndian(byte[] Data, int Offset) =>
        (ushort)((Data[Offset] << 8) | Data[Offset + 1]);

    private static void WriteInt32BigEndian(Stream Stream, int Value)
    {
        Stream.WriteByte((byte)((Value >> 24) & 0xFF));
        Stream.WriteByte((byte)((Value >> 16) & 0xFF));
        Stream.WriteByte((byte)((Value >> 8) & 0xFF));
        Stream.WriteByte((byte)(Value & 0xFF));
    }

    private static void WriteUInt16BigEndian(Stream Stream, ushort Value)
    {
        Stream.WriteByte((byte)((Value >> 8) & 0xFF));
        Stream.WriteByte((byte)(Value & 0xFF));
    }
}
#pragma warning restore SA1600
