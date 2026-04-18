namespace WillowMaze.Wasm.Decompiled;


abstract class pc933863a : java.io.Stream {
    private int f21b59360;
    private int f49c8bc2e;
    protected readonly java.io.Stream f678db741;
    private int f782ee3ab;
    private int fd1be6e5e;
    private int ff0f66e31;
    protected readonly java.io.Stream ff747bcd5;

    pc933863a(java.io.Stream inputStream, int i) {
        this.f678db741 = inputStream;
        this.f21b59360 = i;
    }

    public static void CLyKskPbiodOPDyZ(p5a445d71.p7c922baa.pca323100.p70b47217 p70b47217Var, bool z) {
        p70b47217Var.setEofOn00(z);
    }

    int getRemaining() {
        return this.f21b59360;
    }

    protected void SetParentEofDetect(bool z) {
        java.io.Stream inputStream = this.f678db741;
        if (inputStream is p5a445d71.p7c922baa.pca323100.p70b47217) {
            CLyKskPbiodOPDyZ((p5a445d71.p7c922baa.pca323100.p70b47217) inputStream, z);
        }
    }
}

