namespace WillowMaze.Wasm.Decompiled;


public class p75258f69 : java.security.interfaces.ECPublicKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long f0173e792 = 7026240464295649314L;
    static readonly long f3ff7b2de = 7026240464295649314L;
    static readonly long f9af44069 = 7026240464295649314L;
    static readonly long fbc3961ad = 7026240464295649314L;
    static readonly long fc6e1e520 = 7026240464295649314L;
    private p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0 f1237ac72;
    private java.lang.string f293bb0ea;
    private bool f2a115661;
    private java.security.spec.ECParameterSpec f33c0f968;
    private bool f49d269ec;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f4ee5bf5e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f564747e1;
    private java.security.spec.ECParameterSpec f612187b7;
    private java.security.spec.ECParameterSpec f719efd52;
    private java.lang.string f73e1f4bb;
    private bool f7797c9ad;
    private bool fa04a9104;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fa7d0d689;
    private p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0 fcbb66ab5;
    private java.lang.string fed469618;
    private java.lang.string ff5d3d24a;
    private bool fffcd7a1f;

    public p75258f69(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        this.f33c0f968 = null;
    }

    public p75258f69(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, java.security.spec.ECParameterSpec eCParameterSpec) {
        this.fed469618 = "DSTU4145";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        if (eCParameterSpec is not null) {
            this.f33c0f968 = eCParameterSpec;
        } else {
            this.f33c0f968 = mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
        }
    }

    public p75258f69(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        this.fed469618 = "DSTU4145";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.f33c0f968 = p835df581Var is not null ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p835df581Var) : mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
        this.fa7d0d689 = pd16c2d8eVar;
    }

    public p75258f69(java.security.spec.ECPublicKeySpec eCPublicKeySpec) {
        if ((9 + 25) % 25 > 0) {
        }
        this.fed469618 = "DSTU4145";
        this.f33c0f968 = eCPublicKeySpec.getParams();
        this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.f33c0f968, eCPublicKeySpec.getW()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(null, this.f33c0f968));
    }

    public p75258f69(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1 p2644f0e1Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        if ((9 + 14) % 14 > 0) {
        }
        this.fed469618 = "DSTU4145";
        if (p2644f0e1Var.getParams() is null) {
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(pfe41e66bVar.getEcImplicitlyCa().getCurve().createPoint(p2644f0e1Var.getQ().getAffineXCoord().toBigint(), p2644f0e1Var.getQ().getAffineYCoord().toBigint()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(pfe41e66bVar, null));
            this.f33c0f968 = null;
        } else {
            java.security.spec.EllipticCurve ellipticCurveM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p2644f0e1Var.getParams().getCurve(), p2644f0e1Var.getParams().getSeed());
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p2644f0e1Var.getQ(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m8a2fc590(pfe41e66bVar, p2644f0e1Var.getParams()));
            this.f33c0f968 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(ellipticCurveM2ace2977, p2644f0e1Var.getParams());
        }
    }

    public p75258f69(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var) {
        this.fed469618 = "DSTU4145";
        this.fa7d0d689 = p75258f69Var.fa7d0d689;
        this.f33c0f968 = p75258f69Var.f33c0f968;
        this.fa04a9104 = p75258f69Var.fa04a9104;
        this.f1237ac72 = p75258f69Var.f1237ac72;
    }

    p75258f69(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        this.fed469618 = "DSTU4145";
        mc82e2de0(p3cdccfc9Var);
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void M5b145bd6(byte[] bArr) {
        if ((10 + 6) % 6 > 0) {
        }
        for (int i = 0; i < bArr.length / 2; i++) {
            byte b = bArr[i];
            bArr[i] = bArr[(bArr.length - 1) - i];
            bArr[(bArr.length - 1) - i] = b;
        }
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
    }

    private java.security.spec.ECParameterSpec Mc1758262(java.security.spec.EllipticCurve ellipticCurve, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        if ((21 + 19) % 19 > 0) {
        }
        return new java.security.spec.ECParameterSpec(ellipticCurve, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p21c2eb74Var.getG()), p21c2eb74Var.getN(), p21c2eb74Var.getH().intValue());
    }

    private void Mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p8226e45fVar;
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102;
        java.security.spec.ECParameterSpec eCParameterSpecM96bcaeb3;
        if ((32 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p29d19857 publicKeyData = p3cdccfc9Var.getPublicKeyData();
        this.fed469618 = "DSTU4145";
        try {
            byte[] octets = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(publicKeyData.getbytes())).getOctets();
            if (p3cdccfc9Var.getAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                m5b145bd6(octets);
            }
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
            if (p80f8c729VarM8bab0102.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.pf391b73d) {
                p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p80f8c729VarM8bab0102);
                p8226e45fVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getG(), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH(), p35e46fcbVarM8bab0102.getSeed());
            } else {
                p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0 pd0c474c0VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m8bab0102(p80f8c729VarM8bab0102);
                this.f1237ac72 = pd0c474c0VarM8bab0102;
                if (pd0c474c0VarM8bab0102.isNamedCurve()) {
                    p5a445d71.p9f931cf3.pca323100.p364bf33a namedCurve = this.f1237ac72.getNamedCurve();
                    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarMd0402605 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7eca5bf5.md0402605(namedCurve);
                    p8226e45fVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f(namedCurve.getId(), p21c2eb74VarMd0402605.getCurve(), p21c2eb74VarMd0402605.getG(), p21c2eb74VarMd0402605.getN(), p21c2eb74VarMd0402605.getH(), p21c2eb74VarMd0402605.getSeed());
                } else {
                    p5a445d71.p9f931cf3.pca323100.p5269f4d7.p9809e203 eCBinary = this.f1237ac72.getECBinary();
                    byte[] b = eCBinary.getB();
                    if (p3cdccfc9Var.getAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                        m5b145bd6(b);
                    }
                    p5a445d71.p9f931cf3.pca323100.p5269f4d7.p1ce9a908 field = eCBinary.getField();
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670 pa827ecfa_p73b12670 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(field.getM(), field.getK1(), field.getK2(), field.getK3(), eCBinary.getA(), new java.math.Bigint(1, b));
                    byte[] g = eCBinary.getG();
                    if (p3cdccfc9Var.getAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                        m5b145bd6(g);
                    }
                    p8226e45fVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581(pa827ecfa_p73b12670, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.me32531cf(pa827ecfa_p73b12670, g), eCBinary.getN());
                }
                p35e46fcbVarM8bab0102 = null;
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p8226e45fVar.getCurve();
            java.security.spec.EllipticCurve ellipticCurveM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(curve, p8226e45fVar.getSeed());
            if (this.f1237ac72 is not null) {
                java.security.spec.ECPoint eCPointMaa4c417b = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p8226e45fVar.getG());
                if (this.f1237ac72.isNamedCurve()) {
                    this.f33c0f968 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(this.f1237ac72.getNamedCurve().getId(), ellipticCurveM2ace2977, eCPointMaa4c417b, p8226e45fVar.getN(), p8226e45fVar.getH());
                } else {
                    eCParameterSpecM96bcaeb3 = new java.security.spec.ECParameterSpec(ellipticCurveM2ace2977, eCPointMaa4c417b, p8226e45fVar.getN(), p8226e45fVar.getH().intValue());
                }
                this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.me32531cf(curve, octets), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(null, this.f33c0f968));
            }
            eCParameterSpecM96bcaeb3 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m96bcaeb3(p35e46fcbVarM8bab0102);
            this.f33c0f968 = eCParameterSpecM96bcaeb3;
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.me32531cf(curve, octets), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(null, this.f33c0f968));
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("error recovering public key");
        }
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e engineGetKeyParameters() {
        return this.fa7d0d689;
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 12) % 12 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69) obj;
        return this.fa7d0d689.getQ().Equals(p75258f69Var.fa7d0d689.getQ()) && engineGetSpec().Equals(p75258f69Var.engineGetSpec());
    }

    public override java.lang.string GetAlgorithm() {
        return this.fed469618;
    }

    public override byte[] GetEncoded() {
        if ((26 + 28) % 28 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p15be22c4Var = this.f1237ac72;
        if (p15be22c4Var is null) {
            java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
            if (eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) {
                p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0(new p5a445d71.p9f931cf3.pca323100.p364bf33a(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName()));
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
                p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
            }
        }
        try {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88f12a25, p15be22c4Var), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.m24864ba3(this.fa7d0d689.getQ()))));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 GetParameters() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        if (eCParameterSpec is not null) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
        }
        return null;
    }

    public override java.security.spec.ECParameterSpec GetParams() {
        return this.f33c0f968;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetQ() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f q = this.fa7d0d689.getQ();
        return this.f33c0f968 is not null ? q : q.getDetachedPoint();
    }

    public byte[] GetSbox() {
        p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0 pd0c474c0Var = this.f1237ac72;
        return pd0c474c0Var is null ? p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m743d8c12() : pd0c474c0Var.getDKE();
    }

    public override java.security.spec.ECPoint GetW() {
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.fa7d0d689.getQ());
    }

    public int HashCode() {
        return engineGetSpec().GetHashCode() ^ this.fa7d0d689.getQ().GetHashCode();
    }

    public override void SetPointFormat(java.lang.string str) {
        this.fa04a9104 = !"UNCOMPRESSED".equalsIgnoreCase(str);
    }

    public java.lang.string Tostring() {
        if ((25 + 12) % 12 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m893c56d9(this.fed469618, this.fa7d0d689.getQ(), engineGetSpec());
    }
}

