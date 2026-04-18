namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p648e639a<T, U> : io.reactivex.rxjava3.functions.Function<T, org.reactivestreams.Publisher<U>> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2d496053;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3c580e71;
    private readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : U>> f4b9f83e1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa89c7019;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff3b019f4;

    p975b8e81$p648e639a(io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : U>> function) {
        this.f4b9f83e1 = function;
    }

    public static p5a445d71.p18f29add.p32c73be0 GNAqSIWzvdbvAaFY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p648e639a p975b8e81_p648e639a, java.lang.object obj) {
        return p975b8e81_p648e639a.m3950apply(obj);
    }

    public static java.lang.object HpuboKYkZVhXTQhz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object MjxerORfgVxMTOEm(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return GNAqSIWzvdbvAaFY(this, obj);
    }

    public org.reactivestreams.Publisher<U> M3950apply(T t) throws java.lang.Exception {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f((java.lang.IEnumerable) MjxerORfgVxMTOEm(HpuboKYkZVhXTQhz(this.f4b9f83e1, t), "The mapper returned a null IEnumerable"));
    }
}

