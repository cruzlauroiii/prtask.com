namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$pa16abf78<U, R, T> : io.reactivex.rxjava3.functions.Function<U, R> {
    private readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    private readonly java.lang.object faef17367;
    private readonly T fe358efa4;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba feddfa61c;

    p975b8e81$pa16abf78(io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction, T t) {
        this.f61aaf8fd = biFunction;
        this.fe358efa4 = t;
    }

    public static java.lang.object VmBQIrbnpIoOxwBe(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public R Apply(U u) throws java.lang.Exception {
        return (R) VmBQIrbnpIoOxwBe(this.f61aaf8fd, this.fe358efa4, u);
    }
}

