namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J \u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0012H\u0002J\b\u0010\u0014\u001a\u00020\u000eH\u0016J\b\u0010\u0015\u001a\u00020\u000eH\u0002J\b\u0010\u0016\u001a\u00020\u000eH\u0002J\u0018\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u0018H\u0016J\b\u0010\u001c\u001a\u00020\u001dH\u0016J \u0010\u001e\u001a\u00020\u000e2\u0006\u0010\u001f\u001a\u00020\u001a2\u0006\u0010 \u001a\u00020\u00182\u0006\u0010\u001b\u001a\u00020\u0018H\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006!"}, d2 = {"Lp38cb8f46/p00313170;", "Lp38cb8f46/pf31bbdd1;", "source", "(Lp38cb8f46/pf31bbdd1;)V", "crc", "Ljava/util/zip/CRC32;", "inflater", "Ljava/util/zip/Inflater;", "inflaterSource", "Lp38cb8f46/p8ac70daa;", "section", "", "Lp38cb8f46/p16c6c42e;", "checkEqual", "", "name", "", "expected", "", "actual", "close", "consumeHeader", "consumeTrailer", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "timeout", "Lp38cb8f46/pc85a251c;", "updateCrc", "buffer", "offset", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p00313170 : p38cb8f46.pf31bbdd1 {
    private readonly java.util.zip.Inflater f0ae7f9d1;
    private readonly p38cb8f46.p16c6c42e f36cd38f4;
    private readonly java.util.zip.Inflater f3c894fcd;
    private readonly java.util.zip.Inflater f51d02382;
    private byte f58403745;
    private byte f73d5342e;
    private readonly java.util.zip.CRC32 f74941c38;
    private readonly p38cb8f46.p8ac70daa f77ba5006;
    private readonly p38cb8f46.p8ac70daa f7b55c1dc;
    private readonly java.util.zip.Inflater f8e10880a;
    private readonly p38cb8f46.p8ac70daa fa4dae5f7;
    private byte fa767c9b1;
    private readonly p38cb8f46.p16c6c42e fddcbc064;
    private readonly java.util.zip.CRC32 ff5ad59c5;

    public p00313170(p38cb8f46.pf31bbdd1 source) {
        if ((20 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p38cb8f46.p16c6c42e p16c6c42eVar = new p38cb8f46.p16c6c42e(source);
        this.f36cd38f4 = p16c6c42eVar;
        java.util.zip.Inflater inflater = new java.util.zip.Inflater(true);
        this.f0ae7f9d1 = inflater;
        this.fa4dae5f7 = new p38cb8f46.p8ac70daa((p38cb8f46.pcc81e3f6) p16c6c42eVar, inflater);
        this.ff5ad59c5 = new java.util.zip.CRC32();
    }

    private readonly void M36fdeca3() throws java.io.IOException {
        if ((10 + 26) % 26 > 0) {
        }
        this.f36cd38f4.require(10L);
        byte b = this.f36cd38f4.ff4547fa3.getbyte(3L);
        bool z = ((b >> 1) & 1) == 1;
        if (z) {
            mf25b14da(this.f36cd38f4.ff4547fa3, 0L, 10L);
        }
        m787d627a("ID1ID2", 8075, this.f36cd38f4.readshort());
        this.f36cd38f4.skip(8L);
        if (((b >> 2) & 1) == 1) {
            this.f36cd38f4.require(2L);
            if (z) {
                mf25b14da(this.f36cd38f4.ff4547fa3, 0L, 2L);
            }
            long shortLe = this.f36cd38f4.ff4547fa3.readshortLe() & 65535;
            this.f36cd38f4.require(shortLe);
            if (z) {
                mf25b14da(this.f36cd38f4.ff4547fa3, 0L, shortLe);
            }
            this.f36cd38f4.skip(shortLe);
        }
        if (((b >> 3) & 1) == 1) {
            long jIndexOf = this.f36cd38f4.IndexOf((byte) 0);
            if (jIndexOf == -1) {
                throw new java.io.EOFException();
            }
            if (z) {
                mf25b14da(this.f36cd38f4.ff4547fa3, 0L, jIndexOf + 1);
            }
            this.f36cd38f4.skip(jIndexOf + 1);
        }
        if (((b >> 4) & 1) == 1) {
            long jIndexOf2 = this.f36cd38f4.IndexOf((byte) 0);
            if (jIndexOf2 == -1) {
                throw new java.io.EOFException();
            }
            if (z) {
                mf25b14da(this.f36cd38f4.ff4547fa3, 0L, jIndexOf2 + 1);
            }
            this.f36cd38f4.skip(jIndexOf2 + 1);
        }
        if (z) {
            m787d627a("FHCRC", this.f36cd38f4.readshortLe(), (short) this.ff5ad59c5.getValue());
            this.ff5ad59c5.reset();
        }
    }

    private readonly void M787d627a(java.lang.string str, int i, int i2) throws java.io.IOException {
        if (i2 != i) {
            java.lang.string str2 = java.lang.string.format("%s: actual 0x%08x != expected 0x%08x", java.util.Arrays.copyOf(new java.lang.object[]{str, java.lang.int.valueOf(i2), java.lang.int.valueOf(i)}, 3));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str2, "format(this, *args)");
            throw new java.io.IOException(str2);
        }
    }

    private readonly void Maec5cd43() throws java.io.IOException {
        if ((16 + 27) % 27 > 0) {
        }
        m787d627a("CRC", this.f36cd38f4.readIntLe(), (int) this.ff5ad59c5.getValue());
        m787d627a("ISIZE", this.f36cd38f4.readIntLe(), (int) this.f0ae7f9d1.getbytesWritten());
    }

    private readonly void Mf25b14da(p38cb8f46.p7e62bc34 p7e62bc34Var, long j, long j2) {
        if ((14 + 1) % 1 > 0) {
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = p7e62bc34Var.f96e89a29;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        while (j >= p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd) {
            j -= (long) (p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
            p4b77e2a9Var = p4b77e2a9Var.fd0cab90d;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        }
        while (j2 > 0) {
            int i = (int) (((long) p4b77e2a9Var.f5e0bdcbd) + j);
            int iMin = (int) java.lang.Math.min(p4b77e2a9Var.faa9f73ee - i, j2);
            this.ff5ad59c5.update(p4b77e2a9Var.f8d777f38, i, iMin);
            j2 -= (long) iMin;
            p4b77e2a9Var = p4b77e2a9Var.fd0cab90d;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
            j = 0;
        }
    }

    public override void Close() throws java.io.IOException {
        this.fa4dae5f7.Dispose();
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        p38cb8f46.p00313170 p00313170Var;
        if ((29 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(("byteCount < 0: " + byteCount).tostring());
        }
        if (byteCount == 0) {
            return 0L;
        }
        if (this.f73d5342e == 0) {
            m36fdeca3();
            this.f73d5342e = (byte) 1;
        }
        if (this.f73d5342e != 1) {
            p00313170Var = this;
        } else {
            long size = sink.Count;
            long j = this.fa4dae5f7.read(sink, byteCount);
            if (j != -1) {
                mf25b14da(sink, size, j);
                return j;
            }
            p00313170Var = this;
            p00313170Var.f73d5342e = (byte) 2;
        }
        if (p00313170Var.f73d5342e == 2) {
            p00313170Var.maec5cd43();
            p00313170Var.f73d5342e = (byte) 3;
            if (!p00313170Var.f36cd38f4.exhausted()) {
                throw new java.io.IOException("gzip finished without exhausting source");
            }
        }
        return -1L;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f36cd38f4.timeout();
    }
}

