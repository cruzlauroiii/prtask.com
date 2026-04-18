using PrTask.Cdp;
namespace PrTask.E2E;
public sealed record PlatformContext(
    string Platform,
    string PlatformUrl,
    CdpPage Page,
    CdpBrowser Browser,
    HttpClient? Http);
