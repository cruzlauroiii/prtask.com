using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HttpSourceCodeService IDE0028 suppression for IDictionary return type")]
    public void HttpSourceCodeServiceIde0028Suppression()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpSourceCodeService.cs");
        Assert.IsTrue(Source.Contains("IDE0028"),
            "HttpSourceCodeService must suppress IDE0028 for IDictionary collection expression incompatibility");
        Assert.IsTrue(Source.Contains("GetFilesAsync"),
            "HttpSourceCodeService must implement GetFilesAsync");
        Assert.IsTrue(Source.Contains("GetModifiedFilesAsync"),
            "HttpSourceCodeService must implement GetModifiedFilesAsync");
        Assert.IsTrue(Source.Contains("IDictionary"),
            "HttpSourceCodeService must return IDictionary interface type");
    }
}
