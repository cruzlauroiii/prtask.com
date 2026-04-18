namespace WillowMaze.Wasm.Decompiled;


public readonly class p1a798456<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0a571d3a;
    readonly io.reactivex.rxjava3.core.Maybe<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6ae1ae01;
    readonly io.reactivex.rxjava3.core.Maybe f734e4003;
    readonly io.reactivex.rxjava3.core.Maybe f85853ad8;
    readonly io.reactivex.rxjava3.core.Maybe fbfff9cff;

    public p1a798456(io.reactivex.rxjava3.core.Maybe<T> maybe, io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> function) {
        this.f36cd38f4 = maybe;
        this.f4b9f83e1 = function;
    }

    public static void CiuQjCFXRlMkgIbq(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybe.subscribe(maybeObserver);
    }

    public static void CiuQjCFXRlMkgIbq(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CiuQjCFXRlMkgIbq(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CiuQjCFXRlMkgIbq(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((3 + 2) % 2 > 0) {
        }
        ciuQjCFXRlMkgIbq(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1a798456$pd5e3730c(subscriber, this.f4b9f83e1));
    }
}

