namespace WillowMaze.Wasm.Decompiled;


readonly class pd6103485$p6fbc9adc<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long fa7d172b9 = -5467847744262967226L;
    private static readonly long fc6e1e520 = -5467847744262967226L;
    p5a445d71.p18f29add.p787ad0b7 f02edc9dd;
    p5a445d71.p18f29add.p787ad0b7 f6fbb1099;
    p5a445d71.p18f29add.p787ad0b7 fb8cf3426;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;

    pd6103485$p6fbc9adc(org.reactivestreams.Subscriber<T> subscriber) {
        super(subscriber);
    }

    public static bool QCyfCDxLgaJIKZXO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void SlDVOuBJHIKUYRdL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd6103485$p6fbc9adc pd6103485_p6fbc9adc, java.lang.object obj) {
        pd6103485_p6fbc9adc.complete(obj);
    }

    public static void UbWlvtxwetgIAhRJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void FwERUdkNDEtNIWjU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void JmPDbuSVnagCoPHk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void PgWZGFhoIZyUTaTr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void RquPHbKUCaJahsuB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void XPXBlDazdMlnOVCy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public void Cancel() {
        xPXBlDazdMlnOVCy(this);
        rquPHbKUCaJahsuB(this.fbc3b0556);
    }

    public void OnComplete() {
        java.lang.object obj = this.f2063c160;
        if (obj is null) {
            pgWZGFhoIZyUTaTr(this.fd22a0a80);
        } else {
            SlDVOuBJHIKUYRdL(this, obj);
        }
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        fwERUdkNDEtNIWjU(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        this.f2063c160 = t;
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((7 + 17) % 17 > 0) {
        }
        if (QCyfCDxLgaJIKZXO(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            UbWlvtxwetgIAhRJ(this.fd22a0a80, this);
            jmPDbuSVnagCoPHk(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

