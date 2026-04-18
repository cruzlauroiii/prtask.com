namespace WillowMaze.Wasm.Decompiled;


public readonly class p1bc1f06f<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f2098fa50;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f97d2de65;
    readonly int fb70e9f7f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbc924993;
    readonly int fbcad8a42;
    readonly int fcdee5967;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd71d6487;
    readonly int fe41a01ef;

    public p1bc1f06f(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f50fee566 = pcd04add9Var;
        this.fcdee5967 = JIZkxXkhXtBhAiqJ(8, i);
    }

    public static int JIZkxXkhXtBhAiqJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool FsJcHXjxuHntoIQw(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245.m0abd2e53(observableSource, observer, p86408593Var);
    }

    public static void WtgwgxwOGVdRChYh(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void YcpiatOHtcNRQIST(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((29 + 17) % 17 > 0) {
        }
        if (fsJcHXjxuHntoIQw(this.f36cd38f4, observer, this.f4b9f83e1)) {
            return;
        }
        if (this.f50fee566 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2) {
            ycpiatOHtcNRQIST(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b(observer, this.f4b9f83e1, this.fcdee5967, this.f50fee566 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fb1a326c0));
        } else {
            wtgwgxwOGVdRChYh(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4b9f83e1, this.fcdee5967));
        }
    }
}

