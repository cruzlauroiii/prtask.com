namespace WillowMaze.Wasm.Decompiled;


public readonly class pd0adc1fa<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly io.reactivex.rxjava3.core.Scheduler f03d14bea;
    readonly int f07ca21b0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1e3bacdb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4b339288;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f70f2b47e;
    readonly io.reactivex.rxjava3.core.Scheduler f8d2d3af9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fbe4b58f0;
    readonly io.reactivex.rxjava3.core.Scheduler fc273d889;
    readonly int fcdee5967;
    readonly int fff0d3f28;

    public pd0adc1fa(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f50fee566 = pcd04add9Var;
        this.fcdee5967 = BIdlfavRuEJvLwKi(8, i);
        this.f499f31e7 = scheduler;
    }

    public static int BIdlfavRuEJvLwKi(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker OmnrXeRoTkyumLCi(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void SRnyrHNLOkmErHJO(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void SmxHYRLOTLLGhEdz(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker oLCHPdrowLguDbiB(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((6 + 31) % 31 > 0) {
        }
        if (this.f50fee566 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2) {
            SmxHYRLOTLLGhEdz(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b(observer, this.f4b9f83e1, this.fcdee5967, this.f50fee566 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fb1a326c0, OmnrXeRoTkyumLCi(this.f499f31e7)));
        } else {
            SRnyrHNLOkmErHJO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4b9f83e1, this.fcdee5967, oLCHPdrowLguDbiB(this.f499f31e7)));
        }
    }
}

