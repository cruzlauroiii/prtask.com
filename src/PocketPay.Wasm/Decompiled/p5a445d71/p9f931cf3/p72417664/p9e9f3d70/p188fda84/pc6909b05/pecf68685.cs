namespace WillowMaze.Wasm.Decompiled;


public class pecf68685 : java.security.interfaces.ECPublicKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long f94a80167 = 7026240464295649314L;
    static readonly long fa6f6d637 = 7026240464295649314L;
    static readonly long fbc2b5ce6 = 7026240464295649314L;
    static readonly long fc6e1e520 = 7026240464295649314L;
    static readonly long fdc9b2664 = 7026240464295649314L;
    private java.lang.string f2a16a5ab;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f2a939c41;
    private java.security.spec.ECParameterSpec f33c0f968;
    private java.lang.string f36e064e3;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f41a30cda;
    private java.lang.string f5a9142bd;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f62f6f98d;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f87868a67;
    private bool fa04a9104;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fa7d0d689;
    private bool fb2d3bba9;
    private java.security.spec.ECParameterSpec fb48cd25f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fdc19459a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e fdff1ef67;
    private java.lang.string fe7c1d29e;
    private java.lang.string fed469618;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff6a9ff0c;

    public pecf68685(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        this.f33c0f968 = null;
    }

    public pecf68685(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((2 + 22) % 22 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        if (parameters is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483 p2cc33483Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483) parameters;
            this.f62f6f98d = new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(p2cc33483Var.getPublicKeyParamHashSet(), p2cc33483Var.getDigestParamHashSet(), p2cc33483Var.getEncryptionParamHashSet());
        }
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        if (eCParameterSpec is not null) {
            this.f33c0f968 = eCParameterSpec;
        } else {
            this.f33c0f968 = mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
        }
    }

    public pecf68685(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        this.fed469618 = "ECGOST3410";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.fa7d0d689 = pd16c2d8eVar;
        this.f33c0f968 = p835df581Var is not null ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p835df581Var) : mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
    }

    public pecf68685(java.security.interfaces.ECPublicKey eCPublicKey) {
        if ((2 + 2) % 2 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        this.fed469618 = eCPublicKey.getAlgorithm();
        this.f33c0f968 = eCPublicKey.getParams();
        this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.f33c0f968, eCPublicKey.getW()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(null, eCPublicKey.getParams()));
    }

    public pecf68685(java.security.spec.ECPublicKeySpec eCPublicKeySpec) {
        if ((25 + 9) % 9 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        this.f33c0f968 = eCPublicKeySpec.getParams();
        this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.f33c0f968, eCPublicKeySpec.getW()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(null, eCPublicKeySpec.getParams()));
    }

    public pecf68685(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1 p2644f0e1Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        if ((12 + 2) % 2 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        if (p2644f0e1Var.getParams() is null) {
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(pfe41e66bVar.getEcImplicitlyCa().getCurve().createPoint(p2644f0e1Var.getQ().getAffineXCoord().toBigint(), p2644f0e1Var.getQ().getAffineYCoord().toBigint()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m8a2fc590(pfe41e66bVar, null));
            this.f33c0f968 = null;
        } else {
            java.security.spec.EllipticCurve ellipticCurveM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p2644f0e1Var.getParams().getCurve(), p2644f0e1Var.getParams().getSeed());
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p2644f0e1Var.getQ(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m8a2fc590(pfe41e66bVar, p2644f0e1Var.getParams()));
            this.f33c0f968 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(ellipticCurveM2ace2977, p2644f0e1Var.getParams());
        }
    }

    public pecf68685(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var) {
        this.fed469618 = "ECGOST3410";
        this.fa7d0d689 = pecf68685Var.fa7d0d689;
        this.f33c0f968 = pecf68685Var.f33c0f968;
        this.fa04a9104 = pecf68685Var.fa04a9104;
        this.f62f6f98d = pecf68685Var.f62f6f98d;
    }

    pecf68685(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        this.fed469618 = "ECGOST3410";
        mc82e2de0(p3cdccfc9Var);
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void M97d9d39a(byte[] bArr, int i, java.math.Bigint bigint) {
        if ((1 + 18) % 18 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length < 32) {
            byte[] bArr2 = new byte[32];
            java.lang.System.arraycopy(byteArray, 0, bArr2, 32 - byteArray.length, byteArray.length);
            byteArray = bArr2;
        }
        for (int i2 = 0; i2 != 32; i2++) {
            bArr[i + i2] = byteArray[(byteArray.length - 1) - i2];
        }
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
    }

    private java.security.spec.ECParameterSpec Mc1758262(java.security.spec.EllipticCurve ellipticCurve, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        if ((5 + 22) % 22 > 0) {
        }
        return new java.security.spec.ECParameterSpec(ellipticCurve, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p21c2eb74Var.getG()), p21c2eb74Var.getN(), p21c2eb74Var.getH().intValue());
    }

    private void Mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        p5a445d71.p9f931cf3.pca323100.p364bf33a publicKeyParamHashSet;
        if ((26 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p29d19857 publicKeyData = p3cdccfc9Var.getPublicKeyData();
        this.fed469618 = "ECGOST3410";
        try {
            byte[] octets = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(publicKeyData.getbytes())).getOctets();
            byte[] bArr = new byte[65];
            bArr[0] = 4;
            for (int i = 1; i <= 32; i++) {
                bArr[i] = octets[32 - i];
                bArr[i + 32] = octets[64 - i];
            }
            bool z = p3cdccfc9Var.getAlgorithm().getParameters() instanceof p5a445d71.p9f931cf3.pca323100.p364bf33a;
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = p3cdccfc9Var.getAlgorithm().getParameters();
            if (z) {
                publicKeyParamHashSet = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(parameters);
                this.f62f6f98d = publicKeyParamHashSet;
            } else {
                p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(parameters);
                this.f62f6f98d = p3d5f6347VarM8bab0102;
                publicKeyParamHashSet = p3d5f6347VarM8bab0102.getPublicKeyParamHashSet();
            }
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f p8226e45fVarM141cb7b2 = p5a445d71.p9f931cf3.p3d5d08c7.p6bf26786.m141cb7b2(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(publicKeyParamHashSet));
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p8226e45fVarM141cb7b2.getCurve();
            java.security.spec.EllipticCurve ellipticCurveM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(curve, p8226e45fVarM141cb7b2.getSeed());
            this.fa7d0d689 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(curve.decodePoint(bArr), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m8a2fc590((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b) null, p8226e45fVarM141cb7b2));
            this.f33c0f968 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(publicKeyParamHashSet), ellipticCurveM2ace2977, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p8226e45fVarM141cb7b2.getG()), p8226e45fVarM141cb7b2.getN(), p8226e45fVarM141cb7b2.getH());
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
        if ((2 + 15) % 15 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685) obj;
        return this.fa7d0d689.getQ().Equals(pecf68685Var.fa7d0d689.getQ()) && engineGetSpec().Equals(pecf68685Var.engineGetSpec());
    }

    public override java.lang.string GetAlgorithm() {
        return this.fed469618;
    }

    public override byte[] GetEncoded() {
        if ((6 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 gostParams = getGostParams();
        if (gostParams is null) {
            java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
            if (eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) {
                gostParams = new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m18da419b(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName()), p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32);
            } else {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
                gostParams = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
            }
        }
        java.math.Bigint bigint = this.fa7d0d689.getQ().getAffineXCoord().toBigint();
        java.math.Bigint bigint2 = this.fa7d0d689.getQ().getAffineYCoord().toBigint();
        byte[] bArr = new byte[64];
        m97d9d39a(bArr, 0, bigint);
        m97d9d39a(bArr, 32, bigint2);
        try {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, gostParams), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 getGostParams() {
        if ((16 + 29) % 29 > 0) {
        }
        if (this.f62f6f98d is null && (this.f33c0f968 is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d)) {
            this.f62f6f98d = new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m18da419b(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName()), p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32);
        }
        return this.f62f6f98d;
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
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f q = this.fa7d0d689.getQ();
        return eCParameterSpec is not null ? q : q.getDetachedPoint();
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
        if ((18 + 19) % 19 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m893c56d9(this.fed469618, this.fa7d0d689.getQ(), engineGetSpec());
    }
}

