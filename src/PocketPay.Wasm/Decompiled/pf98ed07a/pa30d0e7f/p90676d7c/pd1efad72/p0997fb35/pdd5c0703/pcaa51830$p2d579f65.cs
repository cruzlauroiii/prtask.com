namespace WillowMaze.Wasm.Decompiled;


readonly class pcaa51830$p2d579f65<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f2e1fcc97 = -8583764624474935784L;
    private static readonly long f658a4980 = -8583764624474935784L;
    private static readonly long fc6e1e520 = -8583764624474935784L;
    readonly io.reactivex.rxjava3.core.SingleObserver f048e72d5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f61c38fc3;
    readonly io.reactivex.rxjava3.core.SingleObserver f62b76bd1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver fcc8e5817;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd08fe80a;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd8e6a8d9;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff8e414b1;
    readonly io.reactivex.rxjava3.core.SingleObserver ffb5d1c1b;

    pcaa51830$p2d579f65(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.fd22a0a80 = singleObserver;
        OhiHJqjzeIfDpZZa(this, p004bf6c9Var);
    }

    public static void HeKPYsXVUqqNgkXL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void OhiHJqjzeIfDpZZa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pcaa51830$p2d579f65 pcaa51830_p2d579f65, java.lang.object obj) {
        pcaa51830_p2d579f65.lazyHashSet(obj);
    }

    public static void SestHolHPyuftCpA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static bool VnfhIPHmEPhAjgVO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ARianOVzTGcHbzbI(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool ArfSOphmIySXoEgx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void BVRjuRLqXjGquKhr(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void JWNnEyDSxQnjTucD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void NDkXMbllehpTxCBR(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.object VpLGKwrKcNwhWYMJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pcaa51830$p2d579f65 pcaa51830_p2d579f65, java.lang.object obj) {
        return pcaa51830_p2d579f65.getAndHashSet(obj);
    }

    public static void WGakunbxODHhJNjW(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9) vpLGKwrKcNwhWYMJ(this, null);
        if (p004bf6c9Var is null) {
            return;
        }
        try {
            SestHolHPyuftCpA(p004bf6c9Var);
        } catch (java.lang.Exception th) {
            HeKPYsXVUqqNgkXL(th);
            jWNnEyDSxQnjTucD(th);
        }
        aRianOVzTGcHbzbI(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return arfSOphmIySXoEgx(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        nDkXMbllehpTxCBR(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (VnfhIPHmEPhAjgVO(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            bVRjuRLqXjGquKhr(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        wGakunbxODHhJNjW(this.fd22a0a80, t);
    }
}

