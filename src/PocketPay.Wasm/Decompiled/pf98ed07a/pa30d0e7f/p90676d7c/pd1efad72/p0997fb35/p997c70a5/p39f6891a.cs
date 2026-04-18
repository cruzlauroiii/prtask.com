namespace WillowMaze.Wasm.Decompiled;


public readonly class p39f6891a<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly java.util.concurrent.TimeUnit f0ca58382;
    readonly io.reactivex.rxjava3.core.Scheduler f302fb627;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f592081eb;
    readonly java.util.concurrent.TimeUnit f7629c8b9;
    readonly long f90260174;
    readonly long f90272dda;
    readonly java.util.concurrent.TimeUnit fba857371;
    readonly io.reactivex.rxjava3.core.Scheduler fc2895090;

    public p39f6891a(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observableSource);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker HFYlFBXVvoECsssp(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void WitfqasuWdUOfULP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((26 + 7) % 7 > 0) {
        }
        WitfqasuWdUOfULP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p74fc0c5a(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f90272dda, this.f3e34bdeb, HFYlFBXVvoECsssp(this.f499f31e7)));
    }
}

