namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p39e3a865 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p39e3a865() {
        super(null);
    }

    pc9dc66d2$p39e3a865(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b p51ac8148_p2bd4a59bWithPublicKey;
        if ((26 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551 pacfb2551VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        if (pacfb2551VarM8bab0102 is null) {
            byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p3cdccfc9Var.parsePublicKey()).getOctets();
            p51ac8148_p2bd4a59bWithPublicKey = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194.m14dde801(p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(octets, 0))).withPublicKey(octets);
        } else {
            p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = pacfb2551VarM8bab0102.getTreeDigest().getAlgorithm();
            p5a445d71.p9f931cf3.pccb008a9.pca323100.p81c0a6c0 p81c0a6c0VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p81c0a6c0.m8bab0102(p3cdccfc9Var.parsePublicKey());
            p51ac8148_p2bd4a59bWithPublicKey = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(pacfb2551VarM8bab0102.getHeight(), pacfb2551VarM8bab0102.getLayers(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.me0825354(algorithm))).withPublicSeed(p81c0a6c0VarM8bab0102.getPublicSeed()).withRoot(p81c0a6c0VarM8bab0102.getRoot());
        }
        return p51ac8148_p2bd4a59bWithPublicKey.build();
    }
}

