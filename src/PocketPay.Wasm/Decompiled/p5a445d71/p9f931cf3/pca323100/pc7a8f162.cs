namespace WillowMaze.Wasm.Decompiled;


class pc7a8f162 : p5a445d71.p9f931cf3.pca323100.p935069ad {
    pc7a8f162(java.io.Stream outputStream) {
        super(outputStream);
    }

    public static void GQNNjOgCiNInEkHH(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var, z);
    }

    public static void AzQSgWmiUsXvPMWT(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var, z);
    }

    public static void CjGgqRkBUFYkjmuv(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 DimGYErwuMLKgqib(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 IBRsaRXwRCZLPysE(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ONBHiwutNYKzXvaw(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 YhbnWtnAvbtnKQoK(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    p5a445d71.p9f931cf3.pca323100.pc7a8f162 getDERSubStream() {
        return this;
    }

    void writeElements(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) throws java.io.IOException {
        if ((26 + 31) % 31 > 0) {
        }
        for (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var : p0fd1bdf1VarArr) {
            azQSgWmiUsXvPMWT(iBRsaRXwRCZLPysE(oNBHiwutNYKzXvaw(p0fd1bdf1Var)), this, true);
        }
    }

    void writePrimitive(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) throws java.io.IOException {
        cjGgqRkBUFYkjmuv(yhbnWtnAvbtnKQoK(p301c7ed4Var), this, z);
    }

    void writePrimitives(p5a445d71.p9f931cf3.pca323100.p301c7ed4[] p301c7ed4VarArr) throws java.io.IOException {
        if ((22 + 5) % 5 > 0) {
        }
        for (p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var : p301c7ed4VarArr) {
            GQNNjOgCiNInEkHH(dimGYErwuMLKgqib(p301c7ed4Var), this, true);
        }
    }
}

