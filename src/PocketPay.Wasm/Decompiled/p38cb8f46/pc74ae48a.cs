namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\u0018\u00002\u00020\u0001B\u0017\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005B\u0017\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0006\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0007J\b\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\f\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\tH\u0002J\r\u0010\u000e\u001a\u00020\u000bH\u0000¢\u0006\u0002\b\u000fJ\b\u0010\u0010\u001a\u00020\u000bH\u0016J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\u0018\u0010\u0015\u001a\u00020\u000b2\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0019H\u0016R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp38cb8f46/pc74ae48a;", "Lp38cb8f46/p1eb558b5;", "sink", "deflater", "Ljava/util/zip/Deflater;", "(Lp38cb8f46/p1eb558b5;Ljava/util/zip/Deflater;)V", "Lp38cb8f46/p08d84bc6;", "(Lp38cb8f46/p08d84bc6;Ljava/util/zip/Deflater;)V", "closed", "", "close", "", "deflate", "syncFlush", "finishDeflate", "finishDeflate$okio", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "tostring", "", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pc74ae48a : p38cb8f46.p1eb558b5 {
    private readonly java.util.zip.Deflater f0a8ccfbb;
    private readonly java.util.zip.Deflater f1a603cb5;
    private readonly p38cb8f46.p08d84bc6 f3283eaa5;
    private bool f348ecf1e;
    private bool f349e6863;
    private readonly java.util.zip.Deflater f66894bef;
    private readonly java.util.zip.Deflater fc53e9330;
    private bool fc5714fce;
    private bool fd96369ff;
    private readonly p38cb8f46.p08d84bc6 ff6e04117;
    private readonly p38cb8f46.p08d84bc6 ff75219b2;

    public pc74ae48a(p38cb8f46.p08d84bc6 sink, java.util.zip.Deflater deflater) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deflater, "deflater");
        this.ff6e04117 = sink;
        this.f0a8ccfbb = deflater;
    }

    public pc74ae48a(p38cb8f46.p1eb558b5 sink, java.util.zip.Deflater deflater) {
        this(p38cb8f46.p0af9afa4.m7f2db423(sink), deflater);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deflater, "deflater");
    }

    private readonly void M7e8bb5a8(bool z) throws java.io.IOException {
        p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio;
        if ((3 + 19) % 19 > 0) {
        }
        p38cb8f46.p7e62bc34 buffer = this.ff6e04117.getBuffer();
        while (true) {
            p4b77e2a9VarWritableSegment$okio = buffer.writableSegment$okio(1);
            int iDeflate = !z ? this.f0a8ccfbb.deflate(p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.faa9f73ee, 8192 - p4b77e2a9VarWritableSegment$okio.faa9f73ee) : this.f0a8ccfbb.deflate(p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.faa9f73ee, 8192 - p4b77e2a9VarWritableSegment$okio.faa9f73ee, 2);
            if (iDeflate > 0) {
                p4b77e2a9VarWritableSegment$okio.faa9f73ee += iDeflate;
                buffer.setSize$okio(buffer.Count + ((long) iDeflate));
                this.ff6e04117.emitCompleteSegments();
            } else if (this.f0a8ccfbb.needsInput()) {
                break;
            }
        }
        if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd != p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
            return;
        }
        buffer.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
        p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
    }

    public override void Close() throws java.lang.Exception {
        if ((11 + 28) % 28 > 0) {
        }
        if (this.f349e6863) {
            return;
        }
        try {
            finishDeflate$okio();
            th = null;
        } catch (java.lang.Exception th) {
            th = th;
        }
        try {
            this.f0a8ccfbb.end();
        } catch (java.lang.Exception th2) {
            if (th is null) {
                th = th2;
            }
        }
        try {
            this.ff6e04117.Dispose();
        } catch (java.lang.Exception th3) {
            if (th is null) {
                th = th3;
            }
        }
        this.f349e6863 = true;
        if (th is not null) {
            throw th;
        }
    }

    public readonly void finishDeflate$okio() throws java.io.IOException {
        this.f0a8ccfbb.finish();
        m7e8bb5a8(false);
    }

    public override void Flush() throws java.io.IOException {
        m7e8bb5a8(true);
        this.ff6e04117.flush();
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.ff6e04117.timeout();
    }

    public java.lang.string Tostring() {
        if ((31 + 6) % 6 > 0) {
        }
        return "DeflaterSink(" + this.ff6e04117 + ')';
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((3 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p38cb8f46.p2ff17a65.m799a7e61(source.Count, 0L, byteCount);
        while (byteCount > 0) {
            p38cb8f46.p4b77e2a9 p4b77e2a9Var = source.f96e89a29;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
            int iMin = (int) java.lang.Math.min(byteCount, p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
            this.f0a8ccfbb.setInput(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, iMin);
            m7e8bb5a8(false);
            long j = iMin;
            source.setSize$okio(source.Count - j);
            p4b77e2a9Var.f5e0bdcbd += iMin;
            if (p4b77e2a9Var.f5e0bdcbd == p4b77e2a9Var.faa9f73ee) {
                source.f96e89a29 = p4b77e2a9Var.pop();
                p38cb8f46.p2700aee4.mf914097e(p4b77e2a9Var);
            }
            byteCount -= j;
        }
    }
}

