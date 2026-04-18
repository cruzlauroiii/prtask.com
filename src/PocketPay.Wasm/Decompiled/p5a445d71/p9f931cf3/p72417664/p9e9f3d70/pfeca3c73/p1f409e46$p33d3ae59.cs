namespace WillowMaze.Wasm.Decompiled;


public class p1f409e46$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f f21ffce5b;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f f73611e69;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f f864acd27;
    p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f fa85433cc;

    protected override byte[] EngineGetEncoded() {
        if ((32 + 23) % 23 > 0) {
        }
        try {
            return this.f21ffce5b.getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("a41afda3df2a3abce12ee4e159ece504ff99753847686ff442c913799f45eb"));
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
        if ((21 + 26) % 26 > 0) {
        }
        if (!(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("PBEParameterSpec required to initialise a PBKDF1 PBE parameters algorithm parameters object");
        }
        javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
        this.f21ffce5b = new p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f(pBEParameterSpec.getSalt(), pBEParameterSpec.getIterationCount());
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        this.f21ffce5b = p5a445d71.p9f931cf3.pca323100.p56fc8961.pf8f35d1f.m8bab0102(bArr);
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown parameters format in PBKDF2 parameters object");
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "PBKDF1 Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.PBEParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new javax.crypto.spec.PBEParameterSpec(this.f21ffce5b.getSalt(), this.f21ffce5b.getIterationCount().intValue());
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to PBKDF1 PBE parameters object.");
    }
}

