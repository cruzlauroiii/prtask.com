namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0011\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\u0018\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u001aH\u0016J\b\u0010\u001e\u001a\u00020\u0018H\u0002J\b\u0010\u001f\u001a\u00020 H\u0016R\u001a\u0010\u0005\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u001a\u0010\u000b\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\f\u0010\b\"\u0004\b\r\u0010\nR\u001a\u0010\u000e\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\b\"\u0004\b\u0010\u0010\nR\u001a\u0010\u0011\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0012\u0010\b\"\u0004\b\u0013\u0010\nR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0014\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0015\u0010\b\"\u0004\b\u0016\u0010\n¨\u0006!"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e$ped8626c7;", "Lp38cb8f46/pf31bbdd1;", "source", "Lp38cb8f46/pcc81e3f6;", "(Lp38cb8f46/pcc81e3f6;)V", "flags", "", "getFlags", "()I", "setFlags", "(I)V", "left", "getLeft", "setLeft", "length", "getLength", "setLength", "padding", "getPadding", "setPadding", "streamId", "getStreamId", "setStreamId", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "readContinuationHeader", "timeout", "Lp38cb8f46/pc85a251c;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p1b0ecc4e$ped8626c7 : p38cb8f46.pf31bbdd1 {
    private int f0261c4a3;
    private int f0355aecc;
    private int f0b1f7074;
    private int f2cb8abd2;
    private int f2f0bd86c;
    private int f2fa47f7c;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly p38cb8f46.pcc81e3f6 f382445d7;
    private int f3d2afde8;
    private int f435de071;
    private int f44590c3b;
    private int f4e5868d6;
    private int f80463261;
    private int f811882fe;
    private int f95025aae;
    private int fb70cdb87;
    private int fb85a778f;
    private readonly p38cb8f46.pcc81e3f6 fb8a6eddf;
    private readonly p38cb8f46.pcc81e3f6 fc6b0e8c1;
    private int fc75cb34f;

    public p1b0ecc4e$ped8626c7(p38cb8f46.pcc81e3f6 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        this.f36cd38f4 = source;
    }

    private readonly void ReadContinuationHeader() throws java.io.IOException {
        if ((2 + 21) % 21 > 0) {
        }
        int i = this.f44590c3b;
        int medium = p7ddcfee1.pd1efad72.p23e8a4b4.readMedium(this.f36cd38f4);
        this.f811882fe = medium;
        this.f2fa47f7c = medium;
        int iAnd = p7ddcfee1.pd1efad72.p23e8a4b4.and(this.f36cd38f4.readbyte(), 255);
        this.f4e5868d6 = p7ddcfee1.pd1efad72.p23e8a4b4.and(this.f36cd38f4.readbyte(), 255);
        if (p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f910eef8c.getConsoleger().isConsolegable(java.util.logging.Level.FINE)) {
            p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.f910eef8c.getConsoleger().fine(p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f76425f17.frameConsole(true, this.f44590c3b, this.f2fa47f7c, iAnd, this.f4e5868d6));
        }
        int i2 = this.f36cd38f4.readInt() & int.MAX_VALUE;
        this.f44590c3b = i2;
        if (iAnd != 9) {
            throw new java.io.IOException(iAnd + " != TYPE_CONTINUATION");
        }
        if (i2 != i) {
            throw new java.io.IOException("TYPE_CONTINUATION streamId changed");
        }
    }

    public override void Close() throws java.io.IOException {
    }

    public readonly int GetFlags() {
        return this.f4e5868d6;
    }

    public readonly int GetLeft() {
        return this.f811882fe;
    }

    public readonly int GetLength() {
        return this.f2fa47f7c;
    }

    public readonly int GetPadding() {
        return this.fb70cdb87;
    }

    public readonly int GetStreamId() {
        return this.f44590c3b;
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((12 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        while (true) {
            int i = this.f811882fe;
            if (i != 0) {
                long j = this.f36cd38f4.read(sink, java.lang.Math.min(byteCount, i));
                if (j == -1) {
                    return -1L;
                }
                this.f811882fe -= (int) j;
                return j;
            }
            this.f36cd38f4.skip(this.fb70cdb87);
            this.fb70cdb87 = 0;
            if ((this.f4e5868d6 & 4) != 0) {
                return -1L;
            }
            readContinuationHeader();
        }
    }

    public readonly void SetFlags(int i) {
        this.f4e5868d6 = i;
    }

    public readonly void SetLeft(int i) {
        this.f811882fe = i;
    }

    public readonly void SetLength(int i) {
        this.f2fa47f7c = i;
    }

    public readonly void SetPadding(int i) {
        this.fb70cdb87 = i;
    }

    public readonly void SetStreamId(int i) {
        this.f44590c3b = i;
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f36cd38f4.timeout();
    }
}

