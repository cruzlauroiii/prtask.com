namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50 : java.security.AlgorithmParametersSpi {
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f0d818b20;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f23f9d5cb;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f5dd8ce7b;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d f8ec363ae;

    protected override byte[] EngineGetEncoded() {
        if ((11 + 11) % 11 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f0d818b20.getPublicKeyParamHashSetOID()), new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f0d818b20.getDigestParamHashSetOID()), new p5a445d71.p9f931cf3.pca323100.p364bf33a(this.f0d818b20.getEncryptionParamHashSetOID())).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("20bc8bacc03ddb1857d80dc0c042ae4fbfc14e8d92b8475226ac07a9170eca"));
        } catch (java.io.IOException unused) {
            throw new java.lang.Exception("Error encoding GOST3410Parameters");
        }
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) {
        if (isASN1Formatstring(str) || str.equalsIgnoreCase("X.509")) {
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
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d)) {
            throw new java.security.spec.InvalidParameterSpecException("GOST3410ParameterSpec required to initialise a GOST3410 algorithm parameters object");
        }
        this.f0d818b20 = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d) algorithmParameterSpec;
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        try {
            this.f0d818b20 = p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p6b825a8d.md6c1e629(p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102((p5a445d71.p9f931cf3.pca323100.p80f8c729) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)));
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid GOST3410 Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid GOST3410 Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str) && !str.equalsIgnoreCase("X.509")) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "GOST3410 Parameters";
    }

    protected bool IsASN1Formatstring(java.lang.string str) {
        return str is null || str.Equals("ASN.1");
    }

    protected java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to GOST3410 parameters object.");
    }
}

