namespace WillowMaze.Wasm.Decompiled;


public class p83204de6 : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((3 + 15) % 15 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("5a8b28daf762e59d2e23abd73db1b70cfce7aad03181d9747de8cf50d5"));
        }
        try {
            return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded())));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((16 + 17) % 17 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + keySpec + com.decryptstringmanager.Decryptstring.decryptstring("560574bf0fba28d0977a6fabc495d38291dbd28bbe96fbcb5931eb2ef3"));
        }
        try {
            return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override readonly java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((4 + 32) % 32 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("aa4b76b94a079647d39a736116137091fb3041cdbb59cd4a064ef6de31");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52)) {
                throw new java.security.spec.InvalidKeySpecException("Unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + cls + strDecryptstring);
    }

    public override readonly java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52)) {
            return key;
        }
        throw new java.security.InvalidKeyException("Unsupported key type");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d(p811299f8Var);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52(p3cdccfc9Var);
    }
}

