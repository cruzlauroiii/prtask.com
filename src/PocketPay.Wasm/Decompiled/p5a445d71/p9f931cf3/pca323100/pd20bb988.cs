namespace WillowMaze.Wasm.Decompiled;


public class pd20bb988 : p5a445d71.p9f931cf3.pca323100.p4183ae36 {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f9af82489;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f9f900604;

    pd20bb988(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.pa2b87867 ZyquSZUNCCdtzleC(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return m2e88eca8(p8557f615Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd6ccb7fc HGYJgaFClyymCZda(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KUmaBdLZkrhJconX(p5a445d71.p9f931cf3.pca323100.pd20bb988 pd20bb988Var) {
        return pd20bb988Var.getLoadedobject();
    }

    static p5a445d71.p9f931cf3.pca323100.pa2b87867 M2e88eca8(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pca323100.pa2b87867(hGYJgaFClyymCZda(p8557f615Var));
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 PXGFIpmHWikmzkUG(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static java.lang.string RqJMyfBnmVNAKYUi(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return ZyquSZUNCCdtzleC(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return pXGFIpmHWikmzkUG(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 16) % 16 > 0) {
        }
        try {
            return kUmaBdLZkrhJconX(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(rqJMyfBnmVNAKYUi(e), e);
        }
    }
}

