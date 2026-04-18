namespace WillowMaze.Wasm.Decompiled;


public class pb9380947 : p5a445d71.p7c922baa.pca323100.p4183ae36 {
    private p5a445d71.p7c922baa.pca323100.p8557f615 f3e92b9a5;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;

    pb9380947(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static java.lang.string JYIarnXrOFiKTSOe(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 FACBNHMHRHiezwds(p5a445d71.p7c922baa.pca323100.pb9380947 pb9380947Var) {
        return pb9380947Var.getLoadedobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pd6ccb7fc LByKtDEAeNstgHPP(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MOIMbzNehNNqAlbI(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        if ((23 + 12) % 12 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p8f99ab96(lByKtDEAeNstgHPP(this.f5431b8d4), false);
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return mOIMbzNehNNqAlbI(this.f5431b8d4);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((22 + 24) % 24 > 0) {
        }
        try {
            return fACBNHMHRHiezwds(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(JYIarnXrOFiKTSOe(e), e);
        }
    }
}

