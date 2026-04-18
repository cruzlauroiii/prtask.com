namespace WillowMaze.Wasm.Decompiled;


public class p786b122d : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((14 + 28) % 28 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("8c9c8b63fe971b96671ec66c513c602c6e19764545c710ed58e9acd283"));
        }
        try {
            return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded())));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((26 + 31) % 31 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("unknown key specification: " + keySpec + com.decryptstringmanager.Decryptstring.decryptstring("e3a3b6fd1905303a89f1d88569872738d0349e40a74a9f4a929faa347d"));
        }
        try {
            return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override readonly java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((11 + 15) % 15 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("31df44e3f918a7d24ed7ed4a579140f03de98bc758e358b2c7ad681cb4");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3)) {
                throw new java.security.spec.InvalidKeySpecException("unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("unknown key specification: " + cls + strDecryptstring);
    }

    public override readonly java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3)) {
            return key;
        }
        throw new java.security.InvalidKeyException("unsupported key type");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970(p811299f8Var);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3(p3cdccfc9Var);
    }
}

