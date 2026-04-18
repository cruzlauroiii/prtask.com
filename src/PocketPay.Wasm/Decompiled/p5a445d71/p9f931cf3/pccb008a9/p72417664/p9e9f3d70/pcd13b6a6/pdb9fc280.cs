namespace WillowMaze.Wasm.Decompiled;


public class pdb9fc280 : java.security.KeyFactorySpi : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    public override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((28 + 10) % 10 > 0) {
        }
        if (keySpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pb83ae16d) {
            return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee((p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pb83ae16d) keySpec);
        }
        if (!(keySpec is java.security.spec.PKCS8EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unsupported key specification: " + keySpec.GetType() + com.decryptstringmanager.Decryptstring.decryptstring("4e24038d7c6b6425cfa454317c734a83fb9b216d3aadf788e994c61df3"));
        }
        try {
            return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded())));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((25 + 27) % 27 > 0) {
        }
        if (keySpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c73b922) {
            return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f((p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c73b922) keySpec);
        }
        if (!(keySpec is java.security.spec.X509EncodedKeySpec)) {
            throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + keySpec + com.decryptstringmanager.Decryptstring.decryptstring("3add9af74906c9eca3fd25f848b5518d75a8c79b8f37373c538aafd016"));
        }
        try {
            return generatePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException(e.tostring());
        }
    }

    public override readonly java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((6 + 10) % 10 > 0) {
        }
        bool z = key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("9275569ebc0a70c2bbb9d86cda1331871200ad47ecd9ecba50fb3b459e");
        if (z) {
            if (java.security.spec.PKCS8EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.PKCS8EncodedKeySpec(key.getEncoded());
            }
            if (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pb83ae16d.class.isAssignableFrom(cls)) {
                p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee pd2f390eeVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee) key;
                return new p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.pb83ae16d(pd2f390eeVar.getInvA1(), pd2f390eeVar.getB1(), pd2f390eeVar.getInvA2(), pd2f390eeVar.getB2(), pd2f390eeVar.getVi(), pd2f390eeVar.getLayers());
            }
        } else {
            if (!(key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f)) {
                throw new java.security.spec.InvalidKeySpecException("Unsupported key type: " + key.GetType() + strDecryptstring);
            }
            if (java.security.spec.X509EncodedKeySpec.class.isAssignableFrom(cls)) {
                return new java.security.spec.X509EncodedKeySpec(key.getEncoded());
            }
            if (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c73b922.class.isAssignableFrom(cls)) {
                p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f p3ec0531fVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f) key;
                return new p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p4c73b922(p3ec0531fVar.getDocLength(), p3ec0531fVar.getCoeffQuadratic(), p3ec0531fVar.getCoeffSingular(), p3ec0531fVar.getCoeffScalar());
            }
        }
        throw new java.security.spec.InvalidKeySpecException("Unknown key specification: " + cls + strDecryptstring);
    }

    public override readonly java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if ((key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee) || (key is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f)) {
            return key;
        }
        throw new java.security.InvalidKeyException("Unsupported key type");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((7 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454 p2f98f454VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p2f98f454.m8bab0102(p811299f8Var.parsePrivateKey());
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.pd2f390ee(p2f98f454VarM8bab0102.getInvA1(), p2f98f454VarM8bab0102.getB1(), p2f98f454VarM8bab0102.getInvA2(), p2f98f454VarM8bab0102.getB2(), p2f98f454VarM8bab0102.getVi(), p2f98f454VarM8bab0102.getLayers());
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((6 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1 pf9e213f1VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1.m8bab0102(p3cdccfc9Var.parsePublicKey());
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p3ec0531f(pf9e213f1VarM8bab0102.getDocLength(), pf9e213f1VarM8bab0102.getCoeffQuadratic(), pf9e213f1VarM8bab0102.getCoeffSingular(), pf9e213f1VarM8bab0102.getCoeffScalar());
    }
}

