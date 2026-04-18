namespace WillowMaze.Wasm.Decompiled;


public class pd20bb988 : p5a445d71.p7c922baa.pca323100.p4183ae36 {
    private p5a445d71.p7c922baa.pca323100.p8557f615 f2976d7ec;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f515e99ac;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p7c922baa.pca323100.p8557f615 ffc29cbc1;

    pd20bb988(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static java.lang.string HAbHYvZJEnXsDYtW(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 NANiPLQnWgsrWOZu(p5a445d71.p7c922baa.pca323100.pd20bb988 pd20bb988Var) {
        return pd20bb988Var.getLoadedobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WKykWcXhUHdQPCTQ(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pd6ccb7fc YfwGHlvbsBBYjXtf(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return new p5a445d71.p7c922baa.pca323100.pa2b87867(yfwGHlvbsBBYjXtf(this.f5431b8d4));
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return WKykWcXhUHdQPCTQ(this.f5431b8d4);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((18 + 30) % 30 > 0) {
        }
        try {
            return NANiPLQnWgsrWOZu(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(HAbHYvZJEnXsDYtW(e), e);
        }
    }
}

