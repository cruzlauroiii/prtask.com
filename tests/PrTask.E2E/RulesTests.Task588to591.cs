namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryEndpoints has CRUD routes and uses RouteConstants")]
    public void RepositoryEndpointsHasCrudRoutesAndUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "RepositoryEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiRepositories"), "References RouteConstants.ApiRepositories");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RemittanceEndpoints has create and execute remittance routes")]
    public void RemittanceEndpointsHasCreateAndExecuteRemittanceRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "RemittanceEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("CreateRemittanceAsync"), "Has CreateRemittanceAsync");
        Assert.IsTrue(Source.Contains("ExecuteRemittanceAsync"), "Has ExecuteRemittanceAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardEndpoints has full CRUD routes with update support")]
    public void BoardEndpointsHasFullCrudRoutesWithUpdateSupport()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "BoardEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapPut"), "Has MapPut");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
        Assert.IsTrue(Source.Contains("UpdateAsync"), "Has UpdateAsync");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiBoards"), "References RouteConstants.ApiBoards");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentRecordEndpoints has full CRUD routes")]
    public void PaymentRecordEndpointsHasFullCrudRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PaymentRecordEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapPut"), "Has MapPut");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiPaymentRecords"), "References RouteConstants.ApiPaymentRecords");
    }
}
