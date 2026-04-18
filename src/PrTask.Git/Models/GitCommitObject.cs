using System.Globalization;
using System.Text;

namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitCommitObject : GitObject
{
    public string TreeHash { get; set; } = string.Empty;
    public string[] ParentHashes { get; set; } = [];
    public string AuthorName { get; set; } = string.Empty;
    public string AuthorEmail { get; set; } = string.Empty;
    public DateTimeOffset AuthorDate { get; set; }
    public string CommitterName { get; set; } = string.Empty;
    public string CommitterEmail { get; set; } = string.Empty;
    public DateTimeOffset CommitterDate { get; set; }
    public string Message { get; set; } = string.Empty;

    public override GitObjectType Type => GitObjectType.Commit;

    public override byte[] Serialize()
    {
        var Sb = new StringBuilder();
        Sb.Append(CultureInfo.InvariantCulture, $"tree {TreeHash}\n");

        foreach (var Parent in ParentHashes)
        {
            Sb.Append(CultureInfo.InvariantCulture, $"parent {Parent}\n");
        }

        Sb.Append(CultureInfo.InvariantCulture, $"author {AuthorName} <{AuthorEmail}> {FormatTimestamp(AuthorDate)}\n");
        Sb.Append(CultureInfo.InvariantCulture, $"committer {CommitterName} <{CommitterEmail}> {FormatTimestamp(CommitterDate)}\n");
        Sb.Append('\n');
        Sb.Append(Message);
        Sb.Append('\n');

        return Encoding.UTF8.GetBytes(Sb.ToString());
    }

    public GitCommitInfo ToCommitInfo() => new()
    {
        Hash = Hash,
        TreeHash = TreeHash,
        ParentHashes = ParentHashes,
        AuthorName = AuthorName,
        AuthorEmail = AuthorEmail,
        AuthorDate = AuthorDate,
        CommitterName = CommitterName,
        CommitterEmail = CommitterEmail,
        CommitterDate = CommitterDate,
        Message = Message,
    };

    public static GitCommitObject FromRaw(GitRawObject Obj)
    {
        var Info = GitObjects.ParseCommit(Obj.Data) ?? new GitCommitInfo();
        Info.Hash = Obj.Hash;
        return new GitCommitObject
        {
            Hash = Obj.Hash,
            TreeHash = Info.TreeHash,
            ParentHashes = Info.ParentHashes,
            AuthorName = Info.AuthorName,
            AuthorEmail = Info.AuthorEmail,
            AuthorDate = Info.AuthorDate,
            CommitterName = Info.CommitterName,
            CommitterEmail = Info.CommitterEmail,
            CommitterDate = Info.CommitterDate,
            Message = Info.Message,
        };
    }

    public static GitCommitObject FromInfo(GitCommitInfo Info) => new()
    {
        Hash = Info.Hash,
        TreeHash = Info.TreeHash,
        ParentHashes = Info.ParentHashes,
        AuthorName = Info.AuthorName,
        AuthorEmail = Info.AuthorEmail,
        AuthorDate = Info.AuthorDate,
        CommitterName = Info.CommitterName,
        CommitterEmail = Info.CommitterEmail,
        CommitterDate = Info.CommitterDate,
        Message = Info.Message,
    };

    private static string FormatTimestamp(DateTimeOffset Date)
    {
        var Epoch = Date.ToUnixTimeSeconds();
        var Offset = Date.Offset;
        var Sign = Offset >= TimeSpan.Zero ? "+" : "-";
        var AbsOffset = Offset.Duration();
        return string.Format(CultureInfo.InvariantCulture, "{0} {1}{2:D2}{3:D2}", Epoch, Sign, AbsOffset.Hours, AbsOffset.Minutes);
    }
}
#pragma warning restore SA1600
