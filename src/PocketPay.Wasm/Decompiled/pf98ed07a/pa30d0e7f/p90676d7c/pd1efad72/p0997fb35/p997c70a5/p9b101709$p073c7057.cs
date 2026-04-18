namespace WillowMaze.Wasm.Decompiled;


readonly class p9b101709$p073c7057<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.lang.object f1f0da883;
    T f2063c160;
    bool f51f64488;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f56d1eef4;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.MaybeObserver f7139626c;
    bool f8c235b2b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fab470b44;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fadca610a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fc4b699bf;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdde7d07b;
    bool fe1bf92e6;
    readonly io.reactivex.rxjava3.core.MaybeObserver fecdc2972;

    p9b101709$p073c7057(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void JSjoNtKYIMcbKxBw(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void JtAKpsCYjNHGYQwB(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void RFPkAKTbFLyzdHpQ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void RjAcYNQaQeLqxIxP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void TFyjgpmtuMWrmWJS(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void WPyALyIfhXdUVCgp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool AeHznxDDbrBgsBIX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void GoDDJEghhjzNPFig(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool MQZhkrhrYWXjuSqm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void NIEGdbEUXetkZJTA(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        WPyALyIfhXdUVCgp(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return aeHznxDDbrBgsBIX(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((29 + 10) % 10 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f2063c160;
        this.f2063c160 = null;
        if (t is not null) {
            TFyjgpmtuMWrmWJS(this.fd22a0a80, t);
        } else {
            JtAKpsCYjNHGYQwB(this.fd22a0a80);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            goDDJEghhjzNPFig(th);
        } else {
            this.f6b2ded51 = true;
            RFPkAKTbFLyzdHpQ(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f2063c160 is null) {
            this.f2063c160 = t;
            return;
        }
        this.f6b2ded51 = true;
        RjAcYNQaQeLqxIxP(this.fbc3b0556);
        nIEGdbEUXetkZJTA(this.fd22a0a80, new java.lang.IllegalArgumentException("Sequence contains more than one element!"));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (mQZhkrhrYWXjuSqm(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            JSjoNtKYIMcbKxBw(this.fd22a0a80, this);
        }
    }
}

