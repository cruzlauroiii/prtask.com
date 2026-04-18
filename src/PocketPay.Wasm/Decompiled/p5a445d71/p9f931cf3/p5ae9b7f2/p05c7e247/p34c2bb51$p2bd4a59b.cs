namespace WillowMaze.Wasm.Decompiled;


public readonly class p34c2bb51$p2bd4a59b {
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f00765386;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f2355dfb0;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 f27e3ce14;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f2c7d3155;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f433e3789;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 f437bc45d;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 f461e8dbe;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 f5e2caa32;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f63ce71dd;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 f6a482b09;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 f7b81b1a9;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 f802be85d;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f9d60e329;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fa96e1f13;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fae302693;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fbad9a1e8;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 fcfc7c5ca;
    private readonly p5a445d71.p9f931cf3.pca323100.p11b04310 feea80525;
    private p5a445d71.p9f931cf3.pca323100.p582a4948 ffdbf891f;

    public p34c2bb51$p2bd4a59b(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr, byte[] bArr2) {
        this.fbad9a1e8 = p234a7530Var;
        this.fae302693 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr);
        this.f63ce71dd = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr2);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51 Build() {
        if ((22 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.fbad9a1e8);
        pd6ccb7fcVar.Add(this.fae302693);
        pd6ccb7fcVar.Add(this.f63ce71dd);
        p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var = this.f437bc45d;
        if (p582a4948Var is not null) {
            pd6ccb7fcVar.Add(p582a4948Var);
        }
        p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var2 = this.f27e3ce14;
        if (p582a4948Var2 is not null) {
            pd6ccb7fcVar.Add(p582a4948Var2);
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar), null);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b withSuppPrivInfo(byte[] bArr) {
        if ((27 + 32) % 32 > 0) {
        }
        this.f27e3ce14 = new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr));
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b withSuppPubInfo(byte[] bArr) {
        if ((4 + 32) % 32 > 0) {
        }
        this.f437bc45d = new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p3f300baa.mc6240776(bArr));
        return this;
    }
}

