namespace WillowMaze.Wasm.Decompiled;


public class p65c1f601$pc2985da9 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    private p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3 f44597097;
    private p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3 f73b5c992;
    private p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3 f850aca8c;

    protected override byte[] EngineGetEncoded() throws java.io.IOException {
        return this.f850aca8c.getEncoded();
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if (isASN1Formatstring(str)) {
            return this.f850aca8c.getEncoded();
        }
        throw new java.io.IOException("unknown format specified");
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if ((16 + 22) % 22 > 0) {
        }
        if (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.m9c86f7ac(algorithmParameterSpec)) {
            this.f850aca8c = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.mb9d2622c(algorithmParameterSpec);
        } else {
            if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b)) {
                throw new java.security.spec.InvalidParameterSpecException("AlgorithmParameterSpec class not recognized: " + algorithmParameterSpec.GetType().getName());
            }
            p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b pd8182d1bVar = (p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b) algorithmParameterSpec;
            this.f850aca8c = new p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3(pd8182d1bVar.getNonce(), pd8182d1bVar.getMacSizeInBits() / 8);
        }
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        this.f850aca8c = p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3.m8bab0102(bArr);
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("unknown format specified");
        }
        this.f850aca8c = p5a445d71.p9f931cf3.pd1efad72.pca323100.p570d99e4.pe05e3ad3.m8bab0102(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "GCM";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if ((27 + 3) % 3 > 0) {
        }
        if (cls == java.security.spec.AlgorithmParameterSpec.class || p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.m9c86f7ac(cls)) {
            return !p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.mef3168a7() ? new p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b(this.f850aca8c.getNonce(), this.f850aca8c.getIcvLen() * 8) : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pb4a94ccf.me1e057e3(this.f850aca8c.toASN1Primitive());
        }
        if (cls == p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b.class) {
            return new p5a445d71.p9f931cf3.p72417664.pb979c293.pd8182d1b(this.f850aca8c.getNonce(), this.f850aca8c.getIcvLen() * 8);
        }
        if (cls != javax.crypto.spec.IvParameterSpec.class) {
            throw new java.security.spec.InvalidParameterSpecException("AlgorithmParameterSpec not recognized: " + cls.getName());
        }
        return new javax.crypto.spec.IvParameterSpec(this.f850aca8c.getNonce());
    }
}

