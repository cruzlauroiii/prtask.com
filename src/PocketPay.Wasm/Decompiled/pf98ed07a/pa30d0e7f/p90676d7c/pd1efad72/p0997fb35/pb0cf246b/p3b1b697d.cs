namespace WillowMaze.Wasm.Decompiled;


public readonly class p3b1b697d<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f4dce97e4;
    readonly long f6a992d55;
    readonly long f844ca306;
    readonly long f865bff11;
    readonly long f894925db;
    readonly io.reactivex.rxjava3.core.Flowable fa3c8bb9e;
    readonly io.reactivex.rxjava3.core.Flowable ff1a1d441;

    public p3b1b697d(io.reactivex.rxjava3.core.Flowable<T> flowable, long j) {
        this.f36cd38f4 = flowable;
        this.f6a992d55 = j;
    }

    public static io.reactivex.rxjava3.core.Flowable HERTLXwzRKAjgcte(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static void GulUZGtvSGQYxnlJ(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        if ((1 + 24) % 24 > 0) {
        }
        return HERTLXwzRKAjgcte(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc7931aa6(this.f36cd38f4, this.f6a992d55, null, false));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((24 + 15) % 15 > 0) {
        }
        gulUZGtvSGQYxnlJ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p3b1b697d$p6b4417bd(maybeObserver, this.f6a992d55));
    }
}

