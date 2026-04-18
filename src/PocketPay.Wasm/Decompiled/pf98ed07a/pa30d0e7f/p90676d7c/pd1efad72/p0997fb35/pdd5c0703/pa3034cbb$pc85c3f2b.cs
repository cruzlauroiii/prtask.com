namespace WillowMaze.Wasm.Decompiled;


readonly class pa3034cbb$pc85c3f2b<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f000435d7;
    readonly io.reactivex.rxjava3.core.SingleObserver fbb503da2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fd5269e5a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fe52e7ffe;

    pa3034cbb$pc85c3f2b(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.fd22a0a80 = singleObserver;
        this.fd5269e5a = p004bf6c9Var;
    }

    public static bool IFXhelYcBsXYzHdc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool OwUSeiABDUCwJqPY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void PFqFwBOyPKTcRwhN(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void RPuvdDrDQATRKvRN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pa3034cbb$pc85c3f2b pa3034cbb_pc85c3f2b) {
        pa3034cbb_pc85c3f2b.md5269e5a();
    }

    public static void SrxSTyNFwZXMZjTT(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void ThTpgGbgszYuqJBM(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void BuozktTcEEwRiQEe(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BwDBdhKyGpWOxJOz(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void EZfjcnDDCuFqrhSf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pa3034cbb$pc85c3f2b pa3034cbb_pc85c3f2b) {
        pa3034cbb_pc85c3f2b.md5269e5a();
    }

    private void Md5269e5a() {
        try {
            SrxSTyNFwZXMZjTT(this.fd5269e5a);
        } catch (java.lang.Exception th) {
            buozktTcEEwRiQEe(th);
            pLewRpvGgkKdYcpQ(th);
        }
    }

    public static void MiCcHnDyjVKSIELT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void PLewRpvGgkKdYcpQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public override void Dispose() {
        miCcHnDyjVKSIELT(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return OwUSeiABDUCwJqPY(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        bwDBdhKyGpWOxJOz(this.fd22a0a80, th);
        eZfjcnDDCuFqrhSf(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (IFXhelYcBsXYzHdc(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            PFqFwBOyPKTcRwhN(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        ThTpgGbgszYuqJBM(this.fd22a0a80, t);
        RPuvdDrDQATRKvRN(this);
    }
}

