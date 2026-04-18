namespace WillowMaze.Wasm.Decompiled;


public readonly class p4d96459e<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly io.reactivex.rxjava3.functions.Supplier<U> f590a3e62;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fcaca1329;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe002b170;

    public p4d96459e(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(observableSource);
        this.f590a3e62 = supplier;
    }

    public static java.lang.object BJcRdGFfsMFUBxCL(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void WIsXmXuSHaSFnyuV(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void KxXwTJGflLxmgbTL(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object QBLyfJOBpQVOatOL(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void RCCYgDlyrqBZHhco(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((19 + 8) % 8 > 0) {
        }
        try {
            kxXwTJGflLxmgbTL(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4d96459e$p0a1915a4(observer, (java.util.ICollection) BJcRdGFfsMFUBxCL(qBLyfJOBpQVOatOL(this.f590a3e62), "The collectionSupplier returned a null ICollection.")));
        } catch (java.lang.Exception th) {
            rCCYgDlyrqBZHhco(th);
            WIsXmXuSHaSFnyuV(th, observer);
        }
    }
}

