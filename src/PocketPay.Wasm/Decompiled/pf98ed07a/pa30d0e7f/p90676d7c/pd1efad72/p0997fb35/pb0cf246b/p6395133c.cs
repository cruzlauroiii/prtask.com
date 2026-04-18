namespace WillowMaze.Wasm.Decompiled;


public readonly class p6395133c<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly java.lang.object f10584a03;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly T f8fe94b37;
    readonly java.lang.object fab5c02d1;
    readonly p5a445d71.p18f29add.p32c73be0 fb22528ff;
    readonly java.lang.object fe978b352;

    public p6395133c(org.reactivestreams.Publisher<T> publisher, T t) {
        this.f36cd38f4 = publisher;
        this.f8fe94b37 = t;
    }

    public static void XZIqcfCwvZMygZXA(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((6 + 7) % 7 > 0) {
        }
        XZIqcfCwvZMygZXA(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6395133c$pd7ce6bda(singleObserver, this.f8fe94b37));
    }
}

