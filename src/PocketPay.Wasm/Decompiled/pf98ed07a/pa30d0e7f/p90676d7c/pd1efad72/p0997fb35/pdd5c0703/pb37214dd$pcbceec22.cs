namespace WillowMaze.Wasm.Decompiled;


readonly class pb37214dd$pcbceec22<T, R> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f397b6566 = -5556924161382950569L;
    private static readonly long f9b1a1d14 = -5556924161382950569L;
    private static readonly long faf3c31d4 = -5556924161382950569L;
    private static readonly long fc6e1e520 = -5556924161382950569L;
    readonly io.reactivex.rxjava3.core.SingleObserver f04b9fefe;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0ea570b1;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly io.reactivex.rxjava3.core.SingleObserver f44b66e67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f60a39c8a;
    readonly io.reactivex.rxjava3.internal.operators.single.SingleZipArray$ZipSingleObserver<T>[] f6ea648a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f[] f7144559c;
    java.lang.object[] f7ff79b16;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f98e9a7b6;
    java.lang.object[] fa726d372;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f[] fdda06ff0;
    java.lang.object[] ff09cc7ee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f[] ffe540d73;

    pb37214dd$pcbceec22(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, int i, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function) {
        super(i);
        this.fd22a0a80 = singleObserver;
        this.f3298b476 = function;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f[] pb37214dd_p299f366fArr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f[i];
        for (int i2 = 0; i2 < i; i2++) {
            pb37214dd_p299f366fArr[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f(this, i2);
        }
        this.f6ea648a6 = pb37214dd_p299f366fArr;
        this.ff09cc7ee = new java.lang.object[i];
    }

    public static int BHnCVggJMwBoSVwt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22) {
        return pb37214dd_pcbceec22.decrementAndGet();
    }

    public static void KsfSxRPZcUsVkqcQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f pb37214dd_p299f366f) {
        pb37214dd_p299f366f.dispose();
    }

    public static void LCxSUVdqpHLUeZut(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f pb37214dd_p299f366f) {
        pb37214dd_p299f366f.dispose();
    }

    public static int MqFyoIPrJpifkWoO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22, int i) {
        return pb37214dd_pcbceec22.getAndHashSet(i);
    }

    public static void QBiSidCdMrUOFosx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void THYNPHkcFJRJdgWO(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void WlJrbhNsccnHaPQw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f pb37214dd_p299f366f) {
        pb37214dd_p299f366f.dispose();
    }

    public static void DRaVJyMQZCfRkqEh(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void FfVjRHlcJtTHcoXW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object GnyPIvtSWdaurkAA(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JSUOrxdXEtKorfHQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object KmTXYplwbWgUaaFt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static int MjPlBzIakQBBGKtJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22) {
        return pb37214dd_pcbceec22[);
    }

    public static int PLhwZdazqGLYXkJz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22, int i) {
        return pb37214dd_pcbceec22.getAndHashSet(i);
    }

    public static void UwDXVSXiEceBQqpL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22, int i) {
        pb37214dd_pcbceec22.disposeExcept(i);
    }

    public override void Dispose() {
        if ((7 + 26) % 26 > 0) {
        }
        if (MqFyoIPrJpifkWoO(this, 0) <= 0) {
            return;
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f pb37214dd_p299f366f : this.f6ea648a6) {
            LCxSUVdqpHLUeZut(pb37214dd_p299f366f);
        }
        this.ff09cc7ee = null;
    }

    void disposeExcept(int i) {
        if ((32 + 13) % 13 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$p299f366f[] pb37214dd_p299f366fArr = this.f6ea648a6;
        int length = pb37214dd_p299f366fArr.length;
        for (int i2 = 0; i2 < i; i2++) {
            WlJrbhNsccnHaPQw(pb37214dd_p299f366fArr[i2]);
        }
        while (true) {
            i++;
            if (i >= length) {
                return;
            } else {
                KsfSxRPZcUsVkqcQ(pb37214dd_p299f366fArr[i]);
            }
        }
    }

    void innerError(java.lang.Exception th, int i) {
        if (pLhwZdazqGLYXkJz(this, 0) <= 0) {
            ffVjRHlcJtTHcoXW(th);
            return;
        }
        uwDXVSXiEceBQqpL(this, i);
        this.ff09cc7ee = null;
        THYNPHkcFJRJdgWO(this.fd22a0a80, th);
    }

    void innerSuccess(T t, int i) {
        java.lang.object[] objArr = this.ff09cc7ee;
        if (objArr is not null) {
            objArr[i] = t;
        }
        if (BHnCVggJMwBoSVwt(this) != 0) {
            return;
        }
        try {
            java.lang.object objGnyPIvtSWdaurkAA = gnyPIvtSWdaurkAA(kmTXYplwbWgUaaFt(this.f3298b476, objArr), "The zipper returned a null value");
            this.ff09cc7ee = null;
            QBiSidCdMrUOFosx(this.fd22a0a80, objGnyPIvtSWdaurkAA);
        } catch (java.lang.Exception th) {
            jSUOrxdXEtKorfHQ(th);
            this.ff09cc7ee = null;
            dRaVJyMQZCfRkqEh(this.fd22a0a80, th);
        }
    }

    public override bool IsDisposed() {
        return mjPlBzIakQBBGKtJ(this) <= 0;
    }
}

