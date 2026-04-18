namespace WillowMaze.Wasm.Decompiled;


public class p60056297 : p5a445d71.p7c922baa.pca323100.p3d058689 {
    private readonly int f2d39bbfb;
    private readonly p5a445d71.p7c922baa.pca323100.p8557f615 f3643b863;
    private readonly p5a445d71.p7c922baa.pca323100.p8557f615 f3df94085;
    private readonly p5a445d71.p7c922baa.pca323100.p8557f615 f60088ef5;
    private readonly int f73982b3e;
    private readonly int fb0af4d95;
    private readonly p5a445d71.p7c922baa.pca323100.p8557f615 fbb52bf88;
    private readonly int fc69d18be;
    private readonly int fe4d23e84;

    p60056297(int i, p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        this.fe4d23e84 = i;
        this.f3643b863 = p8557f615Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 GpjSPcPQKwTrPIkZ(p5a445d71.p7c922baa.pca323100.p60056297 p60056297Var) {
        return p60056297Var.getLoadedobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pd6ccb7fc HJiRVWQYEfGoXonV(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MkZMRVcyLgNIOikt(p5a445d71.p7c922baa.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static java.lang.string TKCFkqFepeLRafHB(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        if ((7 + 9) % 9 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.pc807ebcd(this.fe4d23e84, HJiRVWQYEfGoXonV(this.f3643b863));
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return MkZMRVcyLgNIOikt(this.f3643b863);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((8 + 23) % 23 > 0) {
        }
        try {
            return GpjSPcPQKwTrPIkZ(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(TKCFkqFepeLRafHB(e), e);
        }
    }
}

