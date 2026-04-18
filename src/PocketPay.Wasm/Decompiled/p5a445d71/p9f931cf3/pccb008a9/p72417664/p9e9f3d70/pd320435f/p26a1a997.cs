namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : java.security.Signature {
    private java.security.SecureRandom f3a330e60;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f48f2ba7e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p21c106e2 f793621f7;
    private java.security.SecureRandom f7a5d3577;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p21c106e2 f967345d0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fbc26e92c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private java.security.SecureRandom fd925e07e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p21c106e2 fdb56a74d;
    private java.security.SecureRandom ffff56050;

    protected p26a1a997(java.lang.string str) {
        super(str);
    }

    protected p26a1a997(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p21c106e2 p21c106e2Var) {
        super(str);
        this.fc10f7796 = pe5cfc515Var;
        this.fdb56a74d = p21c106e2Var;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((25 + 3) % 3 > 0) {
        }
        if (!(privateKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d)) {
            throw new java.security.InvalidKeyException("unknown private key passed to qTESLA");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p2f864b5d) privateKey).getKeyParams();
        if (this.f7ddf32e1 is not null) {
            keyParams = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(keyParams, this.f7ddf32e1);
        }
        this.fdb56a74d.init(true, keyParams);
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if (!(publicKey is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52)) {
            throw new java.security.InvalidKeyException("unknown public key passed to qTESLA");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 keyParams = ((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.pa074df52) publicKey).getKeyParams();
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
        try {
            return this.fdb56a74d.generateSignature(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p69279707.meca8e3f6(this.fc10f7796));
        } catch (java.lang.Exception e) {
            if (e is java.lang.IllegalStateException) {
                throw new java.security.SignatureException(e.getMessage());
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
        return this.fdb56a74d.verifySignature(p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pd320435f.p69279707.meca8e3f6(this.fc10f7796), bArr);
    }
}

