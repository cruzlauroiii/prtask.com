namespace WillowMaze.Wasm.Decompiled;


readonly class p9e84576a$pdca3b148 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<java.lang.object> {
    private static readonly long f392c59d9 = 3256684027868224024L;
    private static readonly long fc6e1e520 = 3256684027868224024L;
    readonly int f14c5eb3e;
    readonly int f6a8bb7cb;
    readonly int f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 f9e555a26;
    readonly int fa3d78506;
    readonly int fca314ea8;
    bool fca66516b;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableWithLatestFromMany$WithLatestFromObserver<object, object> fd0e45878;
    bool fe39190f2;

    p9e84576a$pdca3b148(io.reactivex.rxjava3.internal.operators.observable.ObservableWithLatestFromMany$WithLatestFromObserver<object, object> observableWithLatestFromMany$WithLatestFromObserver, int i) {
        this.fd0e45878 = observableWithLatestFromMany$WithLatestFromObserver;
        this.f6a992d55 = i;
    }

    public static bool AboLgtEDmdDyNjBg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void NSyCnrnbSCZNeCVk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i, bool z) {
        p9e84576a_pf81b0546.innerComplete(i, z);
    }

    public static bool OXotwsPFsVFjNQBA(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void QuXWBQGACRSihdEt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i, java.lang.Exception th) {
        p9e84576a_pf81b0546.innerError(i, th);
    }

    public static void NDgpWGngTzBMBLpz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i, java.lang.object obj) {
        p9e84576a_pf81b0546.innerNext(i, obj);
    }

    public void Dispose() {
        OXotwsPFsVFjNQBA(this);
    }

    public override void OnComplete() {
        if ((29 + 7) % 7 > 0) {
        }
        NSyCnrnbSCZNeCVk(this.fd0e45878, this.f6a992d55, this.fca66516b);
    }

    public override void OnError(java.lang.Exception th) {
        QuXWBQGACRSihdEt(this.fd0e45878, this.f6a992d55, th);
    }

    public override void OnNext(java.lang.object obj) {
        if (!this.fca66516b) {
            this.fca66516b = true;
        }
        nDgpWGngTzBMBLpz(this.fd0e45878, this.f6a992d55, obj);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        AboLgtEDmdDyNjBg(this, p7beea252Var);
    }
}

