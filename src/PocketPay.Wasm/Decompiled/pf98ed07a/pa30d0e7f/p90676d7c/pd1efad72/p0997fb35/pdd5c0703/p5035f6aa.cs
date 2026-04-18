namespace WillowMaze.Wasm.Decompiled;


public readonly class p5035f6aa<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource f15e6a714;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f69ee6a10;
    readonly io.reactivex.rxjava3.core.Scheduler f91247fc4;
    readonly io.reactivex.rxjava3.core.Scheduler f9f07d111;
    readonly io.reactivex.rxjava3.core.SingleSource fca327839;
    readonly io.reactivex.rxjava3.core.Scheduler ff6a4b9c4;

    public p5035f6aa(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f36cd38f4 = singleSource;
        this.f499f31e7 = scheduler;
    }

    public static void BnNXvqawTTqihMzN(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((6 + 27) % 27 > 0) {
        }
        bnNXvqawTTqihMzN(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p5035f6aa$pe67cfff0(singleObserver, this.f499f31e7));
    }
}

