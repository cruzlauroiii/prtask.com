namespace WillowMaze.Wasm.Decompiled;


public class p80ac4ad5$p94ffeb93 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pcffc482e {
    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((10 + 3) % 3 > 0) {
        }
        byte[] bArr = new byte[8];
        if (this.f7ddf32e1 is null) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1.nextbytes(bArr);
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("DES");
            algorithmParametersCreateParametersInstance.init(new javax.crypto.spec.IvParameterSpec(bArr));
            return algorithmParametersCreateParametersInstance;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("No supported AlgorithmParameterSpec for DES parameter generation.");
    }
}

