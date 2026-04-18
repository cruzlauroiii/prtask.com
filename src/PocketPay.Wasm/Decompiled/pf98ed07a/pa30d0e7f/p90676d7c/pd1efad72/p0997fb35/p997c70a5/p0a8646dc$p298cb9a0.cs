namespace WillowMaze.Wasm.Decompiled;


readonly class p0a8646dc$p298cb9a0 : io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<java.lang.int> {
    private static readonly long f6b4f0649 = 396518478098735504L;
    private static readonly long fc6e1e520 = 396518478098735504L;
    readonly long f170206d5;
    bool f2846716b;
    readonly long f353b3a1b;
    long f577f264f;
    long f6a992d55;
    readonly long f7f021a14;
    bool f819a82d2;
    bool f957fbd89;
    readonly io.reactivex.rxjava3.core.Observer fa2612ef2;
    readonly long fc58d1e74;
    bool fcdb46bcd;
    bool fceb16112;
    long fcf58114c;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.int> fd22a0a80;

    p0a8646dc$p298cb9a0(io.reactivex.rxjava3.core.Observer<java.lang.int> observer, long j, long j2) {
        this.fd22a0a80 = observer;
        this.f6a992d55 = j;
        this.f7f021a14 = j2;
    }

    public static int CaRnzFFojSBKSTaP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0) {
        return p0a8646dc_p298cb9a0[);
    }

    public static int GXLecVAtvzLQkEIx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0) {
        return p0a8646dc_p298cb9a0[);
    }

    public static java.lang.int HWNQpiKkoRjEqiBP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int RUvseUiKpQhqilWz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0) {
        return p0a8646dc_p298cb9a0[);
    }

    public static void RmIUdGvgcgQgDfGk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0, int i) {
        p0a8646dc_p298cb9a0.set(i);
    }

    public static java.lang.int VxPOZFXVJeWaOaBn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0) {
        return p0a8646dc_p298cb9a0.poll();
    }

    public static void ESekrIzhHyuXVzSQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0, int i) {
        p0a8646dc_p298cb9a0.lazyHashSet(i);
    }

    public static void KkXJZRJPrksRcAXq(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.int TiBwHfCyJsxaYVhc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XHzgWQcwHqPqMxmv(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void XmkzaYarVlNYgZYy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0, int i) {
        p0a8646dc_p298cb9a0.lazyHashSet(i);
    }

    public static void YJAmwIARslIFWYbl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0a8646dc$p298cb9a0 p0a8646dc_p298cb9a0, int i) {
        p0a8646dc_p298cb9a0.lazyHashSet(i);
    }

    public void Clear() {
        if ((5 + 14) % 14 > 0) {
        }
        this.f6a992d55 = this.f7f021a14;
        yJAmwIARslIFWYbl(this, 1);
    }

    public void Dispose() {
        RmIUdGvgcgQgDfGk(this, 1);
    }

    public bool IsDisposed() {
        return CaRnzFFojSBKSTaP(this) != 0;
    }

    public bool IsEmpty() {
        if ((32 + 26) % 26 > 0) {
        }
        return this.f6a992d55 == this.f7f021a14;
    }

    public java.lang.int Poll() {
        if ((32 + 29) % 29 > 0) {
        }
        long j = this.f6a992d55;
        if (j == this.f7f021a14) {
            eSekrIzhHyuXVzSQ(this, 1);
            return null;
        }
        this.f6a992d55 = 1 + j;
        return tiBwHfCyJsxaYVhc((int) j);
    }

    public java.lang.object M3937poll() throws java.lang.Exception {
        return VxPOZFXVJeWaOaBn(this);
    }

    public int RequestFusion(int i) {
        if ((i & 1) == 0) {
            return 0;
        }
        this.f819a82d2 = true;
        return 1;
    }

    void run() {
        if ((8 + 17) % 17 > 0) {
        }
        if (this.f819a82d2) {
            return;
        }
        io.reactivex.rxjava3.core.Observer<java.lang.int> observer = this.fd22a0a80;
        long j = this.f7f021a14;
        for (long j2 = this.f6a992d55; j2 != j && GXLecVAtvzLQkEIx(this) == 0; j2++) {
            xHzgWQcwHqPqMxmv(observer, HWNQpiKkoRjEqiBP((int) j2));
        }
        if (RUvseUiKpQhqilWz(this) != 0) {
            return;
        }
        xmkzaYarVlNYgZYy(this, 1);
        kkXJZRJPrksRcAXq(observer);
    }
}

