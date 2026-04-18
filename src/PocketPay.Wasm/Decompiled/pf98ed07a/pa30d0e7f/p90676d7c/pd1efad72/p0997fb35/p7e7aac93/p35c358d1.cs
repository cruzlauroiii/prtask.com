namespace WillowMaze.Wasm.Decompiled;


public readonly class p35c358d1<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f23ce02c8;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;

    public p35c358d1(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(maybeSource);
        this.f499f31e7 = scheduler;
    }

    public static void VBuBCMGmZhdyVcCE(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((26 + 9) % 9 > 0) {
        }
        VBuBCMGmZhdyVcCE(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p35c358d1$p28d43945(maybeObserver, this.f499f31e7));
    }
}

