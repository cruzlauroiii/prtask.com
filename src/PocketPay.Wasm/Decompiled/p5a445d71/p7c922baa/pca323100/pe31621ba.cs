namespace WillowMaze.Wasm.Decompiled;


public class pe31621ba : p5a445d71.p7c922baa.pca323100.p0fd1bdf1, p5a445d71.p7c922baa.pca323100.p1e3b7dbf {
    private p5a445d71.p7c922baa.pca323100.p8557f615 f289a4fb1;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f3fe6c6fc;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f45102df3;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;

    public pe31621ba(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NLtAMVdKHkuQGkXP(p5a445d71.p7c922baa.pca323100.pe31621ba pe31621baVar) {
        return pe31621baVar.getLoadedobject();
    }

    public static java.lang.string BPOdendYqVowdkdV(java.lang.IllegalArgumentException illegalArgumentException) {
        return illegalArgumentException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 KJdFonHahkGymDLQ(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pd6ccb7fc XwcMeKCgfvOGSjrS(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        if ((27 + 23) % 23 > 0) {
        }
        try {
            return new p5a445d71.p7c922baa.pca323100.p763a7db9(xwcMeKCgfvOGSjrS(this.f5431b8d4));
        } catch (java.lang.IllegalArgumentException e) {
            throw new p5a445d71.p7c922baa.pca323100.pa2b39ca1(bPOdendYqVowdkdV(e), e);
        }
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return kJdFonHahkGymDLQ(this.f5431b8d4);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((30 + 28) % 28 > 0) {
        }
        try {
            return NLtAMVdKHkuQGkXP(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024("unable to get DER object", e);
        } catch (java.lang.IllegalArgumentException e2) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024("unable to get DER object", e2);
        }
    }
}

