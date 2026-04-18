namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50$p8c5e459e : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50 {
    java.security.spec.PSSParameterSpec f0d818b20;
    java.security.spec.PSSParameterSpec f19092485;
    java.security.spec.PSSParameterSpec f73366177;
    java.security.spec.PSSParameterSpec f88493c5c;
    java.security.spec.PSSParameterSpec f8a66b503;

    protected override byte[] EngineGetEncoded() throws java.io.IOException {
        if ((27 + 16) % 16 > 0) {
        }
        java.security.spec.PSSParameterSpec pSSParameterSpec = this.f0d818b20;
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.m18da419b(pSSParameterSpec.getDigestAlgorithm()), p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
        java.security.spec.MGF1ParameterSpec mGF1ParameterSpec = (java.security.spec.MGF1ParameterSpec) pSSParameterSpec.getMGFParameters();
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("b562869315beaf788a92b45278cbb41d12f8b504e96d7f916213316f721d46");
        if (mGF1ParameterSpec is null) {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.pfa0321ce(p234a7530Var, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(!pSSParameterSpec.getMGFAlgorithm().Equals(com.decryptstringmanager.Decryptstring.decryptstring("28e1fcedcab95408482036264b2ec7dcdcf1a92fd6ca5830f558a0ccdbe527b29d005075")) ? p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af : p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f), new p5a445d71.p9f931cf3.pca323100.pf391b73d(pSSParameterSpec.getSaltLength()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(pSSParameterSpec.getTrailerField())).getEncoded(strDecryptstring);
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.pfa0321ce(p234a7530Var, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.m18da419b(mGF1ParameterSpec.getDigestAlgorithm()), p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17)), new p5a445d71.p9f931cf3.pca323100.pf391b73d(pSSParameterSpec.getSaltLength()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(pSSParameterSpec.getTrailerField())).getEncoded(strDecryptstring);
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if (str.equalsIgnoreCase("X.509") || str.equalsIgnoreCase("ASN.1")) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (!(algorithmParameterSpec is java.security.spec.PSSParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("PSSParameterSpec required to initialise an PSS algorithm parameters object");
        }
        this.f0d818b20 = (java.security.spec.PSSParameterSpec) algorithmParameterSpec;
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((5 + 27) % 27 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.pfa0321ce pfa0321ceVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pfa0321ce.m8bab0102(bArr);
            p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = pfa0321ceVarM8bab0102.getMaskGenAlgorithm().getAlgorithm();
            if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c)) {
                this.f0d818b20 = new java.security.spec.PSSParameterSpec(p5a445d71.p9f931cf3.p72417664.p05c7e247.p45eb53fe.mba8d3a36(pfa0321ceVarM8bab0102.getHashAlgorithm().getAlgorithm()), java.security.spec.PSSParameterSpec.DEFAULT.getMGFAlgorithm(), new java.security.spec.MGF1ParameterSpec(p5a445d71.p9f931cf3.p72417664.p05c7e247.p45eb53fe.mba8d3a36(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(pfa0321ceVarM8bab0102.getMaskGenAlgorithm().getParameters()).getAlgorithm())), pfa0321ceVarM8bab0102.getSaltLength().intValue(), pfa0321ceVarM8bab0102.getTrailerField().intValue());
                return;
            }
            if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f) && !algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af)) {
                throw new java.io.IOException("unknown mask generation function: " + pfa0321ceVarM8bab0102.getMaskGenAlgorithm().getAlgorithm());
            }
            this.f0d818b20 = new java.security.spec.PSSParameterSpec(p5a445d71.p9f931cf3.p72417664.p05c7e247.p45eb53fe.mba8d3a36(pfa0321ceVarM8bab0102.getHashAlgorithm().getAlgorithm()), algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f) ? com.decryptstringmanager.Decryptstring.decryptstring("e6d6c1f92c12897f2ae866575e0de3fd297096ee2d541b322cd1f7966f5c9be8f3200f8b") : com.decryptstringmanager.Decryptstring.decryptstring("e678680f5a703b84c877d89f0b3bab6ac3dd648b74515dbed673d58d2a79e93fe95809da"), null, pfa0321ceVarM8bab0102.getSaltLength().intValue(), pfa0321ceVarM8bab0102.getTrailerField().intValue());
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid PSS Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid PSS Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str) && !str.equalsIgnoreCase("X.509")) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "PSS Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == java.security.spec.PSSParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to PSS parameters object.");
    }
}

