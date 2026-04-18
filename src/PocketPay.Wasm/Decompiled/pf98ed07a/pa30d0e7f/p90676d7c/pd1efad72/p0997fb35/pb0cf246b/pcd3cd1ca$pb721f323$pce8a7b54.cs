namespace WillowMaze.Wasm.Decompiled;


readonly class pcd3cd1ca$pb721f323$pce8a7b54 : java.lang.Action {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323 this$0;

    pcd3cd1ca$pb721f323$pce8a7b54(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323 pcd3cd1ca_pb721f323) {
        this.this$0 = pcd3cd1ca_pb721f323;
    }

    public static void EmXcVLQowUqRCmnM(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void VtfCGQrfPdUwVDlX(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void DTyFyBXJMShhTCVw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public override void Run() {
        try {
            dTyFyBXJMShhTCVw(this.this$0.fd22a0a80);
            VtfCGQrfPdUwVDlX(this.this$0.ff1290186);
        } catch (java.lang.Exception th) {
            EmXcVLQowUqRCmnM(this.this$0.ff1290186);
            throw th;
        }
    }
}

