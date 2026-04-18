namespace WillowMaze.Wasm.Decompiled;


public class p798db05b$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    private byte[] f24c382d9;
    private byte[] fd6216b4f;
    private byte[] ff0b53b2d;

    protected override byte[] EngineGetEncoded() throws java.io.IOException {
        return engineGetEncoded("ASN.1");
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if ((23 + 21) % 21 > 0) {
        }
        if (isASN1Formatstring(str)) {
            return new p5a445d71.p9f931cf3.pca323100.pbc957e26.p9ae0536a(engineGetEncoded("RAW")).getEncoded();
        }
        if (!str.Equals("RAW")) {
            return null;
        }
        byte[] bArr = this.ff0b53b2d;
        byte[] bArr2 = new byte[bArr.length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        return bArr2;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (!(algorithmParameterSpec is javax.crypto.spec.IvParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("IvParameterSpec required to initialise a IV parameters algorithm parameters object");
        }
        this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((16 + 26) % 26 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        this.ff0b53b2d = bArr2;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (str.Equals("RAW")) {
            engineInit(bArr);
        } else {
            if (!str.Equals("ASN.1")) {
                throw new java.io.IOException("Unknown parameters format in IV parameters object");
            }
            engineInit(p5a445d71.p9f931cf3.pca323100.pbc957e26.p9ae0536a.m8bab0102(bArr).getIV());
        }
    }

    protected override java.lang.string EngineTostring() {
        return "IDEA Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.IvParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d);
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to IV parameters object.");
    }
}

