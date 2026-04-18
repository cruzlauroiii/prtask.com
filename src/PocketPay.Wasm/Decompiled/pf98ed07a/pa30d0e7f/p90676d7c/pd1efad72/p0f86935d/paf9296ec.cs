namespace WillowMaze.Wasm.Decompiled;


public readonly class paf9296ec<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly io.reactivex.rxjava3.core.Single f0c919cb4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0d801847;
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7313679f;
    readonly io.reactivex.rxjava3.core.Single f90535478;
    readonly io.reactivex.rxjava3.core.Single f95adccdf;
    readonly io.reactivex.rxjava3.core.Single faaaff497;

    public paf9296ec(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> function) {
        this.f36cd38f4 = single;
        this.f4b9f83e1 = function;
    }

    public static void ZghkvjkLCuqblngK(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    public static void ZghkvjkLCuqblngK(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZghkvjkLCuqblngK(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZghkvjkLCuqblngK(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((3 + 10) % 10 > 0) {
        }
        ZghkvjkLCuqblngK(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.paf9296ec$pf835a8b8(maybeObserver, this.f4b9f83e1));
    }
}

