namespace WillowMaze.Wasm.Decompiled;


public readonly class pceaf51f1<T> : io.reactivex.rxjava3.core.Completable {
    readonly bool f1688c183;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1bb21e6e;
    readonly bool f2cdc705c;
    readonly io.reactivex.rxjava3.core.Observable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f46a77588;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f50fee566;
    readonly io.reactivex.rxjava3.core.Observable f79228c94;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f886e05cd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa4a38d6f;

    public pceaf51f1(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        this.f36cd38f4 = observable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void ARlLbYRuTkXhuzTq(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public static bool GBzOTGgcIGxwnztP(java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p864fd216.m53eb0443(obj, p86408593Var, completableObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((27 + 12) % 12 > 0) {
        }
        if (gBzOTGgcIGxwnztP(this.f36cd38f4, this.f4b9f83e1, completableObserver)) {
            return;
        }
        ARlLbYRuTkXhuzTq(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51(completableObserver, this.f4b9f83e1, this.f50fee566));
    }
}

