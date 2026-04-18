namespace WillowMaze.Wasm.Decompiled;


public readonly class pec6b47c6<T, U> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly p5a445d71.p18f29add.p32c73be0 f5d3cb782;
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 f961d084a;
    readonly p5a445d71.p18f29add.p32c73be0 faf780b67;

    public pec6b47c6(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, org.reactivestreams.Publisher<U> publisher) {
        super(maybeSource);
        this.f795f3202 = publisher;
    }

    public static void LtmrPLqCLoVDRXTx(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void UwgdqcDrMVVhiWlU(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void PjJbmKqzcirFneHr(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((4 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pec6b47c6$p03fceb00 pec6b47c6_p03fceb00 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pec6b47c6$p03fceb00(maybeObserver);
        LtmrPLqCLoVDRXTx(maybeObserver, pec6b47c6_p03fceb00);
        pjJbmKqzcirFneHr(this.f795f3202, pec6b47c6_p03fceb00.f795f3202);
        UwgdqcDrMVVhiWlU(this.f36cd38f4, pec6b47c6_p03fceb00);
    }
}

