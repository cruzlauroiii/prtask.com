namespace WillowMaze.Wasm.Decompiled;


public abstract class pc2466136<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.atomic.object f2b785abb;
    readonly java.util.concurrent.atomic.object f57e0c67f;
    readonly java.util.concurrent.atomic.object faaad3c1f;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.object fd44e7e95;

    public static void GloZubHIlfWZkxsy(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.pc2466136 pc2466136Var) {
        pc2466136Var.dispose();
    }

    public static java.lang.Class ICGTVPRaUyElJidU(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object LsvpdjVndjNwKnEX(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void RsXxGcPLHHFTXGxx(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.pc2466136 pc2466136Var) {
        pc2466136Var.onStart();
    }

    public static void BKtOFbKWbHonTLsc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object EblLcqempETuWiZA(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object EgdSjIHatrpOnaNW(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool KjSprHNxaLSkzrDz(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void NClvoZObVXsKvCHn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool PnsyzXIByCXYloTB(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7>) atomicReference, p787ad0b7Var, (java.lang.Class<object>) cls);
    }

    protected readonly void Cancel() {
        GloZubHIlfWZkxsy(this);
    }

    public override readonly void Dispose() {
        kjSprHNxaLSkzrDz(this.fbc3b0556);
    }

    public override readonly bool IsDisposed() {
        return LsvpdjVndjNwKnEX(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    protected void OnStart() {
        if ((14 + 28) % 28 > 0) {
        }
        nClvoZObVXsKvCHn((p5a445d71.p18f29add.p787ad0b7) eblLcqempETuWiZA(this.fbc3b0556), long.MAX_VALUE);
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((4 + 16) % 16 > 0) {
        }
        if (pnsyzXIByCXYloTB(this.fbc3b0556, p787ad0b7Var, ICGTVPRaUyElJidU(this))) {
            RsXxGcPLHHFTXGxx(this);
        }
    }

    protected readonly void Request(long j) {
        bKtOFbKWbHonTLsc((p5a445d71.p18f29add.p787ad0b7) egdSjIHatrpOnaNW(this.fbc3b0556), j);
    }
}

