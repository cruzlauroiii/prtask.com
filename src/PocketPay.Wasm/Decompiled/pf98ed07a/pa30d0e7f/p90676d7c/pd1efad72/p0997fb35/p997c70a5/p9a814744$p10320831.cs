namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p10320831<T, S> : io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> {
    readonly io.reactivex.rxjava3.functions.BiConsumer<S, io.reactivex.rxjava3.core.Emitter<T>> f1005b14b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f18e06b1c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fa313f3a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fc44fcb15;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 ffceb2828;

    p9a814744$p10320831(io.reactivex.rxjava3.functions.BiConsumer<S, io.reactivex.rxjava3.core.Emitter<T>> biConsumer) {
        this.f1005b14b = biConsumer;
    }

    public static void BEXfMaCOCYLyGIoM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static java.lang.object JbdwtxlCFcHYyfKn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p10320831 p9a814744_p10320831, java.lang.object obj, io.reactivex.rxjava3.core.Emitter emitter) {
        return p9a814744_p10320831.apply(obj, emitter);
    }

    public S Apply(S s, io.reactivex.rxjava3.core.Emitter<T> emitter) throws java.lang.Exception {
        bEXfMaCOCYLyGIoM(this.f1005b14b, s, emitter);
        return s;
    }

    public java.lang.object Apply(java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        return jbdwtxlCFcHYyfKn(this, obj, (io.reactivex.rxjava3.core.Emitter) obj2);
    }
}

