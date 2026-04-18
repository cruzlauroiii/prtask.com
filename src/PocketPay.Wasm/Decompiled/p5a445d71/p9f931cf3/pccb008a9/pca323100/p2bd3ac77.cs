namespace WillowMaze.Wasm.Decompiled;


public class p2bd3ac77 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f0625f6a0;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private readonly int f402abc46;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f42c28003;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f5ca6a03b;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f7ca2aa27;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f87ef809f;
    private readonly int fb435e227;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fdee0f4d9;

    public p2bd3ac77(int i, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((2 + 1) % 1 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L);
        this.fb435e227 = i;
        this.f42c28003 = p234a7530Var;
    }

    private p2bd3ac77(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f2af72f10 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        this.fb435e227 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(1)).intValueExact();
        this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729Var.getobjectAt(2));
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public int GetHeight() {
        return this.fb435e227;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetTreeDigest() {
        return this.f42c28003;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((9 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.f2af72f10);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fb435e227));
        pd6ccb7fcVar.Add(this.f42c28003);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

