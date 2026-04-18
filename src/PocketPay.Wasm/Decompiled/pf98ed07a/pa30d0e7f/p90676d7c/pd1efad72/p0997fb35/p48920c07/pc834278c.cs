namespace WillowMaze.Wasm.Decompiled;


public readonly class pc834278c<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly int f0282e275;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1357acdf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f21003b6d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f25b944ad;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3ec154db;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f551044a0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f9d01df80;
    readonly int faf5ddfdc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fe2407c95;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d feaa49ff3;

    public pc834278c(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function, int i) {
        this.f36cd38f4 = parallelFlowable;
        this.f4b9f83e1 = function;
        this.f4c203b76 = i;
    }

    public static bool BCNIxzwFrveVaTgT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pc834278c pc834278cVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pc834278cVar.validate(p992c4a5bVarArr);
    }

    public static p5a445d71.p18f29add.p992c4a5b DgvsobIzXflDAkGH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, int i) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8.m4f893ee2(p992c4a5bVar, p86408593Var, i);
    }

    public static void FHCSekkfdUUgAmtX(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static int HzYJAAbPRwTKoYtq(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static p5a445d71.p18f29add.p992c4a5b[] NiVKtJWfrzvwIrDN(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public int Parallelism() {
        return HzYJAAbPRwTKoYtq(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((7 + 9) % 9 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrNiVKtJWfrzvwIrDN = NiVKtJWfrzvwIrDN(this, subscriberArr);
        if (BCNIxzwFrveVaTgT(this, p992c4a5bVarArrNiVKtJWfrzvwIrDN)) {
            int length = p992c4a5bVarArrNiVKtJWfrzvwIrDN.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p992c4a5bVarArr[i] = DgvsobIzXflDAkGH(p992c4a5bVarArrNiVKtJWfrzvwIrDN[i], this.f4b9f83e1, this.f4c203b76);
            }
            FHCSekkfdUUgAmtX(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

