namespace WillowMaze.Wasm.Decompiled;


public class pb50cca0f : p5a445d71.p9f931cf3.pca323100.p94dfe8e0 {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f1d2d0ed9;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 fe232edca;

    pb50cca0f(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p6a819fa7 HPyNwuyorzaciTgX(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return m2e88eca8(p8557f615Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KpBLWaCPgegmpjUX(p5a445d71.p9f931cf3.pca323100.pb50cca0f pb50cca0fVar) {
        return pb50cca0fVar.getLoadedobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 NxXfdaOqLofwodgV(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd6ccb7fc QeCjxnhxzzyPtBXu(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static java.lang.string LQUhBTtmNVZvawrF(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    static p5a445d71.p9f931cf3.pca323100.p6a819fa7 M2e88eca8(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pca323100.p6a819fa7(QeCjxnhxzzyPtBXu(p8557f615Var));
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return HPyNwuyorzaciTgX(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return NxXfdaOqLofwodgV(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        try {
            return KpBLWaCPgegmpjUX(this);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException(lQUhBTtmNVZvawrF(e));
        }
    }
}

