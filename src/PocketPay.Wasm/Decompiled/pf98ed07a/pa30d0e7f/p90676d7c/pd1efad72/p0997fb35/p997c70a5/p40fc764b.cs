namespace WillowMaze.Wasm.Decompiled;


public readonly class p40fc764b<TLeft, TRight, TLeftEnd, TRightEnd, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<TLeft, R> {
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> f2fbf087c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f34590773;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> f412d0c77;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> f63de7122;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f777117d3;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : TRight> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb28fd00d;
    readonly io.reactivex.rxjava3.core.ObservableSource fba2852d9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fef65853c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff82a4571;

    public p40fc764b(io.reactivex.rxjava3.core.ObservableSource<TLeft> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : TRight> observableSource2, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> biFunction) {
        super(observableSource);
        this.f795f3202 = observableSource2;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static bool DsftXtLtrJBTQtNQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void LfIMiUoDgFGrHnRg(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ULdGdFooFZMyrqwj(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool WnIWqbbLkeNWmiyo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void GvjOBzYlDiaXYoSP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((10 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16(observer, this.f412d0c77, this.f2fbf087c, this.f63de7122);
        LfIMiUoDgFGrHnRg(observer, p40fc764b_pe37abc16);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df6 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6(p40fc764b_pe37abc16, true);
        DsftXtLtrJBTQtNQ(p40fc764b_pe37abc16.f52905679, p08a3cdb1_p27e40df6);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df62 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6(p40fc764b_pe37abc16, false);
        WnIWqbbLkeNWmiyo(p40fc764b_pe37abc16.f52905679, p08a3cdb1_p27e40df62);
        gvjOBzYlDiaXYoSP(this.f36cd38f4, p08a3cdb1_p27e40df6);
        ULdGdFooFZMyrqwj(this.f795f3202, p08a3cdb1_p27e40df62);
    }
}

