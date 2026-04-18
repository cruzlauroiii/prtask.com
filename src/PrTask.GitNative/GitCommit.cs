using System.Globalization;
using System.Text;
using PrTask.GitNative.Models;

namespace PrTask.GitNative;

#pragma warning disable SA1600
public static class GitCommit
{
    public static string CreateCommit(
        string GitDir,
        string TreeHash,
        string[] ParentHashes,
        string AuthorName,
        string AuthorEmail,
        string CommitterName,
        string CommitterEmail,
        string Message,
        DateTimeOffset? AuthorDate = null,
        DateTimeOffset? CommitterDate = null)
    {
        var Now = DateTimeOffset.Now;
        var ActualAuthorDate = AuthorDate ?? Now;
        var ActualCommitterDate = CommitterDate ?? Now;

        var Sb = new StringBuilder();
        Sb.Append(CultureInfo.InvariantCulture, $"tree {TreeHash}\n");

        foreach (var Parent in ParentHashes)
        {
            Sb.Append(CultureInfo.InvariantCulture, $"parent {Parent}\n");
        }

        Sb.Append(CultureInfo.InvariantCulture, $"author {AuthorName} <{AuthorEmail}> {FormatTimestamp(ActualAuthorDate)}\n");
        Sb.Append(CultureInfo.InvariantCulture, $"committer {CommitterName} <{CommitterEmail}> {FormatTimestamp(ActualCommitterDate)}\n");
        Sb.Append('\n');
        Sb.Append(Message);
        Sb.Append('\n');

        var CommitData = Encoding.UTF8.GetBytes(Sb.ToString());
        return GitObjects.WriteObject(GitDir, GitObjectType.Commit, CommitData);
    }

    public static string CreateCommitFromIndex(
        GitRepository Repo,
        string AuthorName,
        string AuthorEmail,
        string CommitterName,
        string CommitterEmail,
        string Message,
        DateTimeOffset? AuthorDate = null,
        DateTimeOffset? CommitterDate = null)
    {
        // Read the index and build a tree
        var Entries = GitIndex.ReadIndex(Repo.GitDir);
        if (Entries.Count == 0)
        {
            throw new InvalidOperationException("Nothing to commit: index is empty");
        }

        var TreeHash = BuildTreeFromIndex(Repo.GitDir, Entries);

        // Get parent commit(s) from HEAD
        var HeadHash = Repo.ReadHead();
        var Parents = string.IsNullOrEmpty(HeadHash) ? Array.Empty<string>() : new[] { HeadHash };

        var CommitHash = CreateCommit(
            Repo.GitDir, TreeHash, Parents,
            AuthorName, AuthorEmail,
            CommitterName, CommitterEmail,
            Message, AuthorDate, CommitterDate);

        // Update HEAD
        UpdateHead(Repo, CommitHash);

        return CommitHash;
    }

    public static string BuildTreeFromIndex(string GitDir, List<GitIndexEntry> Entries)
    {
        // Group entries by top-level directory
        var Root = new TreeBuilder();

        foreach (var Entry in Entries)
        {
            var Parts = Entry.Path.Split('/');
            var Current = Root;

            for (var I = 0; I < Parts.Length - 1; I++)
            {
                if (!Current.Subdirectories.TryGetValue(Parts[I], out var SubDir))
                {
                    SubDir = new TreeBuilder();
                    Current.Subdirectories[Parts[I]] = SubDir;
                }

                Current = SubDir;
            }

            Current.Files.Add(new GitTreeEntry
            {
                Mode = Entry.Mode.ToString("D6", CultureInfo.InvariantCulture),
                Name = Parts[^1],
                Hash = Entry.Hash,
            });
        }

        return WriteTreeRecursive(GitDir, Root);
    }

    private static string WriteTreeRecursive(string GitDir, TreeBuilder Builder)
    {
        var TreeEntries = new List<GitTreeEntry>();

        // Add files
        TreeEntries.AddRange(Builder.Files);

        // Add subdirectories
        foreach (var Kvp in Builder.Subdirectories)
        {
            var SubTreeHash = WriteTreeRecursive(GitDir, Kvp.Value);
            TreeEntries.Add(new GitTreeEntry
            {
                Mode = "40000",
                Name = Kvp.Key,
                Hash = SubTreeHash,
            });
        }

        return GitObjects.WriteTree(GitDir, TreeEntries);
    }

    public static void UpdateHead(GitRepository Repo, string CommitHash)
    {
        var HeadRef = Repo.ReadHeadRef();
        if (!string.IsNullOrEmpty(HeadRef))
        {
            // Update the branch ref
            var RefPath = Path.Combine(Repo.GitDir, HeadRef.Replace('/', Path.DirectorySeparatorChar));
            var Dir = Path.GetDirectoryName(RefPath)!;
            Directory.CreateDirectory(Dir);
            File.WriteAllText(RefPath, CommitHash + "\n");
        }
        else
        {
            // Detached HEAD - update HEAD directly
            File.WriteAllText(Path.Combine(Repo.GitDir, "HEAD"), CommitHash + "\n");
        }
    }

    public static GitCommitInfo? GetCommitInfo(GitRepository Repo, string Hash)
    {
        var Raw = Repo.ReadObject(Hash);
        if (Raw is null || Raw.Type != GitObjectType.Commit)
        {
            return null;
        }

        var Info = GitObjects.ParseCommit(Raw.Data);
        if (Info is not null)
        {
            Info.Hash = Hash;
        }

        return Info;
    }

    public static List<GitCommitInfo> GetLog(GitRepository Repo, string StartHash, int MaxCount = 50)
    {
        var Log = new List<GitCommitInfo>();
        var Visited = new HashSet<string>(StringComparer.Ordinal);
        var Queue = new Queue<string>();
        Queue.Enqueue(StartHash);

        while (Queue.Count > 0 && Log.Count < MaxCount)
        {
            var Hash = Queue.Dequeue();
            if (!Visited.Add(Hash))
            {
                continue;
            }

            var Info = GetCommitInfo(Repo, Hash);
            if (Info is null)
            {
                continue;
            }

            Log.Add(Info);

            foreach (var Parent in Info.ParentHashes)
            {
                if (!Visited.Contains(Parent))
                {
                    Queue.Enqueue(Parent);
                }
            }
        }

        return Log.OrderByDescending(C => C.AuthorDate).ToList();
    }

    private static string FormatTimestamp(DateTimeOffset Date)
    {
        var Epoch = Date.ToUnixTimeSeconds();
        var Offset = Date.Offset;
        var Sign = Offset >= TimeSpan.Zero ? "+" : "-";
        var AbsOffset = Offset.Duration();
        return string.Format(CultureInfo.InvariantCulture, "{0} {1}{2:D2}{3:D2}", Epoch, Sign, AbsOffset.Hours, AbsOffset.Minutes);
    }

    private sealed class TreeBuilder
    {
        public Dictionary<string, TreeBuilder> Subdirectories { get; } = new(StringComparer.Ordinal);
        public List<GitTreeEntry> Files { get; } = new();
    }
}
#pragma warning restore SA1600
