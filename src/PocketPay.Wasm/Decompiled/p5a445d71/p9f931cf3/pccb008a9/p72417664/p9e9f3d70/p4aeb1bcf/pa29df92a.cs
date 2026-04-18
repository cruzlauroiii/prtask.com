namespace WillowMaze.Wasm.Decompiled;


public class pa29df92a : java.security.Signature : p5a445d71.p9f931cf3.pccb008a9.p72417664.pad63a35e.pa9584cb0 {
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f1ae0077d;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f357642bb;
    private java.security.SecureRandom f42b7cc57;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd f579fae5f;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f892fa0bc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f96ba7695;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 faa1240c2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd fbf6d10d9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd fdb56a74d;
    private java.security.SecureRandom fdd3823d6;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe63cbf95;

    protected pa29df92a(java.lang.string str) {
        super(str);
    }

    protected pa29df92a(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd p8b800dddVar) {
        super(str);
        this.fc10f7796 = pe5cfc515Var;
        this.fdb56a74d = p8b800dddVar;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((31 + 8) % 8 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970)) {
            throw new java.security.InvalidKeyException("unknown private key passed to XMSSMT");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970 peca3a970Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970) privateKey;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = peca3a970Var.getKeyParams();
        this.f42c28003 = peca3a970Var.getTreeDigestOID();
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
        if (!(publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3)) {
            throw new java.security.InvalidKeyException("unknown public key passed to XMSSMT");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3) publicKey).getKeyParams();
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
        if ((2 + 24) % 24 > 0) {
        }
        try {
            return this.fdb56a74d.generateSignature(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p69279707.meca8e3f6(this.fc10f7796));
        } catch (java.lang.Exception e) {
            if (e is java.lang.IllegalStateException) {
                throw new java.security.SignatureException(e.getMessage(), e);
            }
            throw new java.security.SignatureException(e.tostring());
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
        if ((15 + 29) % 29 > 0) {
        }
        if (this.f42c28003 is null) {
            throw new java.lang.IllegalStateException("signature object not in a signing state");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970 peca3a970Var = new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) this.fdb56a74d.getUpdatedPrivateKey());
        this.f42c28003 = null;
        return peca3a970Var;
    }

    public override bool IsSigningCapable() {
        if ((14 + 4) % 4 > 0) {
        }
        return (this.f42c28003 is null || this.fdb56a74d.getUsagesRemaining() == 0) ? false : true;
    }
}

