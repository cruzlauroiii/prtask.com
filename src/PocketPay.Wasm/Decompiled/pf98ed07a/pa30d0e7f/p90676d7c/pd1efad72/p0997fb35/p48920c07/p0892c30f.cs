namespace WillowMaze.Wasm.Decompiled;


public readonly class p0892c30f<T> : io.reactivex.rxjava3.parallel.ParallelFlowable<T> {
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f518ab04f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fcd607fa4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fdca64a06;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d ffa789635;

    public p0892c30f(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.f36cd38f4 = parallelFlowable;
        this.ff670ef68 = predicate;
    }

    public static p5a445d71.p18f29add.p992c4a5b[] EAPQRYQStEWAelno(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static bool KdVQdKQcphZDXUwe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f p0892c30fVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return p0892c30fVar.validate(p992c4a5bVarArr);
    }

    public static void PAkLrxacnWfZgjGS(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static int SrahEGMSEeEZHAhq(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public int Parallelism() {
        return srahEGMSEeEZHAhq(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<T>[] subscriberArr) {
        if ((15 + 4) % 4 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrEAPQRYQStEWAelno = EAPQRYQStEWAelno(this, subscriberArr);
        if (kdVQdKQcphZDXUwe(this, p992c4a5bVarArrEAPQRYQStEWAelno)) {
            int length = p992c4a5bVarArrEAPQRYQStEWAelno.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = p992c4a5bVarArrEAPQRYQStEWAelno[i];
                if (p992c4a5bVar is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$pe9a0f99c((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) p992c4a5bVar, this.ff670ef68);
                } else {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$p2aa853d9(p992c4a5bVar, this.ff670ef68);
                }
            }
            pAkLrxacnWfZgjGS(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

