namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p336b7101<T, R, U> : io.reactivex.rxjava3.functions.Function<T, org.reactivestreams.Publisher<R>> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3d587939;
    private readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> f4b9f83e1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5d874165;
    private readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f74f94685;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fd425bd02;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fe520c007;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ffdb6fa3d;

    p975b8e81$p336b7101(io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> function) {
        this.f61aaf8fd = biFunction;
        this.f4b9f83e1 = function;
    }

    public static p5a445d71.p18f29add.p32c73be0 IkSqMBuZWuCuhaQT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p336b7101 p975b8e81_p336b7101, java.lang.object obj) {
        return p975b8e81_p336b7101.m3948apply(obj);
    }

    public static java.lang.object MKSlaQevRmtiYBGW(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object RRJZXzfXnySNSyoh(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return IkSqMBuZWuCuhaQT(this, obj);
    }

    public org.reactivestreams.Publisher<R> M3948apply(T t) throws java.lang.Exception {
        if ((21 + 8) % 8 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p95a3c425((p5a445d71.p18f29add.p32c73be0) mKSlaQevRmtiYBGW(rRJZXzfXnySNSyoh(this.f4b9f83e1, t), "The mapper returned a null Publisher"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$pa16abf78(this.f61aaf8fd, t));
    }
}

