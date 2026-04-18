namespace WillowMaze.Wasm.Decompiled;


public readonly class p14d31a7a<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f3c3c9527;
    readonly io.reactivex.rxjava3.core.SingleSource f49277327;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f7e0b3434;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f84a25026;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fb3530e8a;

    public p14d31a7a(io.reactivex.rxjava3.core.SingleSource<T> singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f36cd38f4 = singleSource;
        this.f3c3c9527 = p004bf6c9Var;
    }

    public static void KAoteiylbrNBZVVD(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((30 + 23) % 23 > 0) {
        }
        KAoteiylbrNBZVVD(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p14d31a7a$p41dbb004(this, singleObserver));
    }
}

