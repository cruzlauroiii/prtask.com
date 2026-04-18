using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
[DisplayName("T45 Login Page")]
public class LoginPageTests : PlaywrightTestBase
{
    private const string LoginHeadingSelector = "h1";
    private const int ExpectedOkStatus = 200;

    [TestMethod]
    [DisplayName("T45-01 Login page loads successfully")]
    public async Task LoginPageLoadsSuccessfullyAsync()
    {
        var Response = await NavigateAsync(RouteConstants.Login);
        Assert.IsNotNull(Response);
        Assert.AreEqual(ExpectedOkStatus, Response.Status);
    }

    [TestMethod]
    [DisplayName("T45-02 Login page contains heading")]
    public async Task LoginPageContainsHeadingAsync()
    {
        await NavigateAsync(RouteConstants.Login);
        var Heading = await Page.QuerySelectorAsync(LoginHeadingSelector);
        Assert.IsNotNull(Heading);
    }

    [TestMethod]
    [DisplayName("T45-03 Dev login endpoint returns OK")]
    public async Task DevLoginEndpointReturnsOkAsync()
    {
        await DevLoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
    }
}
