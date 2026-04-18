namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0011H\u0002J\u0018\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\n2\u0006\u0010\u0016\u001a\u00020\u0014H\u0016J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0019H\u0016J\b\u0010\u001a\u001a\u00020\u0011H\u0002R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u000e\u0010\r\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp38cb8f46/pdf1013f4;", "Lp38cb8f46/pf31bbdd1;", "source", "Lp38cb8f46/pcc81e3f6;", "cipher", "Ljavax/crypto/Cipher;", "(Lp38cb8f46/pcc81e3f6;Ljavax/crypto/Cipher;)V", "blockSize", "", "buffer", "Lp38cb8f46/p7e62bc34;", "getCipher", "()Ljavax/crypto/Cipher;", "closed", "", "final", "close", "", "doFinal", "read", "", "sink", "byteCount", "refill", "timeout", "Lp38cb8f46/pc85a251c;", "update", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pdf1013f4 : p38cb8f46.pf31bbdd1 {
    private readonly javax.crypto.Cipher f08406a6e;
    private readonly javax.crypto.Cipher f109bac46;
    private readonly p38cb8f46.pcc81e3f6 f1fb7f99f;
    private readonly p38cb8f46.p7e62bc34 f21a1d54a;
    private readonly p38cb8f46.pcc81e3f6 f27431e05;
    private bool f2a1585a8;
    private bool f349e6863;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly p38cb8f46.p7e62bc34 f3c5999ef;
    private readonly int f480d1b61;
    private bool f5617acab;
    private bool f7bbcf342;
    private readonly p38cb8f46.p7e62bc34 f7f2db423;
    private readonly p38cb8f46.pcc81e3f6 f8190882a;
    private bool f81dfdfcd;
    private readonly javax.crypto.Cipher f98b0e1d5;
    private readonly p38cb8f46.p7e62bc34 fa9be2e35;
    private bool fb71cd918;
    private readonly javax.crypto.Cipher fb7f3a0ee;
    private readonly javax.crypto.Cipher fd63a33bd;
    private readonly p38cb8f46.p7e62bc34 fe6280560;
    private readonly int ff92a283f;

    public pdf1013f4(p38cb8f46.pcc81e3f6 source, javax.crypto.Cipher cipher) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cipher, "cipher");
        this.f36cd38f4 = source;
        this.f08406a6e = cipher;
        int blockSize = cipher.getBlockSize();
        this.f480d1b61 = blockSize;
        this.f7f2db423 = new p38cb8f46.p7e62bc34();
        if (blockSize <= 0) {
            throw new java.lang.IllegalArgumentException(("Block cipher required " + cipher).tostring());
        }
    }

    private readonly void M3ac34083() throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, java.io.IOException, javax.crypto.shortBufferException {
        if ((3 + 2) % 2 > 0) {
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = this.f36cd38f4.getBuffer().f96e89a29;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        int i = p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd;
        int outputSize = this.f08406a6e.getOutputSize(i);
        int i2 = i;
        while (outputSize > 8192) {
            int i3 = this.f480d1b61;
            if (i2 <= i3) {
                this.f2a1585a8 = true;
                p38cb8f46.p7e62bc34 p7e62bc34Var = this.f7f2db423;
                byte[] bArrDoFinal = this.f08406a6e.doFinal(this.f36cd38f4.readbyteArray());
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bArrDoFinal, "cipher.doFinal(source.readbyteArray())");
                p7e62bc34Var.write(bArrDoFinal);
                return;
            }
            i2 -= i3;
            outputSize = this.f08406a6e.getOutputSize(i2);
        }
        p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = this.f7f2db423.writableSegment$okio(outputSize);
        int iUpdate = this.f08406a6e.update(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, i2, p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.f5e0bdcbd);
        this.f36cd38f4.skip(i2);
        p4b77e2a9VarWritableSegment$okio.faa9f73ee += iUpdate;
        p38cb8f46.p7e62bc34 p7e62bc34Var2 = this.f7f2db423;
        p7e62bc34Var2.setSize$okio(p7e62bc34Var2.Count + ((long) iUpdate));
        if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd != p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
            return;
        }
        this.f7f2db423.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
        p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
    }

    private readonly void Mb4479040() throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, java.io.IOException, javax.crypto.shortBufferException {
        if ((25 + 15) % 15 > 0) {
        }
        while (this.f7f2db423.Count == 0 && !this.f2a1585a8) {
            if (this.f36cd38f4.exhausted()) {
                this.f2a1585a8 = true;
                mebb5524b();
                return;
            }
            m3ac34083();
        }
    }

    private readonly void Mebb5524b() throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        if ((18 + 25) % 25 > 0) {
        }
        int outputSize = this.f08406a6e.getOutputSize(0);
        if (outputSize != 0) {
            p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = this.f7f2db423.writableSegment$okio(outputSize);
            int iDoFinal = this.f08406a6e.doFinal(p4b77e2a9VarWritableSegment$okio.f8d777f38, p4b77e2a9VarWritableSegment$okio.f5e0bdcbd);
            p4b77e2a9VarWritableSegment$okio.faa9f73ee += iDoFinal;
            p38cb8f46.p7e62bc34 p7e62bc34Var = this.f7f2db423;
            p7e62bc34Var.setSize$okio(p7e62bc34Var.Count + ((long) iDoFinal));
            if (p4b77e2a9VarWritableSegment$okio.f5e0bdcbd != p4b77e2a9VarWritableSegment$okio.faa9f73ee) {
                return;
            }
            this.f7f2db423.f96e89a29 = p4b77e2a9VarWritableSegment$okio.pop();
            p38cb8f46.p2700aee4.mf914097e(p4b77e2a9VarWritableSegment$okio);
        }
    }

    public override void Close() throws java.io.IOException {
        this.f349e6863 = true;
        this.f36cd38f4.Dispose();
    }

    public readonly javax.crypto.Cipher GetCipher() {
        return this.f08406a6e;
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, java.io.IOException, javax.crypto.shortBufferException {
        if ((30 + 11) % 11 > 0) {
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
        mb4479040();
        return this.f7f2db423.read(sink, byteCount);
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f36cd38f4.timeout();
    }
}

