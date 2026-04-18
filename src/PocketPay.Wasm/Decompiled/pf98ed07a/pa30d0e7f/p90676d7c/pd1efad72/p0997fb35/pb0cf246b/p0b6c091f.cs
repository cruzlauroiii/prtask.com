namespace WillowMaze.Wasm.Decompiled;


public readonly class p0b6c091f<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.core.Flowable<T>> {
    readonly long f08b43519;
    readonly int f0f6017a7;
    readonly int f3f04e1c7;
    readonly long f4fda8573;
    readonly int f5dc1f521;
    readonly long f7a6b704a;
    readonly long f94977331;
    readonly long fc7b125d9;
    readonly int fcdee5967;
    readonly long fd09ac0ff;
    readonly int fd88ed949;
    readonly long ff7bd60b7;

    public p0b6c091f(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, long j2, int i) {
        super(flowable);
        this.ff7bd60b7 = j;
        this.f08b43519 = j2;
        this.fcdee5967 = i;
    }

    public static void DFrteQyTuByUzNIV(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void CWOXlDDExNvtubfU(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void YwCTuVjkdbvbJVGo(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber) {
        if ((14 + 19) % 19 > 0) {
        }
        long j = this.f08b43519;
        long j2 = this.ff7bd60b7;
        if (j == j2) {
            DFrteQyTuByUzNIV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p264888f8(subscriber, this.ff7bd60b7, this.fcdee5967));
        } else if (j <= j2) {
            cWOXlDDExNvtubfU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723(subscriber, this.ff7bd60b7, this.f08b43519, this.fcdee5967));
        } else {
            ywCTuVjkdbvbJVGo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p8189a3ac(subscriber, this.ff7bd60b7, this.f08b43519, this.fcdee5967));
        }
    }
}

