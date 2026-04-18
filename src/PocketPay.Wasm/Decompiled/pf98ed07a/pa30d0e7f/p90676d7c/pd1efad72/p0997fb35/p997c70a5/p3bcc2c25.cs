namespace WillowMaze.Wasm.Decompiled;


public readonly class p3bcc2c25<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f1b8b6fcd;
    readonly long f61b0cfce;
    readonly long fa78f39d9;
    readonly long fe2942a04;

    public p3bcc2c25(io.reactivex.rxjava3.core.Observable<T> observable, long j) {
        super(observable);
        this.fe2942a04 = j;
    }

    public static void LEbJIZdaLvsDeIgm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bcc2c25$peec42446 p3bcc2c25_peec42446) {
        p3bcc2c25_peec42446.subscribeNext();
    }

    public static void BlFTnpQYWvBIMasH(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((10 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        blFTnpQYWvBIMasH(observer, pa7808658Var);
        long j = this.fe2942a04;
        LEbJIZdaLvsDeIgm(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bcc2c25$peec42446(observer, j != long.MAX_VALUE ? j - 1 : long.MAX_VALUE, pa7808658Var, this.f36cd38f4));
    }
}

