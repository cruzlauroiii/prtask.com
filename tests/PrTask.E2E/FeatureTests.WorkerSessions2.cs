namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker export default must define async fetch handler accepting request and env parameters")]
    public void WorkerExportDefaultMustDefineAsyncFetchHandlerAcceptingRequestAndEnvParameters()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("export default", StringComparison.Ordinal), "Worker must use ES module export default pattern");
        Assert.IsTrue(Js.Contains("async fetch(request, env)", StringComparison.Ordinal), "Worker fetch handler must accept request and env");
        Assert.IsTrue(Js.Contains("new URL(request.url)", StringComparison.Ordinal), "Worker must parse URL from request");
        Assert.IsTrue(Js.Contains("url.pathname.startsWith(\"/api/\")", StringComparison.Ordinal), "Worker must check pathname starts with /api/");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker content type header must be application json for all api response handlers")]
    public void WorkerContentTypeHeaderMustBeApplicationJsonForAllApiResponseHandlers()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"Content-Type\": \"application/json\"", StringComparison.Ordinal), "Worker API headers must include Content-Type: application/json");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker task path regex must match api tasks slash any non slash characters for single task routes")]
    public void WorkerTaskPathRegexMustMatchApiTasksSlashAnyNonSlashCharactersForSingleTaskRoutes()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("path.match(/^\\/api\\/tasks\\/[^/]+$/)", StringComparison.Ordinal), "Worker must use regex to match single task routes");
        Assert.IsTrue(Js.Contains("path.match(/^\\/api\\/tasks\\/[^/]+\\/prs$/)", StringComparison.Ordinal), "Worker must use regex to match task PRs sub-route");
        Assert.IsTrue(Js.Contains("path.split(\"/\")[3]", StringComparison.Ordinal), "Worker must extract taskId from path index 3 for PR queries");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google callback must delete pkce verifier from sessions after successful retrieval")]
    public void WorkerGoogleCallbackMustDeletePkceVerifierFromSessionsAfterSuccessfulRetrieval()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("env.SESSIONS.get(\"pkce_\" + state)", StringComparison.Ordinal), "Google callback must retrieve PKCE verifier from KV");
        Assert.IsTrue(Js.Contains("env.SESSIONS.delete(\"pkce_\" + state)", StringComparison.Ordinal), "Google callback must delete PKCE verifier after use");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker github token exchange must use json content type header not form url encoded like other providers")]
    public void WorkerGitHubTokenExchangeMustUseJsonContentTypeHeaderNotFormUrlEncodedLikeOtherProviders()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"Content-Type\": \"application/json\", \"Accept\": \"application/json\"", StringComparison.Ordinal), "GitHub token exchange must use JSON content type and accept headers");
        Assert.IsTrue(Js.Contains("JSON.stringify({", StringComparison.Ordinal), "GitHub must send JSON body with JSON.stringify");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Worker google azure and okta token exchanges must use form url encoded content type header")]
    public void WorkerGoogleAzureAndOktaTokenExchangesMustUseFormUrlEncodedContentTypeHeader()
    {
        var Js = ReadInfraFile("worker.js");
        Assert.IsTrue(Js.Contains("\"Content-Type\": \"application/x-www-form-urlencoded\"", StringComparison.Ordinal), "PKCE providers must use form-urlencoded content type");
        Assert.IsTrue(Js.Contains("tokenBody.toString()", StringComparison.Ordinal), "PKCE providers must serialize URLSearchParams to string");
    }
}
