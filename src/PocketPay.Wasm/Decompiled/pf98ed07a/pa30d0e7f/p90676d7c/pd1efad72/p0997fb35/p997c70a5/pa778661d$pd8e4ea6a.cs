namespace WillowMaze.Wasm.Decompiled;


readonly class pa778661d$pd8e4ea6a<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f13bed22c;
    readonly io.reactivex.rxjava3.core.Observer f23a98d6b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f2b3fab01;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4816e00a;
    readonly io.reactivex.rxjava3.core.Observer f58fe0c17;
    readonly io.reactivex.rxjava3.core.Observer f654edf66;
    bool f6b2ded51;
    bool f728992bb;
    bool fa8aae051;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.bool> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer feb5ff6cb;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    pa778661d$pd8e4ea6a(io.reactivex.rxjava3.core.Observer<java.lang.bool> observer, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = observer;
        this.ff670ef68 = predicate;
    }

    public static bool BALsPEOMRBMfMHSn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static java.lang.bool HbjqiolAUuqCJAgj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void ISgJUfEuihyFoejo(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JgziUcpKQORNkwxm(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void WCBwLbhtPeOIkofZ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void XTQsTObhSoeabmGp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void DlXsvjKHSCdytgzU(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void EcYrPioSyoqqlNvh(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void FepEAvZZdgbaYcCH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void INSprLUJQyAdtrnd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void PxFoaAQiFnzauGdw(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.bool QXnQuPPHJaGyRKGm(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void SfzlexnhzSnKDRas(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa778661d$pd8e4ea6a pa778661d_pd8e4ea6a, java.lang.Exception th) {
        pa778661d_pd8e4ea6a.onError(th);
    }

    public static void TUipzEmuRQKvaUAW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VtrRWGLBGDctLucc(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool YHmHsCsaOneGQHSJ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static bool YoFEdyXqyRvBhtWv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public override void Dispose() {
        ecYrPioSyoqqlNvh(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return BALsPEOMRBMfMHSn(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((6 + 30) % 30 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ISgJUfEuihyFoejo(this.fd22a0a80, qXnQuPPHJaGyRKGm(true));
        dlXsvjKHSCdytgzU(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            XTQsTObhSoeabmGp(th);
        } else {
            this.f6b2ded51 = true;
            vtrRWGLBGDctLucc(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        try {
            if (yHmHsCsaOneGQHSJ(this.ff670ef68, t)) {
                return;
            }
            this.f6b2ded51 = true;
            fepEAvZZdgbaYcCH(this.fbc3b0556);
            WCBwLbhtPeOIkofZ(this.fd22a0a80, HbjqiolAUuqCJAgj(false));
            pxFoaAQiFnzauGdw(this.fd22a0a80);
        } catch (java.lang.Exception th) {
            iNSprLUJQyAdtrnd(th);
            tUipzEmuRQKvaUAW(this.fbc3b0556);
            sfzlexnhzSnKDRas(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (yoFEdyXqyRvBhtWv(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            JgziUcpKQORNkwxm(this.fd22a0a80, this);
        }
    }
}

