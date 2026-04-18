namespace WillowMaze.Wasm.Decompiled;


public readonly class paf16d6a0<T, R> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f44e2d2da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f541c111a;
    readonly io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9e4102be;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 feb6689c1;

    public paf16d6a0(io.reactivex.rxjava3.core.Maybe<T> maybe, io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> function) {
        super(maybe);
        this.f5b3c3200 = function;
    }

    public static void BpaOlIHkXsZFIeie(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((13 + 24) % 24 > 0) {
        }
        BpaOlIHkXsZFIeie(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.paf16d6a0$p206aa94e(maybeObserver, this.f5b3c3200));
    }
}

