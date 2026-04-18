namespace WillowMaze.Wasm.Decompiled;


public readonly class p0b7c3921<T> : io.reactivex.rxjava3.core.Completable {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f08d9af04;
    readonly int f09134106;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f41c150b9;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly int f4c203b76;
    readonly io.reactivex.rxjava3.core.Flowable f4e0865ef;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f74de2a77;
    readonly int f77920c9b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8439a12a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb10bff5c;
    readonly io.reactivex.rxjava3.core.Flowable fce7a633d;
    readonly io.reactivex.rxjava3.core.Flowable fcf3f0d76;

    public p0b7c3921(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void LoafhYPffEgDjAMx(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((23 + 16) % 16 > 0) {
        }
        loafhYPffEgDjAMx(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf(completableObserver, this.f4b9f83e1, this.f560019e4, this.f4c203b76));
    }
}

