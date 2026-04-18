namespace WillowMaze.Wasm.Decompiled;


public class pb8101683 : p5a445d71.p7c922baa.pca323100.pa5dc5f26 {
    private bool f17433c63;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f3ba42688;
    private bool f3f3abce6;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5431b8d4;
    private int f56e03b52;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f5725563c;
    private p5a445d71.p7c922baa.pca323100.p8557f615 f60781047;
    private int faababab9;
    private bool fb52d9e9d;
    private p5a445d71.p7c922baa.pca323100.p8557f615 fc9f49b52;
    private int feae2e4d0;

    pb8101683(bool z, int i, p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.fb52d9e9d = z;
        this.feae2e4d0 = i;
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 AwFouZNARKCPnzLX(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var, bool z, int i) {
        return p8557f615Var.readTaggedobject(z, i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 CxtPbnGMSigcgoHA(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var, bool z, int i) {
        return p8557f615Var.readImplicit(z, i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NZGFYXSDTizfmSDa(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 JjdAzmUUzGBxMYZR(p5a445d71.p7c922baa.pca323100.pb8101683 pb8101683Var) {
        return pb8101683Var.getLoadedobject();
    }

    public static java.lang.string SMwHuoiNRITGKogT(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        if ((27 + 16) % 16 > 0) {
        }
        return AwFouZNARKCPnzLX(this.f5431b8d4, this.fb52d9e9d, this.feae2e4d0);
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetobjectParser(int i, bool z) throws java.io.IOException {
        if (!z) {
            return CxtPbnGMSigcgoHA(this.f5431b8d4, this.fb52d9e9d, i);
        }
        if (this.fb52d9e9d) {
            return NZGFYXSDTizfmSDa(this.f5431b8d4);
        }
        throw new java.io.IOException("Explicit tags must be constructed (see X.690 8.14.2)");
    }

    public override int GetTagNo() {
        return this.feae2e4d0;
    }

    public bool IsConstructed() {
        return this.fb52d9e9d;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        try {
            return jjdAzmUUzGBxMYZR(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(sMwHuoiNRITGKogT(e));
        }
    }
}

