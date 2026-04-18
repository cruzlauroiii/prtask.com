namespace WillowMaze.Wasm.Decompiled;


public class p935069ad : p5a445d71.p7c922baa.pca323100.p8bf0ff80 {
    public p935069ad(java.io.Stream outputStream) {
        super(outputStream);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 LPFAdQvYKfWBGhwj(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDLobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 ZDblDvkeIpyHWAQR(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void HMzyaKtIRtWXiMPI(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var);
    }

    public override void Writeobject(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        if (p0fd1bdf1Var is null) {
            throw new java.io.IOException("null object detected");
        }
        hMzyaKtIRtWXiMPI(LPFAdQvYKfWBGhwj(ZDblDvkeIpyHWAQR(p0fd1bdf1Var)), this);
    }
}

