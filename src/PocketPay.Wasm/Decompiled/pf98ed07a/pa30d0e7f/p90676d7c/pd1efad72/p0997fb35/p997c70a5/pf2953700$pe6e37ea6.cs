namespace WillowMaze.Wasm.Decompiled;


readonly class pf2953700$pe6e37ea6<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly long f123b4140;
    readonly T f16830a58;
    readonly long f2edb2962;
    readonly io.reactivex.rxjava3.core.SingleObserver f39613fba;
    readonly java.lang.object f5007c876;
    readonly io.reactivex.rxjava3.core.SingleObserver f51acd0aa;
    bool f5adbf449;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f656b337f;
    readonly java.lang.object f66a8109f;
    readonly io.reactivex.rxjava3.core.SingleObserver f6976df39;
    readonly long f6a992d55;
    bool f6b2ded51;
    readonly java.lang.object f81dc818b;
    readonly io.reactivex.rxjava3.core.SingleObserver f9505b5e7;
    long f98f613f4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa534bb1b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    long fbc9ed188;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fcb982d19;
    long fd030923c;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    long fe2942a04;
    long febf77325;
    bool feec03f11;
    readonly long ff1409236;
    bool ff9d7c9a7;

    pf2953700$pe6e37ea6(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, long j, T t) {
        this.fd22a0a80 = singleObserver;
        this.f6a992d55 = j;
        this.f16830a58 = t;
    }

    public static void BiIselpEfpLFVnZf(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void DWNaegpRrYHWuoxw(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void EiHtKihkFbwAzjXF(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void GwBqWVDcmqWiQcik(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void OXyjuneqrZmKJwsC(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void BONQzBcaRgkFfJQg(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool CPLwYXXNVjFCOXxL(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void DLDJZxoSHwODTirZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool IAZOyjmQclbbzuMw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ZhZStKnRRjtovcMZ(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        dLDJZxoSHwODTirZ(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return cPLwYXXNVjFCOXxL(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f16830a58;
        if (t is null) {
            bONQzBcaRgkFfJQg(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            zhZStKnRRjtovcMZ(this.fd22a0a80, t);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            OXyjuneqrZmKJwsC(th);
        } else {
            this.f6b2ded51 = true;
            BiIselpEfpLFVnZf(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((3 + 28) % 28 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.fe2942a04;
        if (j != this.f6a992d55) {
            this.fe2942a04 = j + 1;
            return;
        }
        this.f6b2ded51 = true;
        GwBqWVDcmqWiQcik(this.fbc3b0556);
        EiHtKihkFbwAzjXF(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (iAZOyjmQclbbzuMw(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            DWNaegpRrYHWuoxw(this.fd22a0a80, this);
        }
    }
}

