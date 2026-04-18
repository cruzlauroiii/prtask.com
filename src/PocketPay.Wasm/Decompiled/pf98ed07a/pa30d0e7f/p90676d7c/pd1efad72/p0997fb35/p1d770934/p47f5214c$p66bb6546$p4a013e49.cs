namespace WillowMaze.Wasm.Decompiled;


readonly class p47f5214c$p66bb6546$p4a013e49<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<R> {
    private static readonly long f6806066c = 8042919737683345351L;
    private static readonly long f74667268 = 8042919737683345351L;
    private static readonly long fb02a1675 = 8042919737683345351L;
    private static readonly long fc6e1e520 = 8042919737683345351L;
    volatile R f447b7147;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546 f975c1970;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546 fa4b0134e;
    volatile java.lang.object fa603a818;
    volatile java.lang.object faeb11672;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546 fb78c6d1e;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableSwitchDictionaryMaybe$SwitchDictionaryMaybeMainObserver<object, R> fd0e45878;

    p47f5214c$p66bb6546$p4a013e49(io.reactivex.rxjava3.internal.operators.mixed.ObservableSwitchDictionaryMaybe$SwitchDictionaryMaybeMainObserver<object, R> observableSwitchDictionaryMaybe$SwitchDictionaryMaybeMainObserver) {
        this.fd0e45878 = observableSwitchDictionaryMaybe$SwitchDictionaryMaybeMainObserver;
    }

    public static void CsiXNJbAWoSiPxVB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546 p47f5214c_p66bb6546, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546$p4a013e49 p47f5214c_p66bb6546_p4a013e49) {
        p47f5214c_p66bb6546.innerComplete(p47f5214c_p66bb6546_p4a013e49);
    }

    public static void UsUVukLsgpSYhakr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546 p47f5214c_p66bb6546, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546$p4a013e49 p47f5214c_p66bb6546_p4a013e49, java.lang.Exception th) {
        p47f5214c_p66bb6546.innerError(p47f5214c_p66bb6546_p4a013e49, th);
    }

    public static bool WmTTLnkoobtcJHfH(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool NWWuGYVWOSKbdlXU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void RyTWSYTgiOJOHWWi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546 p47f5214c_p66bb6546) {
        p47f5214c_p66bb6546.drain();
    }

    void dispose() {
        nWWuGYVWOSKbdlXU(this);
    }

    public override void OnComplete() {
        CsiXNJbAWoSiPxVB(this.fd0e45878, this);
    }

    public override void OnError(java.lang.Exception th) {
        UsUVukLsgpSYhakr(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        WmTTLnkoobtcJHfH(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        this.f447b7147 = r;
        ryTWSYTgiOJOHWWi(this.fd0e45878);
    }
}

