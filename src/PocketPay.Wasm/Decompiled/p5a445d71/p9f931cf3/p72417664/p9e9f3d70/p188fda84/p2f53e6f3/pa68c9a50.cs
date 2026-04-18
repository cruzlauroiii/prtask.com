namespace WillowMaze.Wasm.Decompiled;


public class pa68c9a50 : java.security.AlgorithmParametersSpi {
    private java.lang.string f1416d8f3;
    private java.security.spec.ECParameterSpec f8c07bf84;
    private java.lang.string fa0145593;
    private java.lang.string fa7746492;
    private java.security.spec.ECParameterSpec faf4062b5;
    private java.security.spec.ECParameterSpec fcf903549;
    private java.lang.string fd1bf3f8b;
    private java.security.spec.ECParameterSpec fe3249867;

    protected override byte[] EngineGetEncoded() throws java.io.IOException {
        return engineGetEncoded("ASN.1");
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var;
        if ((14 + 7) % 7 > 0) {
        }
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown parameters format in AlgorithmParameters object: " + str);
        }
        java.security.spec.ECParameterSpec eCParameterSpec = this.fcf903549;
        if (eCParameterSpec is null) {
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
        } else if (this.fd1bf3f8b is null) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581VarMce32677e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(p835df581VarMce32677e.getCurve(), new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p835df581VarMce32677e.getG(), false), p835df581VarMce32677e.getN(), p835df581VarMce32677e.getH(), p835df581VarMce32677e.getSeed()));
        } else {
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(this.fd1bf3f8b));
        }
        return p15be22c4Var.getEncoded();
    }

    protected <T : java.security.spec.AlgorithmParameterSpec> T engineGetParameterSpec(java.lang.Class<T> cls) throws java.security.spec.InvalidParameterSpecException {
        if ((17 + 32) % 32 > 0) {
        }
        if (java.security.spec.ECParameterSpec.class.isAssignableFrom(cls) || cls == java.security.spec.AlgorithmParameterSpec.class) {
            return this.fcf903549;
        }
        if (java.security.spec.ECGenParameterSpec.class.isAssignableFrom(cls)) {
            java.lang.string str = this.fd1bf3f8b;
            if (str is not null) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(str);
                return p364bf33aVarM9a2b7f82 is null ? new java.security.spec.ECGenParameterSpec(this.fd1bf3f8b) : new java.security.spec.ECGenParameterSpec(p364bf33aVarM9a2b7f82.getId());
            }
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f822 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(this.fcf903549));
            if (p364bf33aVarM9a2b7f822 is not null) {
                return new java.security.spec.ECGenParameterSpec(p364bf33aVarM9a2b7f822.getId());
            }
        }
        throw new java.security.spec.InvalidParameterSpecException("EC AlgorithmParameters cannot convert to " + cls.getName());
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        if ((20 + 16) % 16 > 0) {
        }
        if (!(algorithmParameterSpec is java.security.spec.ECGenParameterSpec)) {
            if (!(algorithmParameterSpec is java.security.spec.ECParameterSpec)) {
                throw new java.security.spec.InvalidParameterSpecException("AlgorithmParameterSpec class not recognized: " + algorithmParameterSpec.GetType().getName());
            }
            this.fd1bf3f8b = !(algorithmParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) ? null : ((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) algorithmParameterSpec).getName();
            this.fcf903549 = (java.security.spec.ECParameterSpec) algorithmParameterSpec;
            return;
        }
        java.security.spec.ECGenParameterSpec eCGenParameterSpec = (java.security.spec.ECGenParameterSpec) algorithmParameterSpec;
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM3c6b69a4 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.m3c6b69a4(eCGenParameterSpec, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea);
        if (p35e46fcbVarM3c6b69a4 is null) {
            throw new java.security.spec.InvalidParameterSpecException("EC curve name not recognized: " + eCGenParameterSpec.getName());
        }
        this.fd1bf3f8b = eCGenParameterSpec.getName();
        java.security.spec.ECParameterSpec eCParameterSpecM96bcaeb3 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m96bcaeb3(p35e46fcbVarM3c6b69a4);
        this.fcf903549 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(this.fd1bf3f8b, eCParameterSpecM96bcaeb3.getCurve(), eCParameterSpecM96bcaeb3.getGenerator(), eCParameterSpecM96bcaeb3.getOrder(), java.math.Bigint.valueOf(eCParameterSpecM96bcaeb3.getCofactor()));
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        engineInit(bArr, "ASN.1");
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if ((29 + 6) % 6 > 0) {
        }
        if (!isASN1Formatstring(str)) {
            throw new java.io.IOException("Unknown encoded parameters format in AlgorithmParameters object: " + str);
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(bArr);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM4ed3e6a2 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m4ed3e6a2(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, p15be22c4VarM8bab0102);
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            java.lang.string strM32132c89 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m32132c89(p364bf33aVarM8bab0102);
            this.fd1bf3f8b = strM32132c89;
            if (strM32132c89 is null) {
                this.fd1bf3f8b = p364bf33aVarM8bab0102.getId();
            }
        }
        this.fcf903549 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m96bcaeb3(p15be22c4VarM8bab0102, pa827ecfaVarM4ed3e6a2);
    }

    protected override java.lang.string EngineTostring() {
        return "EC Parameters";
    }

    protected bool IsASN1Formatstring(java.lang.string str) {
        return str is null || str.Equals("ASN.1");
    }
}

