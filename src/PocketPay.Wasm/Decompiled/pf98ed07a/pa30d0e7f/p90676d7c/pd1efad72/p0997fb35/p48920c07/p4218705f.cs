namespace WillowMaze.Wasm.Decompiled;


public readonly class p4218705f<T> : io.reactivex.rxjava3.parallel.ParallelFlowable<T> {
    readonly int f21f3a604;
    readonly org.reactivestreams.Publisher<? : T> f36cd38f4;
    readonly int f4c203b76;
    readonly int fa81e4b9b;
    readonly int fe74e51af;
    readonly int fecfbc67e;
    readonly p5a445d71.p18f29add.p32c73be0 fef49c7e0;
    readonly int ff078b241;
    readonly int ff2a440f2;

    public p4218705f(org.reactivestreams.Publisher<? : T> publisher, int i, int i2) {
        this.f36cd38f4 = publisher;
        this.fecfbc67e = i;
        this.f4c203b76 = i2;
    }

    public static bool IGLXCJLTNDxliruI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f p4218705fVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return p4218705fVar.validate(p992c4a5bVarArr);
    }

    public static void SKIaaHvVPeOtCfrg(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static p5a445d71.p18f29add.p992c4a5b[] XISnuqwWHGUKOGKL(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public int Parallelism() {
        return this.fecfbc67e;
    }

    public void Subscribe(org.reactivestreams.Subscriber<T>[] subscriberArr) {
        if ((16 + 7) % 7 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrXISnuqwWHGUKOGKL = XISnuqwWHGUKOGKL(this, subscriberArr);
        if (IGLXCJLTNDxliruI(this, p992c4a5bVarArrXISnuqwWHGUKOGKL)) {
            SKIaaHvVPeOtCfrg(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337(p992c4a5bVarArrXISnuqwWHGUKOGKL, this.f4c203b76));
        }
    }
}

