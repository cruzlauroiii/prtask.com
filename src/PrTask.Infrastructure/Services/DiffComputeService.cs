using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public sealed partial class DiffComputeService : IDiffComputeService
{
    private static readonly Dictionary<string, string> ExtensionToLanguageMap = new(StringComparer.OrdinalIgnoreCase)
    {
        [DiffConstants.ExtensionCs] = DiffConstants.LanguageCSharp,
        [DiffConstants.ExtensionRazor] = DiffConstants.LanguageCSharp,
        [DiffConstants.ExtensionJs] = DiffConstants.LanguageJavaScript,
        [DiffConstants.ExtensionJsx] = DiffConstants.LanguageJavaScript,
        [DiffConstants.ExtensionTs] = DiffConstants.LanguageTypeScript,
        [DiffConstants.ExtensionTsx] = DiffConstants.LanguageTypeScript,
        [DiffConstants.ExtensionCss] = DiffConstants.LanguageCss,
        [DiffConstants.ExtensionScss] = DiffConstants.LanguageCss,
        [DiffConstants.ExtensionHtml] = DiffConstants.LanguageHtml,
        [DiffConstants.ExtensionHtm] = DiffConstants.LanguageHtml,
        [DiffConstants.ExtensionJson] = DiffConstants.LanguageJson,
        [DiffConstants.ExtensionXml] = DiffConstants.LanguageXml,
        [DiffConstants.ExtensionSql] = DiffConstants.LanguageSql,
        [DiffConstants.ExtensionPy] = DiffConstants.LanguagePython,
        [DiffConstants.ExtensionRs] = DiffConstants.LanguageRust,
        [DiffConstants.ExtensionGo] = DiffConstants.LanguageGo,
        [DiffConstants.ExtensionJava] = DiffConstants.LanguageJava,
        [DiffConstants.ExtensionRb] = DiffConstants.LanguageRuby
    };
    public DiffResultModel ComputeDiff(string OldText, string NewText)
    {
        var OldLines = SplitLines(OldText);
        var NewLines = SplitLines(NewText);
        var EditScript = ComputeEditScript(OldLines, NewLines);
        var InlineResult = new List<DiffLineModel>();
        var OldSideResult = new List<DiffLineModel>();
        var NewSideResult = new List<DiffLineModel>();
        var Additions = 0;
        var Deletions = 0;
        var OldIndex = 0;
        var NewIndex = 0;
        foreach (var Edit in EditScript)
        {
            switch (Edit)
            {
                case EditType.Keep:
                    var KeepLine = OldLines[OldIndex];
                    InlineResult.Add(new DiffLineModel { Type = DiffLineType.Unchanged, Text = KeepLine, OldLineNumber = OldIndex + 1, NewLineNumber = NewIndex + 1 });
                    OldSideResult.Add(new DiffLineModel { Type = DiffLineType.Unchanged, Text = KeepLine, OldLineNumber = OldIndex + 1, NewLineNumber = OldIndex + 1 });
                    NewSideResult.Add(new DiffLineModel { Type = DiffLineType.Unchanged, Text = KeepLine, OldLineNumber = NewIndex + 1, NewLineNumber = NewIndex + 1 });
                    OldIndex++;
                    NewIndex++;
                    break;
                case EditType.Delete:
                    var DeletedLine = OldLines[OldIndex];
                    InlineResult.Add(new DiffLineModel { Type = DiffLineType.Deleted, Text = DeletedLine, OldLineNumber = OldIndex + 1 });
                    OldSideResult.Add(new DiffLineModel { Type = DiffLineType.Deleted, Text = DeletedLine, OldLineNumber = OldIndex + 1, NewLineNumber = OldIndex + 1 });
                    NewSideResult.Add(new DiffLineModel { Type = DiffLineType.Imaginary, Text = string.Empty });
                    OldIndex++;
                    Deletions++;
                    break;
                case EditType.Insert:
                    var InsertedLine = NewLines[NewIndex];
                    InlineResult.Add(new DiffLineModel { Type = DiffLineType.Added, Text = InsertedLine, NewLineNumber = NewIndex + 1 });
                    OldSideResult.Add(new DiffLineModel { Type = DiffLineType.Imaginary, Text = string.Empty });
                    NewSideResult.Add(new DiffLineModel { Type = DiffLineType.Added, Text = InsertedLine, OldLineNumber = NewIndex + 1, NewLineNumber = NewIndex + 1 });
                    NewIndex++;
                    Additions++;
                    break;
            }
        }
        return new DiffResultModel
        {
            InlineLines = InlineResult,
            OldLines = OldSideResult,
            NewLines = NewSideResult,
            Additions = Additions,
            Deletions = Deletions,
            Modifications = 0
        };
    }
    public string DetectLanguage(string FileName)
    {
        if (string.IsNullOrEmpty(FileName)) { return DiffConstants.LanguagePlainText; }
        var ExtensionIndex = FileName.LastIndexOf('.');
        if (ExtensionIndex < 0) { return DiffConstants.LanguagePlainText; }
        var Extension = FileName[ExtensionIndex..];
        return ExtensionToLanguageMap.GetValueOrDefault(Extension, DiffConstants.LanguagePlainText);
    }
    private static string[] SplitLines(string Text) =>
        string.IsNullOrEmpty(Text) ? [] : Text.Split('\n');
    private static List<EditType> ComputeEditScript(string[] OldLines, string[] NewLines)
    {
        var OldLength = OldLines.Length;
        var NewLength = NewLines.Length;
        var Max = OldLength + NewLength;
        if (Max == 0) { return []; }
        var ArraySize = (2 * Max) + 1;
        var ForwardV = new int[ArraySize];
        Array.Fill(ForwardV, -1);
        var Trace = new List<int[]>();
        for (var D = 0; D <= Max; D++)
        {
            var Snapshot = new int[ArraySize];
            Array.Copy(ForwardV, Snapshot, ForwardV.Length);
            Trace.Add(Snapshot);
            for (var K = -D; K <= D; K += 2)
            {
                var Index = K + Max;
                int X;
                if (K == -D || (K != D && ForwardV[Index - 1] < ForwardV[Index + 1]))
                {
                    X = ForwardV[Index + 1];
                }
                else
                {
                    X = ForwardV[Index - 1] + 1;
                }
                var Y = X - K;
                while (X < OldLength && Y < NewLength && OldLines[X] == NewLines[Y])
                {
                    X++;
                    Y++;
                }
                ForwardV[Index] = X;
                if (X >= OldLength && Y >= NewLength)
                {
                    return BuildEditScript(Trace, OldLines, NewLines, Max);
                }
            }
        }
        return BuildEditScript(Trace, OldLines, NewLines, Max);
    }
    private static List<EditType> BuildEditScript(List<int[]> Trace, string[] OldLines, string[] NewLines, int Max)
    {
        var X = OldLines.Length;
        var Y = NewLines.Length;
        var Result = new List<EditType>();
        for (var D = Trace.Count - 1; D > 0; D--)
        {
            var V = Trace[D - 1];
            var K = X - Y;
            var Index = K + Max;
            int PrevX;
            int PrevY;
            if (K == -D || (K != D && V[Index - 1] < V[Index + 1]))
            {
                PrevX = V[Index + 1];
                PrevY = PrevX - (K + 1);
            }
            else
            {
                PrevX = V[Index - 1] + 1;
                PrevY = PrevX - K;
            }
            while (X > PrevX && Y > PrevY)
            {
                Result.Add(EditType.Keep);
                X--;
                Y--;
            }
            if (D > 0)
            {
                if (X == PrevX)
                {
                    Result.Add(EditType.Insert);
                    Y--;
                }
                else if (Y == PrevY)
                {
                    Result.Add(EditType.Delete);
                    X--;
                }
            }
        }
        while (X > 0 && Y > 0)
        {
            Result.Add(EditType.Keep);
            X--;
            Y--;
        }
        Result.Reverse();
        return Result;
    }
    private enum EditType
    {
        Keep = 0,
        Insert = 1,
        Delete = 2
    }
}
