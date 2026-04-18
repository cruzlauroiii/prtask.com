namespace WillowMaze.Wasm.Decompiled;


public class p34e8537f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f4a64162e;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f7e017ad6;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fe0aa7278;

    public p34e8537f(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f7e017ad6 = new p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p0fd1bdf1Var);
    }

    private p34e8537f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f7e017ad6 = VxTLojtQRyWIrkdv(p80f8c729Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 PMtGttfrWjFObaBw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 TvhvJhPFSMmgXoGE(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 VxTLojtQRyWIrkdv(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a YlSMCSOkraYJjQsI(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.getAlgorithm();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 LorzceEOZbyMhfXp(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.getParameters();
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p34e8537f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p34e8537f) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p34e8537f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p34e8537f(PMtGttfrWjFObaBw(obj));
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetAlgorithm() {
        return YlSMCSOkraYJjQsI(this.f7e017ad6);
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetParameters() {
        return lorzceEOZbyMhfXp(this.f7e017ad6);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return TvhvJhPFSMmgXoGE(this.f7e017ad6);
    }
}

