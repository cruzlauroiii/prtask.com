namespace WillowMaze.Wasm.Decompiled;


public readonly class pda04a980<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f254d47a8;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f79f97aff;
    readonly io.reactivex.rxjava3.core.ObservableSource fa49856c0;

    public pda04a980(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.f36cd38f4 = observableSource;
    }

    public static void RzMfKTjpgJCPldBq(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        RzMfKTjpgJCPldBq(this.f36cd38f4, observer);
    }
}

