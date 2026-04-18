namespace WillowMaze.Wasm.Decompiled;


public readonly class pfa9467cc<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f26bbc56f;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.TimeUnit f41f56603;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f53082917;
    readonly long f90272dda;
    readonly long fd3f76228;

    public pfa9467cc(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observableSource);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker gWxaCqrTvDKCNjlN(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void SBmafQJJDZxEsuhf(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((20 + 6) % 6 > 0) {
        }
        sBmafQJJDZxEsuhf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfa9467cc$p74fc0c5a(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f90272dda, this.f3e34bdeb, gWxaCqrTvDKCNjlN(this.f499f31e7)));
    }
}

