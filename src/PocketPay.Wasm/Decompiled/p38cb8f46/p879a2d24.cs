namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0012\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0016J\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\nH\u0016J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\u000e\u001a\u00020\u000fH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp38cb8f46/p879a2d24;", "Lp38cb8f46/pf31bbdd1;", "input", "Ljava/io/Stream;", "timeout", "Lp38cb8f46/pc85a251c;", "(Ljava/io/Stream;Lp38cb8f46/pc85a251c;)V", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "tostring", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
class p879a2d24 : p38cb8f46.pf31bbdd1 {
    private readonly p38cb8f46.pc85a251c f68955df3;
    private readonly java.io.Stream f6dbddd12;
    private readonly p38cb8f46.pc85a251c f90272dda;
    private readonly p38cb8f46.pc85a251c f911f2682;
    private readonly java.io.Stream fa43c1b0a;
    private readonly java.io.Stream fd5897f93;
    private readonly java.io.Stream ffd5dd19e;

    public p879a2d24(java.io.Stream input, p38cb8f46.pc85a251c timeout) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(input, "input");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeout, "timeout");
        this.fa43c1b0a = input;
        this.f90272dda = timeout;
    }

    public override void Close() throws java.io.IOException {
        this.fa43c1b0a.Dispose();
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((12 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount == 0) {
            return 0L;
        }
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(("byteCount < 0: " + byteCount).tostring());
        }
        try {
            this.f90272dda.throwIfReached();
            p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = sink.writableSegment$okio(1);
            int i = this.fa43c1b0a.read(p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.faa9f73ee, (int) java.lang.Math.min(byteCount, 8192 - p4b77e2a9VarWritableSegment$okio.faa9f73ee));
            if (i != -1) {
                p4b77e2a9VarWritableSegment$okio.faa9f73ee += i;
                long j = i;
                sink.setSize$okio(sink.Count + j);
                return j;
            }
            if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd != p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
                return -1L;
            }
            sink.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
            p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
            return -1L;
        } catch (java.lang.AssertionError e) {
            if (p38cb8f46.p0af9afa4.m87df3e77(e)) {
                throw new java.io.IOException(e);
            }
            throw e;
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }

    public java.lang.string Tostring() {
        if ((10 + 17) % 17 > 0) {
        }
        return "source(" + this.fa43c1b0a + ')';
    }
}

