namespace WillowMaze.Wasm.Decompiled;


public class p1ed4edc3 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f0330539b;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f1f368c02;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d f2af72f10;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f42c28003;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fb2f89bd8;
    private readonly p5a445d71.p7c922baa.pca323100.pf391b73d fbc5ef49e;

    private p1ed4edc3(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f2af72f10 = gaYbiNjyBMXitmQX(kAhXpLSMyUhQYLdK(p80f8c729Var, 0));
        this.f42c28003 = YOjivjWiLysWsuzl(FtZqSvgtvOIKFkkH(p80f8c729Var, 1));
    }

    public p1ed4edc3(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((15 + 8) % 8 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p7c922baa.pca323100.pf391b73d(0L);
        this.f42c28003 = p234a7530Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 FtZqSvgtvOIKFkkH(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 YOjivjWiLysWsuzl(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static void BlgxpCNgdmMwtcGf(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void FDahCVhcjobMCTJK(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d GaYbiNjyBMXitmQX(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GeWAEKfRgZwvEAEi(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KAhXpLSMyUhQYLdK(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static readonly p5a445d71.p7c922baa.pccb008a9.pca323100.p1ed4edc3 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pccb008a9.pca323100.p1ed4edc3) {
            return (p5a445d71.p7c922baa.pccb008a9.pca323100.p1ed4edc3) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pccb008a9.pca323100.p1ed4edc3(geWAEKfRgZwvEAEi(obj));
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetTreeDigest() {
        return this.f42c28003;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((7 + 4) % 4 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        blgxpCNgdmMwtcGf(pd6ccb7fcVar, this.f2af72f10);
        fDahCVhcjobMCTJK(pd6ccb7fcVar, this.f42c28003);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

