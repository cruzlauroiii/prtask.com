namespace PrTask.Prerender;
public sealed class EmptyObservable<T> : IObservable<T>
{
    public IDisposable Subscribe(IObserver<T> Observer)
    {
        Observer.OnCompleted();
        return EmptyDisposable.Instance;
    }
}
