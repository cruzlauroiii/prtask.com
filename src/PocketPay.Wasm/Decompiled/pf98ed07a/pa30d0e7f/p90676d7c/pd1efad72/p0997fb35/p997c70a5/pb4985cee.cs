namespace WillowMaze.Wasm.Decompiled;


public readonly class pb4985cee<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f0f601c53;
    readonly java.util.concurrent.TimeUnit f243b9b14;
    readonly long f2964196d;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f468fa96a;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f87d90441;
    readonly long f90272dda;
    readonly bool f9ad8f684;
    readonly bool fa1068ba8;
    readonly bool fa740fac9;
    readonly java.util.concurrent.TimeUnit fac2f93a9;
    readonly java.util.concurrent.TimeUnit fb6030cac;
    readonly java.util.concurrent.TimeUnit fbbe78bee;
    readonly io.reactivex.rxjava3.core.Scheduler fc8a178f3;
    readonly long fcb5bfb75;

    public pb4985cee(io.reactivex.rxjava3.core.Observable<T> observable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(observable);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f9ad8f684 = z;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker dGGTUnKvKFkXoHWs(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void EApRPSFsWUPLDWBw(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((32 + 32) % 32 > 0) {
        }
        eApRPSFsWUPLDWBw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb4985cee$pd32b7427(observer, this.f90272dda, this.f3e34bdeb, dGGTUnKvKFkXoHWs(this.f499f31e7), this.f9ad8f684));
    }
}

