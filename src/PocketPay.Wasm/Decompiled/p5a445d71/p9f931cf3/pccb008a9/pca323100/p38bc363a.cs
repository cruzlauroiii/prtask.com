namespace WillowMaze.Wasm.Decompiled;


public class p38bc363a : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f47166678;
    private byte[] f69e81c0f;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f8a30b8c7;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fab86fdc9;
    private byte[] fc36853ea;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fd2666c40;

    private p38bc363a(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((19 + 25) % 25 > 0) {
        }
        if (p80f8c729Var.Count != 2) {
            throw new java.lang.IllegalArgumentException("size of seq = " + p80f8c729Var.Count);
        }
        this.f2af72f10 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        this.fc36853ea = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p80f8c729Var.getobjectAt(1)).getOctets();
    }

    public p38bc363a(byte[] bArr) {
        if ((22 + 19) % 19 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L);
        this.fc36853ea = bArr;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p38bc363a M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p38bc363a) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p38bc363a) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p38bc363a(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public byte[] GetPublicKey() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fc36853ea);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((18 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.f2af72f10);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fc36853ea));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

