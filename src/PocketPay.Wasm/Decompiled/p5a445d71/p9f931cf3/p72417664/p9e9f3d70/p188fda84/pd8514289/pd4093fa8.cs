namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f {
    private bool Mce74825b(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a) || p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5) || p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f9b97977f) || p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7cba43c4);
    }

    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e) ? !(keySpec is java.security.spec.ECPrivateKeySpec) ? super.engineGeneratePrivate(keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf((java.security.spec.ECPrivateKeySpec) keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e) keySpec);
    }

    public override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1) ? !(keySpec is java.security.spec.ECPublicKeySpec) ? super.engineGeneratePublic(keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed((java.security.spec.ECPublicKeySpec) keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1) keySpec, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea);
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((9 + 6) % 6 > 0) {
        }
        if (cls.isAssignableFrom(java.security.spec.ECPublicKeySpec.class) && (key is java.security.interfaces.ECPublicKey)) {
            java.security.interfaces.ECPublicKey eCPublicKey = (java.security.interfaces.ECPublicKey) key;
            if (eCPublicKey.getParams() is not null) {
                return new java.security.spec.ECPublicKeySpec(eCPublicKey.getW(), eCPublicKey.getParams());
            }
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa();
            return new java.security.spec.ECPublicKeySpec(eCPublicKey.getW(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getSeed()), ecImplicitlyCa));
        }
        if (cls.isAssignableFrom(java.security.spec.ECPrivateKeySpec.class) && (key is java.security.interfaces.ECPrivateKey)) {
            java.security.interfaces.ECPrivateKey eCPrivateKey = (java.security.interfaces.ECPrivateKey) key;
            if (eCPrivateKey.getParams() is not null) {
                return new java.security.spec.ECPrivateKeySpec(eCPrivateKey.getS(), eCPrivateKey.getParams());
            }
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa2 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa();
            return new java.security.spec.ECPrivateKeySpec(eCPrivateKey.getS(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(ecImplicitlyCa2.getCurve(), ecImplicitlyCa2.getSeed()), ecImplicitlyCa2));
        }
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1.class) && (key is java.security.interfaces.ECPublicKey)) {
            java.security.interfaces.ECPublicKey eCPublicKey2 = (java.security.interfaces.ECPublicKey) key;
            if (eCPublicKey2.getParams() is not null) {
                return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(eCPublicKey2.getParams(), eCPublicKey2.getW()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCPublicKey2.getParams()));
            }
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(eCPublicKey2.getParams(), eCPublicKey2.getW()), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa());
        }
        if (!cls.isAssignableFrom(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e.class) || !(key is java.security.interfaces.ECPrivateKey)) {
            return super.engineGetKeySpec(key, cls);
        }
        java.security.interfaces.ECPrivateKey eCPrivateKey2 = (java.security.interfaces.ECPrivateKey) key;
        if (eCPrivateKey2.getParams() is not null) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e(eCPrivateKey2.getS(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCPrivateKey2.getParams()));
        }
        return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e(eCPrivateKey2.getS(), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa());
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((19 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (mce74825b(algorithm)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf(p811299f8Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((23 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (mce74825b(algorithm)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed(p3cdccfc9Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }
}

