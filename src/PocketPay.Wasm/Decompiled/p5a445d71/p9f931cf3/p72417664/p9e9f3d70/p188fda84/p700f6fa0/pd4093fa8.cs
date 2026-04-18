namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f {
    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is javax.crypto.spec.DHPrivateKeySpec) ? super.engineGeneratePrivate(keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e((javax.crypto.spec.DHPrivateKeySpec) keySpec);
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if (!(keySpec is javax.crypto.spec.DHPublicKeySpec)) {
            return super.engineGeneratePublic(keySpec);
        }
        try {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34((javax.crypto.spec.DHPublicKeySpec) keySpec);
        } catch (java.lang.IllegalArgumentException e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p6be59720(e.getMessage(), e);
        }
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if (cls.isAssignableFrom(javax.crypto.spec.DHPrivateKeySpec.class) && (key is javax.crypto.interfaces.DHPrivateKey)) {
            javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) key;
            return new javax.crypto.spec.DHPrivateKeySpec(dHPrivateKey.getX(), dHPrivateKey.getParams().getP(), dHPrivateKey.getParams().getG());
        }
        if (!cls.isAssignableFrom(javax.crypto.spec.DHPublicKeySpec.class) || !(key is javax.crypto.interfaces.DHPublicKey)) {
            return super.engineGetKeySpec(key, cls);
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) key;
        return new javax.crypto.spec.DHPublicKeySpec(dHPublicKey.getY(), dHPublicKey.getParams().getP(), dHPublicKey.getParams().getG());
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is javax.crypto.interfaces.DHPublicKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34((javax.crypto.interfaces.DHPublicKey) key);
        }
        if (key is javax.crypto.interfaces.DHPrivateKey) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e((javax.crypto.interfaces.DHPrivateKey) key);
        }
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((11 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da) && !algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0)) {
            throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
        }
        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p57bb5d9e(p811299f8Var);
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((12 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da) && !algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0)) {
            throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
        }
        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34(p3cdccfc9Var);
    }
}

