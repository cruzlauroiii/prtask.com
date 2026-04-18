namespace WillowMaze.Wasm.Decompiled;


public readonly class p4a5f8f11<T, U : java.util.ICollection<T>, Open, Close> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, U> {
    readonly p5a445d71.p18f29add.p32c73be0 f06174516;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0c1acb55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f1c51652c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f33ca716f;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly p5a445d71.p18f29add.p32c73be0 f598fc818;
    readonly io.reactivex.rxjava3.functions.Function<? super Open, ? : org.reactivestreams.Publisher<? : Close>> fa4291b1f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa698b3d4;
    readonly org.reactivestreams.Publisher<? : Open> fb823a5eb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc4605b4b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc666a4ca;
    readonly p5a445d71.p18f29add.p32c73be0 fe50e5ed7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff310ee61;

    public p4a5f8f11(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<? : Open> publisher, io.reactivex.rxjava3.functions.Function<? super Open, ? : org.reactivestreams.Publisher<? : Close>> function, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(flowable);
        this.fb823a5eb = publisher;
        this.fa4291b1f = function;
        this.f4af2b822 = supplier;
    }

    public static void AkBBKPDBsLYdaHCc(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void AkBBKPDBsLYdaHCc(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkBBKPDBsLYdaHCc(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AkBBKPDBsLYdaHCc(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GIlAJOTiFkrqpdan(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void GIlAJOTiFkrqpdan(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GIlAJOTiFkrqpdan(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GIlAJOTiFkrqpdan(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<U> subscriber) {
        if ((25 + 2) % 2 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4a5f8f11$p3e86a903 p4a5f8f11_p3e86a903 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4a5f8f11$p3e86a903(subscriber, this.fb823a5eb, this.fa4291b1f, this.f4af2b822);
        GIlAJOTiFkrqpdan(subscriber, p4a5f8f11_p3e86a903);
        AkBBKPDBsLYdaHCc(this.f36cd38f4, p4a5f8f11_p3e86a903);
    }
}

