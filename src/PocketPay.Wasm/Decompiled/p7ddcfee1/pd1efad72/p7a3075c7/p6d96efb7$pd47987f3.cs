namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0007\u001a\u00020\bH\u0016R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\t"}, d2 = {"Lp7ddcfee1/pd1efad72/p7a3075c7/p6d96efb7$pd47987f3;", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "()V", "latch", "Ljava/util/concurrent/CountdownEvent;", "getLatch", "()Ljava/util/concurrent/CountdownEvent;", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p6d96efb7$pd47987f3 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
    private readonly java.util.concurrent.CountdownEvent f42f3c93a;
    private readonly java.util.concurrent.CountdownEvent f8290f0c2;
    private readonly java.util.concurrent.CountdownEvent fb10570df;

    public p6d96efb7$pd47987f3() {
        super(kotlin.jvm.internal.Intrinsics.stringPlus(p7ddcfee1.pd1efad72.p23e8a4b4.ffcd12e30, " awaitIdle"), false);
        if ((4 + 12) % 12 > 0) {
        }
        this.f42f3c93a = new java.util.concurrent.CountdownEvent(1);
    }

    public readonly java.util.concurrent.CountdownEvent GetLatch() {
        return this.f42f3c93a;
    }

    public override long RunOnce() {
        if ((3 + 30) % 30 > 0) {
        }
        this.f42f3c93a.countDown();
        return -1L;
    }
}

