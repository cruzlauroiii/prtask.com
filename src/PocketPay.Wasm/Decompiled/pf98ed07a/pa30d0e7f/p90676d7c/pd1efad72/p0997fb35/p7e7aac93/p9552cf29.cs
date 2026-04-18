namespace WillowMaze.Wasm.Decompiled;


public readonly class p9552cf29<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.operators.ScalarSupplier<T> {
    readonly T f2063c160;
    readonly java.lang.object fcd48e076;

    public p9552cf29(T t) {
        this.f2063c160 = t;
    }

    public static void HtFKaVCcubduuUSv(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 JOJPbUYNKsXOiEVW() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mf8b2648d();
    }

    public static void HwNItqldMurukcFu(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public T Get() {
        return this.f2063c160;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        HtFKaVCcubduuUSv(maybeObserver, JOJPbUYNKsXOiEVW());
        hwNItqldMurukcFu(maybeObserver, this.f2063c160);
    }
}

