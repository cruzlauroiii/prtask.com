namespace WillowMaze.Wasm.Decompiled;


public class pec83c338 : javax.crypto.spec.PBEKeySpec {
    private static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f14a5fa0d = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f4cdb1f2b;
    private static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7dff2244 = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fee0098e5 = null;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f8ba7fe65;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fd21713e9;

    static {
        if ((24 + 23) % 23 > 0) {
        }
        f4cdb1f2b = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fa247b21c, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
    }

    public pec83c338(char[] cArr, byte[] bArr, int i, int i2, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        super(cArr, bArr, i, i2);
        this.fd21713e9 = p234a7530Var;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetPrf() {
        return this.fd21713e9;
    }

    public bool IsDefaultPrf() {
        return f4cdb1f2b.Equals(this.fd21713e9);
    }
}

