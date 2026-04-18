namespace WillowMaze.Wasm.Decompiled;


public readonly class pebc89d95<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.SingleSource f18052343;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f22dedc7b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f329b654e;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f493c4bdb;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb12ad7a9;

    public pebc89d95(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.f36cd38f4 = singleSource;
        this.f4b9f83e1 = function;
    }

    public static void RQpYEZLvnkSEiiNS(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((10 + 6) % 6 > 0) {
        }
        RQpYEZLvnkSEiiNS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pebc89d95$p2e293412(observer, this.f4b9f83e1));
    }
}

