namespace WillowMaze.Wasm.Decompiled;


public class p9cd0c098 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7eacabf6 {
    private static readonly int f1331926c = -1894007588;
    private static readonly int f2aa016bd = 1859775393;
    private static readonly int f4582481e = 20;
    private static readonly int f5aefcaaf = 1518500249;
    private static readonly int f5c80cf3a = -899497514;
    private static readonly int f6d18ad0e = -899497514;
    private static readonly int f893b46f7 = -899497514;
    private static readonly int f9a6cd390 = -899497514;
    private static readonly int fa0b0e26e = 1518500249;
    private static readonly int fb9467af2 = 1859775393;
    private static readonly int fd3a3415a = 20;
    private static readonly int fd84cc73b = 1859775393;
    private static readonly int fdd52af28 = 1859775393;
    private static readonly int fe1266f9c = 1518500249;
    private static readonly int fe4551ab5 = -899497514;
    private static readonly int fe97f08a6 = -1894007588;
    private int[] f02129bb8;
    private int f106530dc;
    private int[] f18898cb1;
    private int f2f362fc4;
    private int f44e5a258;
    private int f5293d3a8;
    private int[] f5aee5a79;
    private int f6b57370b;
    private int f70c2f71e;
    private int f7163f70b;
    private int f805a8c7b;
    private int f83065208;
    private int f8482f5a7;
    private int f87f8c15c;
    private int f88c3300c;
    private int faaadb10a;
    private int fb1476321;
    private int fc5a8521a;
    private int fca2bf3f6;

    public p9cd0c098() {
        this.f02129bb8 = new int[80];
        reset();
    }

    public p9cd0c098(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098 p9cd0c098Var) {
        super(p9cd0c098Var);
        this.f02129bb8 = new int[80];
        me7efa710(p9cd0c098Var);
    }

    public p9cd0c098(byte[] bArr) {
        super(bArr);
        if ((6 + 23) % 23 > 0) {
        }
        this.f02129bb8 = new int[80];
        this.f106530dc = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 16);
        this.fca2bf3f6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 20);
        this.fb1476321 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 24);
        this.f6b57370b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 28);
        this.f83065208 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 32);
        this.fc5a8521a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 36);
        for (int i = 0; i != this.fc5a8521a; i++) {
            this.f02129bb8[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, (i * 4) + 40);
        }
    }

    private int M2510c390(int i, int i2, int i3) {
        return (i ^ i2) ^ i3;
    }

    private int M8fa14cdd(int i, int i2, int i3) {
        return (i & i2) | ((~i) & i3);
    }

    private int Mb2f5ff47(int i, int i2, int i3) {
        return ((i2 | i3) & i) | (i2 & i3);
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098 p9cd0c098Var) {
        if ((31 + 28) % 28 > 0) {
        }
        this.f106530dc = p9cd0c098Var.f106530dc;
        this.fca2bf3f6 = p9cd0c098Var.fca2bf3f6;
        this.fb1476321 = p9cd0c098Var.fb1476321;
        this.f6b57370b = p9cd0c098Var.f6b57370b;
        this.f83065208 = p9cd0c098Var.f83065208;
        int[] iArr = p9cd0c098Var.f02129bb8;
        java.lang.System.arraycopy(iArr, 0, this.f02129bb8, 0, iArr.length);
        this.fc5a8521a = p9cd0c098Var.fc5a8521a;
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((22 + 31) % 31 > 0) {
        }
        finish();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f106530dc, bArr, i);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fca2bf3f6, bArr, i + 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb1476321, bArr, i + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6b57370b, bArr, i + 12);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f83065208, bArr, i + 16);
        reset();
        return 20;
    }

    public override java.lang.string GetAlgorithmName() {
        return com.decryptstringmanager.Decryptstring.decryptstring("020260913e3888c059e442314cead19f18233d4406d5b48a62fb7e2b6ab8533e33");
    }

    public override int GetDigestSize() {
        return 20;
    }

    public override byte[] GetEncodedState() {
        if ((29 + 27) % 27 > 0) {
        }
        byte[] bArr = new byte[(this.fc5a8521a * 4) + 40];
        super.populateState(bArr);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f106530dc, bArr, 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fca2bf3f6, bArr, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb1476321, bArr, 24);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6b57370b, bArr, 28);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f83065208, bArr, 32);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fc5a8521a, bArr, 36);
        for (int i = 0; i != this.fc5a8521a; i++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[i], bArr, (i * 4) + 40);
        }
        return bArr;
    }

    protected override void ProcessBlock() {
        if ((31 + 31) % 31 > 0) {
        }
        for (int i = 16; i < 80; i++) {
            int[] iArr = this.f02129bb8;
            int i2 = ((iArr[i - 3] ^ iArr[i - 8]) ^ iArr[i - 14]) ^ iArr[i - 16];
            iArr[i] = (i2 >>> 31) | (i2 << 1);
        }
        int iM2510c390 = this.f106530dc;
        int iM2510c3902 = this.fca2bf3f6;
        int i3 = this.fb1476321;
        int i4 = this.f6b57370b;
        int i5 = this.f83065208;
        int i6 = 0;
        for (int i7 = 0; i7 < 4; i7++) {
            int i8 = i6 + 1;
            int iM8fa14cdd = i5 + ((iM2510c390 << 5) | (iM2510c390 >>> 27)) + m8fa14cdd(iM2510c3902, i3, i4) + this.f02129bb8[i6] + 1518500249;
            int i9 = (iM2510c3902 >>> 2) | (iM2510c3902 << 30);
            int i10 = i6 + 2;
            int iM8fa14cdd2 = i4 + ((iM8fa14cdd << 5) | (iM8fa14cdd >>> 27)) + m8fa14cdd(iM2510c390, i9, i3) + this.f02129bb8[i8] + 1518500249;
            int i11 = (iM2510c390 >>> 2) | (iM2510c390 << 30);
            int i12 = i6 + 3;
            int iM8fa14cdd3 = i3 + ((iM8fa14cdd2 << 5) | (iM8fa14cdd2 >>> 27)) + m8fa14cdd(iM8fa14cdd, i11, i9) + this.f02129bb8[i10] + 1518500249;
            i5 = (iM8fa14cdd >>> 2) | (iM8fa14cdd << 30);
            int i13 = i6 + 4;
            iM2510c3902 = i9 + ((iM8fa14cdd3 << 5) | (iM8fa14cdd3 >>> 27)) + m8fa14cdd(iM8fa14cdd2, i5, i11) + this.f02129bb8[i12] + 1518500249;
            i4 = (iM8fa14cdd2 >>> 2) | (iM8fa14cdd2 << 30);
            i6 += 5;
            iM2510c390 = i11 + ((iM2510c3902 << 5) | (iM2510c3902 >>> 27)) + m8fa14cdd(iM8fa14cdd3, i4, i5) + this.f02129bb8[i13] + 1518500249;
            i3 = (iM8fa14cdd3 >>> 2) | (iM8fa14cdd3 << 30);
        }
        for (int i14 = 0; i14 < 4; i14++) {
            int i15 = i6 + 1;
            int iM2510c3903 = i5 + ((iM2510c390 << 5) | (iM2510c390 >>> 27)) + m2510c390(iM2510c3902, i3, i4) + this.f02129bb8[i6] + 1859775393;
            int i16 = (iM2510c3902 >>> 2) | (iM2510c3902 << 30);
            int i17 = i6 + 2;
            int iM2510c3904 = i4 + ((iM2510c3903 << 5) | (iM2510c3903 >>> 27)) + m2510c390(iM2510c390, i16, i3) + this.f02129bb8[i15] + 1859775393;
            int i18 = (iM2510c390 >>> 2) | (iM2510c390 << 30);
            int i19 = i6 + 3;
            int iM2510c3905 = i3 + ((iM2510c3904 << 5) | (iM2510c3904 >>> 27)) + m2510c390(iM2510c3903, i18, i16) + this.f02129bb8[i17] + 1859775393;
            i5 = (iM2510c3903 >>> 2) | (iM2510c3903 << 30);
            int i20 = i6 + 4;
            iM2510c3902 = i16 + ((iM2510c3905 << 5) | (iM2510c3905 >>> 27)) + m2510c390(iM2510c3904, i5, i18) + this.f02129bb8[i19] + 1859775393;
            i4 = (iM2510c3904 >>> 2) | (iM2510c3904 << 30);
            i6 += 5;
            iM2510c390 = i18 + ((iM2510c3902 << 5) | (iM2510c3902 >>> 27)) + m2510c390(iM2510c3905, i4, i5) + this.f02129bb8[i20] + 1859775393;
            i3 = (iM2510c3905 >>> 2) | (iM2510c3905 << 30);
        }
        for (int i21 = 0; i21 < 4; i21++) {
            int i22 = i6 + 1;
            int iMb2f5ff47 = i5 + (((((iM2510c390 << 5) | (iM2510c390 >>> 27)) + mb2f5ff47(iM2510c3902, i3, i4)) + this.f02129bb8[i6]) - 1894007588);
            int i23 = i6 + 2;
            int iMb2f5ff472 = i4 + (((((iMb2f5ff47 << 5) | (iMb2f5ff47 >>> 27)) + mb2f5ff47(iM2510c390, r2, i3)) + this.f02129bb8[i22]) - 1894007588);
            int i24 = i6 + 3;
            int iMb2f5ff473 = i3 + (((((iMb2f5ff472 << 5) | (iMb2f5ff472 >>> 27)) + mb2f5ff47(iMb2f5ff47, r1, r2)) + this.f02129bb8[i23]) - 1894007588);
            i5 = (iMb2f5ff47 >>> 2) | (iMb2f5ff47 << 30);
            int i25 = i6 + 4;
            iM2510c3902 = ((iM2510c3902 >>> 2) | (iM2510c3902 << 30)) + (((((iMb2f5ff473 << 5) | (iMb2f5ff473 >>> 27)) + mb2f5ff47(iMb2f5ff472, i5, r1)) + this.f02129bb8[i24]) - 1894007588);
            i4 = (iMb2f5ff472 >>> 2) | (iMb2f5ff472 << 30);
            i6 += 5;
            iM2510c390 = ((iM2510c390 >>> 2) | (iM2510c390 << 30)) + (((((iM2510c3902 << 5) | (iM2510c3902 >>> 27)) + mb2f5ff47(iMb2f5ff473, i4, i5)) + this.f02129bb8[i25]) - 1894007588);
            i3 = (iMb2f5ff473 >>> 2) | (iMb2f5ff473 << 30);
        }
        for (int i26 = 0; i26 <= 3; i26++) {
            int i27 = i6 + 1;
            int iM2510c3906 = i5 + (((((iM2510c390 << 5) | (iM2510c390 >>> 27)) + m2510c390(iM2510c3902, i3, i4)) + this.f02129bb8[i6]) - 899497514);
            int i28 = i6 + 2;
            int iM2510c3907 = i4 + (((((iM2510c3906 << 5) | (iM2510c3906 >>> 27)) + m2510c390(iM2510c390, r2, i3)) + this.f02129bb8[i27]) - 899497514);
            int i29 = i6 + 3;
            int iM2510c3908 = i3 + (((((iM2510c3907 << 5) | (iM2510c3907 >>> 27)) + m2510c390(iM2510c3906, r1, r2)) + this.f02129bb8[i28]) - 899497514);
            i5 = (iM2510c3906 >>> 2) | (iM2510c3906 << 30);
            int i30 = i6 + 4;
            iM2510c3902 = ((iM2510c3902 >>> 2) | (iM2510c3902 << 30)) + (((((iM2510c3908 << 5) | (iM2510c3908 >>> 27)) + m2510c390(iM2510c3907, i5, r1)) + this.f02129bb8[i29]) - 899497514);
            i4 = (iM2510c3907 >>> 2) | (iM2510c3907 << 30);
            i6 += 5;
            iM2510c390 = ((iM2510c390 >>> 2) | (iM2510c390 << 30)) + (((((iM2510c3902 << 5) | (iM2510c3902 >>> 27)) + m2510c390(iM2510c3908, i4, i5)) + this.f02129bb8[i30]) - 899497514);
            i3 = (iM2510c3908 >>> 2) | (iM2510c3908 << 30);
        }
        this.f106530dc += iM2510c390;
        this.fca2bf3f6 += iM2510c3902;
        this.fb1476321 += i3;
        this.f6b57370b += i4;
        this.f83065208 += i5;
        this.fc5a8521a = 0;
        for (int i31 = 0; i31 < 16; i31++) {
            this.f02129bb8[i31] = 0;
        }
    }

    protected override void ProcessLength(long j) {
        if ((8 + 27) % 27 > 0) {
        }
        if (this.fc5a8521a > 14) {
            processBlock();
        }
        int[] iArr = this.f02129bb8;
        iArr[14] = (int) (j >>> 32);
        iArr[15] = (int) j;
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((1 + 24) % 24 > 0) {
        }
        int i2 = (bArr[i + 3] & 255) | (bArr[i] << 24) | ((bArr[i + 1] & 255) << 16) | ((bArr[i + 2] & 255) << 8);
        int[] iArr = this.f02129bb8;
        int i3 = this.fc5a8521a;
        iArr[i3] = i2;
        int i4 = i3 + 1;
        this.fc5a8521a = i4;
        if (i4 != 16) {
            return;
        }
        processBlock();
    }

    public override void Reset() {
        if ((5 + 32) % 32 > 0) {
        }
        super.reset();
        this.f106530dc = 1732584193;
        this.fca2bf3f6 = -271733879;
        this.fb1476321 = -1732584194;
        this.f6b57370b = 271733878;
        this.f83065208 = -1009589776;
        this.fc5a8521a = 0;
        int i = 0;
        while (true) {
            int[] iArr = this.f02129bb8;
            if (i == iArr.length) {
                return;
            }
            iArr[i] = 0;
            i++;
        }
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098 p9cd0c098Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098) p4d7fdfb1Var;
        super.copyIn(p9cd0c098Var);
        me7efa710(p9cd0c098Var);
    }
}

