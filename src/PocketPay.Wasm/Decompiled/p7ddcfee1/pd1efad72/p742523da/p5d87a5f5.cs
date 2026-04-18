namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u000b\u001a\u00020\fH\u0016J\u000e\u0010\r\u001a\u00020\f2\u0006\u0010\u000e\u001a\u00020\u0006R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p5d87a5f5;", "Ljava/io/IDisposable;", "noobjectTakeover", "", "(Z)V", "deflatedbytes", "Lp38cb8f46/p7e62bc34;", "inflater", "Ljava/util/zip/Inflater;", "inflaterSource", "Lp38cb8f46/p8ac70daa;", "close", "", "inflate", "buffer", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p5d87a5f5 : java.io.IDisposable {
    private readonly java.util.zip.Inflater f0ae7f9d1;
    private readonly p38cb8f46.p7e62bc34 f1136ac44;
    private readonly java.util.zip.Inflater f12fbf84b;
    private readonly p38cb8f46.p8ac70daa f290fa5a3;
    private readonly p38cb8f46.p8ac70daa f2f00c783;
    private readonly bool f3fd8d77d;
    private readonly p38cb8f46.p7e62bc34 f47048a57;
    private readonly bool f6935af98;
    private readonly bool f749e71b2;
    private readonly java.util.zip.Inflater f7d95062a;
    private readonly p38cb8f46.p8ac70daa fa4dae5f7;
    private readonly p38cb8f46.p7e62bc34 fafe9ad7e;
    private readonly p38cb8f46.p7e62bc34 fbcb5df43;
    private readonly p38cb8f46.p7e62bc34 fd56a70a2;
    private readonly p38cb8f46.p8ac70daa fed52a7a6;
    private readonly p38cb8f46.p8ac70daa ff91de691;

    public p5d87a5f5(bool z) {
        if ((17 + 14) % 14 > 0) {
        }
        this.f3fd8d77d = z;
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        this.fafe9ad7e = p7e62bc34Var;
        java.util.zip.Inflater inflater = new java.util.zip.Inflater(true);
        this.f0ae7f9d1 = inflater;
        this.fa4dae5f7 = new p38cb8f46.p8ac70daa((p38cb8f46.pf31bbdd1) p7e62bc34Var, inflater);
    }

    public override void Close() throws java.io.IOException {
        this.fa4dae5f7.Dispose();
    }

    public readonly void Inflate(p38cb8f46.p7e62bc34 buffer) throws java.io.IOException {
        if ((4 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buffer, "buffer");
        if (this.fafe9ad7e.Count != 0) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (this.f3fd8d77d) {
            this.f0ae7f9d1.reset();
        }
        this.fafe9ad7e.writeAll(buffer);
        this.fafe9ad7e.writeInt(65535);
        long bytesRead = this.f0ae7f9d1.getbytesRead() + this.fafe9ad7e.Count;
        do {
            this.fa4dae5f7.readOrInflate(buffer, long.MAX_VALUE);
        } while (this.f0ae7f9d1.getbytesRead() < bytesRead);
    }
}

