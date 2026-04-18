namespace WillowMaze.Wasm.Decompiled;


public class pd7f2a5f9$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58 f11f7d269;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58 f21ffce5b;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58 f9d2f8f9b;

    protected override byte[] EngineGetEncoded() {
        if ((5 + 11) % 11 > 0) {
        }
        try {
            return this.f21ffce5b.getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("4a91c90fd1b5fa432bcd6ade7dcd4a64880350e6324be3cc2ea06e6bf4b18a"));
        } catch (java.io.IOException e) {
            throw new java.lang.Exception("Oooops! " + e.tostring());
        }
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) {
        if (isASN1Formatstring(str)) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if ((17 + 9) % 9 > 0) {
        }
        if (!(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("PBEParameterSpec required to initialise a PKCS12 PBE parameters algorithm parameters object");
        }
        javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
        this.f21ffce5b = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58(pBEParameterSpec.getSalt(), pBEParameterSpec.getIterationCount());
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        this.f21ffce5b = p5a445d71.p9f931cf3.pca323100.p56fc8961.p46a7aa58.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr));
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown parameters format in PKCS12 PBE parameters object");
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "PKCS12 PBE Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.PBEParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new javax.crypto.spec.PBEParameterSpec(this.f21ffce5b.getIV(), this.f21ffce5b.getIterations().intValue());
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to PKCS12 PBE parameters object.");
    }
}

