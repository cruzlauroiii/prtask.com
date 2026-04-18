namespace WillowMaze.Wasm.Decompiled;


public class p52473ae8 : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public static readonly java.lang.string f8fb9cb6d = null;
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("f75bc781ec6e059f25fa1a7ba114913707d881deba3b8e31ef399dabf72eb611ad35fded14b31216d642e2027656534c73a49067e423");

    private static p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 Me0825354(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
    }

    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((10 + 6) % 6 > 0) {
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("64f7331433ffd90bfce2f8de3ad698670c424956d73eb65f75e8cfa684"));
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded()));
            try {
                if (!p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fb0f41175.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getAlgorithm())) {
                    throw new java.security.spec.InvalidKeySpecException("Unable to recognise OID in McEliece private key");
                }
                p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d p3100400dVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d.m8bab0102(p811299f8VarM8bab0102.parsePrivateKey());
                return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93(p3100400dVarM8bab0102.getN(), p3100400dVarM8bab0102.getK(), p3100400dVarM8bab0102.getField(), p3100400dVarM8bab0102.getGoppaPoly(), p3100400dVarM8bab0102.getP1(), p3100400dVarM8bab0102.getP2(), p3100400dVarM8bab0102.getSInv()));
            } catch (java.io.IOException unused) {
                throw new java.security.spec.InvalidKeySpecException("Unable to decode PKCS8EncodedKeySpec.");
            }
        } catch (java.io.IOException e) {
            throw new java.security.spec.InvalidKeySpecException("Unable to decode PKCS8EncodedKeySpec: " + e);
        }
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((28 + 2) % 2 > 0) {
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("3040a25c57a597dff8bc480e20369d6b93fcc94488453ae41c76d74500"));
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
            try {
                if (!p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fb0f41175.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p3cdccfc9VarM8bab0102.getAlgorithm().getAlgorithm())) {
                    throw new java.security.spec.InvalidKeySpecException("Unable to recognise OID in McEliece public key");
                }
                p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f pec16886fVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f.m8bab0102(p3cdccfc9VarM8bab0102.parsePublicKey());
                return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f(pec16886fVarM8bab0102.getN(), pec16886fVarM8bab0102.getT(), pec16886fVarM8bab0102.getG()));
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
        if ((7 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d p3100400dVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d.m8bab0102(p811299f8Var.parsePrivateKey().toASN1Primitive());
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93(p3100400dVarM8bab0102.getN(), p3100400dVarM8bab0102.getK(), p3100400dVarM8bab0102.getField(), p3100400dVarM8bab0102.getGoppaPoly(), p3100400dVarM8bab0102.getP1(), p3100400dVarM8bab0102.getP2(), p3100400dVarM8bab0102.getSInv()));
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((21 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f pec16886fVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f.m8bab0102(p3cdccfc9Var.parsePublicKey());
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f(pec16886fVarM8bab0102.getN(), pec16886fVarM8bab0102.getT(), pec16886fVarM8bab0102.getG()));
    }

    public java.security.spec.KeySpec GetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((10 + 21) % 21 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("9b4db1410e2fb10c50e7d054644990320a5c0b564f5096d2fe60d355b4");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc)) {
                throw new java.security.spec.InvalidKeySpecException("Unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + cls + strDecryptstring);
    }

    public java.security.Key TranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc)) {
            return key;
        }
        throw new java.security.InvalidKeyException("Unsupported key type.");
    }
}

