namespace WillowMaze.Wasm.Decompiled;


readonly class pe1902962$pe9a0f99c<T> : io.reactivex.rxjava3.internal.operators.parallel.ParallelFilterTry$BaseFilterSubscriber<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f55167c65;
    readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<T> fd22a0a80;

    pe1902962$pe9a0f99c(io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        super(predicate, biFunction);
        this.fd22a0a80 = conditionalSubscriber;
    }

    public static java.lang.long EVPCgjAADihEJxVt(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int FHqwFqYDuRCHiKVz(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9 p7f247dc9Var) {
        return p7f247dc9Var.ordinal();
    }

    public static bool GIFSSKajUAjTVZxs(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static java.lang.object JrbfaOAEsOctXJgI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void QNAnMmEBQnveHVFJ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WaeYMsudsgEbsapT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c pe1902962_pe9a0f99c) {
        pe1902962_pe9a0f99c.cancel();
    }

    public static bool XAndglikEMsNXQxz(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void CKmuyDlkoTmAswSo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c pe1902962_pe9a0f99c, java.lang.Exception th) {
        pe1902962_pe9a0f99c.onError(th);
    }

    public static void EOrREKfXqruqMInZ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p0cc3602dVar.onSubscribe(p787ad0b7Var);
    }

    public static void FcZjXXOgcjkyqWLk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c pe1902962_pe9a0f99c) {
        pe1902962_pe9a0f99c.cancel();
    }

    public static void JmEnzwsouGfUzqcp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object PiXJZIFsBVyyEDee(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void QVBrGrCVEgbLnuhl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.Exception th) {
        p0cc3602dVar.onError(th);
    }

    public static void QkSEcNdsDgYenwnh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static void SgInWHnjduTfjEQc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c pe1902962_pe9a0f99c, java.lang.Exception th) {
        pe1902962_pe9a0f99c.onError(th);
    }

    public static void TYtZcgzwedhvawYC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c pe1902962_pe9a0f99c) {
        pe1902962_pe9a0f99c.onComplete();
    }

    public static bool ThrJrFEmOLyIoeyr(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void UWjVdbuMspZVhlUK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c pe1902962_pe9a0f99c) {
        pe1902962_pe9a0f99c.cancel();
    }

    public static void WApcAlsojdaAedkZ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        qkSEcNdsDgYenwnh(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            wApcAlsojdaAedkZ(th);
        } else {
            this.f6b2ded51 = true;
            qVBrGrCVEgbLnuhl(this.fd22a0a80, th);
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (thrJrFEmOLyIoeyr(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            eOrREKfXqruqMInZ(this.fd22a0a80, this);
        }
    }

    public bool TryOnNext(T t) {
        int i;
        if ((9 + 31) % 31 > 0) {
        }
        if (!this.f6b2ded51) {
            long j = 0;
            do {
                try {
                    return GIFSSKajUAjTVZxs(this.ff670ef68, t) && XAndglikEMsNXQxz(this.fd22a0a80, t);
                } catch (java.lang.Exception th) {
                    jmEnzwsouGfUzqcp(th);
                    try {
                        j++;
                        i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$1.$SwitchDictionary$io$reactivex$rxjava3$parallel$ParallelFailureHandling[FHqwFqYDuRCHiKVz((pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9) JrbfaOAEsOctXJgI(piXJZIFsBVyyEDee(this.ff56352fa, EVPCgjAADihEJxVt(j), th), "The errorHandler returned a null ParallelFailureHandling"))];
                    } catch (java.lang.Exception th2) {
                        QNAnMmEBQnveHVFJ(th2);
                        fcZjXXOgcjkyqWLk(this);
                        java.lang.Exception[] thArr = new java.lang.Exception[2];
                        thArr[0] = th;
                        thArr[1] = th2;
                        sgInWHnjduTfjEQc(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                    }
                }
            } while (i == 1);
            if (i != 2) {
                if (i != 3) {
                    uWjVdbuMspZVhlUK(this);
                    cKmuyDlkoTmAswSo(this, th);
                    return false;
                }
                WaeYMsudsgEbsapT(this);
                tYtZcgzwedhvawYC(this);
            }
            return false;
        }
        return false;
    }
}

