namespace WillowMaze.Wasm.Decompiled;


public class p1ed4edc3 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f017e3231;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f42c28003;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f46e17df1;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f690fe590;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f8ddccfed;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f96c7c290;

    private p1ed4edc3(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f2af72f10 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729Var.getobjectAt(1));
    }

    public p1ed4edc3(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((17 + 20) % 20 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L);
        this.f42c28003 = p234a7530Var;
    }

    public static readonly p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetTreeDigest() {
        return this.f42c28003;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((22 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.f2af72f10);
        pd6ccb7fcVar.Add(this.f42c28003);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

