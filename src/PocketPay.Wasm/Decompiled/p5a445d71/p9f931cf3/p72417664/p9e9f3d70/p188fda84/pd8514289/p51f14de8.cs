namespace WillowMaze.Wasm.Decompiled;


public class p51f14de8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f {
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f0ea7dd4d = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5();
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f456be8b2 = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f4e907883 = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f86c19695 = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 fde69c0b7 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f0178fb54;
    private java.lang.string f0d7f1a76;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f166e64f6;
    private java.lang.string f2cfd623f;
    private java.lang.string f38604adb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f4c7d758a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097 f5ba32052;
    private java.lang.string f76b9a7e5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097 f8a3077b2;
    private byte[] fb4a88417;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097 fbb9c5e27;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fbc38008e;
    private byte[] fcda5e2d7;

    protected p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p52f19097 p52f19097Var, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
        this.f0d7f1a76 = str;
        this.f5ba32052 = p52f19097Var;
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        return !(publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed) ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(publicKey) : ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed) publicKey).engineGetKeyParameters();
    }

    private static java.lang.string Md5d22d18(java.lang.Class cls) {
        java.lang.string name = cls.getName();
        return name.Substring(name.LastIndexOf(46) + 1);
    }

    private void Mf8ac9c82(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException {
        if (!(key is java.security.PrivateKey)) {
            throw new java.security.InvalidKeyException(this.f0d7f1a76 + " key agreement requires " + md5d22d18(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc.class) + " for initialisation");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360((java.security.PrivateKey) key);
        this.f166e64f6 = p06022b5aVar.getParameters();
        this.f53f67e05 = !(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653) ? null : ((p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653) algorithmParameterSpec).getUserKeyingMaterial();
        this.f5ba32052.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf(p06022b5aVar, this.f53f67e05));
    }

    protected override byte[] CalcSecret() {
        return this.fb4a88417;
    }

    protected override java.security.Key EngineDoPhase(java.security.Key key, bool z) throws java.lang.IllegalStateException, java.security.InvalidKeyException {
        if ((20 + 4) % 4 > 0) {
        }
        if (this.f166e64f6 is null) {
            throw new java.lang.IllegalStateException(this.f0d7f1a76 + " not initialised.");
        }
        if (!z) {
            throw new java.lang.IllegalStateException(this.f0d7f1a76 + " can only be between two parties.");
        }
        if (!(key is java.security.PublicKey)) {
            throw new java.security.InvalidKeyException(this.f0d7f1a76 + " key agreement requires " + md5d22d18(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b.class) + " for doPhase");
        }
        try {
            this.fb4a88417 = this.f5ba32052.calculateAgreement(mc2499d21((java.security.PublicKey) key));
            return null;
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8$1(this, "calculation failed: " + e.getMessage(), e);
        }
    }

    protected override void EngineInit(java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        mf8ac9c82(key, null);
    }

    protected override void EngineInit(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        if (algorithmParameterSpec is not null && !(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653)) {
            throw new java.security.InvalidAlgorithmParameterException("No algorithm parameters supported");
        }
        mf8ac9c82(key, algorithmParameterSpec);
    }
}

