namespace WillowMaze.Wasm.Decompiled;


public readonly class p423c5578<T, U> : io.reactivex.rxjava3.core.Single<T> {
    readonly p5a445d71.p18f29add.p32c73be0 f3482bfd2;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleSource f94b1f574;
    readonly p5a445d71.p18f29add.p32c73be0 fd30e2761;

    public p423c5578(io.reactivex.rxjava3.core.SingleSource<T> singleSource, org.reactivestreams.Publisher<U> publisher) {
        this.f36cd38f4 = singleSource;
        this.f795f3202 = publisher;
    }

    public static void PFOikEGFcuWetIkL(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void UHVcOdcdChpqLSGN(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void MqkAWmGlHRLMLxBO(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((2 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p406318cb p423c5578_p406318cb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p406318cb(singleObserver);
        UHVcOdcdChpqLSGN(singleObserver, p423c5578_p406318cb);
        PFOikEGFcuWetIkL(this.f795f3202, p423c5578_p406318cb.f795f3202);
        mqkAWmGlHRLMLxBO(this.f36cd38f4, p423c5578_p406318cb);
    }
}

