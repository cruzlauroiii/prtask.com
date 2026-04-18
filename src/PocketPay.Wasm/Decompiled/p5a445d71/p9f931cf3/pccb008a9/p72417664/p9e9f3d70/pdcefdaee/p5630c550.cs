namespace WillowMaze.Wasm.Decompiled;


public class p5630c550 : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("712c487892e2095236e4bc31170df665b5abaf62bb036ff0a5013e11704c8257b5f36d1a5c375c60adfbdf53aa2710c0230985960c79");
    public static readonly java.lang.string fcd8a57f1 = null;

    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((25 + 20) % 20 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("5b17399505dd4d6a304b3162f3162943db227487198707dd5b45bd6265"));
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded()));
            try {
                if (!p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getAlgorithm())) {
                    throw new java.security.spec.InvalidKeySpecException("Unable to recognise OID in McEliece public key");
                }
                p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd pddbd07cdVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd.m8bab0102(p811299f8VarM8bab0102.parsePrivateKey());
                return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f(pddbd07cdVarM8bab0102.getN(), pddbd07cdVarM8bab0102.getK(), pddbd07cdVarM8bab0102.getField(), pddbd07cdVarM8bab0102.getGoppaPoly(), pddbd07cdVarM8bab0102.getP(), p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pa470a233.me0825354(pddbd07cdVarM8bab0102.getDigest()).getAlgorithmName()));
            } catch (java.io.IOException unused) {
                throw new java.security.spec.InvalidKeySpecException("Unable to decode PKCS8EncodedKeySpec.");
            }
        } catch (java.io.IOException e) {
            throw new java.security.spec.InvalidKeySpecException("Unable to decode PKCS8EncodedKeySpec: " + e);
        }
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((5 + 15) % 15 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("53ae6efdd875f08fae90b1eded0014e09f2fa719beaa278bcd91d9a42f"));
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
            try {
                if (!p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p3cdccfc9VarM8bab0102.getAlgorithm().getAlgorithm())) {
                    throw new java.security.spec.InvalidKeySpecException("Unable to recognise OID in McEliece private key");
                }
                p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728 p751e4728VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728.m8bab0102(p3cdccfc9VarM8bab0102.parsePublicKey());
                return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe(p751e4728VarM8bab0102.getN(), p751e4728VarM8bab0102.getT(), p751e4728VarM8bab0102.getG(), p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pa470a233.me0825354(p751e4728VarM8bab0102.getDigest()).getAlgorithmName()));
            } catch (java.io.IOException e) {
                throw new java.security.spec.InvalidKeySpecException("Unable to decode X509EncodedKeySpec: " + e.getMessage());
            }
        } catch (java.io.IOException e2) {
            throw new java.security.spec.InvalidKeySpecException(e2.tostring());
        }
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        return null;
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        return null;
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((31 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd pddbd07cdVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd.m8bab0102(p811299f8Var.parsePrivateKey().toASN1Primitive());
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f(pddbd07cdVarM8bab0102.getN(), pddbd07cdVarM8bab0102.getK(), pddbd07cdVarM8bab0102.getField(), pddbd07cdVarM8bab0102.getGoppaPoly(), pddbd07cdVarM8bab0102.getP(), null));
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((22 + 32) % 32 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728 p751e4728VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728.m8bab0102(p3cdccfc9Var.parsePublicKey());
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe(p751e4728VarM8bab0102.getN(), p751e4728VarM8bab0102.getT(), p751e4728VarM8bab0102.getG(), p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pa470a233.me0825354(p751e4728VarM8bab0102.getDigest()).getAlgorithmName()));
    }

    public java.security.spec.KeySpec GetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((26 + 9) % 9 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("427367e7b7e735b82b2f9b454310655bec2c8e5debd888290d4d9286ca");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb)) {
                throw new java.security.spec.InvalidKeySpecException("Unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + cls + strDecryptstring);
    }

    public java.security.Key TranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb)) {
            return key;
        }
        throw new java.security.InvalidKeyException("Unsupported key type.");
    }
}

