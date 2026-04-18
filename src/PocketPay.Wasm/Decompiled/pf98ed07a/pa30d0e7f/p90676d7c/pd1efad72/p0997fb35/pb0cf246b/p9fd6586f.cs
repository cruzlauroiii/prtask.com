namespace WillowMaze.Wasm.Decompiled;


public readonly class p9fd6586f<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1cc02168;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f24c94369;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f4cd6d715;
    readonly p5a445d71.p18f29add.p32c73be0 f8c0d0cad;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f98166ff9;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    readonly java.lang.object fe8d1d316;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fe8fc6f9b;
    readonly R ffe4c0f30;

    public p9fd6586f(org.reactivestreams.Publisher<T> publisher, R r, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        this.f36cd38f4 = publisher;
        this.ffe4c0f30 = r;
        this.fe6392c2b = biFunction;
    }

    public static void CUslztQEeyeGazyB(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((4 + 5) % 5 > 0) {
        }
        CUslztQEeyeGazyB(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9fd6586f$p32707b45(singleObserver, this.fe6392c2b, this.ffe4c0f30));
    }
}

