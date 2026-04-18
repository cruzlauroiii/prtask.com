namespace WillowMaze.Wasm.Decompiled;


public readonly class p5238b021<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.Observable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f8490eba5;
    readonly io.reactivex.rxjava3.core.Observable f85905ad7;
    readonly io.reactivex.rxjava3.core.Observable f86394d0c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa84fdd40;
    readonly io.reactivex.rxjava3.core.Observable fcc6adde8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdcfc5a25;
    readonly io.reactivex.rxjava3.core.Observable fe4527efb;

    public p5238b021(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z) {
        this.f36cd38f4 = observable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void GaIOUmJzqFsbFsoa(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public static bool KxKYOjuyCzYFneUU(java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p864fd216.m97c40b97(obj, p86408593Var, observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((11 + 13) % 13 > 0) {
        }
        if (kxKYOjuyCzYFneUU(this.f36cd38f4, this.f4b9f83e1, observer)) {
            return;
        }
        gaIOUmJzqFsbFsoa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p5238b021$pda169406(observer, this.f4b9f83e1, this.f50fee566));
    }
}

