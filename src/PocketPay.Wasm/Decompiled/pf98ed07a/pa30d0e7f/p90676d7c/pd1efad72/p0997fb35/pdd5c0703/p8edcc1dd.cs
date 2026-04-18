namespace WillowMaze.Wasm.Decompiled;


public readonly class p8edcc1dd<T> : io.reactivex.rxjava3.core.Completable {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1360d76d;
    readonly io.reactivex.rxjava3.core.SingleSource f2dd823ab;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f70b51ad0;
    readonly io.reactivex.rxjava3.core.SingleSource f9db4bae4;
    readonly io.reactivex.rxjava3.core.SingleSource ffe93d8a3;

    public p8edcc1dd(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function) {
        this.f36cd38f4 = singleSource;
        this.f4b9f83e1 = function;
    }

    public static void LbzQjcnRkmMURcPv(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void RfFeROYYDxmEcVJZ(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((32 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8edcc1dd$p1b4f32e9 p8edcc1dd_p1b4f32e9 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8edcc1dd$p1b4f32e9(completableObserver, this.f4b9f83e1);
        RfFeROYYDxmEcVJZ(completableObserver, p8edcc1dd_p1b4f32e9);
        LbzQjcnRkmMURcPv(this.f36cd38f4, p8edcc1dd_p1b4f32e9);
    }
}

