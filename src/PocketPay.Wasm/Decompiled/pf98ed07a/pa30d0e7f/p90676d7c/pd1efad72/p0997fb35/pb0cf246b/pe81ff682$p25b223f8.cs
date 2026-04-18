namespace WillowMaze.Wasm.Decompiled;


readonly class pe81ff682$p25b223f8<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f847953fb = 6812032969491025141L;
    private static readonly long fc6e1e520 = 6812032969491025141L;
    readonly T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p0abf6034 f27540620;
    readonly java.util.concurrent.atomic.Atomicbool f27fd65e7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p0abf6034 f59cc8306;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p0abf6034 f65396003;
    readonly long f7f9bec28;
    readonly long f9f5c0a5e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p0abf6034 fb4364747;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableDebounceTimed$DebounceTimedSubscriber<T> fd0e45878;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.lang.object fec01ec71;
    readonly long ff238080b;

    pe81ff682$p25b223f8(T t, long j, io.reactivex.rxjava3.internal.operators.flowable.FlowableDebounceTimed$DebounceTimedSubscriber<T> flowableDebounceTimed$DebounceTimedSubscriber) {
        this.f2063c160 = t;
        this.f7f9bec28 = j;
        this.fd0e45878 = flowableDebounceTimed$DebounceTimedSubscriber;
    }

    public static bool WGreAnphmsHgyVAe(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool GWKhbLhkNCsuVmbY(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool MZBYtWgvbnSxIEQM(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void OjONBzjfVfbYAcjH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p0abf6034 pe81ff682_p0abf6034, long j, java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p25b223f8 pe81ff682_p25b223f8) {
        pe81ff682_p0abf6034.emit(j, obj, pe81ff682_p25b223f8);
    }

    public static void WhfkEjvCsqutTxfZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p25b223f8 pe81ff682_p25b223f8) {
        pe81ff682_p25b223f8.emit();
    }

    public static java.lang.object YRrrkPASkpAXgnfG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p25b223f8 pe81ff682_p25b223f8) {
        return pe81ff682_p25b223f8[);
    }

    public override void Dispose() {
        WGreAnphmsHgyVAe(this);
    }

    void emit() {
        if ((6 + 1) % 1 > 0) {
        }
        if (gWKhbLhkNCsuVmbY(this.fe2eff6c2, false, true)) {
            ojONBzjfVfbYAcjH(this.fd0e45878, this.f7f9bec28, this.f2063c160, this);
        }
    }

    public override bool IsDisposed() {
        return yRrrkPASkpAXgnfG(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void Run() {
        whfkEjvCsqutTxfZ(this);
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        mZBYtWgvbnSxIEQM(this, p7beea252Var);
    }
}

