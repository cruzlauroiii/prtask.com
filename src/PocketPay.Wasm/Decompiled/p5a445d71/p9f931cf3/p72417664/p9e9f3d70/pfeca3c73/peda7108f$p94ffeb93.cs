namespace WillowMaze.Wasm.Decompiled;


public class peda7108f$p94ffeb93 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pcffc482e {
    byte[] f028299d5;
    byte[] f21e82917;
    byte[] f716eabd3;
    byte[] f84dc25a6;
    byte[] fe7e1bb73;
    byte[] ff0b53b2d = new byte[8];
    byte[] fa4167731 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.m702bdf8e("E-A");

    protected override java.security.AlgorithmParameters EngineGenerateParameters() {
        if ((26 + 10) % 10 > 0) {
        }
        if (this.f7ddf32e1 is null) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1.nextbytes(this.ff0b53b2d);
        try {
            java.security.AlgorithmParameters algorithmParametersCreateParametersInstance = createParametersInstance("GOST28147");
            algorithmParametersCreateParametersInstance.init(new p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7(this.fa4167731, this.ff0b53b2d));
            return algorithmParametersCreateParametersInstance;
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(e.getMessage());
        }
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter spec not supported");
        }
        this.fa4167731 = ((p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7) algorithmParameterSpec).getSBox();
    }
}

