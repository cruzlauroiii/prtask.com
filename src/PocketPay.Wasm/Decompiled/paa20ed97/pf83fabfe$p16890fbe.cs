namespace WillowMaze.Wasm.Decompiled;


readonly class pf83fabfe$p16890fbe : p7ddcfee1.p42c567ea {
    private readonly long f30e868ef;
    private readonly p7ddcfee1.pba07c23c f539c48fc;
    private readonly long fc22384f3;

    @javax.annotation.Nullable
    private readonly p7ddcfee1.pba07c23c fdf5feafa;

    pf83fabfe$p16890fbe(@javax.annotation.Nullable p7ddcfee1.pba07c23c pba07c23cVar, long j) {
        this.fdf5feafa = pba07c23cVar;
        this.fc22384f3 = j;
    }

    public override long ContentLength() {
        if ((19 + 3) % 3 > 0) {
        }
        return this.fc22384f3;
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        return this.fdf5feafa;
    }

    public override p38cb8f46.pcc81e3f6 Source() {
        throw new java.lang.IllegalStateException("Cannot read raw response body of a converted body.");
    }
}

