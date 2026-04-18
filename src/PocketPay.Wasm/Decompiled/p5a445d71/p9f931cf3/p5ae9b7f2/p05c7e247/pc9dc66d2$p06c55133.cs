namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p06c55133 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p06c55133() {
        super(null);
    }

    pc9dc66d2$p06c55133(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var;
        if ((9 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) p15be22c4VarM8bab0102.getParameters();
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.md0402605(p364bf33aVar);
            if (p35e46fcbVarMd0402605 is null) {
                p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(p364bf33aVar);
            }
            p21c2eb74Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVar, p35e46fcbVarMd0402605);
        } else {
            p21c2eb74Var = !p15be22c4VarM8bab0102.isImplicitlyCA() ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters())) : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74) obj;
        }
        byte[] bytes = p3cdccfc9Var.getPublicKeyData().getbytes();
        p5a445d71.p9f931cf3.pca323100.p11b04310 p6f0e511cVar = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bytes);
        if (bytes[0] == 4 && bytes[1] == bytes.length - 2) {
            byte b = bytes[2];
            if ((b == 2 || b == 3) && new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5().getbyteLength(p21c2eb74Var.getCurve()) >= bytes.length - 3) {
                try {
                    p6f0e511cVar = (p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bytes);
                } catch (java.io.IOException unused) {
                    throw new java.lang.IllegalArgumentException("error recovering public key");
                }
            }
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p21c2eb74Var.getCurve(), p6f0e511cVar).getPoint(), p21c2eb74Var);
    }
}

