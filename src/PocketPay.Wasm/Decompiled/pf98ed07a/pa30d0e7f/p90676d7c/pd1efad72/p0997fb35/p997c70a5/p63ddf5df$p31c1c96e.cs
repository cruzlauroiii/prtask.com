namespace WillowMaze.Wasm.Decompiled;


readonly class p63ddf5df$p31c1c96e<T> : java.util.ArrayQueue<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f53415ae6 = 7240042530241604978L;
    private static readonly long fc6e1e520 = 7240042530241604978L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f0b984e44;
    volatile bool f38881e0a;
    volatile bool f3d68da18;
    volatile bool f6c88560c;
    volatile bool f93b08bfd;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fbc422ec1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc5824d06;
    readonly io.reactivex.rxjava3.core.Observer fcb60aa61;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly int fe2942a04;
    readonly int ffdc77e0e;

    p63ddf5df$p31c1c96e(io.reactivex.rxjava3.core.Observer<T> observer, int i) {
        this.fd22a0a80 = observer;
        this.fe2942a04 = i;
    }

    public static void DmpzKfptcnsjXRSr(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object GGDycVWKirCHiMVb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p63ddf5df$p31c1c96e p63ddf5df_p31c1c96e) {
        return p63ddf5df_p31c1c96e.poll();
    }

    public static void NhNnkJTShrvwGQRy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void WgcQKVUKkZXekiZO(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static int BpujEpqenBcGtpcs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p63ddf5df$p31c1c96e p63ddf5df_p31c1c96e) {
        return p63ddf5df_p31c1c96e.Count;
    }

    public static bool DFDMWubTjMjqTMhj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LwOSIcWxPTfCMRkD(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void VmhNKtyZBtAvCbRD(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object ZKrCTyrUqNULFcwk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p63ddf5df$p31c1c96e p63ddf5df_p31c1c96e) {
        return p63ddf5df_p31c1c96e.poll();
    }

    public static bool ZwELsRJFKmfHESWa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p63ddf5df$p31c1c96e p63ddf5df_p31c1c96e, java.lang.object obj) {
        return p63ddf5df_p31c1c96e.offer(obj);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        NhNnkJTShrvwGQRy(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        if ((16 + 3) % 3 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
        while (!this.f38881e0a) {
            java.lang.object objZKrCTyrUqNULFcwk = zKrCTyrUqNULFcwk(this);
            if (objZKrCTyrUqNULFcwk is null) {
                vmhNKtyZBtAvCbRD(observer);
                return;
            }
            WgcQKVUKkZXekiZO(observer, objZKrCTyrUqNULFcwk);
        }
    }

    public override void OnError(java.lang.Exception th) {
        DmpzKfptcnsjXRSr(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((12 + 27) % 27 > 0) {
        }
        if (this.fe2942a04 == bpujEpqenBcGtpcs(this)) {
            GGDycVWKirCHiMVb(this);
        }
        zwELsRJFKmfHESWa(this, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (dFDMWubTjMjqTMhj(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            lwOSIcWxPTfCMRkD(this.fd22a0a80, this);
        }
    }
}

