namespace WillowMaze.Wasm.Decompiled;


public class p8a423ff2 : p5a445d71.p9f931cf3.pca323100.p94dfe8e0 {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f05d09a11;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f2c93e23b;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;

    p8a423ff2(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p85c20c01 IuARIeLrBcbxwhWa(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        return p5a445d71.p9f931cf3.pca323100.pe6365583.mb3b41fc6(pd6ccb7fcVar);
    }

    public static java.lang.string SzcUpUuAEcWPygKX(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd6ccb7fc XszrySejIdfPMwjm(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 RRqcdkVbCDtnUule(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZJSGoHrIiSQKPfnJ(p5a445d71.p9f931cf3.pca323100.p8a423ff2 p8a423ff2Var) {
        return p8a423ff2Var.getLoadedobject();
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return IuARIeLrBcbxwhWa(XszrySejIdfPMwjm(this.f5431b8d4));
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return rRqcdkVbCDtnUule(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        try {
            return zJSGoHrIiSQKPfnJ(this);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(SzcUpUuAEcWPygKX(e));
        }
    }
}

