namespace WillowMaze.Wasm.Decompiled;


public class p85d33963 : p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 f15a174cb;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 f36f12594;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5a6b556f f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5a6b556f f4db67f2e;
    private java.security.SecureRandom f6a2fceb4;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fabeef833;
    private java.security.SecureRandom fbfa58257;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5a6b556f fdfbfec68;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 fe7eafe1c;

    public p85d33963() {
        this.fe7eafe1c = new p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pd449b1b7();
    }

    public p85d33963(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbd7aaca5 pbd7aaca5Var) {
        this.fe7eafe1c = pbd7aaca5Var;
    }

    private java.math.Bigint M3fc46678(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        if ((30 + 19) % 19 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(7, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(secureRandom)).Add(java.math.Bigint.valueOf(128L)).multiply(bigint);
    }

    private java.math.Bigint Mdf265527(java.math.Bigint bigint, byte[] bArr) {
        if ((31 + 23) % 23 > 0) {
        }
        if (bigint.bitLength() >= bArr.length * 8) {
            return new java.math.Bigint(1, bArr);
        }
        int iBitLength = bigint.bitLength() / 8;
        byte[] bArr2 = new byte[iBitLength];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, iBitLength);
        return new java.math.Bigint(1, bArr2);
    }

    public override java.math.Bigint[] GenerateSignature(byte[] bArr) {
        if ((4 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd parameters = this.f3c6e0b8a.getParameters();
        java.math.Bigint q = parameters.getQ();
        java.math.Bigint bigintMdf265527 = mdf265527(q, bArr);
        java.math.Bigint x = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) this.f3c6e0b8a).getX();
        if (this.fe7eafe1c.isDeterministic()) {
            this.fe7eafe1c.init(q, x, bArr);
        } else {
            this.fe7eafe1c.init(q, this.f7ddf32e1);
        }
        java.math.Bigint bigintNextK = this.fe7eafe1c.nextK();
        java.math.Bigint bigintMod = parameters.getG().modPow(bigintNextK.Add(m3fc46678(q, this.f7ddf32e1)), parameters.getP()).mod(q);
        java.math.Bigint bigintMod2 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m635f3861(q, bigintNextK).multiply(bigintMdf265527.Add(x.multiply(bigintMod))).mod(q);
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintMod;
        bigintArr[1] = bigintMod2;
        return bigintArr;
    }

    public override java.math.Bigint GetOrder() {
        return this.f3c6e0b8a.getParameters().getQ();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5a6b556f p5a6b556fVar;
        java.security.SecureRandom random;
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
                this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) p4715f007Var.getParameters();
                random = p4715f007Var.getRandom();
            } else {
                p5a6b556fVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) pc9ef6b45Var;
            }
            this.f7ddf32e1 = initSecureRandom((z || this.fe7eafe1c.isDeterministic()) ? false : true, random);
        }
        p5a6b556fVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a) pc9ef6b45Var;
        this.f3c6e0b8a = p5a6b556fVar;
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
        if ((14 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd parameters = this.f3c6e0b8a.getParameters();
        java.math.Bigint q = parameters.getQ();
        java.math.Bigint bigintMdf265527 = mdf265527(q, bArr);
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(0L);
        if (bigintValueOf.compareTo(bigint) >= 0 || q.compareTo(bigint) <= 0 || bigintValueOf.compareTo(bigint2) >= 0 || q.compareTo(bigint2) <= 0) {
            return false;
        }
        java.math.Bigint bigintMe90945d8 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.me90945d8(q, bigint2);
        java.math.Bigint bigintMod = bigintMdf265527.multiply(bigintMe90945d8).mod(q);
        java.math.Bigint bigintMod2 = bigint.multiply(bigintMe90945d8).mod(q);
        java.math.Bigint p = parameters.getP();
        return parameters.getG().modPow(bigintMod, p).multiply(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a) this.f3c6e0b8a).getY().modPow(bigintMod2, p)).mod(p).mod(q).Equals(bigint);
    }
}

