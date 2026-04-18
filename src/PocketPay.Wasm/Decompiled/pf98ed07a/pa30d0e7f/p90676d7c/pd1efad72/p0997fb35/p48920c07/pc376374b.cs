namespace WillowMaze.Wasm.Decompiled;


public readonly class pc376374b<T, R> : io.reactivex.rxjava3.parallel.ParallelFlowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f07b9c6fe;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f32338fd7;
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<T> f36cd38f4;
    readonly int f428538eb;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d f4c200404;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly int f677699c4;
    readonly int f69ac5bc9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6a15c975;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fd0a74b8a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fee50ac6a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 ff4d8c903;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff9bbfcb5;
    readonly int ffe0c1412;

    public pc376374b(io.reactivex.rxjava3.parallel.ParallelFlowable<T> parallelFlowable, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        this.f36cd38f4 = parallelFlowable;
        this.f4b9f83e1 = (pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593) UDaSfivZEBcDdgVw(function, "mapper");
        this.f4c203b76 = i;
        this.f560019e4 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9) NKaonXPGsnDzDnwe(pcd04add9Var, "errorMode");
    }

    public static java.lang.object NKaonXPGsnDzDnwe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object UDaSfivZEBcDdgVw(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool XNqLRGjjMHbBhDlY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pc376374b pc376374bVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pc376374bVar.validate(p992c4a5bVarArr);
    }

    public static p5a445d71.p18f29add.p992c4a5b[] ZOUMtrYOFPSavGTc(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.m5788df95(p536a505dVar, p992c4a5bVarArr);
    }

    public static int JnQnxDfVtLLljeyO(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static void SQvbxVCLBxIUQSxg(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    public static p5a445d71.p18f29add.p992c4a5b UFlwIbNDEXmBcyye(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37a1aa52.m4f893ee2(p992c4a5bVar, p86408593Var, i, pcd04add9Var);
    }

    public int Parallelism() {
        return jnQnxDfVtLLljeyO(this.f36cd38f4);
    }

    public void Subscribe(org.reactivestreams.Subscriber<R>[] subscriberArr) {
        if ((32 + 14) % 14 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArrZOUMtrYOFPSavGTc = ZOUMtrYOFPSavGTc(this, subscriberArr);
        if (XNqLRGjjMHbBhDlY(this, p992c4a5bVarArrZOUMtrYOFPSavGTc)) {
            int length = p992c4a5bVarArrZOUMtrYOFPSavGTc.length;
            p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = new p5a445d71.p18f29add.p992c4a5b[length];
            for (int i = 0; i < length; i++) {
                p992c4a5bVarArr[i] = uFlwIbNDEXmBcyye(p992c4a5bVarArrZOUMtrYOFPSavGTc[i], this.f4b9f83e1, this.f4c203b76, this.f560019e4);
            }
            sQvbxVCLBxIUQSxg(this.f36cd38f4, p992c4a5bVarArr);
        }
    }
}

