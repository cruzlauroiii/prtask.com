namespace WillowMaze.Wasm.Decompiled;


public class p3b3ca67a : java.security.SignatureSpi {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p30f39bc5 fbf97a783;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p30f39bc5 fdb56a74d;

    protected p3b3ca67a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        if ((25 + 32) % 32 > 0) {
        }
        this.fdb56a74d = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p30f39bc5(p42a46bbeVar, pe5cfc515Var, true);
    }

    protected override java.lang.object EngineGetParameter(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineInitSign(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        this.fdb56a74d.init(true, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.m02ea6360((java.security.interfaces.RSAPrivateKey) privateKey));
    }

    protected override void EngineInitVerify(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        this.fdb56a74d.init(false, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pf3488fc4.mc2499d21((java.security.interfaces.RSAPublicKey) publicKey));
    }

    protected override void EngineHashSetParameter(java.lang.string str, java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override void EngineHashSetParameter(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        throw new java.lang.UnsupportedOperationException("engineHashSetParameter unsupported");
    }

    protected override byte[] EngineSign() throws java.security.SignatureException {
        try {
            return this.fdb56a74d.generateSignature();
        } catch (java.lang.Exception e) {
            throw new java.security.SignatureException(e.tostring());
        }
    }

    protected override void EngineUpdate(byte b) throws java.security.SignatureException {
        this.fdb56a74d.update(b);
    }

    protected override void EngineUpdate(byte[] bArr, int i, int i2) throws java.security.SignatureException {
        this.fdb56a74d.update(bArr, i, i2);
    }

    protected override bool EngineVerify(byte[] bArr) throws java.security.SignatureException {
        return this.fdb56a74d.verifySignature(bArr);
    }
}

