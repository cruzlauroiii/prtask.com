using Microsoft.JSInterop;

namespace WillowMaze.Wasm.Services;

public sealed class WssInterop : IAsyncDisposable
{
    private readonly IJSRuntime Js;
    private DotNetObjectReference<WssNfcWorkbenchService>? DotNetRef;

    public WssInterop(IJSRuntime Js) => this.Js = Js;

    public async Task<bool> ConnectAsync(string Url, WssNfcWorkbenchService Service)
    {
        DotNetRef = DotNetObjectReference.Create(Service);
        return await Js.InvokeAsync<bool>("WillowWss.connect", Url, DotNetRef);
    }

    public async Task<bool> SendAsync(string Json) => await Js.InvokeAsync<bool>("WillowWss.send", Json);
    public async Task DisconnectAsync() => await Js.InvokeVoidAsync("WillowWss.disconnect");
    public async Task<bool> IsConnectedAsync() => await Js.InvokeAsync<bool>("WillowWss.isConnected");
    public async Task<bool> HasWebNfcAsync() => await Js.InvokeAsync<bool>("WillowWss.hasWebNfc");
    public async Task<int> GenerateRandomPortAsync() => await Js.InvokeAsync<int>("WillowWss.generateRandomPort");

    public async Task<bool> StartWebNfcScanAsync(WssNfcWorkbenchService Service)
    {
        DotNetRef ??= DotNetObjectReference.Create(Service);
        return await Js.InvokeAsync<bool>("WillowWss.startWebNfcScan", DotNetRef);
    }

    public async Task<string> WriteWebNfcAsync(string Text, bool IsUri) => await Js.InvokeAsync<string>("WillowWss.writeWebNfc", Text, IsUri);

    public async ValueTask DisposeAsync()
    {
        DotNetRef?.Dispose();
        try { await Js.InvokeVoidAsync("WillowWss.disconnect"); } catch { }
    }
}
