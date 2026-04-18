namespace PrTask.Cdp;

#pragma warning disable SA1611, SA1615, RCS1141
public interface ICdpPage : IAsyncDisposable
{
    string TargetId { get; }
    string SessionId { get; }
    Task<string> NavigateAsync(string Url, CancellationToken Cancel = default);
    Task WaitForLoadAsync(CancellationToken Cancel = default);
    Task<byte[]> CaptureScreenshotAsync(string Format = "png", int Quality = 80, CancellationToken Cancel = default);
    Task<string> GetOuterHtmlAsync(string Selector, CancellationToken Cancel = default);
    Task<int> QuerySelectorAsync(string Selector, CancellationToken Cancel = default);
    Task<int[]> QuerySelectorAllAsync(string Selector, CancellationToken Cancel = default);
    Task<object?> EvaluateAsync(string Expression, CancellationToken Cancel = default);
    Task ClickAsync(int X, int Y, CancellationToken Cancel = default);
    Task TypeTextAsync(string Text, CancellationToken Cancel = default);
    Task PressKeyAsync(string Key, CancellationToken Cancel = default);
    Task SetViewportAsync(int Width, int Height, double DeviceScaleFactor = 1.0, CancellationToken Cancel = default);
    Task EnableNetworkAsync(CancellationToken Cancel = default);
    Task SetExtraHeadersAsync(Dictionary<string, string> Headers, CancellationToken Cancel = default);
    Task<string> GetResponseBodyAsync(string RequestId, CancellationToken Cancel = default);
    Task EnableConsoleAsync(CancellationToken Cancel = default);
}
#pragma warning restore SA1611, SA1615, RCS1141
