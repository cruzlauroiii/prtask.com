namespace PrTask.E2E;
public partial class ArchitectureTests
{
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("No single line or block comments should exist in any source file")]
    public void TNoComments01NoSingleLineOrBlockCommentsShouldExistInAnySourceFile()
    {
        var Violations = new List<string>();
        foreach (var FilePath in GetSourceFiles(".cs").Concat(GetSourceFiles(".razor")))
        {
            var Lines = File.ReadAllLines(FilePath);
            for (var I = 0; I < Lines.Length; I++)
            {
                var Trimmed = Lines[I].Trim();
                if (Trimmed.StartsWith("///"))
                {
                    continue;
                }
                if (IsRealComment(Trimmed))
                {
                    Violations.Add($"{Path.GetFileName(FilePath)}:{I + 1}");
                }
            }
        }
        Assert.AreEqual(0, Violations.Count, $"Comments found in: {string.Join(", ", Violations.Take(10))}");
    }
    private static bool IsRealComment(string Trimmed) =>
        (Trimmed.StartsWith("//") && !Trimmed.StartsWith("///"))
        || (Trimmed.Contains("/*") && !IsInsideStringLiteral(Trimmed, Trimmed.IndexOf("/*")));
    private static bool IsInsideStringLiteral(string Line, int Position)
    {
        var QuoteCount = 0;
        for (var I = 0; I < Position; I++)
        {
            if (Line[I] == '"' && (I == 0 || Line[I - 1] != '\\'))
            {
                QuoteCount++;
            }
        }
        return QuoteCount % 2 != 0;
    }
}
