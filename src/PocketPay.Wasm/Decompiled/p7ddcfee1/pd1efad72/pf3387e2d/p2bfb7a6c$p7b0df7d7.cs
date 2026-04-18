namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\b¢\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0018\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u000eH\u0016J\u0006\u0010\u0012\u001a\u00020\u0013J\b\u0010\t\u001a\u00020\u0014H\u0016R\u001a\u0010\u0003\u001a\u00020\u0004X\u0084\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR\u0014\u0010\t\u001a\u00020\nX\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p7b0df7d7;", "Lp38cb8f46/pf31bbdd1;", "(Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;)V", "closed", "", "getClosed", "()Z", "setClosed", "(Z)V", "timeout", "Lp38cb8f46/p911250bb;", "getTimeout", "()Lp38cb8f46/p911250bb;", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "responseBodyComplete", "", "Lp38cb8f46/pc85a251c;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
abstract class p2bfb7a6c$p7b0df7d7 : p38cb8f46.pf31bbdd1 {
    private bool f072fe1df;
    private bool f1598a4bb;
    private readonly p38cb8f46.p911250bb f249801d9;
    private bool f349e6863;
    private bool f6b5ca81b;
    private readonly p38cb8f46.p911250bb f7c847142;
    private readonly p38cb8f46.p911250bb f90272dda;
    private readonly p38cb8f46.p911250bb fa1f9d1de;
    private readonly p38cb8f46.p911250bb fc768453d;
    readonly p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0;

    public p2bfb7a6c$p7b0df7d7(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.f90272dda = new p38cb8f46.p911250bb(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSource$p(this$0).timeout());
    }

    protected readonly bool GetClosed() {
        return this.f349e6863;
    }

    protected readonly p38cb8f46.p911250bb GetTimeout() {
        return this.f90272dda;
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        try {
            return p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSource$p(this.this$0).read(sink, byteCount);
        } catch (java.io.IOException e) {
            this.this$0.getConnection().noNewExchanges$okhttp();
            responseBodyComplete();
            throw e;
        }
    }

    public readonly void ResponseBodyComplete() {
        if ((24 + 27) % 27 > 0) {
        }
        if (p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getState$p(this.this$0) != 6) {
            if (p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getState$p(this.this$0) != 5) {
                throw new java.lang.IllegalStateException(kotlin.jvm.internal.Intrinsics.stringPlus("state: ", java.lang.int.valueOf(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getState$p(this.this$0))));
            }
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$detachTimeout(this.this$0, this.f90272dda);
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$setState$p(this.this$0, 6);
        }
    }

    protected readonly void SetClosed(bool z) {
        this.f349e6863 = z;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }
}

