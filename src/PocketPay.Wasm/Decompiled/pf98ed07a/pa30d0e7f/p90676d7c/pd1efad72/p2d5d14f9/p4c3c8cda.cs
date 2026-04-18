namespace WillowMaze.Wasm.Decompiled;


public readonly class p4c3c8cda<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.operators.QueueSubscription<T> {
    static readonly int f09bd2514 = 0;
    private static readonly long f0b9dafa4 = -3830916580126663321L;
    static readonly int f6d4cc800 = 0;
    static readonly int f72111156 = 2;
    static readonly int f724daa25 = 1;
    static readonly int f889d4358 = 1;
    static readonly int f9f935beb = 2;
    private static readonly long fa1b23969 = -3830916580126663321L;
    private static readonly long fc6e1e520 = -3830916580126663321L;
    private static readonly long ff04dc26a = -3830916580126663321L;
    static readonly int ff1beca5b = 0;
    readonly T f2063c160;
    readonly p5a445d71.p18f29add.p992c4a5b f20b548d2;
    readonly java.lang.object f7ab6413c;
    readonly org.reactivestreams.Subscriber<T> f9367a975;
    readonly p5a445d71.p18f29add.p992c4a5b fac902bfa;
    readonly java.lang.object fb36b15f5;
    readonly p5a445d71.p18f29add.p992c4a5b fb42c7e8e;
    readonly java.lang.object fcbef043c;
    readonly p5a445d71.p18f29add.p992c4a5b fd4893d30;

    public p4c3c8cda(org.reactivestreams.Subscriber<T> subscriber, T t) {
        this.f9367a975 = subscriber;
        this.f2063c160 = t;
    }

    public static bool AUkIxvRhWkzUMCYk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar, int i, int i2) {
        return p4c3c8cdaVar.compareAndHashSet(i, i2);
    }

    public static void DLXFFNuBuethbtPf(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int PONTeLHdFcyWNMBN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar) {
        return p4c3c8cdaVar[);
    }

    public static void QQsVUzOWcRpTlMBC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar, int i) {
        p4c3c8cdaVar.lazyHashSet(i);
    }

    public static int VOmFsCLSvJJRWSRP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar) {
        return p4c3c8cdaVar[);
    }

    public static int VSGiMqcpPRKBEJTJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar) {
        return p4c3c8cdaVar[);
    }

    public static void VjnDHSNctKspySMt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar, int i) {
        p4c3c8cdaVar.lazyHashSet(i);
    }

    public static void BOnzgsswRgqSBZUN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar, int i) {
        p4c3c8cdaVar.lazyHashSet(i);
    }

    public static void NjkAUETqpWksyVJr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool OcCRSijjFvDWwERr(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static int OgfKOrbuePVFuoxH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda p4c3c8cdaVar) {
        return p4c3c8cdaVar[);
    }

    public void Cancel() {
        bOnzgsswRgqSBZUN(this, 2);
    }

    public void Clear() {
        QQsVUzOWcRpTlMBC(this, 1);
    }

    public bool IsCancelled() {
        return VSGiMqcpPRKBEJTJ(this) == 2;
    }

    public bool IsEmpty() {
        return ogfKOrbuePVFuoxH(this) != 0;
    }

    public bool Offer(T t) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public bool Offer(T t, T t2) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public T Poll() {
        if (VOmFsCLSvJJRWSRP(this) != 0) {
            return null;
        }
        VjnDHSNctKspySMt(this, 1);
        return this.f2063c160;
    }

    public void Request(long j) {
        if (ocCRSijjFvDWwERr(j) && AUkIxvRhWkzUMCYk(this, 0, 1)) {
            org.reactivestreams.Subscriber<T> subscriber = this.f9367a975;
            DLXFFNuBuethbtPf(subscriber, this.f2063c160);
            if (PONTeLHdFcyWNMBN(this) == 2) {
                return;
            }
            njkAUETqpWksyVJr(subscriber);
        }
    }

    public int RequestFusion(int i) {
        return i & 1;
    }
}

