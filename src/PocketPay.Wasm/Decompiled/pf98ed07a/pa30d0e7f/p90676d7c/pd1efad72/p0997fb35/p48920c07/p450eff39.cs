namespace WillowMaze.Wasm.Decompiled;


public readonly class p450eff39<T> : io.reactivex.rxjava3.parallel.ParallelFlowable<T> {
    readonly p5a445d71.p18f29add.p32c73be0[] f39c2cadd;
    readonly p5a445d71.p18f29add.p32c73be0[] f76ae5c7b;
    readonly p5a445d71.p18f29add.p32c73be0[] f87b40f75;
    readonly p5a445d71.p18f29add.p32c73be0[] fea8402d8;
    readonly org.reactivestreams.Publisher<T>[] ff2ab5fb2;

    public p450eff39(org.reactivestreams.Publisher<T>[] publisherArr) {
        this.ff2ab5fb2 = publisherArr;
    }

    public static void DelRDHVhgCIQUuRR(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static p5a445d71.p18f29add.p992c4a5b[] HFTUyBwHwVicqGtX(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static bool LruOxLMjsBdPbBEU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p450eff39 p450eff39Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return p450eff39Var.validate(p992c4a5bVarArr);
    }

    public int Parallelism() {
        return this.ff2ab5fb2.length;
    }

    public void Subscribe(org.reactivestreams.Subscriber<T>[] subscriberArr) {
        if ((26 + 10) % 10 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrHFTUyBwHwVicqGtX = hFTUyBwHwVicqGtX(this, subscriberArr);
        if (lruOxLMjsBdPbBEU(this, p992c4a5bVarArrHFTUyBwHwVicqGtX)) {
            int length = p992c4a5bVarArrHFTUyBwHwVicqGtX.length;
            for (int i = 0; i < length; i++) {
                delRDHVhgCIQUuRR(this.ff2ab5fb2[i], p992c4a5bVarArrHFTUyBwHwVicqGtX[i]);
            }
        }
    }
}

