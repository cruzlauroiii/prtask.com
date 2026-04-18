namespace WillowMaze.Wasm.Decompiled;


public readonly class p2e204e81<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f0bb87fa8;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f58716175;
    readonly io.reactivex.rxjava3.core.SingleSource fd4b6a5f8;
    readonly io.reactivex.rxjava3.functions.Consumer<T> ff36fb8bf;

    public p2e204e81(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        this.f36cd38f4 = singleSource;
        this.ff36fb8bf = consumer;
    }

    public static void DsaoFDxDAviVyokI(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((1 + 11) % 11 > 0) {
        }
        dsaoFDxDAviVyokI(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p2e204e81$pd309e11d(this, singleObserver));
    }
}

