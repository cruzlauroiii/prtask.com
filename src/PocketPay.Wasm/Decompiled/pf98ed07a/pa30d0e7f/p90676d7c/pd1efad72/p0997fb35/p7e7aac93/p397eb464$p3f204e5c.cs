namespace WillowMaze.Wasm.Decompiled;


readonly class p397eb464$p3f204e5c : io.reactivex.rxjava3.core.MaybeObserver<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.lang.object f2063c160;
    readonly io.reactivex.rxjava3.core.SingleObserver f507e04d1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f61c077d0;
    readonly io.reactivex.rxjava3.core.SingleObserver f6f9da3b9;
    readonly java.lang.object f80bfc421;
    readonly io.reactivex.rxjava3.core.SingleObserver f9178695d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver ff4d18dc1;

    p397eb464$p3f204e5c(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver, java.lang.object obj) {
        this.fd22a0a80 = singleObserver;
        this.f2063c160 = obj;
    }

    public static java.lang.bool BobXLuAlqcwMlSIl(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool FYZslBTlydgIiqRY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool JPHYINbqKxSSswxh(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void KsYFOxcciHyEVcbc(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void LFjpRuYJsktnqTLR(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void MDwevXGWmRNMdOnr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void YfDpIKfxFZNYAREe(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool OuEfbUfALbbzwNma(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static void VEwmBNZMXWliVJyw(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool WvEmOfRyddKNHashSetj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        MDwevXGWmRNMdOnr(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return wvEmOfRyddKNHashSetj(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        vEwmBNZMXWliVJyw(this.fd22a0a80, BobXLuAlqcwMlSIl(false));
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        KsYFOxcciHyEVcbc(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (JPHYINbqKxSSswxh(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            LFjpRuYJsktnqTLR(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(java.lang.object obj) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        YfDpIKfxFZNYAREe(this.fd22a0a80, FYZslBTlydgIiqRY(ouEfbUfALbbzwNma(obj, this.f2063c160)));
    }
}

