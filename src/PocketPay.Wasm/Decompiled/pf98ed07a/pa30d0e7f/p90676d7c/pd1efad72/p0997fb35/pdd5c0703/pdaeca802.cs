namespace WillowMaze.Wasm.Decompiled;


public readonly class pdaeca802<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f48fb8435;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f55cfebeb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f59177c49;
    readonly io.reactivex.rxjava3.core.SingleSource f5a9e4f7d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fc78c711a;
    readonly io.reactivex.rxjava3.core.SingleSource ff3cd8405;

    public pdaeca802(io.reactivex.rxjava3.core.SingleSource<T> singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f36cd38f4 = singleSource;
        this.f55cfebeb = p004bf6c9Var;
    }

    public static void YiCwBTtUjQITYfBR(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((17 + 15) % 15 > 0) {
        }
        yiCwBTtUjQITYfBR(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdaeca802$p4450821b(singleObserver, this.f55cfebeb));
    }
}

