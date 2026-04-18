namespace WillowMaze.Wasm.Decompiled;


public readonly class p248fdbe9<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f168e7247;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f995a510e;
    readonly io.reactivex.rxjava3.core.SingleSource f9b72e69a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fd4b0c25f;
    readonly io.reactivex.rxjava3.core.SingleSource fd8322f5f;
    readonly io.reactivex.rxjava3.functions.Consumer<java.lang.Exception> fdcce2ff2;

    public p248fdbe9(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Consumer<java.lang.Exception> consumer) {
        this.f36cd38f4 = singleSource;
        this.fdcce2ff2 = consumer;
    }

    public static void FvHpaVjLzMHqHjVb(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((3 + 28) % 28 > 0) {
        }
        fvHpaVjLzMHqHjVb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p248fdbe9$p36212573(this, singleObserver));
    }
}

