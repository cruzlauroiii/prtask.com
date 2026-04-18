namespace WillowMaze.Wasm.Decompiled;


public readonly class pe9e86cc1<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f2076f848;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f23b95e08;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f322d5ab3;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f525dcf28;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f52ec47d1;
    private readonly io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f5788df95;

    public pe9e86cc1(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> consumer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        super(observable);
        this.f5788df95 = consumer;
        this.f2076f848 = p004bf6c9Var;
    }

    public static void MFFWCvlFRVdCcWDb(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((21 + 16) % 16 > 0) {
        }
        MFFWCvlFRVdCcWDb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p1a801758(observer, this.f5788df95, this.f2076f848));
    }
}

