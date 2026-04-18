namespace WillowMaze.Wasm.Decompiled;


readonly class p08a3cdb1$ped70e0fb : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f38897edd = 1883890389173668373L;
    private static readonly long f85cc6806 = 1883890389173668373L;
    private static readonly long fc6e1e520 = 1883890389173668373L;
    private static readonly long fdc2dab84 = 1883890389173668373L;
    readonly int f405c5381;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf f4163c87a;
    readonly bool f5ca1263e;
    readonly int f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf fb2d7e08c;
    readonly int fb374c62f;
    readonly bool fcfbccb48;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf fd0e45878;
    readonly int fdad3ca5f;
    readonly bool ffaa03dcd;

    p08a3cdb1$ped70e0fb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, bool z, int i) {
        this.fd0e45878 = p08a3cdb1_pebedbfbf;
        this.fcfbccb48 = z;
        this.f6a992d55 = i;
    }

    public static bool PENAFqjuDwGSAZrT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object PyLHLBJDFiFDbTXt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb) {
        return p08a3cdb1_ped70e0fb[);
    }

    public static void XHHxbRsajjgiNwfQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, bool z, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb) {
        p08a3cdb1_pebedbfbf.innerClose(z, p08a3cdb1_ped70e0fb);
    }

    public static void AVJHLGtCVgnQQjIV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, java.lang.Exception th) {
        p08a3cdb1_pebedbfbf.innerCloseError(th);
    }

    public static void BDLqFrqxQuDCGrCJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, bool z, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb) {
        p08a3cdb1_pebedbfbf.innerClose(z, p08a3cdb1_ped70e0fb);
    }

    public static bool LBAchSBcToCldQAK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool RgYycLutHOqtdrgg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool TIwADJLFMuKCHPFg(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        PENAFqjuDwGSAZrT(this);
    }

    public override bool IsDisposed() {
        return lBAchSBcToCldQAK((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) PyLHLBJDFiFDbTXt(this));
    }

    public override void OnComplete() {
        if ((12 + 14) % 14 > 0) {
        }
        XHHxbRsajjgiNwfQ(this.fd0e45878, this.fcfbccb48, this);
    }

    public override void OnError(java.lang.Exception th) {
        aVJHLGtCVgnQQjIV(this.fd0e45878, th);
    }

    public override void OnNext(java.lang.object obj) {
        if (tIwADJLFMuKCHPFg(this)) {
            bDLqFrqxQuDCGrCJ(this.fd0e45878, this.fcfbccb48, this);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        rgYycLutHOqtdrgg(this, p7beea252Var);
    }
}

