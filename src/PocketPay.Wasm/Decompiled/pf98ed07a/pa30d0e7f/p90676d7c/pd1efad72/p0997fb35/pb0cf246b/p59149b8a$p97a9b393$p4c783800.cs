namespace WillowMaze.Wasm.Decompiled;


readonly class p59149b8a$p97a9b393$p4c783800 : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    private static readonly long f557917ae = -5592042965931999169L;
    private static readonly long f71c00680 = -5592042965931999169L;
    private static readonly long f76843c1d = -5592042965931999169L;
    private static readonly long fa58712ef = -5592042965931999169L;
    private static readonly long fc6e1e520 = -5592042965931999169L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393 this$0;

    p59149b8a$p97a9b393$p4c783800(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393 p59149b8a_p97a9b393) {
        this.this$0 = p59149b8a_p97a9b393;
    }

    public static bool EgZYNjDoaXFHlVCX(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static bool TOOfHosjRjeyfQrC(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object UchDuaDGNTHjEsOD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393$p4c783800 p59149b8a_p97a9b393_p4c783800) {
        return p59149b8a_p97a9b393_p4c783800[);
    }

    public static void XffZlLMGpLFbZQzx(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void SjCAYneJZMburtJs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((org.reactivestreams.Subscriber<object>) p992c4a5bVar, th, atomicint, p36a52e5dVar);
    }

    public void OnComplete() {
        this.this$0.f63d721d2 = true;
    }

    public void OnError(java.lang.Exception th) {
        if ((21 + 2) % 2 > 0) {
        }
        TOOfHosjRjeyfQrC(this.this$0.fbc3b0556);
        org.reactivestreams.Subscriber<T> subscriber = this.this$0.fd22a0a80;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393 p59149b8a_p97a9b393 = this.this$0;
        sjCAYneJZMburtJs(subscriber, th, p59149b8a_p97a9b393, p59149b8a_p97a9b393.fcb5e100e);
    }

    public void OnNext(java.lang.object obj) {
        this.this$0.f63d721d2 = true;
        XffZlLMGpLFbZQzx((p5a445d71.p18f29add.p787ad0b7) UchDuaDGNTHjEsOD(this));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((32 + 13) % 13 > 0) {
        }
        EgZYNjDoaXFHlVCX(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

