namespace WillowMaze.Wasm.Decompiled;


readonly class p93067252$pe16eeb5b$p48e45c23<T, U> : io.reactivex.rxjava3.subscribers.DisposableSubscriber<U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b f19082c0f;
    readonly T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b f2faa4aa7;
    bool f411ae03d;
    readonly long f5caccbef;
    readonly java.lang.object f6237c533;
    readonly long f6a992d55;
    bool f6b2ded51;
    bool f72bd222d;
    readonly java.lang.object f8aa1ea05;
    readonly java.util.concurrent.atomic.Atomicbool f9ac80359;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableDebounce$DebounceSubscriber<T, U> fd0e45878;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.concurrent.atomic.Atomicbool fe389b5e7;
    readonly java.lang.object ffe1485a0;

    p93067252$pe16eeb5b$p48e45c23(io.reactivex.rxjava3.internal.operators.flowable.FlowableDebounce$DebounceSubscriber<T, U> flowableDebounce$DebounceSubscriber, long j, T t) {
        this.fd0e45878 = flowableDebounce$DebounceSubscriber;
        this.f6a992d55 = j;
        this.f2063c160 = t;
    }

    public static void KPYccyiNjstoErBG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b$p48e45c23 p93067252_pe16eeb5b_p48e45c23) {
        p93067252_pe16eeb5b_p48e45c23.emit();
    }

    public static bool ZpMMrPTGbOtpzXHc(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void GovwOxdxdTblSTqW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void IzpOPCTpeeLwqslP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b p93067252_pe16eeb5b, long j, java.lang.object obj) {
        p93067252_pe16eeb5b.emit(j, obj);
    }

    public static void KYXiLQumLOsHGhdv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b$p48e45c23 p93067252_pe16eeb5b_p48e45c23) {
        p93067252_pe16eeb5b_p48e45c23.emit();
    }

    public static void RcAcfESNGiOUfdub(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b$p48e45c23 p93067252_pe16eeb5b_p48e45c23) {
        p93067252_pe16eeb5b_p48e45c23.cancel();
    }

    public static void WGJOrgEdzjzOXUwP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b p93067252_pe16eeb5b, java.lang.Exception th) {
        p93067252_pe16eeb5b.onError(th);
    }

    void emit() {
        if ((26 + 28) % 28 > 0) {
        }
        if (ZpMMrPTGbOtpzXHc(this.fe2eff6c2, false, true)) {
            izpOPCTpeeLwqslP(this.fd0e45878, this.f6a992d55, this.f2063c160);
        }
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        kYXiLQumLOsHGhdv(this);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            govwOxdxdTblSTqW(th);
        } else {
            this.f6b2ded51 = true;
            wGJOrgEdzjzOXUwP(this.fd0e45878, th);
        }
    }

    public void OnNext(U u) {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        rcAcfESNGiOUfdub(this);
        KPYccyiNjstoErBG(this);
    }
}

