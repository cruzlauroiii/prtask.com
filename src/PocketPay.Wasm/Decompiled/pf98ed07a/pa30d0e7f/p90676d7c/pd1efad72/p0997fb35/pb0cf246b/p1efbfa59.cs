namespace WillowMaze.Wasm.Decompiled;


public readonly class p1efbfa59<T> : io.reactivex.rxjava3.core.Flowable<T> : io.reactivex.rxjava3.operators.ScalarSupplier<T> {
    private readonly T f2063c160;
    private readonly java.lang.object f3d9d2f1e;
    private readonly java.lang.object f430bdba7;
    private readonly java.lang.object f4543bcfc;

    public p1efbfa59(T t) {
        this.f2063c160 = t;
    }

    public static void WhSKCLnTmkcnDPYH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public T Get() {
        return this.f2063c160;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        WhSKCLnTmkcnDPYH(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda(subscriber, this.f2063c160));
    }
}

