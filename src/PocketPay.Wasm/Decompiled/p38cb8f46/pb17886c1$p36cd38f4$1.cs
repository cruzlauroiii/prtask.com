namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0003H\u0016¨\u0006\u0007"}, d2 = {"okio/Throttler$source$1", "Lp38cb8f46/pe86e8b35;", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pb17886c1$p36cd38f4$1 : p38cb8f46.pe86e8b35 {
    readonly p38cb8f46.pb17886c1 this$0;

    pb17886c1$p36cd38f4$1(p38cb8f46.pf31bbdd1 pf31bbdd1Var, p38cb8f46.pb17886c1 pb17886c1Var) {
        super(pf31bbdd1Var);
        this.this$0 = pb17886c1Var;
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.InterruptedIOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        try {
            return super.read(sink, this.this$0.take$okio(byteCount));
        } catch (java.lang.InterruptedException unused) {
            java.lang.Thread.currentThread().interrupt();
            throw new java.io.InterruptedIOException("interrupted");
        }
    }
}

