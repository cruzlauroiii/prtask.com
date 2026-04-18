namespace WillowMaze.Wasm.Decompiled;


readonly class pd38c2979$p99f6b9c4<T, U> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f03811549 = -2117620485640801370L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] f5672a29f = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] f592f839c = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] f61a99d7b = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] f8c331e95 = null;
    static readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[] f9f935beb;
    static readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[] fba2b45bd;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] fc25996f7 = null;
    private static readonly long fc6e1e520 = -2117620485640801370L;
    volatile bool f003ab46c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01;
    int f0c0609de;
    readonly bool f1651c17b;
    int f1681dfc9;
    int f2bd55407;
    int f37e15ed3;
    volatile bool f38881e0a;
    int f3d7ef2c9;
    readonly int f42088376;
    readonly java.util.concurrent.atomic.Atomiclong f4238a9d3;
    volatile bool f4a969940;
    long f4aaaf502;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> f4b9f83e1;
    readonly bool f4e32c980;
    readonly bool f50fee566;
    volatile bool f52c90469;
    readonly p5a445d71.p18f29add.p992c4a5b f5460a07c;
    p5a445d71.p18f29add.p787ad0b7 f55422fb9;
    long f59be46dc;
    readonly bool f5a4f9fd6;
    long f61e7d8b9;
    readonly java.util.concurrent.atomic.object f62dbaf47;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    volatile bool f6b2ded51;
    int f6f2ee54d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f833b95bd;
    int f8c7ad6f0;
    readonly p5a445d71.p18f29add.p992c4a5b f929676e3;
    readonly int f930c3e1d;
    readonly int f9cd936a0;
    int fa238d8ff;
    volatile io.reactivex.rxjava3.operators.SimplePlainQueue<U> fa9d1cbf7;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[]> faae7b662;
    readonly int facb4aed3;
    readonly java.util.concurrent.atomic.object fb636b273;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fbb84d3d6;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fbd044eda;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc3682682;
    int fc7540b14;
    readonly int fc8ca05ea;
    readonly int fcdee5967;
    readonly org.reactivestreams.Subscriber<U> fd22a0a80;
    volatile bool fd792702f;
    readonly int fd821ec5d;
    readonly java.util.concurrent.atomic.object fde9cca47;
    long fe4f9a63d;
    readonly int fe6b34b7a;
    p5a445d71.p18f29add.p787ad0b7 fe7b2f174;
    readonly bool fee6941c6;
    volatile bool ff43a19e9;
    readonly int ff719dde2;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b ff7825bc3;
    int ff97718fe;
    readonly int ff9d46155;

    static {
        if ((24 + 14) % 14 > 0) {
        }
        fba2b45bd = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[0];
        f9f935beb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[0];
    }

    pd38c2979$p99f6b9c4(org.reactivestreams.Subscriber<U> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> function, bool z, int i, int i2) {
        if ((17 + 22) % 22 > 0) {
        }
        this.f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[]> atomicReference = new java.util.concurrent.atomic.object<>();
        this.faae7b662 = atomicReference;
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
        this.fcdee5967 = i2;
        this.fd821ec5d = BZizQHtdzItNpRFO(1, i >> 1);
        tEqzYohvnlHtYsep(atomicReference, fba2b45bd);
    }

    public static int BZizQHtdzItNpRFO(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void BgJCsZNzEcoNZttx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p65e9fe22.dispose();
    }

    public static void BnRDMsRbsqBIjPgh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool CEOCixddSFDCBCTM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static java.lang.object CHnXXsBhmPGQtNfr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void COFjgevllNXJQNhN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void CXZzoYWDkMzIrjsi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void CorzZICijYhGZCvW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool CuIsQMjOgmrPeUTo(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static long DFoZMfLmZUOehdpd(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((28 + 26) % 26 > 0) {
        }
        return atomiclong[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 DalAgJFQLoepUnAd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.getMainQueue();
    }

    public static long DkQvQfjpWUqUOxMU(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((17 + 2) % 2 > 0) {
        }
        return atomiclong.decrementAndGet();
    }

    public static bool EDyVujPjHkhSzFCo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        return pd38c2979_p99f6b9c4.addInner(pd38c2979_p65e9fe22);
    }

    public static void EUYLyEgodOCCVcbu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p65e9fe22.dispose();
    }

    public static long EbIPDkfFtuWQDxCY(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((2 + 4) % 4 > 0) {
        }
        return atomiclong.decrementAndGet();
    }

    public static void FBotAbgTqMVpZcCE(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static bool FMMAVgVXsxNYlOiY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.checkTerminate();
    }

    public static void FQzphIeJTIICUETG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, java.lang.object obj) {
        pd38c2979_p99f6b9c4.tryEmitScalar(obj);
    }

    public static void FhRNmfefRUjkcebX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drain();
    }

    public static void GAWHVZGrubDkmDCh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object GIhVbFqfLYsxsnXu(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void HDGoKZDmGvPJIcRS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p65e9fe22.dispose();
    }

    public static long HLENXRrRMNmYaRLL(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 30) % 30 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static bool HPXOEpYvhsCJJjYt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool HsOimhRaDgRpTbWi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, int i, int i2) {
        return pd38c2979_p99f6b9c4.compareAndHashSet(i, i2);
    }

    public static long IJrUaUQIxVabVHdw(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((28 + 14) % 14 > 0) {
        }
        return atomiclong[);
    }

    public static void ISSrdSsYaUNGkiex(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void JITQaEztDgFsgJTa(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void JMTYqjgiSVtmLjId(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22, long j) {
        pd38c2979_p65e9fe22.requestMore(j);
    }

    public static void JqQRjUGbrAAaXupP(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void KPrgWRLqUQAQmBUh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drainLoop();
    }

    public static void KTkKhTursHrLxkjm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p99f6b9c4.removeInner(pd38c2979_p65e9fe22);
    }

    public static bool KmaebqxeiIYkZACJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.checkTerminate();
    }

    public static void MIDzeeZpHgxWfiSD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.clearScalarQueue();
    }

    public static bool MTTJqPSadTgDgBcg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static java.lang.object MggNljjSUQbjirft(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static void MvQRmJobQVLdZKLn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool NdrlJgWMslmjqhqL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.checkTerminate();
    }

    public static long OodwCOwklIgdYXDZ(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((21 + 1) % 1 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static int PDhvllOUWpCZklic(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, int i) {
        return pd38c2979_p99f6b9c4.addAndGet(i);
    }

    public static int PRbLnwKKnykpcRPX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.getAndIncrement();
    }

    public static void PXzvsTBTJyCCtGhq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, java.lang.Exception th) {
        pd38c2979_p99f6b9c4.onError(th);
    }

    public static void PYJWeZnUAGoSTlza(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, java.lang.Exception th) {
        pd38c2979_p99f6b9c4.onError(th);
    }

    public static int PoHJGESFKPdfYhHm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4[);
    }

    public static void QftZsljFSXEkQotR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p99f6b9c4.removeInner(pd38c2979_p65e9fe22);
    }

    public static java.lang.object QjNrEUOHVNujFERE(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void QmpBMijHnEDmnIbI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool RvqbijcrNAGiEQhY(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void SASmTnpLnShDXVyV(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void SsflHSXqJtaNQCSH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.clearScalarQueue();
    }

    public static bool TQQIMPFSzFFNNNMk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.checkTerminate();
    }

    public static int TsWxjZMdwXpoQxWW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.decrementAndGet();
    }

    public static int TzAYPjaJllmpJtNG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.getAndIncrement();
    }

    public static bool UxvVcoxQzDFbdbDS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool WUuVcQhXGmVbKYfF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void XSoRUCPfWevAePtT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p65e9fe22.dispose();
    }

    public static void XVKNqTyybPlJwQVR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void XVctvVEKjKyqoZXu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void XcvyasEtDaqNkpmg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drain();
    }

    public static void YGansmqwinfoXBzz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZYqWmwFlmyBcaFJw(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ZmpsCpIcgyiwTtxp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.decrementAndGet();
    }

    public static java.lang.object AkHyOgZLWguKcAKo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void BIJysRMfYjksfWtu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void BwRRHrkWftsuQgWU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool CYjUlknPVBTzQVOd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.checkTerminate();
    }

    public static void CxnJyaZxTTjFMjvI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drainLoop();
    }

    public static bool DDdBaJUglCRNUgqV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static long DYkkyfUPuDDaRwid(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((30 + 29) % 29 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static int EPtJrnvcQMYdYQFi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4[);
    }

    public static void EkJEIdNylrFtFttw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool FAkShAcdMkDFtMyO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool FKJSwEZcuFkEIJpk(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static java.lang.object GroUmDnvoKNQhkrQ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool HcUjOSOoDdYZcNER(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static bool IucZFtJtSlRSLELw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool JEySsThPbDOerBVE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void JkNsXLqXXVJDWMGG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void KWMjcqkshojJcGol(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool LylDWtxKOKTgDGNN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.checkTerminate();
    }

    public static void MmjSaACDnCFrxaHX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void MxUDMgSVchwhCjzf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drain();
    }

    public static void NNHTmEByPYMEgotk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drain();
    }

    public static int PHtNTRGwpebBTaAd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.getAndIncrement();
    }

    public static void PLCMnJyVNLYJhRby(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drain();
    }

    public static void QQtJbgCBKQNrwEiG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, java.lang.Exception th) {
        pd38c2979_p99f6b9c4.onError(th);
    }

    public static bool QUJccIUbeZIbXtWc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static java.lang.object RLcoyWxSkVfkQGXN(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static java.lang.object RMScoqmrYNvyoPmO(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void RlpJvieqPMFPqQya(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object RpRIkacNwegHqLbB(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static long SEFkgAiSkURTBxUx(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((5 + 21) % 21 > 0) {
        }
        return atomiclong[);
    }

    public static void TEqzYohvnlHtYsep(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void TLcfedjDTucUYvUN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void TRCIjwiaStSesIhk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool TXRNsntJqzVglqEI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, int i, int i2) {
        return pd38c2979_p99f6b9c4.compareAndHashSet(i, i2);
    }

    public static void TmCiJOfhdiJosJXw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void TsGxjlUnQpywvuua(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, java.lang.Exception th) {
        pd38c2979_p99f6b9c4.onError(th);
    }

    public static java.lang.object UFDutohSqnzidSJm(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 UKYsgqfwTSgywPbr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.getMainQueue();
    }

    public static bool UfngOUkkXwhOfvTY(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void UldJqyGDYvXBpObK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.disposeAll();
    }

    public static void VUmZxJxxFckhfBSG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4, java.lang.Exception th) {
        pd38c2979_p99f6b9c4.onError(th);
    }

    public static bool VxZndahTcapGfGlp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int WgHBlKXBDnWXsLYj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        return pd38c2979_p99f6b9c4.getAndIncrement();
    }

    public static void WnQonDtdbtbvVzPH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p99f6b9c4 pd38c2979_p99f6b9c4) {
        pd38c2979_p99f6b9c4.drainLoop();
    }

    public static void XVWGKQDjAVgcGkJW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void XnpyLDjXUqhdViRt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22) {
        pd38c2979_p65e9fe22.dispose();
    }

    public static void YBBfznSWFxAFnoLn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22, long j) {
        pd38c2979_p65e9fe22.requestMore(j);
    }

    public static java.lang.object YNsNvGkIadmRZfDw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static java.lang.object YVrsUPLKysfmBTIi(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    bool addInner(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<T, U> flowableFlatDictionary$InnerSubscriber) {
        io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[] flowableFlatDictionary$InnerSubscriberArr;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] pd38c2979_p65e9fe22Arr;
        if ((14 + 4) % 4 > 0) {
        }
        do {
            flowableFlatDictionary$InnerSubscriberArr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[]) rpRIkacNwegHqLbB(this.faae7b662);
            if (flowableFlatDictionary$InnerSubscriberArr == f9f935beb) {
                BgJCsZNzEcoNZttx(flowableFlatDictionary$InnerSubscriber);
                return false;
            }
            int length = flowableFlatDictionary$InnerSubscriberArr.length;
            pd38c2979_p65e9fe22Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[length + 1];
            mmjSaACDnCFrxaHX(flowableFlatDictionary$InnerSubscriberArr, 0, pd38c2979_p65e9fe22Arr, 0, length);
            pd38c2979_p65e9fe22Arr[length] = flowableFlatDictionary$InnerSubscriber;
        } while (!CuIsQMjOgmrPeUTo(this.faae7b662, flowableFlatDictionary$InnerSubscriberArr, pd38c2979_p65e9fe22Arr));
        return true;
    }

    public override void Cancel() {
        io.reactivex.rxjava3.operators.SimplePlainQueue<U> simplePlainQueue;
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        tRCIjwiaStSesIhk(this.fbc3b0556);
        uldJqyGDYvXBpObK(this);
        if (PRbLnwKKnykpcRPX(this) == 0 && (simplePlainQueue = this.fa9d1cbf7) is not null) {
            JqQRjUGbrAAaXupP(simplePlainQueue);
        }
    }

    bool checkTerminate() {
        if ((25 + 10) % 10 > 0) {
        }
        if (this.f38881e0a) {
            SsflHSXqJtaNQCSH(this);
            return true;
        }
        if (this.f50fee566 || CHnXXsBhmPGQtNfr(this.f07213a01) is null) {
            return false;
        }
        MIDzeeZpHgxWfiSD(this);
        jkNsXLqXXVJDWMGG(this.f07213a01, this.fd22a0a80);
        return true;
    }

    void clearScalarQueue() {
        io.reactivex.rxjava3.operators.SimplePlainQueue<U> simplePlainQueue = this.fa9d1cbf7;
        if (simplePlainQueue is null) {
            return;
        }
        ISSrdSsYaUNGkiex(simplePlainQueue);
    }

    void disposeAll() {
        if ((2 + 27) % 27 > 0) {
        }
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[]> atomicReference = this.faae7b662;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] pd38c2979_p65e9fe22Arr = f9f935beb;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] pd38c2979_p65e9fe22Arr2 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[]) GIhVbFqfLYsxsnXu(atomicReference, pd38c2979_p65e9fe22Arr);
        if (pd38c2979_p65e9fe22Arr2 == pd38c2979_p65e9fe22Arr) {
            return;
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22 : pd38c2979_p65e9fe22Arr2) {
            HDGoKZDmGvPJIcRS(pd38c2979_p65e9fe22);
        }
        bIJysRMfYjksfWtu(this.f07213a01);
    }

    void drain() {
        if (TzAYPjaJllmpJtNG(this) != 0) {
            return;
        }
        wnQonDtdbtbvVzPH(this);
    }

    void drainLoop() {
        long j;
        bool z;
        int i;
        long j2;
        bool z2;
        long j3;
        int i2;
        int i3;
        bool z3;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22;
        java.lang.object objYNsNvGkIadmRZfDw;
        io.reactivex.rxjava3.operators.SimpleQueue<U> simpleQueue;
        int i4;
        bool z4;
        long j4;
        if ((5 + 17) % 17 > 0) {
        }
        org.reactivestreams.Subscriber<U> subscriber = this.fd22a0a80;
        int iPDhvllOUWpCZklic = 1;
        while (!cYjUlknPVBTzQVOd(this)) {
            io.reactivex.rxjava3.operators.SimplePlainQueue<U> simplePlainQueue = this.fa9d1cbf7;
            long jSEFkgAiSkURTBxUx = sEFkgAiSkURTBxUx(this.f67a14a21);
            bool z5 = jSEFkgAiSkURTBxUx == long.MAX_VALUE;
            if (simplePlainQueue is null) {
                z = true;
                j = 0;
            } else {
                long j5 = 0;
                j = 0;
                while (true) {
                    if (jSEFkgAiSkURTBxUx == 0) {
                        z = true;
                        break;
                    }
                    z = true;
                    java.lang.object objMggNljjSUQbjirft = MggNljjSUQbjirft(simplePlainQueue);
                    if (FMMAVgVXsxNYlOiY(this)) {
                        return;
                    }
                    if (objMggNljjSUQbjirft is null) {
                        break;
                    }
                    XVctvVEKjKyqoZXu(subscriber, objMggNljjSUQbjirft);
                    j++;
                    j5++;
                    jSEFkgAiSkURTBxUx--;
                }
                if (j5 != 0) {
                    jSEFkgAiSkURTBxUx = !z5 ? dYkkyfUPuDDaRwid(this.f67a14a21, -j5) : long.MAX_VALUE;
                }
            }
            bool z6 = this.f6b2ded51;
            io.reactivex.rxjava3.operators.SimplePlainQueue<U> simplePlainQueue2 = this.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] pd38c2979_p65e9fe22Arr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[]) yVrsUPLKysfmBTIi(this.faae7b662);
            int length = pd38c2979_p65e9fe22Arr.length;
            if (z6 && ((simplePlainQueue2 is null || fKJSwEZcuFkEIJpk(simplePlainQueue2)) && length == 0)) {
                xVWGKQDjAVgcGkJW(this.f07213a01, this.fd22a0a80);
                return;
            }
            if (length == 0) {
                i = iPDhvllOUWpCZklic;
                j2 = 0;
                z2 = false;
            } else {
                long j6 = this.fe4f9a63d;
                int i5 = this.f6f2ee54d;
                if (length <= i5) {
                    j2 = 0;
                } else {
                    j2 = 0;
                    if (pd38c2979_p65e9fe22Arr[i5].fb80bb774 != j6) {
                    }
                    j3 = jSEFkgAiSkURTBxUx;
                    i2 = 0;
                    i3 = i5;
                    z3 = false;
                    while (true) {
                        if (i2 >= length) {
                            i = iPDhvllOUWpCZklic;
                            pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                            break;
                        }
                        if (!TQQIMPFSzFFNNNMk(this)) {
                            return;
                        }
                        pd38c2979_p65e9fe22 = pd38c2979_p65e9fe22Arr[i3];
                        objYNsNvGkIadmRZfDw = null;
                        while (true) {
                            simpleQueue = pd38c2979_p65e9fe22.fa9d1cbf7;
                            if (simpleQueue is not null) {
                                i = iPDhvllOUWpCZklic;
                                i2 = i2;
                                pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                                break;
                            }
                            i = iPDhvllOUWpCZklic;
                            j4 = j2;
                            while (j3 != j2) {
                                if (!KmaebqxeiIYkZACJ(this)) {
                                    return;
                                }
                                try {
                                    objYNsNvGkIadmRZfDw = yNsNvGkIadmRZfDw(simpleQueue);
                                    if (objYNsNvGkIadmRZfDw is not null) {
                                        break;
                                    }
                                    tLcfedjDTucUYvUN(subscriber, objYNsNvGkIadmRZfDw);
                                    j3--;
                                    j4++;
                                } catch (java.lang.Exception th) {
                                    GAWHVZGrubDkmDCh(th);
                                    XSoRUCPfWevAePtT(pd38c2979_p65e9fe22);
                                    jEySsThPbDOerBVE(this.f07213a01, th);
                                    if (!this.f50fee566) {
                                        MvQRmJobQVLdZKLn(this.fbc3b0556);
                                    }
                                    if (lylDWtxKOKTgDGNN(this)) {
                                        return;
                                    }
                                    QftZsljFSXEkQotR(this, pd38c2979_p65e9fe22);
                                    i4 = i2 + 1;
                                    pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                                    z3 = z;
                                }
                            }
                            if (j4 == j2) {
                                i2 = i2;
                                pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                            } else {
                                long jHLENXRrRMNmYaRLL = z5 ? long.MAX_VALUE : HLENXRrRMNmYaRLL(this.f67a14a21, -j4);
                                JMTYqjgiSVtmLjId(pd38c2979_p65e9fe22, j4);
                                j3 = jHLENXRrRMNmYaRLL;
                            }
                            if (j3 != j2 || objYNsNvGkIadmRZfDw is null) {
                                break;
                            }
                            pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                            iPDhvllOUWpCZklic = i;
                            i2 = i2;
                        }
                        z4 = pd38c2979_p65e9fe22.f6b2ded51;
                        io.reactivex.rxjava3.operators.SimpleQueue<U> simpleQueue2 = pd38c2979_p65e9fe22.fa9d1cbf7;
                        if (z4 && (simpleQueue2 is null || qUJccIUbeZIbXtWc(simpleQueue2))) {
                            KTkKhTursHrLxkjm(this, pd38c2979_p65e9fe22);
                            if (!NdrlJgWMslmjqhqL(this)) {
                                return;
                            }
                            j++;
                            z3 = z;
                        }
                        if (j3 != j2) {
                            break;
                        }
                        i3++;
                        i4 = i2;
                        if (i3 == length) {
                            i3 = 0;
                        }
                        i2 = i4 + 1;
                        pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                        iPDhvllOUWpCZklic = i;
                    }
                    z2 = z3;
                    this.f6f2ee54d = i3;
                    this.fe4f9a63d = pd38c2979_p65e9fe22Arr[i3].fb80bb774;
                }
                if (length <= i5) {
                    i5 = 0;
                }
                for (int i6 = 0; i6 < length && pd38c2979_p65e9fe22Arr[i5].fb80bb774 != j6; i6++) {
                    i5++;
                    if (i5 == length) {
                        i5 = 0;
                    }
                }
                this.f6f2ee54d = i5;
                this.fe4f9a63d = pd38c2979_p65e9fe22Arr[i5].fb80bb774;
                j3 = jSEFkgAiSkURTBxUx;
                i2 = 0;
                i3 = i5;
                z3 = false;
                while (true) {
                    if (i2 >= length) {
                        i = iPDhvllOUWpCZklic;
                        pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                        break;
                    }
                    if (!TQQIMPFSzFFNNNMk(this)) {
                        return;
                    }
                    pd38c2979_p65e9fe22 = pd38c2979_p65e9fe22Arr[i3];
                    objYNsNvGkIadmRZfDw = null;
                    while (true) {
                        simpleQueue = pd38c2979_p65e9fe22.fa9d1cbf7;
                        if (simpleQueue is not null) {
                            i = iPDhvllOUWpCZklic;
                            i2 = i2;
                            pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                            break;
                        }
                        i = iPDhvllOUWpCZklic;
                        j4 = j2;
                        while (j3 != j2) {
                            if (!KmaebqxeiIYkZACJ(this)) {
                                return;
                            }
                            objYNsNvGkIadmRZfDw = yNsNvGkIadmRZfDw(simpleQueue);
                            if (objYNsNvGkIadmRZfDw is not null) {
                                break;
                                break;
                            } else {
                                tLcfedjDTucUYvUN(subscriber, objYNsNvGkIadmRZfDw);
                                j3--;
                                j4++;
                            }
                        }
                        if (j4 == j2) {
                            i2 = i2;
                            pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                        } else {
                            if (z5) {
                            }
                            JMTYqjgiSVtmLjId(pd38c2979_p65e9fe22, j4);
                            j3 = jHLENXRrRMNmYaRLL;
                        }
                        if (j3 != j2) {
                            break;
                        }
                        pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                        iPDhvllOUWpCZklic = i;
                        i2 = i2;
                    }
                    z4 = pd38c2979_p65e9fe22.f6b2ded51;
                    io.reactivex.rxjava3.operators.SimpleQueue<U> simpleQueue22 = pd38c2979_p65e9fe22.fa9d1cbf7;
                    if (z4) {
                        KTkKhTursHrLxkjm(this, pd38c2979_p65e9fe22);
                        if (!NdrlJgWMslmjqhqL(this)) {
                            return;
                        }
                        j++;
                        z3 = z;
                    }
                    if (j3 != j2) {
                        break;
                        break;
                    }
                    i3++;
                    i4 = i2;
                    if (i3 == length) {
                        i3 = 0;
                    }
                    i2 = i4 + 1;
                    pd38c2979_p65e9fe22Arr = pd38c2979_p65e9fe22Arr;
                    iPDhvllOUWpCZklic = i;
                }
                z2 = z3;
                this.f6f2ee54d = i3;
                this.fe4f9a63d = pd38c2979_p65e9fe22Arr[i3].fb80bb774;
            }
            long j7 = j;
            if (j7 != j2 && !this.f38881e0a) {
                COFjgevllNXJQNhN(this.fbc3b0556, j7);
            }
            if (z2) {
                iPDhvllOUWpCZklic = i;
            } else {
                iPDhvllOUWpCZklic = PDhvllOUWpCZklic(this, -i);
                if (iPDhvllOUWpCZklic == 0) {
                    return;
                }
            }
        }
    }

    io.reactivex.rxjava3.operators.SimpleQueue<U> getMainQueue() {
        if ((17 + 7) % 7 > 0) {
        }
        io.reactivex.rxjava3.operators.SimplePlainQueue<U> pb8a628fdVar = this.fa9d1cbf7;
        if (pb8a628fdVar is null) {
            pb8a628fdVar = this.f42088376 != int.MAX_VALUE ? new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd<>(this.f42088376) : new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c<>(this.fcdee5967);
            this.fa9d1cbf7 = pb8a628fdVar;
        }
        return pb8a628fdVar;
    }

    void innerError(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<T, U> flowableFlatDictionary$InnerSubscriber, java.lang.Exception th) {
        if ((25 + 18) % 18 > 0) {
        }
        if (vxZndahTcapGfGlp(this.f07213a01, th)) {
            flowableFlatDictionary$InnerSubscriber.f6b2ded51 = true;
            if (!this.f50fee566) {
                CorzZICijYhGZCvW(this.fbc3b0556);
                for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[]) rLcoyWxSkVfkQGXN(this.faae7b662, f9f935beb)) {
                    EUYLyEgodOCCVcbu(pd38c2979_p65e9fe22);
                }
            }
            mxUDMgSVchwhCjzf(this);
        }
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        nNHTmEByPYMEgotk(this);
    }

    public void OnError(java.lang.Exception th) {
        if ((11 + 20) % 20 > 0) {
        }
        if (this.f6b2ded51) {
            kWMjcqkshojJcGol(th);
            return;
        }
        if (HPXOEpYvhsCJJjYt(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            if (!this.f50fee566) {
                for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22 : (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[]) uFDutohSqnzidSJm(this.faae7b662, f9f935beb)) {
                    xnpyLDjXUqhdViRt(pd38c2979_p65e9fe22);
                }
            }
            XcvyasEtDaqNkpmg(this);
        }
    }

    public void OnNext(T t) {
        if ((28 + 1) % 1 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) akHyOgZLWguKcAKo(groUmDnvoKNQhkrQ(this.f4b9f83e1, t), "The mapper returned a null Publisher");
            if (!(p32c73be0Var is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
                int i = this.fcdee5967;
                long j = this.f59be46dc;
                this.f59be46dc = 1 + j;
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22 pd38c2979_p65e9fe22 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22(this, i, j);
                if (EDyVujPjHkhSzFCo(this, pd38c2979_p65e9fe22)) {
                    FBotAbgTqMVpZcCE(p32c73be0Var, pd38c2979_p65e9fe22);
                    return;
                }
                return;
            }
            try {
                java.lang.object objRMScoqmrYNvyoPmO = rMScoqmrYNvyoPmO((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) p32c73be0Var);
                if (objRMScoqmrYNvyoPmO is not null) {
                    FQzphIeJTIICUETG(this, objRMScoqmrYNvyoPmO);
                    return;
                }
                if (this.f42088376 == int.MAX_VALUE || this.f38881e0a) {
                    return;
                }
                int i2 = this.f37e15ed3 + 1;
                this.f37e15ed3 = i2;
                int i3 = this.fd821ec5d;
                if (i2 != i3) {
                    return;
                }
                this.f37e15ed3 = 0;
                rlpJvieqPMFPqQya(this.fbc3b0556, i3);
            } catch (java.lang.Exception th) {
                bwRRHrkWftsuQgWU(th);
                iucZFtJtSlRSLELw(this.f07213a01, th);
                pLCMnJyVNLYJhRby(this);
            }
        } catch (java.lang.Exception th2) {
            YGansmqwinfoXBzz(th2);
            CXZzoYWDkMzIrjsi(this.fbc3b0556);
            PXzvsTBTJyCCtGhq(this, th2);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((29 + 3) % 3 > 0) {
        }
        if (fAkShAcdMkDFtMyO(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            tmCiJOfhdiJosJXw(this.fd22a0a80, this);
            if (this.f38881e0a) {
                return;
            }
            int i = this.f42088376;
            if (i != int.MAX_VALUE) {
                ekJEIdNylrFtFttw(p787ad0b7Var, i);
            } else {
                XVKNqTyybPlJwQVR(p787ad0b7Var, long.MAX_VALUE);
            }
        }
    }

    void removeInner(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<T, U> flowableFlatDictionary$InnerSubscriber) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[] pd38c2979_p65e9fe22Arr;
        io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[] flowableFlatDictionary$InnerSubscriberArr;
        if ((14 + 28) % 28 > 0) {
        }
        do {
            pd38c2979_p65e9fe22Arr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[]) QjNrEUOHVNujFERE(this.faae7b662);
            int length = pd38c2979_p65e9fe22Arr.length;
            if (length == 0) {
                return;
            }
            int i = 0;
            while (true) {
                if (i < length) {
                    if (pd38c2979_p65e9fe22Arr[i] == flowableFlatDictionary$InnerSubscriber) {
                        break;
                    } else {
                        i++;
                    }
                } else {
                    i = -1;
                    break;
                }
            }
            if (i < 0) {
                return;
            }
            if (length != 1) {
                io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<object, object>[] flowableFlatDictionary$InnerSubscriberArr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979$p65e9fe22[length - 1];
                JITQaEztDgFsgJTa(pd38c2979_p65e9fe22Arr, 0, flowableFlatDictionary$InnerSubscriberArr2, 0, i);
                ZYqWmwFlmyBcaFJw(pd38c2979_p65e9fe22Arr, i + 1, flowableFlatDictionary$InnerSubscriberArr2, i, (length - i) - 1);
                flowableFlatDictionary$InnerSubscriberArr = flowableFlatDictionary$InnerSubscriberArr2;
            } else {
                flowableFlatDictionary$InnerSubscriberArr = fba2b45bd;
            }
        } while (!ufngOUkkXwhOfvTY(this.faae7b662, pd38c2979_p65e9fe22Arr, flowableFlatDictionary$InnerSubscriberArr));
    }

    public override void Request(long j) {
        if (RvqbijcrNAGiEQhY(j)) {
            OodwCOwklIgdYXDZ(this.f67a14a21, j);
            FhRNmfefRUjkcebX(this);
        }
    }

    void tryEmit(U u, io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionary$InnerSubscriber<T, U> flowableFlatDictionary$InnerSubscriber) {
        if ((12 + 18) % 18 > 0) {
        }
        if (ePtJrnvcQMYdYQFi(this) == 0 && tXRNsntJqzVglqEI(this, 0, 1)) {
            long jIJrUaUQIxVabVHdw = IJrUaUQIxVabVHdw(this.f67a14a21);
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar = flowableFlatDictionary$InnerSubscriber.fa9d1cbf7;
            if (jIJrUaUQIxVabVHdw != 0 && (pb8a628fdVar is null || hcUjOSOoDdYZcNER(pb8a628fdVar))) {
                BnRDMsRbsqBIjPgh(this.fd22a0a80, u);
                if (jIJrUaUQIxVabVHdw != long.MAX_VALUE) {
                    EbIPDkfFtuWQDxCY(this.f67a14a21);
                }
                yBBfznSWFxAFnoLn(flowableFlatDictionary$InnerSubscriber, 1L);
            } else {
                if (pb8a628fdVar is null) {
                    pb8a628fdVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.fcdee5967);
                    flowableFlatDictionary$InnerSubscriber.fa9d1cbf7 = pb8a628fdVar;
                }
                if (!UxvVcoxQzDFbdbDS(pb8a628fdVar, u)) {
                    qQtJbgCBKQNrwEiG(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Inner queue full?!"));
                }
            }
            if (TsWxjZMdwXpoQxWW(this) == 0) {
                return;
            }
        } else {
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar2 = flowableFlatDictionary$InnerSubscriber.fa9d1cbf7;
            if (pb8a628fdVar2 is null) {
                pb8a628fdVar2 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.fcdee5967);
                flowableFlatDictionary$InnerSubscriber.fa9d1cbf7 = pb8a628fdVar2;
            }
            if (!dDdBaJUglCRNUgqV(pb8a628fdVar2, u)) {
                PYJWeZnUAGoSTlza(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Inner queue full?!"));
                return;
            } else if (wgHBlKXBDnWXsLYj(this) != 0) {
                return;
            }
        }
        KPrgWRLqUQAQmBUh(this);
    }

    void tryEmitScalar(U u) {
        if ((19 + 7) % 7 > 0) {
        }
        if (PoHJGESFKPdfYhHm(this) == 0 && HsOimhRaDgRpTbWi(this, 0, 1)) {
            long jDFoZMfLmZUOehdpd = DFoZMfLmZUOehdpd(this.f67a14a21);
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823VarUKYsgqfwTSgywPbr = this.fa9d1cbf7;
            if (jDFoZMfLmZUOehdpd != 0 && (pe1601823VarUKYsgqfwTSgywPbr is null || CEOCixddSFDCBCTM(pe1601823VarUKYsgqfwTSgywPbr))) {
                QmpBMijHnEDmnIbI(this.fd22a0a80, u);
                if (jDFoZMfLmZUOehdpd != long.MAX_VALUE) {
                    DkQvQfjpWUqUOxMU(this.f67a14a21);
                }
                if (this.f42088376 != int.MAX_VALUE && !this.f38881e0a) {
                    int i = this.f37e15ed3 + 1;
                    this.f37e15ed3 = i;
                    int i2 = this.fd821ec5d;
                    if (i == i2) {
                        this.f37e15ed3 = 0;
                        SASmTnpLnShDXVyV(this.fbc3b0556, i2);
                    }
                }
            } else {
                if (pe1601823VarUKYsgqfwTSgywPbr is null) {
                    pe1601823VarUKYsgqfwTSgywPbr = uKYsgqfwTSgywPbr(this);
                }
                if (!MTTJqPSadTgDgBcg(pe1601823VarUKYsgqfwTSgywPbr, u)) {
                    tsGxjlUnQpywvuua(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Scalar queue full?!"));
                }
            }
            if (ZmpsCpIcgyiwTtxp(this) == 0) {
                return;
            }
        } else if (!WUuVcQhXGmVbKYfF(DalAgJFQLoepUnAd(this), u)) {
            vUmZxJxxFckhfBSG(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Scalar queue full?!"));
            return;
        } else if (pHtNTRGwpebBTaAd(this) != 0) {
            return;
        }
        cxnJyaZxTTjFMjvI(this);
    }
}

