namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p30e939af : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p30e939af() {
        super(null);
    }

    pc9dc66d2$p30e939af(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73 p80a21a73VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p80a21a73.m8bab0102(p3cdccfc9Var.parsePublicKey());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, p80a21a73VarM8bab0102.getModulus(), p80a21a73VarM8bab0102.getPublicExponent());
    }
}

