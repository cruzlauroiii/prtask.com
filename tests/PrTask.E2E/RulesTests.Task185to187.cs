namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PlainTextDbService uses LowDb.Net with LowDbDocument model and FormatStrings.CollectionFilePath")]
    public void Rule185LowDbNetIntegration()
    {
        var ServicePath = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "PlainTextDbService.cs");
        Assert.IsTrue(File.Exists(ServicePath), "PlainTextDbService.cs must exist");
        var Service = File.ReadAllText(ServicePath);
        Assert.IsTrue(Service.Contains("D20Tek.LowDb"),
            "PlainTextDbService must use D20Tek.LowDb namespace");
        Assert.IsTrue(Service.Contains("LowDbDocument"),
            "PlainTextDbService must use LowDbDocument model");
        Assert.IsTrue(Service.Contains("LowDbFactory"),
            "PlainTextDbService must use LowDbFactory");
        Assert.IsTrue(Service.Contains("CollectionFilePath"),
            "PlainTextDbService must use FormatStrings.CollectionFilePath");
        var ModelPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "LowDbDocument.cs");
        Assert.IsTrue(File.Exists(ModelPath), "LowDbDocument.cs must exist in Domain/Models");
        var Model = File.ReadAllText(ModelPath);
        Assert.IsTrue(Model.Contains("Items"),
            "LowDbDocument must have Items property");
        var FormatStr = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(FormatStr.Contains("CollectionFilePath"),
            "FormatStrings must have CollectionFilePath helper");
        var Csproj = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Infrastructure", "PrTask.Infrastructure.csproj"));
        Assert.IsTrue(Csproj.Contains("LowDb.Net"),
            "Infrastructure csproj must reference LowDb.Net package");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AutomergeNative exists with P/Invoke declarations and SyncService uses automerge")]
    public void Rule186AutomergeNativeInterop()
    {
        var NativePath = Path.Combine(SourceRoot, "PrTask.Infrastructure", "NativeMethods", "AutomergeNative.cs");
        Assert.IsTrue(File.Exists(NativePath), "AutomergeNative.cs must exist in Infrastructure/NativeMethods");
        var Native = File.ReadAllText(NativePath);
        Assert.IsTrue(Native.Contains("LibraryImport"),
            "AutomergeNative must use LibraryImport for P/Invoke");
        Assert.IsTrue(Native.Contains("AMcreate"),
            "AutomergeNative must declare AMcreate binding");
        Assert.IsTrue(Native.Contains("AMresultFree"),
            "AutomergeNative must declare AMresultFree binding");
        Assert.IsTrue(Native.Contains("AMmerge"),
            "AutomergeNative must declare AMmerge binding");
        var ServicePath = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "SyncService.cs");
        var Service = File.ReadAllText(ServicePath);
        Assert.IsTrue(Service.Contains("AutomergeNative"),
            "SyncService must reference AutomergeNative");
        Assert.IsTrue(Service.Contains("IDisposable"),
            "SyncService must implement IDisposable");
        Assert.IsTrue(Service.Contains("NativeLibrary.TryLoad"),
            "SyncService must use NativeLibrary.TryLoad for graceful degradation");
        var AiConst = ReadSource("PrTask.Domain", "Constants", "AiConstants.cs");
        Assert.IsTrue(AiConst.Contains("SyncProviderAutomerge"),
            "AiConstants must define SyncProviderAutomerge");
        Assert.IsTrue(AiConst.Contains("LogAutomergeLoaded"),
            "AiConstants must define LogAutomergeLoaded");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI pages must not have @page directives to avoid ambiguous route errors")]
    public void Rule187MauiPagesNoRouteDirectives()
    {
        var MauiPagesDir = Path.Combine(SourceRoot, "PrTask.Maui", "Pages");
        var RazorFiles = Directory.GetFiles(MauiPagesDir, "*.razor", SearchOption.AllDirectories);
        foreach (var FilePath in RazorFiles)
        {
            var Content = File.ReadAllText(FilePath);
            var FileName = Path.GetFileName(FilePath);
            Assert.IsFalse(Content.Contains("@page"),
                $"MAUI page {FileName} must not have @page directive");
        }
    }
}
