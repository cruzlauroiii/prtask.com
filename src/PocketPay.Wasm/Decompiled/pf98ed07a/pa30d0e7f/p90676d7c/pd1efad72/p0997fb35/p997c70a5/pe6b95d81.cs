namespace WillowMaze.Wasm.Decompiled;


public readonly class pe6b95d81<T, U> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f29a70ba3;
    readonly io.reactivex.rxjava3.core.ObservableSource f2acf060d;
    readonly io.reactivex.rxjava3.core.ObservableSource<U> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f8e9546dd;
    readonly io.reactivex.rxjava3.core.ObservableSource f9247b7ba;
    readonly io.reactivex.rxjava3.core.ObservableSource fa4fbc5b8;
    readonly io.reactivex.rxjava3.core.ObservableSource fdacfbd31;
    readonly io.reactivex.rxjava3.core.ObservableSource ff817a431;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> ffad58de7;

    public pe6b95d81(io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, io.reactivex.rxjava3.core.ObservableSource<U> observableSource2) {
        this.ffad58de7 = observableSource;
        this.f795f3202 = observableSource2;
    }

    public static void IaPADFqFsyOcjnmI(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void QsDJvsNuWQuFoScA(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((7 + 2) % 2 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        QsDJvsNuWQuFoScA(observer, pa7808658Var);
        IaPADFqFsyOcjnmI(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pe6b95d81$p3447673a(this, pa7808658Var, observer));
    }
}

