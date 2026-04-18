namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardEndpoints mutations require authorization")]
    public void BoardEndpointsMutationsRequireAuth()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "BoardEndpoints.cs");
        Assert.IsTrue(Source.Contains("RequireAuthorization"),
            "BoardEndpoints must have RequireAuthorization on mutation operations");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SprintEndpoints mutations require authorization")]
    public void SprintEndpointsMutationsRequireAuth()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SprintEndpoints.cs");
        Assert.IsTrue(Source.Contains("RequireAuthorization"),
            "SprintEndpoints must have RequireAuthorization on mutation operations");
    }
}
