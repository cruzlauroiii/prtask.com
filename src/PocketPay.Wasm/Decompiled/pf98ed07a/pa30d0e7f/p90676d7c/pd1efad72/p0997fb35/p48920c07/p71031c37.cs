namespace WillowMaze.Wasm.Decompiled;


public readonly class p71031c37<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> f36cd38f4;
    readonly int f444e6926;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f4921bd02;
    readonly int f4c203b76;
    readonly bool f50fee566;
    readonly bool f8317d048;
    readonly int fa4aac9d1;
    readonly bool fab7e9fa2;
    readonly int fc0ee13de;
    readonly int fc376cbd4;
    readonly bool fcdff16e2;
    readonly bool fe9b2135d;

    public p71031c37(io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> parallelFlowable, int i, bool z) {
        this.f36cd38f4 = parallelFlowable;
        this.f4c203b76 = i;
        this.f50fee566 = z;
    }

    public static int IqmACuHmvGPoQlMO(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static void OfgqSWhkwoGGbqMN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static int TJKLiJLZzOmhcXcj(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static void XuBkQRQdXHqeSXER(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((21 + 22) % 22 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p8be94f50 = !this.f50fee566 ? new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p8be94f50(subscriber, IqmACuHmvGPoQlMO(this.f36cd38f4), this.f4c203b76) : new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$pa3b1861d(subscriber, TJKLiJLZzOmhcXcj(this.f36cd38f4), this.f4c203b76);
        OfgqSWhkwoGGbqMN(subscriber, p71031c37_p8be94f50);
        XuBkQRQdXHqeSXER(this.f36cd38f4, p71031c37_p8be94f50.faae7b662);
    }
}

