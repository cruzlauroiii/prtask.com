namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$pae335842 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$pae335842() {
        super(null);
    }

    pc9dc66d2$pae335842(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p3cdccfc9Var.parsePublicKey()).getOctets();
        if (p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(octets, 0) == 1) {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets, 4, octets.length));
        }
        if (octets.length == 64) {
            octets = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets, 4, octets.length);
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b.m8bab0102(octets);
    }
}

