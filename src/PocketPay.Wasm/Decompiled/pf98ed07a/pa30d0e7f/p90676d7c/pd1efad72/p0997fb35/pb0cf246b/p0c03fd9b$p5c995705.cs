namespace WillowMaze.Wasm.Decompiled;


readonly class p0c03fd9b$p5c995705<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f1fbd040f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f27fcebe3;
    readonly p5a445d71.p18f29add.p992c4a5b f4331b118;
    readonly p5a445d71.p18f29add.p992c4a5b f4eab3f28;
    readonly p5a445d71.p18f29add.p992c4a5b f55e1f299;
    p5a445d71.p18f29add.p787ad0b7 f5bf157ab;
    bool f6b2ded51;
    bool f7aa5ee73;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f979fb2fa;
    readonly p5a445d71.p18f29add.p992c4a5b fa837e549;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    p0c03fd9b$p5c995705(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = subscriber;
        this.ff670ef68 = predicate;
    }

    public static void BYafjikoTjEUxOmZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c03fd9b$p5c995705 p0c03fd9b_p5c995705, java.lang.Exception th) {
        p0c03fd9b_p5c995705.onError(th);
    }

    public static void CHEYJJIizKeZpLoI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool FLZxfIqDVFJNRYig(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void GpNyILBUeYPuWqJI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void HHKsAVNFiwUHUyJb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void MZxXWowOfjkPKFaz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool NEHFvxJkVJorUmoO(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void XQHYwPaMzuoxDwgJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void ZqETLQMPeNRjFKyT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void CfsKqzUulxygqZfa(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void EzlQswdVoqpAijtT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void IySWLlpHEFaZjqky(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NpiWmeQmOoCpeEpj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WlSvrjuJAJwtnRaW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        ezlQswdVoqpAijtT(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        XQHYwPaMzuoxDwgJ(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            npiWmeQmOoCpeEpj(th);
        } else {
            this.f6b2ded51 = true;
            wlSvrjuJAJwtnRaW(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        try {
            if (NEHFvxJkVJorUmoO(this.ff670ef68, t)) {
                GpNyILBUeYPuWqJI(this.fd22a0a80, t);
                return;
            }
            this.f6b2ded51 = true;
            MZxXWowOfjkPKFaz(this.fbc3b0556);
            HHKsAVNFiwUHUyJb(this.fd22a0a80);
        } catch (java.lang.Exception th) {
            iySWLlpHEFaZjqky(th);
            ZqETLQMPeNRjFKyT(this.fbc3b0556);
            BYafjikoTjEUxOmZ(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (FLZxfIqDVFJNRYig(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            cfsKqzUulxygqZfa(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        CHEYJJIizKeZpLoI(this.fbc3b0556, j);
    }
}

