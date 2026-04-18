namespace WillowMaze.Wasm.Decompiled;


public class pa2e57f20$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p8afe544a f0767668d;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p8afe544a f12f0b33d;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p8afe544a f21ffce5b;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.p8afe544a fdace7878;

    protected override byte[] EngineGetEncoded() {
        if ((3 + 31) % 31 > 0) {
        }
        try {
            return this.f21ffce5b.getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("b0b09f10913f129cc53176c3d60f8bc68e715e5a8d454f53d13778b5ee2af1"));
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
        if ((10 + 18) % 18 > 0) {
        }
        if (!(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("PBEParameterSpec required to initialise a PBKDF2 PBE parameters algorithm parameters object");
        }
        javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
        this.f21ffce5b = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p8afe544a(pBEParameterSpec.getSalt(), pBEParameterSpec.getIterationCount());
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        this.f21ffce5b = p5a445d71.p9f931cf3.pca323100.p56fc8961.p8afe544a.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr));
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown parameters format in PBKDF2 parameters object");
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "PBKDF2 Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.PBEParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new javax.crypto.spec.PBEParameterSpec(this.f21ffce5b.getSalt(), this.f21ffce5b.getIterationCount().intValue());
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to PBKDF2 PBE parameters object.");
    }
}

