namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SprintEndpoints has CRUD routes and uses RouteConstants")]
    public void SprintEndpointsHasCrudRoutesAndUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SprintEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapPatch") || Source.Contains("MapPut"), "Has MapPatch or MapPut");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiSprints"), "References RouteConstants.ApiSprints");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("LeaderboardEndpoints has read-only routes and uses RouteConstants")]
    public void LeaderboardEndpointsHasReadOnlyRoutesAndUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "LeaderboardEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiLeaderboard"), "References RouteConstants.ApiLeaderboard");
        Assert.IsTrue(Source.Contains("LeaderboardEntryDto.FromEntity"), "Uses LeaderboardEntryDto.FromEntity");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("UserEndpoints has CRUD routes and uses RouteConstants")]
    public void UserEndpointsHasCrudRoutesAndUsesRouteConstants()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "UserEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPatch") || Source.Contains("MapPut"), "Has MapPatch or MapPut");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiUsers"), "References RouteConstants.ApiUsers");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("ReviewCommentEndpoints has read create and delete routes")]
    public void ReviewCommentEndpointsHasReadCreateAndDeleteRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "ReviewCommentEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiReviewComments"), "References RouteConstants.ApiReviewComments");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SourceCodeEndpoints has upload and retrieval routes")]
    public void SourceCodeEndpointsHasUploadAndRetrievalRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SourceCodeEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiSourceCode"), "References RouteConstants.ApiSourceCode");
        Assert.IsTrue(Source.Contains("StoreFilesAsync"), "Has StoreFilesAsync");
    }
}
