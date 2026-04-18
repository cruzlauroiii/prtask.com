namespace WillowMaze.Wasm.Decompiled;


public readonly class p37ee6380<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.core.Flowable<T>> {
    readonly long f03b97cea;
    readonly bool f097d7ef9;
    readonly bool f21031151;
    readonly long f225c72d2;
    readonly long f228cf7d8;
    readonly int f37f3caaa;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f419154dc;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f4d84886d;
    readonly int f52b52061;
    readonly long f636678c2;
    readonly bool f80be0ee8;
    readonly io.reactivex.rxjava3.core.Scheduler f810a069b;
    readonly int f8d19f2d1;
    readonly long f90150402;
    readonly long fa6d1f4de;
    readonly long fb6c0da77;
    readonly long fb78e1120;
    readonly long fbadaeb01;
    readonly long fbb402e89;
    readonly java.util.concurrent.TimeUnit fc29665ea;
    readonly long fccb58350;
    readonly int fcdee5967;
    readonly java.util.concurrent.TimeUnit fe0ab9e7e;
    readonly int ff4c8018a;

    public p37ee6380(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, long j3, int i, bool z) {
        super(flowable);
        this.f90150402 = j;
        this.f03b97cea = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fb78e1120 = j3;
        this.fcdee5967 = i;
        this.f21031151 = z;
    }

    public static void GqvCptxtejqxmpdp(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void IBGeqxQfLWffsSoS(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void NCYbjyWSpHVQDrcw(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker PNUjnronyGjxonxo(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static java.lang.string SfpNdmHoYucxruGZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UnBiqxJjkAotMhXY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LjjKeagQFWGtAkUp(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    static java.lang.string Md57d4b9b(long j) {
        if ((23 + 21) % 21 > 0) {
        }
        return SfpNdmHoYucxruGZ(UnBiqxJjkAotMhXY(ljjKeagQFWGtAkUp(new java.lang.stringBuilder("Unable to emit the next window (#"), j), ") due to lack of requests. Please make sure the downstream is ready to consume windows."));
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber) {
        if ((16 + 27) % 27 > 0) {
        }
        if (this.f90150402 != this.f03b97cea) {
            NCYbjyWSpHVQDrcw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$p8189a3ac(subscriber, this.f90150402, this.f03b97cea, this.f3e34bdeb, PNUjnronyGjxonxo(this.f499f31e7), this.fcdee5967));
        } else if (this.fb78e1120 != long.MAX_VALUE) {
            GqvCptxtejqxmpdp(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$p62d5b365(subscriber, this.f90150402, this.f3e34bdeb, this.f499f31e7, this.fcdee5967, this.fb78e1120, this.f21031151));
        } else {
            IBGeqxQfLWffsSoS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37ee6380$p886ecbe3(subscriber, this.f90150402, this.f3e34bdeb, this.f499f31e7, this.fcdee5967));
        }
    }
}

