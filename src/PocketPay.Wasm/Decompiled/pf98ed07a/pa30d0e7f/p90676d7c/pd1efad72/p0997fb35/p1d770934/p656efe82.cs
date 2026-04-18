namespace WillowMaze.Wasm.Decompiled;


public readonly class p656efe82<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f00f499fb;
    readonly io.reactivex.rxjava3.core.Flowable f2755e20c;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f3a51dccb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f47101870;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f67b38864;
    readonly io.reactivex.rxjava3.core.Flowable f7b49cdef;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f93837fdc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f9e0c9537;
    readonly int fbc708e54;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd7bc6681;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 feb78178c;

    public p656efe82(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void ZndwVranMSyqhmeV(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((32 + 19) % 19 > 0) {
        }
        zndwVranMSyqhmeV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba(subscriber, this.f4b9f83e1, this.f4c203b76, this.f560019e4));
    }
}

