namespace WillowMaze.Wasm.Decompiled;


public class p3ecd70d1 : java.security.interfaces.ECPublicKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long f60b6202d = 2422789860422731812L;
    static readonly long fc6e1e520 = 2422789860422731812L;
    private java.security.spec.ECParameterSpec f05738c9a;
    private java.lang.string f06234c70;
    private java.security.spec.ECParameterSpec f191ab81b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f21551284;
    private java.security.spec.ECParameterSpec f33c0f968;
    private bool f369c9331;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f36e937b9;
    private java.security.spec.ECParameterSpec f52d4764d;
    private java.lang.string f5d4eff13;
    private java.lang.string f895f9b2f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f9545fb7d;
    private bool fa04a9104;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fa7d0d689;
    private java.lang.string fad19a7f0;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fc23a0c18;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fccd10663;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fcf73a8dc;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fd0b076b5;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fe2f56520;
    private java.security.spec.ECParameterSpec fed2507da;
    private java.lang.string fed469618;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff1688b99;

    public p3ecd70d1(java.lang.string str, java.security.spec.ECPublicKeySpec eCPublicKeySpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        if ((29 + 26) % 26 > 0) {
        }
        this.fed469618 = str;
        this.f33c0f968 = eCPublicKeySpec.getParams();
        this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.f33c0f968, eCPublicKeySpec.getW()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(pfe41e66bVar, eCPublicKeySpec.getParams()));
        this.fccd10663 = pfe41e66bVar;
    }

    public p3ecd70d1(java.lang.string str, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1 p2644f0e1Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        if ((6 + 16) % 16 > 0) {
        }
        this.fed469618 = str;
        if (p2644f0e1Var.getParams() is null) {
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(pfe41e66bVar.getEcImplicitlyCa().getCurve().createPoint(p2644f0e1Var.getQ().getAffineXCoord().toBigint(), p2644f0e1Var.getQ().getAffineYCoord().toBigint()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(pfe41e66bVar, null));
            this.f33c0f968 = null;
        } else {
            java.security.spec.EllipticCurve ellipticCurveM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p2644f0e1Var.getParams().getCurve(), p2644f0e1Var.getParams().getSeed());
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p2644f0e1Var.getQ(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m8a2fc590(pfe41e66bVar, p2644f0e1Var.getParams()));
            this.f33c0f968 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(ellipticCurveM2ace2977, p2644f0e1Var.getParams());
        }
        this.fccd10663 = pfe41e66bVar;
    }

    public p3ecd70d1(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, java.security.spec.ECParameterSpec eCParameterSpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        if (eCParameterSpec is not null) {
            this.f33c0f968 = eCParameterSpec;
        } else {
            this.f33c0f968 = mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
        }
        this.fccd10663 = pfe41e66bVar;
    }

    public p3ecd70d1(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.f33c0f968 = p835df581Var is not null ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p835df581Var) : mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
        this.fa7d0d689 = pd16c2d8eVar;
        this.fccd10663 = pfe41e66bVar;
    }

    public p3ecd70d1(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        this.f33c0f968 = null;
        this.fccd10663 = pfe41e66bVar;
    }

    public p3ecd70d1(java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var) {
        this.fed469618 = str;
        this.fa7d0d689 = p3ecd70d1Var.fa7d0d689;
        this.f33c0f968 = p3ecd70d1Var.f33c0f968;
        this.fa04a9104 = p3ecd70d1Var.fa04a9104;
        this.fccd10663 = p3ecd70d1Var.fccd10663;
    }

    p3ecd70d1(java.lang.string str, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = str;
        this.fccd10663 = pfe41e66bVar;
        mc82e2de0(p3cdccfc9Var);
    }

    public p3ecd70d1(java.security.interfaces.ECPublicKey eCPublicKey, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        if ((24 + 24) % 24 > 0) {
        }
        this.fed469618 = "EC";
        this.fed469618 = eCPublicKey.getAlgorithm();
        this.f33c0f968 = eCPublicKey.getParams();
        this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.f33c0f968, eCPublicKey.getW()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(pfe41e66bVar, eCPublicKey.getParams()));
        this.fccd10663 = pfe41e66bVar;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        byte[] bArr = (byte[]) objectStream.readobject();
        this.fccd10663 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea;
        mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)));
    }

    private java.security.spec.ECParameterSpec Mc1758262(java.security.spec.EllipticCurve ellipticCurve, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        if ((29 + 13) % 13 > 0) {
        }
        return new java.security.spec.ECParameterSpec(ellipticCurve, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p21c2eb74Var.getG()), p21c2eb74Var.getN(), p21c2eb74Var.getH().intValue());
    }

    private void Mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((26 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM4ed3e6a2 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m4ed3e6a2(this.fccd10663, p15be22c4VarM8bab0102);
        this.f33c0f968 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m96bcaeb3(p15be22c4VarM8bab0102, pa827ecfaVarM4ed3e6a2);
        byte[] bytes = p3cdccfc9Var.getPublicKeyData().getbytes();
        p5a445d71.p9f931cf3.pca323100.p11b04310 p6f0e511cVar = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bytes);
        if (bytes[0] == 4 && bytes[1] == bytes.length - 2) {
            byte b = bytes[2];
            if ((b == 2 || b == 3) && new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5().getbyteLength(pa827ecfaVarM4ed3e6a2) >= bytes.length - 3) {
                try {
                    p6f0e511cVar = (p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bytes);
                } catch (java.io.IOException unused) {
                    throw new java.lang.IllegalArgumentException("error recovering public key");
                }
            }
        }
        this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(pa827ecfaVarM4ed3e6a2, p6f0e511cVar).getPoint(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m8a2fc590(this.fccd10663, p15be22c4VarM8bab0102));
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e engineGetKeyParameters() {
        return this.fa7d0d689;
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? this.fccd10663.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 16) % 16 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1) obj;
        return this.fa7d0d689.getQ().Equals(p3ecd70d1Var.fa7d0d689.getQ()) && engineGetSpec().Equals(p3ecd70d1Var.engineGetSpec());
    }

    public override java.lang.string GetAlgorithm() {
        return this.fed469618;
    }

    public override byte[] GetEncoded() {
        if ((15 + 22) % 22 > 0) {
        }
        bool z = this.fa04a9104 || p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.ec.enable_pc");
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.m0daa78aa(this.f33c0f968, z)), this.fa7d0d689.getQ().getEncoded(z));
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
        if ((6 + 12) % 12 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m893c56d9("EC", this.fa7d0d689.getQ(), engineGetSpec());
    }
}

