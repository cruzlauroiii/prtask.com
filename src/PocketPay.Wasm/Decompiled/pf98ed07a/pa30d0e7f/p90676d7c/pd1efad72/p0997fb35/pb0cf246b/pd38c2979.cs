namespace WillowMaze.Wasm.Decompiled;


public readonly class pd38c2979<T, U> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1cbd8f20;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> f4b9f83e1;
    readonly int f4cc58bce;
    readonly int f5013771c;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5543fc12;
    readonly int f9e29375a;
    readonly int f9fd7d4f3;
    readonly int fcdee5967;
    readonly bool fde5c6bb6;
    readonly int fe0ca4de7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fedf3a976;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff9bfcffc;

    public pd38c2979(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> function, bool z, int i, int i2) {
        super(flowable);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
        this.fcdee5967 = i2;
    }

    public static io.reactivex.rxjava3.core.FlowableSubscriber FsUgZPMwaHtceKUE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, bool z, int i, int i2) {
        return m4f893ee2(p992c4a5bVar, p86408593Var, z, i, i2);
    }

    public static bool QpTyBijLXorAGrUE(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6f5e6c40.m0abd2e53(p32c73be0Var, p992c4a5bVar, p86408593Var);
    }

    public static void HpDhlzTvZLqHyNyb(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static <T, U> io.reactivex.rxjava3.core.FlowableSubscriber<T> M4f893ee2(org.reactivestreams.Subscriber<U> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> function, bool z, int i, int i2) {
        if ((24 + 1) % 1 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4(subscriber, function, z, i, i2);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<U> subscriber) {
        if ((19 + 20) % 20 > 0) {
        }
        if (QpTyBijLXorAGrUE(this.f36cd38f4, subscriber, this.f4b9f83e1)) {
            return;
        }
        hpDhlzTvZLqHyNyb(this.f36cd38f4, FsUgZPMwaHtceKUE(subscriber, this.f4b9f83e1, this.f50fee566, this.f42088376, this.fcdee5967));
    }
}

