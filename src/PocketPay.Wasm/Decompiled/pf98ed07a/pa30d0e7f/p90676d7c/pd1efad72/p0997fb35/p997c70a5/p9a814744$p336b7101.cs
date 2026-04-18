namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p336b7101<T, R, U> : io.reactivex.rxjava3.functions.Function<T, io.reactivex.rxjava3.core.ObservableSource<R>> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3620022d;
    private readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f5369a29a;
    private readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f774796a5;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f7bd7c9e8;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ffc21f1e0;

    p9a814744$p336b7101(io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function) {
        this.f61aaf8fd = biFunction;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object OrGitpqfgmjQoWuU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object XrtsqDERMJMHfNvH(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static io.reactivex.rxjava3.core.ObservableSource KsigsRpIEBLXZyhs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p336b7101 p9a814744_p336b7101, java.lang.object obj) {
        return p9a814744_p336b7101.apply(obj);
    }

    public io.reactivex.rxjava3.core.ObservableSource<R> Apply(T t) throws java.lang.Exception {
        if ((3 + 17) % 17 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p915ea05a((io.reactivex.rxjava3.core.ObservableSource) OrGitpqfgmjQoWuU(XrtsqDERMJMHfNvH(this.f4b9f83e1, t), "The mapper returned a null ObservableSource"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$pa16abf78(this.f61aaf8fd, t));
    }

    public java.lang.object M3939apply(java.lang.object obj) throws java.lang.Exception {
        return ksigsRpIEBLXZyhs(this, obj);
    }
}

