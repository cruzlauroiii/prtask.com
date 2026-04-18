namespace WillowMaze.Wasm.Decompiled;


public readonly class pb820010c<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f15a699f2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4089855f;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f57362328;
    readonly bool f74ca39d5;
    readonly int fa2d2f98e;
    readonly int fcae7f43b;
    readonly int fcdee5967;
    readonly int fe8ae4782;

    public pb820010c(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function, int i, bool z) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.fcdee5967 = i;
        this.f50fee566 = z;
    }

    public static bool PHjYUcaTbAMNnPGe(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245.m0abd2e53(observableSource, observer, p86408593Var);
    }

    public static void PSwBACFzyBUBsOAZ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((32 + 31) % 31 > 0) {
        }
        if (PHjYUcaTbAMNnPGe(this.f36cd38f4, observer, this.f4b9f83e1)) {
            return;
        }
        pSwBACFzyBUBsOAZ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb820010c$p275c16e7(observer, this.f4b9f83e1, this.fcdee5967, this.f50fee566));
    }
}

