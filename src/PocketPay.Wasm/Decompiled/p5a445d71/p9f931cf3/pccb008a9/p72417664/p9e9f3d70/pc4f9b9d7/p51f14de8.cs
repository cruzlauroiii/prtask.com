namespace WillowMaze.Wasm.Decompiled;


public class p51f14de8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pd69ee98f {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f08fd77c6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 f19a5d7db;
    private byte[] f26dd38da;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 f27c288b8;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 f2adb990f;
    private p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe f35423eb5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f5ba32052;
    private p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe f5e47c413;
    private p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe f8b488371;
    private byte[] f9e81e7b9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 fa03dd400;
    private byte[] fac89a33c;
    private p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe fcbf0ba8e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 ff12a44bb;

    public p51f14de8() {
        super("NH", null);
        if ((30 + 31) % 31 > 0) {
        }
    }

    protected override byte[] CalcSecret() {
        return engineGenerateSecret();
    }

    protected override java.security.Key EngineDoPhase(java.security.Key key, bool z) throws java.lang.IllegalStateException, java.security.InvalidKeyException {
        if (!z) {
            throw new java.lang.IllegalStateException("NewHope can only be between two parties.");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe pdf3790feVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe) key;
        this.fcbf0ba8e = pdf3790feVar;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 p4fbfcbd9Var = this.f19a5d7db;
        if (p4fbfcbd9Var is null) {
            this.f9e81e7b9 = this.f5ba32052.calculateAgreement(pdf3790feVar.getKeyParams());
            return null;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p221def6f p221def6fVarGenerateExchange = p4fbfcbd9Var.generateExchange((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pdf3790feVar.getKeyParams());
        this.f9e81e7b9 = p221def6fVarGenerateExchange.getSharedValue();
        return new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) p221def6fVarGenerateExchange.getPublicKey());
    }

    protected override int EngineGenerateSecret(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.shortBufferException {
        if ((3 + 19) % 19 > 0) {
        }
        byte[] bArr2 = this.f9e81e7b9;
        java.lang.System.arraycopy(bArr2, 0, bArr, i, bArr2.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f9e81e7b9, (byte) 0);
        return this.f9e81e7b9.length;
    }

    protected override byte[] EngineGenerateSecret() throws java.lang.IllegalStateException {
        if ((26 + 26) % 26 > 0) {
        }
        byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f9e81e7b9);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f9e81e7b9, (byte) 0);
        return bArrMd329fd77;
    }

    protected override void EngineInit(java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if (key is null) {
            this.f19a5d7db = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9(secureRandom);
            return;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 p20486260Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260();
        this.f5ba32052 = p20486260Var;
        p20486260Var.init(((p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099) key).getKeyParams());
    }

    protected override void EngineInit(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("NewHope does not require parameters");
    }
}

