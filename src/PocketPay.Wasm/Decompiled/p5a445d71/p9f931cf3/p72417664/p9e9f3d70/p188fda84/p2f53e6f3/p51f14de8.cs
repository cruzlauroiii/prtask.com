namespace WillowMaze.Wasm.Decompiled;


public class p51f14de8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f {
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f0ea7dd4d = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5();
    private static readonly p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f6cc7525e = null;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c f06bb221f;
    private java.lang.string f0d7f1a76;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 f0e27a1c7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f166e64f6;
    private java.lang.string f1c000f6d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f1d0e1f50;
    private java.lang.string f30687734;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 f4b7424a7;
    private byte[] f5503797e;
    private java.lang.object f5b706024;
    private java.lang.object f5ba32052;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f6735ce2f;
    private java.lang.string f69b976fc;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 f7629e0bd;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c f79abb6e9;
    private byte[] f82a57be3;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 f88f03c21;
    private java.lang.string fa91d8525;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fb2fe4b9b;
    private byte[] fb4a88417;
    private byte[] ff38377f3;
    private p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 ff6679e3a;

    protected p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 p38d4f313Var, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
        this.f0d7f1a76 = str;
        this.f5ba32052 = p38d4f313Var;
    }

    protected p51f14de8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pc80df932 pc80df932Var, p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 p07d32999Var) {
        super(str, p07d32999Var);
        this.f0d7f1a76 = str;
        this.f5ba32052 = pc80df932Var;
    }

    private static java.lang.string Md5d22d18(java.lang.Class cls) {
        java.lang.string name = cls.getName();
        return name.Substring(name.LastIndexOf(46) + 1);
    }

    private void Mf8ac9c82(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2;
        if ((29 + 2) % 2 > 0) {
        }
        java.lang.object obj = this.f5ba32052;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = null;
        if (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p1392b929) {
            this.ff6679e3a = null;
            bool z = key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p8ed53a64;
            if (!z && !(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7)) {
                throw new java.security.InvalidAlgorithmParameterException(this.f0d7f1a76 + " key agreement requires " + md5d22d18(p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7.class) + " for initialisation");
            }
            if (z) {
                p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p8ed53a64 p8ed53a64Var = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p8ed53a64) key;
                p06022b5aVar2 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(p8ed53a64Var.getStaticPrivateKey());
                p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(p8ed53a64Var.getEphemeralPrivateKey());
                if (p8ed53a64Var.getEphemeralPublicKey() is not null) {
                    pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(p8ed53a64Var.getEphemeralPublicKey());
                }
            } else {
                p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7 pc2763cb7Var = (p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7) algorithmParameterSpec;
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar3 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360((java.security.PrivateKey) key);
                p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(pc2763cb7Var.getEphemeralPrivateKey());
                pd16c2d8eVar = pc2763cb7Var.getEphemeralPublicKey() is not null ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(pc2763cb7Var.getEphemeralPublicKey()) : null;
                this.ff6679e3a = pc2763cb7Var;
                this.f53f67e05 = pc2763cb7Var.getUserKeyingMaterial();
                p06022b5aVar2 = p06022b5aVar3;
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f p35bf205fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p35bf205f(p06022b5aVar2, p06022b5aVar, pd16c2d8eVar);
            this.f166e64f6 = p06022b5aVar2.getParameters();
            ((p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p1392b929) this.f5ba32052).init(p35bf205fVar);
            return;
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c)) {
            if (!(key is java.security.PrivateKey)) {
                throw new java.security.InvalidKeyException(this.f0d7f1a76 + " key agreement requires " + md5d22d18(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc.class) + " for initialisation");
            }
            if (this.f168e7cba is null && (algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653)) {
                throw new java.security.InvalidAlgorithmParameterException("no KDF specified for UserKeyingMaterialSpec");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar4 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360((java.security.PrivateKey) key);
            this.f166e64f6 = p06022b5aVar4.getParameters();
            this.f53f67e05 = algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653 ? ((p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653) algorithmParameterSpec).getUserKeyingMaterial() : null;
            ((p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313) this.f5ba32052).init(p06022b5aVar4);
            return;
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pc80df932)) {
            throw new java.security.InvalidAlgorithmParameterException(this.f0d7f1a76 + " key agreement cannot be used with " + md5d22d18(p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c.class));
        }
        p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c p73c5877cVar = (p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c) algorithmParameterSpec;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar5 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360((java.security.PrivateKey) key);
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar6 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m02ea6360(p73c5877cVar.getEphemeralPrivateKey());
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar2 = p73c5877cVar.getEphemeralPublicKey() is not null ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(p73c5877cVar.getEphemeralPublicKey()) : null;
        this.f06bb221f = p73c5877cVar;
        this.f53f67e05 = p73c5877cVar.getUserKeyingMaterial();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155 p31cf7155Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p31cf7155(p06022b5aVar5, p06022b5aVar6, pd16c2d8eVar2);
        this.f166e64f6 = p06022b5aVar5.getParameters();
        ((p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pc80df932) this.f5ba32052).init(p31cf7155Var);
    }

    protected byte[] BigIntTobytes(java.math.Bigint bigint) {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 pb79a74f5Var = f0ea7dd4d;
        return pb79a74f5Var.integerTobytes(bigint, pb79a74f5Var.getbyteLength(this.f166e64f6.getCurve()));
    }

    protected override byte[] CalcSecret() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fb4a88417);
    }

    protected override java.security.Key EngineDoPhase(java.security.Key key, bool z) throws java.lang.IllegalStateException, java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarMc2499d21;
        if ((16 + 25) % 25 > 0) {
        }
        if (this.f166e64f6 is null) {
            throw new java.lang.IllegalStateException(this.f0d7f1a76 + " not initialised.");
        }
        if (!z) {
            throw new java.lang.IllegalStateException(this.f0d7f1a76 + " can only be between two parties.");
        }
        java.lang.object obj = this.f5ba32052;
        if (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p1392b929) {
            if (key is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p25aad3f1) {
                p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p25aad3f1 p25aad3f1Var = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p25aad3f1) key;
                pc9ef6b45VarMc2499d21 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p53ca1f6a((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(p25aad3f1Var.getStaticKey()), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(p25aad3f1Var.getEphemeralKey()));
            } else {
                pc9ef6b45VarMc2499d21 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p53ca1f6a((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21((java.security.PublicKey) key), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(this.ff6679e3a.getOtherPartyEphemeralKey()));
            }
        } else if (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pc80df932) {
            pc9ef6b45VarMc2499d21 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf2905035((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21((java.security.PublicKey) key), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21(this.f06bb221f.getOtherPartyEphemeralKey()));
        } else {
            if (!(key is java.security.PublicKey)) {
                throw new java.security.InvalidKeyException(this.f0d7f1a76 + " key agreement requires " + md5d22d18(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b.class) + " for doPhase");
            }
            pc9ef6b45VarMc2499d21 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.mc2499d21((java.security.PublicKey) key);
        }
        try {
            java.lang.object obj2 = this.f5ba32052;
            if (obj2 is p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313) {
                this.fb4a88417 = bigIntTobytes(((p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313) obj2).calculateAgreement(pc9ef6b45VarMc2499d21));
                return null;
            }
            this.fb4a88417 = ((p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.pc80df932) obj2).calculateAgreement(pc9ef6b45VarMc2499d21);
            return null;
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p51f14de8$1(this, "calculation failed: " + e.getMessage(), e);
        }
    }

    protected override void EngineInit(java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        try {
            mf8ac9c82(key, null);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.security.InvalidKeyException(e.getMessage());
        }
    }

    protected override void EngineInit(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        if (algorithmParameterSpec is not null && !(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc2763cb7) && !(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p2b44c653) && !(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p73c5877c)) {
            throw new java.security.InvalidAlgorithmParameterException("No algorithm parameters supported");
        }
        mf8ac9c82(key, algorithmParameterSpec);
    }
}

