namespace WillowMaze.Wasm.Decompiled;


public readonly class pb0908338<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly T f2063c160;
    readonly java.lang.object f8bf87586;
    readonly java.lang.object fd169773b;

    public pb0908338(T t) {
        this.f2063c160 = t;
    }

    public static void HRWKuZgjhFVMGAWn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void JpNbjhlmNGqGZhfb(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 RDktyAQbXIUaPutm() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mf8b2648d();
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        JpNbjhlmNGqGZhfb(singleObserver, rDktyAQbXIUaPutm());
        HRWKuZgjhFVMGAWn(singleObserver, this.f2063c160);
    }
}

