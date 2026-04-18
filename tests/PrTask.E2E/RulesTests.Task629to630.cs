namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("VoidEndpoints has full CRUD including DELETE")]
    public void VoidEndpointsHasFullCrud()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "VoidEndpoints.cs");
        Assert.IsTrue(Source.Contains("MapGet"),
            "VoidEndpoints must have GET operations");
        Assert.IsTrue(Source.Contains("MapPost"),
            "VoidEndpoints must have POST operation");
        Assert.IsTrue(Source.Contains("MapPatch"),
            "VoidEndpoints must have PATCH operation");
        Assert.IsTrue(Source.Contains("MapDelete"),
            "VoidEndpoints must have DELETE operation");
        Assert.IsTrue(Source.Contains("DeleteAsync"),
            "VoidEndpoints DELETE must call DeleteAsync");
        Assert.IsTrue(Source.Contains("Results.NoContent()"),
            "VoidEndpoints DELETE must return NoContent on success");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundEndpoints has full CRUD including DELETE")]
    public void RefundEndpointsHasFullCrud()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "RefundEndpoints.cs");
        Assert.IsTrue(Source.Contains("MapGet"),
            "RefundEndpoints must have GET operations");
        Assert.IsTrue(Source.Contains("MapPost"),
            "RefundEndpoints must have POST operation");
        Assert.IsTrue(Source.Contains("MapMethods") || Source.Contains("MapPatch"),
            "RefundEndpoints must have PATCH operation");
        Assert.IsTrue(Source.Contains("MapDelete"),
            "RefundEndpoints must have DELETE operation");
        Assert.IsTrue(Source.Contains("DeleteAsync"),
            "RefundEndpoints DELETE must call DeleteAsync");
        Assert.IsTrue(Source.Contains("Results.NoContent()"),
            "RefundEndpoints DELETE must return NoContent on success");
    }
}
