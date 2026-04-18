namespace WillowMaze.Wasm.Decompiled;


public class pc7bcd95d : java.security.interfaces.ECPublicKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    private java.security.spec.ECParameterSpec f1af2cd90;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f24477236;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f2ccea0ac;
    private java.security.spec.ECParameterSpec f33c0f968;
    private java.lang.string f518324ca;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f62f6f98d;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f6323b875;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f69e08dee;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f7694f4a6;
    private java.lang.string f7a8d8a85;
    private java.lang.string f7b29c210;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f8982043f;
    private java.lang.string f9776b15c;
    private bool fa04a9104;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 fa54d9e92;
    private bool fb6392984;
    private java.security.spec.ECParameterSpec fc5780ed2;
    private java.lang.string fed469618;

    public pc7bcd95d(java.lang.string str, java.security.spec.ECPublicKeySpec eCPublicKeySpec) {
        this.fed469618 = str;
        java.security.spec.ECParameterSpec params = eCPublicKeySpec.getParams();
        this.f33c0f968 = params;
        this.f7694f4a6 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(params, eCPublicKeySpec.getW());
    }

    public pc7bcd95d(java.lang.string str, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d pc7bcd95dVar) {
        this.fed469618 = str;
        this.f7694f4a6 = pc7bcd95dVar.f7694f4a6;
        this.f33c0f968 = pc7bcd95dVar.f33c0f968;
        this.fa04a9104 = pc7bcd95dVar.fa04a9104;
        this.f62f6f98d = pc7bcd95dVar.f62f6f98d;
    }

    public pc7bcd95d(java.lang.string str, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p2644f0e1 p2644f0e1Var) {
        java.security.spec.ECParameterSpec eCParameterSpecMce32677e;
        this.fed469618 = str;
        this.f7694f4a6 = p2644f0e1Var.getQ();
        if (p2644f0e1Var.getParams() is null) {
            if (this.f7694f4a6.getCurve() is null) {
                this.f7694f4a6 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getCurve().createPoint(this.f7694f4a6.getAffineXCoord().toBigint(), this.f7694f4a6.getAffineYCoord().toBigint());
            }
            eCParameterSpecMce32677e = null;
        } else {
            eCParameterSpecMce32677e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p2644f0e1Var.getParams().getCurve(), p2644f0e1Var.getParams().getSeed()), p2644f0e1Var.getParams());
        }
        this.f33c0f968 = eCParameterSpecMce32677e;
    }

    public pc7bcd95d(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        this.fed469618 = str;
        this.f7694f4a6 = pd16c2d8eVar.getQ();
        this.f33c0f968 = null;
    }

    public pc7bcd95d(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, java.security.spec.ECParameterSpec eCParameterSpec) {
        this.fed469618 = "EC";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.f7694f4a6 = pd16c2d8eVar.getQ();
        if (eCParameterSpec is not null) {
            this.f33c0f968 = eCParameterSpec;
        } else {
            this.f33c0f968 = mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
        }
    }

    public pc7bcd95d(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        this.fed469618 = "EC";
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = pd16c2d8eVar.getParameters();
        this.fed469618 = str;
        this.f7694f4a6 = pd16c2d8eVar.getQ();
        this.f33c0f968 = p835df581Var is not null ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p835df581Var) : mc1758262(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), parameters);
    }

    public pc7bcd95d(java.security.interfaces.ECPublicKey eCPublicKey) {
        this.fed469618 = "EC";
        this.fed469618 = eCPublicKey.getAlgorithm();
        java.security.spec.ECParameterSpec params = eCPublicKey.getParams();
        this.f33c0f968 = params;
        this.f7694f4a6 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(params, eCPublicKey.getW());
    }

    pc7bcd95d(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        this.fed469618 = "EC";
        mc82e2de0(p3cdccfc9Var);
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(getEncoded());
        objectStream.writeobject(this.fed469618);
        objectStream.writebool(this.fa04a9104);
    }

    private void M97d9d39a(byte[] bArr, int i, java.math.Bigint bigint) {
        if ((11 + 27) % 27 > 0) {
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

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
        this.fed469618 = (java.lang.string) objectStream.readobject();
        this.fa04a9104 = objectStream.readbool();
    }

    private java.security.spec.ECParameterSpec Mc1758262(java.security.spec.EllipticCurve ellipticCurve, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        if ((12 + 8) % 8 > 0) {
        }
        return new java.security.spec.ECParameterSpec(ellipticCurve, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p21c2eb74Var.getG()), p21c2eb74Var.getN(), p21c2eb74Var.getH().intValue());
    }

    private void Mc82e2de0(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve;
        if ((22 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 algorithm = p3cdccfc9Var.getAlgorithm();
        if (algorithm.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c)) {
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
                p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(algorithm.getParameters());
                this.f62f6f98d = p3d5f6347VarM8bab0102;
                p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f p8226e45fVarM141cb7b2 = p5a445d71.p9f931cf3.p3d5d08c7.p6bf26786.m141cb7b2(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet()));
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve2 = p8226e45fVarM141cb7b2.getCurve();
                java.security.spec.EllipticCurve ellipticCurveM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(curve2, p8226e45fVarM141cb7b2.getSeed());
                this.f7694f4a6 = curve2.decodePoint(bArr);
                this.f33c0f968 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(this.f62f6f98d.getPublicKeyParamHashSet()), ellipticCurveM2ace2977, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p8226e45fVarM141cb7b2.getG()), p8226e45fVarM141cb7b2.getN(), p8226e45fVarM141cb7b2.getH());
                return;
            } catch (java.io.IOException unused) {
                throw new java.lang.IllegalArgumentException("error recovering public key");
            }
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(algorithm.getParameters());
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) p15be22c4VarM8bab0102.getParameters();
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVar);
            curve = p35e46fcbVarMf7b916f7.getCurve();
            this.f33c0f968 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m6720e003(p364bf33aVar), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(curve, p35e46fcbVarMf7b916f7.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarMf7b916f7.getG()), p35e46fcbVarMf7b916f7.getN(), p35e46fcbVarMf7b916f7.getH());
        } else if (p15be22c4VarM8bab0102.isImplicitlyCA()) {
            this.f33c0f968 = null;
            curve = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getCurve();
        } else {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            curve = p35e46fcbVarM8bab0102.getCurve();
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(curve, p35e46fcbVarM8bab0102.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH().intValue());
        }
        byte[] bytes = p3cdccfc9Var.getPublicKeyData().getbytes();
        p5a445d71.p9f931cf3.pca323100.p11b04310 p6f0e511cVar = new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bytes);
        if (bytes[0] == 4 && bytes[1] == bytes.length - 2) {
            byte b = bytes[2];
            if ((b == 2 || b == 3) && new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5().getbyteLength(curve) >= bytes.length - 3) {
                try {
                    p6f0e511cVar = (p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bytes);
                } catch (java.io.IOException unused2) {
                    throw new java.lang.IllegalArgumentException("error recovering public key");
                }
            }
        }
        this.f7694f4a6 = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(curve, p6f0e511cVar).getPoint();
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f EngineGetQ() {
        return this.f7694f4a6;
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 7) % 7 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d)) {
            return false;
        }
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d pc7bcd95dVar = (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d) obj;
        return engineGetQ().Equals(pc7bcd95dVar.engineGetQ()) && engineGetSpec().Equals(pc7bcd95dVar.engineGetSpec());
    }

    public override java.lang.string GetAlgorithm() {
        return this.fed469618;
    }

    public override byte[] GetEncoded() {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var;
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var;
        if ((12 + 7) % 7 > 0) {
        }
        if (this.fed469618.Equals("ECGOST3410")) {
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p3d5f6347Var = this.f62f6f98d;
            if (p3d5f6347Var is null) {
                java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
                if (eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) {
                    p3d5f6347Var = new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m18da419b(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName()), p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32);
                } else {
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
                    p3d5f6347Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
                }
            }
            java.math.Bigint bigint = this.f7694f4a6.getAffineXCoord().toBigint();
            java.math.Bigint bigint2 = this.f7694f4a6.getAffineYCoord().toBigint();
            byte[] bArr = new byte[64];
            m97d9d39a(bArr, 0, bigint);
            m97d9d39a(bArr, 32, bigint2);
            try {
                p3cdccfc9Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, p3d5f6347Var), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr));
            } catch (java.io.IOException unused) {
                return null;
            }
        } else {
            java.security.spec.ECParameterSpec eCParameterSpec2 = this.f33c0f968;
            if (eCParameterSpec2 is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec2).getName());
                if (p364bf33aVarM9a2b7f82 is null) {
                    p364bf33aVarM9a2b7f82 = new p5a445d71.p9f931cf3.pca323100.p364bf33a(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName());
                }
                p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p364bf33aVarM9a2b7f82);
            } else if (eCParameterSpec2 is not null) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace29772 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec2.getCurve());
                p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace29772, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace29772, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
            } else {
                p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
            }
            p3cdccfc9Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p15be22c4Var), getQ().getEncoded(this.fa04a9104));
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(p3cdccfc9Var);
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
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = this.f7694f4a6;
        return eCParameterSpec is not null ? p53a5793fVar : p53a5793fVar.getDetachedPoint();
    }

    public override java.security.spec.ECPoint GetW() {
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(this.f7694f4a6);
    }

    public int HashCode() {
        return engineGetSpec().GetHashCode() ^ engineGetQ().GetHashCode();
    }

    public override void SetPointFormat(java.lang.string str) {
        this.fa04a9104 = !"UNCOMPRESSED".equalsIgnoreCase(str);
    }

    public java.lang.string Tostring() {
        if ((31 + 29) % 29 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("EC Public Key");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(strM2295b6f1);
        stringBuffer.append("            X: ").append(this.f7694f4a6.getAffineXCoord().toBigint().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("            Y: ").append(this.f7694f4a6.getAffineYCoord().toBigint().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

