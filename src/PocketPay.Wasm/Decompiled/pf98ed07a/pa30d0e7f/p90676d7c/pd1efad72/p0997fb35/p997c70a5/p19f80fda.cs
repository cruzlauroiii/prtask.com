namespace WillowMaze.Wasm.Decompiled;


public readonly class p19f80fda<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f1b97ad7d;
    readonly bool f2e28d80d;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly int f7a67aa3d;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Scheduler fb965d1f8;
    readonly bool fba22e308;
    readonly int fcdee5967;

    public p19f80fda(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.Scheduler scheduler, bool z, int i) {
        super(observableSource);
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
        this.fcdee5967 = i;
    }

    public static void AZmSNGbcgrgqLHIa(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void IBZbEnFkTdmHkUAh(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker VyMqDtMtUuFWApEw(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((30 + 15) % 15 > 0) {
        }
        io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
        if (scheduler is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e) {
            IBZbEnFkTdmHkUAh(this.f36cd38f4, observer);
        } else {
            AZmSNGbcgrgqLHIa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1(observer, VyMqDtMtUuFWApEw(scheduler), this.f825ea879, this.fcdee5967));
        }
    }
}

