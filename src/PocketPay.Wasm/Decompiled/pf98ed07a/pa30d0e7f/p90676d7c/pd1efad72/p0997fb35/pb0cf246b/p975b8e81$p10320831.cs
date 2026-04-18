namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p10320831<T, S> : io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> {
    readonly io.reactivex.rxjava3.functions.BiConsumer<S, io.reactivex.rxjava3.core.Emitter<T>> f1005b14b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f1d3d3023;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f56ab8b5b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f97893ae4;

    p975b8e81$p10320831(io.reactivex.rxjava3.functions.BiConsumer<S, io.reactivex.rxjava3.core.Emitter<T>> biConsumer) {
        this.f1005b14b = biConsumer;
    }

    public static java.lang.object AJvczKINdSGmjrMQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p10320831 p975b8e81_p10320831, java.lang.object obj, io.reactivex.rxjava3.core.Emitter emitter) {
        return p975b8e81_p10320831.apply(obj, emitter);
    }

    public static void SbPTKAWAuSmtyTCb(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public S Apply(S s, io.reactivex.rxjava3.core.Emitter<T> emitter) throws java.lang.Exception {
        sbPTKAWAuSmtyTCb(this.f1005b14b, s, emitter);
        return s;
    }

    public java.lang.object Apply(java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        return aJvczKINdSGmjrMQ(this, obj, (io.reactivex.rxjava3.core.Emitter) obj2);
    }
}

