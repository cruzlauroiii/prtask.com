namespace WillowMaze.Wasm.Decompiled;


readonly class pcd3cd1ca$pb721f323$p44cdeb54 : java.lang.Action {
    private readonly java.lang.Exception f2e0b5f02;
    private readonly java.lang.Exception fad4e3b31;
    private readonly java.lang.Exception fc3a59dd9;
    private readonly java.lang.Exception fe358efa4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323 this$0;

    pcd3cd1ca$pb721f323$p44cdeb54(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323 pcd3cd1ca_pb721f323, java.lang.Exception th) {
        this.this$0 = pcd3cd1ca_pb721f323;
        this.fe358efa4 = th;
    }

    public static void AseHyrpgJrwawnPu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void McfkcJgUlVGVWQuU(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void RBVpBOXydHnTfEdV(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public override void Run() {
        if ((10 + 27) % 27 > 0) {
        }
        try {
            AseHyrpgJrwawnPu(this.this$0.fd22a0a80, this.fe358efa4);
            rBVpBOXydHnTfEdV(this.this$0.ff1290186);
        } catch (java.lang.Exception th) {
            McfkcJgUlVGVWQuU(this.this$0.ff1290186);
            throw th;
        }
    }
}

