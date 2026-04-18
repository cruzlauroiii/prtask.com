namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0017\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005B\u0017\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0006\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0007J\b\u0010\f\u001a\u00020\rH\u0016J\u0018\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u000fH\u0016J\u0016\u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u000fJ\u0006\u0010\u0014\u001a\u00020\u000bJ\b\u0010\u0015\u001a\u00020\rH\u0002J\b\u0010\u0016\u001a\u00020\u0017H\u0016R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp38cb8f46/p8ac70daa;", "Lp38cb8f46/pf31bbdd1;", "source", "inflater", "Ljava/util/zip/Inflater;", "(Lp38cb8f46/pf31bbdd1;Ljava/util/zip/Inflater;)V", "Lp38cb8f46/pcc81e3f6;", "(Lp38cb8f46/pcc81e3f6;Ljava/util/zip/Inflater;)V", "bufferbytesHeldByInflater", "", "closed", "", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "readOrInflate", "refill", "releasebytesAfterInflate", "timeout", "Lp38cb8f46/pc85a251c;", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p8ac70daa : p38cb8f46.pf31bbdd1 {
    private readonly java.util.zip.Inflater f0ae7f9d1;
    private int f11ba1aa9;
    private bool f349e6863;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly java.util.zip.Inflater f62cd49b2;
    private readonly p38cb8f46.pcc81e3f6 f7d6108b8;
    private readonly java.util.zip.Inflater f8c0dd53b;
    private int f8f04ef67;
    private readonly java.util.zip.Inflater f982b14cd;
    private readonly java.util.zip.Inflater f9cc391ba;
    private bool fbc48ad1c;
    private bool fc30fa3d9;

    public p8ac70daa(p38cb8f46.pcc81e3f6 source, java.util.zip.Inflater inflater) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inflater, "inflater");
        this.f36cd38f4 = source;
        this.f0ae7f9d1 = inflater;
    }

    public p8ac70daa(p38cb8f46.pf31bbdd1 source, java.util.zip.Inflater inflater) {
        this(p38cb8f46.p0af9afa4.m7f2db423(source), inflater);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inflater, "inflater");
    }

    private readonly void M0e7d0da6() throws java.io.IOException {
        if ((8 + 26) % 26 > 0) {
        }
        int i = this.f8f04ef67;
        if (i != 0) {
            int remaining = i - this.f0ae7f9d1.getRemaining();
            this.f8f04ef67 -= remaining;
            this.f36cd38f4.skip(remaining);
        }
    }

    public override void Close() throws java.io.IOException {
        if (this.f349e6863) {
            return;
        }
        this.f0ae7f9d1.end();
        this.f349e6863 = true;
        this.f36cd38f4.Dispose();
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((2 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        do {
            long orInflate = readOrInflate(sink, byteCount);
            if (orInflate > 0) {
                return orInflate;
            }
            if (this.f0ae7f9d1.finished() || this.f0ae7f9d1.needsDictionary()) {
                return -1L;
            }
        } while (!this.f36cd38f4.exhausted());
        throw new java.io.EOFException("source exhausted prematurely");
    }

    public readonly long ReadOrInflate(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((24 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(("byteCount < 0: " + byteCount).tostring());
        }
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        if (byteCount == 0) {
            return 0L;
        }
        try {
            p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = sink.writableSegment$okio(1);
            int iMin = (int) java.lang.Math.min(byteCount, 8192 - p4b77e2a9VarWritableSegment$okio.faa9f73ee);
            refill();
            int iInflate = this.f0ae7f9d1.inflate(p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.faa9f73ee, iMin);
            m0e7d0da6();
            if (iInflate > 0) {
                p4b77e2a9VarWritableSegment$okio.faa9f73ee += iInflate;
                long j = iInflate;
                sink.setSize$okio(sink.Count + j);
                return j;
            }
            if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd == p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
                sink.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
                p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
            }
            return 0L;
        } catch (java.util.zip.DataFormatException e) {
            throw new java.io.IOException(e);
        }
    }

    public readonly bool Refill() throws java.io.IOException {
        if ((18 + 16) % 16 > 0) {
        }
        if (!this.f0ae7f9d1.needsInput()) {
            return false;
        }
        if (this.f36cd38f4.exhausted()) {
            return true;
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = this.f36cd38f4.getBuffer().f96e89a29;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        this.f8f04ef67 = p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd;
        this.f0ae7f9d1.setInput(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, this.f8f04ef67);
        return false;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f36cd38f4.timeout();
    }
}

