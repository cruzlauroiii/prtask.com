namespace WillowMaze.Wasm.Decompiled;


public readonly class p84f45a11<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f173005a4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2b9c1aed;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> fa1b38de8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb3dd6620;
    readonly io.reactivex.rxjava3.core.SingleSource fbe02eba1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc76db0ff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdb0afb67;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> fe8e93457;

    public p84f45a11(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function2) {
        this.f36cd38f4 = singleSource;
        this.fe8e93457 = function;
        this.fa1b38de8 = function2;
    }

    public static void RzESgIYoOUqGOAxj(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((6 + 7) % 7 > 0) {
        }
        RzESgIYoOUqGOAxj(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e(singleObserver, this.fe8e93457, this.fa1b38de8));
    }
}

