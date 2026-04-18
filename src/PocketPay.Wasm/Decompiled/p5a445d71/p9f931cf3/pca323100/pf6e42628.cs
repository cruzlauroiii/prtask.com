namespace WillowMaze.Wasm.Decompiled;


public class pf6e42628 : p5a445d71.p9f931cf3.pca323100.p138fad60 {
    public pf6e42628(java.io.Stream outputStream) throws java.io.IOException {
        super(outputStream);
        pnhYVQRIqdYsqKsw(this, 48);
    }

    public pf6e42628(java.io.Stream outputStream, int i, bool z) throws java.io.IOException {
        super(outputStream, i, z);
        QojnRaFiaDQsRicJ(this, 48);
    }

    public static void KzUzBvuUsFWQylrO(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream);
    }

    public static void MLyMdFELnMVWvOZX(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.io.Stream outputStream) throws java.io.IOException {
        p301c7ed4Var.encodeTo(outputStream);
    }

    public static void QojnRaFiaDQsRicJ(p5a445d71.p9f931cf3.pca323100.pf6e42628 pf6e42628Var, int i) {
        pf6e42628Var.writeBERHeader(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 LVVPoGCcpFmKHmCP(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void LcVoWoHuosWBlwwt(p5a445d71.p9f931cf3.pca323100.pf6e42628 pf6e42628Var) {
        pf6e42628Var.writeBEREnd();
    }

    public static void PnhYVQRIqdYsqKsw(p5a445d71.p9f931cf3.pca323100.pf6e42628 pf6e42628Var, int i) {
        pf6e42628Var.writeBERHeader(i);
    }

    public void Addobject(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        KzUzBvuUsFWQylrO(lVVPoGCcpFmKHmCP(p0fd1bdf1Var), this.f353b66c0);
    }

    public void Addobject(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) throws java.io.IOException {
        MLyMdFELnMVWvOZX(p301c7ed4Var, this.f353b66c0);
    }

    public void Close() throws java.io.IOException {
        lcVoWoHuosWBlwwt(this);
    }
}

