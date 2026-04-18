namespace WillowMaze.Wasm.Decompiled;


public readonly class p471f7e18<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f28fc7115;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fca4c337c;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fda3736f2;

    public p471f7e18(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        super(maybeSource);
        this.fda3736f2 = function;
    }

    public static void BVOoNGCGdsWgdjRG(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((29 + 9) % 9 > 0) {
        }
        BVOoNGCGdsWgdjRG(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p471f7e18$p4bc0959a(maybeObserver, this.fda3736f2));
    }
}

