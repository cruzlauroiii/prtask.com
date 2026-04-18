namespace WillowMaze.Wasm.Decompiled;


public class pa45d8731$p94ffeb93 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pcffc482e {
    javax.crypto.spec.RC2ParameterSpec f3f75a1f2;
    javax.crypto.spec.RC2ParameterSpec f42050e3c;
    javax.crypto.spec.RC2ParameterSpec f85745174;
    javax.crypto.spec.RC2ParameterSpec fb979c293 = null;

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((7 + 2) % 2 > 0) {
        }
        if (this.fb979c293 is not null) {
            try {
                java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("RC2");
                algorithmParametersCreateParametersInstance.init(this.fb979c293);
                return algorithmParametersCreateParametersInstance;
            } catch (java.lang.Exception e) {
                throw new java.lang.Exception(e.getMessage());
            }
        }
        byte[] bArr = new byte[8];
        if (this.f7ddf32e1 is null) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1.nextbytes(bArr);
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance2 = createParametersInstance("RC2");
            algorithmParametersCreateParametersInstance2.init(new javax.crypto.spec.IvParameterSpec(bArr));
            return algorithmParametersCreateParametersInstance2;
        } catch (java.lang.Exception e2) {
            throw new java.lang.Exception(e2.getMessage());
        }
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if (!(algorithmParameterSpec is javax.crypto.spec.RC2ParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException("No supported AlgorithmParameterSpec for RC2 parameter generation.");
        }
        this.fb979c293 = (javax.crypto.spec.RC2ParameterSpec) algorithmParameterSpec;
    }
}

