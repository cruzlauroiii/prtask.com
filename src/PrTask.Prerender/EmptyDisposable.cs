namespace PrTask.Prerender;
public sealed class EmptyDisposable : IDisposable
{
    public static readonly EmptyDisposable Instance = new();
#pragma warning disable S1186
    public void Dispose() { }
#pragma warning restore S1186
}
