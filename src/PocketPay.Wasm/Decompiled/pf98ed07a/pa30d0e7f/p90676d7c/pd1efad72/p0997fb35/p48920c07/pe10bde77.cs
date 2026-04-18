namespace WillowMaze.Wasm.Decompiled;


public readonly class pe10bde77<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3c5ebde5;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f679221e2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f71b34eaa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f8ba6e0ee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f959fa34c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fbc74de6d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe627a32e;

    public pe10bde77(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function) {
        this.f36cd38f4 = parallelFlowable;
        this.f4b9f83e1 = function;
    }

    public static int RMWRISXJsKdKrRyI(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static p5a445d71.p18f29add.p992c4a5b[] RduOqbxaMWopMtQP(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static void GLxXaPMCRaQsEEtL(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static bool SPFBVgckkTixZJnv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe10bde77 pe10bde77Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pe10bde77Var.validate(p992c4a5bVarArr);
    }

    public int Parallelism() {
        return RMWRISXJsKdKrRyI(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((32 + 18) % 18 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrRduOqbxaMWopMtQP = RduOqbxaMWopMtQP(this, subscriberArr);
        if (sPFBVgckkTixZJnv(this, p992c4a5bVarArrRduOqbxaMWopMtQP)) {
            int length = p992c4a5bVarArrRduOqbxaMWopMtQP.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = p992c4a5bVarArrRduOqbxaMWopMtQP[i];
                if (p992c4a5bVar is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe10bde77$p1c0003cd((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) p992c4a5bVar, this.f4b9f83e1);
                } else {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe10bde77$p373531b7(p992c4a5bVar, this.f4b9f83e1);
                }
            }
            gLxXaPMCRaQsEEtL(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

