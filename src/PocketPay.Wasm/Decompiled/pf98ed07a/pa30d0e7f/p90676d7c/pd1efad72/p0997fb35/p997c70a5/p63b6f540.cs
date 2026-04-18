namespace WillowMaze.Wasm.Decompiled;


public readonly class p63b6f540<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource fdf63aa0c;

    public p63b6f540(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.f36cd38f4 = observableSource;
    }

    public static void CnoCteYNJXwMtlyD(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        cnoCteYNJXwMtlyD(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p63b6f540$p6800ff30(maybeObserver));
    }
}

