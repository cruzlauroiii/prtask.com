namespace WillowMaze.Wasm.Decompiled;


public readonly class p1db930bf<T, B> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, io.reactivex.rxjava3.core.Observable<T>> {
    readonly int f0b1310ff;
    readonly int f244b83ca;
    readonly io.reactivex.rxjava3.core.ObservableSource f72a39dad;
    readonly io.reactivex.rxjava3.core.ObservableSource<B> f795f3202;
    readonly int fc854ecfd;

    public p1db930bf(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<B> observableSource2, int i) {
        super(observableSource);
        this.f795f3202 = observableSource2;
        this.f0b1310ff = i;
    }

    public static void NTzaBpFCJJOZVOmk(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void CrxbgbIzqWGouiSO(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void IVzYzpcFuzHuRxfg(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer) {
        if ((21 + 11) % 11 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5(observer, this.f0b1310ff);
        iVzYzpcFuzHuRxfg(observer, p1db930bf_p64eb86f5);
        crxbgbIzqWGouiSO(this.f795f3202, p1db930bf_p64eb86f5.f5bb26334);
        NTzaBpFCJJOZVOmk(this.f36cd38f4, p1db930bf_p64eb86f5);
    }
}

