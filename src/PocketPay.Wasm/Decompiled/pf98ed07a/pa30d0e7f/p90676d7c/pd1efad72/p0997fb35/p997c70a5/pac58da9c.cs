namespace WillowMaze.Wasm.Decompiled;


public readonly class pac58da9c<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f17eb3595;
    readonly io.reactivex.rxjava3.core.Scheduler f1bb52328;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f45e81a3d;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f9ad8f684;
    readonly long f9c68bbbb;
    readonly bool f9ec29bec;
    readonly long fa0acfa46;
    readonly java.util.concurrent.TimeUnit fc6d65102;
    readonly io.reactivex.rxjava3.core.Scheduler fd186cfcc;
    readonly java.util.concurrent.TimeUnit fe430bfa9;
    readonly io.reactivex.rxjava3.core.Scheduler ff4ac3926;
    readonly long ff8bb4f18;

    public pac58da9c(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(observableSource);
        this.fa0acfa46 = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f9ad8f684 = z;
    }

    public static void RcTGkLRUyBSLRgyS(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void RiAEWpQdMGRwXXju(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((19 + 5) % 5 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 p74f2a0f6Var = new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer);
        if (this.f9ad8f684) {
            RcTGkLRUyBSLRgyS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pb270b383(p74f2a0f6Var, this.fa0acfa46, this.f3e34bdeb, this.f499f31e7));
        } else {
            riAEWpQdMGRwXXju(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$p4878127b(p74f2a0f6Var, this.fa0acfa46, this.f3e34bdeb, this.f499f31e7));
        }
    }
}

