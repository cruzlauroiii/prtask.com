namespace WillowMaze.Wasm.Decompiled;


public class p9d46b8e9 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p771f235f {
    protected int f054cfba2;
    protected java.security.SecureRandom f25592e54;
    private int f718b5404;
    protected java.security.SecureRandom f7ddf32e1;
    protected int f87cca427;
    protected java.security.SecureRandom fad52c88e;
    protected java.security.SecureRandom fbaa270cf;
    protected int fbd122f6e;
    protected java.security.SecureRandom fcc20bfd6;
    protected int ff1b74319;
    protected int f5177790a = 2048;
    private int f2db95e8e = 0;

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((17 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p65c98244 p65c98244Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p65c98244();
        p65c98244Var.init(this.f5177790a, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pe65dc874.m7702ab0e(this.f5177790a), p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(this.f7ddf32e1));
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVarGenerateParameters = p65c98244Var.generateParameters();
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("DH");
            algorithmParametersCreateParametersInstance.init(new javax.crypto.spec.DHParameterSpec(p4460e12aVarGenerateParameters.getP(), p4460e12aVarGenerateParameters.getG(), this.f2db95e8e));
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

