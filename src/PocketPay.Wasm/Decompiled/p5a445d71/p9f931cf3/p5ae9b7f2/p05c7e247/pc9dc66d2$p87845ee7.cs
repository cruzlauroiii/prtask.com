namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$p87845ee7 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$p87845ee7() {
        super(null);
    }

    pc9dc66d2$p87845ee7(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) {
        if ((2 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 algorithm = p3cdccfc9Var.getAlgorithm();
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm2 = algorithm.getAlgorithm();
        p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(algorithm.getParameters());
        p5a445d71.p9f931cf3.pca323100.p364bf33a publicKeyParamHashSet = p3d5f6347VarM8bab0102.getPublicKeyParamHashSet();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483 p2cc33483Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(publicKeyParamHashSet, p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(publicKeyParamHashSet)), publicKeyParamHashSet, p3d5f6347VarM8bab0102.getDigestParamHashSet(), p3d5f6347VarM8bab0102.getEncryptionParamHashSet());
        try {
            p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var = (p5a445d71.p9f931cf3.pca323100.p11b04310) p3cdccfc9Var.parsePublicKey();
            int i = !algorithm2.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5) ? 32 : 64;
            int i2 = i * 2;
            byte[] octets = p11b04310Var.getOctets();
            if (octets.length != i2) {
                throw new java.lang.IllegalArgumentException("invalid length for GOST3410_2012 public key");
            }
            byte[] bArr = new byte[i2 + 1];
            bArr[0] = 4;
            for (int i3 = 1; i3 <= i; i3++) {
                bArr[i3] = octets[i - i3];
                bArr[i3 + i] = octets[i2 - i3];
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p2cc33483Var.getCurve().decodePoint(bArr), p2cc33483Var);
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("error recovering GOST3410_2012 public key");
        }
    }
}

