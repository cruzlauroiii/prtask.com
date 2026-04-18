namespace WillowMaze.Wasm.Decompiled;


public class p9d46b8e9 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p771f235f {
    protected int f3cd96c3b;
    protected int f3e458a5b;
    protected java.security.SecureRandom f485292be;
    protected int f5177790a = 1024;
    protected int f7528b0b5;
    protected int f77169ba2;
    protected java.security.SecureRandom f7ddf32e1;
    protected java.security.SecureRandom f885af784;
    protected java.security.SecureRandom feae8a893;
    protected java.security.SecureRandom ffc81b038;

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((13 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p21247682 p21247682Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p21247682();
        java.security.SecureRandom secureRandom = this.f7ddf32e1;
        if (secureRandom is null) {
            p21247682Var.init(this.f5177790a, 2, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
        } else {
            p21247682Var.init(this.f5177790a, 2, secureRandom);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05VarGenerateParameters = p21247682Var.generateParameters();
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("GOST3410");
            algorithmParametersCreateParametersInstance.init(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d(new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417(p9c4e2d05VarGenerateParameters.getP(), p9c4e2d05VarGenerateParameters.getQ(), p9c4e2d05VarGenerateParameters.getA())));
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
        throw new java.security.InvalidAlgorithmParameterException("No supported AlgorithmParameterSpec for GOST3410 parameter generation.");
    }
}

