namespace WillowMaze.Wasm.Decompiled;


readonly class pa3541f7e$p3447673a$pce8a7b54 : java.lang.Action {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a this$0;

    pa3541f7e$p3447673a$pce8a7b54(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a pa3541f7e_p3447673a) {
        this.this$0 = pa3541f7e_p3447673a;
    }

    public static void EmLERQJTGsQSoQBb(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void MXxJPdrqFsybBiEV(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void PTQNWNgZRsybxfTg(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public override void Run() {
        try {
            EmLERQJTGsQSoQBb(this.this$0.fd22a0a80);
            MXxJPdrqFsybBiEV(this.this$0.ff1290186);
        } catch (java.lang.Exception th) {
            PTQNWNgZRsybxfTg(this.this$0.ff1290186);
            throw th;
        }
    }
}

