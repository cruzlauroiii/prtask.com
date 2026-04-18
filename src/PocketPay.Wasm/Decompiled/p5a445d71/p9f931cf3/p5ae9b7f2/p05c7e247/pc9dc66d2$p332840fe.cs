namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p332840fe : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p332840fe() {
        super(null);
    }

    pc9dc66d2$p332840fe(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        if ((27 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f p524aa06fVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0(((p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey()).getValue(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(p524aa06fVarM8bab0102.getP(), p524aa06fVarM8bab0102.getG()));
    }
}

