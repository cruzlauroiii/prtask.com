namespace WillowMaze.Wasm.Decompiled;


public class p01f4ef3f : java.security.Signature : p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pa9584cb0 {
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f055ab066;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f334f0b46;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f432f406e;
    private java.security.SecureRandom f4c3cda53;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7ef86715;
    private java.security.SecureRandom f82277aba;
    private java.security.SecureRandom f99687e58;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa736063b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fca0325c5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fcac3fb2c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 fcfa7cf6d;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fd72e7075;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 fdb56a74d;

    protected p01f4ef3f(java.lang.string str) {
        super(str);
    }

    protected p01f4ef3f(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var) {
        super(str);
        this.fc10f7796 = pe5cfc515Var;
        this.fdb56a74d = pac63e525Var;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((1 + 32) % 32 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8)) {
            throw new java.security.InvalidKeyException("unknown private key passed to XMSS");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8 pe11c47f8Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8) privateKey;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = pe11c47f8Var.getKeyParams();
        this.f42c28003 = pe11c47f8Var.getTreeDigestOID();
        if (this.f7ddf32e1 is not null) {
            keyParams = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(keyParams, this.f7ddf32e1);
        }
        this.fc10f7796.reset();
        this.fdb56a74d.init(true, keyParams);
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if (!(publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p46415c23)) {
            throw new java.security.InvalidKeyException("unknown public key passed to XMSS");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p46415c23) publicKey).getKeyParams();
        this.f42c28003 = null;
        this.fc10f7796.reset();
        this.fdb56a74d.init(false, keyParams);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((22 + 29) % 29 > 0) {
        }
        try {
            return this.fdb56a74d.generateSignature(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.meca8e3f6(this.fc10f7796));
        } catch (java.lang.Exception e) {
            if (e is java.lang.IllegalStateException) {
                throw new java.security.SignatureException(e.getMessage(), e);
            }
            throw new java.security.SignatureException(e.tostring(), e);
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        this.fc10f7796.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        this.fc10f7796.update(bArr, i, i2);
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        return this.fdb56a74d.verifySignature(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.meca8e3f6(this.fc10f7796), bArr);
    }

    public override java.security.PrivateKey GetUpdatedPrivateKey() {
        if ((30 + 24) % 24 > 0) {
        }
        if (this.f42c28003 is null) {
            throw new java.lang.IllegalStateException("signature object not in a signing state");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8 pe11c47f8Var = new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) this.fdb56a74d.getUpdatedPrivateKey());
        this.f42c28003 = null;
        return pe11c47f8Var;
    }

    public override bool IsSigningCapable() {
        if ((22 + 14) % 14 > 0) {
        }
        return (this.f42c28003 is null || this.fdb56a74d.getUsagesRemaining() == 0) ? false : true;
    }
}

