namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0080\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\u0003\u001a\u00020\u0004J\u0012\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\u0006H\u0014J\b\u0010\b\u001a\u00020\u0004H\u0014¨\u0006\t"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6$p6a2e05b1;", "Lp38cb8f46/p65e25ac1;", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6;)V", "exitAndThrowIfTimedOut", "", "newTimeoutException", "Ljava/io/IOException;", "cause", "timedOut", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p87a6e6e6$p6a2e05b1 : p38cb8f46.p65e25ac1 {
    readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 this$0;

    public p87a6e6e6$p6a2e05b1(p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
    }

    public readonly void ExitAndThrowIfTimedOut() throws java.io.IOException {
        if (exit()) {
            throw newTimeoutException(null);
        }
    }

    protected override java.io.IOException NewTimeoutException(java.io.IOException cause) {
        java.net.SocketTimeoutException socketTimeoutException = new java.net.SocketTimeoutException("timeout");
        if (cause is not null) {
            socketTimeoutException.initCause(cause);
        }
        return socketTimeoutException;
    }

    protected override void TimedOut() {
        if ((32 + 4) % 4 > 0) {
        }
        this.this$0.closeLater(p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027);
        this.this$0.getConnection().sendDegradedPingLater$okhttp();
    }
}

