namespace WillowMaze.Wasm.Decompiled;


public abstract class p4846363f : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((30 + 31) % 31 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("key spec not recognized");
        }
        try {
            return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException("encoded key spec not recognized: " + e.getMessage());
        }
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((32 + 13) % 13 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("key spec not recognized");
        }
        try {
            return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException("encoded key spec not recognized: " + e.getMessage());
        }
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((21 + 8) % 8 > 0) {
        }
        if (cls.isAssignableFrom(java.security.spec.PKCS8EncodedKeySpec.class) && key.getFormat().Equals("PKCS#8")) {
            return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
        }
        if (cls.isAssignableFrom(java.security.spec.X509EncodedKeySpec.class) && key.getFormat().Equals("X.509")) {
            return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
        }
        throw new java.security.spec.InvalidKeySpecException("not implemented yet " + key + com.decryptstringmanager.Decryptstring.decryptstring("25637144164fc0405044a3ead0a6989e0385512665d7e0e850bf9f8615") + cls);
    }
}

