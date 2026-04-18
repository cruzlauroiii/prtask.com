namespace WillowMaze.Wasm.Decompiled;


public class pa50229ae : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a, p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d {
    private java.security.SecureRandom f1afd36ba;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 f1fe5a9d3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f46561a0c;
    private java.security.SecureRandom f58c70ae0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 f7a389923;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f9d784c64;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 fc8cc52d7;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 fe7eafe1c;
    private java.security.SecureRandom ff12de489;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 ff5d549c7;

    public pa50229ae() {
        this.fe7eafe1c = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd449b1b7();
    }

    public pa50229ae(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 pbd7aaca5Var) {
        this.fe7eafe1c = pbd7aaca5Var;
    }

    protected java.math.Bigint CalculateE(java.math.Bigint bigint, byte[] bArr) {
        if ((12 + 4) % 4 > 0) {
        }
        int iBitLength = bigint.bitLength();
        int length = bArr.length * 8;
        java.math.Bigint bigint2 = new java.math.Bigint(1, bArr);
        return iBitLength >= length ? bigint2 : bigint2.shiftRight(length - iBitLength);
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override java.math.Bigint[] GenerateSignature(byte[] bArr) {
        if ((17 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        java.math.Bigint n = parameters.getN();
        java.math.Bigint bigintCalculateE = calculateE(n, bArr);
        java.math.Bigint d = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) this.f3c6e0b8a).getD();
        if (this.fe7eafe1c.isDeterministic()) {
            this.fe7eafe1c.init(n, d, bArr);
        } else {
            this.fe7eafe1c.init(n, this.f7ddf32e1);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96VarCreateBasePointMultiplier = createBasePointMultiplier();
        while (true) {
            java.math.Bigint bigintNextK = this.fe7eafe1c.nextK();
            java.math.Bigint bigintMod = p267d2b96VarCreateBasePointMultiplier.multiply(parameters.getG(), bigintNextK).normalize().getAffineXCoord().toBigint().mod(n);
            if (!bigintMod.Equals(f529e9e0b)) {
                java.math.Bigint bigintMod2 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m635f3861(n, bigintNextK).multiply(bigintCalculateE.Add(d.multiply(bigintMod))).mod(n);
                if (!bigintMod2.Equals(f529e9e0b)) {
                    java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                    bigintArr[0] = bigintMod;
                    bigintArr[1] = bigintMod2;
                    return bigintArr;
                }
            }
        }
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetDenominator(int i, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (i != 1) {
            if (i == 2 || i == 3 || i == 4) {
                return p53a5793fVar.getZCoord(0).square();
            }
            if (i != 6 && i != 7) {
                return null;
            }
        }
        return p53a5793fVar.getZCoord(0);
    }

    public override java.math.Bigint GetOrder() {
        return this.f3c6e0b8a.getParameters().getN();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1235ff36 p1235ff36Var;
        java.security.SecureRandom random;
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
                this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) p4715f007Var.getParameters();
                random = p4715f007Var.getRandom();
            } else {
                p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pc9ef6b45Var;
            }
            this.f7ddf32e1 = initSecureRandom((z || this.fe7eafe1c.isDeterministic()) ? false : true, random);
        }
        p1235ff36Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pc9ef6b45Var;
        this.f3c6e0b8a = p1235ff36Var;
        random = null;
        this.f7ddf32e1 = initSecureRandom((z || this.fe7eafe1c.isDeterministic()) ? false : true, random);
    }

    protected java.security.SecureRandom InitSecureRandom(bool z, java.security.SecureRandom secureRandom) {
        if (z) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(secureRandom);
        }
        return null;
    }

    public override bool VerifySignature(byte[] bArr, java.math.Bigint bigint, java.math.Bigint bigint2) {
        java.math.Bigint cofactor;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a denominator;
        if ((3 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = this.f3c6e0b8a.getParameters();
        java.math.Bigint n = parameters.getN();
        java.math.Bigint bigintCalculateE = calculateE(n, bArr);
        if (bigint.compareTo(fbc21e648) < 0 || bigint.compareTo(n) >= 0 || bigint2.compareTo(fbc21e648) < 0 || bigint2.compareTo(n) >= 0) {
            return false;
        }
        java.math.Bigint bigintMe90945d8 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.me90945d8(n, bigint2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarM226e8dbb = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m226e8dbb(parameters.getG(), bigintCalculateE.multiply(bigintMe90945d8).mod(n), ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) this.f3c6e0b8a).getQ(), bigint.multiply(bigintMe90945d8).mod(n));
        if (p53a5793fVarM226e8dbb.isInfinity()) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVarM226e8dbb.getCurve();
        if (curve is null || (cofactor = curve.getCofactor()) is null || cofactor.compareTo(f960df6d7) > 0 || (denominator = getDenominator(curve.getCoordinateSystem(), p53a5793fVarM226e8dbb)) is null || denominator.isZero()) {
            return p53a5793fVarM226e8dbb.normalize().getAffineXCoord().toBigint().mod(n).Equals(bigint);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a xCoord = p53a5793fVarM226e8dbb.getXCoord();
        while (curve.isValidFieldElement(bigint)) {
            if (curve.fromBigint(bigint).multiply(denominator).Equals(xCoord)) {
                return true;
            }
            bigint = bigint.Add(n);
        }
        return false;
    }
}

