namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$pa16abf78<U, R, T> : io.reactivex.rxjava3.functions.Function<U, R> {
    private readonly java.lang.object f09afd9a6;
    private readonly java.lang.object f0cfce668;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3bbef6e9;
    private readonly java.lang.object f45b37201;
    private readonly java.lang.object f4dec0711;
    private readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f85d5c5cf;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f8acb0221;
    private readonly T fe358efa4;

    p9a814744$pa16abf78(io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction, T t) {
        this.f61aaf8fd = biFunction;
        this.fe358efa4 = t;
    }

    public static java.lang.object SKiFhkOWhCheACRx(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public R Apply(U u) throws java.lang.Exception {
        return (R) SKiFhkOWhCheACRx(this.f61aaf8fd, this.fe358efa4, u);
    }
}

