namespace WillowMaze.Wasm.Decompiled;


public class pa7b92d9b : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((5 + 5) % 5 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("2d317a553aeb37ed16a8c069cb3a863594c36e5f731337686e10d7ce1b"));
        }
        try {
            return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded())));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring(), e);
        }
    }

    public override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((20 + 25) % 25 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("unknown key specification: " + keySpec + com.decryptstringmanager.Decryptstring.decryptstring("6af92e64472c59dc5ddf332c249c460bc0f3fd02da5ef46720707aad23"));
        }
        try {
            return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring(), e);
        }
    }

    public override readonly java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((3 + 32) % 32 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("8ae2f1f2ce6ef3939bf7197912d07237d7416ab89e3b64f63ff5d682f2");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4)) {
                throw new java.security.spec.InvalidKeySpecException("unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("unknown key specification: " + cls + strDecryptstring);
    }

    public override readonly java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4)) {
            return key;
        }
        throw new java.security.InvalidKeyException("unsupported key type");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.p241bd5c3(p811299f8Var);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd27cfd44.pb98d31c4(p3cdccfc9Var);
    }
}

