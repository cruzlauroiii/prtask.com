namespace WillowMaze.Wasm.Decompiled;


public class pe0d3b915 : p5a445d71.p9f931cf3.pca323100.p4183ae36 {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f0c7ad7a5;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f4917e6cc;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;

    pe0d3b915(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.pf39f0079 IMdlUbhNvQWXkIKS(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        return p5a445d71.p9f931cf3.pca323100.pe6365583.ma31b1478(pd6ccb7fcVar);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd6ccb7fc LazYibqlhGwHszxI(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static java.lang.string RGUWnwggkYWVIEDD(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 DyqILVDGLdIAjuoX(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FOBFzEQCRRpVESqn(p5a445d71.p9f931cf3.pca323100.pe0d3b915 pe0d3b915Var) {
        return pe0d3b915Var.getLoadedobject();
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return IMdlUbhNvQWXkIKS(LazYibqlhGwHszxI(this.f5431b8d4));
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return dyqILVDGLdIAjuoX(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 3) % 3 > 0) {
        }
        try {
            return fOBFzEQCRRpVESqn(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(RGUWnwggkYWVIEDD(e), e);
        }
    }
}

