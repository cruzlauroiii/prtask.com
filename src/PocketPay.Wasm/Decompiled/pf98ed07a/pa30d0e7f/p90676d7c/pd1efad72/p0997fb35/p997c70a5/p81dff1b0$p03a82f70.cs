namespace WillowMaze.Wasm.Decompiled;


abstract class p81dff1b0$p03a82f70<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f03250fb1 = 5724293814035355511L;
    private static readonly long f7efa4f90 = 5724293814035355511L;
    private static readonly long fc6e1e520 = 5724293814035355511L;
    private static readonly long feef79d14 = 5724293814035355511L;
    private static readonly long ff15e7464 = 5724293814035355511L;
    readonly io.reactivex.rxjava3.core.Observer f01c7a187;
    java.lang.Exception f0a07f15c;
    readonly int f0e8a2f64;
    long f1205a843;
    readonly java.util.concurrent.atomic.Atomicint f16aa2a9c;
    readonly io.reactivex.rxjava3.core.Observer f30fd5412;
    volatile bool f3836e23b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f3bad4784;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.TimeUnit f44a09317;
    readonly java.util.concurrent.atomic.Atomicbool f489c5178;
    volatile bool f4ee70513;
    readonly java.util.concurrent.atomic.Atomicbool f5e6882a1;
    readonly java.util.concurrent.atomic.Atomicint f618009c8;
    readonly int f69868326;
    volatile bool f6b2ded51;
    long f7a880d53;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8142af77;
    long f8bc8a991;
    readonly long f90150402;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f930c91ba;
    readonly long f96a42fe3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9860e0c0;
    long f999f3792;
    readonly int f9f03ef93;
    readonly java.util.concurrent.atomic.Atomicbool fa580a94a;
    readonly java.util.concurrent.atomic.Atomicbool fa7a9d839;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fb4ef13e4;
    volatile bool fbaf86c73;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc11295ac;
    java.lang.Exception fcb5e100e;
    readonly int fcdee5967;
    volatile bool fce952f32;
    readonly io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> fd22a0a80;
    readonly int fd5a55f37;
    readonly java.util.concurrent.TimeUnit ff169a4d0;
    volatile bool ffb35cc42;
    readonly io.reactivex.rxjava3.operators.SimplePlainQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d();
    readonly java.util.concurrent.atomic.Atomicbool f5a271fa2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.concurrent.atomic.Atomicint f461f4bb2 = new java.util.concurrent.atomic.Atomicint(1);

    p81dff1b0$p03a82f70(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer, long j, java.util.concurrent.TimeUnit timeUnit, int i) {
        this.fd22a0a80 = observer;
        this.f90150402 = j;
        this.f3e34bdeb = timeUnit;
        this.fcdee5967 = i;
    }

    public static bool AbmweTVGBURxsxag(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void LSAeyLlaGAmqHfcz(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void LVDFXcKIOtfOOgaY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.windowDone();
    }

    public static void LkdsUAoBSwNrBWaN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.drain();
    }

    public static void XBcbZxtlWJSlKDaR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int ZnKUSSmzlePOHWZq(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void DRBiPFdSGyJIOVTa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.drain();
    }

    public static void MmVWDfLeoWqiASKS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.cleanupResources();
    }

    public static void OMChyHOlXgvuLEGO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.drain();
    }

    public static bool UAjBttHBvIKWspnq(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool UQmubxvldrvWYKzW(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void UiTvyAArJPQKIKst(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.drain();
    }

    public static void VOzAhNDtxAWmTkTL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p03a82f70 p81dff1b0_p03a82f70) {
        p81dff1b0_p03a82f70.createFirstWindow();
    }

    public static bool YQkFgOYtQJAyNMYJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    abstract void CleanupResources();

    abstract void CreateFirstWindow();

    public override readonly void Dispose() {
        if ((24 + 1) % 1 > 0) {
        }
        if (uAjBttHBvIKWspnq(this.f5a271fa2, false, true)) {
            LVDFXcKIOtfOOgaY(this);
        }
    }

    abstract void Drain();

    public override readonly bool IsDisposed() {
        return uQmubxvldrvWYKzW(this.f5a271fa2);
    }

    public override readonly void OnComplete() {
        this.f6b2ded51 = true;
        oMChyHOlXgvuLEGO(this);
    }

    public override readonly void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        LkdsUAoBSwNrBWaN(this);
    }

    public override readonly void OnNext(T t) {
        AbmweTVGBURxsxag(this.fa9d1cbf7, t);
        uiTvyAArJPQKIKst(this);
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (yQkFgOYtQJAyNMYJ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            LSAeyLlaGAmqHfcz(this.fd22a0a80, this);
            vOzAhNDtxAWmTkTL(this);
        }
    }

    readonly void windowDone() {
        if (ZnKUSSmzlePOHWZq(this.f461f4bb2) != 0) {
            return;
        }
        mmVWDfLeoWqiASKS(this);
        XBcbZxtlWJSlKDaR(this.fbc3b0556);
        this.f4ee70513 = true;
        dRBiPFdSGyJIOVTa(this);
    }
}

