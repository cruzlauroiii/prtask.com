namespace WillowMaze.Wasm.Decompiled;


public readonly class p08a3cdb1<TLeft, TRight, TLeftEnd, TRightEnd, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<TLeft, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1438d641;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> f2fbf087c;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> f412d0c77;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f540942ba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5a793149;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5c27ac17;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Observable<TRight>, ? : R> f63de7122;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : TRight> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f7eef1b0c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8ae5068a;
    readonly io.reactivex.rxjava3.core.ObservableSource f9d9fc65a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9e19ef5d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbec23f85;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc0324bc0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdcfa5ade;
    readonly io.reactivex.rxjava3.core.ObservableSource fe7635d2c;

    public p08a3cdb1(io.reactivex.rxjava3.core.ObservableSource<TLeft> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : TRight> observableSource2, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Observable<TRight>, ? : R> biFunction) {
        super(observableSource);
        this.f795f3202 = observableSource2;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static bool AGEsGZtIgSjNOhNZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static bool WVZNrUqukWGzODpW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void YIIkcCqRSIVdREam(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void NZmeoZUrnwQfNcNY(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void RbjoNPjNZVaPnqWf(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((17 + 29) % 29 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e(observer, this.f412d0c77, this.f2fbf087c, this.f63de7122);
        nZmeoZUrnwQfNcNY(observer, p08a3cdb1_p2781571e);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df6 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6(p08a3cdb1_p2781571e, true);
        WVZNrUqukWGzODpW(p08a3cdb1_p2781571e.f52905679, p08a3cdb1_p27e40df6);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df62 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6(p08a3cdb1_p2781571e, false);
        AGEsGZtIgSjNOhNZ(p08a3cdb1_p2781571e.f52905679, p08a3cdb1_p27e40df62);
        YIIkcCqRSIVdREam(this.f36cd38f4, p08a3cdb1_p27e40df6);
        rbjoNPjNZVaPnqWf(this.f795f3202, p08a3cdb1_p27e40df62);
    }
}

