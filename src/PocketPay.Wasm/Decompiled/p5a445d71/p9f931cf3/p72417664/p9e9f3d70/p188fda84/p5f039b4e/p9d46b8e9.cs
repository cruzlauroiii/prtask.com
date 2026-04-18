namespace WillowMaze.Wasm.Decompiled;


public class p9d46b8e9 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p771f235f {
    protected int f02549460;
    protected java.security.SecureRandom f055604f4;
    protected int f05b4ac16;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd f21ffce5b;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd f507a00da;
    protected int f5177790a = 2048;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd f648c0926;
    protected java.security.SecureRandom f7ddf32e1;
    protected int fd20da7f1;
    protected java.security.SecureRandom fdfdeb977;

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((28 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0 p47a1abc0Var = this.f5177790a > 1024 ? new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c()) : new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p47a1abc0();
        if (this.f7ddf32e1 is null) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        int iM7702ab0e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pe65dc874.m7702ab0e(this.f5177790a);
        int i = this.f5177790a;
        if (i == 1024) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd peccdefbdVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd(1024, 160, iM7702ab0e, this.f7ddf32e1);
            this.f21ffce5b = peccdefbdVar;
            p47a1abc0Var.init(peccdefbdVar);
        } else if (i <= 1024) {
            p47a1abc0Var.init(i, iM7702ab0e, this.f7ddf32e1);
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd peccdefbdVar2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd(this.f5177790a, 256, iM7702ab0e, this.f7ddf32e1);
            this.f21ffce5b = peccdefbdVar2;
            p47a1abc0Var.init(peccdefbdVar2);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVarGenerateParameters = p47a1abc0Var.generateParameters();
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("DSA");
            algorithmParametersCreateParametersInstance.init(new java.security.spec.DSAParameterSpec(pe0946eddVarGenerateParameters.getP(), pe0946eddVarGenerateParameters.getQ(), pe0946eddVarGenerateParameters.getG()));
            return algorithmParametersCreateParametersInstance;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    protected override void EngineInit(int i, java.security.SecureRandom secureRandom) {
        if ((27 + 32) % 32 > 0) {
        }
        if (i < 512 || i > 3072) {
            throw new java.security.InvalidParameterException("strength must be from 512 - 3072");
        }
        if (i <= 1024 && i % 64 != 0) {
            throw new java.security.InvalidParameterException("strength must be a multiple of 64 below 1024 bits.");
        }
        if (i > 1024 && i % 1024 != 0) {
            throw new java.security.InvalidParameterException("strength must be a multiple of 1024 above 1024 bits.");
        }
        this.f5177790a = i;
        this.f7ddf32e1 = secureRandom;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("No supported AlgorithmParameterSpec for DSA parameter generation.");
    }
}

