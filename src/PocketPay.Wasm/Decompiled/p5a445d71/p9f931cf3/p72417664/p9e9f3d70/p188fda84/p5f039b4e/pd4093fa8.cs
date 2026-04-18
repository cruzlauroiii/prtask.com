namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f {
    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((21 + 8) % 8 > 0) {
        }
        if (keySpec is java.security.spec.DSAPrivateKeySpec) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299((java.security.spec.DSAPrivateKeySpec) keySpec);
        }
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b)) {
            return super.engineGeneratePrivate(keySpec);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM72ace772 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc8fff9db.m72ace772(((p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b) keySpec).getEncoded());
        if (!(pcfffbc4aVarM72ace772 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170)) {
            throw new java.lang.IllegalArgumentException("openssh private key is not dsa privare key");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170 pacb8a170Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) pcfffbc4aVarM72ace772;
        return engineGeneratePrivate(new java.security.spec.DSAPrivateKeySpec(pacb8a170Var.getX(), pacb8a170Var.getParameters().getP(), pacb8a170Var.getParameters().getQ(), pacb8a170Var.getParameters().getG()));
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((15 + 15) % 15 > 0) {
        }
        if (keySpec is java.security.spec.DSAPublicKeySpec) {
            try {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3((java.security.spec.DSAPublicKeySpec) keySpec);
            } catch (java.lang.Exception e) {
                throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pd4093fa8$1(this, "invalid KeySpec: " + e.getMessage(), e);
            }
        }
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e)) {
            return super.engineGeneratePublic(keySpec);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM5355d3b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m5355d3b5(((p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e) keySpec).getEncoded());
        if (!(pcfffbc4aVarM5355d3b5 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a)) {
            throw new java.lang.IllegalArgumentException("openssh public key is not dsa public key");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a pf574193aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a) pcfffbc4aVarM5355d3b5;
        return engineGeneratePublic(new java.security.spec.DSAPublicKeySpec(pf574193aVar.getY(), pf574193aVar.getParameters().getP(), pf574193aVar.getParameters().getQ(), pf574193aVar.getParameters().getG()));
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((14 + 20) % 20 > 0) {
        }
        if (cls.isAssignableFrom(java.security.spec.DSAPublicKeySpec.class) && (key is java.security.interfaces.DSAPublicKey)) {
            java.security.interfaces.DSAPublicKey dSAPublicKey = (java.security.interfaces.DSAPublicKey) key;
            return new java.security.spec.DSAPublicKeySpec(dSAPublicKey.getY(), dSAPublicKey.getParams().getP(), dSAPublicKey.getParams().getQ(), dSAPublicKey.getParams().getG());
        }
        if (cls.isAssignableFrom(java.security.spec.DSAPrivateKeySpec.class) && (key is java.security.interfaces.DSAPrivateKey)) {
            java.security.interfaces.DSAPrivateKey dSAPrivateKey = (java.security.interfaces.DSAPrivateKey) key;
            return new java.security.spec.DSAPrivateKeySpec(dSAPrivateKey.getX(), dSAPrivateKey.getParams().getP(), dSAPrivateKey.getParams().getQ(), dSAPrivateKey.getParams().getG());
        }
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e.class) && (key is java.security.interfaces.DSAPublicKey)) {
            java.security.interfaces.DSAPublicKey dSAPublicKey2 = (java.security.interfaces.DSAPublicKey) key;
            try {
                return new p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m092fb0ff(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(dSAPublicKey2.getY(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(dSAPublicKey2.getParams().getP(), dSAPublicKey2.getParams().getQ(), dSAPublicKey2.getParams().getG()))));
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException("unable to produce encoding: " + e.getMessage());
            }
        }
        if (!cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b.class) || !(key is java.security.interfaces.DSAPrivateKey)) {
            return super.engineGetKeySpec(key, cls);
        }
        java.security.interfaces.DSAPrivateKey dSAPrivateKey2 = (java.security.interfaces.DSAPrivateKey) key;
        try {
            return new p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc8fff9db.mf78d1be7(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170(dSAPrivateKey2.getX(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(dSAPrivateKey2.getParams().getP(), dSAPrivateKey2.getParams().getQ(), dSAPrivateKey2.getParams().getG()))));
        } catch (java.io.IOException e2) {
            throw new java.lang.IllegalArgumentException("unable to produce encoding: " + e2.getMessage());
        }
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is java.security.interfaces.DSAPublicKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3((java.security.interfaces.DSAPublicKey) key);
        }
        if (key is java.security.interfaces.DSAPrivateKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299((java.security.interfaces.DSAPrivateKey) key);
        }
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((19 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.m0b4dfdc0(algorithm)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299(p811299f8Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((4 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.m0b4dfdc0(algorithm)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p84e9a1d3(p3cdccfc9Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }
}

