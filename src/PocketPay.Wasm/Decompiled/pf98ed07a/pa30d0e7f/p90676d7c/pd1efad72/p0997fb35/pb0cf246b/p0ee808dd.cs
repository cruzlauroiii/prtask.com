namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ee808dd<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0ab972f2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f0e6c8c23;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4b3ea8ff;
    readonly io.reactivex.rxjava3.functions.Supplier<? : R> f6c1d5d4f;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f81778e72;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : R> fa1b38de8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa52aaa79;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd41cde1c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd4f9c78f;

    public p0ee808dd(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : R> function2, io.reactivex.rxjava3.functions.Supplier<? : R> supplier) {
        super(flowable);
        this.f81778e72 = function;
        this.fa1b38de8 = function2;
        this.f6c1d5d4f = supplier;
    }

    public static void UHiJdgMzchWeQuib(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((27 + 11) % 11 > 0) {
        }
        uHiJdgMzchWeQuib(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ee808dd$p3fcbec52(subscriber, this.f81778e72, this.fa1b38de8, this.f6c1d5d4f));
    }
}

