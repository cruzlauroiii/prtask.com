namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p15f19da3 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p15f19da3() {
        super(null);
    }

    pc9dc66d2$p15f19da3(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar;
        if ((23 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = (p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey();
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = p3cdccfc9Var.getAlgorithm().getParameters();
        if (parameters is null) {
            pe0946eddVar = null;
        } else {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(parameters.toASN1Primitive());
            pe0946eddVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(pf391b73dVar.getValue(), pe0946eddVar);
    }
}

