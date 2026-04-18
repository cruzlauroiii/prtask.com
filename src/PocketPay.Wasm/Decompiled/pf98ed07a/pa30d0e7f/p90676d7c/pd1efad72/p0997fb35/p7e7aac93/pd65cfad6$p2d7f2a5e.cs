namespace WillowMaze.Wasm.Decompiled;


readonly class pd65cfad6$p2d7f2a5e<T> : java.util.concurrent.ConcurrentLinkedQueue<T> : io.reactivex.rxjava3.internal.operators.maybe.MaybeMergeArray$SimpleQueueWithConsumerIndex<T> {
    private static readonly long f2be65482 = -4025173261791142821L;
    private static readonly long f66cd9ef8 = -4025173261791142821L;
    private static readonly long f8a267f64 = -4025173261791142821L;
    private static readonly long fc6e1e520 = -4025173261791142821L;
    readonly java.util.concurrent.atomic.Atomicint f87c332e5 = new java.util.concurrent.atomic.Atomicint();
    int fa0c91d05;
    int fb9a53da1;
    readonly java.util.concurrent.atomic.Atomicint fd229858a;

    pd65cfad6$p2d7f2a5e() {
    }

    public static java.lang.object IpBNTnuDreGRfGCM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p2d7f2a5e pd65cfad6_p2d7f2a5e) {
        return pd65cfad6_p2d7f2a5e.poll();
    }

    public static int RIBxBhACreKjykxj(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static java.lang.object CcbGNcnapByRvUoF(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue) {
        return super.poll();
    }

    public static bool FrhXpPqUTLMOemVo(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue, java.lang.object obj) {
        return super.offer(obj);
    }

    public static int HzjyswBGUomLRcaV(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public int ConsumerIndex() {
        return this.fa0c91d05;
    }

    public void Drop() {
        IpBNTnuDreGRfGCM(this);
    }

    public override bool Offer(T t) {
        hzjyswBGUomLRcaV(this.f87c332e5);
        return frhXpPqUTLMOemVo(this, t);
    }

    public bool Offer(T t, T t2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override T Poll() {
        if ((27 + 25) % 25 > 0) {
        }
        T t = (T) ccbGNcnapByRvUoF(this);
        if (t is not null) {
            this.fa0c91d05++;
        }
        return t;
    }

    public int ProducerIndex() {
        return RIBxBhACreKjykxj(this.f87c332e5);
    }
}

