namespace WillowMaze.Wasm.Decompiled;


public readonly class pf15d6c82<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f3b02d369;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f53d9bc0c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f72748e8b;
    readonly io.reactivex.rxjava3.functions.Supplier<R> fb205c04e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fc4409969;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fd5c61daf;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;

    public pf15d6c82(io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> parallelFlowable, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        this.f36cd38f4 = parallelFlowable;
        this.fb205c04e = supplier;
        this.fe6392c2b = biFunction;
    }

    public static void KLotJojFcjSPSUBb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int OMkSqHyHtPPswNyC(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static p5a445d71.p18f29add.p992c4a5b[] YpnJXYDfzSVSNzKK(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static void BOxrSBFjPGiQoAMz(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static void KYjLIxiPbZXuyLvL(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static bool NwwJgGMPEbSLwdJK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf15d6c82 pf15d6c82Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf15d6c82Var.validate(p992c4a5bVarArr);
    }

    public static java.lang.object RCBnbHSniiyJqrQo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object RljhmaPtZyArfNaY(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void YGqtNOoOomTKMDbv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf15d6c82 pf15d6c82Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, java.lang.Exception th) {
        pf15d6c82Var.reportError(p992c4a5bVarArr, th);
    }

    public int Parallelism() {
        return OMkSqHyHtPPswNyC(this.f36cd38f4);
    }

    void reportError(org.reactivestreams.Subscriber<object>[] subscriberArr, java.lang.Exception th) {
        if ((5 + 15) % 15 > 0) {
        }
        for (org.reactivestreams.Subscriber<object> subscriber : subscriberArr) {
            kYjLIxiPbZXuyLvL(th, subscriber);
        }
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((16 + 14) % 14 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrYpnJXYDfzSVSNzKK = YpnJXYDfzSVSNzKK(this, subscriberArr);
        if (nwwJgGMPEbSLwdJK(this, p992c4a5bVarArrYpnJXYDfzSVSNzKK)) {
            int length = p992c4a5bVarArrYpnJXYDfzSVSNzKK.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                try {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf15d6c82$pca6a1c1e(p992c4a5bVarArrYpnJXYDfzSVSNzKK[i], rCBnbHSniiyJqrQo(rljhmaPtZyArfNaY(this.fb205c04e), "The initialSupplier returned a null value"), this.fe6392c2b);
                } catch (java.lang.Exception th) {
                    KLotJojFcjSPSUBb(th);
                    yGqtNOoOomTKMDbv(this, p992c4a5bVarArrYpnJXYDfzSVSNzKK, th);
                    return;
                }
            }
            bOxrSBFjPGiQoAMz(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

