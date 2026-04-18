namespace WillowMaze.Wasm.Decompiled;


public class pb631a1de : java.security.SignatureSpi {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97 f167319e0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97 f7c2c00fc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97 fdb56a74d;

    protected pb631a1de(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.fdb56a74d = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97(p42a46bbeVar, pe5cfc515Var);
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

