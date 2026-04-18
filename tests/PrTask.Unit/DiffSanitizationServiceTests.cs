using PrTask.Infrastructure.Services;
namespace PrTask.Unit;
[TestClass]
public class DiffSanitizationServiceTests
{
    private DiffSanitizationService Service { get; } = new();
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must redact directory paths from diff headers keeping only filename")]
    public void SanitizeMustRedactDirectoryPathsFromDiffHeadersKeepingOnlyFilename()
    {
        const string RawDiff = "diff --git a/src/services/auth.cs b/src/services/auth.cs";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.IsTrue(Result.Contains("auth.cs"));
        Assert.IsFalse(Result.Contains("src/services/"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must redact paths in plus plus plus and minus minus minus lines")]
    public void SanitizeMustRedactPathsInPlusPlusPlusAndMinusMinusMinusLines()
    {
        const string RawDiff = "--- a/src/deep/path/file.ts\n+++ b/src/deep/path/file.ts";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.IsTrue(Result.Contains("file.ts"));
        Assert.IsFalse(Result.Contains("src/deep/path/"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must preserve hunk headers unchanged")]
    public void SanitizeMustPreserveHunkHeadersUnchanged()
    {
        const string RawDiff = "@@ -10,5 +10,7 @@ namespace Foo";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual(RawDiff, Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must redact lines containing password assignments")]
    public void SanitizeMustRedactLinesContainingPasswordAssignments()
    {
        const string RawDiff = "+password = \"s3cret123\"";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual("+[REDACTED]", Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must redact lines containing api key assignments")]
    public void SanitizeMustRedactLinesContainingApiKeyAssignments()
    {
        const string RawDiff = "+api_key = \"abc123def456\"";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual("+[REDACTED]", Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must redact lines containing connection string assignments")]
    public void SanitizeMustRedactLinesContainingConnectionStringAssignments()
    {
        const string RawDiff = "-connection_string = \"Server=db;User=admin\"";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual("-[REDACTED]", Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must preserve normal added lines without secrets")]
    public void SanitizeMustPreserveNormalAddedLinesWithoutSecrets()
    {
        const string RawDiff = "+var Count = items.Length;";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual(RawDiff, Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must preserve normal removed lines without secrets")]
    public void SanitizeMustPreserveNormalRemovedLinesWithoutSecrets()
    {
        const string RawDiff = "-Console.WriteLine(\"hello\");";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual(RawDiff, Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must preserve context lines unchanged")]
    public void SanitizeMustPreserveContextLinesUnchanged()
    {
        const string RawDiff = " unchanged context line";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual(RawDiff, Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Extract extensions must return comma separated unique extensions from diff")]
    public void ExtractExtensionsMustReturnCommaSeparatedUniqueExtensionsFromDiff()
    {
        const string RawDiff = "diff --git a/foo.cs b/foo.cs\ndiff --git a/bar.ts b/bar.ts\ndiff --git a/baz.cs b/baz.cs\n";
        var Result = Service.ExtractFileExtensions(RawDiff);
        Assert.IsTrue(Result.Contains(".cs"));
        Assert.IsTrue(Result.Contains(".ts"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Extract extensions must return empty string for diff with no file extensions")]
    public void ExtractExtensionsMustReturnEmptyStringForDiffWithNoFileExtensions()
    {
        const string Input = "some random text";
        var Result = Service.ExtractFileExtensions(Input);
        Assert.AreEqual(string.Empty, Result);
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must handle complete multi section diff correctly")]
    public void SanitizeMustHandleCompleteMultiSectionDiffCorrectly()
    {
        const string RawDiff = "diff --git a/src/app/service.cs b/src/app/service.cs\n--- a/src/app/service.cs\n+++ b/src/app/service.cs\n@@ -1,3 +1,4 @@\n using System;\n+using System.Text;\n-secret = \"hunter2\"";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.IsTrue(Result.Contains("service.cs"));
        Assert.IsFalse(Result.Contains("src/app/"));
        Assert.IsTrue(Result.Contains("+using System.Text;"));
        Assert.IsTrue(Result.Contains("-[REDACTED]"));
    }
    [TestMethod, TestCategory("Unit")]
    [DisplayName("Sanitize must redact token assignments in added lines")]
    public void SanitizeMustRedactTokenAssignmentsInAddedLines()
    {
        const string RawDiff = "+token = \"ghp_abc123\"";
        var Result = Service.SanitizeDiffForPublicDisplay(RawDiff);
        Assert.AreEqual("+[REDACTED]", Result);
    }
}
