namespace WillowMaze.Wasm.Decompiled;


readonly class pafdeb810$pf62ac110 : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f109dcd37 = 1883890389173668373L;
    private static readonly long fc6e1e520 = 1883890389173668373L;
    readonly int f1671e077;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf f3d0b5f9d;
    readonly bool f440c3985;
    readonly bool f45ec84af;
    readonly int f6a992d55;
    readonly bool f8ca6e83f;
    readonly int fc734629f;
    readonly bool fcfbccb48;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf fdeac7aac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf fee87b839;
    readonly int ff9024127;
    readonly int ffb95c286;

    pafdeb810$pf62ac110(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, bool z, int i) {
        this.fd0e45878 = pafdeb810_pebedbfbf;
        this.fcfbccb48 = z;
        this.f6a992d55 = i;
    }

    public static bool MQGwXhWzulUldGIK(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool OggKlLKExMgealfl(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void QPjFUAEONPLkawpE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, bool z, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac110) {
        pafdeb810_pebedbfbf.innerClose(z, pafdeb810_pf62ac110);
    }

    public static bool WRhRfBYtKxAFlAqj(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object InYyojHUvcqNDkTZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac110) {
        return pafdeb810_pf62ac110[);
    }

    public static void JmGoNPTkNaTkfURx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, bool z, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac110) {
        pafdeb810_pebedbfbf.innerClose(z, pafdeb810_pf62ac110);
    }

    public static void XxTkePOpTsrxDnar(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf pafdeb810_pebedbfbf, java.lang.Exception th) {
        pafdeb810_pebedbfbf.innerCloseError(th);
    }

    public override void Dispose() {
        WRhRfBYtKxAFlAqj(this);
    }

    public override bool IsDisposed() {
        return inYyojHUvcqNDkTZ(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((16 + 7) % 7 > 0) {
        }
        QPjFUAEONPLkawpE(this.fd0e45878, this.fcfbccb48, this);
    }

    public void OnError(java.lang.Exception th) {
        xxTkePOpTsrxDnar(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        if (MQGwXhWzulUldGIK(this)) {
            jmGoNPTkNaTkfURx(this.fd0e45878, this.fcfbccb48, this);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((18 + 14) % 14 > 0) {
        }
        OggKlLKExMgealfl(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

