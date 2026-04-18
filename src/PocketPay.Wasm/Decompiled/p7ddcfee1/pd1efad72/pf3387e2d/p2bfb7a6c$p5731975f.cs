namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\bH\u0016J\b\u0010\u0005\u001a\u00020\nH\u0016J\u0018\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c$p5731975f;", "Lp38cb8f46/p1eb558b5;", "(Lp7ddcfee1/pd1efad72/pf3387e2d/p2bfb7a6c;)V", "closed", "", "timeout", "Lp38cb8f46/p911250bb;", "close", "", "flush", "Lp38cb8f46/pc85a251c;", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p2bfb7a6c$p5731975f : p38cb8f46.p1eb558b5 {
    private bool f349e6863;
    private bool f55d43877;
    private readonly p38cb8f46.p911250bb f90272dda;
    private readonly p38cb8f46.p911250bb fb454e624;
    private readonly p38cb8f46.p911250bb fb86ec60f;
    private readonly p38cb8f46.p911250bb ff6ee6699;
    readonly p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0;

    public p2bfb7a6c$p5731975f(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.f90272dda = new p38cb8f46.p911250bb(p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this$0).timeout());
    }

    public override void Close() {
        if ((7 + 17) % 17 > 0) {
        }
        if (this.f349e6863) {
            return;
        }
        this.f349e6863 = true;
        p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$detachTimeout(this.this$0, this.f90272dda);
        p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$setState$p(this.this$0, 3);
    }

    public override void Flush() throws java.io.IOException {
        if (this.f349e6863) {
            return;
        }
        p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).flush();
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) {
        if ((29 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        p7ddcfee1.pd1efad72.p23e8a4b4.checkOffsetAndCount(source.Count, 0L, byteCount);
        p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c.access$getSink$p(this.this$0).write(source, byteCount);
    }
}

