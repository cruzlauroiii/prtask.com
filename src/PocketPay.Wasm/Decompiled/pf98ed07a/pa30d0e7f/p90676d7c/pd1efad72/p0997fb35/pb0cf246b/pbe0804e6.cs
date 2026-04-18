namespace WillowMaze.Wasm.Decompiled;


public readonly class pbe0804e6<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly bool f0b95aebf;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4d0de374;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcb0ee9f0;
    readonly int fcdee5967;
    readonly int fe0b78481;

    public pbe0804e6(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function, int i, bool z) {
        super(flowable);
        this.f4b9f83e1 = function;
        this.fcdee5967 = i;
        this.f50fee566 = z;
    }

    public static void GpLZUGdVrHzDsroG(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static bool RIUbxpuchXsYfWzf(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6f5e6c40.m0abd2e53(p32c73be0Var, p992c4a5bVar, p86408593Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((32 + 22) % 22 > 0) {
        }
        if (rIUbxpuchXsYfWzf(this.f36cd38f4, subscriber, this.f4b9f83e1)) {
            return;
        }
        gpLZUGdVrHzDsroG(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbe0804e6$ped419cb8(subscriber, this.f4b9f83e1, this.fcdee5967, this.f50fee566));
    }
}

