namespace WillowMaze.Wasm.Decompiled;


public class p9d46b8e9 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p771f235f {
    private int f0542bf18;
    protected java.security.SecureRandom f7ddf32e1;
    private int f91e4601f;
    private int fb1fe8111;
    protected java.security.SecureRandom fcaafbf82;
    protected java.security.SecureRandom fd073226c;
    protected int fe09bc6fa;
    protected int f5177790a = 1024;
    private int f2db95e8e = 0;

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((14 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pb68cb209 pb68cb209Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pb68cb209();
        java.security.SecureRandom secureRandom = this.f7ddf32e1;
        if (secureRandom is null) {
            pb68cb209Var.init(this.f5177790a, 20, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
        } else {
            pb68cb209Var.init(this.f5177790a, 20, secureRandom);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073VarGenerateParameters = pb68cb209Var.generateParameters();
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("ElGamal");
            algorithmParametersCreateParametersInstance.init(new javax.crypto.spec.DHParameterSpec(p85d5a073VarGenerateParameters.getP(), p85d5a073VarGenerateParameters.getG(), this.f2db95e8e));
            return algorithmParametersCreateParametersInstance;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    protected override void EngineInit(int i, java.security.SecureRandom secureRandom) {
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if (!(algorithmParameterSpec is javax.crypto.spec.DHGenParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException("DH parameter generator requires a DHGenParameterSpec for initialisation");
        }
        javax.crypto.spec.DHGenParameterSpec dHGenParameterSpec = (javax.crypto.spec.DHGenParameterSpec) algorithmParameterSpec;
        this.f5177790a = dHGenParameterSpec.getPrimeSize();
        this.f2db95e8e = dHGenParameterSpec.getExponentSize();
        this.f7ddf32e1 = secureRandom;
    }
}

