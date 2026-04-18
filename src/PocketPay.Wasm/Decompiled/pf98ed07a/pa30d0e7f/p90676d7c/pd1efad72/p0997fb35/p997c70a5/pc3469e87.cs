namespace WillowMaze.Wasm.Decompiled;


public readonly class pc3469e87<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f0e7c757d;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.ObservableSource f4abe7ba9;
    readonly io.reactivex.rxjava3.core.Scheduler f5df85db4;
    readonly long f63c031db;
    readonly io.reactivex.rxjava3.core.Scheduler f64ffc215;
    readonly long f6cc71219;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f7dc7cddb;
    readonly long f90272dda;
    readonly io.reactivex.rxjava3.core.Scheduler fa30baab0;
    readonly java.util.concurrent.TimeUnit fcd241f99;

    public pc3469e87(io.reactivex.rxjava3.core.Observable<T> observable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        super(observable);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f795f3202 = observableSource;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker ASDChkaFRqUFnEMf(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void TFdFKNWOGAEYMTQK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p380be188 pc3469e87_p380be188, long j) {
        pc3469e87_p380be188.startTimeout(j);
    }

    public static void BwGrRoFWIZkReLTV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p45a20df8 pc3469e87_p45a20df8, long j) {
        pc3469e87_p45a20df8.startTimeout(j);
    }

    public static void EBEeAYqTPBUsyiov(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void FQnHyylruozxWudR(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker paPDgXHiugJPmclZ(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void ZJLRfcszIIoKQFZA(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ZhdsMrRrDfXarGck(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((9 + 28) % 28 > 0) {
        }
        if (this.f795f3202 is not null) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p45a20df8 pc3469e87_p45a20df8 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p45a20df8(observer, this.f90272dda, this.f3e34bdeb, paPDgXHiugJPmclZ(this.f499f31e7), this.f795f3202);
            fQnHyylruozxWudR(observer, pc3469e87_p45a20df8);
            bwGrRoFWIZkReLTV(pc3469e87_p45a20df8, 0L);
            eBEeAYqTPBUsyiov(this.f36cd38f4, pc3469e87_p45a20df8);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p380be188 pc3469e87_p380be188 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3469e87$p380be188(observer, this.f90272dda, this.f3e34bdeb, ASDChkaFRqUFnEMf(this.f499f31e7));
        zJLRfcszIIoKQFZA(observer, pc3469e87_p380be188);
        TFdFKNWOGAEYMTQK(pc3469e87_p380be188, 0L);
        zhdsMrRrDfXarGck(this.f36cd38f4, pc3469e87_p380be188);
    }
}

