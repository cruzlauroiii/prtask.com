namespace WillowMaze.Wasm.Decompiled;


public readonly class pa534c8fa<T> : io.reactivex.rxjava3.core.Single<io.reactivex.rxjava3.core.Notification<T>> {
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Single fa5d6d764;
    readonly io.reactivex.rxjava3.core.Single fd99f00c3;
    readonly io.reactivex.rxjava3.core.Single ff6bd57b0;

    public pa534c8fa(io.reactivex.rxjava3.core.Single<T> single) {
        this.f36cd38f4 = single;
    }

    public static void MmnDnPqmPbCGzPaw(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.core.Notification<T>> singleObserver) {
        mmnDnPqmPbCGzPaw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pfbfa53ab(singleObserver));
    }
}

