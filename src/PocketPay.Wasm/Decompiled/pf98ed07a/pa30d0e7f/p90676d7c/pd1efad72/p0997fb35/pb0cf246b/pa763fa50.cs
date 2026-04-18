namespace WillowMaze.Wasm.Decompiled;


public readonly class pa763fa50<T, U : java.util.ICollection<T>, B> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f1961a547;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f37450e22;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f53a612d7;
    readonly org.reactivestreams.Publisher<B> f81fd830c;
    readonly p5a445d71.p18f29add.p32c73be0 f875bf22b;
    readonly p5a445d71.p18f29add.p32c73be0 fa7d25ce9;
    readonly p5a445d71.p18f29add.p32c73be0 faadeeb3a;
    readonly p5a445d71.p18f29add.p32c73be0 fc3da48af;

    public pa763fa50(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<B> publisher, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(flowable);
        this.f81fd830c = publisher;
        this.f4af2b822 = supplier;
    }

    public static void EVZBOWdhMtwdjdZM(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void EVZBOWdhMtwdjdZM(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EVZBOWdhMtwdjdZM(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EVZBOWdhMtwdjdZM(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<U> subscriber) {
        if ((13 + 32) % 32 > 0) {
        }
        EVZBOWdhMtwdjdZM(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa763fa50$p0354e3e5(new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber), this.f4af2b822, this.f81fd830c));
    }
}

