namespace WillowMaze.Wasm.Decompiled;


public class pb50cca0f : p5a445d71.p7c922baa.pca323100.p94dfe8e0 {
    private p5a445d71.p7c922baa.pca323100.p8557f615 f4fc28ee7;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f966abb0a;
    private p5a445d71.p7c922baa.pca323100.p8557f615 fa2254064;
    private p5a445d71.p7c922baa.pca323100.p8557f615 ff5f22c06;

    pb50cca0f(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KrUWYxejRMBohmOc(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pd6ccb7fc WHhAYiEUAUiUYDUT(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static java.lang.string NrTFKoCAueVbTrOJ(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VBIHEPWiyvhtYcmB(p5a445d71.p7c922baa.pca323100.pb50cca0f pb50cca0fVar) {
        return pb50cca0fVar.getLoadedobject();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return new p5a445d71.p7c922baa.pca323100.p6a819fa7(WHhAYiEUAUiUYDUT(this.f5431b8d4));
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return KrUWYxejRMBohmOc(this.f5431b8d4);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        try {
            return vBIHEPWiyvhtYcmB(this);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(nrTFKoCAueVbTrOJ(e));
        }
    }
}

