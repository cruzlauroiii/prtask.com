namespace WillowMaze.Wasm.Decompiled;


readonly class p1432991f$ped40debe<T> : java.lang.Action {
    readonly io.reactivex.rxjava3.core.MaybeSource f14d4e0c6;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f3ffc907c;
    readonly io.reactivex.rxjava3.core.MaybeSource f76c7c831;
    readonly io.reactivex.rxjava3.core.MaybeObserver f8a3eebdf;
    readonly io.reactivex.rxjava3.core.MaybeSource fb290ab0e;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd0d95724;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fdfda0d32;
    readonly io.reactivex.rxjava3.core.MaybeObserver ff54bf680;

    p1432991f$ped40debe(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.fdfda0d32 = maybeObserver;
        this.f36cd38f4 = maybeSource;
    }

    public static void BezXudgPMnZZlZZo(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public override void Run() {
        bezXudgPMnZZlZZo(this.f36cd38f4, this.fdfda0d32);
    }
}

