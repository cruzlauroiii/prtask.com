namespace WillowMaze.Wasm.Decompiled;


readonly class pf690e6db$pdb78eae8<T, C> : io.reactivex.rxjava3.internal.subscribers.DeferredScalarSubscriber<T, C> {
    private static readonly long f140b3163 = -4767392946044436228L;
    private static readonly long f28dc2912 = -4767392946044436228L;
    private static readonly long f42edb267 = -4767392946044436228L;
    private static readonly long f9de6ec9f = -4767392946044436228L;
    private static readonly long fc6e1e520 = -4767392946044436228L;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f7021ef0d;
    bool f90bfb6ee;
    readonly io.reactivex.rxjava3.functions.BiConsumer<C, T> f91e3a7ff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fa8022bc0;
    C fdb6d9b45;
    bool fe2d9af93;
    bool fe9bf5502;
    java.lang.object ffabddbb2;

    pf690e6db$pdb78eae8(org.reactivestreams.Subscriber<C> subscriber, C c, io.reactivex.rxjava3.functions.BiConsumer<C, T> biConsumer) {
        super(subscriber);
        this.fdb6d9b45 = c;
        this.f91e3a7ff = biConsumer;
    }

    public static void AVDLpLDNWVezeeBt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pa2106daa pa2106daaVar) {
        super.cancel();
    }

    public static void DeivRBhkaSqpTqzy(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool DoLxFyHLMkLBXpKK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void LrTCifJleoQSFCHC(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void NTOOLzRUAKYKYgRt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QZfqrzhpHoSmPHAN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf690e6db$pdb78eae8 pf690e6db_pdb78eae8, java.lang.Exception th) {
        pf690e6db_pdb78eae8.onError(th);
    }

    public static void USgijiqBDmfQVtyG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf690e6db$pdb78eae8 pf690e6db_pdb78eae8, java.lang.object obj) {
        pf690e6db_pdb78eae8.complete(obj);
    }

    public static void HVCuvDwDlKLOPUSK(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static void LeAmsLlexbecScDB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void PFOZNvYntEcOqYKl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void TfNxrMRQzLFtFXPQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void VDgzbNmMUpzKcEMG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf690e6db$pdb78eae8 pf690e6db_pdb78eae8) {
        pf690e6db_pdb78eae8.cancel();
    }

    public void Cancel() {
        AVDLpLDNWVezeeBt(this);
        DeivRBhkaSqpTqzy(this.fbc3b0556);
    }

    public void OnComplete() {
        if ((20 + 12) % 12 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        C c = this.fdb6d9b45;
        this.fdb6d9b45 = null;
        USgijiqBDmfQVtyG(this, c);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            tfNxrMRQzLFtFXPQ(th);
            return;
        }
        this.f6b2ded51 = true;
        this.fdb6d9b45 = null;
        LrTCifJleoQSFCHC(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((12 + 2) % 2 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            hVCuvDwDlKLOPUSK(this.f91e3a7ff, this.fdb6d9b45, t);
        } catch (java.lang.Exception th) {
            leAmsLlexbecScDB(th);
            vDgzbNmMUpzKcEMG(this);
            QZfqrzhpHoSmPHAN(this, th);
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((8 + 32) % 32 > 0) {
        }
        if (DoLxFyHLMkLBXpKK(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            pFOZNvYntEcOqYKl(this.fd22a0a80, this);
            NTOOLzRUAKYKYgRt(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

