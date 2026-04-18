namespace WillowMaze.Wasm.Decompiled;


public readonly class p32449449<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.SingleSource f15e07b9e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f33f85857;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.SingleSource f9013a5a3;
    readonly io.reactivex.rxjava3.core.SingleSource f94107ff5;

    public p32449449(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function) {
        this.f36cd38f4 = singleSource;
        this.f4b9f83e1 = function;
    }

    public static void OzISgcjzdZwVFKip(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void YqNZpOQnqZDMffzv(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((27 + 15) % 15 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p32449449$peec3693b p32449449_peec3693b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p32449449$peec3693b(observer, this.f4b9f83e1);
        yqNZpOQnqZDMffzv(observer, p32449449_peec3693b);
        OzISgcjzdZwVFKip(this.f36cd38f4, p32449449_peec3693b);
    }
}

