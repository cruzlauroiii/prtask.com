namespace WillowMaze.Wasm.Decompiled;


public readonly class pe7c376bd<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f01c85c66;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f89f90c73;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 ffec7a302;

    public pe7c376bd(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        super(maybeSource);
        this.ff670ef68 = predicate;
    }

    public static void HlisRBDGvUNZRAxC(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((12 + 1) % 1 > 0) {
        }
        HlisRBDGvUNZRAxC(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe7c376bd$p19001454(maybeObserver, this.ff670ef68));
    }
}

