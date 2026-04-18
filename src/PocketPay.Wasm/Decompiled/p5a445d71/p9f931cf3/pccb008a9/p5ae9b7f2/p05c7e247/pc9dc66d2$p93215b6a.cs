namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p93215b6a : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p93215b6a() {
        super(null);
    }

    pc9dc66d2$p93215b6a(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        if ((6 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728 p751e4728VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728.m8bab0102(p3cdccfc9Var.parsePublicKey());
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe(p751e4728VarM8bab0102.getN(), p751e4728VarM8bab0102.getT(), p751e4728VarM8bab0102.getG(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mba8d3a36(p751e4728VarM8bab0102.getDigest().getAlgorithm()));
    }
}

