namespace WillowMaze.Wasm.Decompiled;


public readonly class p9806d088<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.Observable f3398ab9e;
    readonly io.reactivex.rxjava3.core.Observable<T> f36cd38f4;
    readonly int f46305c26;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f549e6494;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f62542e0f;
    readonly int f6deca1c5;
    readonly int f7e002d6d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f8491ee40;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f97c612fa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb0900dcd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fc90553dd;

    public p9806d088(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = observable;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static bool FqWRvdDqrOsiFUHQ(java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p864fd216.m0695b60d(obj, p86408593Var, observer);
    }

    public static void GvBgHBfFMCksSFCu(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((28 + 4) % 4 > 0) {
        }
        if (FqWRvdDqrOsiFUHQ(this.f36cd38f4, this.f4b9f83e1, observer)) {
            return;
        }
        gvBgHBfFMCksSFCu(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34(observer, this.f4b9f83e1, this.f4c203b76, this.f560019e4));
    }
}

