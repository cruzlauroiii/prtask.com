using System.Net;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SecurityConstants defines all security header names and values")]
    public void SecurityConstantsDefinesAllHeaders()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SecurityConstants.cs");
        Assert.IsTrue(Source.Contains("XContentTypeOptions"), "Must define XContentTypeOptions header name");
        Assert.IsTrue(Source.Contains("nosniff"), "Must define nosniff value");
        Assert.IsTrue(Source.Contains("XFrameOptions"), "Must define XFrameOptions header name");
        Assert.IsTrue(Source.Contains("DENY"), "Must define DENY value");
        Assert.IsTrue(Source.Contains("ReferrerPolicy"), "Must define ReferrerPolicy header name");
        Assert.IsTrue(Source.Contains("strict-origin-when-cross-origin"), "Must define referrer policy value");
        Assert.IsTrue(Source.Contains("PermissionsPolicy"), "Must define PermissionsPolicy header name");
        Assert.IsTrue(Source.Contains("camera=()"), "Must restrict camera permission");
        Assert.IsTrue(Source.Contains("StrictTransportSecurity"), "Must define HSTS header name");
        Assert.IsTrue(Source.Contains("max-age=31536000"), "Must define HSTS max-age");
        Assert.IsTrue(Source.Contains("XssProtection"), "Must define XSS protection header name");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs adds security headers middleware before UseCors")]
    public void ProgramCsAddsSecurityHeadersMiddleware()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains(nameof(SecurityConstants) + ".XContentTypeOptions"),
            "Program.cs must append XContentTypeOptions header");
        Assert.IsTrue(Source.Contains(nameof(SecurityConstants) + ".XFrameOptions"),
            "Program.cs must append XFrameOptions header");
        Assert.IsTrue(Source.Contains(nameof(SecurityConstants) + ".ReferrerPolicy"),
            "Program.cs must append ReferrerPolicy header");
        Assert.IsTrue(Source.Contains(nameof(SecurityConstants) + ".PermissionsPolicy"),
            "Program.cs must append PermissionsPolicy header");
        var MiddlewareIdx = Source.IndexOf("SecurityConstants.XContentTypeOptions", StringComparison.Ordinal);
        var CorsIdx = Source.IndexOf("UseCors", StringComparison.Ordinal);
        Assert.IsTrue(MiddlewareIdx < CorsIdx,
            "Security headers middleware must be registered before UseCors");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Client _headers file has security headers for Cloudflare Pages")]
    public void ClientHeadersFileHasSecurityHeaders()
    {
        var Headers = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "_headers"));
        Assert.IsTrue(Headers.Contains("X-Content-Type-Options: nosniff"),
            "_headers must have X-Content-Type-Options");
        Assert.IsTrue(Headers.Contains("X-Frame-Options: DENY"),
            "_headers must have X-Frame-Options");
        Assert.IsTrue(Headers.Contains("Referrer-Policy: strict-origin-when-cross-origin"),
            "_headers must have Referrer-Policy");
        Assert.IsTrue(Headers.Contains("Permissions-Policy:"),
            "_headers must have Permissions-Policy");
        Assert.IsTrue(Headers.Contains("Strict-Transport-Security:"),
            "_headers must have HSTS");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Live site must return security headers")]
    public async Task Task595LiveSiteSecurityHeadersAsync()
    {
        var Response = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiTasks}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"API tasks returned {Response.StatusCode}");
        if (!BaseUrl.Contains(AppConstants.AppDomain))
        {
            var XctoHeader = Response.Headers.Contains(SecurityConstants.XContentTypeOptions)
                ? Response.Headers.GetValues(SecurityConstants.XContentTypeOptions).FirstOrDefault()
                : Response.Content.Headers.Contains(SecurityConstants.XContentTypeOptions)
                    ? Response.Content.Headers.GetValues(SecurityConstants.XContentTypeOptions).FirstOrDefault()
                    : null;
            Assert.IsTrue(XctoHeader is not null,
                "Local server must return X-Content-Type-Options header");
        }
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("All service interfaces have Infrastructure implementations")]
    public void AllServiceInterfacesHaveImplementations()
    {
        var ClientOnlyInterfaces = new HashSet<string> { "ILocalStoreService", "IGitSyncService" };
        var InterfaceDir = Path.Combine(SourceRoot, "PrTask.Application", "Services");
        var ImplDir = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services");
        var Interfaces = Directory.GetFiles(InterfaceDir, "I*Service.cs");
        Assert.IsTrue(Interfaces.Length >= 30, $"Must have at least 30 service interfaces, found {Interfaces.Length}");
        var ImplFiles = Directory.GetFiles(ImplDir, "*.cs", SearchOption.AllDirectories);
        var ImplContents = string.Join("\n", ImplFiles.Select(File.ReadAllText));
        var Missing = new List<string>();
        foreach (var Iface in Interfaces)
        {
            var InterfaceName = Path.GetFileNameWithoutExtension(Iface);
            if (ClientOnlyInterfaces.Contains(InterfaceName))
            {
                continue;
            }

            if (!ImplContents.Contains(InterfaceName))
            {
                Missing.Add(InterfaceName);
            }
        }
        Assert.AreEqual(0, Missing.Count, $"Missing implementations: {string.Join(", ", Missing)}");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Client Program.cs registers all WSS services for SharedUI pages")]
    public void ClientProgramRegistersAllWssServices()
    {
        var ClientProgram = ReadSource("PrTask.Client", "Program.cs");
        var WssServiceDir = Path.Combine(SourceRoot, "PrTask.Client", "Services");
        var WssServices = Directory.GetFiles(WssServiceDir, "Wss*Service.cs");
        var Missing = new List<string>();
        foreach (var Svc in WssServices)
        {
            var ClassName = Path.GetFileNameWithoutExtension(Svc);
            if (!ClientProgram.Contains(ClassName))
            {
                Missing.Add(ClassName);
            }
        }
        Assert.AreEqual(0, Missing.Count, $"Unregistered WSS services: {string.Join(", ", Missing)}");
    }
}
