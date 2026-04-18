namespace WillowMaze.Wasm.Decompiled;


abstract class p00b0137c<T, U> : io.reactivex.rxjava3.core.Observable<U> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamObservableSource<T> {
    protected readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    protected readonly io.reactivex.rxjava3.core.ObservableSource f62ca8a72;
    protected readonly io.reactivex.rxjava3.core.ObservableSource f7543a28a;
    protected readonly io.reactivex.rxjava3.core.ObservableSource fc3b8d1db;

    p00b0137c(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.f36cd38f4 = observableSource;
    }

    public readonly io.reactivex.rxjava3.core.ObservableSource<T> Source() {
        return this.f36cd38f4;
    }
}

