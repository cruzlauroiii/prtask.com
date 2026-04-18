using System.Globalization;
using PrTask.Git.Models;

namespace PrTask.Git;

#pragma warning disable SA1600
internal static class GitDiffAlgorithm
{
    internal static IList<GitDiffHunk> ComputeMyersDiff(string[] OldLines, string[] NewLines)
    {
        var N = OldLines.Length;
        var M = NewLines.Length;

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
                var OldLook = FindNext(OldLines, NewLines[NewIdx], OldIdx, Math.Min(OldIdx + GitConstants.LookaheadDistance, N));
                var NewLook = FindNext(NewLines, OldLines[OldIdx], NewIdx, Math.Min(NewIdx + GitConstants.LookaheadDistance, M));

                if (OldLook >= 0 && (NewLook < 0 || OldLook - OldIdx <= NewLook - NewIdx))
                {
                    while (OldIdx < OldLook)
                    {
                        DiffLines.Add((GitDiffLineType.Deletion, OldLines[OldIdx], OldIdx, GitConstants.NotFound));
                        OldIdx++;
                    }
                }
                else if (NewLook >= 0)
                {
                    while (NewIdx < NewLook)
                    {
                        DiffLines.Add((GitDiffLineType.Addition, NewLines[NewIdx], GitConstants.NotFound, NewIdx));
                        NewIdx++;
                    }
                }
                else
                {
                    DiffLines.Add((GitDiffLineType.Deletion, OldLines[OldIdx], OldIdx, GitConstants.NotFound));
                    DiffLines.Add((GitDiffLineType.Addition, NewLines[NewIdx], GitConstants.NotFound, NewIdx));
                    OldIdx++;
                    NewIdx++;
                }
            }
        }

        while (OldIdx < N)
        {
            DiffLines.Add((GitDiffLineType.Deletion, OldLines[OldIdx], OldIdx, GitConstants.NotFound));
            OldIdx++;
        }

        while (NewIdx < M)
        {
            DiffLines.Add((GitDiffLineType.Addition, NewLines[NewIdx], GitConstants.NotFound, NewIdx));
            NewIdx++;
        }

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

    private static Collection<GitDiffHunk> GroupIntoHunks(List<(GitDiffLineType Type, string Content, int OldLine, int NewLine)> DiffLines)
    {
        var Hunks = new Collection<GitDiffHunk>();
        if (DiffLines.Count == 0)
        {
            return Hunks;
        }

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
                    var StartOld = Math.Max(0, I - GitConstants.DiffContextSize);

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
                if (I - LastChangeIdx > GitConstants.DiffContextSize)
                {
                    UpdateHunkCounts(CurrentHunk);
                    CurrentHunk.Header = string.Format(CultureInfo.InvariantCulture, GitConstants.HunkHeaderFormat,
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
            CurrentHunk.Header = string.Format(CultureInfo.InvariantCulture, GitConstants.HunkHeaderFormat,
                CurrentHunk.OldStart, CurrentHunk.OldCount, CurrentHunk.NewStart, CurrentHunk.NewCount);
            Hunks.Add(CurrentHunk);
        }

        return Hunks;
    }

    private static void UpdateHunkCounts(GitDiffHunk Hunk)
    {
        Hunk.OldCount = Hunk.Lines.Count(L => L.Type is GitDiffLineType.Context or GitDiffLineType.Deletion);
        Hunk.NewCount = Hunk.Lines.Count(L => L.Type is GitDiffLineType.Context or GitDiffLineType.Addition);
    }
}
#pragma warning restore SA1600
