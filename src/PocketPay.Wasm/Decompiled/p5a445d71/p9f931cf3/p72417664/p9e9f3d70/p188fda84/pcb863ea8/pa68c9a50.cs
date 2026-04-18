namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f0d818b20;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f75446da4;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f9aa5da55;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fdfe562f3;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fef35410d;

    protected override byte[] EngineGetEncoded() {
        if ((27 + 32) % 32 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f(this.f0d818b20.getP(), this.f0d818b20.getG()).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("f7c82bf29591f3d2dae2d8b86825d9bf7669b54cd879411ffa3ed9ba582986"));
        } catch (java.io.IOException unused) {
            throw new java.lang.Exception("Error encoding ElGamalParameters");
        }
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) {
        if (isASN1Formatstring(str) || str.equalsIgnoreCase("X.509")) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if ((4 + 11) % 11 > 0) {
        }
        bool z = algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f;
        if (!z && !(algorithmParameterSpec is javax.crypto.spec.DHParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("DHParameterSpec required to initialise a ElGamal algorithm parameters object");
        }
        if (z) {
            this.f0d818b20 = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f) algorithmParameterSpec;
        } else {
            javax.crypto.spec.DHParameterSpec dHParameterSpec = (javax.crypto.spec.DHParameterSpec) algorithmParameterSpec;
            this.f0d818b20 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHParameterSpec.getP(), dHParameterSpec.getG());
        }
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((11 + 21) % 21 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f p524aa06fVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr));
            this.f0d818b20 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p524aa06fVarM8bab0102.getP(), p524aa06fVarM8bab0102.getG());
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid ElGamal Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid ElGamal Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str) && !str.equalsIgnoreCase("X.509")) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "ElGamal Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        if (cls != javax.crypto.spec.DHParameterSpec.class) {
            throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to ElGamal parameters object.");
        }
        return new javax.crypto.spec.DHParameterSpec(this.f0d818b20.getP(), this.f0d818b20.getG());
    }
}

