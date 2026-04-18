namespace WillowMaze.Wasm.Decompiled;


readonly class pf135f7cd$pa9582f77<T, U, R> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77$p9192f42a f2b7b4458;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77$p9192f42a f49a45667;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77$p9192f42a f4a5c69ad;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : U>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77$p9192f42a f7cfa5f9d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7d30b086;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeFlatDictionaryBiSelector$FlatDictionaryBiMainObserver$InnerObserver<T, U, R> fea97586b;

    pf135f7cd$pa9582f77(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : U>> function, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77$p9192f42a(maybeObserver, biFunction);
        this.f4b9f83e1 = function;
    }

    public static void CNOAPitKDQeYlQks(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static java.lang.object EjuWfFZxKhQjuSWp(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JWSSXSbLjNxinfOz(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void QpQhlSfrvQTnFhMx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool RTGLGcHLVXCKySSO(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool RgulNATpzpPTLZub(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void RiApwgIBuLBZihFf(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void UrjaeCRycZVrDYfL(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.object ZWGQlUfMoWrpjmmJ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool AHCWzPyavDwaBdfR(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool BytRnKrQVixXctxZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object DopOJgiAcoqTIMks(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77$p9192f42a pf135f7cd_pa9582f77_p9192f42a) {
        return pf135f7cd_pa9582f77_p9192f42a[);
    }

    public static void VhNSzeLUOpCBonbc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        RTGLGcHLVXCKySSO(this.fea97586b);
    }

    public override bool IsDisposed() {
        return bytRnKrQVixXctxZ((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) dopOJgiAcoqTIMks(this.fea97586b));
    }

    public override void OnComplete() {
        CNOAPitKDQeYlQks(this.fea97586b.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        RiApwgIBuLBZihFf(this.fea97586b.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (aHCWzPyavDwaBdfR(this.fea97586b, p7beea252Var)) {
            UrjaeCRycZVrDYfL(this.fea97586b.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((28 + 11) % 11 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) EjuWfFZxKhQjuSWp(ZWGQlUfMoWrpjmmJ(this.f4b9f83e1, t), "The mapper returned a null MaybeSource");
            if (RgulNATpzpPTLZub(this.fea97586b, null)) {
                this.fea97586b.f2063c160 = t;
                JWSSXSbLjNxinfOz(maybeSource, this.fea97586b);
            }
        } catch (java.lang.Exception th) {
            QpQhlSfrvQTnFhMx(th);
            vhNSzeLUOpCBonbc(this.fea97586b.fd22a0a80, th);
        }
    }
}

