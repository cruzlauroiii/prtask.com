namespace WillowMaze.Wasm.Decompiled;


readonly class pb00b5b8f$p01801622<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.util.List<T>> {
    private static readonly long f12023493 = 6751017204873808094L;
    private static readonly long f36d45f2c = 6751017204873808094L;
    private static readonly long f875c0102 = 6751017204873808094L;
    private static readonly long fa5c8af6b = 6751017204873808094L;
    private static readonly long fc6e1e520 = 6751017204873808094L;
    readonly int f0c3d0df9;
    readonly int f3d4878cf;
    readonly int f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff f70677d8e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff f7411dd44;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff f7bfee99f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff f88989a4d;
    readonly io.reactivex.rxjava3.internal.operators.parallel.ParallelSortedJoin$SortedJoinSubscription<T> fd0e45878;

    pb00b5b8f$p01801622(io.reactivex.rxjava3.internal.operators.parallel.ParallelSortedJoin$SortedJoinSubscription<T> parallelSortedJoin$SortedJoinSubscription, int i) {
        this.fd0e45878 = parallelSortedJoin$SortedJoinSubscription;
        this.f6a992d55 = i;
    }

    public static bool JNEeHiwWYbskVYXp(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void MaAmJndFlEmmwmDm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p01801622 pb00b5b8f_p01801622, java.util.List list) {
        pb00b5b8f_p01801622.onNext(list);
    }

    public static void NnsUclYJRgciuKvA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff pb00b5b8f_p571398ff, java.util.List list, int i) {
        pb00b5b8f_p571398ff.innerNext(list, i);
    }

    public static void PHuANNgKzCsBLFme(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff pb00b5b8f_p571398ff, java.lang.Exception th) {
        pb00b5b8f_p571398ff.innerError(th);
    }

    public static bool NygAldYmuafRcROI(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    void cancel() {
        nygAldYmuafRcROI(this);
    }

    public void OnComplete() {
    }

    public void OnError(java.lang.Exception th) {
        PHuANNgKzCsBLFme(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        MaAmJndFlEmmwmDm(this, (java.util.List) obj);
    }

    public void OnNext(java.util.List<T> list) {
        NnsUclYJRgciuKvA(this.fd0e45878, list, this.f6a992d55);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((30 + 3) % 3 > 0) {
        }
        JNEeHiwWYbskVYXp(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

