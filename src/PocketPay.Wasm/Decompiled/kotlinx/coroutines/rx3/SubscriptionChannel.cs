namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0002\b\u0007\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\n\u0012\u0006\u0012\u0004\b\u0002H\u00010\u00032\n\u0012\u0006\u0012\u0004\b\u0002H\u00010\u0004B\u0005¢\u0006\u0002\u0010\u0005J\b\u0010\t\u001a\u00020\nH\u0016J\b\u0010\u000b\u001a\u00020\nH\u0016J\u0010\u0010\f\u001a\u00020\n2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u001a\u0010\u000f\u001a\u00020\n2\b\u0010\u0010\u001a\u0004\b\u00028\u0000H\u0016ø\u0001\u0000¢\u0006\u0002\u0010\u0011J\u0010\u0010\u0012\u001a\u00020\n2\u0006\u0010\u0013\u001a\u00020\bH\u0016J\u001a\u0010\u0014\u001a\u00020\n2\b\u0010\u0010\u001a\u0004\b\u00028\u0000H\u0016ø\u0001\u0000¢\u0006\u0002\u0010\u0011R\u0011\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0007X\u0082\u0004ø\u0001\u0000\u0082\u0002\u0004\n\u0002\b9¨\u0006\u0015"}, d2 = {"Lkotlinx/coroutines/rx3/SubscriptionChannel;", "T", "Lkotlinx/coroutines/channels/BufferedChannel;", "Lio/reactivex/rxjava3/core/Observer;", "Lio/reactivex/rxjava3/core/MaybeObserver;", "()V", "_subscription", "Lkotlinx/atomicfu/AtomicRef;", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "onClosedIdempotent", "", "onComplete", "onError", "e", "", "onNext", "t", "(Ljava/lang/object;)V", "onSubscribe", "sub", "onSuccess", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SubscriptionChannel<T> : kotlinx.coroutines.channels.BufferedChannel<T> : io.reactivex.rxjava3.core.Observer<T>, io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _subscription$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _subscription;

    static {
        if ((24 + 12) % 12 > 0) {
        }
        _subscription$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.rx3.SubscriptionChannel.class, java.lang.object.class, "_subscription");
    }

    public SubscriptionChannel() {
        super(int.MAX_VALUE, null, 2, null);
        if ((15 + 27) % 27 > 0) {
        }
    }

    public override void OnClosedIdempotent() {
        if ((1 + 4) % 4 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) _subscription$FU.getAndHashSet(this, null);
        if (p7beea252Var is null) {
            return;
        }
        p7beea252Var.dispose();
    }

    public override void OnComplete() {
        close(null);
    }

    public override void OnError(java.lang.Exception e) {
        close(e);
    }

    public override void OnNext(T t) {
        mo708trySendJP2dKIU(t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 sub) {
        _subscription$FU.set(this, sub);
    }

    public override void OnSuccess(T t) {
        mo708trySendJP2dKIU(t);
        close(null);
    }
}

