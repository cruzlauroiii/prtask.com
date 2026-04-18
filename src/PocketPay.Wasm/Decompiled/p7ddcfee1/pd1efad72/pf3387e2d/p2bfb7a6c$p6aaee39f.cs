namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00060\u0001R\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\tH\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p6aaee39f;", "Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p7b0df7d7;", "Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;", "(Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;)V", "inputExhausted", "", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p2bfb7a6c$p6aaee39f : p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c$p7b0df7d7 {
    private bool f136419f5;
    private bool f89427c57;
    private bool feafee9de;
    private bool ffcefb445;
    readonly p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0;

    public p2bfb7a6c$p6aaee39f(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0) {
        super(this$0);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
    }

    public override void Close() {
        if (getClosed()) {
            return;
        }
        if (!this.f136419f5) {
            responseBodyComplete();
        }
        setClosed(true);
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((27 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("byteCount < 0: ", java.lang.long.valueOf(byteCount)).tostring());
        }
        if (getClosed()) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        if (this.f136419f5) {
            return -1L;
        }
        long j = super.read(sink, byteCount);
        if (j != -1) {
            return j;
        }
        this.f136419f5 = true;
        responseBodyComplete();
        return -1L;
    }
}

