namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$pbdf1d41a : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$pbdf1d41a() {
        super(null);
    }

    pc9dc66d2$pbdf1d41a(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b pe1225d2e_p2bd4a59bWithPublicKey;
        if ((29 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77 p2bd3ac77VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        if (p2bd3ac77VarM8bab0102 is null) {
            byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p3cdccfc9Var.parsePublicKey()).getOctets();
            pe1225d2e_p2bd4a59bWithPublicKey = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9.m14dde801(p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(octets, 0))).withPublicKey(octets);
        } else {
            p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p2bd3ac77VarM8bab0102.getTreeDigest().getAlgorithm();
            p5a445d71.p9f931cf3.pccb008a9.pca323100.p81c0a6c0 p81c0a6c0VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p81c0a6c0.m8bab0102(p3cdccfc9Var.parsePublicKey());
            pe1225d2e_p2bd4a59bWithPublicKey = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(p2bd3ac77VarM8bab0102.getHeight(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.me0825354(algorithm))).withPublicSeed(p81c0a6c0VarM8bab0102.getPublicSeed()).withRoot(p81c0a6c0VarM8bab0102.getRoot());
        }
        return pe1225d2e_p2bd4a59bWithPublicKey.build();
    }
}

