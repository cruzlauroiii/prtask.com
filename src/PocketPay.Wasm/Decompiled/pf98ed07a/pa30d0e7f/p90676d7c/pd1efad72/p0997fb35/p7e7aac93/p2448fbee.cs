namespace WillowMaze.Wasm.Decompiled;


public readonly class p2448fbee<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    public p2448fbee(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        super(maybeSource);
    }

    public static void BSGSPXsgrZIRVlvA(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        BSGSPXsgrZIRVlvA(this.f36cd38f4, maybeObserver);
    }
}

