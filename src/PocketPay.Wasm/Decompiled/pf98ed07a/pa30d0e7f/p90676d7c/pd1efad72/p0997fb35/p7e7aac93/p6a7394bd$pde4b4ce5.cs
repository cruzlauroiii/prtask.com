namespace WillowMaze.Wasm.Decompiled;


readonly class p6a7394bd$pde4b4ce5<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f003d71ac;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f227ec9a6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa60fe9bc;
    readonly io.reactivex.rxjava3.core.MaybeObserver fb8d5caa5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<java.lang.bool> fd22a0a80;

    p6a7394bd$pde4b4ce5(io.reactivex.rxjava3.core.MaybeObserver<java.lang.bool> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void FFVBpOuXQslUNTZt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NUaAhcisrcHhHZZB(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool TouSvAUgUCVvxtHY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static java.lang.bool FNWVQcsyoszREsoi(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool GFFeuKtJxOLaJGOw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.bool IlWSMOrPNzYtampn(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void MaPJofmhVIcmvdFt(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void RoMXHpYwHVpnzutj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void TOfLcwzLzbPabFhL(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        FFVBpOuXQslUNTZt(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return TouSvAUgUCVvxtHY(this.fbc3b0556);
    }

    public override void OnComplete() {
        NUaAhcisrcHhHZZB(this.fd22a0a80, fNWVQcsyoszREsoi(true));
    }

    public override void OnError(java.lang.Exception th) {
        maPJofmhVIcmvdFt(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (gFFeuKtJxOLaJGOw(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            tOfLcwzLzbPabFhL(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        roMXHpYwHVpnzutj(this.fd22a0a80, ilWSMOrPNzYtampn(false));
    }
}

