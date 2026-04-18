using System.Globalization;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public static class GitObjects
{
    public static string ComputeHash(GitObjectType Type, byte[] Data)
    {
        var Header = Encoding.ASCII.GetBytes(string.Format(CultureInfo.InvariantCulture, "{0} {1}\0", TypeToString(Type), Data.Length));
        var FullContent = new byte[Header.Length + Data.Length];
        Buffer.BlockCopy(Header, 0, FullContent, 0, Header.Length);
        Buffer.BlockCopy(Data, 0, FullContent, Header.Length, Data.Length);
        var HashBytes = SHA1.HashData(FullContent);
        return Convert.ToHexStringLower(HashBytes);
    }

    public static string WriteObject(string GitDir, GitObjectType Type, byte[] Data)
    {
        var Hash = ComputeHash(Type, Data);
        var ObjPath = GetObjectPath(GitDir, Hash);
        if (File.Exists(ObjPath))
        {
            return Hash;
        }

        var Dir = Path.GetDirectoryName(ObjPath)!;
        Directory.CreateDirectory(Dir);

        var Header = Encoding.ASCII.GetBytes(string.Format(CultureInfo.InvariantCulture, "{0} {1}\0", TypeToString(Type), Data.Length));
        var FullContent = new byte[Header.Length + Data.Length];
        Buffer.BlockCopy(Header, 0, FullContent, 0, Header.Length);
        Buffer.BlockCopy(Data, 0, FullContent, Header.Length, Data.Length);

        using var FileStream = new FileStream(ObjPath, FileMode.CreateNew, FileAccess.Write);
        using var DeflateStream = new ZLibStream(FileStream, CompressionLevel.Optimal);
        DeflateStream.Write(FullContent, 0, FullContent.Length);

        return Hash;
    }

    public static GitRawObject? ReadObject(string GitDir, string Hash)
    {
        var ObjPath = GetObjectPath(GitDir, Hash);
        if (!File.Exists(ObjPath))
        {
            return null;
        }

        byte[] Decompressed;
        using (var FileStream = new FileStream(ObjPath, FileMode.Open, FileAccess.Read))
        using (var DeflateStream = new ZLibStream(FileStream, CompressionMode.Decompress))
        using (var MemStream = new MemoryStream())
        {
            DeflateStream.CopyTo(MemStream);
            Decompressed = MemStream.ToArray();
        }

        // Parse header: "type size\0data"
        var NullIndex = Array.IndexOf(Decompressed, (byte)0);
        if (NullIndex < 0)
        {
            return null;
        }

        var HeaderStr = Encoding.ASCII.GetString(Decompressed, 0, NullIndex);
        var SpaceIndex = HeaderStr.IndexOf(' ', StringComparison.Ordinal);
        if (SpaceIndex < 0)
        {
            return null;
        }

        var TypeStr = HeaderStr[..SpaceIndex];
        var SizeStr = HeaderStr[(SpaceIndex + 1)..];
        if (!int.TryParse(SizeStr, CultureInfo.InvariantCulture, out var Size))
        {
            return null;
        }

        var DataStart = NullIndex + 1;
        var Data = new byte[Decompressed.Length - DataStart];
        Buffer.BlockCopy(Decompressed, DataStart, Data, 0, Data.Length);

        return new GitRawObject
        {
            Hash = Hash,
            Type = StringToType(TypeStr),
            Data = Data,
            Size = Size,
        };
    }

    public static string WriteBlob(string GitDir, byte[] Content) =>
        WriteObject(GitDir, GitObjectType.Blob, Content);

    public static string WriteTree(string GitDir, List<GitTreeEntry> Entries)
    {
        using var Stream = new MemoryStream();
        foreach (var Entry in Entries.OrderBy(E => E.IsDirectory ? E.Name + "/" : E.Name, StringComparer.Ordinal))
        {
            var ModeBytes = Encoding.ASCII.GetBytes(string.Format(CultureInfo.InvariantCulture, "{0} {1}\0", Entry.Mode, Entry.Name));
            Stream.Write(ModeBytes, 0, ModeBytes.Length);

            var HashBytes = Convert.FromHexString(Entry.Hash);
            Stream.Write(HashBytes, 0, HashBytes.Length);
        }

        return WriteObject(GitDir, GitObjectType.Tree, Stream.ToArray());
    }

    public static List<GitTreeEntry> ParseTree(byte[] Data)
    {
        var Entries = new List<GitTreeEntry>();
        var Offset = 0;
        while (Offset < Data.Length)
        {
            // Read mode and name: "mode name\0"
            var SpacePos = Array.IndexOf(Data, (byte)' ', Offset);
            if (SpacePos < 0)
            {
                break;
            }

            var Mode = Encoding.ASCII.GetString(Data, Offset, SpacePos - Offset);

            var NullPos = Array.IndexOf(Data, (byte)0, SpacePos + 1);
            if (NullPos < 0)
            {
                break;
            }

            var Name = Encoding.ASCII.GetString(Data, SpacePos + 1, NullPos - SpacePos - 1);

            // Read 20-byte SHA-1 hash
            if (NullPos + 1 + 20 > Data.Length)
            {
                break;
            }

            var HashBytes = new byte[20];
            Buffer.BlockCopy(Data, NullPos + 1, HashBytes, 0, 20);
            var Hash = Convert.ToHexStringLower(HashBytes);

            Entries.Add(new GitTreeEntry
            {
                Mode = Mode,
                Name = Name,
                Hash = Hash,
            });

            Offset = NullPos + 1 + 20;
        }

        return Entries;
    }

    public static GitCommitInfo? ParseCommit(byte[] Data)
    {
        var Text = Encoding.UTF8.GetString(Data);
        var Lines = Text.Split('\n');
        var Info = new GitCommitInfo();
        var ParentList = new List<string>();
        var MessageStart = false;
        var MessageBuilder = new StringBuilder();

        foreach (var Line in Lines)
        {
            if (MessageStart)
            {
                if (MessageBuilder.Length > 0)
                {
                    MessageBuilder.Append('\n');
                }

                MessageBuilder.Append(Line);
                continue;
            }

            if (string.IsNullOrEmpty(Line))
            {
                MessageStart = true;
                continue;
            }

            if (Line.StartsWith("tree ", StringComparison.Ordinal))
            {
                Info.TreeHash = Line[5..];
            }
            else if (Line.StartsWith("parent ", StringComparison.Ordinal))
            {
                ParentList.Add(Line[7..]);
            }
            else if (Line.StartsWith("author ", StringComparison.Ordinal))
            {
                ParseIdentity(Line[7..], out var Name, out var Email, out var Date);
                Info.AuthorName = Name;
                Info.AuthorEmail = Email;
                Info.AuthorDate = Date;
            }
            else if (Line.StartsWith("committer ", StringComparison.Ordinal))
            {
                ParseIdentity(Line[10..], out var Name, out var Email, out var Date);
                Info.CommitterName = Name;
                Info.CommitterEmail = Email;
                Info.CommitterDate = Date;
            }
        }

        Info.ParentHashes = ParentList.ToArray();
        Info.Message = MessageBuilder.ToString().TrimEnd();
        return Info;
    }

    private static void ParseIdentity(string Value, out string Name, out string Email, out DateTimeOffset Date)
    {
        // Format: "Name <email> timestamp timezone"
        var EmailStart = Value.IndexOf('<', StringComparison.Ordinal);
        var EmailEnd = Value.IndexOf('>', StringComparison.Ordinal);

        Name = EmailStart > 0 ? Value[..(EmailStart - 1)].Trim() : string.Empty;
        Email = EmailStart >= 0 && EmailEnd > EmailStart ? Value[(EmailStart + 1)..EmailEnd] : string.Empty;

        Date = DateTimeOffset.UtcNow;
        if (EmailEnd >= 0 && EmailEnd + 2 < Value.Length)
        {
            var TimePart = Value[(EmailEnd + 2)..].Trim();
            var Parts = TimePart.Split(' ');
            if (Parts.Length >= 1 && long.TryParse(Parts[0], CultureInfo.InvariantCulture, out var Epoch))
            {
                var Offset = TimeSpan.Zero;
                if (Parts.Length >= 2 && Parts[1].Length >= 4)
                {
                    var Sign = Parts[1][0] == '-' ? GitConstants.NegativeSign : 1;
                    var OffsetStr = Parts[1].TrimStart('+', '-');
                    if (int.TryParse(OffsetStr[..2], CultureInfo.InvariantCulture, out var Hours) &&
                        int.TryParse(OffsetStr[2..], CultureInfo.InvariantCulture, out var Minutes))
                    {
                        Offset = new TimeSpan(Sign * Hours, Sign * Minutes, 0);
                    }
                }

                Date = DateTimeOffset.FromUnixTimeSeconds(Epoch).ToOffset(Offset);
            }
        }
    }

    private static string GetObjectPath(string GitDir, string Hash) =>
        Path.Combine(GitDir, "objects", Hash[..2], Hash[2..]);

    private static string TypeToString(GitObjectType Type) => Type switch
    {
        GitObjectType.Blob => "blob",
        GitObjectType.Tree => "tree",
        GitObjectType.Commit => "commit",
        GitObjectType.Tag => "tag",
        _ => "blob",
    };

    private static GitObjectType StringToType(string Type) => Type switch
    {
        "blob" => GitObjectType.Blob,
        "tree" => GitObjectType.Tree,
        "commit" => GitObjectType.Commit,
        "tag" => GitObjectType.Tag,
        _ => GitObjectType.Blob,
    };
}
#pragma warning restore SA1600
