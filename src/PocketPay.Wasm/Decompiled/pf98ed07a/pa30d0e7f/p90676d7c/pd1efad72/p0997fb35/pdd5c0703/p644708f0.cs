namespace WillowMaze.Wasm.Decompiled;


public readonly class p644708f0<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f4aec4663;
    readonly io.reactivex.rxjava3.core.SingleSource f6860161e;

    public p644708f0(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.f36cd38f4 = singleSource;
    }

    public static void FZoMNwUWQDJvIQrp(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        fZoMNwUWQDJvIQrp(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p644708f0$peaa78d7a(singleObserver));
    }
}

