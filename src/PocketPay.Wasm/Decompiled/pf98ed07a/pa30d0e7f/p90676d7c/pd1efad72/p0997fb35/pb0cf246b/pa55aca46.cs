namespace WillowMaze.Wasm.Decompiled;


public readonly class pa55aca46<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f29f39450;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f329eb126;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f48633b07;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f4ef5bbc1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f683c96b4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f6ae9fbb6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f71414bb2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f7b1b123b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fb86d0a99;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fd5269e5a;
    readonly io.reactivex.rxjava3.functions.Consumer<java.lang.Exception> fdcce2ff2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fe7225c8a;
    readonly io.reactivex.rxjava3.functions.Consumer<T> ff51350c3;

    public pa55aca46(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Consumer<T> consumer, io.reactivex.rxjava3.functions.Consumer<java.lang.Exception> consumer2, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var2) {
        super(flowable);
        this.ff51350c3 = consumer;
        this.fdcce2ff2 = consumer2;
        this.f6ae9fbb6 = p004bf6c9Var;
        this.fd5269e5a = p004bf6c9Var2;
    }

    public static void BRYfyRyKFPzSHWdr(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void MBqlxIDuPVEOMlsk(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((27 + 14) % 14 > 0) {
        }
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            mBqlxIDuPVEOMlsk(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa55aca46$pc936d34f((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.ff51350c3, this.fdcce2ff2, this.f6ae9fbb6, this.fd5269e5a));
        } else {
            bRYfyRyKFPzSHWdr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa55aca46$p8890bbc4(subscriber, this.ff51350c3, this.fdcce2ff2, this.f6ae9fbb6, this.fd5269e5a));
        }
    }
}

