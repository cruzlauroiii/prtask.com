namespace WillowMaze.Wasm.Decompiled;


readonly class pea430f18$p04829003<T, R> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<R>, io.reactivex.rxjava3.core.MaybeObserver<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f0861d933 = -8948264376121066672L;
    private static readonly long f342d67eb = -8948264376121066672L;
    private static readonly long f919ee0c7 = -8948264376121066672L;
    private static readonly long fc6e1e520 = -8948264376121066672L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3603fcf3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3dafc55b;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly p5a445d71.p18f29add.p992c4a5b f8bd328fd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb2bd35b8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc09fe723;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fdfdb547f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff95e2b6e;

    pea430f18$p04829003(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
    }

    public static void JavTSTWwwdbLGixa(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void AVNKZZnfdCfQNgvb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object AbZRgMwwyyhbYpFV(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool BEoIKqfKeoxWkKaF(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static void GRmfYNCkCTCzIEso(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void KHzSUAQNzEgbdsxa(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void MVBpCQXqmCvcjPWM(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static void NgQxUbeZWwLXYbWi(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object PcnftNEDPYNvbhxz(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void RDjHPuUJzzvxzUlK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool RVpnztIDAvsDrwhd(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object TXQEWPPMyKfYWXAa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pea430f18$p04829003 pea430f18_p04829003) {
        return pea430f18_p04829003[);
    }

    public static void UwYOKvgGFWSIonAc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool VmcJIdCaMITRcPSM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void YYDcUBVKjGnpriUD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        kHzSUAQNzEgbdsxa(this.fbc3b0556);
        rVpnztIDAvsDrwhd(this);
    }

    public override void OnComplete() {
        rDjHPuUJzzvxzUlK(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        yYDcUBVKjGnpriUD(this.fd22a0a80, th);
    }

    public void OnNext(R r) {
        JavTSTWwwdbLGixa(this.fd22a0a80, r);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        bEoIKqfKeoxWkKaF(this, this.f67a14a21, p787ad0b7Var);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (vmcJIdCaMITRcPSM(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            gRmfYNCkCTCzIEso(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((16 + 28) % 28 > 0) {
        }
        try {
            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) pcnftNEDPYNvbhxz(abZRgMwwyyhbYpFV(this.f4b9f83e1, t), "The mapper returned a null Publisher");
            if (tXQEWPPMyKfYWXAa(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
                return;
            }
            ngQxUbeZWwLXYbWi(p32c73be0Var, this);
        } catch (java.lang.Exception th) {
            uwYOKvgGFWSIonAc(th);
            aVNKZZnfdCfQNgvb(this.fd22a0a80, th);
        }
    }

    public override void Request(long j) {
        mVBpCQXqmCvcjPWM(this, this.f67a14a21, j);
    }
}

