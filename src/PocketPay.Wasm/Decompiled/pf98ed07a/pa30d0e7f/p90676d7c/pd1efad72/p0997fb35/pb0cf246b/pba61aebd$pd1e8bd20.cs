namespace WillowMaze.Wasm.Decompiled;


readonly class pba61aebd$pd1e8bd20<T> : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pc54af332 {
    private static readonly long f7b827bbd = 3764492702657003550L;
    private static readonly long fc6e1e520 = 3764492702657003550L;
    readonly java.util.concurrent.atomic.Atomiclong f0d2392b4;
    readonly p5a445d71.p18f29add.p992c4a5b f142e5f39;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2abbbae9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f478f3a4c;
    long f48fe8558;
    readonly java.util.concurrent.atomic.object f4992f7f5;
    p5a445d71.p18f29add.p32c73be0 f49f5b3e3;
    org.reactivestreams.Publisher<? : T> f4ccb1142;
    long f5ab21a76;
    readonly p5a445d71.p18f29add.p992c4a5b f63acc514;
    readonly java.util.concurrent.atomic.Atomiclong f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f6b6f784b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f7ad287c4;
    readonly java.util.concurrent.atomic.object f7e5794a2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f8bef86ae;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f9a983635;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<object>> fca11cf04;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b ff3d56961;
    readonly java.util.concurrent.atomic.object ffc202ff3;

    pba61aebd$pd1e8bd20(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<object>> function, org.reactivestreams.Publisher<? : T> publisher) {
        super(true);
        this.fd22a0a80 = subscriber;
        this.fca11cf04 = function;
        this.f478f3a4c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        this.fbc3b0556 = new java.util.concurrent.atomic.object<>();
        this.f4ccb1142 = publisher;
        this.f6a992d55 = new java.util.concurrent.atomic.Atomiclong();
    }

    public static void AmETnmdMlEwPomgu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pd1e8bd20 pba61aebd_pd1e8bd20, long j) {
        pba61aebd_pd1e8bd20.produced(j);
    }

    public static void BIzyLSbhzWdlCFmj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool CyaruJvZrsfsPxez(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void DOWyTminTPtnpTdV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void FXPmQTWHOlRxmtco(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pd1e8bd20 pba61aebd_pd1e8bd20, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pba61aebd_pd1e8bd20.setSubscription(p787ad0b7Var);
    }

    public static bool GXPwLSkhNOMzVboQ(java.util.concurrent.atomic.Atomiclong atomiclong, long j, long j2) {
        return atomiclong.compareAndHashSet(j, j2);
    }

    public static bool GrmHrHYMRlduAGfs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void HkmSwGkxaSwdbJRF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void IRLMohwCcqrCSGoz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object IbUmgawaXlNUDUND(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var[);
    }

    public static long OHDhUWcDDYzeMPhR(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((13 + 26) % 26 > 0) {
        }
        return atomiclong.getAndHashSet(j);
    }

    public static long PWsdDkasMBmYYrtz(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((10 + 7) % 7 > 0) {
        }
        return atomiclong.getAndHashSet(j);
    }

    public static void SYPrKvftRiDdoQty(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool ScMbRYLKXDpdABkf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void VBBrlhYFiFHnfynZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void VRuxUzNlSCHjFQHD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void WbVJaRbFxBdhcBko(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var) {
        super.cancel();
    }

    public static void YuVMKZROuAozHKHY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ZBJxBcAKMEdKplmJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void ZIlhblxhtTDLusQc(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object AAMgrQnZqBBrntVL(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void BvevsbnHMAKHsQoA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool IMRgiTwRyuERUFMg(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object KKLrGFVHEyHVrlaL(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void KXuKeoTgoJZPSvbt(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static bool LNCSqMobdlHfvIiS(java.util.concurrent.atomic.Atomiclong atomiclong, long j, long j2) {
        return atomiclong.compareAndHashSet(j, j2);
    }

    public static bool ODZufIPxJCDtxxxN(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void OMnJqJsiZoTcUDzl(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void OluvRGydoVThELlQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void QZnrCAHMznUVcruz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void RbZZHZKNOaHMZCsn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool SUlpGaXfpWhLyFOt(java.util.concurrent.atomic.Atomiclong atomiclong, long j, long j2) {
        return atomiclong.compareAndHashSet(j, j2);
    }

    public static long TdvWtQvEuihMuZww(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((11 + 27) % 27 > 0) {
        }
        return atomiclong.getAndHashSet(j);
    }

    public static java.lang.object WkdngxYUmZvabJXl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void YIIIuPCqtWqOJurn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static long ZKgROyYxXMaavuVD(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((9 + 17) % 17 > 0) {
        }
        return atomiclong[);
    }

    public static void ZuxFxcKmcygQtpko(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        WbVJaRbFxBdhcBko(this);
        DOWyTminTPtnpTdV(this.f478f3a4c);
    }

    public void OnComplete() {
        if ((1 + 20) % 20 > 0) {
        }
        if (tdvWtQvEuihMuZww(this.f6a992d55, long.MAX_VALUE) == long.MAX_VALUE) {
            return;
        }
        yIIIuPCqtWqOJurn(this.f478f3a4c);
        rbZZHZKNOaHMZCsn(this.fd22a0a80);
        VRuxUzNlSCHjFQHD(this.f478f3a4c);
    }

    public void OnError(java.lang.Exception th) {
        if ((12 + 7) % 7 > 0) {
        }
        if (OHDhUWcDDYzeMPhR(this.f6a992d55, long.MAX_VALUE) == long.MAX_VALUE) {
            qZnrCAHMznUVcruz(th);
            return;
        }
        VBBrlhYFiFHnfynZ(this.f478f3a4c);
        bvevsbnHMAKHsQoA(this.fd22a0a80, th);
        ZBJxBcAKMEdKplmJ(this.f478f3a4c);
    }

    public void OnNext(T t) {
        if ((12 + 28) % 28 > 0) {
        }
        long jZKgROyYxXMaavuVD = zKgROyYxXMaavuVD(this.f6a992d55);
        if (jZKgROyYxXMaavuVD == long.MAX_VALUE) {
            return;
        }
        long j = jZKgROyYxXMaavuVD + 1;
        if (GXPwLSkhNOMzVboQ(this.f6a992d55, jZKgROyYxXMaavuVD, j)) {
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) IbUmgawaXlNUDUND(this.f478f3a4c);
            if (p7beea252Var is not null) {
                BIzyLSbhzWdlCFmj(p7beea252Var);
            }
            this.f48fe8558++;
            IRLMohwCcqrCSGoz(this.fd22a0a80, t);
            try {
                p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) kKLrGFVHEyHVrlaL(wkdngxYUmZvabJXl(this.fca11cf04, t), "The itemTimeoutIndicator returned a null Publisher.");
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pb0252226 pba61aebd_pb0252226 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pb0252226(j, this);
                if (ScMbRYLKXDpdABkf(this.f478f3a4c, pba61aebd_pb0252226)) {
                    oMnJqJsiZoTcUDzl(p32c73be0Var, pba61aebd_pb0252226);
                }
            } catch (java.lang.Exception th) {
                SYPrKvftRiDdoQty(th);
                YuVMKZROuAozHKHY((p5a445d71.p18f29add.p787ad0b7) aAMgrQnZqBBrntVL(this.fbc3b0556));
                PWsdDkasMBmYYrtz(this.f6a992d55, long.MAX_VALUE);
                zuxFxcKmcygQtpko(this.fd22a0a80, th);
            }
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (CyaruJvZrsfsPxez(this.fbc3b0556, p787ad0b7Var)) {
            FXPmQTWHOlRxmtco(this, p787ad0b7Var);
        }
    }

    public override void OnTimeout(long j) {
        if ((20 + 13) % 13 > 0) {
        }
        if (lNCSqMobdlHfvIiS(this.f6a992d55, j, long.MAX_VALUE)) {
            iMRgiTwRyuERUFMg(this.fbc3b0556);
            org.reactivestreams.Publisher<? : T> publisher = this.f4ccb1142;
            this.f4ccb1142 = null;
            long j2 = this.f48fe8558;
            if (j2 != 0) {
                AmETnmdMlEwPomgu(this, j2);
            }
            kXuKeoTgoJZPSvbt(publisher, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$p4d22150d(this.fd22a0a80, this));
        }
    }

    public override void OnTimeoutError(long j, java.lang.Exception th) {
        if ((15 + 2) % 2 > 0) {
        }
        if (!sUlpGaXfpWhLyFOt(this.f6a992d55, j, long.MAX_VALUE)) {
            HkmSwGkxaSwdbJRF(th);
        } else {
            oDZufIPxJCDtxxxN(this.fbc3b0556);
            oluvRGydoVThELlQ(this.fd22a0a80, th);
        }
    }

    void startFirstTimeout(org.reactivestreams.Publisher<object> publisher) {
        if ((32 + 1) % 1 > 0) {
        }
        if (publisher is null) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pb0252226 pba61aebd_pb0252226 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pb0252226(0L, this);
        if (GrmHrHYMRlduAGfs(this.f478f3a4c, pba61aebd_pb0252226)) {
            ZIlhblxhtTDLusQc(publisher, pba61aebd_pb0252226);
        }
    }
}

