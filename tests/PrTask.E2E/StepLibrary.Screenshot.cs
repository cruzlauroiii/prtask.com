using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task ScreenshotAsync(string Label, string? StepNumber = null, string? Prefix = null)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = BuildScreenshotFileName(Label, StepNumber, Prefix);
        var Bytes = await BrowserPage.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, FileName), Bytes);
    }
    private static string BuildScreenshotFileName(string Label, string? StepNumber, string? Prefix)
    {
        var Parts = new List<string>();
        if (!string.IsNullOrEmpty(Prefix))
        {
            Parts.Add(Prefix);
        }
        if (!string.IsNullOrEmpty(StepNumber))
        {
            Parts.Add(StepNumber);
        }
        Parts.Add(Label);
        var BaseName = string.Join("-", Parts);
        if (!BaseName.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
        {
            BaseName += ".png";
        }
        return BaseName;
    }
    private static Task VerifyScreenshotsExistAsync(string[] FileNames)
    {
        foreach (var FileName in FileNames)
        {
            var FilePath = Path.Combine(ScreenshotDir, FileName);
            Assert.IsTrue(File.Exists(FilePath), $"Screenshot '{FileName}' must exist at {FilePath}");
            var Size = new FileInfo(FilePath).Length;
            Assert.IsTrue(Size > E2EWorkflowConstants.MinScreenshotBytes,
                $"Screenshot '{FileName}' must be > {E2EWorkflowConstants.MinScreenshotBytes} bytes, got {Size} bytes");
        }
        return Task.CompletedTask;
    }
    private static string GetScreenshotPath(string Label)
    {
        var FileName = Label.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ? Label : $"{Label}.png";
        return Path.Combine(ScreenshotDir, FileName);
    }
}
