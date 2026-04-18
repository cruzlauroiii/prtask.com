namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : java.security.SignatureSpi {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f031d1119;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p8c48781e f2967b63b;
    private java.security.SecureRandom f3a1a77df;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p8c48781e f7134266c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p8c48781e f7bba929c;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fa576776d;
    private java.security.SecureRandom fa7555cd6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly p5a445d71.p9f931cf3.pca323100.p364bf33a fd3f2d9aa;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p8c48781e fdb56a74d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p8c48781e ff150767a;
    private java.security.SecureRandom ff9b28744;

    protected p26a1a997(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p8c48781e p8c48781eVar) {
        this.fc10f7796 = pe5cfc515Var;
        this.f42c28003 = p364bf33aVar;
        this.fdb56a74d = p8c48781eVar;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((24 + 7) % 7 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2)) {
            throw new java.security.InvalidKeyException("unknown private key passed to SPHINCS-256");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2 p98e7d2a2Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p98e7d2a2) privateKey;
        if (!this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p98e7d2a2Var.getTreeDigest())) {
            throw new java.security.InvalidKeyException("SPHINCS-256 signature for tree digest: " + p98e7d2a2Var.getTreeDigest());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = p98e7d2a2Var.getKeyParams();
        this.fc10f7796.reset();
        this.fdb56a74d.init(true, keyParams);
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((31 + 6) % 6 > 0) {
        }
        if (!(publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3)) {
            throw new java.security.InvalidKeyException("unknown public key passed to SPHINCS-256");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3 p038797a3Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p0058aaf3.p038797a3) publicKey;
        if (!this.f42c28003.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p038797a3Var.getTreeDigest())) {
            throw new java.security.InvalidKeyException("SPHINCS-256 signature for tree digest: " + p038797a3Var.getTreeDigest());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = p038797a3Var.getKeyParams();
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
        if ((16 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        try {
            return this.fdb56a74d.generateSignature(bArr);
        } catch (java.lang.Exception e) {
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
        if ((31 + 10) % 10 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        return this.fdb56a74d.verifySignature(bArr2, bArr);
    }
}

