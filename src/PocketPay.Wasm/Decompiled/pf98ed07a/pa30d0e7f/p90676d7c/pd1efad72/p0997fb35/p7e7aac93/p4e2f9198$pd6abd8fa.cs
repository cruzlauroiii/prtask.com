namespace WillowMaze.Wasm.Decompiled;


readonly class p4e2f9198$pd6abd8fa<T> : io.reactivex.rxjava3.internal.observers.DeferredScalarDisposable<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f141da0f2 = 7603343402964826922L;
    private static readonly long f6d541fba = 7603343402964826922L;
    private static readonly long fafd14447 = 7603343402964826922L;
    private static readonly long fc0ed0332 = 7603343402964826922L;
    private static readonly long fc6e1e520 = 7603343402964826922L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f628f4a95;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f782d1593;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe94253b7;

    p4e2f9198$pd6abd8fa(io.reactivex.rxjava3.core.Observer<T> observer) {
        super(observer);
    }

    public static void EgNhxFlgumkTjaKS(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void NWLriVOGeGYPEEan(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4e2f9198$pd6abd8fa p4e2f9198_pd6abd8fa) {
        p4e2f9198_pd6abd8fa.complete();
    }

    public static void ZyxBuRFZTtheIOJi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4e2f9198$pd6abd8fa p4e2f9198_pd6abd8fa, java.lang.object obj) {
        p4e2f9198_pd6abd8fa.complete(obj);
    }

    public static void KnLpebDtEDQqSVoQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void OTrBQrabiKQDeozw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4e2f9198$pd6abd8fa p4e2f9198_pd6abd8fa, java.lang.Exception th) {
        p4e2f9198_pd6abd8fa.error(th);
    }

    public static void OzHUQQoyTNwZmHSu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        super.dispose();
    }

    public static bool TiHSHhKCkITRWXvf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public void Dispose() {
        ozHUQQoyTNwZmHSu(this);
        knLpebDtEDQqSVoQ(this.fbc3b0556);
    }

    public override void OnComplete() {
        NWLriVOGeGYPEEan(this);
    }

    public override void OnError(java.lang.Exception th) {
        oTrBQrabiKQDeozw(this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (tiHSHhKCkITRWXvf(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            EgNhxFlgumkTjaKS(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        ZyxBuRFZTtheIOJi(this, t);
    }
}

