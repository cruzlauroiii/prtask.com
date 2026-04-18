namespace WillowMaze.Wasm.Decompiled;


readonly class p9806158f<T> : io.reactivex.rxjava3.core.Observable<T> {
    private readonly io.reactivex.rxjava3.core.Observable f0d36b409;
    private readonly io.reactivex.rxjava3.core.Observable<retrofit2.Response<T>> fbc3b0556;

    p9806158f(io.reactivex.rxjava3.core.Observable<retrofit2.Response<T>> observable) {
        this.fbc3b0556 = observable;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fbc3b0556.subscribe(new paa20ed97.p8a7a38cf.p90676d7c.p9806158f$p0e7dd80e(observer));
    }
}

