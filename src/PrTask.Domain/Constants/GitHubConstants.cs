namespace PrTask.Domain.Constants;
public static class GitHubConstants
{
    public const string AuthorizeUrl = "https://github.com/login/oauth/authorize";
    public const string TokenUrl = "https://github.com/login/oauth/access_token";
    public const string UserApiUrl = "https://api.github.com/user";
    public const string RequiredScope = "read:user user:email";
}
