namespace WillowMaze.Wasm.Decompiled;


public readonly class p2dc94426<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly bool f034a0988;
    readonly bool f25b484a4;
    readonly io.reactivex.rxjava3.core.Scheduler f31569c34;
    readonly bool f331ec8da;
    readonly io.reactivex.rxjava3.core.Scheduler f3c3f3433;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f608a78da;
    readonly long f67691af4;
    readonly long f89b8cc61;
    readonly bool f9ad8f684;
    readonly long fa0acfa46;
    readonly io.reactivex.rxjava3.core.Scheduler feaa1d141;
    readonly java.util.concurrent.TimeUnit ffea1f8ab;

    public p2dc94426(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(flowable);
        this.fa0acfa46 = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f9ad8f684 = z;
    }

    public static void BDWdPkROroWtFwqb(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void JyCdJVwwQKkOVMnh(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((8 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var = new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber);
        if (this.f9ad8f684) {
            jyCdJVwwQKkOVMnh(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pb270b383(p43808dd0Var, this.fa0acfa46, this.f3e34bdeb, this.f499f31e7));
        } else {
            BDWdPkROroWtFwqb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$p4878127b(p43808dd0Var, this.fa0acfa46, this.f3e34bdeb, this.f499f31e7));
        }
    }
}

