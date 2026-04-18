namespace WillowMaze.Wasm.Decompiled;


public readonly class p712f06a3<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.core.Notification<T>> {
    public p712f06a3(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        super(flowable);
    }

    public static void FflwZGGRWXbbLcWj(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Notification<T>> subscriber) {
        FflwZGGRWXbbLcWj(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p712f06a3$pa610fdff(subscriber));
    }
}

