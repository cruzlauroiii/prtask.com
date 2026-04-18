namespace WillowMaze.Wasm.Decompiled;


public readonly class p81dff1b0<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, io.reactivex.rxjava3.core.Observable<T>> {
    readonly java.util.concurrent.TimeUnit f036eea14;
    readonly long f03b97cea;
    readonly long f07f6622e;
    readonly long f0f392c61;
    readonly long f1ef91eb3;
    readonly bool f21031151;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f42926ab1;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f73d22d93;
    readonly long f77a0edca;
    readonly int f7ad6f6a3;
    readonly io.reactivex.rxjava3.core.Scheduler f80fff24f;
    readonly long f8a100392;
    readonly long f90150402;
    readonly int f9ac5465f;
    readonly bool fa3b77018;
    readonly long fb19af081;
    readonly long fb78e1120;
    readonly int fcdee5967;
    readonly java.util.concurrent.TimeUnit ffe49109b;

    public p81dff1b0(io.reactivex.rxjava3.core.Observable<T> observable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, long j3, int i, bool z) {
        super(observable);
        this.f90150402 = j;
        this.f03b97cea = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fb78e1120 = j3;
        this.fcdee5967 = i;
        this.f21031151 = z;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker BEScIDJaArgiKnDx(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void XcdQrogNNBginOMU(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void JXoJmPSVlgzpPyaU(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void TgGnXMfJVDNxEQfC(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer) {
        if ((16 + 23) % 23 > 0) {
        }
        if (this.f90150402 != this.f03b97cea) {
            XcdQrogNNBginOMU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pf29e7156(observer, this.f90150402, this.f03b97cea, this.f3e34bdeb, BEScIDJaArgiKnDx(this.f499f31e7), this.fcdee5967));
        } else if (this.fb78e1120 != long.MAX_VALUE) {
            jXoJmPSVlgzpPyaU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2(observer, this.f90150402, this.f3e34bdeb, this.f499f31e7, this.fcdee5967, this.fb78e1120, this.f21031151));
        } else {
            tgGnXMfJVDNxEQfC(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$pc5b56990(observer, this.f90150402, this.f3e34bdeb, this.f499f31e7, this.fcdee5967));
        }
    }
}

