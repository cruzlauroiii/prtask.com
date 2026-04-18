namespace WillowMaze.Wasm.Decompiled;


public readonly class pb00b5b8f<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.parallel.ParallelFlowable<java.util.List<T>> f36cd38f4;
    readonly java.util.Comparator<T> f4092f21b;
    readonly java.util.Comparator f5beb1969;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d fd8e32f65;

    public pb00b5b8f(io.reactivex.rxjava3.parallel.ParallelFlowable<java.util.List<T>> parallelFlowable, java.util.Comparator<T> comparator) {
        this.f36cd38f4 = parallelFlowable;
        this.f4092f21b = comparator;
    }

    public static int CTjgrvsbFzfhtYud(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar) {
        return p536a505dVar.parallelism();
    }

    public static void PEDxiSoNYalbxXjY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void QyWnccOxOmxYaxfx(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p536a505d p536a505dVar, p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr) {
        p536a505dVar.subscribe(p992c4a5bVarArr);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((14 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff pb00b5b8f_p571398ff = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pb00b5b8f$p571398ff(subscriber, CTjgrvsbFzfhtYud(this.f36cd38f4), this.f4092f21b);
        PEDxiSoNYalbxXjY(subscriber, pb00b5b8f_p571398ff);
        qyWnccOxOmxYaxfx(this.f36cd38f4, pb00b5b8f_p571398ff.faae7b662);
    }
}

