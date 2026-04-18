namespace WillowMaze.Wasm.Decompiled;


readonly class pafdeb810$p4c9f5644 : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f55a2fa0a = 1883890389173668373L;
    private static readonly long fc6e1e520 = 1883890389173668373L;
    private static readonly long ffbba201a = 1883890389173668373L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf f245da1d4;
    readonly bool f6ed51aae;
    readonly bool fcfbccb48;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf fd0e45878;
    readonly bool fd52bcfc7;

    pafdeb810$p4c9f5644(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, bool z) {
        this.fd0e45878 = pafdeb810_pebedbfbf;
        this.fcfbccb48 = z;
    }

    public static bool EFRYumWvfSuqKfNU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object GYmFZTUqZzQDJkgy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f5644) {
        return pafdeb810_p4c9f5644[);
    }

    public static bool XyTwoWSYBZCNDQrN(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void PlRPpurhlFqavwBy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, java.lang.Exception th) {
        pafdeb810_pebedbfbf.innerError(th);
    }

    public static void QGuMCJjJyIrahajp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f5644) {
        pafdeb810_pebedbfbf.innerComplete(pafdeb810_p4c9f5644);
    }

    public static void VZgcOJHwXpoXskaU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, bool z, java.lang.object obj) {
        pafdeb810_pebedbfbf.innerValue(z, obj);
    }

    public override void Dispose() {
        EFRYumWvfSuqKfNU(this);
    }

    public override bool IsDisposed() {
        return GYmFZTUqZzQDJkgy(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        qGuMCJjJyIrahajp(this.fd0e45878, this);
    }

    public void OnError(java.lang.Exception th) {
        plRPpurhlFqavwBy(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        vZgcOJHwXpoXskaU(this.fd0e45878, this.fcfbccb48, obj);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((32 + 4) % 4 > 0) {
        }
        XyTwoWSYBZCNDQrN(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

