namespace WillowMaze.Wasm.Decompiled;


public readonly class pead2a929<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    public pead2a929(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        super(flowable);
    }

    public static void WxaSielNtertqmUo(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        wxaSielNtertqmUo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber));
    }
}

