namespace WillowMaze.Wasm.Decompiled;


public readonly class pc50c153b<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f0bb01e29;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1e181502;
    readonly int f42088376;
    readonly int f435f7792;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly int f4be47c8c;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8bfcb36f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9839da7f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcb699c5f;
    readonly int fd4cc92db;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fdba19a7b;

    public pc50c153b(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i, int i2) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f42088376 = i;
        this.f4c203b76 = i2;
    }

    public static void YNYOeDixNAjgZAHc(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((21 + 12) % 12 > 0) {
        }
        YNYOeDixNAjgZAHc(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80(observer, this.f4b9f83e1, this.f42088376, this.f4c203b76, this.f560019e4));
    }
}

