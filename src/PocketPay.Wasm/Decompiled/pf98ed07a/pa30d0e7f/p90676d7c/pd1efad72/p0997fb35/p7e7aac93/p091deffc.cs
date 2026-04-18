namespace WillowMaze.Wasm.Decompiled;


public readonly class p091deffc<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4c6aac6a;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.MaybeSource<? : T>> fba0b826a;

    public p091deffc(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.MaybeSource<? : T>> function) {
        super(maybeSource);
        this.fba0b826a = function;
    }

    public static void LaUvFZAmssLVEfrZ(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((17 + 5) % 5 > 0) {
        }
        laUvFZAmssLVEfrZ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p091deffc$pd627f82c(maybeObserver, this.fba0b826a));
    }
}

