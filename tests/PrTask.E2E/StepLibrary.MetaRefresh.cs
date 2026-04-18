namespace PrTask.E2E;

public partial class RulesTests
{
    private static async Task<(HttpResponseMessage Response, string Html)> GetFollowingMetaRefreshAsync(
        HttpClient Client, string Url)
    {
        var Response = await Client.GetAsync(Url);
        if (!Response.IsSuccessStatusCode)
        {
            return (Response, await Response.Content.ReadAsStringAsync());
        }
        var Html = await Response.Content.ReadAsStringAsync();
        if (!Html.Contains("http-equiv=\"refresh\"", StringComparison.OrdinalIgnoreCase))
        {
            return (Response, Html);
        }
        var Match = MetaRefreshUrlPattern().Match(Html);
        if (!Match.Success)
        {
            return (Response, Html);
        }
        var Target = Match.Groups[1].Value;
        var BaseUri = new Uri(Url);
        var TargetUrl = Target.Contains("://") ? Target : new Uri(BaseUri, Target).ToString();
        var FpResponse = await Client.GetAsync(TargetUrl);
        var FpHtml = await FpResponse.Content.ReadAsStringAsync();
        return (FpResponse, FpHtml);
    }
}
