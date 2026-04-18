namespace WillowMaze.Wasm.Decompiled;


readonly class p5293a861$pcbceec22<T, R> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fb710ac19 = -5556924161382950569L;
    private static readonly long fc6e1e520 = -5556924161382950569L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07[] f1c22c01a;
    readonly io.reactivex.rxjava3.core.MaybeObserver f283fd5c2;
    java.lang.object[] f2bb1439d;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    java.lang.object[] f449f1f48;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeZipArray$ZipMaybeObserver<T>[] f6ea648a6;
    readonly io.reactivex.rxjava3.core.MaybeObserver f86868a43;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07[] f8bce010b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa0cd2a84;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc1cee8ab;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdba03838;
    java.lang.object[] fde94064e;
    java.lang.object[] fe473ddaa;
    readonly io.reactivex.rxjava3.core.MaybeObserver fedddd17f;
    java.lang.object[] ff09cc7ee;

    p5293a861$pcbceec22(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, int i, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function) {
        super(i);
        this.fd22a0a80 = maybeObserver;
        this.f3298b476 = function;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07[] p5293a861_ped11fd07Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07[i];
        for (int i2 = 0; i2 < i; i2++) {
            p5293a861_ped11fd07Arr[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07(this, i2);
        }
        this.f6ea648a6 = p5293a861_ped11fd07Arr;
        this.ff09cc7ee = new java.lang.object[i];
    }

    public static void EHljgDoePBmYDkTu(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void EXGYKCDWbAMxwXki(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07 p5293a861_ped11fd07) {
        p5293a861_ped11fd07.dispose();
    }

    public static java.lang.object FVdEqXWIezUWfxGf(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void LqchGlVuorVxVwkz(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static java.lang.object MofrJWgqxAWibzXk(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void OpTtgHiDKGpiIqdI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, int i) {
        p5293a861_pcbceec22.disposeExcept(i);
    }

    public static void RneNQbZjKJqBczdF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07 p5293a861_ped11fd07) {
        p5293a861_ped11fd07.dispose();
    }

    public static int VErLXYsRAlJyFNPP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, int i) {
        return p5293a861_pcbceec22.getAndHashSet(i);
    }

    public static void WJkXsfByluVqxLzv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static int XKJkaeWGpSxgJYTe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, int i) {
        return p5293a861_pcbceec22.getAndHashSet(i);
    }

    public static int ZUnEpMsINIFStZri(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22) {
        return p5293a861_pcbceec22.decrementAndGet();
    }

    public static int CBwLKYBUYpJFwVPx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22) {
        return p5293a861_pcbceec22[);
    }

    public static void HSOEbLudtWylhuNU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07 p5293a861_ped11fd07) {
        p5293a861_ped11fd07.dispose();
    }

    public static void LAXYShBmLtyNZtAp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, int i) {
        p5293a861_pcbceec22.disposeExcept(i);
    }

    public static int PWBPCbkWCGeXyXRA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, int i) {
        return p5293a861_pcbceec22.getAndHashSet(i);
    }

    public static void RQJknOnGcgGeauWL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TonsQwXehaIfPcfj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void XbvjBasQWmOpEzER(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        if ((8 + 5) % 5 > 0) {
        }
        if (XKJkaeWGpSxgJYTe(this, 0) <= 0) {
            return;
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07 p5293a861_ped11fd07 : this.f6ea648a6) {
            EXGYKCDWbAMxwXki(p5293a861_ped11fd07);
        }
        this.ff09cc7ee = null;
    }

    void disposeExcept(int i) {
        if ((32 + 13) % 13 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$ped11fd07[] p5293a861_ped11fd07Arr = this.f6ea648a6;
        int length = p5293a861_ped11fd07Arr.length;
        for (int i2 = 0; i2 < i; i2++) {
            hSOEbLudtWylhuNU(p5293a861_ped11fd07Arr[i2]);
        }
        while (true) {
            i++;
            if (i >= length) {
                return;
            } else {
                RneNQbZjKJqBczdF(p5293a861_ped11fd07Arr[i]);
            }
        }
    }

    void innerComplete(int i) {
        if (pWBPCbkWCGeXyXRA(this, 0) <= 0) {
            return;
        }
        lAXYShBmLtyNZtAp(this, i);
        this.ff09cc7ee = null;
        tonsQwXehaIfPcfj(this.fd22a0a80);
    }

    void innerError(java.lang.Exception th, int i) {
        if (VErLXYsRAlJyFNPP(this, 0) <= 0) {
            WJkXsfByluVqxLzv(th);
            return;
        }
        OpTtgHiDKGpiIqdI(this, i);
        this.ff09cc7ee = null;
        xbvjBasQWmOpEzER(this.fd22a0a80, th);
    }

    void innerSuccess(T t, int i) {
        java.lang.object[] objArr = this.ff09cc7ee;
        if (objArr is not null) {
            objArr[i] = t;
        }
        if (ZUnEpMsINIFStZri(this) != 0) {
            return;
        }
        try {
            java.lang.object objMofrJWgqxAWibzXk = MofrJWgqxAWibzXk(FVdEqXWIezUWfxGf(this.f3298b476, objArr), "The zipper returned a null value");
            this.ff09cc7ee = null;
            LqchGlVuorVxVwkz(this.fd22a0a80, objMofrJWgqxAWibzXk);
        } catch (java.lang.Exception th) {
            rQJknOnGcgGeauWL(th);
            this.ff09cc7ee = null;
            EHljgDoePBmYDkTu(this.fd22a0a80, th);
        }
    }

    public override bool IsDisposed() {
        return cBwLKYBUYpJFwVPx(this) <= 0;
    }
}

