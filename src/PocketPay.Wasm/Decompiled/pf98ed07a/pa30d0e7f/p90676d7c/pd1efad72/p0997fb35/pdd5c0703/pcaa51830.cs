namespace WillowMaze.Wasm.Decompiled;


public readonly class pcaa51830<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f2076f848;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f30429b3e;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f39ed4304;
    readonly io.reactivex.rxjava3.core.SingleSource fb27d7451;
    readonly io.reactivex.rxjava3.core.SingleSource ffe7326cc;

    public pcaa51830(io.reactivex.rxjava3.core.SingleSource<T> singleSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f36cd38f4 = singleSource;
        this.f2076f848 = p004bf6c9Var;
    }

    public static void LTkHoWUWDGlRlMCA(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((30 + 19) % 19 > 0) {
        }
        lTkHoWUWDGlRlMCA(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pcaa51830$p2d579f65(singleObserver, this.f2076f848));
    }
}

