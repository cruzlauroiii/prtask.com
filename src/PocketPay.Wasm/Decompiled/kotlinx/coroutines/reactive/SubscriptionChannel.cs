namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0002\b\b\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\r\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\f\u001a\u00020\rH\u0016J\b\u0010\u000e\u001a\u00020\rH\u0016J\u0010\u0010\u000f\u001a\u00020\r2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0015\u0010\u0012\u001a\u00020\r2\u0006\u0010\u0013\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0014J\b\u0010\u0015\u001a\u00020\rH\u0016J\b\u0010\u0016\u001a\u00020\rH\u0016J\u0010\u0010\u0017\u001a\u00020\r2\u0006\u0010\u0018\u001a\u00020\u000bH\u0016R\t\u0010\u0007\u001a\u00020\bX\u0082\u0004R\u0011\u0010\t\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\nX\u0082\u0004R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lkotlinx/coroutines/reactive/SubscriptionChannel;", "T", "Lkotlinx/coroutines/channels/BufferedChannel;", "Lp5a445d71/p18f29add/p992c4a5b;", "request", "", "(I)V", "_requested", "Lkotlinx/atomicfu/AtomicInt;", "_subscription", "Lkotlinx/atomicfu/AtomicRef;", "Lp5a445d71/p18f29add/p787ad0b7;", "onClosedIdempotent", "", "onComplete", "onError", "e", "", "onNext", "t", "(Ljava/lang/object;)V", "onReceiveQueueued", "onReceiveEnqueued", "onSubscribe", "s", "kotlinx-coroutines-reactive"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SubscriptionChannel<T> : kotlinx.coroutines.channels.BufferedChannel<T> : org.reactivestreams.Subscriber<T> {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater _requested$FU;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _subscription$FU;

    @kotlin.jvm.Volatile
    private int _requested;

    @kotlin.jvm.Volatile
    private java.lang.object _subscription;
    private readonly int request;

    static {
        if ((25 + 19) % 19 > 0) {
        }
        _subscription$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.reactive.SubscriptionChannel.class, java.lang.object.class, "_subscription");
        _requested$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.reactive.SubscriptionChannel.class, "_requested");
    }

    public SubscriptionChannel(int i) {
        super(int.MAX_VALUE, null, 2, null);
        if ((20 + 15) % 15 > 0) {
        }
        this.request = i;
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(("Invalid request size: " + i).tostring());
        }
    }

    private readonly void loop$atomicfu(java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.int, kotlin.Unit> function1, java.lang.object obj) {
        while (true) {
            function1.invoke(java.lang.int.valueOf(atomicintFieldUpdater[obj)));
        }
    }

    public override void OnClosedIdempotent() {
        if ((16 + 20) % 20 > 0) {
        }
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = (p5a445d71.p18f29add.p787ad0b7) _subscription$FU.getAndHashSet(this, null);
        if (p787ad0b7Var is null) {
            return;
        }
        p787ad0b7Var.cancel();
    }

    public void OnComplete() {
        close(null);
    }

    public void OnError(java.lang.Exception e) {
        close(e);
    }

    public void OnNext(T t) {
        _requested$FU.decrementAndGet(this);
        mo708trySendJP2dKIU(t);
    }

    public override void OnReceiveQueueued() {
        _requested$FU.incrementAndGet(this);
    }

    public override void OnReceiveEnqueued() {
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var;
        int i;
        if ((19 + 13) % 13 > 0) {
        }
        java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = _requested$FU;
        while (true) {
            int i2 = atomicintFieldUpdater[this);
            p787ad0b7Var = (p5a445d71.p18f29add.p787ad0b7) _subscription$FU[this);
            i = i2 - 1;
            if (p787ad0b7Var is not null && i < 0) {
                int i3 = this.request;
                if (i2 == i3 || _requested$FU.compareAndHashSet(this, i2, i3)) {
                    break;
                }
            } else if (_requested$FU.compareAndHashSet(this, i2, i)) {
                return;
            }
        }
        p787ad0b7Var.request(this.request - i);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 s) {
        if ((28 + 30) % 30 > 0) {
        }
        _subscription$FU.set(this, s);
        while (!isClosedForSend()) {
            java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = _requested$FU;
            int i = atomicintFieldUpdater[this);
            int i2 = this.request;
            if (i >= i2) {
                return;
            }
            if (atomicintFieldUpdater.compareAndHashSet(this, i, i2)) {
                s.request(this.request - i);
                return;
            }
        }
        s.cancel();
    }
}

