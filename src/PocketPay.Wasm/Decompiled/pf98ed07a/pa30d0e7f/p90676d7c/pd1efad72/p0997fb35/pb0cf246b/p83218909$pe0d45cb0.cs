namespace WillowMaze.Wasm.Decompiled;


readonly class p83218909$pe0d45cb0<T, U> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f05eb89b2 = 2827772011130406689L;
    private static readonly long f2f267961 = 2827772011130406689L;
    private static readonly long f34f897b3 = 2827772011130406689L;
    private static readonly long fc6e1e520 = 2827772011130406689L;
    readonly java.util.concurrent.atomic.object f20e69847;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 f3a968be7;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 f641ef80d;
    readonly p5a445d71.p18f29add.p32c73be0 f72a8d7d5;
    readonly java.util.concurrent.atomic.Atomiclong f7aad2ae8;
    io.reactivex.rxjava3.internal.operators.flowable.FlowableRepeatWhen$WhenSourceSubscriber<T, U> f9367a975;
    readonly java.util.concurrent.atomic.object f938fb233;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 f9b3ddf82;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 fc1b78b70;
    readonly java.util.concurrent.atomic.Atomiclong fc29558e8;
    readonly java.util.concurrent.atomic.Atomiclong feb2049d6;
    readonly java.util.concurrent.atomic.Atomiclong ff5d9fbae;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    p83218909$pe0d45cb0(org.reactivestreams.Publisher<T> publisher) {
        this.f36cd38f4 = publisher;
    }

    public static void MQlGfRxOZUxHEhoB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 p83218909_pfde4bb14) {
        p83218909_pfde4bb14.cancel();
    }

    public static bool NVHEsKkfuLixknyV(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static java.lang.object RircbAYCWcMrvYWp(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void XRiYxPqnddadUIkE(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static int CSYrmHppFGzGFYrj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pe0d45cb0 p83218909_pe0d45cb0) {
        return p83218909_pe0d45cb0.getAndIncrement();
    }

    public static void IQTpsLsmMjbuRGdB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int JItFbIxZIsdcRhIk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pe0d45cb0 p83218909_pe0d45cb0) {
        return p83218909_pe0d45cb0.decrementAndGet();
    }

    public static void WPxOZtGBmdRrXBVQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 p83218909_pfde4bb14) {
        p83218909_pfde4bb14.cancel();
    }

    public static void XhrQuhrBrpXRMWbO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void ZdiRVFGMCPrtUdke(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static bool ZtLUbUkitfvrjtJd(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public override void Cancel() {
        ztLUbUkitfvrjtJd(this.fbc3b0556);
    }

    public void OnComplete() {
        wPxOZtGBmdRrXBVQ(this.f9367a975);
        xhrQuhrBrpXRMWbO(this.f9367a975.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        MQlGfRxOZUxHEhoB(this.f9367a975);
        iQTpsLsmMjbuRGdB(this.f9367a975.fd22a0a80, th);
    }

    public void OnNext(java.lang.object obj) {
        if (cSYrmHppFGzGFYrj(this) != 0) {
            return;
        }
        do {
            if (RircbAYCWcMrvYWp(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
                return;
            } else {
                XRiYxPqnddadUIkE(this.f36cd38f4, this.f9367a975);
            }
        } while (jItFbIxZIsdcRhIk(this) != 0);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        NVHEsKkfuLixknyV(this.fbc3b0556, this.f67a14a21, p787ad0b7Var);
    }

    public override void Request(long j) {
        zdiRVFGMCPrtUdke(this.fbc3b0556, this.f67a14a21, j);
    }
}

