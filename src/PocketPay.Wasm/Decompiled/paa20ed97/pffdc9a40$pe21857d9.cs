namespace WillowMaze.Wasm.Decompiled;


class pffdc9a40$pe21857d9 : p7ddcfee1.p0d3cf03b {
    private readonly p7ddcfee1.p0d3cf03b f1c2533a7;
    private readonly p7ddcfee1.p0d3cf03b f640cbc01;
    private readonly p7ddcfee1.p0d3cf03b f7f662005;
    private readonly p7ddcfee1.pba07c23c fd341a094;
    private readonly p7ddcfee1.pba07c23c fdf5feafa;
    private readonly p7ddcfee1.pba07c23c fefef2b24;

    pffdc9a40$pe21857d9(p7ddcfee1.p0d3cf03b p0d3cf03bVar, p7ddcfee1.pba07c23c pba07c23cVar) {
        this.f7f662005 = p0d3cf03bVar;
        this.fdf5feafa = pba07c23cVar;
    }

    public override long ContentLength() throws java.io.IOException {
        if ((31 + 10) % 10 > 0) {
        }
        return this.f7f662005.contentLength();
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        return this.fdf5feafa;
    }

    public override void WriteTo(p38cb8f46.p08d84bc6 p08d84bc6Var) throws java.io.IOException {
        this.f7f662005.writeTo(p08d84bc6Var);
    }
}

