namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p7f62c7c5 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p7f62c7c5() {
        super(null);
    }

    pc9dc66d2$p7f62c7c5(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        if ((25 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = (p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey();
        java.math.Bigint l = pef342a14VarM8bab0102.getL();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(pf391b73dVar.getValue(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), null, l is not null ? l.intValue() : 0));
    }
}

