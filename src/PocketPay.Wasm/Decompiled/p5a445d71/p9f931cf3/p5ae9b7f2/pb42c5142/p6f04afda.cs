namespace WillowMaze.Wasm.Decompiled;


public class p6f04afda : p5a445d71.p9f931cf3.p5ae9b7f2.p10f79631 {
    public static readonly int f07d6700c = 13772;
    public static readonly int f08e13d21 = 13004;
    public static readonly int f1abcaf73 = 13516;
    public static readonly int f21d9a77e = 12748;
    public static readonly int f37430381 = 188;
    public static readonly int f5e4f02a2 = 188;
    public static readonly int f6c6edc60 = 13772;
    public static readonly int f7b8847c4 = 188;
    public static readonly int f7e9e86e7 = 14028;
    public static readonly int f8a9d0f50 = 12748;
    public static readonly int f8c183a64 = 13772;
    public static readonly int f8ddef47b = 13516;
    public static readonly int f96b553f1 = 14028;
    public static readonly int f9770fa28 = 13516;
    public static readonly int f99884844 = 12748;
    public static readonly int fa021d47b = 14284;
    public static readonly int fa7884ffa = 13516;
    public static readonly int fab224db0 = 13260;
    public static readonly int fb98e38f1 = 14284;
    public static readonly int fbaaebb58 = 13772;
    public static readonly int fbe0331b8 = 12748;
    public static readonly int fbf2e0442 = 13004;
    public static readonly int fc61b3229 = 14284;
    public static readonly int fcde38591 = 13260;
    public static readonly int fd3a8b1f6 = 188;
    public static readonly int fd96f7492 = 14028;
    public static readonly int fdf0092d7 = 188;
    public static readonly int fe47cbd2e = 14028;
    public static readonly int fe73fd05d = 13516;
    public static readonly int fea9135f3 = 13004;
    public static readonly int ffdf74f1f = 13772;
    public static readonly int ffee94a1f = 14028;
    private byte[] f017f6a4a;
    private int f0272308c;
    private byte[] f0491c007;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    private byte[] f0f080cbe;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f0f087f0f;
    private byte[] f14511f2f;
    private int f1c1adb07;
    private byte[] f1c942747;
    private int f1fb21d86;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f20196cda;
    private bool f2c5f6112;
    private int f31151962;
    private int f315bc4de;
    private int f323751b7;
    private byte[] f325ba39b;
    private int f3a61ed44;
    private byte[] f4735c06e;
    private int f4bebe16f;
    private byte[] f4bfa4ef3;
    private int f4f56d52c;
    private byte[] f50e8b548;
    private byte[] f50efdc87;
    private byte[] f57c45264;
    private int f6bbc970a;
    private int f6bbcafe7;
    private java.security.SecureRandom f77903dca;
    private java.security.SecureRandom f7ddf32e1;
    private int f7e6d50ee;
    private int f7eafeb2d;
    private bool f7f3cb99f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f827be603;
    private byte[] f859f6a25;
    private byte[] f8842549b;
    private byte[] f88c88cd7;
    private byte[] f8ce4457a;
    private int f93707f72;
    private int f96b942ad;
    private byte[] f9ca9ac17;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fa2506d6c;
    private int fab1427ae;
    private int fac1b04b1;
    private int fb0013e59;
    private bool fb74a73db;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fbb0c9ad0;
    private byte[] fbe20c896;
    private int fbe5fa681;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private bool fc6d73de6;
    private bool fd6812307;
    private byte[] fd8259507;
    private int fd99fe9b5;
    private byte[] fdbdd0289;
    private int fe61807d2;
    private byte[] fe7288c7a;
    private byte[] ff0eeb357;
    private int ff10ebc17;
    private byte[] ffe539f44;
    private java.security.SecureRandom fff3834a3;

    public p6f04afda(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        this(p42a46bbeVar, pe5cfc515Var, i, false);
    }

    public p6f04afda(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, bool z) {
        int iIntValue;
        this.f08406a6e = p42a46bbeVar;
        this.fc10f7796 = pe5cfc515Var;
        this.fb0013e59 = pe5cfc515Var.getDigestSize();
        this.f7e6d50ee = i;
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

    private void M634ed66f(int i, byte[] bArr) {
        bArr[0] = (byte) (i >>> 24);
        bArr[1] = (byte) (i >>> 16);
        bArr[2] = (byte) (i >>> 8);
        bArr[3] = (byte) i;
    }

    private void M8f780856(byte[] bArr) {
        if ((3 + 28) % 28 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            bArr[i] = 0;
        }
    }

    private void M93e7d2df(long j, byte[] bArr) {
        if ((22 + 16) % 16 > 0) {
        }
        bArr[0] = (byte) (j >>> 56);
        bArr[1] = (byte) (j >>> 48);
        bArr[2] = (byte) (j >>> 40);
        bArr[3] = (byte) (j >>> 32);
        bArr[4] = (byte) (j >>> 24);
        bArr[5] = (byte) (j >>> 16);
        bArr[6] = (byte) (j >>> 8);
        bArr[7] = (byte) j;
    }

    private bool M9c7b8fe2(byte[] bArr, byte[] bArr2) {
        if ((19 + 18) % 18 > 0) {
        }
        bool z = this.fd99fe9b5 == bArr2.length;
        for (int i = 0; i != bArr2.length; i++) {
            if (bArr[i] != bArr2[i]) {
                z = false;
            }
        }
        return z;
    }

    private byte[] Maafcb7af(byte[] bArr, int i, int i2, int i3) {
        int i4;
        if ((32 + 2) % 2 > 0) {
        }
        byte[] bArr2 = new byte[i3];
        byte[] bArr3 = new byte[this.fb0013e59];
        byte[] bArr4 = new byte[4];
        this.fc10f7796.reset();
        int i5 = 0;
        while (true) {
            i4 = this.fb0013e59;
            if (i5 >= i3 / i4) {
                break;
            }
            m634ed66f(i5, bArr4);
            this.fc10f7796.update(bArr, i, i2);
            this.fc10f7796.update(bArr4, 0, 4);
            this.fc10f7796.doFinal(bArr3, 0);
            int i6 = this.fb0013e59;
            java.lang.System.arraycopy(bArr3, 0, bArr2, i5 * i6, i6);
            i5++;
        }
        if (i4 * i5 < i3) {
            m634ed66f(i5, bArr4);
            this.fc10f7796.update(bArr, i, i2);
            this.fc10f7796.update(bArr4, 0, 4);
            this.fc10f7796.doFinal(bArr3, 0);
            int i7 = this.fb0013e59;
            java.lang.System.arraycopy(bArr3, 0, bArr2, i5 * i7, i3 - (i5 * i7));
        }
        return bArr2;
    }

    public override byte[] GenerateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((15 + 12) % 12 > 0) {
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr = new byte[digestSize];
        this.fc10f7796.doFinal(bArr, 0);
        byte[] bArr2 = new byte[8];
        m93e7d2df(this.fd99fe9b5 * 8, bArr2);
        this.fc10f7796.update(bArr2, 0, 8);
        this.fc10f7796.update(this.fd8259507, 0, this.fd99fe9b5);
        this.fc10f7796.update(bArr, 0, digestSize);
        byte[] bArr3 = this.ff0eeb357;
        if (bArr3 is null) {
            bArr3 = new byte[this.f7e6d50ee];
            this.f7ddf32e1.nextbytes(bArr3);
        }
        this.fc10f7796.update(bArr3, 0, bArr3.length);
        int digestSize2 = this.fc10f7796.getDigestSize();
        byte[] bArr4 = new byte[digestSize2];
        this.fc10f7796.doFinal(bArr4, 0);
        int i = this.f93707f72 != 188 ? 2 : 1;
        byte[] bArr5 = this.f14511f2f;
        int length = bArr5.length;
        int i2 = this.fd99fe9b5;
        int length2 = (((length - i2) - bArr3.length) - this.fb0013e59) - i;
        bArr5[length2 - 1] = 1;
        java.lang.System.arraycopy(this.fd8259507, 0, bArr5, length2, i2);
        java.lang.System.arraycopy(bArr3, 0, this.f14511f2f, length2 + this.fd99fe9b5, bArr3.length);
        byte[] bArrMaafcb7af = maafcb7af(bArr4, 0, digestSize2, (this.f14511f2f.length - this.fb0013e59) - i);
        for (int i3 = 0; i3 != bArrMaafcb7af.length; i3++) {
            byte[] bArr6 = this.f14511f2f;
            bArr6[i3] = (byte) (bArr6[i3] ^ bArrMaafcb7af[i3]);
        }
        byte[] bArr7 = this.f14511f2f;
        int length3 = bArr7.length;
        int i4 = this.fb0013e59;
        java.lang.System.arraycopy(bArr4, 0, bArr7, (length3 - i4) - i, i4);
        int i5 = this.f93707f72;
        if (i5 != 188) {
            byte[] bArr8 = this.f14511f2f;
            bArr8[bArr8.length - 2] = (byte) (i5 >>> 8);
            bArr8[bArr8.length - 1] = (byte) i5;
        } else {
            byte[] bArr9 = this.f14511f2f;
            bArr9[bArr9.length - 1] = -68;
        }
        byte[] bArr10 = this.f14511f2f;
        bArr10[0] = (byte) (bArr10[0] & 127);
        byte[] bArrProcessBlock = this.f08406a6e.processBlock(bArr10, 0, bArr10.length);
        int i6 = this.fd99fe9b5;
        byte[] bArr11 = new byte[i6];
        this.f8842549b = bArr11;
        byte[] bArr12 = this.fd8259507;
        this.fd6812307 = i6 <= bArr12.length;
        java.lang.System.arraycopy(bArr12, 0, bArr11, 0, bArr11.length);
        m8f780856(this.fd8259507);
        m8f780856(this.f14511f2f);
        this.fd99fe9b5 = 0;
        return bArrProcessBlock;
    }

    public override byte[] GetRecoveredMessage() {
        return this.f8842549b;
    }

    public override bool HasFullMessage() {
        return this.fd6812307;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var;
        java.security.SecureRandom secureRandomM07091bf1;
        if ((14 + 5) % 5 > 0) {
        }
        int length = this.f7e6d50ee;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            p753eae39Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) p4715f007Var.getParameters();
            if (z) {
                secureRandomM07091bf1 = p4715f007Var.getRandom();
                this.f7ddf32e1 = secureRandomM07091bf1;
            }
        } else if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p120db2b8) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p120db2b8 p120db2b8Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p120db2b8) pc9ef6b45Var;
            p753eae39Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) p120db2b8Var.getParameters();
            byte[] salt = p120db2b8Var.getSalt();
            this.ff0eeb357 = salt;
            length = salt.length;
            if (salt.length != this.f7e6d50ee) {
                throw new java.lang.IllegalArgumentException("Fixed salt is of wrong length");
            }
        } else {
            p753eae39Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
            if (z) {
                secureRandomM07091bf1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
                this.f7ddf32e1 = secureRandomM07091bf1;
            }
        }
        this.f08406a6e.init(z, p753eae39Var);
        int iBitLength = p753eae39Var.getModulus().bitLength();
        this.f4f56d52c = iBitLength;
        byte[] bArr = new byte[(iBitLength + 7) / 8];
        this.f14511f2f = bArr;
        int i = this.f93707f72;
        int length2 = bArr.length;
        if (i != 188) {
            this.fd8259507 = new byte[((length2 - this.fc10f7796.getDigestSize()) - length) - 3];
        } else {
            this.fd8259507 = new byte[((length2 - this.fc10f7796.getDigestSize()) - length) - 2];
        }
        reset();
    }

    public override void Reset() {
        if ((6 + 24) % 24 > 0) {
        }
        this.fc10f7796.reset();
        this.fd99fe9b5 = 0;
        byte[] bArr = this.fd8259507;
        if (bArr is not null) {
            m8f780856(bArr);
        }
        byte[] bArr2 = this.f8842549b;
        if (bArr2 is not null) {
            m8f780856(bArr2);
            this.f8842549b = null;
        }
        this.fd6812307 = false;
        if (this.f325ba39b is null) {
            return;
        }
        this.f325ba39b = null;
        m8f780856(this.f50efdc87);
        this.f50efdc87 = null;
    }

    public override void Update(byte b) {
        if ((21 + 25) % 25 > 0) {
        }
        if (this.f325ba39b is null) {
            int i = this.fd99fe9b5;
            byte[] bArr = this.fd8259507;
            if (i < bArr.length) {
                this.fd99fe9b5 = i + 1;
                bArr[i] = b;
                return;
            }
        }
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((22 + 14) % 14 > 0) {
        }
        if (this.f325ba39b is null) {
            while (i2 > 0 && this.fd99fe9b5 < this.fd8259507.length) {
                update(bArr[i]);
                i++;
                i2--;
            }
        }
        if (i2 <= 0) {
            return;
        }
        this.fc10f7796.update(bArr, i, i2);
    }

    public override void UpdateWithRecoveredMessage(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i;
        if ((9 + 10) % 10 > 0) {
        }
        byte[] bArrProcessBlock = this.f08406a6e.processBlock(bArr, 0, bArr.length);
        int length = bArrProcessBlock.length;
        int i2 = this.f4f56d52c;
        if (length < (i2 + 7) / 8) {
            int i3 = (i2 + 7) / 8;
            byte[] bArr2 = new byte[i3];
            java.lang.System.arraycopy(bArrProcessBlock, 0, bArr2, i3 - bArrProcessBlock.length, bArrProcessBlock.length);
            m8f780856(bArrProcessBlock);
            bArrProcessBlock = bArr2;
        }
        if (((bArrProcessBlock[bArrProcessBlock.length - 1] & 255) ^ 188) != 0) {
            i = 2;
            int i4 = ((bArrProcessBlock[bArrProcessBlock.length - 2] & 255) << 8) | (bArrProcessBlock[bArrProcessBlock.length - 1] & 255);
            java.lang.int numM8729361b = p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.p78369c04.m8729361b(this.fc10f7796);
            if (numM8729361b is null) {
                throw new java.lang.IllegalArgumentException("unrecognised hash in signature");
            }
            int iIntValue = numM8729361b.intValue();
            if (i4 != iIntValue && (iIntValue != 15052 || i4 != 16588)) {
                throw new java.lang.IllegalStateException("signer initialised with wrong digest for trailer " + i4);
            }
        } else {
            i = 1;
        }
        this.fc10f7796.doFinal(new byte[this.fb0013e59], 0);
        int length2 = bArrProcessBlock.length;
        int i5 = this.fb0013e59;
        byte[] bArrMaafcb7af = maafcb7af(bArrProcessBlock, (length2 - i5) - i, i5, (bArrProcessBlock.length - i5) - i);
        for (int i6 = 0; i6 != bArrMaafcb7af.length; i6++) {
            bArrProcessBlock[i6] = (byte) (bArrProcessBlock[i6] ^ bArrMaafcb7af[i6]);
        }
        bArrProcessBlock[0] = (byte) (bArrProcessBlock[0] & 127);
        int i7 = 0;
        while (i7 != bArrProcessBlock.length && bArrProcessBlock[i7] != 1) {
            i7++;
        }
        int i8 = i7 + 1;
        if (i8 >= bArrProcessBlock.length) {
            m8f780856(bArrProcessBlock);
        }
        this.fd6812307 = i8 > 1;
        byte[] bArr3 = new byte[(bArrMaafcb7af.length - i8) - this.f7e6d50ee];
        this.f8842549b = bArr3;
        java.lang.System.arraycopy(bArrProcessBlock, i8, bArr3, 0, bArr3.length);
        byte[] bArr4 = this.f8842549b;
        java.lang.System.arraycopy(bArr4, 0, this.fd8259507, 0, bArr4.length);
        this.f325ba39b = bArr;
        this.f50efdc87 = bArrProcessBlock;
        this.fbe5fa681 = i8;
        this.fab1427ae = i;
    }

    public override bool VerifySignature(byte[] bArr) {
        if ((30 + 7) % 7 > 0) {
        }
        int i = this.fb0013e59;
        byte[] bArr2 = new byte[i];
        this.fc10f7796.doFinal(bArr2, 0);
        byte[] bArr3 = this.f325ba39b;
        if (bArr3 is null) {
            try {
                updateWithRecoveredMessage(bArr);
            } catch (java.lang.Exception unused) {
                return false;
            }
        } else if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr3, bArr)) {
            throw new java.lang.IllegalStateException("updateWithRecoveredMessage called on different signature");
        }
        byte[] bArr4 = this.f50efdc87;
        int i2 = this.fbe5fa681;
        int i3 = this.fab1427ae;
        this.f325ba39b = null;
        this.f50efdc87 = null;
        byte[] bArr5 = new byte[8];
        m93e7d2df(this.f8842549b.length * 8, bArr5);
        this.fc10f7796.update(bArr5, 0, 8);
        byte[] bArr6 = this.f8842549b;
        if (bArr6.length != 0) {
            this.fc10f7796.update(bArr6, 0, bArr6.length);
        }
        this.fc10f7796.update(bArr2, 0, i);
        byte[] bArr7 = this.ff0eeb357;
        if (bArr7 is null) {
            this.fc10f7796.update(bArr4, i2 + this.f8842549b.length, this.f7e6d50ee);
        } else {
            this.fc10f7796.update(bArr7, 0, bArr7.length);
        }
        int digestSize = this.fc10f7796.getDigestSize();
        byte[] bArr8 = new byte[digestSize];
        this.fc10f7796.doFinal(bArr8, 0);
        int length = (bArr4.length - i3) - digestSize;
        bool z = true;
        for (int i4 = 0; i4 != digestSize; i4++) {
            if (bArr8[i4] != bArr4[length + i4]) {
                z = false;
            }
        }
        m8f780856(bArr4);
        m8f780856(bArr8);
        if (!z) {
            this.fd6812307 = false;
            this.fd99fe9b5 = 0;
            m8f780856(this.f8842549b);
            return false;
        }
        if (this.fd99fe9b5 == 0 || m9c7b8fe2(this.fd8259507, this.f8842549b)) {
            this.fd99fe9b5 = 0;
            m8f780856(this.fd8259507);
            return true;
        }
        this.fd99fe9b5 = 0;
        m8f780856(this.fd8259507);
        return false;
    }
}

