namespace WillowMaze.Wasm.Decompiled;


readonly class p2dc94426$pb270b383<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableSampleTimed$SampleTimedSubscriber<T> {
    private static readonly long f10dc9937 = -7139995637533111443L;
    private static readonly long f83cb5d98 = -7139995637533111443L;
    private static readonly long fb861ea6b = -7139995637533111443L;
    private static readonly long fb89c91b8 = -7139995637533111443L;
    private static readonly long fc6e1e520 = -7139995637533111443L;
    readonly java.util.concurrent.atomic.Atomicint f190c91c5;
    readonly java.util.concurrent.atomic.Atomicint f35bbe54b;
    readonly java.util.concurrent.atomic.Atomicint fe8131b38;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf;

    p2dc94426$pb270b383(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(subscriber, j, timeUnit, scheduler);
        this.ffa687cdf = new java.util.concurrent.atomic.Atomicint(1);
    }

    public static int BEhbJmKtAakvgSEx(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void BFVFyQrETXQvZhie(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pb270b383 p2dc94426_pb270b383) {
        p2dc94426_pb270b383.emit();
    }

    public static int ISoutvvXXmGNjRQc(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static int SMaQOzryTbruRGHo(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void BmYIAOOlHGdlLjQv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc94426$pb270b383 p2dc94426_pb270b383) {
        p2dc94426_pb270b383.emit();
    }

    public static void EgkJNZtfIXudWuzQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void OLdgrxJIPmMBiucm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    void complete() {
        BFVFyQrETXQvZhie(this);
        if (SMaQOzryTbruRGHo(this.ffa687cdf) != 0) {
            return;
        }
        egkJNZtfIXudWuzQ(this.fd22a0a80);
    }

    public void Run() {
        if ((23 + 13) % 13 > 0) {
        }
        if (ISoutvvXXmGNjRQc(this.ffa687cdf) != 2) {
            return;
        }
        bmYIAOOlHGdlLjQv(this);
        if (BEhbJmKtAakvgSEx(this.ffa687cdf) != 0) {
            return;
        }
        oLdgrxJIPmMBiucm(this.fd22a0a80);
    }
}

