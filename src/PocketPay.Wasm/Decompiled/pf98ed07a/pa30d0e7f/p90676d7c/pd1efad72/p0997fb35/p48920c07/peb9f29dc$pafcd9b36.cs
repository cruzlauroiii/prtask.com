namespace WillowMaze.Wasm.Decompiled;


readonly class peb9f29dc$pafcd9b36<T> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f4e876b5b;
    p5a445d71.p18f29add.p787ad0b7 f605c8b45;
    bool f6a44740a;
    bool f6b2ded51;
    bool f7393f8c1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f8626846a;
    readonly p5a445d71.p18f29add.p992c4a5b f8b654b19;
    bool fa5b91140;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc5d52ca5;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fd856e041;
    readonly io.reactivex.rxjava3.functions.Consumer<T> ff51350c3;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;

    peb9f29dc$pafcd9b36(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Consumer<T> consumer, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.fd22a0a80 = subscriber;
        this.ff51350c3 = consumer;
        this.ff56352fa = biFunction;
    }

    public static void AHMgXynHWLSuDaBi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int FJEIbdgpQaTMgqme(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9 p7f247dc9Var) {
        return p7f247dc9Var.ordinal();
    }

    public static void FnZxkDbALJEOhInJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool HEOVQpkOKmAtwyVT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void JacxQUVZKGBFcJbu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36, java.lang.Exception th) {
        peb9f29dc_pafcd9b36.onError(th);
    }

    public static void KBLMcPpdpZsOPCiE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MXHlMEaTQowRqgUf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36, java.lang.Exception th) {
        peb9f29dc_pafcd9b36.onError(th);
    }

    public static java.lang.object RjnICSFSVTSCUYFQ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void TGLnFQYQEkwmPlkI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36) {
        peb9f29dc_pafcd9b36.onComplete();
    }

    public static void UMCtzdivGdhCLaME(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36) {
        peb9f29dc_pafcd9b36.cancel();
    }

    public static void VJQgOunSJjazVPzN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool ZIfrnZjMqqMDpkvT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36, java.lang.object obj) {
        return peb9f29dc_pafcd9b36.tryOnNext(obj);
    }

    public static void EWjlPunGUfHXEGbp(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void EjWOzTCnKMqNrOTC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36) {
        peb9f29dc_pafcd9b36.cancel();
    }

    public static java.lang.object GJGMWkFksCNSDVSc(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GlpUFYGoBuDVEnPN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void HkWcCTDIwdtvWhjn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void KEvLgyCWvFCiACoc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void LVZwrhoASiafJfmn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.long OEzCQmrTolfHqsoO(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void QCnRdblttqLdGszm(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void TbUOYyVESDglSgie(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$pafcd9b36 peb9f29dc_pafcd9b36) {
        peb9f29dc_pafcd9b36.cancel();
    }

    public static void YmrCfLPWpYggtitp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void Cancel() {
        KBLMcPpdpZsOPCiE(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        hkWcCTDIwdtvWhjn(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            qCnRdblttqLdGszm(th);
        } else {
            this.f6b2ded51 = true;
            VJQgOunSJjazVPzN(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((6 + 1) % 1 > 0) {
        }
        if (ZIfrnZjMqqMDpkvT(this, t)) {
            return;
        }
        glpUFYGoBuDVEnPN(this.fbc3b0556, 1L);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (HEOVQpkOKmAtwyVT(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            FnZxkDbALJEOhInJ(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        AHMgXynHWLSuDaBi(this.fbc3b0556, j);
    }

    public bool TryOnNext(T t) {
        int i;
        if ((13 + 32) % 32 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        long j = 0;
        do {
            try {
                eWjlPunGUfHXEGbp(this.ff51350c3, t);
                kEvLgyCWvFCiACoc(this.fd22a0a80, t);
                return true;
            } catch (java.lang.Exception th) {
                lVZwrhoASiafJfmn(th);
                try {
                    j++;
                    i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.peb9f29dc$1.$SwitchDictionary$io$reactivex$rxjava3$parallel$ParallelFailureHandling[FJEIbdgpQaTMgqme((pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9) gJGMWkFksCNSDVSc(RjnICSFSVTSCUYFQ(this.ff56352fa, oEzCQmrTolfHqsoO(j), th), "The errorHandler returned a null ParallelFailureHandling"))];
                } catch (java.lang.Exception th2) {
                    ymrCfLPWpYggtitp(th2);
                    tbUOYyVESDglSgie(this);
                    java.lang.Exception[] thArr = new java.lang.Exception[2];
                    thArr[0] = th;
                    thArr[1] = th2;
                    MXHlMEaTQowRqgUf(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                    return false;
                }
            }
        } while (i == 1);
        if (i != 2) {
            if (i != 3) {
                UMCtzdivGdhCLaME(this);
                JacxQUVZKGBFcJbu(this, th);
                return false;
            }
            ejWOzTCnKMqNrOTC(this);
            TGLnFQYQEkwmPlkI(this);
        }
        return false;
    }
}

