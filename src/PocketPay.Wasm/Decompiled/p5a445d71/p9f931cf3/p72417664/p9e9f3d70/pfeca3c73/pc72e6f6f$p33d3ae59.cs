namespace WillowMaze.Wasm.Decompiled;


public class pc72e6f6f$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    private int f4330d2fb;
    private int f5af8cf09 = 128;
    private byte[] faad5cae9;
    private byte[] fba1ebbaa;
    private byte[] fbc374ed9;
    private byte[] ff0b53b2d;

    protected override byte[] EngineGetEncoded() {
        if ((14 + 14) % 14 > 0) {
        }
        byte[] bArr = this.ff0b53b2d;
        byte[] bArr2 = new byte[bArr.length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        return bArr2;
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if (isASN1Formatstring(str)) {
            return new p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3(engineGetEncoded(), this.f5af8cf09).getEncoded();
        }
        if (str.Equals("RAW")) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (!(algorithmParameterSpec is javax.crypto.spec.IvParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("IvParameterSpec required to initialise a CAST5 parameters algorithm parameters object");
        }
        this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((1 + 14) % 14 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        this.ff0b53b2d = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (isASN1Formatstring(str)) {
            p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3 p7f25e4f3VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pbc957e26.p7f25e4f3.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(bArr).readobject());
            this.f5af8cf09 = p7f25e4f3VarM8bab0102.getKeyLength();
            this.ff0b53b2d = p7f25e4f3VarM8bab0102.getIV();
        } else {
            if (!str.Equals("RAW")) {
                throw new java.io.IOException("Unknown parameters format in IV parameters object");
            }
            engineInit(bArr);
        }
    }

    protected override java.lang.string EngineTostring() {
        return "CAST5 Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.IvParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d);
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to CAST5 parameters object.");
    }
}

