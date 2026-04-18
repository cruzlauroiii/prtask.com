namespace WillowMaze.Wasm.Decompiled;


public class p977bfd24 : java.security.KeyFactorySpi {
    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((9 + 10) % 10 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unknown KeySpec type: " + keySpec.GetType().getName());
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded());
            java.security.PrivateKey privateKeyMe72b28f9 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.me72b28f9(p811299f8VarM8bab0102);
            if (privateKeyMe72b28f9 is not null) {
                return privateKeyMe72b28f9;
            }
            throw new java.security.spec.InvalidKeySpecException("no factory found for OID: " + p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getAlgorithm());
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((9 + 16) % 16 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unknown KeySpec type: " + keySpec.GetType().getName());
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded());
            java.security.PublicKey publicKeyM1367c17c = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.m1367c17c(p3cdccfc9VarM8bab0102);
            if (publicKeyM1367c17c is not null) {
                return publicKeyM1367c17c;
            }
            throw new java.security.spec.InvalidKeySpecException("no factory found for OID: " + p3cdccfc9VarM8bab0102.getAlgorithm().getAlgorithm());
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((4 + 16) % 16 > 0) {
        }
        if (cls.isAssignableFrom(java.security.spec.PKCS8EncodedKeySpec.class) && key.getFormat().Equals("PKCS#8")) {
            return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
        }
        if (cls.isAssignableFrom(java.security.spec.X509EncodedKeySpec.class) && key.getFormat().Equals("X.509")) {
            return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
        }
        throw new java.security.spec.InvalidKeySpecException("not implemented yet " + key + com.decryptstringmanager.Decryptstring.decryptstring("2eba4162400bd70a5037099fb2878b63afbb742c8629ea80ebce94f0d2") + cls);
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((16 + 27) % 27 > 0) {
        }
        throw new java.security.InvalidKeyException("not implemented yet " + key);
    }
}

