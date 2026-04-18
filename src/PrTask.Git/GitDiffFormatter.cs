using System.Globalization;
using System.Text;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
public sealed partial class GitDiff
{
    public IList<GitDiffEntry> DiffCommits(string OldCommitHash, string NewCommitHash)
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

        foreach (var FilePath in AllPaths.Order(StringComparer.Ordinal))
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
                    foreach (var Hunk in ComputeHunks(OldHash!, NewHash!))
                    {
                        DiffEntry.Hunks.Add(Hunk);
                    }

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

    public string FormatDiff(IList<GitDiffEntry> Entries)
    {
        var Sb = new StringBuilder();
        foreach (var Entry in Entries)
        {
            FormatDiffEntry(Sb, Entry);

            foreach (var Hunk in Entry.Hunks)
            {
                Sb.AppendLine(Hunk.Header);
                foreach (var Line in Hunk.Lines)
                {
                    var Prefix = Line.Type switch
                    {
                        GitDiffLineType.Addition => GitConstants.DiffLineAddPrefix,
                        GitDiffLineType.Deletion => GitConstants.DiffLineDeletionPrefix,
                        GitDiffLineType.Context => GitConstants.DiffLineContextPrefix,
                        _ => GitConstants.DiffLineContextPrefix,
                    };
                    Sb.AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffLineFormat, Prefix, Line.Content).AppendLine();
                }
            }
        }

        return Sb.ToString();
    }

    private static void FormatDiffEntry(StringBuilder Sb, GitDiffEntry Entry)
    {
        switch (Entry.Status)
        {
            case GitDiffStatus.Added:
                Sb.AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffGitHeaderFormat, Entry.NewPath).AppendLine()
                    .AppendLine(GitConstants.DiffNewFileMode)
                    .AppendLine(GitConstants.DiffOldDevNull)
                    .AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffNewPathFormat, Entry.NewPath).AppendLine();
                break;

            case GitDiffStatus.Deleted:
                Sb.AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffGitHeaderFormat, Entry.OldPath).AppendLine()
                    .AppendLine(GitConstants.DiffDeletedFileMode)
                    .AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffOldPathFormat, Entry.OldPath).AppendLine()
                    .AppendLine(GitConstants.DiffNewDevNull);
                break;

            case GitDiffStatus.Modified:
                Sb.AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffGitHeaderTwoPathFormat, Entry.OldPath, Entry.NewPath).AppendLine()
                    .AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffOldPathFormat, Entry.OldPath).AppendLine()
                    .AppendFormat(CultureInfo.InvariantCulture, GitConstants.DiffNewPathFormat, Entry.NewPath).AppendLine();
                break;

            case GitDiffStatus.Renamed:
            case GitDiffStatus.Copied:
                break;
        }
    }
}
#pragma warning restore SA1600
