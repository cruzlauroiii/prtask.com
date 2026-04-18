namespace WillowMaze.Wasm.Decompiled;


public readonly class pc7931aa6<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly T f16830a58;
    readonly java.lang.object f1752f467;
    readonly bool f1d2566b1;
    readonly long f3d1c9128;
    readonly long f4fa7f531;
    readonly long f6a992d55;
    readonly java.lang.object f98b69e50;
    readonly java.lang.object fbee72687;
    readonly long fdfd0353f;
    readonly bool ff37ffe77;

    public pc7931aa6(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, T t, bool z) {
        super(flowable);
        this.f6a992d55 = j;
        this.f16830a58 = t;
        this.f1d2566b1 = z;
    }

    public static void AQiGFUVsaCNsXqGs(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((18 + 30) % 30 > 0) {
        }
        AQiGFUVsaCNsXqGs(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc7931aa6$p6b4417bd(subscriber, this.f6a992d55, this.f16830a58, this.f1d2566b1));
    }
}

