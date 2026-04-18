namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p15d90229<T, S> : io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> {
    readonly io.reactivex.rxjava3.functions.Consumer<io.reactivex.rxjava3.core.Emitter<T>> f1005b14b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fb5c6c836;

    p975b8e81$p15d90229(io.reactivex.rxjava3.functions.Consumer<io.reactivex.rxjava3.core.Emitter<T>> consumer) {
        this.f1005b14b = consumer;
    }

    public static java.lang.object VrkrYvxjBuNQareS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p15d90229 p975b8e81_p15d90229, java.lang.object obj, io.reactivex.rxjava3.core.Emitter emitter) {
        return p975b8e81_p15d90229.apply(obj, emitter);
    }

    public static void VvWOeFBWEsbFSxfI(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public S Apply(S s, io.reactivex.rxjava3.core.Emitter<T> emitter) throws java.lang.Exception {
        VvWOeFBWEsbFSxfI(this.f1005b14b, emitter);
        return s;
    }

    public java.lang.object Apply(java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        return VrkrYvxjBuNQareS(this, obj, (io.reactivex.rxjava3.core.Emitter) obj2);
    }
}

