namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\r\u0010\b\u001a\u00020\tH\u0007¢\u0006\u0002\b\u0010J\b\u0010\u0011\u001a\u00020\u000fH\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\u0018\u0010\u0014\u001a\u00020\u000f2\u0006\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u0018H\u0002J\u0018\u0010\u0019\u001a\u00020\u000f2\u0006\u0010\u001a\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u0018H\u0016J\b\u0010\u001b\u001a\u00020\u000fH\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0013\u0010\b\u001a\u00020\t8G¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\nR\u000e\u0010\u000b\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Lp38cb8f46/p6599673d;", "Lp38cb8f46/p1eb558b5;", "sink", "(Lp38cb8f46/p1eb558b5;)V", "closed", "", "crc", "Ljava/util/zip/CRC32;", "deflater", "Ljava/util/zip/Deflater;", "()Ljava/util/zip/Deflater;", "deflaterSink", "Lp38cb8f46/pc74ae48a;", "Lp38cb8f46/pd84c6f13;", "close", "", "-deprecated_deflater", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "updateCrc", "buffer", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "write", "source", "writeFooter", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p6599673d : p38cb8f46.p1eb558b5 {
    private readonly java.util.zip.Deflater f0a8ccfbb;
    private readonly p38cb8f46.pc74ae48a f0ef1f65f;
    private readonly p38cb8f46.pc74ae48a f23bbdcd9;
    private bool f349e6863;
    private readonly p38cb8f46.pd84c6f13 f3ac8faae;
    private readonly p38cb8f46.pc74ae48a f3f80f324;
    private readonly java.util.zip.CRC32 f519e06fd;
    private readonly java.util.zip.Deflater f71e1f7f8;
    private readonly p38cb8f46.pc74ae48a f7520b2e7;
    private bool f7b91e6ff;
    private bool f7beecdc7;
    private readonly p38cb8f46.pd84c6f13 f8b00f30b;
    private readonly java.util.zip.CRC32 fb657b70d;
    private bool fbeb91ad1;
    private readonly java.util.zip.CRC32 fc5cf5dcd;
    private readonly p38cb8f46.pd84c6f13 fe6036ed6;
    private bool fed7054c0;
    private readonly java.util.zip.CRC32 ff5ad59c5;
    private readonly java.util.zip.Deflater ff66f6876;
    private readonly p38cb8f46.pd84c6f13 ff6e04117;

    public p6599673d(p38cb8f46.p1eb558b5 sink) {
        if ((25 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        p38cb8f46.pd84c6f13 pd84c6f13Var = new p38cb8f46.pd84c6f13(sink);
        this.ff6e04117 = pd84c6f13Var;
        java.util.zip.Deflater deflater = new java.util.zip.Deflater(-1, true);
        this.f0a8ccfbb = deflater;
        this.f7520b2e7 = new p38cb8f46.pc74ae48a((p38cb8f46.p08d84bc6) pd84c6f13Var, deflater);
        this.ff5ad59c5 = new java.util.zip.CRC32();
        p38cb8f46.p7e62bc34 p7e62bc34Var = pd84c6f13Var.ff4547fa3;
        p7e62bc34Var.writeshort(8075);
        p7e62bc34Var.writebyte(8);
        p7e62bc34Var.writebyte(0);
        p7e62bc34Var.writeInt(0);
        p7e62bc34Var.writebyte(0);
        p7e62bc34Var.writebyte(0);
    }

    private readonly void M1220607c() {
        if ((32 + 16) % 16 > 0) {
        }
        this.ff6e04117.writeIntLe((int) this.ff5ad59c5.getValue());
        this.ff6e04117.writeIntLe((int) this.f0a8ccfbb.getbytesRead());
    }

    private readonly void Mf25b14da(p38cb8f46.p7e62bc34 p7e62bc34Var, long j) {
        if ((11 + 11) % 11 > 0) {
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = p7e62bc34Var.f96e89a29;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        while (j > 0) {
            int iMin = (int) java.lang.Math.min(j, p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
            this.ff5ad59c5.update(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, iMin);
            j -= (long) iMin;
            p4b77e2a9Var = p4b77e2a9Var.fd0cab90d;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        }
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "deflater", imports = {}))
    public readonly java.util.zip.Deflater M3616deprecatedDeflater() {
        return this.f0a8ccfbb;
    }

    public override void Close() throws java.lang.Exception {
        if ((7 + 3) % 3 > 0) {
        }
        if (this.f349e6863) {
            return;
        }
        try {
            this.f7520b2e7.finishDeflate$okio();
            m1220607c();
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

    public readonly java.util.zip.Deflater Deflater() {
        return this.f0a8ccfbb;
    }

    public override void Flush() throws java.io.IOException {
        this.f7520b2e7.flush();
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.ff6e04117.timeout();
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((26 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(("byteCount < 0: " + byteCount).tostring());
        }
        if (byteCount != 0) {
            mf25b14da(source, byteCount);
            this.f7520b2e7.write(source, byteCount);
        }
    }
}

