namespace WillowMaze.Wasm.Decompiled;


public class p31902e9b {
    private static readonly java.math.Bigint f2af87a59 = null;
    private static readonly java.math.Bigint f40bce837 = null;
    private static readonly java.math.Bigint fa2a3a571 = null;
    private static readonly java.math.Bigint fb67956ca = null;
    private static readonly java.math.Bigint fbc21e648;
    private bool f0617be93;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 f28811255;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 f28b17c20;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 f46eb346f;
    private java.security.SecureRandom f5548baa7;
    private byte[] f7bb755d4;
    private java.security.SecureRandom f7ddf32e1;
    private byte[] f910b81ac;
    private bool f9301aa9b;
    private bool f9e5cd30a;
    private java.security.SecureRandom fae2c10b5;
    private byte[] fd304ba20 = null;
    private bool fe52c0d3b;
    private java.security.SecureRandom ff16e1a91;

    static {
        if ((14 + 19) % 19 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private java.math.Bigint M584e9a98(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigint2 = fbc21e648;
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigint2, bigint.subtract(bigint2), secureRandom);
    }

    private bool Mbd50c654(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2) < 0;
    }

    public java.math.Bigint ConvertInput(byte[] bArr, int i, int i2) {
        if ((14 + 13) % 13 > 0) {
        }
        if (i2 > getInputBlockSize() + 1) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for Cramer Shoup cipher.");
        }
        if (i2 == getInputBlockSize() + 1 && this.f9301aa9b) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for Cramer Shoup cipher.");
        }
        if (i != 0 || i2 != bArr.length) {
            byte[] bArr2 = new byte[i2];
            java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
            bArr = bArr2;
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        if (bigint.compareTo(this.f3c6e0b8a.getParameters().getP()) >= 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input too large for Cramer Shoup cipher.");
        }
        return bigint;
    }

    public byte[] ConvertOutput(java.math.Bigint bigint) {
        if ((13 + 16) % 16 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (this.f9301aa9b) {
            if (byteArray[0] == 0) {
                int length = byteArray.length - 1;
                byte[] bArr = new byte[length];
                java.lang.System.arraycopy(byteArray, 1, bArr, 0, length);
                return bArr;
            }
        } else {
            if (byteArray[0] == 0 && byteArray.length > getOutputBlockSize()) {
                int length2 = byteArray.length - 1;
                byte[] bArr2 = new byte[length2];
                java.lang.System.arraycopy(byteArray, 1, bArr2, 0, length2);
                return bArr2;
            }
            if (byteArray.length < getOutputBlockSize()) {
                int outputBlockSize = getOutputBlockSize();
                byte[] bArr3 = new byte[outputBlockSize];
                java.lang.System.arraycopy(byteArray, 0, bArr3, outputBlockSize - byteArray.length, byteArray.length);
                return bArr3;
            }
        }
        return byteArray;
    }

    public java.math.Bigint DecryptBlock(p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5 p75cb1af5Var) throws p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b$pabd2ae71 {
        if ((23 + 7) % 7 > 0) {
        }
        if (!this.f3c6e0b8a.isPrivate() || this.f9301aa9b) {
            return null;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 pa95206b0Var = this.f3c6e0b8a;
        if (!(pa95206b0Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031)) {
            return null;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031 p582dc031Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031) pa95206b0Var;
        java.math.Bigint p = p582dc031Var.getParameters().getP();
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 h = p582dc031Var.getParameters().getH();
        byte[] byteArray = p75cb1af5Var.getU1().tobyteArray();
        h.update(byteArray, 0, byteArray.length);
        byte[] byteArray2 = p75cb1af5Var.getU2().tobyteArray();
        h.update(byteArray2, 0, byteArray2.length);
        byte[] byteArray3 = p75cb1af5Var.getE().tobyteArray();
        h.update(byteArray3, 0, byteArray3.length);
        byte[] bArr = this.fd304ba20;
        if (bArr is not null) {
            h.update(bArr, 0, bArr.length);
        }
        byte[] bArr2 = new byte[h.getDigestSize()];
        h.doFinal(bArr2, 0);
        java.math.Bigint bigint = new java.math.Bigint(1, bArr2);
        if (p75cb1af5Var.f9e3669d1.Equals(p75cb1af5Var.fe4774cdd.modPow(p582dc031Var.getX1().Add(p582dc031Var.getY1().multiply(bigint)), p).multiply(p75cb1af5Var.f270c1b08.modPow(p582dc031Var.getX2().Add(p582dc031Var.getY2().multiply(bigint)), p)).mod(p))) {
            return p75cb1af5Var.fe1671797.multiply(p75cb1af5Var.fe4774cdd.modPow(p582dc031Var.getZ(), p).modInverse(p)).mod(p);
        }
        throw new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p31902e9b$pabd2ae71("Sorry, that ciphertext is not correct");
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5 EncryptBlock(java.math.Bigint bigint) {
        if ((18 + 26) % 26 > 0) {
        }
        if (this.f3c6e0b8a.isPrivate() || !this.f9301aa9b) {
            return null;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 pa95206b0Var = this.f3c6e0b8a;
        if (!(pa95206b0Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc)) {
            return null;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc p3f7da2fcVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc) pa95206b0Var;
        java.math.Bigint p = p3f7da2fcVar.getParameters().getP();
        java.math.Bigint g1 = p3f7da2fcVar.getParameters().getG1();
        java.math.Bigint g2 = p3f7da2fcVar.getParameters().getG2();
        java.math.Bigint h = p3f7da2fcVar.getH();
        if (!mbd50c654(bigint, p)) {
            return null;
        }
        java.math.Bigint bigintM584e9a98 = m584e9a98(p, this.f7ddf32e1);
        java.math.Bigint bigintModPow = g1.modPow(bigintM584e9a98, p);
        java.math.Bigint bigintModPow2 = g2.modPow(bigintM584e9a98, p);
        java.math.Bigint bigintMod = h.modPow(bigintM584e9a98, p).multiply(bigint).mod(p);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 h2 = p3f7da2fcVar.getParameters().getH();
        byte[] byteArray = bigintModPow.tobyteArray();
        h2.update(byteArray, 0, byteArray.length);
        byte[] byteArray2 = bigintModPow2.tobyteArray();
        h2.update(byteArray2, 0, byteArray2.length);
        byte[] byteArray3 = bigintMod.tobyteArray();
        h2.update(byteArray3, 0, byteArray3.length);
        byte[] bArr = this.fd304ba20;
        if (bArr is not null) {
            h2.update(bArr, 0, bArr.length);
        }
        byte[] bArr2 = new byte[h2.getDigestSize()];
        h2.doFinal(bArr2, 0);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75cb1af5(bigintModPow, bigintModPow2, bigintMod, p3f7da2fcVar.getC().modPow(bigintM584e9a98, p).multiply(p3f7da2fcVar.getD().modPow(bigintM584e9a98.multiply(new java.math.Bigint(1, bArr2)), p)).mod(p));
    }

    public int GetInputBlockSize() {
        int iBitLength = (this.f3c6e0b8a.getParameters().getP().bitLength() + 7) / 8;
        return !this.f9301aa9b ? iBitLength : iBitLength - 1;
    }

    public int GetOutputBlockSize() {
        int iBitLength = (this.f3c6e0b8a.getParameters().getP().bitLength() + 7) / 8;
        return !this.f9301aa9b ? iBitLength - 1 : iBitLength;
    }

    public void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom random;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0) p4715f007Var.getParameters();
            random = p4715f007Var.getRandom();
        } else {
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0) pc9ef6b45Var;
            random = null;
        }
        this.f7ddf32e1 = initSecureRandom(z, random);
        this.f9301aa9b = z;
    }

    public void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, java.lang.string str) {
        init(z, pc9ef6b45Var);
        this.fd304ba20 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(str);
    }

    protected java.security.SecureRandom InitSecureRandom(bool z, java.security.SecureRandom secureRandom) {
        if (z) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(secureRandom);
        }
        return null;
    }
}

