using Microsoft.JSInterop;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public sealed class WasmVisibilitySyncService(IJSRuntime JsRuntime) : IVisibilitySyncService
{
    public async Task PauseSyncAsync() =>
        await JsRuntime.InvokeVoidAsync(JsInteropConstants.PauseSync);

    public async Task ResumeSyncAsync() =>
        await JsRuntime.InvokeVoidAsync(JsInteropConstants.ResumeSync);

    public async Task<bool> IsSyncPausedAsync() =>
        await JsRuntime.InvokeAsync<bool>(JsInteropConstants.IsSyncPaused);
}
