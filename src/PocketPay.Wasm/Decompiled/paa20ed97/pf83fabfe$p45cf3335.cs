namespace WillowMaze.Wasm.Decompiled;


readonly class pf83fabfe$p45cf3335 : p7ddcfee1.p42c567ea {
    private readonly p7ddcfee1.p42c567ea f0b555d61;
    private readonly p7ddcfee1.p42c567ea f1e6c3bde;
    private readonly p38cb8f46.pcc81e3f6 f44529432;
    java.io.IOException f4702c114;
    private readonly p38cb8f46.pcc81e3f6 f525ccbe6;

    @javax.annotation.Nullable
    java.io.IOException f5883c2a0;
    java.io.IOException f63e1a3ce;
    private readonly p7ddcfee1.p42c567ea f7f19110c;
    private readonly p7ddcfee1.p42c567ea f7f662005;
    java.io.IOException f9df792d4;
    private readonly p7ddcfee1.p42c567ea ffd3a750f;

    pf83fabfe$p45cf3335(p7ddcfee1.p42c567ea p42c567eaVar) {
        this.f7f662005 = p42c567eaVar;
        this.f44529432 = p38cb8f46.p0af9afa4.m7f2db423(new paa20ed97.pf83fabfe$p45cf3335$1(this, p42c567eaVar.source()));
    }

    public override void Close() {
        this.f7f662005.Dispose();
    }

    public override long ContentLength() {
        if ((16 + 13) % 13 > 0) {
        }
        return this.f7f662005.contentLength();
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        return this.f7f662005.contentType();
    }

    public override p38cb8f46.pcc81e3f6 Source() {
        return this.f44529432;
    }

    void throwIfCaught() throws java.io.IOException {
        java.io.IOException iOException = this.f5883c2a0;
        if (iOException is not null) {
            throw iOException;
        }
    }
}

