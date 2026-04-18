namespace WillowMaze.Wasm.Decompiled;


public class pacfb2551 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly int f151d3418;
    private readonly int f22867715;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f42c28003;
    private readonly int f62d6bf11;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d f8694813f;
    private readonly int f8fcec608;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f90c65ab0;
    private readonly int faa292f2a;
    private readonly int fadbca10a;
    private readonly int fb435e227;
    private readonly p5a445d71.p9f931cf3.pca323100.pf391b73d fbd556e35;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fc2d52810;

    public pacfb2551(int i, int i2, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((21 + 22) % 22 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L);
        this.fb435e227 = i;
        this.faa292f2a = i2;
        this.f42c28003 = p234a7530Var;
    }

    private pacfb2551(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f2af72f10 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        this.fb435e227 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(1)).intValueExact();
        this.faa292f2a = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(2)).intValueExact();
        this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729Var.getobjectAt(3));
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public int GetHeight() {
        return this.fb435e227;
    }

    public int GetLayers() {
        return this.faa292f2a;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetTreeDigest() {
        return this.f42c28003;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((26 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.f2af72f10);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fb435e227));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.faa292f2a));
        pd6ccb7fcVar.Add(this.f42c28003);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

