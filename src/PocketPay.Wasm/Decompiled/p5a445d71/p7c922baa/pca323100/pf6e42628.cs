namespace WillowMaze.Wasm.Decompiled;


public class pf6e42628 : p5a445d71.p7c922baa.pca323100.p138fad60 {
    public pf6e42628(java.io.Stream outputStream) throws java.io.IOException {
        super(outputStream);
        mdcXjzmXdXGcHvOg(this, 48);
    }

    public pf6e42628(java.io.Stream outputStream, int i, bool z) throws java.io.IOException {
        super(outputStream, i, z);
        ejNYrqCXBGudHRhS(this, 48);
    }

    public static void EjNYrqCXBGudHRhS(p5a445d71.p7c922baa.pca323100.pf6e42628 pf6e42628Var, int i) {
        pf6e42628Var.writeBERHeader(i);
    }

    public static void MdcXjzmXdXGcHvOg(p5a445d71.p7c922baa.pca323100.pf6e42628 pf6e42628Var, int i) {
        pf6e42628Var.writeBERHeader(i);
    }

    public static void QGmNqzJKkOpjGYAy(p5a445d71.p7c922baa.pca323100.pf6e42628 pf6e42628Var) {
        pf6e42628Var.writeBEREnd();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 SFjVDZGXoZzJgJWu(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void SgMAPJQUlYiwOPDy(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var);
    }

    public void Addobject(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        sgMAPJQUlYiwOPDy(sFjVDZGXoZzJgJWu(p0fd1bdf1Var), new p5a445d71.p7c922baa.pca323100.p547a7046(this.f353b66c0));
    }

    public void Close() throws java.io.IOException {
        qGmNqzJKkOpjGYAy(this);
    }
}

