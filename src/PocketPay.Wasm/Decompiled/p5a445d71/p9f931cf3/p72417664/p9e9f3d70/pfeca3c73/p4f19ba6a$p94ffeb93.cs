namespace WillowMaze.Wasm.Decompiled;


public class p4f19ba6a$p94ffeb93 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pcffc482e {
    private readonly int f04840335;
    private readonly int f47e838e0;
    private readonly int f662f6839;
    private readonly int f7e425fd7;
    private readonly int fa94f8c7b;

    public p4f19ba6a$p94ffeb93(int i) {
        this.f47e838e0 = i / 8;
    }

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((24 + 17) % 17 > 0) {
        }
        byte[] bArr = new byte[this.f47e838e0];
        if (this.f7ddf32e1 is null) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1.nextbytes(bArr);
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("DSTU7624");
            algorithmParametersCreateParametersInstance.init(new javax.crypto.spec.IvParameterSpec(bArr));
            return algorithmParametersCreateParametersInstance;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("No supported AlgorithmParameterSpec for DSTU7624 parameter generation.");
    }
}

