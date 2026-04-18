namespace WillowMaze.Wasm.Decompiled;


public readonly class p9cfd2a4f<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f2159e811;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fc06fb47b;
    readonly long fe2942a04;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    public p9cfd2a4f(io.reactivex.rxjava3.core.Observable<T> observable, long j, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        super(observable);
        this.ff670ef68 = predicate;
        this.fe2942a04 = j;
    }

    public static void LIhVcrdPXIhJxfvw(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void IeiNQxppiNpJUNVp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cfd2a4f$peec42446 p9cfd2a4f_peec42446) {
        p9cfd2a4f_peec42446.subscribeNext();
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((31 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        LIhVcrdPXIhJxfvw(observer, pa7808658Var);
        ieiNQxppiNpJUNVp(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cfd2a4f$peec42446(observer, this.fe2942a04, this.ff670ef68, pa7808658Var, this.f36cd38f4));
    }
}

