namespace WillowMaze.Wasm.Decompiled;


public class pec16886f : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly int f09f6f0a2;
    private readonly int f24c0d9c8;
    private readonly int f5666d8f5;
    private readonly int f5b9d4ac2;
    private readonly int f7b8b965a;
    private readonly int f7c7ba9fe;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 f97c24160;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 fb2f5ff47;
    private readonly int fbd171946;
    private readonly int fe358efa4;
    private readonly int ff74aab48;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 ff9d57383;
    private readonly int ffcd7ec68;

    public pec16886f(int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var) {
        this.f7b8b965a = i;
        this.fe358efa4 = i2;
        this.fb2f5ff47 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(p6c210a37Var);
    }

    private pec16886f(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((21 + 32) % 32 > 0) {
        }
        this.f7b8b965a = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(0)).intValueExact();
        this.fe358efa4 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(1)).intValueExact();
        this.fb2f5ff47 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(2)).getOctets());
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetG() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.fb2f5ff47);
    }

    public int GetN() {
        return this.f7b8b965a;
    }

    public int GetT() {
        return this.fe358efa4;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f7b8b965a));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fe358efa4));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fb2f5ff47.getEncoded()));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

