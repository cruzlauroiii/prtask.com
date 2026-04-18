namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p561285f1<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.observables.ConnectableObservable<T>> {
    private readonly io.reactivex.rxjava3.core.Observable f02d915a1;
    private readonly io.reactivex.rxjava3.core.Observable f4939e9f4;
    private readonly io.reactivex.rxjava3.core.Observable f5b7f092b;
    private readonly io.reactivex.rxjava3.core.Observable fb5ed2429;
    private readonly io.reactivex.rxjava3.core.Observable<T> fd0e45878;

    p9a814744$p561285f1(io.reactivex.rxjava3.core.Observable<T> observable) {
        this.fd0e45878 = observable;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be JvJzdJPTECMqUqiB(io.reactivex.rxjava3.core.Observable observable) {
        return observable.replay();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be VvHIKWDhhkksgkEa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p561285f1 p9a814744_p561285f1) {
        return p9a814744_p561285f1.m3941get();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return vvHIKWDhhkksgkEa(this);
    }

    public io.reactivex.rxjava3.observables.ConnectableObservable<T> M3941get() {
        return JvJzdJPTECMqUqiB(this.fd0e45878);
    }
}

