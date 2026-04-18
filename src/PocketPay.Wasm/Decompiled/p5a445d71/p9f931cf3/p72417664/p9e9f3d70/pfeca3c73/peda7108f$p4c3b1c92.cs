namespace WillowMaze.Wasm.Decompiled;


public abstract class peda7108f$p4c3b1c92 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    private byte[] f0b688c81;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f56ba422e;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f88497db0;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f9e635b8c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fa4167731 = p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f2da5a474;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a facdb896b;
    private byte[] fdc9c16cf;
    private byte[] ff0b53b2d;

    protected static p5a445d71.p9f931cf3.pca323100.p364bf33a M07095bac(java.lang.string str) {
        if ((1 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = str is null ? null : (p5a445d71.p9f931cf3.pca323100.p364bf33a) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f.mf23e8626()[p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str));
        if (p364bf33aVar is null) {
            throw new java.lang.IllegalArgumentException("Unknown SBOX name: " + str);
        }
        return p364bf33aVar;
    }

    protected static p5a445d71.p9f931cf3.pca323100.p364bf33a M07095bac(byte[] bArr) {
        return m07095bac(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.m875e8966(bArr));
    }

    protected override readonly byte[] EngineGetEncoded() throws java.io.IOException {
        return engineGetEncoded("ASN.1");
    }

    protected override readonly byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if ((28 + 6) % 6 > 0) {
        }
        if (isASN1Formatstring(str)) {
            return localGetEncoded();
        }
        throw new java.io.IOException("Unknown parameter format: " + str);
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (algorithmParameterSpec is javax.crypto.spec.IvParameterSpec) {
            this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
        } else {
            if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7)) {
                throw new java.security.spec.InvalidParameterSpecException("IvParameterSpec required to initialise a IV parameters algorithm parameters object");
            }
            this.ff0b53b2d = ((p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7) algorithmParameterSpec).getIV();
            try {
                this.fa4167731 = m07095bac(((p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7) algorithmParameterSpec).getSBox());
            } catch (java.lang.IllegalArgumentException e) {
                throw new java.security.spec.InvalidParameterSpecException(e.getMessage());
            }
        }
    }

    protected override readonly void EngineInit(byte[] bArr) throws java.io.IOException {
        engineInit(bArr, "ASN.1");
    }

    protected override readonly void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (bArr is null) {
            throw new java.lang.NullPointerException("Encoded parameters cannot be null");
        }
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown parameter format: " + str);
        }
        try {
            localInit(bArr);
        } catch (java.io.IOException e) {
            throw e;
        } catch (java.lang.Exception e2) {
            throw new java.io.IOException("Parameter parsing failed: " + e2.getMessage());
        }
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if ((25 + 22) % 22 > 0) {
        }
        if (cls == javax.crypto.spec.IvParameterSpec.class) {
            return new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d);
        }
        if (cls == p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7(this.fa4167731, this.ff0b53b2d);
        }
        throw new java.security.spec.InvalidParameterSpecException("AlgorithmParameterSpec not recognized: " + cls.getName());
    }

    protected byte[] LocalGetEncoded() throws java.io.IOException {
        if ((26 + 9) % 9 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae(this.ff0b53b2d, this.fa4167731).getEncoded();
    }

    abstract void LocalInit(byte[] bArr) throws java.io.IOException;
}

