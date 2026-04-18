namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p9083e00e<T> : io.reactivex.rxjava3.functions.Consumer<java.lang.Exception> {
    readonly io.reactivex.rxjava3.core.Observer f7296f883;
    readonly io.reactivex.rxjava3.core.Observer<T> fdfda0d32;

    p9a814744$p9083e00e(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fdfda0d32 = observer;
    }

    public static void MwEzqXdNpbErVeOy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p9083e00e p9a814744_p9083e00e, java.lang.Exception th) {
        p9a814744_p9083e00e.accept(th);
    }

    public static void OLkDdxgFQFLpJNXs(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public void Accept(java.lang.object obj) throws java.lang.Exception {
        mwEzqXdNpbErVeOy(this, (java.lang.Exception) obj);
    }

    public void Accept(java.lang.Exception th) {
        oLkDdxgFQFLpJNXs(this.fdfda0d32, th);
    }
}

