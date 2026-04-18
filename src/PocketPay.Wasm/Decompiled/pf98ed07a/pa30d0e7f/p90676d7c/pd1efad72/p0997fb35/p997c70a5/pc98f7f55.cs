namespace WillowMaze.Wasm.Decompiled;


public readonly class pc98f7f55<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly long f03b97cea;
    readonly long f0da39d5d;
    readonly bool f188073a9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f19907ce9;
    readonly bool f21031151;
    readonly long f3813fd43;
    readonly long f3b321e64;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f45264641;
    readonly int f4594ac3b;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly long f4fbfcfa4;
    readonly long f5293d107;
    readonly int f55fd0268;
    readonly long f5a0ab8bb;
    readonly bool f6b300ccb;
    readonly bool f76880fe3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f7777ccbe;
    readonly int f8656e18d;
    readonly long f882e1a45;
    readonly long f90150402;
    readonly java.util.concurrent.TimeUnit f91f97d99;
    readonly int faab387bf;
    readonly long fb57569ea;
    readonly int fb78e1120;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe3cd052a;
    readonly io.reactivex.rxjava3.core.Scheduler ff63a677c;

    public pc98f7f55(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, io.reactivex.rxjava3.functions.Supplier<U> supplier, int i, bool z) {
        super(observableSource);
        this.f90150402 = j;
        this.f03b97cea = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f4af2b822 = supplier;
        this.fb78e1120 = i;
        this.f21031151 = z;
    }

    public static void AdiuWJzZWIsTbsKS(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void CpyATsUArvRAFuxf(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker MWAVlHpyvSFtCgXJ(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void QveyjiuApPtuhuoo(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((26 + 23) % 23 > 0) {
        }
        if (this.f90150402 == this.f03b97cea && this.fb78e1120 == int.MAX_VALUE) {
            AdiuWJzZWIsTbsKS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p92d6b98c(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4af2b822, this.f90150402, this.f3e34bdeb, this.f499f31e7));
            return;
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerMWAVlHpyvSFtCgXJ = MWAVlHpyvSFtCgXJ(this.f499f31e7);
        if (this.f90150402 != this.f03b97cea) {
            CpyATsUArvRAFuxf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p818d737a(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4af2b822, this.f90150402, this.f03b97cea, this.f3e34bdeb, scheduler$WorkerMWAVlHpyvSFtCgXJ));
        } else {
            qveyjiuApPtuhuoo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc98f7f55$p4be479ca(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4af2b822, this.f90150402, this.f3e34bdeb, this.fb78e1120, this.f21031151, scheduler$WorkerMWAVlHpyvSFtCgXJ));
        }
    }
}

