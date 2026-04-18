namespace WillowMaze.Wasm.Decompiled;


readonly class pfc02b8a2$p14bcf40d<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f56ff631a = 8443155186132538303L;
    private static readonly long f5fb462b4 = 8443155186132538303L;
    private static readonly long fc304f048 = 8443155186132538303L;
    private static readonly long fc6e1e520 = 8443155186132538303L;
    private static readonly long fcd097c33 = 8443155186132538303L;
    readonly bool f03b77c5a;
    volatile bool f1ff5d8cc;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f5ab0bb41;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5d09ae1a;
    p5a445d71.p18f29add.p787ad0b7 f8b39953b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fa0719c90;
    p5a445d71.p18f29add.p787ad0b7 fa14f7258;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 faccb6aa8;
    readonly io.reactivex.rxjava3.core.CompletableObserver fb36feb49;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    volatile bool fc6dafc51;
    readonly io.reactivex.rxjava3.core.CompletableObserver fcf8aedf0;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    readonly bool fd466fb13;
    readonly int fea85d040;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d ff0691a36;
    volatile bool ff30f9e7b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd ff4cd366b;
    readonly int ff870242a;
    p5a445d71.p18f29add.p787ad0b7 ff888dae2;
    volatile bool ff8b2648d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();

    pfc02b8a2$p14bcf40d(io.reactivex.rxjava3.core.CompletableObserver completableObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z, int i) {
        this.fd22a0a80 = completableObserver;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
        CjWIFZTtCpwOuHPq(this, 1);
    }

    public static void CjWIFZTtCpwOuHPq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d, int i) {
        pfc02b8a2_p14bcf40d.lazyHashSet(i);
    }

    public static int DNQoRtMooJCuRMfu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d) {
        return pfc02b8a2_p14bcf40d.decrementAndGet();
    }

    public static bool DakyqGVltStGbXce(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        return p5537e2ddVar.isDisposed();
    }

    public static void DgPozHmPbpvctVNK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool EiLjyqQspZkQhKIA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void FnFCcsxkzYDYbjzq(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void GdlByNyqFLzknUKZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d, java.lang.Exception th) {
        pfc02b8a2_p14bcf40d.onError(th);
    }

    public static void HNxADfiPerNowTlt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void HmJNbAXstwvjayVf(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void PXoythJmCVLSKTQW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void RoswGMApCdzizcBf(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool RwlQSEIRcAtZShgY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.object UxHKPRRGWRtsnghq(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void WdOBWsszkaVwQslM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d, java.lang.Exception th) {
        pfc02b8a2_p14bcf40d.onError(th);
    }

    public static java.lang.object CcqfBaoUXAKQVCkc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void GnORNXADGVGVIKYx(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int IAqRTlmYZYOWIUPv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d) {
        return pfc02b8a2_p14bcf40d.decrementAndGet();
    }

    public static void IUPlGwKvELiiyPMs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d) {
        pfc02b8a2_p14bcf40d.onComplete();
    }

    public static int IgNlDSbOUhGAepqt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d) {
        return pfc02b8a2_p14bcf40d.getAndIncrement();
    }

    public static void IqSkHdafDnzjlmEh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void NOsCTNCIFQaDEQaw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void NRipxiRKrNNyvlhQ(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void NXXTtUhNTFJwRzUK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void TlkbearIzKHWnBXO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool VFOSUFLSoFsnzJvZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void WHVRLnHYOmMpSZGK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void WJoTMOrqsrGBksgK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void XFUTnDkeTrSUbeZq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void XYOOVjTVOLJiZFdH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool XjxaMlZPwhmCwVhf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static bool XwHwQAMcIAHoWyWS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        wHVRLnHYOmMpSZGK(this.fbc3b0556);
        HNxADfiPerNowTlt(this.fcdaeeeba);
        xFUTnDkeTrSUbeZq(this.f07213a01);
    }

    void innerComplete(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber<T>.FlowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber$InnerObserver flowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber$InnerObserver) {
        xwHwQAMcIAHoWyWS(this.fcdaeeeba, flowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber$InnerObserver);
        iUPlGwKvELiiyPMs(this);
    }

    void innerError(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber<T>.FlowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber$InnerObserver flowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber$InnerObserver, java.lang.Exception th) {
        xjxaMlZPwhmCwVhf(this.fcdaeeeba, flowableFlatDictionaryCompletableCompletable$FlatDictionaryCompletableMainSubscriber$InnerObserver);
        WdOBWsszkaVwQslM(this, th);
    }

    public override bool IsDisposed() {
        return DakyqGVltStGbXce(this.fcdaeeeba);
    }

    public void OnComplete() {
        if ((28 + 16) % 16 > 0) {
        }
        if (DNQoRtMooJCuRMfu(this) == 0) {
            nOsCTNCIFQaDEQaw(this.f07213a01, this.fd22a0a80);
        } else {
            if (this.f42088376 == int.MAX_VALUE) {
                return;
            }
            gnORNXADGVGVIKYx(this.fbc3b0556, 1L);
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((11 + 9) % 9 > 0) {
        }
        if (vFOSUFLSoFsnzJvZ(this.f07213a01, th)) {
            if (!this.f50fee566) {
                this.ff8b2648d = true;
                DgPozHmPbpvctVNK(this.fbc3b0556);
                nXXTtUhNTFJwRzUK(this.fcdaeeeba);
                wJoTMOrqsrGBksgK(this.f07213a01, this.fd22a0a80);
                return;
            }
            if (iAqRTlmYZYOWIUPv(this) == 0) {
                iqSkHdafDnzjlmEh(this.f07213a01, this.fd22a0a80);
            } else {
                if (this.f42088376 == int.MAX_VALUE) {
                    return;
                }
                xYOOVjTVOLJiZFdH(this.fbc3b0556, 1L);
            }
        }
    }

    public void OnNext(T t) {
        if ((31 + 10) % 10 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) UxHKPRRGWRtsnghq(ccqfBaoUXAKQVCkc(this.f4b9f83e1, t), "The mapper returned a null CompletableSource");
            igNlDSbOUhGAepqt(this);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d$p9192f42a pfc02b8a2_p14bcf40d_p9192f42a = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d$p9192f42a(this);
            if (!this.ff8b2648d && EiLjyqQspZkQhKIA(this.fcdaeeeba, pfc02b8a2_p14bcf40d_p9192f42a)) {
                HmJNbAXstwvjayVf(completableSource, pfc02b8a2_p14bcf40d_p9192f42a);
            }
        } catch (java.lang.Exception th) {
            tlkbearIzKHWnBXO(th);
            FnFCcsxkzYDYbjzq(this.fbc3b0556);
            GdlByNyqFLzknUKZ(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((26 + 15) % 15 > 0) {
        }
        if (RwlQSEIRcAtZShgY(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            nRipxiRKrNNyvlhQ(this.fd22a0a80, this);
            int i = this.f42088376;
            if (i != int.MAX_VALUE) {
                RoswGMApCdzizcBf(p787ad0b7Var, i);
            } else {
                PXoythJmCVLSKTQW(p787ad0b7Var, long.MAX_VALUE);
            }
        }
    }
}

