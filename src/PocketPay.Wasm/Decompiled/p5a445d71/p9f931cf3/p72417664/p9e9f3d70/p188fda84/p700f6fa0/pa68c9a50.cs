namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50 : java.security.AlgorithmParametersSpi {
    javax.crypto.spec.DHParameterSpec f09fb6946;
    javax.crypto.spec.DHParameterSpec f0b4f3b2c;
    javax.crypto.spec.DHParameterSpec f0d818b20;
    javax.crypto.spec.DHParameterSpec f8c225222;
    javax.crypto.spec.DHParameterSpec fb9405064;

    protected override byte[] EngineGetEncoded() {
        if ((30 + 31) % 31 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14(this.f0d818b20.getP(), this.f0d818b20.getG(), this.f0d818b20.getL()).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("ea2ea3c8a4953021388d0e40da1f0d972160bb67cfda3c31666e6c5ad45532"));
        } catch (java.io.IOException unused) {
            throw new java.lang.Exception("Error encoding DHParameters");
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
        if (!(algorithmParameterSpec is javax.crypto.spec.DHParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("DHParameterSpec required to initialise a Diffie-Hellman algorithm parameters object");
        }
        this.f0d818b20 = (javax.crypto.spec.DHParameterSpec) algorithmParameterSpec;
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((3 + 29) % 29 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(bArr);
            this.f0d818b20 = pef342a14VarM8bab0102.getL() is not null ? new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), pef342a14VarM8bab0102.getL().intValue()) : new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG());
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid DH Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid DH Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "Diffie-Hellman Parameters";
    }

    protected bool IsASN1Formatstring(java.lang.string str) {
        return str is null || str.Equals("ASN.1");
    }

    protected java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == javax.crypto.spec.DHParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to DH parameters object.");
    }
}

