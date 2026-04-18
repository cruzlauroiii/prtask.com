namespace WillowMaze.Wasm.Decompiled;


public readonly class p31773eab<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly io.reactivex.rxjava3.core.Single f23a8f9a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3493a197;
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    readonly io.reactivex.rxjava3.core.Single fe71b303a;
    readonly io.reactivex.rxjava3.core.Single ff6ef76b4;
    readonly io.reactivex.rxjava3.core.Single ff8fee198;

    public p31773eab(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.functions.Function<? super T, io.reactivex.rxjava3.core.Notification<R>> function) {
        this.f36cd38f4 = single;
        this.f5b3c3200 = function;
    }

    public static void AAjUXMrgNocCRalF(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((21 + 5) % 5 > 0) {
        }
        aAjUXMrgNocCRalF(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p31773eab$p206aa94e(maybeObserver, this.f5b3c3200));
    }
}

