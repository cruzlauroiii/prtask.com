namespace WillowMaze.Wasm.Decompiled;


public class pf438a455 : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((16 + 6) % 6 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("5183ae622ef2b7221e9c9cb893263569c4311a98e9f6d1df06c6fd5f08"));
        }
        try {
            return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded())));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((20 + 19) % 19 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + keySpec + com.decryptstringmanager.Decryptstring.decryptstring("4652de4c6cd9803e957417d65fc71b3581c0ecf497130a979e17cd3461"));
        }
        try {
            return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override readonly java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((16 + 14) % 14 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("41b3f25384ecf8f32da996c286d20399da33079bb8825afc477061a7a7");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe)) {
                throw new java.security.spec.InvalidKeySpecException("Unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + cls + strDecryptstring);
    }

    public override readonly java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe)) {
            return key;
        }
        throw new java.security.InvalidKeyException("Unsupported key type");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099(p811299f8Var);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe(p3cdccfc9Var);
    }
}

