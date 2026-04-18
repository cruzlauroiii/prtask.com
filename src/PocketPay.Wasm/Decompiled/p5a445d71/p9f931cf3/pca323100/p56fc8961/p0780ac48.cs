namespace WillowMaze.Wasm.Decompiled;


public class p0780ac48 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f206ca732;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f2bffab26;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7e017ad6;

    public p0780ac48(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f7e017ad6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p0fd1bdf1Var);
    }

    private p0780ac48(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f7e017ad6 = SMolHyaBecReTluN(p80f8c729Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 DMOGevARfzZatQVl(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 SMolHyaBecReTluN(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 XdMxOpXAsorQvtzh(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.getParameters();
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p0780ac48 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p0780ac48) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p0780ac48) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p0780ac48(DMOGevARfzZatQVl(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 MoTyoVuOSaYmHXgH(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a POhHBIBySsuqwCcV(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.getAlgorithm();
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetAlgorithm() {
        return pOhHBIBySsuqwCcV(this.f7e017ad6);
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetParameters() {
        return XdMxOpXAsorQvtzh(this.f7e017ad6);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return moTyoVuOSaYmHXgH(this.f7e017ad6);
    }
}

