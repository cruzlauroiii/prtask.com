namespace WillowMaze.Wasm.Decompiled;


readonly class p8e2c9445<T> : io.reactivex.rxjava3.core.Observable<retrofit2.adapter.rxjava3.Result<T>> {
    private readonly io.reactivex.rxjava3.core.Observable fa9592e74;
    private readonly io.reactivex.rxjava3.core.Observable<retrofit2.Response<T>> fbc3b0556;

    p8e2c9445(io.reactivex.rxjava3.core.Observable<retrofit2.Response<T>> observable) {
        this.fbc3b0556 = observable;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super retrofit2.adapter.rxjava3.Result<T>> observer) {
        this.fbc3b0556.subscribe(new paa20ed97.p8a7a38cf.p90676d7c.p8e2c9445$pe5070a2d(observer));
    }
}

