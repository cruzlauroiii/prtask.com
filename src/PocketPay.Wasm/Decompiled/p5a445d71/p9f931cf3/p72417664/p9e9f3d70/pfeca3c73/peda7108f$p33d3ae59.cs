namespace WillowMaze.Wasm.Decompiled;


public class peda7108f$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p4c3b1c92 {
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f3b62b082;
    private byte[] f44f90a54;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fa4167731 = p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f2da5a474;
    private byte[] ff0b53b2d;

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (algorithmParameterSpec is javax.crypto.spec.IvParameterSpec) {
            this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
        } else {
            if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7)) {
                throw new java.security.spec.InvalidParameterSpecException("IvParameterSpec required to initialise a IV parameters algorithm parameters object");
            }
            this.ff0b53b2d = ((p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7) algorithmParameterSpec).getIV();
            try {
                this.fa4167731 = getSBoxOID(((p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7) algorithmParameterSpec).getSBox());
            } catch (java.lang.IllegalArgumentException e) {
                throw new java.security.spec.InvalidParameterSpecException(e.getMessage());
            }
        }
    }

    protected override java.lang.string EngineTostring() {
        return "GOST 28147 IV Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if ((23 + 1) % 1 > 0) {
        }
        if (cls == javax.crypto.spec.IvParameterSpec.class) {
            return new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d);
        }
        if (cls == p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return new p5a445d71.p9f931cf3.p72417664.pb979c293.pc5c653c7(this.fa4167731, this.ff0b53b2d);
        }
        throw new java.security.spec.InvalidParameterSpecException("AlgorithmParameterSpec not recognized: " + cls.getName());
    }

    protected override byte[] LocalGetEncoded() throws java.io.IOException {
        if ((26 + 5) % 5 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae(this.ff0b53b2d, this.fa4167731).getEncoded();
    }

    protected override void LocalInit(byte[] bArr) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarM89e75c46 = p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
        if (p301c7ed4VarM89e75c46 is p5a445d71.p9f931cf3.pca323100.p11b04310) {
            this.ff0b53b2d = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p301c7ed4VarM89e75c46).getOctets();
        } else {
            if (!(p301c7ed4VarM89e75c46 is p5a445d71.p9f931cf3.pca323100.p80f8c729)) {
                throw new java.io.IOException("Unable to recognize parameters");
            }
            p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae p9f54f8aeVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p9f54f8ae.m8bab0102(p301c7ed4VarM89e75c46);
            this.fa4167731 = p9f54f8aeVarM8bab0102.getEncryptionParamHashSet();
            this.ff0b53b2d = p9f54f8aeVarM8bab0102.getIV();
        }
    }
}

