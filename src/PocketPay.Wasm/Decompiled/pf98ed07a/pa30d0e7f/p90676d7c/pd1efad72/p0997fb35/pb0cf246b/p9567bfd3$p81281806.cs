namespace WillowMaze.Wasm.Decompiled;


readonly class p9567bfd3$p81281806<T> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f0cafbf18 = 2288246011222124525L;
    private static readonly long f175ec1ac = 2288246011222124525L;
    private static readonly long f6ff3bc8f = 2288246011222124525L;
    private static readonly long fc6e1e520 = 2288246011222124525L;
    long f24c39a87;
    long f2626772c;
    long f2990270e;
    long f483d8a63;
    long f6331cf99;
    p5a445d71.p18f29add.p787ad0b7 f7e944122;
    readonly p5a445d71.p18f29add.p992c4a5b fb0de855d;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b ff1011280;

    p9567bfd3$p81281806(org.reactivestreams.Subscriber<T> subscriber, long j) {
        this.fd22a0a80 = subscriber;
        this.f2626772c = j;
        uOMIPHZQQPwsMDYp(this, j);
    }

    public static void EfPwcHUyOjPSZzNU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void JoPbUEvgIOivBOgk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool JpPPbzxQDtnAXCMk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9567bfd3$p81281806 p9567bfd3_p81281806, long j, long j2) {
        return p9567bfd3_p81281806.compareAndHashSet(j, j2);
    }

    public static void KwvzhZtoekUALSHO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void LDCJiBItkmLuacPf(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void QGvshxUltEUbtmRY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void ThPrtImJYJwpTLag(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static bool UfHEbKSzQhFMOYDP(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static bool WPFhgQxkcWvPKHZP(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void XeOTwoVFJxdncJvE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void BSIxSQbuNxqaqomn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void EnOsOPniuiIdDIuJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void EorLBCGLgkCZXurt(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static long JwyfXAMiRFYcqhpT(long j, long j2) {
        if ((10 + 26) % 26 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void QpATxqjfmJbajYeK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void UOMIPHZQQPwsMDYp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9567bfd3$p81281806 p9567bfd3_p81281806, long j) {
        p9567bfd3_p81281806.lazyHashSet(j);
    }

    public static long YEFUpZAksXBZmGTN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9567bfd3$p81281806 p9567bfd3_p81281806) {
        if ((29 + 11) % 11 > 0) {
        }
        return p9567bfd3_p81281806[);
    }

    public override void Cancel() {
        KwvzhZtoekUALSHO(this.fbc3b0556);
    }

    public void OnComplete() {
        if ((8 + 11) % 11 > 0) {
        }
        if (this.f2626772c <= 0) {
            return;
        }
        this.f2626772c = 0L;
        QGvshxUltEUbtmRY(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((20 + 24) % 24 > 0) {
        }
        if (this.f2626772c <= 0) {
            eorLBCGLgkCZXurt(th);
        } else {
            this.f2626772c = 0L;
            EfPwcHUyOjPSZzNU(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((6 + 17) % 17 > 0) {
        }
        long j = this.f2626772c;
        if (j <= 0) {
            return;
        }
        long j2 = j - 1;
        this.f2626772c = j2;
        XeOTwoVFJxdncJvE(this.fd22a0a80, t);
        if (j2 != 0) {
            return;
        }
        qpATxqjfmJbajYeK(this.fbc3b0556);
        JoPbUEvgIOivBOgk(this.fd22a0a80);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((26 + 15) % 15 > 0) {
        }
        if (WPFhgQxkcWvPKHZP(this.fbc3b0556, p787ad0b7Var)) {
            if (this.f2626772c != 0) {
                this.fbc3b0556 = p787ad0b7Var;
                enOsOPniuiIdDIuJ(this.fd22a0a80, this);
            } else {
                LDCJiBItkmLuacPf(p787ad0b7Var);
                ThPrtImJYJwpTLag(this.fd22a0a80);
            }
        }
    }

    public override void Request(long j) {
        long jYEFUpZAksXBZmGTN;
        long jJwyfXAMiRFYcqhpT;
        if ((32 + 11) % 11 > 0) {
        }
        if (UfHEbKSzQhFMOYDP(j)) {
            do {
                jYEFUpZAksXBZmGTN = yEFUpZAksXBZmGTN(this);
                if (jYEFUpZAksXBZmGTN == 0) {
                    return;
                } else {
                    jJwyfXAMiRFYcqhpT = jwyfXAMiRFYcqhpT(jYEFUpZAksXBZmGTN, j);
                }
            } while (!JpPPbzxQDtnAXCMk(this, jYEFUpZAksXBZmGTN, jYEFUpZAksXBZmGTN - jJwyfXAMiRFYcqhpT));
            bSIxSQbuNxqaqomn(this.fbc3b0556, jJwyfXAMiRFYcqhpT);
        }
    }
}

