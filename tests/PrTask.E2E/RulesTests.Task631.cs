namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("No internal record definitions in endpoint files")]
    public void NoInternalRecordsInEndpoints()
    {
        var EndpointsDir = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints");
        var Files = Directory.GetFiles(EndpointsDir, "*.cs");
        foreach (var File in Files)
        {
            var Content = System.IO.File.ReadAllText(File);
            Assert.IsFalse(Content.Contains("internal record"),
                string.Format("Endpoint file {0} must not define internal records — externalize to PrTask.Application/Contracts",
                    Path.GetFileName(File)));
        }
    }
}
