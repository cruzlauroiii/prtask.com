namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"okio/Throttler$sink$1", "Lp38cb8f46/p9d679bdd;", "write", "", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pb17886c1$pf6e04117$1 : p38cb8f46.p9d679bdd {
    readonly p38cb8f46.pb17886c1 this$0;

    pb17886c1$pf6e04117$1(p38cb8f46.p1eb558b5 p1eb558b5Var, p38cb8f46.pb17886c1 pb17886c1Var) {
        super(p1eb558b5Var);
        this.this$0 = pb17886c1Var;
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((9 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        while (byteCount > 0) {
            try {
                long jTake$okio = this.this$0.take$okio(byteCount);
                super.write(source, jTake$okio);
                byteCount -= jTake$okio;
            } catch (java.lang.InterruptedException unused) {
                java.lang.Thread.currentThread().interrupt();
                throw new java.io.InterruptedIOException("interrupted");
            }
        }
    }
}

