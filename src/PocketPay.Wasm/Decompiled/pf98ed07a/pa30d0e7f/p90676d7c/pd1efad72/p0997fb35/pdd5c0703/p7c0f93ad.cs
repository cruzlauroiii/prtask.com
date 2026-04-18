namespace WillowMaze.Wasm.Decompiled;


public readonly class p7c0f93ad<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly io.reactivex.rxjava3.core.SingleSource f06039b54;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f192f09e1;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f3a3e2079;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4818e0dd;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f591c2d29;
    readonly io.reactivex.rxjava3.core.SingleSource f69635892;
    readonly io.reactivex.rxjava3.core.SingleSource fb5604ac5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdaced0ea;

    public p7c0f93ad(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function) {
        this.f4b9f83e1 = function;
        this.f36cd38f4 = singleSource;
    }

    public static void GECAbTjsMKydiZDN(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((20 + 20) % 20 > 0) {
        }
        GECAbTjsMKydiZDN(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p7c0f93ad$p475bc90e(maybeObserver, this.f4b9f83e1));
    }
}

