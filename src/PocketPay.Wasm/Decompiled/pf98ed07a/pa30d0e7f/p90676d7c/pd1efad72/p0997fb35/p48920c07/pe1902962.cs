namespace WillowMaze.Wasm.Decompiled;


public readonly class pe1902962<T> : io.reactivex.rxjava3.parallel.ParallelFlowable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0d06c145;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f18cfe822;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f2c7bf5c9;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fb807363b;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 ffe4a1500;

    public pe1902962(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Predicate<T> predicate, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.f36cd38f4 = parallelFlowable;
        this.ff670ef68 = predicate;
        this.ff56352fa = biFunction;
    }

    public static p5a445d71.p18f29add.p992c4a5b[] QiDXKFWezHIRhtsk(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static int ZZvUWBuQGqAegpaP(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static bool ILeiZkkeEXSVICUj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962 pe1902962Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pe1902962Var.validate(p992c4a5bVarArr);
    }

    public static void MFHTwmSGJoEGmLxz(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public int Parallelism() {
        return ZZvUWBuQGqAegpaP(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<T>[] subscriberArr) {
        if ((23 + 13) % 13 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrQiDXKFWezHIRhtsk = QiDXKFWezHIRhtsk(this, subscriberArr);
        if (iLeiZkkeEXSVICUj(this, p992c4a5bVarArrQiDXKFWezHIRhtsk)) {
            int length = p992c4a5bVarArrQiDXKFWezHIRhtsk.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = p992c4a5bVarArrQiDXKFWezHIRhtsk[i];
                if (p992c4a5bVar is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$pe9a0f99c((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) p992c4a5bVar, this.ff670ef68, this.ff56352fa);
                } else {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9(p992c4a5bVar, this.ff670ef68, this.ff56352fa);
                }
            }
            mFHTwmSGJoEGmLxz(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

