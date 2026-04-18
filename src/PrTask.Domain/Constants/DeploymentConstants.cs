namespace PrTask.Domain.Constants;
public static class DeploymentConstants
{
    public const string StatusReady = "Ready";
    public const string StatusDeployed = "Deployed";
    public const string StatusClassSuccess = "success";
    public const string StatusClassInfo = "info";
    public const string LogCloning = "Cloning repository\u2026";
    public const string LogInstalling = "Installing dependencies\u2026";
    public const string LogBuilding = "Building project\u2026";
    public const string LogDeploying = "Deploying to Cloudflare Pages\u2026";
    public const string LogWaiting = "Waiting for deployment data\u2026";
    public const string LogTimeFormat = "HH:mm:ss";
    public const string PreviewUrlFormat = "https://deploy-preview-{0}--{1}.pages.dev";
}
