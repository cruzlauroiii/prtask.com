using System.Globalization;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed class GitDiff
{
    private readonly GitRepository Repo;

    public GitDiff(GitRepository Repo)
    {
        this.Repo = Repo;
    }

    public List<GitDiffEntry> DiffIndex()
    {
        var Results = new List<GitDiffEntry>();
        var Index = new GitIndex(Repo);
        var HeadHash = Repo.GetHead();

        if (HeadHash is null)
        {
            // No commits yet — everything in index is new
            foreach (var Entry in Index.GetEntries())
            {
                Results.Add(new GitDiffEntry
                {
                    NewPath = Entry.Path,
                    NewHash = Entry.Hash,
                    Status = GitDiffStatus.Added,
                });
            }

            return Results;
        }

        var Commit = Repo.GetCommit(HeadHash);
        if (Commit is null)
        {
            return Results;
        }

        // Build flat map of tree
        var TreeEntries = new Dictionary<string, string>(StringComparer.Ordinal);
        FlattenTree(Commit.TreeHash, string.Empty, TreeEntries);

        // Compare index against tree
        var IndexEntries = Index.GetEntries();
        var IndexPaths = new HashSet<string>(StringComparer.Ordinal);

        foreach (var IndexEntry in IndexEntries)
        {
            IndexPaths.Add(IndexEntry.Path);
            if (TreeEntries.TryGetValue(IndexEntry.Path, out var TreeHash))
            {
                if (!string.Equals(TreeHash, IndexEntry.Hash, StringComparison.Ordinal))
                {
                    var DiffEntry = new GitDiffEntry
                    {
                        OldPath = IndexEntry.Path,
                        NewPath = IndexEntry.Path,
                        OldHash = TreeHash,
                        NewHash = IndexEntry.Hash,
                        Status = GitDiffStatus.Modified,
                    };
                    DiffEntry.Hunks = ComputeHunks(TreeHash, IndexEntry.Hash);
                    Results.Add(DiffEntry);
                }
            }
            else
            {
                Results.Add(new GitDiffEntry
                {
                    NewPath = IndexEntry.Path,
                    NewHash = IndexEntry.Hash,
                    Status = GitDiffStatus.Added,
                });
            }
        }

        // Files deleted from tree
        foreach (var Kvp in TreeEntries)
        {
            if (!IndexPaths.Contains(Kvp.Key))
            {
                Results.Add(new GitDiffEntry
                {
                    OldPath = Kvp.Key,
                    OldHash = Kvp.Value,
                    Status = GitDiffStatus.Deleted,
                });
            }
        }

        return Results;
    }

    public List<GitDiffEntry> DiffWorkTree()
    {
        var Results = new List<GitDiffEntry>();
        var Index = new GitIndex(Repo);
        var IndexEntries = Index.GetEntries();

        foreach (var Entry in IndexEntries)
        {
            var FullPath = Path.Combine(Repo.WorkDir, Entry.Path.Replace('/', Path.DirectorySeparatorChar));
            if (!File.Exists(FullPath))
            {
                Results.Add(new GitDiffEntry
                {
                    OldPath = Entry.Path,
                    OldHash = Entry.Hash,
                    Status = GitDiffStatus.Deleted,
                });
                continue;
            }

            var Content = File.ReadAllBytes(FullPath);
            var Hash = GitObjects.ComputeHash(GitObjectType.Blob, Content);

            if (!string.Equals(Hash, Entry.Hash, StringComparison.Ordinal))
            {
                Results.Add(new GitDiffEntry
                {
                    OldPath = Entry.Path,
                    NewPath = Entry.Path,
                    OldHash = Entry.Hash,
                    NewHash = Hash,
                    Status = GitDiffStatus.Modified,
                });
            }
        }

        return Results;
    }

    public List<GitDiffEntry> DiffCommits(string OldCommitHash, string NewCommitHash)
    {
        var Results = new List<GitDiffEntry>();
        var OldCommit = Repo.GetCommit(OldCommitHash);
        var NewCommit = Repo.GetCommit(NewCommitHash);

        if (OldCommit is null || NewCommit is null)
        {
            return Results;
        }

        var OldTree = new Dictionary<string, string>(StringComparer.Ordinal);
        var NewTree = new Dictionary<string, string>(StringComparer.Ordinal);
        FlattenTree(OldCommit.TreeHash, string.Empty, OldTree);
        FlattenTree(NewCommit.TreeHash, string.Empty, NewTree);

        var AllPaths = new HashSet<string>(OldTree.Keys, StringComparer.Ordinal);
        AllPaths.UnionWith(NewTree.Keys);

        foreach (var FilePath in AllPaths.OrderBy(P => P, StringComparer.Ordinal))
        {
            var HasOld = OldTree.TryGetValue(FilePath, out var OldHash);
            var HasNew = NewTree.TryGetValue(FilePath, out var NewHash);

            if (HasOld && HasNew)
            {
                if (!string.Equals(OldHash, NewHash, StringComparison.Ordinal))
                {
                    var DiffEntry = new GitDiffEntry
                    {
                        OldPath = FilePath,
                        NewPath = FilePath,
                        OldHash = OldHash!,
                        NewHash = NewHash!,
                        Status = GitDiffStatus.Modified,
                    };
                    DiffEntry.Hunks = ComputeHunks(OldHash!, NewHash!);
                    Results.Add(DiffEntry);
                }
            }
            else if (HasNew)
            {
                Results.Add(new GitDiffEntry
                {
                    NewPath = FilePath,
                    NewHash = NewHash!,
                    Status = GitDiffStatus.Added,
                });
            }
            else
            {
                Results.Add(new GitDiffEntry
                {
                    OldPath = FilePath,
                    OldHash = OldHash!,
                    Status = GitDiffStatus.Deleted,
                });
            }
        }

        return Results;
    }

    public string FormatDiff(List<GitDiffEntry> Entries)
    {
        var Sb = new StringBuilder();
        foreach (var Entry in Entries)
        {
            switch (Entry.Status)
            {
                case GitDiffStatus.Added:
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "diff --git a/{0} b/{0}", Entry.NewPath));
                    Sb.AppendLine("new file mode 100644");
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "--- /dev/null"));
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "+++ b/{0}", Entry.NewPath));
                    break;

                case GitDiffStatus.Deleted:
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "diff --git a/{0} b/{0}", Entry.OldPath));
                    Sb.AppendLine("deleted file mode 100644");
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "--- a/{0}", Entry.OldPath));
                    Sb.AppendLine("+++ /dev/null");
                    break;

                case GitDiffStatus.Modified:
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "diff --git a/{0} b/{1}", Entry.OldPath, Entry.NewPath));
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "--- a/{0}", Entry.OldPath));
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "+++ b/{0}", Entry.NewPath));
                    break;
            }

            foreach (var Hunk in Entry.Hunks)
            {
                Sb.AppendLine(Hunk.Header);
                foreach (var Line in Hunk.Lines)
                {
                    var Prefix = Line.Type switch
                    {
                        GitDiffLineType.Addition => "+",
                        GitDiffLineType.Deletion => "-",
                        _ => " ",
                    };
                    Sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}{1}", Prefix, Line.Content));
                }
            }
        }

        return Sb.ToString();
    }

    private void FlattenTree(string TreeHash, string Prefix, Dictionary<string, string> Result)
    {
        var Entries = Repo.GetTree(TreeHash);
        foreach (var Entry in Entries)
        {
            var FullPath = string.IsNullOrEmpty(Prefix)
                ? Entry.Name
                : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", Prefix, Entry.Name);

            if (Entry.IsDirectory)
            {
                FlattenTree(Entry.Hash, FullPath, Result);
            }
            else
            {
                Result[FullPath] = Entry.Hash;
            }
        }
    }

    private List<GitDiffHunk> ComputeHunks(string OldHash, string NewHash)
    {
        var OldContent = Repo.GetBlobContent(OldHash);
        var NewContent = Repo.GetBlobContent(NewHash);
        if (OldContent is null || NewContent is null)
        {
            return new List<GitDiffHunk>();
        }

        var OldLines = Encoding.UTF8.GetString(OldContent).Split('\n');
        var NewLines = Encoding.UTF8.GetString(NewContent).Split('\n');

        return ComputeMyersDiff(OldLines, NewLines);
    }

    private static List<GitDiffHunk> ComputeMyersDiff(string[] OldLines, string[] NewLines)
    {
        // Simple LCS-based diff (O(NM) but sufficient for most files)
        var N = OldLines.Length;
        var M = NewLines.Length;

        // Build edit script using simple comparison
        var DiffLines = new List<(GitDiffLineType Type, string Content, int OldLine, int NewLine)>();
        var OldIdx = 0;
        var NewIdx = 0;

        while (OldIdx < N && NewIdx < M)
        {
            if (string.Equals(OldLines[OldIdx], NewLines[NewIdx], StringComparison.Ordinal))
            {
                DiffLines.Add((GitDiffLineType.Context, OldLines[OldIdx], OldIdx, NewIdx));
                OldIdx++;
                NewIdx++;
            }
            else
            {
                // Look ahead to find next match
                var OldLook = FindNext(OldLines, NewLines[NewIdx], OldIdx, Math.Min(OldIdx + 5, N));
                var NewLook = FindNext(NewLines, OldLines[OldIdx], NewIdx, Math.Min(NewIdx + 5, M));

                if (OldLook >= 0 && (NewLook < 0 || OldLook - OldIdx <= NewLook - NewIdx))
                {
                    // Delete old lines until match
                    while (OldIdx < OldLook)
                    {
                        DiffLines.Add((GitDiffLineType.Deletion, OldLines[OldIdx], OldIdx, GitConstants.NotFound));
                        OldIdx++;
                    }
                }
                else if (NewLook >= 0)
                {
                    // Add new lines until match
                    while (NewIdx < NewLook)
                    {
                        DiffLines.Add((GitDiffLineType.Addition, NewLines[NewIdx], GitConstants.NotFound, NewIdx));
                        NewIdx++;
                    }
                }
                else
                {
                    // No match found — delete old, add new
                    DiffLines.Add((GitDiffLineType.Deletion, OldLines[OldIdx], OldIdx, -1));
                    DiffLines.Add((GitDiffLineType.Addition, NewLines[NewIdx], -1, NewIdx));
                    OldIdx++;
                    NewIdx++;
                }
            }
        }

        while (OldIdx < N)
        {
            DiffLines.Add((GitDiffLineType.Deletion, OldLines[OldIdx], OldIdx, -1));
            OldIdx++;
        }

        while (NewIdx < M)
        {
            DiffLines.Add((GitDiffLineType.Addition, NewLines[NewIdx], -1, NewIdx));
            NewIdx++;
        }

        // Group into hunks
        return GroupIntoHunks(DiffLines);
    }

    private static int FindNext(string[] Lines, string Target, int Start, int End)
    {
        for (var I = Start; I < End; I++)
        {
            if (string.Equals(Lines[I], Target, StringComparison.Ordinal))
            {
                return I;
            }
        }

        return GitConstants.NotFound;
    }

    private static List<GitDiffHunk> GroupIntoHunks(List<(GitDiffLineType Type, string Content, int OldLine, int NewLine)> DiffLines)
    {
        var Hunks = new List<GitDiffHunk>();
        if (DiffLines.Count == 0)
        {
            return Hunks;
        }

        const int ContextSize = 3;
        var CurrentHunk = new GitDiffHunk();
        var InHunk = false;
        var LastChangeIdx = GitConstants.NotFound;

        for (var I = 0; I < DiffLines.Count; I++)
        {
            var Line = DiffLines[I];
            var IsChange = Line.Type != GitDiffLineType.Context;

            if (IsChange)
            {
                if (!InHunk)
                {
                    CurrentHunk = new GitDiffHunk();
                    var StartOld = Math.Max(0, I - ContextSize);
                    var StartNew = 0;

                    // Add leading context
                    for (var J = StartOld; J < I; J++)
                    {
                        if (DiffLines[J].Type == GitDiffLineType.Context)
                        {
                            CurrentHunk.Lines.Add(new GitDiffLine { Type = GitDiffLineType.Context, Content = DiffLines[J].Content });
                        }
                    }

                    CurrentHunk.OldStart = Line.OldLine >= 0 ? Line.OldLine + 1 : (I > 0 ? DiffLines[I - 1].OldLine + 2 : 1);
                    CurrentHunk.NewStart = Line.NewLine >= 0 ? Line.NewLine + 1 : (I > 0 ? DiffLines[I - 1].NewLine + 2 : 1);
                    InHunk = true;
                }

                CurrentHunk.Lines.Add(new GitDiffLine { Type = Line.Type, Content = Line.Content });
                LastChangeIdx = I;
            }
            else if (InHunk)
            {
                if (I - LastChangeIdx > ContextSize)
                {
                    // Finalize hunk with trailing context
                    UpdateHunkCounts(CurrentHunk);
                    CurrentHunk.Header = string.Format(CultureInfo.InvariantCulture, "@@ -{0},{1} +{2},{3} @@",
                        CurrentHunk.OldStart, CurrentHunk.OldCount, CurrentHunk.NewStart, CurrentHunk.NewCount);
                    Hunks.Add(CurrentHunk);
                    InHunk = false;
                }
                else
                {
                    CurrentHunk.Lines.Add(new GitDiffLine { Type = GitDiffLineType.Context, Content = Line.Content });
                }
            }
        }

        if (InHunk)
        {
            UpdateHunkCounts(CurrentHunk);
            CurrentHunk.Header = string.Format(CultureInfo.InvariantCulture, "@@ -{0},{1} +{2},{3} @@",
                CurrentHunk.OldStart, CurrentHunk.OldCount, CurrentHunk.NewStart, CurrentHunk.NewCount);
            Hunks.Add(CurrentHunk);
        }

        return Hunks;
    }

    private static void UpdateHunkCounts(GitDiffHunk Hunk)
    {
        Hunk.OldCount = Hunk.Lines.Count(L => L.Type == GitDiffLineType.Context || L.Type == GitDiffLineType.Deletion);
        Hunk.NewCount = Hunk.Lines.Count(L => L.Type == GitDiffLineType.Context || L.Type == GitDiffLineType.Addition);
    }
}
#pragma warning restore SA1600
