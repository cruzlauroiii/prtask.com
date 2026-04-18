namespace WillowMaze.Wasm.Decompiled;


public readonly class p1d65b303<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f08711c92;
    readonly int f236f7c85;
    readonly int f2ad63821;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly bool f4f6a303e;
    readonly int f6b1e7c68;
    readonly bool f825ea879;
    readonly int f8d4e2a5e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f8eaee996;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb1ac7b4c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fdfc1a76d;
    readonly int fede6505c;
    readonly bool ff7e8261d;

    public p1d65b303(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function, bool z, int i, int i2) {
        this.f36cd38f4 = parallelFlowable;
        this.f4b9f83e1 = function;
        this.f825ea879 = z;
        this.f42088376 = i;
        this.f4c203b76 = i2;
    }

    public static p5a445d71.p18f29add.p992c4a5b[] FBrcZYgCPdrydvmm(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static bool JExMFPfiXnaRTFHY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p1d65b303 p1d65b303Var, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return p1d65b303Var.validate(p992c4a5bVarArr);
    }

    public static io.reactivex.rxjava3.core.FlowableSubscriber KkuDfsHMQFytzHtI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, bool z, int i, int i2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd38c2979.m4f893ee2(p992c4a5bVar, p86408593Var, z, i, i2);
    }

    public static void RGnWdwvicGyPzpKz(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static int UkUOoxIXJPLyUybb(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public int Parallelism() {
        return ukUOoxIXJPLyUybb(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((10 + 24) % 24 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrFBrcZYgCPdrydvmm = FBrcZYgCPdrydvmm(this, subscriberArr);
        if (JExMFPfiXnaRTFHY(this, p992c4a5bVarArrFBrcZYgCPdrydvmm)) {
            int length = p992c4a5bVarArrFBrcZYgCPdrydvmm.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p992c4a5bVarArr[i] = KkuDfsHMQFytzHtI(p992c4a5bVarArrFBrcZYgCPdrydvmm[i], this.f4b9f83e1, this.f825ea879, this.f42088376, this.f4c203b76);
            }
            RGnWdwvicGyPzpKz(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

