namespace PrTask.Domain.Constants;
public static class WssStateConstants
{
    public const string ConfigWssUrl = "WssUrl";
    public const string DefaultWssUrl = "wss://prtask.workers.dev/ws";
    public const string LogConnecting = "WssState connecting to {Url}";
    public const string LogConnected = "WssState connected";
    public const string LogDisconnected = "WssState disconnected";
    public const string LogMessageReceived = "WssState message received: {Type}";
    public const string LogSubscriptionDisposed = "WssState subscription disposed";
    public const string LogDisposed = "WssState service disposed";
    public const string DefaultJwtToken = "";
}
