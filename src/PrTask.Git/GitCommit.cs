using System.Globalization;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed class GitCommit
{
    private readonly GitRepository Repo;

    public GitCommit(GitRepository Repo)
    {
        this.Repo = Repo;
    }

    public string CreateCommit(string Message, string AuthorName, string AuthorEmail, string? CommitterName = null, string? CommitterEmail = null)
    {
        var Index = new GitIndex(Repo);
        var Entries = Index.GetEntries();
        if (Entries.Count == 0)
        {
            throw new InvalidOperationException("Nothing to commit — index is empty");
        }

        // Build tree from index entries
        var TreeHash = BuildTreeFromIndex(Entries);

        // Get parent commit
        var HeadHash = Repo.GetHead();
        var Parents = HeadHash is not null ? new[] { HeadHash } : Array.Empty<string>();

        // Format timestamp
        var Now = DateTimeOffset.Now;
        var Timestamp = string.Format(CultureInfo.InvariantCulture, "{0} {1}{2:D2}{3:D2}",
            Now.ToUnixTimeSeconds(),
            Now.Offset >= TimeSpan.Zero ? "+" : "-",
            Math.Abs(Now.Offset.Hours),
            Math.Abs(Now.Offset.Minutes));

        var Committer = CommitterName ?? AuthorName;
        var CommitterMail = CommitterEmail ?? AuthorEmail;

        // Build commit object content
        var Sb = new StringBuilder();
        Sb.Append(string.Format(CultureInfo.InvariantCulture, "tree {0}\n", TreeHash));
        foreach (var Parent in Parents)
        {
            Sb.Append(string.Format(CultureInfo.InvariantCulture, "parent {0}\n", Parent));
        }

        Sb.Append(string.Format(CultureInfo.InvariantCulture, "author {0} <{1}> {2}\n", AuthorName, AuthorEmail, Timestamp));
        Sb.Append(string.Format(CultureInfo.InvariantCulture, "committer {0} <{1}> {2}\n", Committer, CommitterMail, Timestamp));
        Sb.Append('\n');
        Sb.Append(Message);
        Sb.Append('\n');

        var CommitData = Encoding.UTF8.GetBytes(Sb.ToString());
        var CommitHash = GitObjects.WriteObject(Repo.GitDir, GitObjectType.Commit, CommitData);

        // Update HEAD ref
        var Branch = Repo.GetCurrentBranch();
        if (Branch is not null)
        {
            Repo.UpdateRef(string.Format(CultureInfo.InvariantCulture, "refs/heads/{0}", Branch), CommitHash);
        }

        return CommitHash;
    }

    private string BuildTreeFromIndex(IReadOnlyList<GitIndexEntry> Entries)
    {
        // Group entries by top-level directory
        var RootEntries = new List<GitTreeEntry>();
        var Subdirs = new Dictionary<string, List<GitIndexEntry>>(StringComparer.Ordinal);

        foreach (var Entry in Entries)
        {
            var SlashPos = Entry.Path.IndexOf('/', StringComparison.Ordinal);
            if (SlashPos < 0)
            {
                // File at root level
                RootEntries.Add(new GitTreeEntry
                {
                    Mode = (Entry.Mode & 0x1FF & 0x49) != 0 ? "100755" : "100644",
                    Name = Entry.Path,
                    Hash = Entry.Hash,
                });
            }
            else
            {
                var DirName = Entry.Path[..SlashPos];
                var SubPath = Entry.Path[(SlashPos + 1)..];
                if (!Subdirs.TryGetValue(DirName, out var SubEntries))
                {
                    SubEntries = new List<GitIndexEntry>();
                    Subdirs[DirName] = SubEntries;
                }

                SubEntries.Add(new GitIndexEntry
                {
                    Path = SubPath,
                    Hash = Entry.Hash,
                    Mode = Entry.Mode,
                    Stage = Entry.Stage,
                    FileSize = Entry.FileSize,
                    ModifiedTime = Entry.ModifiedTime,
                });
            }
        }

        // Recursively build subtrees
        foreach (var Kvp in Subdirs)
        {
            var SubTreeHash = BuildTreeFromIndex(Kvp.Value.AsReadOnly());
            RootEntries.Add(new GitTreeEntry
            {
                Mode = "40000",
                Name = Kvp.Key,
                Hash = SubTreeHash,
            });
        }

        return GitObjects.WriteTree(Repo.GitDir, RootEntries);
    }
}
#pragma warning restore SA1600
