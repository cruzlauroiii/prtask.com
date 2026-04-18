namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50$peb8fea31 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50 {
    javax.crypto.spec.OAEPParameterSpec f0d818b20;
    javax.crypto.spec.OAEPParameterSpec f45356a0f;
    javax.crypto.spec.OAEPParameterSpec f8d26b63e;
    javax.crypto.spec.OAEPParameterSpec f99998930;

    protected override byte[] EngineGetEncoded() {
        if ((13 + 15) % 15 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p3dfcf319(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.m18da419b(this.f0d818b20.getDigestAlgorithm()), p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.m18da419b(((java.security.spec.MGF1ParameterSpec) this.f0d818b20.getMGFParameters()).getDigestAlgorithm()), p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17)), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f477b5532, new p5a445d71.p9f931cf3.pca323100.p6f0e511c(((javax.crypto.spec.PSource$PSpecified) this.f0d818b20.getPSource()).getValue()))).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("28079f37ffc342da423f970c7912f49ddfbcec2ea7a71c1ecacc7c5e327faa"));
        } catch (java.io.IOException unused) {
            throw new java.lang.Exception("Error encoding OAEPParameters");
        }
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) {
        if (isASN1Formatstring(str) || str.equalsIgnoreCase("X.509")) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (!(algorithmParameterSpec is javax.crypto.spec.OAEPParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("OAEPParameterSpec required to initialise an OAEP algorithm parameters object");
        }
        this.f0d818b20 = (javax.crypto.spec.OAEPParameterSpec) algorithmParameterSpec;
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((31 + 14) % 14 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p3dfcf319 p3dfcf319VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p3dfcf319.m8bab0102(bArr);
            if (!p3dfcf319VarM8bab0102.getMaskGenAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c)) {
                throw new java.io.IOException("unknown mask generation function: " + p3dfcf319VarM8bab0102.getMaskGenAlgorithm().getAlgorithm());
            }
            this.f0d818b20 = new javax.crypto.spec.OAEPParameterSpec(p5a445d71.p9f931cf3.p72417664.p05c7e247.p45eb53fe.mba8d3a36(p3dfcf319VarM8bab0102.getHashAlgorithm().getAlgorithm()), javax.crypto.spec.OAEPParameterSpec.DEFAULT.getMGFAlgorithm(), new java.security.spec.MGF1ParameterSpec(p5a445d71.p9f931cf3.p72417664.p05c7e247.p45eb53fe.mba8d3a36(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p3dfcf319VarM8bab0102.getMaskGenAlgorithm().getParameters()).getAlgorithm())), new javax.crypto.spec.PSource$PSpecified(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p3dfcf319VarM8bab0102.getPSourceAlgorithm().getParameters()).getOctets()));
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid OAEP Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid OAEP Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!str.equalsIgnoreCase("X.509") && !str.equalsIgnoreCase("ASN.1")) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "OAEP Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.OAEPParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to OAEP parameters object.");
    }
}

