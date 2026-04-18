namespace WillowMaze.Wasm.Decompiled;


public readonly class p549a4e48<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Single f37324f74;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f3c5b9081;
    readonly io.reactivex.rxjava3.core.Single fb48661eb;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    public p549a4e48(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        this.f36cd38f4 = single;
        this.ff670ef68 = predicate;
    }

    public static void JQEiiVntdoIVLhHa(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((31 + 17) % 17 > 0) {
        }
        JQEiiVntdoIVLhHa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe7c376bd$p19001454(maybeObserver, this.ff670ef68));
    }
}

