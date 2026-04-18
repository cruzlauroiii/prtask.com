namespace WillowMaze.Wasm.Decompiled;


public readonly class pa71e3a70<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f437bd282;
    readonly io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> f6906652a;

    public pa71e3a70(io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> supplier) {
        this.f6906652a = supplier;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SELvXAAKbGevxHoQ() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mf8b2648d();
    }

    public static java.lang.object WDKYymypIUgIByHn(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void ZjoFhnmRITtLvLRJ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object CbpNhOrmQvoXsFae(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void DjepgrOIVbUUequY(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void PHPpeClOhbuAHYkF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        djepgrOIVbUUequY(maybeObserver, SELvXAAKbGevxHoQ());
        try {
            th = (java.lang.Exception) WDKYymypIUgIByHn(cbpNhOrmQvoXsFae(this.f6906652a), "Supplier returned a null Exception.");
        } catch (java.lang.Exception th) {
            th = th;
            pHPpeClOhbuAHYkF(th);
        }
        ZjoFhnmRITtLvLRJ(maybeObserver, th);
    }
}

