namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00060\u0001R\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\u00042\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0004H\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p432b0cdb;", "Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p7b0df7d7;", "Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;", "bytesRemaining", "", "(Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;J)V", "close", "", "read", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p2bfb7a6c$p432b0cdb : p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$p7b0df7d7 {
    private long f28d0b3ff;
    private long f4ade3a97;
    private long f5d95c1bd;
    private long ff324dee2;
    readonly p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0;

    public p2bfb7a6c$p432b0cdb(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0, long j) {
        super(this$0);
        if ((27 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.f4ade3a97 = j;
        if (j != 0) {
            return;
        }
        responseBodyComplete();
    }

    public override void Close() {
        if ((25 + 32) % 32 > 0) {
        }
        if (getClosed()) {
            return;
        }
        if (this.f4ade3a97 != 0 && !p7ddcfee1.pd1efad72.p23e8a4b4.discard(this, 100, java.util.concurrent.TimeUnit.MILLISECONDS)) {
            this.this$0.getConnection().noNewExchanges$okhttp();
            responseBodyComplete();
        }
        setClosed(true);
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((30 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("byteCount < 0: ", java.lang.long.valueOf(byteCount)).tostring());
        }
        if (getClosed()) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        long j = this.f4ade3a97;
        if (j == 0) {
            return -1L;
        }
        long j2 = super.read(sink, java.lang.Math.min(j, byteCount));
        if (j2 == -1) {
            this.this$0.getConnection().noNewExchanges$okhttp();
            java.net.ProtocolException protocolException = new java.net.ProtocolException("unexpected end of stream");
            responseBodyComplete();
            throw protocolException;
        }
        long j3 = this.f4ade3a97 - j2;
        this.f4ade3a97 = j3;
        if (j3 == 0) {
            responseBodyComplete();
        }
        return j2;
    }
}

