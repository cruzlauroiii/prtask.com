namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p648e639a<T, U> : io.reactivex.rxjava3.functions.Function<T, io.reactivex.rxjava3.core.ObservableSource<U>> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1c464a5a;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f358c4a3d;
    private readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : U>> f4b9f83e1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5806c7cc;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9a424d49;

    p9a814744$p648e639a(io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : U>> function) {
        this.f4b9f83e1 = function;
    }

    public static java.lang.object AYJYPoyXeIszDIvn(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object IGnRQeAZqMjtpdzg(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static io.reactivex.rxjava3.core.ObservableSource QkLDcYZtnPdiXzWL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p648e639a p9a814744_p648e639a, java.lang.object obj) {
        return p9a814744_p648e639a.apply(obj);
    }

    public io.reactivex.rxjava3.core.ObservableSource<U> Apply(T t) throws java.lang.Exception {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcf5d413f((java.lang.IEnumerable) iGnRQeAZqMjtpdzg(aYJYPoyXeIszDIvn(this.f4b9f83e1, t), "The mapper returned a null IEnumerable"));
    }

    public java.lang.object M3942apply(java.lang.object obj) throws java.lang.Exception {
        return qkLDcYZtnPdiXzWL(this, obj);
    }
}

