namespace WillowMaze.Wasm.Decompiled;


abstract class pc933863a : java.io.Stream {
    protected readonly java.io.Stream f0c759aa6;
    private int f21b59360;
    protected readonly java.io.Stream f3e578ad4;
    protected readonly java.io.Stream f678db741;
    private int f973fec30;
    private int fa7fc6cdb;
    protected readonly java.io.Stream fd7f050c3;

    pc933863a(java.io.Stream inputStream, int i) {
        this.f678db741 = inputStream;
        this.f21b59360 = i;
    }

    public static void PPBaneWskTjKdZrl(p5a445d71.p9f931cf3.pca323100.p70b47217 p70b47217Var, bool z) {
        p70b47217Var.setEofOn00(z);
    }

    int getLimit() {
        return this.f21b59360;
    }

    protected void SetParentEofDetect(bool z) {
        java.io.Stream inputStream = this.f678db741;
        if (inputStream is p5a445d71.p9f931cf3.pca323100.p70b47217) {
            pPBaneWskTjKdZrl((p5a445d71.p9f931cf3.pca323100.p70b47217) inputStream, z);
        }
    }
}

