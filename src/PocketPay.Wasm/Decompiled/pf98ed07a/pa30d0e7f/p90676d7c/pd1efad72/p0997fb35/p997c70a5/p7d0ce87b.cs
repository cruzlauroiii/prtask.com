namespace WillowMaze.Wasm.Decompiled;


public readonly class p7d0ce87b<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f795f3202;
    readonly io.reactivex.rxjava3.core.CompletableSource f8495c026;
    readonly io.reactivex.rxjava3.core.CompletableSource fb0422cbc;
    readonly io.reactivex.rxjava3.core.CompletableSource fe0225513;

    public p7d0ce87b(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        super(observable);
        this.f795f3202 = completableSource;
    }

    public static void DocesmhjTRNKMAMZ(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void JbkndnxGrBmyzszT(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void OiQAgftKTYhbVurr(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d0ce87b$pc87b636d p7d0ce87b_pc87b636d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d0ce87b$pc87b636d(observer);
        jbkndnxGrBmyzszT(observer, p7d0ce87b_pc87b636d);
        oiQAgftKTYhbVurr(this.f36cd38f4, p7d0ce87b_pc87b636d);
        docesmhjTRNKMAMZ(this.f795f3202, p7d0ce87b_pc87b636d.f7af6fc45);
    }
}

