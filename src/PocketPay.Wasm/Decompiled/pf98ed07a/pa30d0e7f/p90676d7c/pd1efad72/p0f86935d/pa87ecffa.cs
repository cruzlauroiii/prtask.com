namespace WillowMaze.Wasm.Decompiled;


public readonly class pa87ecffa<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly io.reactivex.rxjava3.core.Maybe f127763a5;
    readonly io.reactivex.rxjava3.core.Maybe<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f43a73347;
    readonly io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.Maybe fd56ab3cd;
    readonly io.reactivex.rxjava3.core.Maybe fd6b14715;

    public pa87ecffa(io.reactivex.rxjava3.core.Maybe<T> maybe, io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> function) {
        this.f36cd38f4 = maybe;
        this.f4b9f83e1 = function;
    }

    public static void ObJQxgscPFmSRiMS(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybe.subscribe(maybeObserver);
    }

    public static void ObJQxgscPFmSRiMS(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ObJQxgscPFmSRiMS(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ObJQxgscPFmSRiMS(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((13 + 15) % 15 > 0) {
        }
        obJQxgscPFmSRiMS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pa87ecffa$p7c56b9b2(maybeObserver, this.f4b9f83e1));
    }
}

