namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50 : java.security.AlgorithmParametersSpi {
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d f05e4c9cd;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d f08700f8c;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d f0d818b20;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d f97647824;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d fb25cd2de;

    protected override byte[] EngineGetEncoded() {
        if ((30 + 2) % 2 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            if (this.f0d818b20.getDerivationV() is not null) {
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f0d818b20.getDerivationV())));
            }
            if (this.f0d818b20.getEncodingV() is not null) {
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 1, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f0d818b20.getEncodingV())));
            }
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f0d818b20.getMacKeySize()));
            if (this.f0d818b20.getNonce() is not null) {
                p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f0d818b20.getCipherKeySize()));
                pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f0d818b20.getNonce()));
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
            }
            pd6ccb7fcVar.Add(this.f0d818b20.getPointCompression() ? p5a445d71.p9f931cf3.pca323100.p41bf756e.fc0d83f0b : p5a445d71.p9f931cf3.pca323100.p41bf756e.f946003f9);
            return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("40aeb55435f4166250c45273c6882ce56052ec6afb8cde572fdb2aa1f684a6"));
        } catch (java.io.IOException unused) {
            throw new java.lang.Exception("Error encoding IESParameters");
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
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d)) {
            throw new java.security.spec.InvalidParameterSpecException("IESParameterSpec required to initialise a IES algorithm parameters object");
        }
        this.f0d818b20 = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d) algorithmParameterSpec;
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        if ((30 + 32) % 32 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr);
            if (p80f8c729Var.Count > 5) {
                throw new java.io.IOException("sequence too big");
            }
            java.util.Enumeration objects = p80f8c729Var.getobjects();
            java.math.Bigint bigint = null;
            bool zIsTrue = false;
            java.math.Bigint value = null;
            byte[] octets = null;
            byte[] octets2 = null;
            byte[] octets3 = null;
            while (objects.hasMoreElements()) {
                java.lang.object objNextElement = objects.nextElement();
                if (objNextElement is p5a445d71.p9f931cf3.pca323100.p582a4948) {
                    p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(objNextElement);
                    if (p582a4948VarM8bab0102.getTagNo() == 0) {
                        octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p582a4948VarM8bab0102, false).getOctets();
                    } else if (p582a4948VarM8bab0102.getTagNo() == 1) {
                        octets2 = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p582a4948VarM8bab0102, false).getOctets();
                    }
                } else if (objNextElement is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
                    value = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(objNextElement).getValue();
                } else if (objNextElement is p5a445d71.p9f931cf3.pca323100.p80f8c729) {
                    p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(objNextElement);
                    java.math.Bigint value2 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(0)).getValue();
                    octets3 = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(1)).getOctets();
                    bigint = value2;
                } else if (objNextElement is p5a445d71.p9f931cf3.pca323100.p41bf756e) {
                    zIsTrue = p5a445d71.p9f931cf3.pca323100.p41bf756e.m8bab0102(objNextElement).isTrue();
                }
            }
            java.math.Bigint bigint2 = value;
            this.f0d818b20 = bigint is not null ? new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(octets, octets2, bigint2.intValue(), bigint.intValue(), octets3, zIsTrue) : new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(octets, octets2, bigint2.intValue(), -1, null, zIsTrue);
        } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
            throw new java.io.IOException("Not a valid IES Parameter encoding.");
        } catch (java.lang.ClassCastException unused2) {
            throw new java.io.IOException("Not a valid IES Parameter encoding.");
        }
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str) && !str.equalsIgnoreCase("X.509")) {
            throw new java.io.IOException("Unknown parameter format " + str);
        }
        engineInit(bArr);
    }

    protected override java.lang.string EngineTostring() {
        return "IES Parameters";
    }

    protected bool IsASN1Formatstring(java.lang.string str) {
        return str is null || str.Equals("ASN.1");
    }

    protected java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if (cls == p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.f0d818b20;
        }
        throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to ElGamal parameters object.");
    }
}

