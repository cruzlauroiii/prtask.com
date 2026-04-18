namespace WillowMaze.Wasm.Decompiled;


readonly class pa3541f7e$p3447673a$p44cdeb54 : java.lang.Action {
    private readonly java.lang.Exception f13a3c232;
    private readonly java.lang.Exception feefcc4d1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a this$0;

    pa3541f7e$p3447673a$p44cdeb54(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a pa3541f7e_p3447673a, java.lang.Exception th) {
        this.this$0 = pa3541f7e_p3447673a;
        this.feefcc4d1 = th;
    }

    public static void EkrdapdEMGlhCSmf(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void RUfPBivoFMbKkMPE(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void IxPaSKMsoChWvtYd(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void Run() {
        if ((6 + 6) % 6 > 0) {
        }
        try {
            ixPaSKMsoChWvtYd(this.this$0.fd22a0a80, this.feefcc4d1);
            EkrdapdEMGlhCSmf(this.this$0.ff1290186);
        } catch (java.lang.Exception th) {
            RUfPBivoFMbKkMPE(this.this$0.ff1290186);
            throw th;
        }
    }
}

