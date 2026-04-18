namespace WillowMaze.Wasm.Decompiled;


public class p76b75934$p753094a7 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pcffc482e {
    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((17 + 17) % 17 > 0) {
        }
        byte[] bArr = new byte[12];
        if (this.f7ddf32e1 is null) {
            this.f7ddf32e1 = new java.security.SecureRandom();
        }
        this.f7ddf32e1.nextbytes(bArr);
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("GCM");
            algorithmParametersCreateParametersInstance.init(new p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3(bArr, 16).getEncoded());
            return algorithmParametersCreateParametersInstance;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("No supported AlgorithmParameterSpec for AES parameter generation.");
    }
}

