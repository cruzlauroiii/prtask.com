namespace WillowMaze.Wasm.Decompiled;


public readonly class p42f12488<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f1f88031f;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f7480e907;
    readonly io.reactivex.rxjava3.core.SingleSource f76bfb32c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f9cb9e967;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 feaf10fcf;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p42f12488(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.f36cd38f4 = singleSource;
        this.ff670ef68 = predicate;
    }

    public static void MuAJwoulZdZWHgel(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((25 + 20) % 20 > 0) {
        }
        muAJwoulZdZWHgel(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p42f12488$pd32950e0(maybeObserver, this.ff670ef68));
    }
}

