using System.Globalization;
using System.Text;
using PrTask.GitNative.Models;

namespace PrTask.GitNative;

#pragma warning disable SA1600
public static class GitDiff
{
    private const int ContextLines = 3;

    public static List<GitDiffEntry> DiffTrees(GitRepository Repo, string OldTreeHash, string NewTreeHash, string Prefix = "")
    {
        var Diffs = new List<GitDiffEntry>();

        var OldEntries = string.IsNullOrEmpty(OldTreeHash)
            ? new Dictionary<string, GitTreeEntry>(StringComparer.Ordinal)
            : ReadTreeEntries(Repo, OldTreeHash);

        var NewEntries = string.IsNullOrEmpty(NewTreeHash)
            ? new Dictionary<string, GitTreeEntry>(StringComparer.Ordinal)
            : ReadTreeEntries(Repo, NewTreeHash);

        var AllNames = new HashSet<string>(StringComparer.Ordinal);
        foreach (var Key in OldEntries.Keys)
        {
            AllNames.Add(Key);
        }

        foreach (var Key in NewEntries.Keys)
        {
            AllNames.Add(Key);
        }

        foreach (var Name in AllNames.OrderBy(N => N, StringComparer.Ordinal))
        {
            OldEntries.TryGetValue(Name, out var OldEntry);
            NewEntries.TryGetValue(Name, out var NewEntry);
            var FullPath = string.IsNullOrEmpty(Prefix) ? Name : Prefix + "/" + Name;

            if (OldEntry is null && NewEntry is not null)
            {
                // Added
                if (NewEntry.IsDirectory)
                {
                    Diffs.AddRange(DiffTrees(Repo, string.Empty, NewEntry.Hash, FullPath));
                }
                else
                {
                    Diffs.Add(CreateDiffEntry(Repo, string.Empty, NewEntry.Hash, FullPath, FullPath, GitDiffStatus.Added));
                }
            }
            else if (OldEntry is not null && NewEntry is null)
            {
                // Deleted
                if (OldEntry.IsDirectory)
                {
                    Diffs.AddRange(DiffTrees(Repo, OldEntry.Hash, string.Empty, FullPath));
                }
                else
                {
                    Diffs.Add(CreateDiffEntry(Repo, OldEntry.Hash, string.Empty, FullPath, FullPath, GitDiffStatus.Deleted));
                }
            }
            else if (OldEntry is not null && NewEntry is not null && OldEntry.Hash != NewEntry.Hash)
            {
                // Modified
                if (OldEntry.IsDirectory && NewEntry.IsDirectory)
                {
                    Diffs.AddRange(DiffTrees(Repo, OldEntry.Hash, NewEntry.Hash, FullPath));
                }
                else if (OldEntry.IsDirectory && !NewEntry.IsDirectory)
                {
                    Diffs.AddRange(DiffTrees(Repo, OldEntry.Hash, string.Empty, FullPath));
                    Diffs.Add(CreateDiffEntry(Repo, string.Empty, NewEntry.Hash, FullPath, FullPath, GitDiffStatus.Added));
                }
                else if (!OldEntry.IsDirectory && NewEntry.IsDirectory)
                {
                    Diffs.Add(CreateDiffEntry(Repo, OldEntry.Hash, string.Empty, FullPath, FullPath, GitDiffStatus.Deleted));
                    Diffs.AddRange(DiffTrees(Repo, string.Empty, NewEntry.Hash, FullPath));
                }
                else
                {
                    Diffs.Add(CreateDiffEntry(Repo, OldEntry.Hash, NewEntry.Hash, FullPath, FullPath, GitDiffStatus.Modified));
                }
            }
        }

        return Diffs;
    }

    public static List<GitDiffEntry> DiffCommits(GitRepository Repo, string OldCommitHash, string NewCommitHash)
    {
        var OldCommit = Repo.ReadCommit(OldCommitHash);
        var NewCommit = Repo.ReadCommit(NewCommitHash);

        var OldTree = OldCommit?.TreeHash ?? string.Empty;
        var NewTree = NewCommit?.TreeHash ?? string.Empty;

        return DiffTrees(Repo, OldTree, NewTree);
    }

    public static string FormatUnifiedDiff(GitDiffEntry Entry)
    {
        var Sb = new StringBuilder();
        Sb.Append(CultureInfo.InvariantCulture, $"diff --git a/{Entry.OldPath} b/{Entry.NewPath}\n");

        if (Entry.Status == GitDiffStatus.Added)
        {
            Sb.Append("new file mode 100644\n");
            Sb.Append("--- /dev/null\n");
            Sb.Append(CultureInfo.InvariantCulture, $"+++ b/{Entry.NewPath}\n");
        }
        else if (Entry.Status == GitDiffStatus.Deleted)
        {
            Sb.Append("deleted file mode 100644\n");
            Sb.Append(CultureInfo.InvariantCulture, $"--- a/{Entry.OldPath}\n");
            Sb.Append("+++ /dev/null\n");
        }
        else
        {
            Sb.Append(CultureInfo.InvariantCulture, $"--- a/{Entry.OldPath}\n");
            Sb.Append(CultureInfo.InvariantCulture, $"+++ b/{Entry.NewPath}\n");
        }

        foreach (var Hunk in Entry.Hunks)
        {
            Sb.Append(CultureInfo.InvariantCulture, $"@@ -{Hunk.OldStart},{Hunk.OldCount} +{Hunk.NewStart},{Hunk.NewCount} @@");
            if (!string.IsNullOrEmpty(Hunk.Header))
            {
                Sb.Append(CultureInfo.InvariantCulture, $" {Hunk.Header}");
            }

            Sb.Append('\n');

            foreach (var Line in Hunk.Lines)
            {
                var Prefix = Line.Type switch
                {
                    GitDiffLineType.Addition => "+",
                    GitDiffLineType.Deletion => "-",
                    _ => " ",
                };
                Sb.Append(CultureInfo.InvariantCulture, $"{Prefix}{Line.Content}\n");
            }
        }

        return Sb.ToString();
    }

    public static string FormatAllDiffs(List<GitDiffEntry> Entries)
    {
        var Sb = new StringBuilder();
        foreach (var Entry in Entries)
        {
            Sb.Append(FormatUnifiedDiff(Entry));
        }

        return Sb.ToString();
    }

    private static GitDiffEntry CreateDiffEntry(
        GitRepository Repo, string OldHash, string NewHash,
        string OldPath, string NewPath, GitDiffStatus Status)
    {
        var Entry = new GitDiffEntry
        {
            OldPath = OldPath,
            NewPath = NewPath,
            OldHash = OldHash,
            NewHash = NewHash,
            Status = Status,
        };

        var OldLines = GetFileLines(Repo, OldHash);
        var NewLines = GetFileLines(Repo, NewHash);

        Entry.Hunks = ComputeHunks(OldLines, NewLines);
        return Entry;
    }

    private static string[] GetFileLines(GitRepository Repo, string Hash)
    {
        if (string.IsNullOrEmpty(Hash))
        {
            return [];
        }

        var Blob = Repo.ReadBlob(Hash);
        if (Blob is null)
        {
            return [];
        }

        return Blob.GetText().Split('\n');
    }

    private static Dictionary<string, GitTreeEntry> ReadTreeEntries(GitRepository Repo, string TreeHash)
    {
        var Raw = Repo.ReadObject(TreeHash);
        if (Raw is null || Raw.Type != GitObjectType.Tree)
        {
            return new Dictionary<string, GitTreeEntry>(StringComparer.Ordinal);
        }

        var Entries = GitObjects.ParseTree(Raw.Data);
        var Dict = new Dictionary<string, GitTreeEntry>(StringComparer.Ordinal);
        foreach (var Entry in Entries)
        {
            Dict[Entry.Name] = Entry;
        }

        return Dict;
    }

    private static List<GitDiffHunk> ComputeHunks(string[] OldLines, string[] NewLines)
    {
        var Hunks = new List<GitDiffHunk>();

        // Myers diff algorithm (simplified)
        var Edits = ComputeEdits(OldLines, NewLines);
        if (Edits.Count == 0)
        {
            return Hunks;
        }

        // Group edits into hunks with context
        var HunkEdits = new List<List<DiffEdit>>();
        var CurrentHunk = new List<DiffEdit>();

        foreach (var Edit in Edits)
        {
            if (CurrentHunk.Count > 0)
            {
                var LastEdit = CurrentHunk[^1];
                var Gap = Edit.OldIndex - (LastEdit.OldIndex + (LastEdit.Type == DiffEditType.Delete ? 1 : 0));
                if (Gap > ContextLines * 2)
                {
                    HunkEdits.Add(CurrentHunk);
                    CurrentHunk = new List<DiffEdit>();
                }
            }

            CurrentHunk.Add(Edit);
        }

        if (CurrentHunk.Count > 0)
        {
            HunkEdits.Add(CurrentHunk);
        }

        foreach (var HunkEditGroup in HunkEdits)
        {
            var FirstEdit = HunkEditGroup[0];
            var LastEdit = HunkEditGroup[^1];

            var OldStart = Math.Max(0, FirstEdit.OldIndex - ContextLines);
            var NewStart = Math.Max(0, FirstEdit.NewIndex - ContextLines);
            var OldEnd = Math.Min(OldLines.Length, (LastEdit.Type == DiffEditType.Delete ? LastEdit.OldIndex + 1 : LastEdit.OldIndex) + ContextLines);
            var NewEnd = Math.Min(NewLines.Length, (LastEdit.Type == DiffEditType.Insert ? LastEdit.NewIndex + 1 : LastEdit.NewIndex) + ContextLines);

            var Hunk = new GitDiffHunk
            {
                OldStart = OldStart + 1,
                OldCount = OldEnd - OldStart,
                NewStart = NewStart + 1,
                NewCount = NewEnd - NewStart,
            };

            // Build hunk lines with context
            var OldPos = OldStart;
            var NewPos = NewStart;
            var EditIdx = 0;

            while (OldPos < OldEnd || NewPos < NewEnd)
            {
                if (EditIdx < HunkEditGroup.Count)
                {
                    var Edit = HunkEditGroup[EditIdx];

                    // Add context lines before this edit
                    while (OldPos < Edit.OldIndex && OldPos < OldEnd)
                    {
                        Hunk.Lines.Add(new GitDiffLine { Type = GitDiffLineType.Context, Content = OldLines[OldPos] });
                        OldPos++;
                        NewPos++;
                    }

                    if (Edit.Type == DiffEditType.Delete)
                    {
                        Hunk.Lines.Add(new GitDiffLine { Type = GitDiffLineType.Deletion, Content = OldLines[Edit.OldIndex] });
                        OldPos++;
                        EditIdx++;
                    }
                    else if (Edit.Type == DiffEditType.Insert)
                    {
                        Hunk.Lines.Add(new GitDiffLine { Type = GitDiffLineType.Addition, Content = NewLines[Edit.NewIndex] });
                        NewPos++;
                        EditIdx++;
                    }
                }
                else
                {
                    // Trailing context
                    if (OldPos < OldEnd && OldPos < OldLines.Length)
                    {
                        Hunk.Lines.Add(new GitDiffLine { Type = GitDiffLineType.Context, Content = OldLines[OldPos] });
                    }

                    OldPos++;
                    NewPos++;
                }
            }

            Hunks.Add(Hunk);
        }

        return Hunks;
    }

    private static List<DiffEdit> ComputeEdits(string[] OldLines, string[] NewLines)
    {
        var Edits = new List<DiffEdit>();

        // LCS-based diff using dynamic programming
        var OldLen = OldLines.Length;
        var NewLen = NewLines.Length;

        // For large files, use a simplified approach
        if (OldLen + NewLen > 20000)
        {
            return ComputeSimpleEdits(OldLines, NewLines);
        }

        // Build LCS table
        var Lcs = new int[OldLen + 1, NewLen + 1];
        for (var I = OldLen - 1; I >= 0; I--)
        {
            for (var J = NewLen - 1; J >= 0; J--)
            {
                if (OldLines[I] == NewLines[J])
                {
                    Lcs[I, J] = Lcs[I + 1, J + 1] + 1;
                }
                else
                {
                    Lcs[I, J] = Math.Max(Lcs[I + 1, J], Lcs[I, J + 1]);
                }
            }
        }

        // Trace back to find edits
        var OldIdx = 0;
        var NewIdx = 0;
        while (OldIdx < OldLen && NewIdx < NewLen)
        {
            if (OldLines[OldIdx] == NewLines[NewIdx])
            {
                OldIdx++;
                NewIdx++;
            }
            else if (Lcs[OldIdx + 1, NewIdx] >= Lcs[OldIdx, NewIdx + 1])
            {
                Edits.Add(new DiffEdit { Type = DiffEditType.Delete, OldIndex = OldIdx, NewIndex = NewIdx });
                OldIdx++;
            }
            else
            {
                Edits.Add(new DiffEdit { Type = DiffEditType.Insert, OldIndex = OldIdx, NewIndex = NewIdx });
                NewIdx++;
            }
        }

        while (OldIdx < OldLen)
        {
            Edits.Add(new DiffEdit { Type = DiffEditType.Delete, OldIndex = OldIdx, NewIndex = NewIdx });
            OldIdx++;
        }

        while (NewIdx < NewLen)
        {
            Edits.Add(new DiffEdit { Type = DiffEditType.Insert, OldIndex = OldIdx, NewIndex = NewIdx });
            NewIdx++;
        }

        return Edits;
    }

    private static List<DiffEdit> ComputeSimpleEdits(string[] OldLines, string[] NewLines)
    {
        var Edits = new List<DiffEdit>();

        // For large files, use line-by-line hashing with a simpler approach
        var OldSet = new Dictionary<string, List<int>>(StringComparer.Ordinal);
        for (var I = 0; I < OldLines.Length; I++)
        {
            if (!OldSet.TryGetValue(OldLines[I], out var Positions))
            {
                Positions = new List<int>();
                OldSet[OldLines[I]] = Positions;
            }

            Positions.Add(I);
        }

        var Matched = new bool[OldLines.Length];
        var NewMatched = new bool[NewLines.Length];

        // Find exact matches greedily
        for (var J = 0; J < NewLines.Length; J++)
        {
            if (OldSet.TryGetValue(NewLines[J], out var Positions))
            {
                foreach (var I in Positions)
                {
                    if (!Matched[I])
                    {
                        Matched[I] = true;
                        NewMatched[J] = true;
                        break;
                    }
                }
            }
        }

        for (var I = 0; I < OldLines.Length; I++)
        {
            if (!Matched[I])
            {
                Edits.Add(new DiffEdit { Type = DiffEditType.Delete, OldIndex = I, NewIndex = 0 });
            }
        }

        for (var J = 0; J < NewLines.Length; J++)
        {
            if (!NewMatched[J])
            {
                Edits.Add(new DiffEdit { Type = DiffEditType.Insert, OldIndex = OldLines.Length, NewIndex = J });
            }
        }

        return Edits.OrderBy(E => E.Type == DiffEditType.Delete ? E.OldIndex : E.NewIndex).ToList();
    }

    private enum DiffEditType
    {
        Delete,
        Insert,
    }

    private struct DiffEdit
    {
        public DiffEditType Type;
        public int OldIndex;
        public int NewIndex;
    }
}
#pragma warning restore SA1600
