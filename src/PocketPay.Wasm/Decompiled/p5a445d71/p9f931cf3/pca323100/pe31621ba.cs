namespace WillowMaze.Wasm.Decompiled;


public class pe31621ba : p5a445d71.p9f931cf3.pca323100.pc7ce2d30 {
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 f76d87901;
    private p5a445d71.p9f931cf3.pca323100.p8557f615 ffa4f63dc;

    public pe31621ba(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p89948dc0 EfwsaoKgVpxstYKw(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return m2e88eca8(p8557f615Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FNgfUcyuAaKRbPXG(p5a445d71.p9f931cf3.pca323100.pe31621ba pe31621baVar) {
        return pe31621baVar.getLoadedobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd6ccb7fc ZvNMASxLZURUdwsE(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readVector();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ACiuHcincllNDoqs(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    static p5a445d71.p9f931cf3.pca323100.p89948dc0 M2e88eca8(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) throws java.io.IOException {
        if ((7 + 22) % 22 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p89948dc0(ZvNMASxLZURUdwsE(p8557f615Var));
        } catch (java.lang.IllegalArgumentException e) {
            throw new p5a445d71.p9f931cf3.pca323100.pa2b39ca1(tOaxKgzPvmqMrWId(e), e);
        }
    }

    public static java.lang.string TOaxKgzPvmqMrWId(java.lang.IllegalArgumentException illegalArgumentException) {
        return illegalArgumentException.getMessage();
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        return EfwsaoKgVpxstYKw(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        return aCiuHcincllNDoqs(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((30 + 1) % 1 > 0) {
        }
        try {
            return FNgfUcyuAaKRbPXG(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024("unable to get DER object", e);
        } catch (java.lang.IllegalArgumentException e2) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024("unable to get DER object", e2);
        }
    }
}

