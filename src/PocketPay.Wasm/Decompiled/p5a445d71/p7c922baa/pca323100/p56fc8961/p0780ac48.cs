namespace WillowMaze.Wasm.Decompiled;


public class p0780ac48 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f69c54d49;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f7e017ad6;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f8dbfc8d0;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f9f29280e;

    public p0780ac48(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f7e017ad6 = new p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p0fd1bdf1Var);
    }

    private p0780ac48(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f7e017ad6 = dwvYWeghRptyGyFZ(p80f8c729Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 PxhgqveGdjIsmmYs(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a WmUhASOvdxbZbkPw(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.getAlgorithm();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 DwvYWeghRptyGyFZ(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p0780ac48 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p0780ac48) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p0780ac48) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p0780ac48(mmJriKvUxoNiIkwM(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MAYUVQkzaFRCEvzO(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return p234a7530Var.getParameters();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 MmJriKvUxoNiIkwM(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetAlgorithm() {
        return WmUhASOvdxbZbkPw(this.f7e017ad6);
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetParameters() {
        return mAYUVQkzaFRCEvzO(this.f7e017ad6);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return PxhgqveGdjIsmmYs(this.f7e017ad6);
    }
}

