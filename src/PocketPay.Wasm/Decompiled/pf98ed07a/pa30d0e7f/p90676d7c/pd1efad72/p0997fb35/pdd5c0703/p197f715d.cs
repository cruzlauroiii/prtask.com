namespace WillowMaze.Wasm.Decompiled;


public readonly class p197f715d<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.SingleSource<? : T>> f0b06ab1b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f36302666;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ffb0e11c0;

    public p197f715d(io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.SingleSource<? : T>> supplier) {
        this.f0b06ab1b = supplier;
    }

    public static void CkWZMSlLurNVZgag(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void GqhgksurbeYUPkyJ(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void KYkrCnlSySAaBbrM(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object WtQFmnSSFkkcEovE(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object YtZldxgmlbOSbCNc(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        try {
            GqhgksurbeYUPkyJ((io.reactivex.rxjava3.core.SingleSource) ytZldxgmlbOSbCNc(wtQFmnSSFkkcEovE(this.f0b06ab1b), "The singleSupplier returned a null SingleSource"), singleObserver);
        } catch (java.lang.Exception th) {
            KYkrCnlSySAaBbrM(th);
            CkWZMSlLurNVZgag(th, singleObserver);
        }
    }
}

