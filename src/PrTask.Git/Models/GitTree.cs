using System.Text;

namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitTree : GitObject
{
    public List<GitTreeEntry> Entries { get; set; } = new();

    public override GitObjectType Type => GitObjectType.Tree;

    public override byte[] Serialize()
    {
        using var Stream = new MemoryStream();
        foreach (var Entry in Entries.OrderBy(E => E.IsDirectory ? E.Name + "/" : E.Name, StringComparer.Ordinal))
        {
            var Header = Encoding.ASCII.GetBytes($"{Entry.Mode} {Entry.Name}\0");
            Stream.Write(Header, 0, Header.Length);
            var HashBytes = Convert.FromHexString(Entry.Hash);
            Stream.Write(HashBytes, 0, HashBytes.Length);
        }

        return Stream.ToArray();
    }

    public GitTreeEntry? FindEntry(string Name) =>
        Entries.Find(E => E.Name == Name);

    public bool ContainsEntry(string Name) =>
        Entries.Exists(E => E.Name == Name);

    public static GitTree FromRaw(GitRawObject Obj)
    {
        var Entries = GitObjects.ParseTree(Obj.Data);
        return new GitTree
        {
            Hash = Obj.Hash,
            Entries = Entries,
        };
    }
}
#pragma warning restore SA1600
