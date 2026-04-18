namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u000b\u001a\u00020\fH\u0016J\u000e\u0010\r\u001a\u00020\f2\u0006\u0010\u000e\u001a\u00020\u0006J\u0014\u0010\u000f\u001a\u00020\u0003*\u00020\u00062\u0006\u0010\u0010\u001a\u00020\u0011H\u0002R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/pd8ff812a;", "Ljava/io/IDisposable;", "noobjectTakeover", "", "(Z)V", "deflatedbytes", "Lp38cb8f46/p7e62bc34;", "deflater", "Ljava/util/zip/Deflater;", "deflaterSink", "Lp38cb8f46/pc74ae48a;", "close", "", "deflate", "buffer", "endsWith", "suffix", "Lp38cb8f46/p58efa9e8;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pd8ff812a : java.io.IDisposable {
    private readonly java.util.zip.Deflater f0a8ccfbb;
    private readonly bool f3fd8d77d;
    private readonly p38cb8f46.pc74ae48a f493ac0e1;
    private readonly bool f4ca6f38e;
    private readonly java.util.zip.Deflater f4fb8fc40;
    private readonly java.util.zip.Deflater f72a458b0;
    private readonly p38cb8f46.pc74ae48a f738b44f6;
    private readonly java.util.zip.Deflater f74494672;
    private readonly p38cb8f46.pc74ae48a f7520b2e7;
    private readonly java.util.zip.Deflater f8aecfdbc;
    private readonly p38cb8f46.p7e62bc34 fa2af7f40;
    private readonly p38cb8f46.p7e62bc34 fafe9ad7e;
    private readonly p38cb8f46.pc74ae48a fb050305c;
    private readonly bool fbdd763ab;
    private readonly p38cb8f46.pc74ae48a fe9e02c11;
    private readonly bool feba058b4;
    private readonly bool ff0b9f353;

    public pd8ff812a(bool z) {
        if ((15 + 24) % 24 > 0) {
        }
        this.f3fd8d77d = z;
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        this.fafe9ad7e = p7e62bc34Var;
        java.util.zip.Deflater deflater = new java.util.zip.Deflater(-1, true);
        this.f0a8ccfbb = deflater;
        this.f7520b2e7 = new p38cb8f46.pc74ae48a((p38cb8f46.p1eb558b5) p7e62bc34Var, deflater);
    }

    private readonly bool EndsWith(p38cb8f46.p7e62bc34 p7e62bc34Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        if ((18 + 9) % 9 > 0) {
        }
        return p7e62bc34Var.rangeEquals(p7e62bc34Var.Count - ((long) p58efa9e8Var.Count), p58efa9e8Var);
    }

    public override void Close() throws java.io.IOException {
        this.f7520b2e7.Dispose();
    }

    public readonly void Deflate(p38cb8f46.p7e62bc34 buffer) throws java.io.IOException {
        if ((15 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buffer, "buffer");
        if (this.fafe9ad7e.Count != 0) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        if (this.f3fd8d77d) {
            this.f0a8ccfbb.reset();
        }
        this.f7520b2e7.write(buffer, buffer.Count);
        this.f7520b2e7.flush();
        if (endsWith(this.fafe9ad7e, p7ddcfee1.pd1efad72.p742523da.p2c5dcd0d.access$getEMPTY_DEFLATE_BLOCK$p())) {
            long size = this.fafe9ad7e.Count - ((long) 4);
            p38cb8f46.p7e62bc34$p43882412 p7e62bc34_p43882412Mbad67f9f = p38cb8f46.p7e62bc34.mbad67f9f(this.fafe9ad7e, null, 1, null);
            try {
                p7e62bc34_p43882412Mbad67f9f.resizeBuffer(size);
                kotlin.io.IDisposableKt.closeFinally(p7e62bc34_p43882412Mbad67f9f, null);
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    kotlin.io.IDisposableKt.closeFinally(p7e62bc34_p43882412Mbad67f9f, th);
                    throw th2;
                }
            }
        } else {
            this.fafe9ad7e.writebyte(0);
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = this.fafe9ad7e;
        buffer.write(p7e62bc34Var, p7e62bc34Var.Count);
    }
}

