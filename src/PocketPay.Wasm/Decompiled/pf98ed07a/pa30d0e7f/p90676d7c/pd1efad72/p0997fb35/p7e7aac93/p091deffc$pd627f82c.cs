namespace WillowMaze.Wasm.Decompiled;


readonly class p091deffc$pd627f82c<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fae736921 = 2026620218879969836L;
    private static readonly long fc6e1e520 = 2026620218879969836L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f2a95e707;
    readonly io.reactivex.rxjava3.core.MaybeObserver f613b85ee;
    readonly io.reactivex.rxjava3.core.MaybeObserver f7933dbf4;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.MaybeSource<? : T>> fba0b826a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc2f62d9b;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd1d99f09;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p091deffc$pd627f82c(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.MaybeSource<? : T>> function) {
        this.fd22a0a80 = maybeObserver;
        this.fba0b826a = function;
    }

    public static void CjHrDtwFUKUcVPWn(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void JyCPgfECfjLWzIAn(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static java.lang.object MhFkQEPDjRgBCvpW(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void NGVuKCNKPVrLeKXn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RHjBdoopcTHtpMmV(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void RwdGQIaNBWiOeKvH(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.object TtrZdwmRCbQTtsXu(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool VjEdIINrnHiMfUwg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool XFAwLZkxVmCNGTts(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool JjDOkijcBdGiGNLJ(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object VAnpgVQUGDnDsZZd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p091deffc$pd627f82c p091deffc_pd627f82c) {
        return p091deffc_pd627f82c[);
    }

    public static bool VKYQYBVngDeJqchS(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void ZKCJfnGXXwywWzka(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public override void Dispose() {
        jjDOkijcBdGiGNLJ(this);
    }

    public override bool IsDisposed() {
        return XFAwLZkxVmCNGTts((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) vAnpgVQUGDnDsZZd(this));
    }

    public override void OnComplete() {
        JyCPgfECfjLWzIAn(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((31 + 20) % 20 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) TtrZdwmRCbQTtsXu(MhFkQEPDjRgBCvpW(this.fba0b826a, th), "The resumeFunction returned a null MaybeSource");
            vKYQYBVngDeJqchS(this, null);
            RHjBdoopcTHtpMmV(maybeSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p091deffc$pd627f82c$p6ad1eaba(this.fd22a0a80, this));
        } catch (java.lang.Exception th2) {
            NGVuKCNKPVrLeKXn(th2);
            io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            CjHrDtwFUKUcVPWn(maybeObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (VjEdIINrnHiMfUwg(this, p7beea252Var)) {
            RwdGQIaNBWiOeKvH(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        zKCJfnGXXwywWzka(this.fd22a0a80, t);
    }
}

