namespace WillowMaze.Wasm.Decompiled;


public class pb431ce38 : p5a445d71.p7c922baa.pca323100.p94dfe8e0 {
    private p5a445d71.p7c922baa.pca323100.p8557f615 f4c7d65f4;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f9115b725;
    private p5a445d71.p7c922baa.pca323100.p8557f615 fa22f93f2;
    private p5a445d71.p7c922baa.pca323100.p8557f615 fa5460944;

    pb431ce38(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IqBEFwnlkOgxxMYi(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 LQSpurWLqUAzyzXT(p5a445d71.p7c922baa.pca323100.pb431ce38 pb431ce38Var) {
        return pb431ce38Var.getLoadedobject();
    }

    public static java.lang.string SYmQYAwwKCRDXgpz(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.pd6ccb7fc SfihqeNpkSOMWTAe(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(sfihqeNpkSOMWTAe(this.f5431b8d4));
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return IqBEFwnlkOgxxMYi(this.f5431b8d4);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        try {
            return LQSpurWLqUAzyzXT(this);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(SYmQYAwwKCRDXgpz(e));
        }
    }
}

