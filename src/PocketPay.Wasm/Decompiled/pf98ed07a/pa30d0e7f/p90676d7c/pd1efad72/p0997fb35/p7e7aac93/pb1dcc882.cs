namespace WillowMaze.Wasm.Decompiled;


public readonly class pb1dcc882<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly java.lang.Exception f57fd4d91;
    readonly java.lang.Exception f6f23bbc8;
    readonly java.lang.Exception fbfd5a804;
    readonly java.lang.Exception fcb5e100e;

    public pb1dcc882(java.lang.Exception th) {
        this.fcb5e100e = th;
    }

    public static void BwCpEVFvehWfWEzm(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ZlUBhIflnimygmjt() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mf8b2648d();
    }

    public static void AghMQWYwCAqPlNDL(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        aghMQWYwCAqPlNDL(maybeObserver, ZlUBhIflnimygmjt());
        BwCpEVFvehWfWEzm(maybeObserver, this.fcb5e100e);
    }
}

