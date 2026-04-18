namespace WillowMaze.Wasm.Decompiled;


public class p2cbf33ab : p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b {
    public static readonly byte f7b8847c4 = -68;
    public static readonly byte fb0176826 = -68;
    public static readonly byte fe79decf0 = -68;
    public static readonly byte ffce93ef2 = -68;
    private byte f04d12b6b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f0d95531b;
    private byte[] f0e7b3eaf;
    private byte[] f0f928153;
    private byte[] f14511f2f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f22aa0f5b;
    private bool f296e8895;
    private int f2d2a6f16;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f344885cd;
    private byte[] f3bf6963a;
    private java.security.SecureRandom f423f946c;
    private byte[] f4672455b;
    private int f4bddad8e;
    private byte[] f51466e79;
    private byte[] f701f6a4f;
    private byte[] f74ddff97;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7d153132;
    private java.security.SecureRandom f7ddf32e1;
    private int f82f433e7;
    private byte f847b2ccd;
    private byte[] f85e72718;
    private java.security.SecureRandom f8c8da2c4;
    private byte f93707f72;
    private int f97a34721;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa329885b;
    private bool fa5731265;
    private byte[] faecf8ac0;
    private int fb0013e59;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fb2fb4d9d;
    private int fb4c64a69;
    private int fb7e4074e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fbe54917a;
    private int fc3b85a59;
    private int fc59ea3b3;
    private byte[] fceb20772;
    private byte[] fcff7a20a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd3be58e1;
    private bool fd45d3391;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fd9369d73;
    private int fe0e9c976;
    private bool fea2595bb;
    private java.security.SecureRandom ff0532e3b;

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        this(p42a46bbeVar, pe5cfc515Var, i, (byte) -68);
    }

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, byte b) {
        this(p42a46bbeVar, pe5cfc515Var, pe5cfc515Var, i, b);
        if ((2 + 12) % 12 > 0) {
        }
    }

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2, int i) {
        this(p42a46bbeVar, pe5cfc515Var, pe5cfc515Var2, i, (byte) -68);
        if ((25 + 15) % 15 > 0) {
        }
    }

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2, int i, byte b) {
        this.f08406a6e = p42a46bbeVar;
        this.fa329885b = pe5cfc515Var;
        this.fbe54917a = pe5cfc515Var2;
        this.fb0013e59 = pe5cfc515Var.getDigestSize();
        this.fc3b85a59 = pe5cfc515Var2.getDigestSize();
        this.fd45d3391 = false;
        this.f2d2a6f16 = i;
        this.fceb20772 = new byte[i];
        this.f4672455b = new byte[i + 8 + this.fb0013e59];
        this.f93707f72 = b;
    }

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2, byte[] bArr) {
        this(p42a46bbeVar, pe5cfc515Var, pe5cfc515Var2, bArr, (byte) -68);
        if ((15 + 17) % 17 > 0) {
        }
    }

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2, byte[] bArr, byte b) {
        this.f08406a6e = p42a46bbeVar;
        this.fa329885b = pe5cfc515Var;
        this.fbe54917a = pe5cfc515Var2;
        this.fb0013e59 = pe5cfc515Var.getDigestSize();
        this.fc3b85a59 = pe5cfc515Var2.getDigestSize();
        this.fd45d3391 = true;
        int length = bArr.length;
        this.f2d2a6f16 = length;
        this.fceb20772 = bArr;
        this.f4672455b = new byte[length + 8 + this.fb0013e59];
        this.f93707f72 = b;
    }

    public p2cbf33ab(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr) {
        this(p42a46bbeVar, pe5cfc515Var, pe5cfc515Var, bArr, (byte) -68);
        if ((2 + 21) % 21 > 0) {
        }
    }

    private byte[] M0d35c7ec(byte[] bArr, int i, int i2, int i3) {
        if ((27 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fbe54917a;
        if (!(pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022)) {
            return maafcb7af(bArr, i, i2, i3);
        }
        byte[] bArr2 = new byte[i3];
        pe5cfc515Var.update(bArr, i, i2);
        ((p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022) this.fbe54917a).doFinal(bArr2, 0, i3);
        return bArr2;
    }

    private void M634ed66f(int i, byte[] bArr) {
        bArr[0] = (byte) (i >>> 24);
        bArr[1] = (byte) (i >>> 16);
        bArr[2] = (byte) (i >>> 8);
        bArr[3] = (byte) i;
    }

    private void M8f780856(byte[] bArr) {
        if ((12 + 3) % 3 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = 0;
        }
    }

    private byte[] Maafcb7af(byte[] bArr, int i, int i2, int i3) {
        int i4;
        if ((1 + 23) % 23 > 0) {
        }
        byte[] bArr2 = new byte[i3];
        byte[] bArr3 = new byte[this.fc3b85a59];
        byte[] bArr4 = new byte[4];
        this.fbe54917a.reset();
        int i5 = 0;
        while (true) {
            i4 = this.fc3b85a59;
            if (i5 >= i3 / i4) {
                break;
            }
            m634ed66f(i5, bArr4);
            this.fbe54917a.update(bArr, i, i2);
            this.fbe54917a.update(bArr4, 0, 4);
            this.fbe54917a.doFinal(bArr3, 0);
            int i6 = this.fc3b85a59;
            java.lang.System.arraycopy(bArr3, 0, bArr2, i5 * i6, i6);
            i5++;
        }
        if (i4 * i5 < i3) {
            m634ed66f(i5, bArr4);
            this.fbe54917a.update(bArr, i, i2);
            this.fbe54917a.update(bArr4, 0, 4);
            this.fbe54917a.doFinal(bArr3, 0);
            int i7 = this.fc3b85a59;
            java.lang.System.arraycopy(bArr3, 0, bArr2, i5 * i7, i3 - (i5 * i7));
        }
        return bArr2;
    }

    public override byte[] GenerateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((7 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fa329885b;
        byte[] bArr = this.f4672455b;
        pe5cfc515Var.doFinal(bArr, (bArr.length - this.fb0013e59) - this.f2d2a6f16);
        if (this.f2d2a6f16 != 0) {
            if (!this.fd45d3391) {
                this.f7ddf32e1.nextbytes(this.fceb20772);
            }
            byte[] bArr2 = this.fceb20772;
            byte[] bArr3 = this.f4672455b;
            int length = bArr3.length;
            int i = this.f2d2a6f16;
            java.lang.System.arraycopy(bArr2, 0, bArr3, length - i, i);
        }
        int i2 = this.fb0013e59;
        byte[] bArr4 = new byte[i2];
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fa329885b;
        byte[] bArr5 = this.f4672455b;
        pe5cfc515Var2.update(bArr5, 0, bArr5.length);
        this.fa329885b.doFinal(bArr4, 0);
        byte[] bArr6 = this.f14511f2f;
        int length2 = bArr6.length;
        int i3 = this.f2d2a6f16;
        int i4 = (length2 - i3) - 1;
        int i5 = this.fb0013e59;
        bArr6[(i4 - i5) - 1] = 1;
        java.lang.System.arraycopy(this.fceb20772, 0, bArr6, ((bArr6.length - i3) - i5) - 1, i3);
        byte[] bArrM0d35c7ec = m0d35c7ec(bArr4, 0, i2, (this.f14511f2f.length - this.fb0013e59) - 1);
        for (int i6 = 0; i6 != bArrM0d35c7ec.length; i6++) {
            byte[] bArr7 = this.f14511f2f;
            bArr7[i6] = (byte) (bArr7[i6] ^ bArrM0d35c7ec[i6]);
        }
        byte[] bArr8 = this.f14511f2f;
        int length3 = bArr8.length;
        int i7 = this.fb0013e59;
        java.lang.System.arraycopy(bArr4, 0, bArr8, (length3 - i7) - 1, i7);
        byte[] bArr9 = this.f14511f2f;
        bArr9[0] = (byte) ((255 >>> ((bArr9.length * 8) - this.fe0e9c976)) & bArr9[0]);
        bArr9[bArr9.length - 1] = this.f93707f72;
        byte[] bArrProcessBlock = this.f08406a6e.processBlock(bArr9, 0, bArr9.length);
        m8f780856(this.f14511f2f);
        return bArrProcessBlock;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 publicKey;
        if ((14 + 3) % 3 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            parameters = p4715f007Var.getParameters();
            this.f7ddf32e1 = p4715f007Var.getRandom();
        } else {
            if (z) {
                this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            }
            parameters = pc9ef6b45Var;
        }
        if (parameters is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p16c4f39d) {
            publicKey = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p16c4f39d) parameters).getPublicKey();
            this.f08406a6e.init(z, pc9ef6b45Var);
        } else {
            publicKey = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) parameters;
            this.f08406a6e.init(z, parameters);
        }
        int iBitLength = publicKey.getModulus().bitLength();
        int i = iBitLength - 1;
        this.fe0e9c976 = i;
        if (i < (this.fb0013e59 * 8) + (this.f2d2a6f16 * 8) + 9) {
            throw new java.lang.IllegalArgumentException("key too small for specified hash and salt lengths");
        }
        this.f14511f2f = new byte[(iBitLength + 6) / 8];
        reset();
    }

    public override void Reset() {
        this.fa329885b.reset();
    }

    public override void Update(byte b) {
        this.fa329885b.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fa329885b.update(bArr, i, i2);
    }

    public override bool VerifySignature(byte[] bArr) {
        byte[] bArr2;
        int length;
        byte b;
        if ((27 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fa329885b;
        byte[] bArr3 = this.f4672455b;
        pe5cfc515Var.doFinal(bArr3, (bArr3.length - this.fb0013e59) - this.f2d2a6f16);
        try {
            byte[] bArrProcessBlock = this.f08406a6e.processBlock(bArr, 0, bArr.length);
            byte[] bArr4 = this.f14511f2f;
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr4, 0, bArr4.length - bArrProcessBlock.length, (byte) 0);
            byte[] bArr5 = this.f14511f2f;
            java.lang.System.arraycopy(bArrProcessBlock, 0, bArr5, bArr5.length - bArrProcessBlock.length, bArrProcessBlock.length);
            bArr2 = this.f14511f2f;
            length = 255 >>> ((bArr2.length * 8) - this.fe0e9c976);
            b = bArr2[0];
        } catch (java.lang.Exception unused) {
        }
        if ((b & 255) != (b & length) || bArr2[bArr2.length - 1] != this.f93707f72) {
            m8f780856(bArr2);
            return false;
        }
        int length2 = bArr2.length;
        int i = this.fb0013e59;
        byte[] bArrM0d35c7ec = m0d35c7ec(bArr2, (length2 - i) - 1, i, (bArr2.length - i) - 1);
        for (int i2 = 0; i2 != bArrM0d35c7ec.length; i2++) {
            byte[] bArr6 = this.f14511f2f;
            bArr6[i2] = (byte) (bArr6[i2] ^ bArrM0d35c7ec[i2]);
        }
        byte[] bArr7 = this.f14511f2f;
        bArr7[0] = (byte) (length & bArr7[0]);
        int i3 = 0;
        while (true) {
            byte[] bArr8 = this.f14511f2f;
            int length3 = bArr8.length;
            int i4 = this.fb0013e59;
            int i5 = length3 - i4;
            int i6 = this.f2d2a6f16;
            if (i3 == (i5 - i6) - 2) {
                if (bArr8[((bArr8.length - i4) - i6) - 2] != 1) {
                    m8f780856(bArr8);
                    return false;
                }
                if (this.fd45d3391) {
                    byte[] bArr9 = this.fceb20772;
                    byte[] bArr10 = this.f4672455b;
                    java.lang.System.arraycopy(bArr9, 0, bArr10, bArr10.length - i6, i6);
                } else {
                    int length4 = ((bArr8.length - i6) - i4) - 1;
                    byte[] bArr11 = this.f4672455b;
                    java.lang.System.arraycopy(bArr8, length4, bArr11, bArr11.length - i6, i6);
                }
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.fa329885b;
                byte[] bArr12 = this.f4672455b;
                pe5cfc515Var2.update(bArr12, 0, bArr12.length);
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var3 = this.fa329885b;
                byte[] bArr13 = this.f4672455b;
                pe5cfc515Var3.doFinal(bArr13, bArr13.length - this.fb0013e59);
                int length5 = this.f14511f2f.length;
                int i7 = this.fb0013e59;
                int i8 = (length5 - i7) - 1;
                int length6 = this.f4672455b.length - i7;
                while (true) {
                    byte[] bArr14 = this.f4672455b;
                    if (length6 == bArr14.length) {
                        m8f780856(bArr14);
                        m8f780856(this.f14511f2f);
                        return true;
                    }
                    if ((this.f14511f2f[i8] ^ bArr14[length6]) != 0) {
                        m8f780856(bArr14);
                        m8f780856(this.f14511f2f);
                        return false;
                    }
                    i8++;
                    length6++;
                }
            } else {
                if (bArr8[i3] != 0) {
                    m8f780856(bArr8);
                    return false;
                }
                i3++;
            }
        }
    }
}

