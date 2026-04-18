namespace WillowMaze.Wasm.Decompiled;


public readonly class pa3541f7e<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly bool f22007bbb;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.TimeUnit f4572037c;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f589c21f5;
    readonly long f7243f8be;
    readonly bool f811d2969;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Scheduler f99ac1d0e;
    readonly java.util.concurrent.TimeUnit f9f352215;
    readonly java.util.concurrent.TimeUnit fba247d85;
    readonly long fba9517c8;
    readonly long fe5ba7bfa;

    public pa3541f7e(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(observableSource);
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker FOstyyNHbAhWZqql(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void DgoMluYclFhJPzZU(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((9 + 12) % 12 > 0) {
        }
        dgoMluYclFhJPzZU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a(!this.f825ea879 ? new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer) : observer, this.f7243f8be, this.f3e34bdeb, FOstyyNHbAhWZqql(this.f499f31e7), this.f825ea879));
    }
}

