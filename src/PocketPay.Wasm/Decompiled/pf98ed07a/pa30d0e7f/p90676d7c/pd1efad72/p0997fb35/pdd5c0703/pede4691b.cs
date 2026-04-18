namespace WillowMaze.Wasm.Decompiled;


public readonly class pede4691b<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f2d9d4a50;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f486d761e;
    readonly io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> f6906652a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff92857dd;

    public pede4691b(io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> supplier) {
        this.f6906652a = supplier;
    }

    public static void MjKGbQyKbKSzzbAp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BUnBGapxHQlHEqdL(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static java.lang.object FeyIXTrKWZyVinyl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object RgmhqckfgLxiYVHG(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        try {
            th = (java.lang.Exception) rgmhqckfgLxiYVHG(feyIXTrKWZyVinyl(this.f6906652a), "Supplier returned a null Exception.");
        } catch (java.lang.Exception th) {
            th = th;
            MjKGbQyKbKSzzbAp(th);
        }
        bUnBGapxHQlHEqdL(th, singleObserver);
    }
}

