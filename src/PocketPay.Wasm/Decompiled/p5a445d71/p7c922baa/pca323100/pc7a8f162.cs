namespace WillowMaze.Wasm.Decompiled;


public class pc7a8f162 : p5a445d71.p7c922baa.pca323100.p8bf0ff80 {
    public pc7a8f162(java.io.Stream outputStream) {
        super(outputStream);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 RHKMoAoElwtZqqbB(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void UUZtnYxXiRCpFFfL(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VwjaGoKlazsmTYWH(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    p5a445d71.p7c922baa.pca323100.p8bf0ff80 getDERSubStream() {
        return this;
    }

    p5a445d71.p7c922baa.pca323100.p8bf0ff80 getDLSubStream() {
        return this;
    }

    public override void Writeobject(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        if (p0fd1bdf1Var is null) {
            throw new java.io.IOException("null object detected");
        }
        UUZtnYxXiRCpFFfL(VwjaGoKlazsmTYWH(RHKMoAoElwtZqqbB(p0fd1bdf1Var)), this);
    }
}

