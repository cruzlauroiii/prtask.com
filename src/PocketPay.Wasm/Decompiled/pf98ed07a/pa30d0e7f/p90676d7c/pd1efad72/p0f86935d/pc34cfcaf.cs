namespace WillowMaze.Wasm.Decompiled;


public readonly class pc34cfcaf<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0edfdcad;
    readonly io.reactivex.rxjava3.core.Maybe<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3d0df35b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4221811e;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f56cf0104;
    readonly io.reactivex.rxjava3.core.Maybe f6b076f9e;
    readonly io.reactivex.rxjava3.core.Maybe f900ead6a;

    public pc34cfcaf(io.reactivex.rxjava3.core.Maybe<T> maybe, io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> function) {
        this.f36cd38f4 = maybe;
        this.f4b9f83e1 = function;
    }

    public static void HkxGUteSJWqbTanf(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybe.subscribe(maybeObserver);
    }

    public static void HkxGUteSJWqbTanf(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HkxGUteSJWqbTanf(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HkxGUteSJWqbTanf(io.reactivex.rxjava3.core.Maybe maybe, io.reactivex.rxjava3.core.MaybeObserver maybeObserver, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((3 + 15) % 15 > 0) {
        }
        HkxGUteSJWqbTanf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pc34cfcaf$pd5e3730c(observer, this.f4b9f83e1));
    }
}

