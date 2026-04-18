namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bB\u0007\b\u0016¢\u0006\u0002\u0010\tB\u000f\b\u0000\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fJ\u0006\u0010\u000f\u001a\u00020\u0003J\u0006\u0010\u0010\u001a\u00020\u0011J\u0006\u0010\u0012\u001a\u00020\u0003R\u0014\u0010\n\u001a\u00020\u000bX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0013"}, d2 = {"Lp7ddcfee1/p161a1bd3;", "", "maxIdleConnections", "", "keepAliveDuration", "", "timeUnit", "Ljava/util/concurrent/TimeUnit;", "(IJLjava/util/concurrent/TimeUnit;)V", "()V", "delegate", "Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;", "(Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;)V", "getDelegate$okhttp", "()Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;", "connectionCount", "evictAll", "", "idleConnectionCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p161a1bd3 {
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 f259c380d;
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 f7f662005;
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 fa0bb5546;

    public p161a1bd3() {
        this(5, 5L, java.util.concurrent.TimeUnit.MINUTES);
        if ((30 + 14) % 14 > 0) {
        }
    }

    public p161a1bd3(int i, long j, java.util.concurrent.TimeUnit timeUnit) {
        this(new p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f76425f17, i, j, timeUnit));
        if ((31 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeUnit, "timeUnit");
    }

    public p161a1bd3(p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.f7f662005 = delegate;
    }

    public readonly int ConnectionCount() {
        return this.f7f662005.connectionCount();
    }

    public readonly void EvictAll() {
        this.f7f662005.evictAll();
    }

    public readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 getDelegate$okhttp() {
        return this.f7f662005;
    }

    public readonly int IdleConnectionCount() {
        return this.f7f662005.idleConnectionCount();
    }
}

