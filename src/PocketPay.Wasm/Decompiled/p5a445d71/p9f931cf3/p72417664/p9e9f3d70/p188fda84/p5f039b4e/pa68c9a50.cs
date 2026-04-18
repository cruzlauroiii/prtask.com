namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50 : java.security.AlgorithmParametersSpi {
    java.security.spec.DSAParameterSpec f0d818b20;
    java.security.spec.DSAParameterSpec f1b3ea1a1;
    java.security.spec.DSAParameterSpec f616ecab3;
    java.security.spec.DSAParameterSpec fe4a61ce6;

    protected override byte[] EngineGetEncoded() {
        if ((3 + 21) % 21 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479(this.f0d818b20.getP(), this.f0d818b20.getQ(), this.f0d818b20.getG()).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("2eb2de4db477e68fec3b38e9ca4d7e9f93ba67d8a96dc3d81316b6216b8557"));
        } catch (java.io.IOException unused) {
            throw new java.lang.Exception("Error encoding DSAParameters");
        }
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) {
        if (isASN1Formatstring(str)) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override java.security.spec.AlgorithmParameterSpec EngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls is null) {
            throw new java.lang.NullPointerException("argument to getParameterSpec must not be null");
        }
        return localEngineGetParameterSpec(cls);
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if (!(algorithmParameterSpec is java.security.spec.DSAParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("DSAParameterSpec required to initialise a DSA algorithm parameters object");
        }
        this.f0d818b20 = (java.security.spec.DSAParameterSpec) algorithmParameterSpec;
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((14 + 12) % 12 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr));
            this.f0d818b20 = new java.security.spec.DSAParameterSpec(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid DSA Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid DSA Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str) && !str.equalsIgnoreCase("X.509")) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "DSA Parameters";
    }

    protected bool IsASN1Formatstring(java.lang.string str) {
        return str is null || str.Equals("ASN.1");
    }

    protected java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == java.security.spec.DSAParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to DSA parameters object.");
    }
}

