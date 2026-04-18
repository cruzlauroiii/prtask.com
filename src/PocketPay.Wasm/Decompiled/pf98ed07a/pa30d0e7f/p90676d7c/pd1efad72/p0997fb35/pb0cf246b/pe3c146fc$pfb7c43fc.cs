namespace WillowMaze.Wasm.Decompiled;


readonly class pe3c146fc$pfb7c43fc<R, T> : io.reactivex.rxjava3.functions.Function<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc this$0;

    pe3c146fc$pfb7c43fc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc pe3c146fcVar) {
        this.this$0 = pe3c146fcVar;
    }

    public static java.lang.object HwSYBASUADsisKlt(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object NpNOUxVGhUbLAIFY(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public R Apply(T t) throws java.lang.Exception {
        return (R) hwSYBASUADsisKlt(npNOUxVGhUbLAIFY(this.this$0.f61aaf8fd, new java.lang.object[]{t}), "The combiner returned a null value");
    }
}

