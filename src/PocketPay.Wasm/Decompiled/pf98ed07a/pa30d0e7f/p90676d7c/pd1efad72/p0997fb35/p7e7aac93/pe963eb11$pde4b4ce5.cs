namespace WillowMaze.Wasm.Decompiled;


readonly class pe963eb11$pde4b4ce5<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f11655686;
    readonly io.reactivex.rxjava3.core.SingleObserver f36f8395a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f77e86a58;
    readonly io.reactivex.rxjava3.core.SingleObserver fbaba914a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fe4ecdaff;

    pe963eb11$pde4b4ce5(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static java.lang.bool FEQuiwiAuUBrPyOx(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool GFPtYbFbZJCcLnJL(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void GMtNXyDVanAuKdWT(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void JZBMsUZkloRTLzqe(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void KrkAmvUKYBctgAqR(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool BHCeBQDFBoMEterX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void IkzSRhzdzPIPxZzt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.bool UZShVBEonSHgasHH(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void XCGZnixFTDWGNnco(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        ikzSRhzdzPIPxZzt(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return GFPtYbFbZJCcLnJL(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        JZBMsUZkloRTLzqe(this.fd22a0a80, uZShVBEonSHgasHH(true));
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        KrkAmvUKYBctgAqR(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (bHCeBQDFBoMEterX(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            xCGZnixFTDWGNnco(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        GMtNXyDVanAuKdWT(this.fd22a0a80, FEQuiwiAuUBrPyOx(false));
    }
}

