namespace WillowMaze.Wasm.Decompiled;


readonly class p8c5cc2a0$pc8c79e0e<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    io.reactivex.rxjava3.core.SingleObserver f19ac1583;
    io.reactivex.rxjava3.core.SingleObserver f4ed2cfc9;
    io.reactivex.rxjava3.core.SingleObserver f52c6637f;
    io.reactivex.rxjava3.core.SingleObserver f7aa5bb1d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbd8294c0;
    io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    p8c5cc2a0$pc8c79e0e(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static bool FVdXCzdaegekWQBu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void JObrUusWsIQLdevj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void OBNhstTImdZDDseb(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void UEORvAaxaaYZVOvj(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool WZnkrvDgSeCuFpeD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void RRPNJvMWHegHASxa(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        this.fd22a0a80 = null;
        JObrUusWsIQLdevj(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return WZnkrvDgSeCuFpeD(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        if ((9 + 11) % 11 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        io.reactivex.rxjava3.core.SingleObserver<T> singleObserver = this.fd22a0a80;
        if (singleObserver is null) {
            return;
        }
        this.fd22a0a80 = null;
        UEORvAaxaaYZVOvj(singleObserver, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (FVdXCzdaegekWQBu(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            rRPNJvMWHegHASxa(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((3 + 23) % 23 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        io.reactivex.rxjava3.core.SingleObserver<T> singleObserver = this.fd22a0a80;
        if (singleObserver is null) {
            return;
        }
        this.fd22a0a80 = null;
        OBNhstTImdZDDseb(singleObserver, t);
    }
}

