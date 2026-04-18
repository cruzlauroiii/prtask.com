namespace WillowMaze.Wasm.Decompiled;


readonly class p9e84576a$pfb7c43fc<R, T> : io.reactivex.rxjava3.functions.Function<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a this$0;

    p9e84576a$pfb7c43fc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a p9e84576aVar) {
        this.this$0 = p9e84576aVar;
    }

    public static java.lang.object XpxgSFujUqniXWAU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object RmaQVboPwvTqQtNt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public R Apply(T t) throws java.lang.Exception {
        return (R) XpxgSFujUqniXWAU(rmaQVboPwvTqQtNt(this.this$0.f61aaf8fd, new java.lang.object[]{t}), "The combiner returned a null value");
    }
}

