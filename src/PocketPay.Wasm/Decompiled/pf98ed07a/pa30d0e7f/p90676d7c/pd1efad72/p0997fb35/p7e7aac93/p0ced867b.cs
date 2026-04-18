namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ced867b<T> : io.reactivex.rxjava3.core.Single<io.reactivex.rxjava3.core.Notification<T>> {
    readonly io.reactivex.rxjava3.core.Maybe f2a536104;
    readonly io.reactivex.rxjava3.core.Maybe<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Maybe f7d734ebc;
    readonly io.reactivex.rxjava3.core.Maybe fb9c0a60d;

    public p0ced867b(io.reactivex.rxjava3.core.Maybe<T> maybe) {
        this.f36cd38f4 = maybe;
    }

    public static void IoxqfvdVNoOIrJrU(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybe.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.core.Notification<T>> singleObserver) {
        ioxqfvdVNoOIrJrU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pfbfa53ab(singleObserver));
    }
}

