namespace PrTask.Domain.Constants;
public static class CloudflareConstants
{
    public const string HttpClientName = "Cloudflare";
    public const string ConfigApiToken = "Cloudflare:ApiToken";
    public const string ConfigD1DatabaseId = "Cloudflare:D1DatabaseId";
    public const string ConfigAccountId = "Cloudflare:AccountId";
    public const string D1QueryPathFormat = "/client/v4/accounts/{0}/d1/database/{1}/query";
    public const string AuthorizationHeader = "Authorization";
    public const string BearerPrefix = "Bearer ";
    public const string JsonResult = "result";
    public const string JsonResults = "results";
    public const string JsonSuccess = "success";
    public const string JsonErrors = "errors";
    public const string JsonSql = "sql";
    public const string JsonParams = "params";
    public const string JsonColumns = "columns";
    public const string JsonRows = "rows";
    public const string JsonData = "data";
    public const string LogD1QueryExecuted = "D1 query executed: {Sql}";
    public const string LogD1QueryFailed = "D1 query failed: {Error}";
    public const string LogD1NotConfigured = "Cloudflare D1 not configured, using local SQLite";
}
