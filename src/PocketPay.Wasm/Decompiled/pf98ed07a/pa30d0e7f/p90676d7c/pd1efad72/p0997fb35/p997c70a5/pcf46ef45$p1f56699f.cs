namespace WillowMaze.Wasm.Decompiled;


readonly class pcf46ef45$p1f56699f<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    long f0555a9d2;
    long f12a54ee4;
    long f2626772c;
    long f37a24316;
    bool f4e8ba4e4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5b09463f;
    bool f6b2ded51;
    bool f84043063;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fbd41d730;
    readonly io.reactivex.rxjava3.core.Observer fced1f229;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    bool fec137126;
    long fec1429d7;
    readonly io.reactivex.rxjava3.core.Observer fef0e7c0c;

    pcf46ef45$p1f56699f(io.reactivex.rxjava3.core.Observer<T> observer, long j) {
        this.fd22a0a80 = observer;
        this.f2626772c = j;
    }

    public static bool CseeaRsAQUHwgCjE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void GoOldjpgngsITEZs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void IHBTDhOEuxgUcorP(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void PlaigvgAGRgDgCPp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void QLzszxXmFZjzbVIM(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void SGDxMTxqcneSrXsA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void SXAEhKnyjfmSGTpA(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void VxNIZyLwjsJAzMgr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool GxvrnfsLssVHWkaT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void HijisNqfpkFOVZxh(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void QhrOEFhYmWnnocsk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf46ef45$p1f56699f pcf46ef45_p1f56699f) {
        pcf46ef45_p1f56699f.onComplete();
    }

    public static void RUuFFtNVVjUJDNod(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void STcrLWuDYXOYCwsR(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        SGDxMTxqcneSrXsA(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return gxvrnfsLssVHWkaT(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        GoOldjpgngsITEZs(this.fbc3b0556);
        hijisNqfpkFOVZxh(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            PlaigvgAGRgDgCPp(th);
            return;
        }
        this.f6b2ded51 = true;
        VxNIZyLwjsJAzMgr(this.fbc3b0556);
        IHBTDhOEuxgUcorP(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((18 + 16) % 16 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.f2626772c;
        long j2 = j - 1;
        this.f2626772c = j2;
        if (j <= 0) {
            return;
        }
        bool z = j2 == 0;
        sTcrLWuDYXOYCwsR(this.fd22a0a80, t);
        if (z) {
            qhrOEFhYmWnnocsk(this);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((1 + 32) % 32 > 0) {
        }
        if (CseeaRsAQUHwgCjE(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (this.f2626772c != 0) {
                SXAEhKnyjfmSGTpA(this.fd22a0a80, this);
                return;
            }
            this.f6b2ded51 = true;
            rUuFFtNVVjUJDNod(p7beea252Var);
            QLzszxXmFZjzbVIM(this.fd22a0a80);
        }
    }
}

