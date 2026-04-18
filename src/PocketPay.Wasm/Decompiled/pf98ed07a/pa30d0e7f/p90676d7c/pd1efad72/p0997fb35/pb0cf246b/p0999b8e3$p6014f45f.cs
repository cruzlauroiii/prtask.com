namespace WillowMaze.Wasm.Decompiled;


readonly class p0999b8e3$p6014f45f<T> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f219b742c = -3176480756392482682L;
    private static readonly long f4ff00570 = -3176480756392482682L;
    private static readonly long f64ca7c21 = -3176480756392482682L;
    private static readonly long fc6e1e520 = -3176480756392482682L;
    private static readonly long ff4a73cb2 = -3176480756392482682L;
    p5a445d71.p18f29add.p787ad0b7 f0b88a09b;
    p5a445d71.p18f29add.p787ad0b7 f12a0860f;
    bool f1e2d5be8;
    bool f311bd30e;
    bool f42966396;
    readonly p5a445d71.p18f29add.p992c4a5b f4480600e;
    bool f61b89633;
    p5a445d71.p18f29add.p787ad0b7 f6508fce2;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;

    p0999b8e3$p6014f45f(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static long CbXKNLJzvTBzXzGG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0999b8e3$p6014f45f p0999b8e3_p6014f45f) {
        if ((20 + 31) % 31 > 0) {
        }
        return p0999b8e3_p6014f45f[);
    }

    public static void DYIDnbYnrCnZYhat(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void DdzgZTeNxGCVJtBZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static long IKapfhbpKvqZhRul(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((18 + 31) % 31 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static bool INXThJGZYDLUNltd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void LMzDhLzoSqNuoJqO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void MiAXZrgpTqGQkUjc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void BzUyHSBtBiQHflTS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0999b8e3$p6014f45f p0999b8e3_p6014f45f, java.lang.Exception th) {
        p0999b8e3_p6014f45f.onError(th);
    }

    public static void ItMyRCLWrOZsTxKm(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool PDxkzBJqrbJhDXAe(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void PfFMzCWkztYTuAli(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void SzYjfPOVjSqkcauU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static long VVljkDcYRVzJMONg(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((11 + 32) % 32 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void YYWbCrccAyyPDnzA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public override void Cancel() {
        pfFMzCWkztYTuAli(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        MiAXZrgpTqGQkUjc(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            szYjfPOVjSqkcauU(th);
        } else {
            this.f6b2ded51 = true;
            DYIDnbYnrCnZYhat(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((4 + 3) % 3 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (CbXKNLJzvTBzXzGG(this) == 0) {
            itMyRCLWrOZsTxKm(this.fbc3b0556);
            bzUyHSBtBiQHflTS(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("could not emit value due to lack of requests"));
        } else {
            yYWbCrccAyyPDnzA(this.fd22a0a80, t);
            vVljkDcYRVzJMONg(this, 1L);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((10 + 2) % 2 > 0) {
        }
        if (INXThJGZYDLUNltd(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            LMzDhLzoSqNuoJqO(this.fd22a0a80, this);
            DdzgZTeNxGCVJtBZ(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (pDxkzBJqrbJhDXAe(j)) {
            IKapfhbpKvqZhRul(this, j);
        }
    }
}

