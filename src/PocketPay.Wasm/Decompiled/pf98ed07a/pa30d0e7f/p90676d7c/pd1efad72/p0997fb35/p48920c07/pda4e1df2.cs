namespace WillowMaze.Wasm.Decompiled;


public readonly class pda4e1df2<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0d1a5e1a;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fa9df34a4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fdaa4aa78;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    public pda4e1df2(io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> parallelFlowable, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.f36cd38f4 = parallelFlowable;
        this.fe6392c2b = biFunction;
    }

    public static void TvZoCitpsCJEUvJd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void NWbPNfcuRVgpqAyd(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static int OyZMLQtogxGIkQau(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((28 + 11) % 11 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54(subscriber, oyZMLQtogxGIkQau(this.f36cd38f4), this.fe6392c2b);
        TvZoCitpsCJEUvJd(subscriber, pda4e1df2_p5e8efd54);
        nWbPNfcuRVgpqAyd(this.f36cd38f4, pda4e1df2_p5e8efd54.faae7b662);
    }
}

