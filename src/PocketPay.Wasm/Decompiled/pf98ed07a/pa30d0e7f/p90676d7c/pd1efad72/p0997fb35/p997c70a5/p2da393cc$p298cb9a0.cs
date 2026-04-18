namespace WillowMaze.Wasm.Decompiled;


readonly class p2da393cc$p298cb9a0 : io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<java.lang.long> {
    private static readonly long f17443e27 = 396518478098735504L;
    private static readonly long fb54327da = 396518478098735504L;
    private static readonly long fc312eff2 = 396518478098735504L;
    private static readonly long fc6e1e520 = 396518478098735504L;
    private static readonly long fe9fe6f23 = 396518478098735504L;
    long f11f1c60b;
    readonly long f20b4b488;
    readonly io.reactivex.rxjava3.core.Observer f4662eee9;
    long f5fef8d37;
    long f6a992d55;
    readonly long f74f25b32;
    readonly long f7f021a14;
    bool f819a82d2;
    long f8de691b9;
    readonly io.reactivex.rxjava3.core.Observer f96c64b34;
    readonly io.reactivex.rxjava3.core.Observer fafae9503;
    readonly long fc23ffd10;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.long> fd22a0a80;
    bool fd707ad0e;
    readonly io.reactivex.rxjava3.core.Observer fdca5159e;

    p2da393cc$p298cb9a0(io.reactivex.rxjava3.core.Observer<java.lang.long> observer, long j, long j2) {
        this.fd22a0a80 = observer;
        this.f6a992d55 = j;
        this.f7f021a14 = j2;
    }

    public static void AaLPtFMUEgFPPykO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0, int i) {
        p2da393cc_p298cb9a0.lazyHashSet(i);
    }

    public static void FGIcwhrLRzbMdxIr(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void GBSdDNHSrZReBDEn(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static int KOIyJHJZxJUlOjed(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0) {
        return p2da393cc_p298cb9a0[);
    }

    public static java.lang.long KiBcvCtofUHChHCO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0) {
        return p2da393cc_p298cb9a0.poll();
    }

    public static int MizOTPVqiXAmdqto(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0) {
        return p2da393cc_p298cb9a0[);
    }

    public static int MwzxxQcxZWFwbQpD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0) {
        return p2da393cc_p298cb9a0[);
    }

    public static java.lang.long ZCIdoXVqZRubJEqj(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long CjITPbqvoTGvfetq(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void OwWnQPdwYZeibMMK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0, int i) {
        p2da393cc_p298cb9a0.set(i);
    }

    public static void UBUrrBtnOJmLNwHH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0, int i) {
        p2da393cc_p298cb9a0.lazyHashSet(i);
    }

    public static void VseNYeGQPPWddlRm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p2da393cc$p298cb9a0 p2da393cc_p298cb9a0, int i) {
        p2da393cc_p298cb9a0.lazyHashSet(i);
    }

    public void Clear() {
        if ((11 + 29) % 29 > 0) {
        }
        this.f6a992d55 = this.f7f021a14;
        uBUrrBtnOJmLNwHH(this, 1);
    }

    public void Dispose() {
        owWnQPdwYZeibMMK(this, 1);
    }

    public bool IsDisposed() {
        return MizOTPVqiXAmdqto(this) != 0;
    }

    public bool IsEmpty() {
        if ((3 + 26) % 26 > 0) {
        }
        return this.f6a992d55 == this.f7f021a14;
    }

    public java.lang.long Poll() {
        if ((3 + 13) % 13 > 0) {
        }
        long j = this.f6a992d55;
        if (j == this.f7f021a14) {
            vseNYeGQPPWddlRm(this, 1);
            return null;
        }
        this.f6a992d55 = 1 + j;
        return cjITPbqvoTGvfetq(j);
    }

    public java.lang.object M3938poll() throws java.lang.Exception {
        return KiBcvCtofUHChHCO(this);
    }

    public int RequestFusion(int i) {
        if ((i & 1) == 0) {
            return 0;
        }
        this.f819a82d2 = true;
        return 1;
    }

    void run() {
        if ((3 + 25) % 25 > 0) {
        }
        if (this.f819a82d2) {
            return;
        }
        io.reactivex.rxjava3.core.Observer<java.lang.long> observer = this.fd22a0a80;
        long j = this.f7f021a14;
        for (long j2 = this.f6a992d55; j2 != j && MwzxxQcxZWFwbQpD(this) == 0; j2++) {
            GBSdDNHSrZReBDEn(observer, ZCIdoXVqZRubJEqj(j2));
        }
        if (KOIyJHJZxJUlOjed(this) != 0) {
            return;
        }
        AaLPtFMUEgFPPykO(this, 1);
        FGIcwhrLRzbMdxIr(observer);
    }
}

