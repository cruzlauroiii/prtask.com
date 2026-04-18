namespace WillowMaze.Wasm.Decompiled;


readonly class p2fec0970$p5bcc3449 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : java.lang.Action, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> {
    private static readonly long f1ed883ef = -4552101107598366241L;
    private static readonly long f85184ee5 = -4552101107598366241L;
    private static readonly long fc6e1e520 = -4552101107598366241L;
    bool f06aa6fa8;
    long f0f1027af;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2fec0970 f10ba75da;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2c127bf3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2fec0970 f30182efe;
    bool f32f04696;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f46bd9917;
    bool f8bd2495b;
    bool faff46da9;
    long fb83e4820;
    long fcd86cfc6;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableRefCount<object> fd0e45878;
    bool fed5e822c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2fec0970 ff50b97ad;
    bool ff627534d;

    p2fec0970$p5bcc3449(io.reactivex.rxjava3.internal.operators.observable.ObservableRefCount<object> observableRefCount) {
        this.fd0e45878 = observableRefCount;
    }

    public static void DVYUKSlpiIMolSWI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2fec0970$p5bcc3449 p2fec0970_p5bcc3449, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p2fec0970_p5bcc3449.accept(p7beea252Var);
    }

    public static bool HFPfYoSqEhUgUYff(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void SDnKnsuyBKndEIOs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2fec0970 p2fec0970Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2fec0970$p5bcc3449 p2fec0970_p5bcc3449) {
        p2fec0970Var.timeout(p2fec0970_p5bcc3449);
    }

    public static void VivueOkVvkOJOgDc(pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be pa6a851beVar) {
        pa6a851beVar.reset();
    }

    public void Accept(java.lang.object obj) throws java.lang.Exception {
        DVYUKSlpiIMolSWI(this, (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) obj);
    }

    public void Accept(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        HFPfYoSqEhUgUYff(this, p7beea252Var);
        lock (this.fd0e45878) {
            try {
                if (this.fed5e822c) {
                    VivueOkVvkOJOgDc(this.fd0e45878.f36cd38f4);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Run() {
        SDnKnsuyBKndEIOs(this.fd0e45878, this);
    }
}

