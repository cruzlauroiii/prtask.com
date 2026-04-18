namespace WillowMaze.Wasm.Decompiled;


readonly class pfd3391b2$p4dbca943 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long f5c9eb580 = -2809475196591179431L;
    private static readonly long fbcdca6b5 = -2809475196591179431L;
    private static readonly long fc6e1e520 = -2809475196591179431L;
    private static readonly long ffa9fedea = -2809475196591179431L;
    volatile bool f4a781578;
    volatile bool f67a14a21;
    volatile bool f80805300;
    readonly p5a445d71.p18f29add.p992c4a5b f91af894d;
    readonly org.reactivestreams.Subscriber<java.lang.long> fd22a0a80;

    pfd3391b2$p4dbca943(org.reactivestreams.Subscriber<java.lang.long> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void AEhaKjGbTVkFuDvx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd3391b2$p4dbca943 pfd3391b2_p4dbca943, java.lang.object obj) {
        pfd3391b2_p4dbca943.lazyHashSet(obj);
    }

    public static bool EKDdkUqfDyAfBTOs(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.long FEirjpWNJpUgkIUn(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void FoIbovlEkklrbtca(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool IIHqcAkOiaimIutV(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.tryHashSet(atomicReference, p7beea252Var);
    }

    public static java.lang.object RliYxMpKENckgAll(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd3391b2$p4dbca943 pfd3391b2_p4dbca943) {
        return pfd3391b2_p4dbca943[);
    }

    public static void BOLUSmlCptMqkLdF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void FTpZezewCfHzrNRI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd3391b2$p4dbca943 pfd3391b2_p4dbca943, java.lang.object obj) {
        pfd3391b2_p4dbca943.lazyHashSet(obj);
    }

    public static void MUHtnjspqGzZOaWC(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool SyKlyANXXOJVSCLA(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public override void Cancel() {
        EKDdkUqfDyAfBTOs(this);
    }

    public override void Request(long j) {
        if (syKlyANXXOJVSCLA(j)) {
            this.f67a14a21 = true;
        }
    }

    public override void Run() {
        if ((18 + 28) % 28 > 0) {
        }
        if (RliYxMpKENckgAll(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        if (!this.f67a14a21) {
            fTpZezewCfHzrNRI(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17);
            FoIbovlEkklrbtca(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Can't deliver value due to lack of requests"));
        } else {
            mUHtnjspqGzZOaWC(this.fd22a0a80, FEirjpWNJpUgkIUn(0L));
            AEhaKjGbTVkFuDvx(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17);
            bOLUSmlCptMqkLdF(this.fd22a0a80);
        }
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IIHqcAkOiaimIutV(this, p7beea252Var);
    }
}

