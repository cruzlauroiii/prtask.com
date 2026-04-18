namespace WillowMaze.Wasm.Decompiled;


public readonly class pf6cdc5d8<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0d2c3e3e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f174d41a2;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3f024039;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f85d6c071;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9ea55ddf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc4d7edee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fcd063d58;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd5fde093;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fefb16ad4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d ff05a0ab6;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;

    public pf6cdc5d8(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.f36cd38f4 = parallelFlowable;
        this.f4b9f83e1 = function;
        this.ff56352fa = biFunction;
    }

    public static int LJsnZHAokhtAKWBQ(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static bool UJSIsIfSPthjkxlS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8 pf6cdc5d8Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf6cdc5d8Var.validate(p992c4a5bVarArr);
    }

    public static void IvDNWPNxsgOWiSKk(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static p5a445d71.p18f29add.p992c4a5b[] SmfmhXSGUHzoUrZm(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public int Parallelism() {
        return LJsnZHAokhtAKWBQ(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((29 + 27) % 27 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrSmfmhXSGUHzoUrZm = smfmhXSGUHzoUrZm(this, subscriberArr);
        if (UJSIsIfSPthjkxlS(this, p992c4a5bVarArrSmfmhXSGUHzoUrZm)) {
            int length = p992c4a5bVarArrSmfmhXSGUHzoUrZm.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = p992c4a5bVarArrSmfmhXSGUHzoUrZm[i];
                if (p992c4a5bVar is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) p992c4a5bVar, this.f4b9f83e1, this.ff56352fa);
                } else {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92(p992c4a5bVar, this.f4b9f83e1, this.ff56352fa);
                }
            }
            ivDNWPNxsgOWiSKk(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

