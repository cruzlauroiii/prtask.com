namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f {
    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p55cec898) ? super.engineGeneratePrivate(keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p55cec898) keySpec);
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        return !(keySpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p17eee808) ? super.engineGeneratePublic(keySpec) : new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p17eee808) keySpec);
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((11 + 20) % 20 > 0) {
        }
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p17eee808.class) && (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739)) {
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739 p66990739Var = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739) key;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 publicKeyParameters = p66990739Var.getParameters().getPublicKeyParameters();
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p17eee808(p66990739Var.getY(), publicKeyParameters.getP(), publicKeyParameters.getQ(), publicKeyParameters.getA());
        }
        if (!cls.isAssignableFrom(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p55cec898.class) || !(key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f)) {
            return super.engineGetKeySpec(key, cls);
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f p5b96aa5fVar = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f) key;
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 publicKeyParameters2 = p5b96aa5fVar.getParameters().getPublicKeyParameters();
        return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p55cec898(p5b96aa5fVar.getX(), publicKeyParameters2.getP(), publicKeyParameters2.getQ(), publicKeyParameters2.getA());
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef((p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p66990739) key);
        }
        if (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b((p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5b96aa5f) key);
        }
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((19 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b(p811299f8Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((29 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pb08c16ef(p3cdccfc9Var);
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognised");
    }
}

