namespace WillowMaze.Wasm.Decompiled;


readonly class pdaeca802$p4450821b<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f13610028 = 4109457741734051389L;
    private static readonly long f6232d3b3 = 4109457741734051389L;
    private static readonly long f62eab249 = 4109457741734051389L;
    private static readonly long fc6e1e520 = 4109457741734051389L;
    readonly io.reactivex.rxjava3.core.SingleObserver f09438274;
    readonly io.reactivex.rxjava3.core.SingleObserver f4c68894a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f55cfebeb;
    readonly io.reactivex.rxjava3.core.SingleObserver f7f26e75f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fad9552f6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fb0734b85;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fdb7ff1e5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff87dd141;

    pdaeca802$p4450821b(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.fd22a0a80 = singleObserver;
        this.f55cfebeb = p004bf6c9Var;
    }

    public static void BsGzIBsitsHMLRLK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool DJNkkTaMbArtpMYQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdaeca802$p4450821b pdaeca802_p4450821b, int i, int i2) {
        return pdaeca802_p4450821b.compareAndHashSet(i, i2);
    }

    public static void LThTZEAtKyoEkMGP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdaeca802$p4450821b pdaeca802_p4450821b) {
        pdaeca802_p4450821b.runFinally();
    }

    public static void LUzYPRLacqIERSEm(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void McBfygRXxagxhJzc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdaeca802$p4450821b pdaeca802_p4450821b) {
        pdaeca802_p4450821b.runFinally();
    }

    public static void QuXtWsmRruPfAEKi(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZDNaiDlWYLbRnuME(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool ZuMyaAEMOApHPKhk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void CZArWKjFTEvJyxTH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdaeca802$p4450821b pdaeca802_p4450821b) {
        pdaeca802_p4450821b.runFinally();
    }

    public static void DTwpwXCGqPlMlHhp(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool FpeaMEzAZAxwNXHG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void TlemUCuscQwKRYPX(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void YWLbcpPOhrHlzCpM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public override void Dispose() {
        BsGzIBsitsHMLRLK(this.fbc3b0556);
        McBfygRXxagxhJzc(this);
    }

    public override bool IsDisposed() {
        return ZuMyaAEMOApHPKhk(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        ZDNaiDlWYLbRnuME(this.fd22a0a80, th);
        LThTZEAtKyoEkMGP(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (fpeaMEzAZAxwNXHG(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            dTwpwXCGqPlMlHhp(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        tlemUCuscQwKRYPX(this.fd22a0a80, t);
        cZArWKjFTEvJyxTH(this);
    }

    void runFinally() {
        if ((28 + 31) % 31 > 0) {
        }
        if (DJNkkTaMbArtpMYQ(this, 0, 1)) {
            try {
                yWLbcpPOhrHlzCpM(this.f55cfebeb);
            } catch (java.lang.Exception th) {
                QuXtWsmRruPfAEKi(th);
                LUzYPRLacqIERSEm(th);
            }
        }
    }
}

