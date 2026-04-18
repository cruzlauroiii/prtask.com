namespace WillowMaze.Wasm.Decompiled;


public readonly class p161b996b<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly int f42088376;
    readonly int f487f6a3d;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    readonly bool f50fee566;
    readonly int f5e8df1b2;
    readonly bool f7b2e574e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7bb84d50;
    readonly int f7f1bd332;
    readonly int fcdee5967;

    public p161b996b(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function, bool z, int i, int i2) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
        this.fcdee5967 = i2;
    }

    public static bool IzoGivxcrSudNjuX(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245.m0abd2e53(observableSource, observer, p86408593Var);
    }

    public static void CpQbAWjgNeuWgFiz(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((15 + 20) % 20 > 0) {
        }
        if (IzoGivxcrSudNjuX(this.f36cd38f4, observer, this.f4b9f83e1)) {
            return;
        }
        cpQbAWjgNeuWgFiz(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6(observer, this.f4b9f83e1, this.f50fee566, this.f42088376, this.fcdee5967));
    }
}

