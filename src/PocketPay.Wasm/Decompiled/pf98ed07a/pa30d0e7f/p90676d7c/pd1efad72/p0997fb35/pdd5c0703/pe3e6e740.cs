namespace WillowMaze.Wasm.Decompiled;


public readonly class pe3e6e740<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f0e44caaf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f2076f848;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f2d838b06;
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f5788df95;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f6a8b892f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fb2399687;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fd3f7eaf9;
    readonly io.reactivex.rxjava3.core.Single ff31e0015;

    public pe3e6e740(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> consumer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f36cd38f4 = single;
        this.f5788df95 = consumer;
        this.f2076f848 = p004bf6c9Var;
    }

    public static void XGaYGkIzzaZlrWqv(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((17 + 32) % 32 > 0) {
        }
        xGaYGkIzzaZlrWqv(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pe3e6e740$p83d1d830(singleObserver, this.f5788df95, this.f2076f848));
    }
}

