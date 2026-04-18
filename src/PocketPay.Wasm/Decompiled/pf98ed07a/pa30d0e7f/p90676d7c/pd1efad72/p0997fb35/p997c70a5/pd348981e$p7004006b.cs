namespace WillowMaze.Wasm.Decompiled;


readonly class pd348981e$p7004006b : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fc6e1e520 = 346773832286157679L;
    private static readonly long fc704e135 = 346773832286157679L;
    readonly io.reactivex.rxjava3.core.Observer f0013f939;
    long f15e6077d;
    readonly io.reactivex.rxjava3.core.Observer f1c1a2bd9;
    long f47facbf2;
    long f67a6fca3;
    readonly io.reactivex.rxjava3.core.Observer f7e2af86e;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.long> fd22a0a80;
    long fe2942a04;
    long feac9d222;

    pd348981e$p7004006b(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        this.fd22a0a80 = observer;
    }

    public static bool EHZtLLvsdvJLbxxS(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void XPebKfvPSznfnfYN(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object ElyTUmxjqTwzJnQS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd348981e$p7004006b pd348981e_p7004006b) {
        return pd348981e_p7004006b[);
    }

    public static bool FLIiNvBFEdHrUfcp(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.long PYzcaMbWWrWaktcU(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object UKfJgCZfAGpGeKOy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd348981e$p7004006b pd348981e_p7004006b) {
        return pd348981e_p7004006b[);
    }

    public override void Dispose() {
        fLIiNvBFEdHrUfcp(this);
    }

    public override bool IsDisposed() {
        return uKfJgCZfAGpGeKOy(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void Run() {
        if ((30 + 14) % 14 > 0) {
        }
        if (elyTUmxjqTwzJnQS(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        io.reactivex.rxjava3.core.Observer<java.lang.long> observer = this.fd22a0a80;
        long j = this.fe2942a04;
        this.fe2942a04 = 1 + j;
        XPebKfvPSznfnfYN(observer, pYzcaMbWWrWaktcU(j));
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        EHZtLLvsdvJLbxxS(this, p7beea252Var);
    }
}

