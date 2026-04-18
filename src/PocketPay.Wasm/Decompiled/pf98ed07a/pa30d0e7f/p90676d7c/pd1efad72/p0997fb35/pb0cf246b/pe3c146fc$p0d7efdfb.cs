namespace WillowMaze.Wasm.Decompiled;


readonly class pe3c146fc$p0d7efdfb<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long fc4901b45 = 1577321883966341961L;
    private static readonly long fc6e1e520 = 1577321883966341961L;
    private static readonly long fdb4ba1ba = 1577321883966341961L;
    private static readonly long feba4adf9 = 1577321883966341961L;
    volatile bool f04ced0aa;
    readonly p5a445d71.p18f29add.p992c4a5b f06f4a1e9;
    volatile bool f0d775044;
    volatile bool f107b8772;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f1bc7635a;
    readonly java.util.concurrent.atomic.object f4be12b4a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5a49e9c2;
    readonly p5a445d71.p18f29add.p992c4a5b f619892fb;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> f61aaf8fd;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[] f6a14584a;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.objectArray f7dfe2628;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[] f7e0e87d4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7e661efc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[] faae7b662;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fb3a90a12;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcb5e100e;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fe485e924;
    readonly java.util.concurrent.atomic.objectArray<java.lang.object> ff09cc7ee;
    volatile bool ff0e7c585;
    readonly p5a445d71.p18f29add.p992c4a5b ff8de0923;

    pe3c146fc$p0d7efdfb(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> function, int i) {
        this.fd22a0a80 = subscriber;
        this.f61aaf8fd = function;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[] pe3c146fc_p396eb818Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[i];
        for (int i2 = 0; i2 < i; i2++) {
            pe3c146fc_p396eb818Arr[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818(this, i2);
        }
        this.faae7b662 = pe3c146fc_p396eb818Arr;
        this.ff09cc7ee = new java.util.concurrent.atomic.objectArray<>(i);
        this.fbc3b0556 = new java.util.concurrent.atomic.object<>();
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
        this.fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    }

    public static void BcEKypDQSJNYljRX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void CmXAvoPIpHAxrwEK(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void DDDuLytEXyTVaMCw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i) {
        pe3c146fc_p0d7efdfb.cancelAllBut(i);
    }

    public static void ExIgwpyTvXeImAKA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((org.reactivestreams.Subscriber<object>) p992c4a5bVar, th, atomicint, p36a52e5dVar);
    }

    public static java.lang.object FDlacNBUOWECnCgy(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool GVJYrdqYxvqeaxqk(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object HDAmxuuHtczOIGbo(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void HeuzKUgbpdcDMXAt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i) {
        pe3c146fc_p0d7efdfb.cancelAllBut(i);
    }

    public static void JpJLNQkJqSwOxjFE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818 pe3c146fc_p396eb818) {
        pe3c146fc_p396eb818.dispose();
    }

    public static bool OShBQSTBVLalhFXE(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void PkLDuyKibtORRuDq(java.util.concurrent.atomic.objectArray atomicReferenceArray, int i, java.lang.object obj) {
        atomicReferenceArray.set(i, obj);
    }

    public static java.lang.object SrxeMYPupNmjFAuC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void TMpPOQRWpdhxtImc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i) {
        pe3c146fc_p0d7efdfb.cancelAllBut(i);
    }

    public static int TttIsdIofZMOHiRV(java.util.concurrent.atomic.objectArray atomicReferenceArray) {
        return atomicReferenceArray.Length;
    }

    public static void UfKYzJtBmaDRrMfp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, java.lang.Exception th) {
        pe3c146fc_p0d7efdfb.onError(th);
    }

    public static java.lang.object BfVcKEPHgFkeuRAj(java.util.concurrent.atomic.objectArray atomicReferenceArray, int i) {
        return atomicReferenceArray[i);
    }

    public static void CtnxudrPyFczSuXq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.m6ae9fbb6((org.reactivestreams.Subscriber<object>) p992c4a5bVar, atomicint, p36a52e5dVar);
    }

    public static void FNLphdFMxHAXZhQk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818 pe3c146fc_p396eb818) {
        pe3c146fc_p396eb818.dispose();
    }

    public static void FQhPEfnsSJJVklgf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb) {
        pe3c146fc_p0d7efdfb.cancel();
    }

    public static void FfcyySVavwSDdPDg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool IeKEndexSWgJroIi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mf51350c3((org.reactivestreams.Subscriber<java.lang.object>) p992c4a5bVar, obj, atomicint, p36a52e5dVar);
    }

    public static bool LLHgBfDnajcIpJWl(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static void NCSiTXVEqTyUCStx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((org.reactivestreams.Subscriber<object>) p992c4a5bVar, th, atomicint, p36a52e5dVar);
    }

    public static bool NFVgNffOscrWWpKd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, java.lang.object obj) {
        return pe3c146fc_p0d7efdfb.tryOnNext(obj);
    }

    public static void NGOSPpNtOimGYJXE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i) {
        pe3c146fc_p0d7efdfb.cancelAllBut(i);
    }

    public static void PDWkEqBSuWmPOkWI(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static void QbhnoWipzJIjklEo(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.m6ae9fbb6((org.reactivestreams.Subscriber<object>) p992c4a5bVar, atomicint, p36a52e5dVar);
    }

    public static void QsmYflIZIcLtzBLA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool TcIiScMrnklhWgxT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object UyWYyFtomctOPzyb(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public override void Cancel() {
        if ((20 + 5) % 5 > 0) {
        }
        OShBQSTBVLalhFXE(this.fbc3b0556);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818 pe3c146fc_p396eb818 : this.faae7b662) {
            JpJLNQkJqSwOxjFE(pe3c146fc_p396eb818);
        }
    }

    void cancelAllBut(int i) {
        if ((8 + 17) % 17 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[] pe3c146fc_p396eb818Arr = this.faae7b662;
        for (int i2 = 0; i2 < pe3c146fc_p396eb818Arr.length; i2++) {
            if (i2 != i) {
                fNLphdFMxHAXZhQk(pe3c146fc_p396eb818Arr[i2]);
            }
        }
    }

    void innerComplete(int i, bool z) {
        if (z) {
            return;
        }
        this.f6b2ded51 = true;
        tcIiScMrnklhWgxT(this.fbc3b0556);
        TMpPOQRWpdhxtImc(this, i);
        qbhnoWipzJIjklEo(this.fd22a0a80, this, this.fcb5e100e);
    }

    void innerError(int i, java.lang.Exception th) {
        this.f6b2ded51 = true;
        GVJYrdqYxvqeaxqk(this.fbc3b0556);
        nGOSPpNtOimGYJXE(this, i);
        nCSiTXVEqTyUCStx(this.fd22a0a80, th, this, this.fcb5e100e);
    }

    void innerNext(int i, java.lang.object obj) {
        PkLDuyKibtORRuDq(this.ff09cc7ee, i, obj);
    }

    public void OnComplete() {
        if ((3 + 24) % 24 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        HeuzKUgbpdcDMXAt(this, -1);
        ctnxudrPyFczSuXq(this.fd22a0a80, this, this.fcb5e100e);
    }

    public void OnError(java.lang.Exception th) {
        if ((27 + 10) % 10 > 0) {
        }
        if (this.f6b2ded51) {
            ffcyySVavwSDdPDg(th);
            return;
        }
        this.f6b2ded51 = true;
        DDDuLytEXyTVaMCw(this, -1);
        ExIgwpyTvXeImAKA(this.fd22a0a80, th, this, this.fcb5e100e);
    }

    public void OnNext(T t) {
        if ((9 + 20) % 20 > 0) {
        }
        if (nFVgNffOscrWWpKd(this, t) || this.f6b2ded51) {
            return;
        }
        BcEKypDQSJNYljRX((p5a445d71.p18f29add.p787ad0b7) HDAmxuuHtczOIGbo(this.fbc3b0556), 1L);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        lLHgBfDnajcIpJWl(this.fbc3b0556, this.f67a14a21, p787ad0b7Var);
    }

    public override void Request(long j) {
        pDWkEqBSuWmPOkWI(this.fbc3b0556, this.f67a14a21, j);
    }

    void subscribe(org.reactivestreams.Publisher<object>[] publisherArr, int i) {
        if ((10 + 18) % 18 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p396eb818[] pe3c146fc_p396eb818Arr = this.faae7b662;
        java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> atomicReference = this.fbc3b0556;
        for (int i2 = 0; i2 < i && FDlacNBUOWECnCgy(atomicReference) != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb; i2++) {
            CmXAvoPIpHAxrwEK(publisherArr[i2], pe3c146fc_p396eb818Arr[i2]);
        }
    }

    public bool TryOnNext(T t) {
        if ((5 + 7) % 7 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        java.util.concurrent.atomic.objectArray<java.lang.object> atomicReferenceArray = this.ff09cc7ee;
        int iTttIsdIofZMOHiRV = TttIsdIofZMOHiRV(atomicReferenceArray);
        java.lang.object[] objArr = new java.lang.object[iTttIsdIofZMOHiRV + 1];
        objArr[0] = t;
        int i = 0;
        while (i < iTttIsdIofZMOHiRV) {
            java.lang.object objBfVcKEPHgFkeuRAj = bfVcKEPHgFkeuRAj(atomicReferenceArray, i);
            if (objBfVcKEPHgFkeuRAj is null) {
                return false;
            }
            i++;
            objArr[i] = objBfVcKEPHgFkeuRAj;
        }
        try {
            ieKEndexSWgJroIi(this.fd22a0a80, uyWYyFtomctOPzyb(SrxeMYPupNmjFAuC(this.f61aaf8fd, objArr), "The combiner returned a null value"), this, this.fcb5e100e);
            return true;
        } catch (java.lang.Exception th) {
            qsmYflIZIcLtzBLA(th);
            fQhPEfnsSJJVklgf(this);
            UfKYzJtBmaDRrMfp(this, th);
            return false;
        }
    }
}

