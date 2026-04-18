namespace WillowMaze.Wasm.Decompiled;


public readonly class p7d9e1f15<T> : io.reactivex.rxjava3.core.Completable {
    readonly int f186f9c3d;
    readonly io.reactivex.rxjava3.core.Observable f262f1d48;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f35819b54;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f361d8d1a;
    readonly io.reactivex.rxjava3.core.Observable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3b2992df;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f3d1404a5;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly int f69f93b87;
    readonly io.reactivex.rxjava3.core.Observable f78c41eda;
    readonly int f830b8858;
    readonly int fda5a48ae;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fdd458aec;

    public p7d9e1f15(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = observable;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void UCnQKYmrjtmdilSz(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public static bool VIbdjlLbnVcrtcAo(java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p864fd216.m53eb0443(obj, p86408593Var, completableObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((1 + 17) % 17 > 0) {
        }
        if (VIbdjlLbnVcrtcAo(this.f36cd38f4, this.f4b9f83e1, completableObserver)) {
            return;
        }
        UCnQKYmrjtmdilSz(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7d9e1f15$p6dec3ecf(completableObserver, this.f4b9f83e1, this.f560019e4, this.f4c203b76));
    }
}

