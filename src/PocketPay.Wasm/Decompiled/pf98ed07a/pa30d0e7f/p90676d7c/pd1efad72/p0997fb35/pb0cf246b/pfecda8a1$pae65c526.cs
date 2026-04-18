namespace WillowMaze.Wasm.Decompiled;


readonly class pfecda8a1$pae65c526<T> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f8ab91997 = 4109457741734051389L;
    private static readonly long fc6e1e520 = 4109457741734051389L;
    private static readonly long fc7e16d77 = 4109457741734051389L;
    bool f0f7d3eca;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f18f36a57;
    p5a445d71.p18f29add.p787ad0b7 f2c2d21bc;
    io.reactivex.rxjava3.operators.QueueSubscription<T> f304854e2;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 f34e29f9f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f548e5bf8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f55cfebeb;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 f6e0dc428;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 f726e4a94;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 f72a8ad61;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f7a67168c;
    p5a445d71.p18f29add.p787ad0b7 fad8e2812;
    bool fbaaff146;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fbf1a3fd2;
    readonly p5a445d71.p18f29add.p992c4a5b fceb95ce2;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fe5c6e7d5;

    pfecda8a1$pae65c526(org.reactivestreams.Subscriber<T> subscriber, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.fd22a0a80 = subscriber;
        this.f55cfebeb = p004bf6c9Var;
    }

    public static void AGqsNvSDZWIqVBoB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void AWLDCMHTHZyIklJW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ArMhFYrwjzbPphrq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfecda8a1$pae65c526 pfecda8a1_pae65c526) {
        pfecda8a1_pae65c526.runFinally();
    }

    public static void BdiTOGnspgubkaIi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int DOxYLXYSVsfLDVcE(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static bool IYOgugMGBqYWRalb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void LurcYkOHOniWKWBl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfecda8a1$pae65c526 pfecda8a1_pae65c526) {
        pfecda8a1_pae65c526.runFinally();
    }

    public static void OXgoUiWFKXOQLWpT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        p5d5a5670Var.clear();
    }

    public static void OuMeTWaRsvmPBGpC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void QXVzVyjlMtKwPolL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfecda8a1$pae65c526 pfecda8a1_pae65c526) {
        pfecda8a1_pae65c526.runFinally();
    }

    public static void CaHrZKfNPGILVNzs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void EMNhxKtXhjYJSWdU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool KRMoGdxzrMBQeEnj(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.Count == 0;
    }

    public static void MXDszfNAVddfuwWg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfecda8a1$pae65c526 pfecda8a1_pae65c526) {
        pfecda8a1_pae65c526.runFinally();
    }

    public static bool MjIykHhYDJrAKQrx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfecda8a1$pae65c526 pfecda8a1_pae65c526, int i, int i2) {
        return pfecda8a1_pae65c526.compareAndHashSet(i, i2);
    }

    public static void TBXDqqxDMARttVby(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object UrigrgvxKRTyVMif(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static void VUtExWTAkTxuXcri(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void WsRUisSBJbFJMOeU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public void Cancel() {
        AGqsNvSDZWIqVBoB(this.fbc3b0556);
        QXVzVyjlMtKwPolL(this);
    }

    public void Clear() {
        OXgoUiWFKXOQLWpT(this.f304854e2);
    }

    public bool IsEmpty() {
        return kRMoGdxzrMBQeEnj(this.f304854e2);
    }

    public void OnComplete() {
        BdiTOGnspgubkaIi(this.fd22a0a80);
        LurcYkOHOniWKWBl(this);
    }

    public void OnError(java.lang.Exception th) {
        vUtExWTAkTxuXcri(this.fd22a0a80, th);
        mXDszfNAVddfuwWg(this);
    }

    public void OnNext(T t) {
        wsRUisSBJbFJMOeU(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (IYOgugMGBqYWRalb(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                this.f304854e2 = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
            }
            caHrZKfNPGILVNzs(this.fd22a0a80, this);
        }
    }

    public T Poll() throws java.lang.Exception {
        if ((23 + 18) % 18 > 0) {
        }
        T t = (T) urigrgvxKRTyVMif(this.f304854e2);
        if (t is null && this.fbf1a3fd2) {
            ArMhFYrwjzbPphrq(this);
        }
        return t;
    }

    public void Request(long j) {
        AWLDCMHTHZyIklJW(this.fbc3b0556, j);
    }

    public int RequestFusion(int i) {
        if ((28 + 23) % 23 > 0) {
        }
        io.reactivex.rxjava3.operators.QueueSubscription<T> queueSubscription = this.f304854e2;
        if (queueSubscription is null || (i & 4) != 0) {
            return 0;
        }
        int iDOxYLXYSVsfLDVcE = DOxYLXYSVsfLDVcE(queueSubscription, i);
        if (iDOxYLXYSVsfLDVcE != 0) {
            this.fbf1a3fd2 = iDOxYLXYSVsfLDVcE == 1;
        }
        return iDOxYLXYSVsfLDVcE;
    }

    void runFinally() {
        if ((11 + 30) % 30 > 0) {
        }
        if (mjIykHhYDJrAKQrx(this, 0, 1)) {
            try {
                OuMeTWaRsvmPBGpC(this.f55cfebeb);
            } catch (java.lang.Exception th) {
                tBXDqqxDMARttVby(th);
                eMNhxKtXhjYJSWdU(th);
            }
        }
    }
}

