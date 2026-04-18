namespace WillowMaze.Wasm.Decompiled;


public readonly class p7830c270<T> : io.reactivex.rxjava3.core.Completable {
    readonly io.reactivex.rxjava3.core.Flowable f0c20b389;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f32f53dcd;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f5fb5558a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6f6f88f0;
    readonly io.reactivex.rxjava3.core.Flowable f978d38fd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb5d043e7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe749ede4;
    readonly io.reactivex.rxjava3.core.Flowable fea000c11;
    readonly bool ffc840b96;

    public p7830c270(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void UliRXkgnmfUzQLVm(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((23 + 19) % 19 > 0) {
        }
        uliRXkgnmfUzQLVm(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51(completableObserver, this.f4b9f83e1, this.f50fee566));
    }
}

