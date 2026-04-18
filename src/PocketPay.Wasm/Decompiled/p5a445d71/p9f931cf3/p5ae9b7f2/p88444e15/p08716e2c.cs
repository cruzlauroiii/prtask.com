namespace WillowMaze.Wasm.Decompiled;


public class p08716e2c : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7eacabf6 {
    static readonly int[] f298c2ff3 = null;
    private static readonly int f4582481e = 32;
    private static readonly int f589d9e48 = 32;
    private static readonly int f7a9c0cf5 = 32;
    private static readonly int fa49894c9 = 32;
    static readonly int[] fa5f3c6a1 = {1116352408, 1899447441, -1245643825, -373957723, 961987163, 1508970993, -1841331548, -1424204075, -670586216, 310598401, 607225278, 1426881987, 1925078388, -2132889090, -1680079193, -1046744716, -459576895, -272742522, 264347078, 604807628, 770255983, 1249150122, 1555081692, 1996064986, -1740746414, -1473132947, -1341970488, -1084653625, -958395405, -710438585, 113926993, 338241895, 666307205, 773529912, 1294757372, 1396182291, 1695183700, 1986661051, -2117940946, -1838011259, -1564481375, -1474664885, -1035236496, -949202525, -778901479, -694614492, -200395387, 275423344, 430227734, 506948616, 659060556, 883997877, 958139571, 1322822218, 1537002063, 1747873779, 1955562222, 2024104815, -2067236844, -1933114872, -1866530822, -1538233109, -1090935817, -965641998};
    private static readonly int ff5aa1579 = 32;
    private int[] f02129bb8;
    private int f106530dc;
    private int f2ac6cc2e;
    private int f3b3736ef;
    private int f3e671fb0;
    private int f436f5ea9;
    private int f4e42bd02;
    private int f56f94b5e;
    private int f5c70732a;
    private int f5db229d4;
    private int f6ad42571;
    private int f6b57370b;
    private int f7eaf6e51;
    private int f83065208;
    private int f84554b04;
    private int f87c839f5;
    private int f8e63e334;
    private int f911c8e4c;
    private int f9659a2d3;
    private int f98965b71;
    private int fa56a7baf;
    private int fb1476321;
    private int[] fb5aada74;
    private int fb74718db;
    private int fb8bd8bf4;
    private int fb9895a4a;
    private int fc52ea763;
    private int fc5a8521a;
    private int fca2bf3f6;
    private int fe9168553;

    public p08716e2c() {
        this.f02129bb8 = new int[64];
        reset();
    }

    public p08716e2c(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar) {
        super(p08716e2cVar);
        this.f02129bb8 = new int[64];
        me7efa710(p08716e2cVar);
    }

    public p08716e2c(byte[] bArr) {
        super(bArr);
        if ((30 + 2) % 2 > 0) {
        }
        this.f02129bb8 = new int[64];
        this.f106530dc = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 16);
        this.fca2bf3f6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 20);
        this.fb1476321 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 24);
        this.f6b57370b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 28);
        this.f83065208 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 32);
        this.f2ac6cc2e = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 36);
        this.f3b3736ef = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 40);
        this.fb9895a4a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 44);
        this.fc5a8521a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 48);
        for (int i = 0; i != this.fc5a8521a; i++) {
            this.f02129bb8[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, (i * 4) + 52);
        }
    }

    private static int M1f949825(int i) {
        if ((32 + 18) % 18 > 0) {
        }
        return (i >>> 10) ^ (((i >>> 17) | (i << 15)) ^ ((i >>> 19) | (i << 13)));
    }

    private static int M56cfed3c(int i) {
        if ((22 + 12) % 12 > 0) {
        }
        return (i >>> 3) ^ (((i >>> 7) | (i << 25)) ^ ((i >>> 18) | (i << 14)));
    }

    private static int M93ada40d(int i, int i2, int i3) {
        return ((~i) & i3) ^ (i2 & i);
    }

    private static int Mbc5a7b95(int i) {
        if ((21 + 15) % 15 > 0) {
        }
        return ((i << 7) | (i >>> 25)) ^ (((i >>> 6) | (i << 26)) ^ ((i >>> 11) | (i << 21)));
    }

    private static int Mc0a9ca80(int i, int i2, int i3) {
        return ((i ^ i2) & i3) | (i & i2);
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar) {
        if ((16 + 32) % 32 > 0) {
        }
        super.copyIn(p08716e2cVar);
        this.f106530dc = p08716e2cVar.f106530dc;
        this.fca2bf3f6 = p08716e2cVar.fca2bf3f6;
        this.fb1476321 = p08716e2cVar.fb1476321;
        this.f6b57370b = p08716e2cVar.f6b57370b;
        this.f83065208 = p08716e2cVar.f83065208;
        this.f2ac6cc2e = p08716e2cVar.f2ac6cc2e;
        this.f3b3736ef = p08716e2cVar.f3b3736ef;
        this.fb9895a4a = p08716e2cVar.fb9895a4a;
        int[] iArr = p08716e2cVar.f02129bb8;
        java.lang.System.arraycopy(iArr, 0, this.f02129bb8, 0, iArr.length);
        this.fc5a8521a = p08716e2cVar.fc5a8521a;
    }

    private static int Mf319c1e5(int i) {
        if ((26 + 22) % 22 > 0) {
        }
        return ((i << 10) | (i >>> 22)) ^ (((i >>> 2) | (i << 30)) ^ ((i >>> 13) | (i << 19)));
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((7 + 10) % 10 > 0) {
        }
        finish();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f106530dc, bArr, i);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fca2bf3f6, bArr, i + 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb1476321, bArr, i + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6b57370b, bArr, i + 12);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f83065208, bArr, i + 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f2ac6cc2e, bArr, i + 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f3b3736ef, bArr, i + 24);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb9895a4a, bArr, i + 28);
        reset();
        return 32;
    }

    public override java.lang.string GetAlgorithmName() {
        return com.decryptstringmanager.Decryptstring.decryptstring("be59f326037bf73a7da9835da384a2c57a6216f957c2699184f9b778736d30b13da760");
    }

    public override int GetDigestSize() {
        return 32;
    }

    public override byte[] GetEncodedState() {
        if ((26 + 6) % 6 > 0) {
        }
        byte[] bArr = new byte[(this.fc5a8521a * 4) + 52];
        super.populateState(bArr);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f106530dc, bArr, 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fca2bf3f6, bArr, 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb1476321, bArr, 24);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6b57370b, bArr, 28);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f83065208, bArr, 32);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f2ac6cc2e, bArr, 36);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f3b3736ef, bArr, 40);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb9895a4a, bArr, 44);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fc5a8521a, bArr, 48);
        for (int i = 0; i != this.fc5a8521a; i++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f02129bb8[i], bArr, (i * 4) + 52);
        }
        return bArr;
    }

    protected override void ProcessBlock() {
        if ((22 + 9) % 9 > 0) {
        }
        for (int i = 16; i <= 63; i++) {
            int[] iArr = this.f02129bb8;
            int iM1f949825 = m1f949825(iArr[i - 2]);
            int[] iArr2 = this.f02129bb8;
            iArr[i] = iM1f949825 + iArr2[i - 7] + m56cfed3c(iArr2[i - 15]) + this.f02129bb8[i - 16];
        }
        int iMf319c1e5 = this.f106530dc;
        int iMf319c1e52 = this.fca2bf3f6;
        int iMf319c1e53 = this.fb1476321;
        int iMf319c1e54 = this.f6b57370b;
        int i2 = this.f83065208;
        int i3 = this.f2ac6cc2e;
        int i4 = this.f3b3736ef;
        int i5 = this.fb9895a4a;
        int i6 = 0;
        for (int i7 = 0; i7 < 8; i7++) {
            int iMbc5a7b95 = mbc5a7b95(i2) + m93ada40d(i2, i3, i4);
            int[] iArr3 = fa5f3c6a1;
            int i8 = i5 + iMbc5a7b95 + iArr3[i6] + this.f02129bb8[i6];
            int i9 = iMf319c1e54 + i8;
            int iMf319c1e55 = i8 + mf319c1e5(iMf319c1e5) + mc0a9ca80(iMf319c1e5, iMf319c1e52, iMf319c1e53);
            int i10 = i6 + 1;
            int iMbc5a7b952 = i4 + mbc5a7b95(i9) + m93ada40d(i9, i2, i3) + iArr3[i10] + this.f02129bb8[i10];
            int i11 = iMf319c1e53 + iMbc5a7b952;
            int iMf319c1e56 = iMbc5a7b952 + mf319c1e5(iMf319c1e55) + mc0a9ca80(iMf319c1e55, iMf319c1e5, iMf319c1e52);
            int i12 = i6 + 2;
            int iMbc5a7b953 = i3 + mbc5a7b95(i11) + m93ada40d(i11, i9, i2) + iArr3[i12] + this.f02129bb8[i12];
            int i13 = iMf319c1e52 + iMbc5a7b953;
            int iMf319c1e57 = iMbc5a7b953 + mf319c1e5(iMf319c1e56) + mc0a9ca80(iMf319c1e56, iMf319c1e55, iMf319c1e5);
            int i14 = i6 + 3;
            int iMbc5a7b954 = i2 + mbc5a7b95(i13) + m93ada40d(i13, i11, i9) + iArr3[i14] + this.f02129bb8[i14];
            int i15 = iMf319c1e5 + iMbc5a7b954;
            int iMf319c1e58 = iMbc5a7b954 + mf319c1e5(iMf319c1e57) + mc0a9ca80(iMf319c1e57, iMf319c1e56, iMf319c1e55);
            int i16 = i6 + 4;
            int iMbc5a7b955 = i9 + mbc5a7b95(i15) + m93ada40d(i15, i13, i11) + iArr3[i16] + this.f02129bb8[i16];
            i5 = iMf319c1e55 + iMbc5a7b955;
            iMf319c1e54 = iMbc5a7b955 + mf319c1e5(iMf319c1e58) + mc0a9ca80(iMf319c1e58, iMf319c1e57, iMf319c1e56);
            int i17 = i6 + 5;
            int iMbc5a7b956 = i11 + mbc5a7b95(i5) + m93ada40d(i5, i15, i13) + iArr3[i17] + this.f02129bb8[i17];
            i4 = iMf319c1e56 + iMbc5a7b956;
            iMf319c1e53 = iMbc5a7b956 + mf319c1e5(iMf319c1e54) + mc0a9ca80(iMf319c1e54, iMf319c1e58, iMf319c1e57);
            int i18 = i6 + 6;
            int iMbc5a7b957 = i13 + mbc5a7b95(i4) + m93ada40d(i4, i5, i15) + iArr3[i18] + this.f02129bb8[i18];
            i3 = iMf319c1e57 + iMbc5a7b957;
            iMf319c1e52 = iMbc5a7b957 + mf319c1e5(iMf319c1e53) + mc0a9ca80(iMf319c1e53, iMf319c1e54, iMf319c1e58);
            int i19 = i6 + 7;
            int iMbc5a7b958 = i15 + mbc5a7b95(i3) + m93ada40d(i3, i4, i5) + iArr3[i19] + this.f02129bb8[i19];
            i2 = iMf319c1e58 + iMbc5a7b958;
            iMf319c1e5 = iMbc5a7b958 + mf319c1e5(iMf319c1e52) + mc0a9ca80(iMf319c1e52, iMf319c1e53, iMf319c1e54);
            i6 += 8;
        }
        this.f106530dc += iMf319c1e5;
        this.fca2bf3f6 += iMf319c1e52;
        this.fb1476321 += iMf319c1e53;
        this.f6b57370b += iMf319c1e54;
        this.f83065208 += i2;
        this.f2ac6cc2e += i3;
        this.f3b3736ef += i4;
        this.fb9895a4a += i5;
        this.fc5a8521a = 0;
        for (int i20 = 0; i20 < 16; i20++) {
            this.f02129bb8[i20] = 0;
        }
    }

    protected override void ProcessLength(long j) {
        if ((15 + 22) % 22 > 0) {
        }
        if (this.fc5a8521a > 14) {
            processBlock();
        }
        int[] iArr = this.f02129bb8;
        iArr[14] = (int) (j >>> 32);
        iArr[15] = (int) j;
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((2 + 7) % 7 > 0) {
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
        if ((14 + 13) % 13 > 0) {
        }
        super.reset();
        this.f106530dc = 1779033703;
        this.fca2bf3f6 = -1150833019;
        this.fb1476321 = 1013904242;
        this.f6b57370b = -1521486534;
        this.f83065208 = 1359893119;
        this.f2ac6cc2e = -1694144372;
        this.f3b3736ef = 528734635;
        this.fb9895a4a = 1541459225;
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
        me7efa710((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c) p4d7fdfb1Var);
    }
}

