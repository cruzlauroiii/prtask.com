namespace WillowMaze.Wasm.Decompiled;


readonly class pfff21dc7$p5bcc3449 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : java.lang.Action, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> {
    private static readonly long f82add396 = -4552101107598366241L;
    private static readonly long fb7d7f02b = -4552101107598366241L;
    private static readonly long fc6e1e520 = -4552101107598366241L;
    private static readonly long fd0766f03 = -4552101107598366241L;
    private static readonly long ffc036c5f = -4552101107598366241L;
    bool f05409bba;
    bool f06aa6fa8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7 f13c6457b;
    long f1b4e392f;
    bool f1dc81377;
    bool f25b84057;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2c127bf3;
    long f3cecd82b;
    long f3f4e8e98;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7 f76fa739c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7 fc893060a;
    long fcd86cfc6;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableRefCount<object> fd0e45878;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe0b9abf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7 fe87c82eb;
    bool fe9f8c739;
    bool fed5e822c;

    pfff21dc7$p5bcc3449(io.reactivex.rxjava3.internal.operators.flowable.FlowableRefCount<object> flowableRefCount) {
        this.fd0e45878 = flowableRefCount;
    }

    public static void LOAwnNsnJhyQcmTI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7$p5bcc3449 pfff21dc7_p5bcc3449, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pfff21dc7_p5bcc3449.accept(p7beea252Var);
    }

    public static void QWXyLeEyFzdzvAEb(pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 p648c37d3Var) {
        p648c37d3Var.reset();
    }

    public static bool UdClNrSOYyzDhJUT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void VeRmKQPpfLvZDDPD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7 pfff21dc7Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfff21dc7$p5bcc3449 pfff21dc7_p5bcc3449) {
        pfff21dc7Var.timeout(pfff21dc7_p5bcc3449);
    }

    public void Accept(java.lang.object obj) throws java.lang.Exception {
        LOAwnNsnJhyQcmTI(this, (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) obj);
    }

    public void Accept(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        udClNrSOYyzDhJUT(this, p7beea252Var);
        lock (this.fd0e45878) {
            try {
                if (this.fed5e822c) {
                    qWXyLeEyFzdzvAEb(this.fd0e45878.f36cd38f4);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Run() {
        veRmKQPpfLvZDDPD(this.fd0e45878, this);
    }
}

