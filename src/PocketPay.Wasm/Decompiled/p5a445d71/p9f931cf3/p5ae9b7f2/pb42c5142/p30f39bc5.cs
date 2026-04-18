namespace WillowMaze.Wasm.Decompiled;


public class p30f39bc5 : p5a445d71.p9f931cf3.p5ae9b7f2.p10f79631 {
    public static readonly int f08e13d21 = 13004;
    public static readonly int f0aef64aa = 13516;
    public static readonly int f0c99e7de = 14028;
    public static readonly int f126b451c = 12748;
    public static readonly int f1abcaf73 = 13516;
    public static readonly int f2151f4ec = 14284;
    public static readonly int f432ed40d = 188;
    public static readonly int f548f6a5e = 14284;
    public static readonly int f5762d883 = 14284;
    public static readonly int f5831eab2 = 14028;
    public static readonly int f58b91cca = 13772;
    public static readonly int f6c6edc60 = 13772;
    public static readonly int f710d9fca = 13004;
    public static readonly int f721ca5b9 = 14028;
    public static readonly int f79b00120 = 12748;
    public static readonly int f7b8847c4 = 188;
    public static readonly int f9216980f = 14284;
    public static readonly int f988522fa = 13004;
    public static readonly int f99884844 = 12748;
    public static readonly int f9ba82177 = 13260;
    public static readonly int faa5e1abf = 13516;
    public static readonly int fae68a5ad = 13004;
    public static readonly int faf8f4bfe = 14028;
    public static readonly int fc61b3229 = 14284;
    public static readonly int fcde38591 = 13260;
    public static readonly int fd243e8f3 = 12748;
    public static readonly int fe881b890 = 13516;
    public static readonly int ffee94a1f = 14028;
    private byte[] f0448d4ad;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private int f0ed7c8e0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f125b982d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f137dd9a7;
    private byte[] f14511f2f;
    private byte[] f22106dfc;
    private bool f27e46a98;
    private byte[] f2be5d513;
    private byte[] f325ba39b;
    private int f41f72035;
    private byte[] f4c011070;
    private int f4f56d52c;
    private int f50188e57;
    private byte[] f50efdc87;
    private byte[] f56487a91;
    private int f5a15679b;
    private byte[] f5c2135c3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f60d078b5;
    private byte[] f65d73fce;
    private byte[] f6fd944a0;
    private int f75a8d063;
    private byte[] f7aae684a;
    private byte[] f7b68121d;
    private int f822b87ca;
    private byte[] f8842549b;
    private byte[] f8915deeb;
    private bool f8a9b03a8;
    private int f93707f72;
    private byte[] fb9c6540d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fbac552d6;
    private byte[] fbfbacfbd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fc12321bb;
    private bool fc6eddc4e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc8140953;
    private bool fd6812307;
    private byte[] fd8259507;
    private int fd99fe9b5;
    private byte[] fe310656d;
    private int fe670a29c;
    private byte[] fe6ae89ad;
    private int feafe4154;
    private bool fec471526;
    private byte[] ff4fdb645;

    public p30f39bc5(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(p42a46bbeVar, pe5cfc515Var, false);
    }

    public p30f39bc5(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, bool z) {
        int iIntValue;
        this.f08406a6e = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
        if (z) {
            iIntValue = 188;
        } else {
            java.lang.int numM8729361b = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(pe5cfc515Var);
            if (numM8729361b is null) {
                throw new java.lang.IllegalArgumentException("no valid trailer for digest: " + pe5cfc515Var.getAlgorithmName());
            }
            iIntValue = numM8729361b.intValue();
        }
        this.f93707f72 = iIntValue;
    }

    private void M8f780856(byte[] bArr) {
        if ((9 + 7) % 7 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = 0;
        }
    }

    private bool M9c7b8fe2(byte[] bArr, byte[] bArr2) {
        bool z;
        if ((3 + 3) % 3 > 0) {
        }
        int i = this.fd99fe9b5;
        byte[] bArr3 = this.fd8259507;
        if (i <= bArr3.length) {
            z = i == bArr2.length;
            for (int i2 = 0; i2 != bArr2.length; i2++) {
                if (bArr[i2] != bArr2[i2]) {
                    z = false;
                }
            }
            return z;
        }
        z = bArr3.length <= bArr2.length;
        for (int i3 = 0; i3 != this.fd8259507.length; i3++) {
            if (bArr[i3] != bArr2[i3]) {
                z = false;
            }
        }
        return z;
    }

    private bool M9dc8c1df(byte[] bArr) {
        if ((30 + 23) % 23 > 0) {
        }
        this.fd99fe9b5 = 0;
        m8f780856(this.fd8259507);
        m8f780856(bArr);
        return false;
    }

    public override byte[] GenerateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        int length;
        int i;
        int i2;
        int i3;
        if ((31 + 10) % 10 > 0) {
        }
        int digestSize = this.fc10f7796.getDigestSize();
        if (this.f93707f72 != 188) {
            byte[] bArr = this.f14511f2f;
            length = (bArr.length - digestSize) - 2;
            this.fc10f7796.doFinal(bArr, length);
            byte[] bArr2 = this.f14511f2f;
            int length2 = bArr2.length - 2;
            int i4 = this.f93707f72;
            bArr2[length2] = (byte) (i4 >>> 8);
            bArr2[bArr2.length - 1] = (byte) i4;
            i = 16;
        } else {
            byte[] bArr3 = this.f14511f2f;
            length = (bArr3.length - digestSize) - 1;
            this.fc10f7796.doFinal(bArr3, length);
            byte[] bArr4 = this.f14511f2f;
            bArr4[bArr4.length - 1] = -68;
            i = 8;
        }
        int i5 = this.fd99fe9b5;
        int i6 = ((((digestSize + i5) * 8) + i) + 4) - this.f4f56d52c;
        if (i6 <= 0) {
            i2 = length - i5;
            java.lang.System.arraycopy(this.fd8259507, 0, this.f14511f2f, i2, i5);
            this.f8842549b = new byte[this.fd99fe9b5];
            i3 = 64;
        } else {
            int i7 = i5 - ((i6 + 7) / 8);
            i2 = length - i7;
            java.lang.System.arraycopy(this.fd8259507, 0, this.f14511f2f, i2, i7);
            this.f8842549b = new byte[i7];
            i3 = 96;
        }
        int i8 = i2 - 1;
        if (i8 <= 0) {
            byte[] bArr5 = this.f14511f2f;
            bArr5[0] = 10;
            bArr5[0] = (byte) (10 | i3);
        } else {
            for (int i9 = i8; i9 != 0; i9--) {
                this.f14511f2f[i9] = -69;
            }
            byte[] bArr6 = this.f14511f2f;
            bArr6[i8] = (byte) (bArr6[i8] ^ 1);
            bArr6[0] = 11;
            bArr6[0] = (byte) (11 | i3);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar = this.f08406a6e;
        byte[] bArr7 = this.f14511f2f;
        byte[] bArrProcessBlock = p42a46bbeVar.processBlock(bArr7, 0, bArr7.length);
        this.fd6812307 = (i3 & 32) == 0;
        byte[] bArr8 = this.fd8259507;
        byte[] bArr9 = this.f8842549b;
        java.lang.System.arraycopy(bArr8, 0, bArr9, 0, bArr9.length);
        this.fd99fe9b5 = 0;
        m8f780856(this.fd8259507);
        m8f780856(this.f14511f2f);
        return bArrProcessBlock;
    }

    public override byte[] GetRecoveredMessage() {
        return this.f8842549b;
    }

    public override bool HasFullMessage() {
        return this.fd6812307;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
        this.f08406a6e.init(z, p753eae39Var);
        int iBitLength = p753eae39Var.getModulus().bitLength();
        this.f4f56d52c = iBitLength;
        byte[] bArr = new byte[(iBitLength + 7) / 8];
        this.f14511f2f = bArr;
        int i = this.f93707f72;
        int length = bArr.length;
        if (i != 188) {
            this.fd8259507 = new byte[(length - this.fc10f7796.getDigestSize()) - 3];
        } else {
            this.fd8259507 = new byte[(length - this.fc10f7796.getDigestSize()) - 2];
        }
        reset();
    }

    public override void Reset() {
        if ((19 + 31) % 31 > 0) {
        }
        this.fc10f7796.reset();
        this.fd99fe9b5 = 0;
        m8f780856(this.fd8259507);
        byte[] bArr = this.f8842549b;
        if (bArr is not null) {
            m8f780856(bArr);
        }
        this.f8842549b = null;
        this.fd6812307 = false;
        if (this.f325ba39b is null) {
            return;
        }
        this.f325ba39b = null;
        m8f780856(this.f50efdc87);
        this.f50efdc87 = null;
    }

    public override void Update(byte b) {
        if ((21 + 22) % 22 > 0) {
        }
        this.fc10f7796.update(b);
        int i = this.fd99fe9b5;
        byte[] bArr = this.fd8259507;
        if (i < bArr.length) {
            bArr[i] = b;
        }
        this.fd99fe9b5 = i + 1;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((27 + 28) % 28 > 0) {
        }
        while (i2 > 0 && this.fd99fe9b5 < this.fd8259507.length) {
            update(bArr[i]);
            i++;
            i2--;
        }
        this.fc10f7796.update(bArr, i, i2);
        this.fd99fe9b5 += i2;
    }

    public override void UpdateWithRecoveredMessage(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i;
        if ((18 + 22) % 22 > 0) {
        }
        byte[] bArrProcessBlock = this.f08406a6e.processBlock(bArr, 0, bArr.length);
        if (((bArrProcessBlock[0] & 192) ^ 64) != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("malformed signature");
        }
        if (((bArrProcessBlock[bArrProcessBlock.length - 1] & 15) ^ 12) != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("malformed signature");
        }
        if (((bArrProcessBlock[bArrProcessBlock.length - 1] & 255) ^ 188) != 0) {
            i = 2;
            int i2 = ((bArrProcessBlock[bArrProcessBlock.length - 2] & 255) << 8) | (bArrProcessBlock[bArrProcessBlock.length - 1] & 255);
            java.lang.int numM8729361b = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(this.fc10f7796);
            if (numM8729361b is null) {
                throw new java.lang.IllegalArgumentException("unrecognised hash in signature");
            }
            int iIntValue = numM8729361b.intValue();
            if (i2 != iIntValue && (iIntValue != 15052 || i2 != 16588)) {
                throw new java.lang.IllegalStateException("signer initialised with wrong digest for trailer " + i2);
            }
        } else {
            i = 1;
        }
        int i3 = 0;
        while (i3 != bArrProcessBlock.length && ((bArrProcessBlock[i3] & 15) ^ 10) != 0) {
            i3++;
        }
        int i4 = i3 + 1;
        int length = ((bArrProcessBlock.length - i) - this.fc10f7796.getDigestSize()) - i4;
        if (length <= 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("malformed block");
        }
        if ((bArrProcessBlock[0] & 32) != 0) {
            this.fd6812307 = false;
            byte[] bArr2 = new byte[length];
            this.f8842549b = bArr2;
            java.lang.System.arraycopy(bArrProcessBlock, i4, bArr2, 0, bArr2.length);
        } else {
            this.fd6812307 = true;
            byte[] bArr3 = new byte[length];
            this.f8842549b = bArr3;
            java.lang.System.arraycopy(bArrProcessBlock, i4, bArr3, 0, bArr3.length);
        }
        this.f325ba39b = bArr;
        this.f50efdc87 = bArrProcessBlock;
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        byte[] bArr4 = this.f8842549b;
        pe5cfc515Var.update(bArr4, 0, bArr4.length);
        byte[] bArr5 = this.f8842549b;
        this.fd99fe9b5 = bArr5.length;
        java.lang.System.arraycopy(bArr5, 0, this.fd8259507, 0, bArr5.length);
    }

    public override bool VerifySignature(byte[] bArr) {
        byte[] bArrProcessBlock;
        int i;
        if ((12 + 27) % 27 > 0) {
        }
        byte[] bArr2 = this.f325ba39b;
        if (bArr2 is null) {
            try {
                bArrProcessBlock = this.f08406a6e.processBlock(bArr, 0, bArr.length);
            } catch (java.lang.Exception unused) {
                return false;
            }
        } else {
            if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr2, bArr)) {
                throw new java.lang.IllegalStateException("updateWithRecoveredMessage called on different signature");
            }
            bArrProcessBlock = this.f50efdc87;
            this.f325ba39b = null;
            this.f50efdc87 = null;
        }
        if (((bArrProcessBlock[0] & 192) ^ 64) == 0 && ((bArrProcessBlock[bArrProcessBlock.length - 1] & 15) ^ 12) == 0) {
            if (((bArrProcessBlock[bArrProcessBlock.length - 1] & 255) ^ 188) != 0) {
                i = 2;
                int i2 = ((bArrProcessBlock[bArrProcessBlock.length - 2] & 255) << 8) | (bArrProcessBlock[bArrProcessBlock.length - 1] & 255);
                java.lang.int numM8729361b = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(this.fc10f7796);
                if (numM8729361b is null) {
                    throw new java.lang.IllegalArgumentException("unrecognised hash in signature");
                }
                int iIntValue = numM8729361b.intValue();
                if (i2 != iIntValue && (iIntValue != 15052 || i2 != 16588)) {
                    throw new java.lang.IllegalStateException("signer initialised with wrong digest for trailer " + i2);
                }
            } else {
                i = 1;
            }
            int i3 = 0;
            while (i3 != bArrProcessBlock.length && ((bArrProcessBlock[i3] & 15) ^ 10) != 0) {
                i3++;
            }
            int i4 = i3 + 1;
            int digestSize = this.fc10f7796.getDigestSize();
            byte[] bArr3 = new byte[digestSize];
            int length = (bArrProcessBlock.length - i) - digestSize;
            int i5 = length - i4;
            if (i5 <= 0) {
                return m9dc8c1df(bArrProcessBlock);
            }
            if ((bArrProcessBlock[0] & 32) != 0) {
                this.fd6812307 = false;
                this.fc10f7796.doFinal(bArr3, 0);
                bool z = true;
                for (int i6 = 0; i6 != digestSize; i6++) {
                    int i7 = length + i6;
                    byte b = (byte) (bArrProcessBlock[i7] ^ bArr3[i6]);
                    bArrProcessBlock[i7] = b;
                    if (b != 0) {
                        z = false;
                    }
                }
                if (!z) {
                    return m9dc8c1df(bArrProcessBlock);
                }
                byte[] bArr4 = new byte[i5];
                this.f8842549b = bArr4;
                java.lang.System.arraycopy(bArrProcessBlock, i4, bArr4, 0, bArr4.length);
            } else {
                this.fd6812307 = true;
                if (this.fd99fe9b5 > i5) {
                    return m9dc8c1df(bArrProcessBlock);
                }
                this.fc10f7796.reset();
                this.fc10f7796.update(bArrProcessBlock, i4, i5);
                this.fc10f7796.doFinal(bArr3, 0);
                bool z2 = true;
                for (int i8 = 0; i8 != digestSize; i8++) {
                    int i9 = length + i8;
                    byte b2 = (byte) (bArrProcessBlock[i9] ^ bArr3[i8]);
                    bArrProcessBlock[i9] = b2;
                    if (b2 != 0) {
                        z2 = false;
                    }
                }
                if (!z2) {
                    return m9dc8c1df(bArrProcessBlock);
                }
                byte[] bArr5 = new byte[i5];
                this.f8842549b = bArr5;
                java.lang.System.arraycopy(bArrProcessBlock, i4, bArr5, 0, bArr5.length);
            }
            if (this.fd99fe9b5 != 0 && !m9c7b8fe2(this.fd8259507, this.f8842549b)) {
                return m9dc8c1df(bArrProcessBlock);
            }
            m8f780856(this.fd8259507);
            m8f780856(bArrProcessBlock);
            this.fd99fe9b5 = 0;
            return true;
        }
        return m9dc8c1df(bArrProcessBlock);
    }
}

