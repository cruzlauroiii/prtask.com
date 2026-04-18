namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b f27d41756;
    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b f4b72aa8d;
    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b f749bcd8a;
    java.lang.string f836bd14d;
    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fccd10663;
    java.lang.string fdf62d83a;
    java.lang.string fed469618;
    java.lang.string ff1bac62e;

    pd4093fa8(java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = str;
        this.fccd10663 = pfe41e66bVar;
    }

    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((11 + 16) % 16 > 0) {
        }
        if (keySpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e) keySpec, this.fccd10663);
        }
        if (keySpec is java.security.spec.ECPrivateKeySpec) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, (java.security.spec.ECPrivateKeySpec) keySpec, this.fccd10663);
        }
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b)) {
            return super.engineGeneratePrivate(keySpec);
        }
        p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(((p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b) keySpec).getEncoded());
        try {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p5eff85bcVarM8bab0102.getParametersobject()), p5eff85bcVarM8bab0102), this.fccd10663);
        } catch (java.io.IOException e) {
            throw new java.security.spec.InvalidKeySpecException("bad encoding: " + e.getMessage());
        }
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((13 + 12) % 12 > 0) {
        }
        try {
            if (keySpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1(this.fed469618, (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1) keySpec, this.fccd10663);
            }
            if (keySpec is java.security.spec.ECPublicKeySpec) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1(this.fed469618, (java.security.spec.ECPublicKeySpec) keySpec, this.fccd10663);
            }
            if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e)) {
                return super.engineGeneratePublic(keySpec);
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM5355d3b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m5355d3b5(((p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e) keySpec).getEncoded());
            if (!(pcfffbc4aVarM5355d3b5 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e)) {
                throw new java.lang.IllegalArgumentException("openssh key is not ec public key");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pcfffbc4aVarM5355d3b5).getParameters();
            return engineGeneratePublic(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pcfffbc4aVarM5355d3b5).getQ(), new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581(parameters.getCurve(), parameters.getG(), parameters.getN(), parameters.getH(), parameters.getSeed())));
        } catch (java.lang.Exception e) {
            throw new java.security.spec.InvalidKeySpecException("invalid KeySpec: " + e.getMessage(), e);
        }
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((28 + 7) % 7 > 0) {
        }
        if ((cls.isAssignableFrom(java.security.spec.KeySpec.class) || cls.isAssignableFrom(java.security.spec.ECPublicKeySpec.class)) && (key is java.security.interfaces.ECPublicKey)) {
            java.security.interfaces.ECPublicKey eCPublicKey = (java.security.interfaces.ECPublicKey) key;
            if (eCPublicKey.getParams() is not null) {
                return new java.security.spec.ECPublicKeySpec(eCPublicKey.getW(), eCPublicKey.getParams());
            }
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa();
            return new java.security.spec.ECPublicKeySpec(eCPublicKey.getW(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getSeed()), ecImplicitlyCa));
        }
        if ((cls.isAssignableFrom(java.security.spec.KeySpec.class) || cls.isAssignableFrom(java.security.spec.ECPrivateKeySpec.class)) && (key is java.security.interfaces.ECPrivateKey)) {
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
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e.class) && (key is java.security.interfaces.ECPrivateKey)) {
            java.security.interfaces.ECPrivateKey eCPrivateKey2 = (java.security.interfaces.ECPrivateKey) key;
            if (eCPrivateKey2.getParams() is not null) {
                return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e(eCPrivateKey2.getS(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCPrivateKey2.getParams()));
            }
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e(eCPrivateKey2.getS(), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa());
        }
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e.class) && (key is java.security.interfaces.ECPublicKey)) {
            if (!(key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1)) {
                throw new java.lang.IllegalArgumentException("invalid key type: " + key.GetType().getName());
            }
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1) key;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 parameters = p3ecd70d1Var.getParameters();
            try {
                return new p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m092fb0ff(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p3ecd70d1Var.getQ(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(parameters.getCurve(), parameters.getG(), parameters.getN(), parameters.getH(), parameters.getSeed()))));
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException("unable to produce encoding: " + e.getMessage());
            }
        }
        if (!cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b.class) || !(key is java.security.interfaces.ECPrivateKey)) {
            return super.engineGetKeySpec(key, cls);
        }
        if (!(key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec)) {
            throw new java.lang.IllegalArgumentException("invalid key type: " + key.GetType().getName());
        }
        try {
            return new p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(key.getEncoded()).parsePrivateKey().toASN1Primitive().getEncoded());
        } catch (java.io.IOException e2) {
            throw new java.lang.IllegalArgumentException("cannot encoded key: " + e2.getMessage());
        }
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is java.security.interfaces.ECPublicKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1((java.security.interfaces.ECPublicKey) key, this.fccd10663);
        }
        if (key is java.security.interfaces.ECPrivateKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec((java.security.interfaces.ECPrivateKey) key, this.fccd10663);
        }
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((9 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec(this.fed469618, p811299f8Var, this.fccd10663);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((15 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1(this.fed469618, p3cdccfc9Var, this.fccd10663);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }
}

