namespace WillowMaze.Wasm.Decompiled;


public readonly class pa224cd38<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    public pa224cd38(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        super(maybeSource);
    }

    public static void LrMcoFhFoXFSoaTa(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        lrMcoFhFoXFSoaTa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa224cd38$p2a9c7bcf(maybeObserver));
    }
}

