namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\r\u001a\u00020\u000eH\u0016J\n\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0002J\b\u0010\u0011\u001a\u00020\u000eH\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\u0018\u0010\u0014\u001a\u00020\b2\u0006\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u0018H\u0002J\u0018\u0010\u0019\u001a\u00020\u000e2\u0006\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u001a\u001a\u00020\u0018H\u0016R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp38cb8f46/p6c7261ea;", "Lp38cb8f46/p1eb558b5;", "sink", "Lp38cb8f46/p08d84bc6;", "cipher", "Ljavax/crypto/Cipher;", "(Lp38cb8f46/p08d84bc6;Ljavax/crypto/Cipher;)V", "blockSize", "", "getCipher", "()Ljavax/crypto/Cipher;", "closed", "", "close", "", "doFinal", "", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "update", "source", "Lp38cb8f46/p7e62bc34;", "remaining", "", "write", "byteCount", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p6c7261ea : p38cb8f46.p1eb558b5 {
    private readonly javax.crypto.Cipher f08406a6e;
    private bool f349e6863;
    private readonly int f373e7ef2;
    private readonly int f480d1b61;
    private readonly p38cb8f46.p08d84bc6 f4c81a9a3;
    private bool f51152a4e;
    private readonly p38cb8f46.p08d84bc6 fa56217df;
    private readonly p38cb8f46.p08d84bc6 fb8fd3540;
    private readonly p38cb8f46.p08d84bc6 fbc36bc54;
    private readonly javax.crypto.Cipher fe9568526;
    private readonly p38cb8f46.p08d84bc6 ff6e04117;

    public p6c7261ea(p38cb8f46.p08d84bc6 sink, javax.crypto.Cipher cipher) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cipher, "cipher");
        this.ff6e04117 = sink;
        this.f08406a6e = cipher;
        int blockSize = cipher.getBlockSize();
        this.f480d1b61 = blockSize;
        if (blockSize <= 0) {
            throw new java.lang.IllegalArgumentException(("Block cipher required " + cipher).tostring());
        }
    }

    private readonly int M3ac34083(p38cb8f46.p7e62bc34 p7e62bc34Var, long j) throws java.io.IOException, javax.crypto.shortBufferException {
        if ((20 + 28) % 28 > 0) {
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = p7e62bc34Var.f96e89a29;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        int iMin = (int) java.lang.Math.min(j, p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
        p38cb8f46.p7e62bc34 buffer = this.ff6e04117.getBuffer();
        int outputSize = this.f08406a6e.getOutputSize(iMin);
        int i = iMin;
        while (outputSize > 8192) {
            int i2 = this.f480d1b61;
            if (i <= i2) {
                p38cb8f46.p08d84bc6 p08d84bc6Var = this.ff6e04117;
                byte[] bArrUpdate = this.f08406a6e.update(p7e62bc34Var.readbyteArray(j));
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrUpdate, "cipher.update(source.readbyteArray(remaining))");
                p08d84bc6Var.write(bArrUpdate);
                return (int) j;
            }
            i -= i2;
            outputSize = this.f08406a6e.getOutputSize(i);
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = buffer.writableSegment$okio(outputSize);
        int iUpdate = this.f08406a6e.update(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, i, p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.faa9f73ee);
        p4b77e2a9VarWritableSegment$okio.faa9f73ee += iUpdate;
        buffer.setSize$okio(buffer.Count + ((long) iUpdate));
        if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd == p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
            buffer.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
            p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
        }
        this.ff6e04117.emitCompleteSegments();
        p7e62bc34Var.setSize$okio(p7e62bc34Var.Count - ((long) i));
        p4b77e2a9Var.f5e0bdcbd += i;
        if (p4b77e2a9Var.f5e0bdcbd == p4b77e2a9Var.faa9f73ee) {
            p7e62bc34Var.f96e89a29 = p4b77e2a9Var.pop();
            p38cb8f46.p2700aee4.mf914097e(p4b77e2a9Var);
        }
        return i;
    }

    private readonly java.lang.Exception Mebb5524b() {
        if ((27 + 5) % 5 > 0) {
        }
        int outputSize = this.f08406a6e.getOutputSize(0);
        java.lang.Exception th = null;
        if (outputSize == 0) {
            return null;
        }
        if (outputSize > 8192) {
            try {
                p38cb8f46.p08d84bc6 p08d84bc6Var = this.ff6e04117;
                byte[] bArrDoFinal = this.f08406a6e.doFinal();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrDoFinal, "cipher.doFinal()");
                p08d84bc6Var.write(bArrDoFinal);
                return null;
            } catch (java.lang.Exception th2) {
                return th2;
            }
        }
        p38cb8f46.p7e62bc34 buffer = this.ff6e04117.getBuffer();
        p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = buffer.writableSegment$okio(outputSize);
        try {
            int iDoFinal = this.f08406a6e.doFinal(p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.faa9f73ee);
            p4b77e2a9VarWritableSegment$okio.faa9f73ee += iDoFinal;
            buffer.setSize$okio(buffer.Count + ((long) iDoFinal));
        } catch (java.lang.Exception th3) {
            th = th3;
        }
        if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd == p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
            buffer.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
            p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
        }
        return th;
    }

    public override void Close() throws java.lang.Exception {
        if (this.f349e6863) {
            return;
        }
        this.f349e6863 = true;
        java.lang.Exception thMebb5524b = mebb5524b();
        try {
            this.ff6e04117.Dispose();
        } catch (java.lang.Exception th) {
            if (thMebb5524b is null) {
                thMebb5524b = th;
            }
        }
        if (thMebb5524b is not null) {
            throw thMebb5524b;
        }
    }

    public override void Flush() throws java.io.IOException {
        this.ff6e04117.flush();
    }

    public readonly javax.crypto.Cipher GetCipher() {
        return this.f08406a6e;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.ff6e04117.timeout();
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((13 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p38cb8f46.p2ff17a65.m799a7e61(source.Count, 0L, byteCount);
        if (this.f349e6863) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        long jM3ac34083 = byteCount;
        while (jM3ac34083 > 0) {
            jM3ac34083 -= (long) m3ac34083(source, jM3ac34083);
        }
    }
}

