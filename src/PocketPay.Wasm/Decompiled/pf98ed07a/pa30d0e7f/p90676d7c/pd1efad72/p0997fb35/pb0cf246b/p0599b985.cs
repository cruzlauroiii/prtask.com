namespace WillowMaze.Wasm.Decompiled;


public readonly class p0599b985<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f07eec475;
    readonly bool f20bd4476;
    readonly int f2b51b804;
    readonly bool f508dc0e5;
    readonly bool f6bf418c6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f76ab66a3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f7b3fa28d;
    readonly bool f825ea879;
    readonly bool f8485a45e;
    readonly int fcdee5967;
    readonly bool fddde2b99;
    readonly bool ffceb1106;

    public p0599b985(io.reactivex.rxjava3.core.Flowable<T> flowable, int i, bool z, bool z2, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        super(flowable);
        this.fcdee5967 = i;
        this.ffceb1106 = z;
        this.f825ea879 = z2;
        this.f07eec475 = p004bf6c9Var;
    }

    public static void FJFierXdibdfttkh(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((5 + 12) % 12 > 0) {
        }
        fJFierXdibdfttkh(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8(subscriber, this.fcdee5967, this.ffceb1106, this.f825ea879, this.f07eec475));
    }
}

