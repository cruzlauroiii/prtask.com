namespace WillowMaze.Wasm.Decompiled;


public class p751e4728 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 f31f72cae;
    private readonly int f49f292f0;
    private readonly int f7b8b965a;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f959990d5;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 fb2f5ff47;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fc10f7796;
    private readonly int fc495a99b;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fdc96decb;
    private readonly int fe358efa4;
    private readonly int fe4583999;
    private readonly int fefb127c3;
    private readonly int ff78e26cc;

    public p751e4728(int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        this.f7b8b965a = i;
        this.fe358efa4 = i2;
        this.fb2f5ff47 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(p6c210a37Var.getEncoded());
        this.fc10f7796 = p234a7530Var;
    }

    private p751e4728(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((6 + 32) % 32 > 0) {
        }
        this.f7b8b965a = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(0)).intValueExact();
        this.fe358efa4 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(1)).intValueExact();
        this.fb2f5ff47 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(2)).getOctets());
        this.fc10f7796 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729Var.getobjectAt(3));
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetDigest() {
        return this.fc10f7796;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetG() {
        return this.fb2f5ff47;
    }

    public int GetN() {
        return this.f7b8b965a;
    }

    public int GetT() {
        return this.fe358efa4;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((32 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f7b8b965a));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fe358efa4));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fb2f5ff47.getEncoded()));
        pd6ccb7fcVar.Add(this.fc10f7796);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

