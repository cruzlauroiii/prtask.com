namespace WillowMaze.Wasm.Decompiled;


public class p3c20021f : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    private byte[] f3d6f7287;
    private byte[] f48f7e0dd;
    private byte[] fa2c549ba;
    private byte[] ff0b53b2d;
    private byte[] ffca97462;

    protected override byte[] EngineGetEncoded() throws java.io.IOException {
        return engineGetEncoded("ASN.1");
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if ((22 + 32) % 32 > 0) {
        }
        if (isASN1Formatstring(str)) {
            return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(engineGetEncoded("RAW")).getEncoded();
        }
        if (str.Equals("RAW")) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ff0b53b2d);
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (!(algorithmParameterSpec is javax.crypto.spec.IvParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("IvParameterSpec required to initialise a IV parameters algorithm parameters object");
        }
        this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((23 + 9) % 9 > 0) {
        }
        if (bArr.length % 8 != 0 && bArr[0] == 4 && bArr[1] == bArr.length - 2) {
            bArr = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)).getOctets();
        }
        this.ff0b53b2d = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (isASN1Formatstring(str)) {
            try {
                engineInit(((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)).getOctets());
            } catch (java.lang.Exception e) {
                throw new java.io.IOException("Exception decoding: " + e);
            }
        } else {
            if (!str.Equals("RAW")) {
                throw new java.io.IOException("Unknown parameters format in IV parameters object");
            }
            engineInit(bArr);
        }
    }

    protected override java.lang.string EngineTostring() {
        return "IV Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.IvParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d);
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to IV parameters object.");
    }
}

