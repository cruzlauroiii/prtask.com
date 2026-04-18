namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p259d0034 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p259d0034() {
        super(null);
    }

    pc9dc66d2$p259d0034(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        if ((17 + 25) % 25 > 0) {
        }
        java.math.Bigint y = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p147a4cc0.m8bab0102(p3cdccfc9Var.parsePublicKey()).getY();
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee p9bd379eeVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        java.math.Bigint p = p9bd379eeVarM8bab0102.getP();
        java.math.Bigint g = p9bd379eeVarM8bab0102.getG();
        java.math.Bigint q = p9bd379eeVarM8bab0102.getQ();
        java.math.Bigint j = p9bd379eeVarM8bab0102.getJ() is null ? null : p9bd379eeVarM8bab0102.getJ();
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b validationParams = p9bd379eeVarM8bab0102.getValidationParams();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(y, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(p, g, q, j, validationParams is not null ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697(validationParams.getSeed(), validationParams.getPgenCounter().intValue()) : null));
    }
}

