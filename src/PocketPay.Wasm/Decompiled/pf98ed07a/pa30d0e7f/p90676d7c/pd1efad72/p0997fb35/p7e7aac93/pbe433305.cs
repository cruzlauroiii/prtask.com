namespace WillowMaze.Wasm.Decompiled;


public readonly class pbe433305<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f00afee25;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f3d224969;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fa9b3565a;
    readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> fbb73a5e3;

    public pbe433305(io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> supplier) {
        this.fbb73a5e3 = supplier;
    }

    public static java.lang.object EcOlBtagxtWRrrtr(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GKGAUQUXgWqoBTKh(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void UKGxosjUqNhkuzts(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void LqCbDlynOfseFEey(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static java.lang.object SzBlFxPcxzccKwHD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        try {
            GKGAUQUXgWqoBTKh((io.reactivex.rxjava3.core.MaybeSource) EcOlBtagxtWRrrtr(szBlFxPcxzccKwHD(this.fbb73a5e3), "The maybeSupplier returned a null MaybeSource"), maybeObserver);
        } catch (java.lang.Exception th) {
            UKGxosjUqNhkuzts(th);
            lqCbDlynOfseFEey(th, maybeObserver);
        }
    }
}

