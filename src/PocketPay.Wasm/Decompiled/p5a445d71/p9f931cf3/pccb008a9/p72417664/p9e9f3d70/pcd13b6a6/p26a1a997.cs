namespace WillowMaze.Wasm.Decompiled;


public class p26a1a997 : java.security.SignatureSpi {
    private java.security.SecureRandom f0f2950bb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f15932261;
    private java.security.SecureRandom f3f0de32d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f46d71033;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f f5291674e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6c7f0ab1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f f706f16a6;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f f9e4fdf9b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f fdb56a74d;

    protected p26a1a997(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f p3935a66fVar) {
        this.fc10f7796 = pe5cfc515Var;
        this.fdb56a74d = p3935a66fVar;
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((13 + 28) % 28 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM02ea6360 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p5cb06cc5.m02ea6360(privateKey);
        if (this.f7ddf32e1 is not null) {
            pc9ef6b45VarM02ea6360 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007(pc9ef6b45VarM02ea6360, this.f7ddf32e1);
        }
        this.fc10f7796.reset();
        this.fdb56a74d.init(true, pc9ef6b45VarM02ea6360);
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        this.f7ddf32e1 = secureRandom;
        engineInitSign(privateKey);
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarMc2499d21 = p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pcd13b6a6.p5cb06cc5.mc2499d21(publicKey);
        this.fc10f7796.reset();
        this.fdb56a74d.init(false, pcfffbc4aVarMc2499d21);
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        if ((15 + 16) % 16 > 0) {
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
        if ((7 + 25) % 25 > 0) {
        }
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr2, 0);
        return this.fdb56a74d.verifySignature(bArr2, bArr);
    }
}

