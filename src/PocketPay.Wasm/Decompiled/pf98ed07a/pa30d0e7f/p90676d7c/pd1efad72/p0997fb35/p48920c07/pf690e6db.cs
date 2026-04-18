namespace WillowMaze.Wasm.Decompiled;


public readonly class pf690e6db<T, C> : io.reactivex.rxjava3.parallel.ParallelFlowable<C> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f075f1da1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f22fdbbf6;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f400c7dce;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f65ab07d0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f7db4160d;
    readonly io.reactivex.rxjava3.functions.BiConsumer<C, T> f91e3a7ff;
    readonly io.reactivex.rxjava3.functions.Supplier<? : C> fbe4db8e3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fbe8ec42e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fdd81cf04;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fe49f2181;

    public pf690e6db(io.reactivex.rxjava3.parallel.ParallelFlowable<? : T> parallelFlowable, io.reactivex.rxjava3.functions.Supplier<? : C> supplier, io.reactivex.rxjava3.functions.BiConsumer<C, T> biConsumer) {
        this.f36cd38f4 = parallelFlowable;
        this.fbe4db8e3 = supplier;
        this.f91e3a7ff = biConsumer;
    }

    public static void JAwsivCWsHHzZUTU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object KHWZFdbxtQUQkDef(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void KzNYOOvDLOpXuXnC(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void QFyLmGKpIQYiNWMh(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static java.lang.object XuZQlOYKDHnRkQPH(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static bool MhGNLyLxxZaYDohz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf690e6db pf690e6dbVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf690e6dbVar.validate(p992c4a5bVarArr);
    }

    public static void OrDSQWwkYknEVzXw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf690e6db pf690e6dbVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, java.lang.Exception th) {
        pf690e6dbVar.reportError(p992c4a5bVarArr, th);
    }

    public static p5a445d71.p18f29add.p992c4a5b[] QURkvNimKLwIrGtY(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static int SkQvcshBDrPZgXtT(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public int Parallelism() {
        return skQvcshBDrPZgXtT(this.f36cd38f4);
    }

    void reportError(org.reactivestreams.Subscriber<object>[] subscriberArr, java.lang.Exception th) {
        if ((10 + 14) % 14 > 0) {
        }
        for (org.reactivestreams.Subscriber<object> subscriber : subscriberArr) {
            KzNYOOvDLOpXuXnC(th, subscriber);
        }
    }

    public void Subscribe(org.reactivestreams.Subscriber<C>[] subscriberArr) {
        if ((20 + 5) % 5 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrQURkvNimKLwIrGtY = qURkvNimKLwIrGtY(this, subscriberArr);
        if (mhGNLyLxxZaYDohz(this, p992c4a5bVarArrQURkvNimKLwIrGtY)) {
            int length = p992c4a5bVarArrQURkvNimKLwIrGtY.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                try {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf690e6db$pdb78eae8(p992c4a5bVarArrQURkvNimKLwIrGtY[i], KHWZFdbxtQUQkDef(XuZQlOYKDHnRkQPH(this.fbe4db8e3), "The initialSupplier returned a null value"), this.f91e3a7ff);
                } catch (java.lang.Exception th) {
                    JAwsivCWsHHzZUTU(th);
                    orDSQWwkYknEVzXw(this, p992c4a5bVarArrQURkvNimKLwIrGtY, th);
                    return;
                }
            }
            QFyLmGKpIQYiNWMh(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

