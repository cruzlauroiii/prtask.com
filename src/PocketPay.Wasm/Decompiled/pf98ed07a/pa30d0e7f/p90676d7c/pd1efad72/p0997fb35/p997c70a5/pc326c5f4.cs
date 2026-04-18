namespace WillowMaze.Wasm.Decompiled;


public readonly class pc326c5f4<T, K> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0944777f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f174ab7ba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4f86f171;
    readonly io.reactivex.rxjava3.functions.Supplier<? : java.util.ICollection<K>> f590a3e62;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fada69f09;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc1595114;

    public pc326c5f4(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.Supplier<? : java.util.ICollection<K>> supplier) {
        super(observableSource);
        this.f866d6d67 = function;
        this.f590a3e62 = supplier;
    }

    public static void DHMLABiFbgDuMRjJ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void EWMINtPIlVuOkiFk(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object HewbkTqNckvcwwiP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object RbPuvjJDuoQcFrLW(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void SllQpWoWHmlEwvdM(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((13 + 30) % 30 > 0) {
        }
        try {
            sllQpWoWHmlEwvdM(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc326c5f4$p732f6524(observer, this.f866d6d67, (java.util.ICollection) RbPuvjJDuoQcFrLW(HewbkTqNckvcwwiP(this.f590a3e62), "The collectionSupplier returned a null ICollection.")));
        } catch (java.lang.Exception th) {
            DHMLABiFbgDuMRjJ(th);
            EWMINtPIlVuOkiFk(th, observer);
        }
    }
}

