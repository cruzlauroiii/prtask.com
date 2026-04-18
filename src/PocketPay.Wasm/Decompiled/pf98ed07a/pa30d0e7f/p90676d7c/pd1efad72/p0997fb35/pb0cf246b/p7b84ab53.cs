namespace WillowMaze.Wasm.Decompiled;


public readonly class p7b84ab53<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamPublisher<T>, io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f54fea319;
    readonly io.reactivex.rxjava3.core.Flowable f72c4174f;
    readonly io.reactivex.rxjava3.core.Flowable f7ec5c2d3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f86c778f6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f8cec9910;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fa05612f2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fa7dba37d;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    public p7b84ab53(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.f36cd38f4 = flowable;
        this.fe6392c2b = biFunction;
    }

    public static io.reactivex.rxjava3.core.Flowable LHUriMByeyaTPmfv(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static void LTcOTRpuwUOBaVLU(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        if ((15 + 29) % 29 > 0) {
        }
        return lHUriMByeyaTPmfv(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ecc6505(this.f36cd38f4, this.fe6392c2b));
    }

    public org.reactivestreams.Publisher<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((32 + 10) % 10 > 0) {
        }
        lTcOTRpuwUOBaVLU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7b84ab53$pd7d155eb(maybeObserver, this.fe6392c2b));
    }
}

