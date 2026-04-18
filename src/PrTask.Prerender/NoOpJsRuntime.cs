using Microsoft.JSInterop;
namespace PrTask.Prerender;
public sealed class NoOpJsRuntime : IJSRuntime
{
    public ValueTask<TValue> InvokeAsync<TValue>(string Identifier, object?[]? Args)
    {
        return ValueTask.FromResult<TValue>(default!);
    }

    public ValueTask<TValue> InvokeAsync<TValue>(string Identifier, CancellationToken CancellationToken, object?[]? Args)
    {
        return ValueTask.FromResult<TValue>(default!);
    }
}
