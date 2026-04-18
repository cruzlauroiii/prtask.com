namespace WillowMaze.Wasm.Decompiled;


public readonly class p94d4f95d<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly int f08b43519;
    readonly int f361f396e;

    public p94d4f95d(io.reactivex.rxjava3.core.Flowable<T> flowable, int i) {
        super(flowable);
        this.f08b43519 = i;
    }

    public static void PfeHBhPNvUawZdWP(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((25 + 5) % 5 > 0) {
        }
        pfeHBhPNvUawZdWP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p94d4f95d$pbb88ae5b(subscriber, this.f08b43519));
    }
}

