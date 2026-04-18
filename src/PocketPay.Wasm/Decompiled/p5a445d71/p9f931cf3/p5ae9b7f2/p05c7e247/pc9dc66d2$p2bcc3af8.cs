namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p2bcc3af8 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p2bcc3af8() {
        super(null);
    }

    pc9dc66d2$p2bcc3af8(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) {
        if ((15 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.p364bf33a publicKeyParamHashSet = p3d5f6347VarM8bab0102.getPublicKeyParamHashSet();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483 p2cc33483Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(publicKeyParamHashSet, p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(publicKeyParamHashSet)), publicKeyParamHashSet, p3d5f6347VarM8bab0102.getDigestParamHashSet(), p3d5f6347VarM8bab0102.getEncryptionParamHashSet());
        try {
            byte[] octets = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p3cdccfc9Var.parsePublicKey()).getOctets();
            if (octets.length != 64) {
                throw new java.lang.IllegalArgumentException("invalid length for GOST3410_2001 public key");
            }
            byte[] bArr = new byte[65];
            bArr[0] = 4;
            for (int i = 1; i <= 32; i++) {
                bArr[i] = octets[32 - i];
                bArr[i + 32] = octets[64 - i];
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p2cc33483Var.getCurve().decodePoint(bArr), p2cc33483Var);
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("error recovering GOST3410_2001 public key");
        }
    }
}

