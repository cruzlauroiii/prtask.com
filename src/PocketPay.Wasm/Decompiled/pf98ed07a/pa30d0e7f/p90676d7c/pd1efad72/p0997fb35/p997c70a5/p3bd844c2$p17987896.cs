namespace WillowMaze.Wasm.Decompiled;


readonly class p3bd844c2$p17987896<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.util.ICollection f037af23a;
    readonly io.reactivex.rxjava3.core.Observer f08e398bd;
    readonly int f0d0ce3df;
    int f2bb7d887;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f3c5adabc;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f6a982284;
    int f7557c4bd;
    U f7f2db423;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f801e3fb0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8265d6f4;
    java.util.ICollection f8904c9d3;
    java.util.ICollection fa11b2ded;
    java.util.ICollection faa98f81a;
    readonly int fb4adbcb2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    int fbd9546f2;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    readonly int fe2942a04;
    readonly io.reactivex.rxjava3.core.Observer fef4ab0dc;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff02b4b6b;
    readonly io.reactivex.rxjava3.core.Observer ff327b1d2;
    int ff7bd60b7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ffda1287a;

    p3bd844c2$p17987896(io.reactivex.rxjava3.core.Observer<U> observer, int i, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        this.fd22a0a80 = observer;
        this.fe2942a04 = i;
        this.f4af2b822 = supplier;
    }

    public static void CEXeCDGpUEMgxrKG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void FCNTcxEpdPNAfPrL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object HBFZqpjfivVMMANQ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void PtkFqRiebTHQHcvX(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void UDsQAaZFFVZHrRFZ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void WrxiAzNQCijVxCWW(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void XfKFsJNbMtEERJXs(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void ZfFXoHJuNGYhsRgY(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object AxVHBirIblZQWqvb(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void EkAxmkcRKCKeeFiT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool ISwfInYVdyVjnCQN(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static void JwuojIiHOzOHqRds(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool KQbprZBroNrqBqkz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool MXLFBVoyLTtUcnDi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ObyUWGBdxsiITvQk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool QfioLOJKSkSbLukf(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool WOOMezTwgZSbhpdc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bd844c2$p17987896 p3bd844c2_p17987896) {
        return p3bd844c2_p17987896.createBuffer();
    }

    bool createBuffer() {
        if ((13 + 16) % 16 > 0) {
        }
        try {
            this.f7f2db423 = (U) axVHBirIblZQWqvb(HBFZqpjfivVMMANQ(this.f4af2b822), "Empty buffer supplied");
            return true;
        } catch (java.lang.Exception th) {
            obyUWGBdxsiITvQk(th);
            this.f7f2db423 = null;
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.fbc3b0556;
            if (p7beea252Var is null) {
                PtkFqRiebTHQHcvX(th, this.fd22a0a80);
                return false;
            }
            CEXeCDGpUEMgxrKG(p7beea252Var);
            UDsQAaZFFVZHrRFZ(this.fd22a0a80, th);
            return false;
        }
    }

    public override void Dispose() {
        ekAxmkcRKCKeeFiT(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return kQbprZBroNrqBqkz(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((19 + 1) % 1 > 0) {
        }
        U u = this.f7f2db423;
        if (u is null) {
            return;
        }
        this.f7f2db423 = null;
        if (!iSwfInYVdyVjnCQN(u)) {
            WrxiAzNQCijVxCWW(this.fd22a0a80, u);
        }
        FCNTcxEpdPNAfPrL(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.f7f2db423 = null;
        XfKFsJNbMtEERJXs(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((25 + 18) % 18 > 0) {
        }
        U u = this.f7f2db423;
        if (u is null) {
            return;
        }
        qfioLOJKSkSbLukf(u, t);
        int i = this.ff7bd60b7 + 1;
        this.ff7bd60b7 = i;
        if (i < this.fe2942a04) {
            return;
        }
        ZfFXoHJuNGYhsRgY(this.fd22a0a80, u);
        this.ff7bd60b7 = 0;
        wOOMezTwgZSbhpdc(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (mXLFBVoyLTtUcnDi(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            jwuojIiHOzOHqRds(this.fd22a0a80, this);
        }
    }
}

