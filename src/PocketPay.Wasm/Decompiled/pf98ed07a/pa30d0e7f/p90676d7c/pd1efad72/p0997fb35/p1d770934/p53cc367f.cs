namespace WillowMaze.Wasm.Decompiled;


public readonly class p53cc367f<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.Flowable f21cae814;
    readonly int f2c6cc0a1;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly io.reactivex.rxjava3.core.Flowable f4e7459a0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f5d7bcca6;
    readonly int f8105340b;
    readonly io.reactivex.rxjava3.core.Flowable f8fe2702c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f916ae888;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fb84f0072;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe03313cb;
    readonly int fe12ae790;
    readonly io.reactivex.rxjava3.core.Flowable fe1daa13d;

    public p53cc367f(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void UWjskhhXhfxrRkuB(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((4 + 16) % 16 > 0) {
        }
        UWjskhhXhfxrRkuB(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1(subscriber, this.f4b9f83e1, this.f4c203b76, this.f560019e4));
    }
}

