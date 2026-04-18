namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f {
    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((14 + 28) % 28 > 0) {
        }
        if (keySpec is java.security.spec.PKCS8EncodedKeySpec) {
            try {
                return generatePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded()));
            } catch (java.lang.Exception e) {
                try {
                    return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2baebdc5(p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1.m8bab0102(((java.security.spec.PKCS8EncodedKeySpec) keySpec).getEncoded()));
                } catch (java.lang.Exception unused) {
                    throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p6be59720("unable to process key spec: " + e.tostring(), e);
                }
            }
        }
        if (keySpec is java.security.spec.RSAPrivateCrtKeySpec) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2baebdc5((java.security.spec.RSAPrivateCrtKeySpec) keySpec);
        }
        if (keySpec is java.security.spec.RSAPrivateKeySpec) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p44536675((java.security.spec.RSAPrivateKeySpec) keySpec);
        }
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b)) {
            throw new java.security.spec.InvalidKeySpecException("unknown KeySpec type: " + keySpec.GetType().getName());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM72ace772 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc8fff9db.m72ace772(((p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b) keySpec).getEncoded());
        if (pcfffbc4aVarM72ace772 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2baebdc5((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) pcfffbc4aVarM72ace772);
        }
        throw new java.security.spec.InvalidKeySpecException("open SSH public key is not RSA private key");
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if (keySpec is java.security.spec.RSAPublicKeySpec) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371((java.security.spec.RSAPublicKeySpec) keySpec);
        }
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e)) {
            return super.engineGeneratePublic(keySpec);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM5355d3b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m5355d3b5(((p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e) keySpec).getEncoded());
        if (pcfffbc4aVarM5355d3b5 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pcfffbc4aVarM5355d3b5);
        }
        throw new java.security.spec.InvalidKeySpecException("Open SSH public key is not RSA public key");
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((5 + 12) % 12 > 0) {
        }
        if ((cls.isAssignableFrom(java.security.spec.KeySpec.class) || cls.isAssignableFrom(java.security.spec.RSAPublicKeySpec.class)) && (key is java.security.interfaces.RSAPublicKey)) {
            java.security.interfaces.RSAPublicKey rSAPublicKey = (java.security.interfaces.RSAPublicKey) key;
            return new java.security.spec.RSAPublicKeySpec(rSAPublicKey.getModulus(), rSAPublicKey.getPublicExponent());
        }
        if ((cls.isAssignableFrom(java.security.spec.KeySpec.class) || cls.isAssignableFrom(java.security.spec.RSAPrivateCrtKeySpec.class)) && (key is java.security.interfaces.RSAPrivateCrtKey)) {
            java.security.interfaces.RSAPrivateCrtKey rSAPrivateCrtKey = (java.security.interfaces.RSAPrivateCrtKey) key;
            return new java.security.spec.RSAPrivateCrtKeySpec(rSAPrivateCrtKey.getModulus(), rSAPrivateCrtKey.getPublicExponent(), rSAPrivateCrtKey.getPrivateExponent(), rSAPrivateCrtKey.getPrimeP(), rSAPrivateCrtKey.getPrimeQ(), rSAPrivateCrtKey.getPrimeExponentP(), rSAPrivateCrtKey.getPrimeExponentQ(), rSAPrivateCrtKey.getCrtCoefficient());
        }
        if ((cls.isAssignableFrom(java.security.spec.KeySpec.class) || cls.isAssignableFrom(java.security.spec.RSAPrivateKeySpec.class)) && (key is java.security.interfaces.RSAPrivateKey)) {
            java.security.interfaces.RSAPrivateKey rSAPrivateKey = (java.security.interfaces.RSAPrivateKey) key;
            return new java.security.spec.RSAPrivateKeySpec(rSAPrivateKey.getModulus(), rSAPrivateKey.getPrivateExponent());
        }
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e.class) && (key is java.security.interfaces.RSAPublicKey)) {
            try {
                return new p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m092fb0ff(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39(false, ((java.security.interfaces.RSAPublicKey) key).getModulus(), ((java.security.interfaces.RSAPublicKey) key).getPublicExponent())));
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException("unable to produce encoding: " + e.getMessage());
            }
        }
        if (!cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b.class) || !(key is java.security.interfaces.RSAPrivateCrtKey)) {
            return super.engineGetKeySpec(key, cls);
        }
        try {
            return new p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc8fff9db.mf78d1be7(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(((java.security.interfaces.RSAPrivateCrtKey) key).getModulus(), ((java.security.interfaces.RSAPrivateCrtKey) key).getPublicExponent(), ((java.security.interfaces.RSAPrivateCrtKey) key).getPrivateExponent(), ((java.security.interfaces.RSAPrivateCrtKey) key).getPrimeP(), ((java.security.interfaces.RSAPrivateCrtKey) key).getPrimeQ(), ((java.security.interfaces.RSAPrivateCrtKey) key).getPrimeExponentP(), ((java.security.interfaces.RSAPrivateCrtKey) key).getPrimeExponentQ(), ((java.security.interfaces.RSAPrivateCrtKey) key).getCrtCoefficient())));
        } catch (java.io.IOException e2) {
            throw new java.lang.IllegalArgumentException("unable to produce encoding: " + e2.getMessage());
        }
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is java.security.interfaces.RSAPublicKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371((java.security.interfaces.RSAPublicKey) key);
        }
        if (key is java.security.interfaces.RSAPrivateCrtKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2baebdc5((java.security.interfaces.RSAPrivateCrtKey) key);
        }
        if (key is java.security.interfaces.RSAPrivateKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p44536675((java.security.interfaces.RSAPrivateKey) key);
        }
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((14 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (!p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.mb393402a(algorithm)) {
            throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
        }
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1.m8bab0102(p811299f8Var.parsePrivateKey());
        return p970a24b1VarM8bab0102.getCoefficient().intValue() != 0 ? new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p2baebdc5(p811299f8Var) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p44536675(p811299f8Var.getPrivateKeyAlgorithm(), p970a24b1VarM8bab0102);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((10 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.mb393402a(algorithm)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p3d891371(p3cdccfc9Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }
}

