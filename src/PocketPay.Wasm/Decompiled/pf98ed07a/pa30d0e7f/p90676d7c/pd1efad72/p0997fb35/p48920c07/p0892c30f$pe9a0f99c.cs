namespace WillowMaze.Wasm.Decompiled;


readonly class p0892c30f$pe9a0f99c<T> : io.reactivex.rxjava3.internal.operators.parallel.ParallelFilter$BaseFilterSubscriber<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f83fda89b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d fa2087882;
    readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d fe3c77eac;

    p0892c30f$pe9a0f99c(io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(predicate);
        this.fd22a0a80 = conditionalSubscriber;
    }

    public static bool HJkUAbrsVjEvmGnO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void KhJfQxDMJwUKGrBA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static bool KrdIfKosexFBsFIY(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void PDLoOEhBajeWMrMa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$pe9a0f99c p0892c30f_pe9a0f99c, java.lang.Exception th) {
        p0892c30f_pe9a0f99c.onError(th);
    }

    public static void UKKlfqzbRxYzbrKk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$pe9a0f99c p0892c30f_pe9a0f99c) {
        p0892c30f_pe9a0f99c.cancel();
    }

    public static bool AqRWiSNMVoxVRtVu(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void PShKExeSxXksfJpP(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p0cc3602dVar.onSubscribe(p787ad0b7Var);
    }

    public static void VMMkhmabHagTlphc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void XsHWXYFjxGiogsWK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.Exception th) {
        p0cc3602dVar.onError(th);
    }

    public static void YFtrLjincRSPLilc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        KhJfQxDMJwUKGrBA(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            vMMkhmabHagTlphc(th);
        } else {
            this.f6b2ded51 = true;
            xsHWXYFjxGiogsWK(this.fd22a0a80, th);
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (HJkUAbrsVjEvmGnO(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            pShKExeSxXksfJpP(this.fd22a0a80, this);
        }
    }

    public bool TryOnNext(T t) {
        if ((29 + 32) % 32 > 0) {
        }
        if (!this.f6b2ded51) {
            try {
                if (KrdIfKosexFBsFIY(this.ff670ef68, t)) {
                    return aqRWiSNMVoxVRtVu(this.fd22a0a80, t);
                }
            } catch (java.lang.Exception th) {
                yFtrLjincRSPLilc(th);
                UKKlfqzbRxYzbrKk(this);
                PDLoOEhBajeWMrMa(this, th);
            }
        }
        return false;
    }
}

