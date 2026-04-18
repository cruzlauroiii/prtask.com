namespace WillowMaze.Wasm.Decompiled;


public readonly class pf875ccb4<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f19c83c59;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f37a9d2cd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f441e994f;
    readonly io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f5e09d5e8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f879da179;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 feb6da21c;

    public pf875ccb4(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> function) {
        this.f36cd38f4 = parallelFlowable;
        this.f4b9f83e1 = function;
    }

    public static void RbGFYetLZIQcjoLR(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static void RbGFYetLZIQcjoLR(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RbGFYetLZIQcjoLR(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RbGFYetLZIQcjoLR(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int PJzDkGVPNiBxDtfx(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static void PJzDkGVPNiBxDtfx(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PJzDkGVPNiBxDtfx(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PJzDkGVPNiBxDtfx(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmccMkwzCWLXtUAk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pf875ccb4 pf875ccb4Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmccMkwzCWLXtUAk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pf875ccb4 pf875ccb4Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmccMkwzCWLXtUAk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pf875ccb4 pf875ccb4Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool YmccMkwzCWLXtUAk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pf875ccb4 pf875ccb4Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf875ccb4Var.validate(p992c4a5bVarArr);
    }

    public int Parallelism() {
        return pJzDkGVPNiBxDtfx(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((11 + 30) % 30 > 0) {
        }
        if (ymccMkwzCWLXtUAk(this, subscriberArr)) {
            int length = subscriberArr.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                org.reactivestreams.Subscriber<R> subscriber = subscriberArr[i];
                if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pf875ccb4$p1c0003cd((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.f4b9f83e1);
                } else {
                    p992c4a5bVarArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pf875ccb4$p373531b7(subscriber, this.f4b9f83e1);
                }
            }
            RbGFYetLZIQcjoLR(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

