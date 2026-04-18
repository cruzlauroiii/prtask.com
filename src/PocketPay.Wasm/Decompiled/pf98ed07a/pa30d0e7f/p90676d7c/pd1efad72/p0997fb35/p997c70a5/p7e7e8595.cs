namespace WillowMaze.Wasm.Decompiled;


public readonly class p7e7e8595<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f0d4e4723;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4634c3e3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4ebe2be0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5400cc65;
    readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f99b0e8da;

    public p7e7e8595(io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> supplier) {
        this.f99b0e8da = supplier;
    }

    public static java.lang.object FxlHDAfJYqXvlJtb(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object KfgpbbVofACuLqrq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void YlNwyVRkRwkuPbIK(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void TPeVMyWCIrXrnUBn(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void XxHbmJYTYqQIfeLx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        try {
            YlNwyVRkRwkuPbIK((io.reactivex.rxjava3.core.ObservableSource) FxlHDAfJYqXvlJtb(KfgpbbVofACuLqrq(this.f99b0e8da), "The supplier returned a null ObservableSource"), observer);
        } catch (java.lang.Exception th) {
            xxHbmJYTYqQIfeLx(th);
            tPeVMyWCIrXrnUBn(th, observer);
        }
    }
}

