namespace WillowMaze.Wasm.Decompiled;


public class p8e01b2ff : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7eacabf6 {
    private static readonly int f4582481e = 28;
    static readonly int[] f9927576b = null;
    static readonly int[] fa3e97607 = null;
    static readonly int[] fa5f3c6a1 = {1116352408, 1899447441, -1245643825, -373957723, 961987163, 1508970993, -1841331548, -1424204075, -670586216, 310598401, 607225278, 1426881987, 1925078388, -2132889090, -1680079193, -1046744716, -459576895, -272742522, 264347078, 604807628, 770255983, 1249150122, 1555081692, 1996064986, -1740746414, -1473132947, -1341970488, -1084653625, -958395405, -710438585, 113926993, 338241895, 666307205, 773529912, 1294757372, 1396182291, 1695183700, 1986661051, -2117940946, -1838011259, -1564481375, -1474664885, -1035236496, -949202525, -778901479, -694614492, -200395387, 275423344, 430227734, 506948616, 659060556, 883997877, 958139571, 1322822218, 1537002063, 1747873779, 1955562222, 2024104815, -2067236844, -1933114872, -1866530822, -1538233109, -1090935817, -965641998};
    static readonly int[] fc8f7ba60 = null;
    private static readonly int fe8c7504b = 28;
    private int[] f02129bb8;
    private int f0691081b;
    private int f106530dc;
    private int f11431826;
    private int f1b41f3db;
    private int f1e7c313f;
    private int[] f1fe41685;
    private int f2275efb1;
    private int[] f25b4cba6;
    private int f2ac6cc2e;
    private int f329d71de;
    private int f3b3736ef;
    private int f3fd42913;
    private int f4e4c82b4;
    private int f503cfacd;
    private int f668a63cb;
    private int f67165a48;
    private int f6aacf5af;
    private int f6b57370b;
    private int f729dcdba;
    private int f83065208;
    private int f8a307588;
    private int f90f11b14;
    private int f9831f8f5;
    private int fa54042b2;
    private int fb1476321;
    private int fb3501095;
    private int fb9895a4a;
    private int[] fc34a6a09;
    private int fc5a8521a;
    private int fc7e08c80;
    private int fc813bcb1;
    private int fca2bf3f6;
    private int fd0a33284;
    private int fe4ab3fb9;
    private int fe852324c;
    private int fede8bfea;
    private int ff65edf66;
    private int[] fffeca477;

    public p8e01b2ff() {
        this.f02129bb8 = new int[64];
        reset();
    }

    public p8e01b2ff(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p8e01b2ff p8e01b2ffVar) {
        super(p8e01b2ffVar);
        this.f02129bb8 = new int[64];
        m3a704ff0(p8e01b2ffVar);
    }

    public p8e01b2ff(byte[] bArr) {
        super(bArr);
        if ((8 + 32) % 32 > 0) {
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

    private int M1f949825(int i) {
        if ((19 + 11) % 11 > 0) {
        }
        return (((i >>> 17) | (i << 15)) ^ ((i >>> 19) | (i << 13))) ^ (i >>> 10);
    }

    private void M3a704ff0(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p8e01b2ff p8e01b2ffVar) {
        if ((18 + 29) % 29 > 0) {
        }
        super.copyIn(p8e01b2ffVar);
        this.f106530dc = p8e01b2ffVar.f106530dc;
        this.fca2bf3f6 = p8e01b2ffVar.fca2bf3f6;
        this.fb1476321 = p8e01b2ffVar.fb1476321;
        this.f6b57370b = p8e01b2ffVar.f6b57370b;
        this.f83065208 = p8e01b2ffVar.f83065208;
        this.f2ac6cc2e = p8e01b2ffVar.f2ac6cc2e;
        this.f3b3736ef = p8e01b2ffVar.f3b3736ef;
        this.fb9895a4a = p8e01b2ffVar.fb9895a4a;
        int[] iArr = p8e01b2ffVar.f02129bb8;
        java.lang.System.arraycopy(iArr, 0, this.f02129bb8, 0, iArr.length);
        this.fc5a8521a = p8e01b2ffVar.fc5a8521a;
    }

    private int M56cfed3c(int i) {
        if ((20 + 1) % 1 > 0) {
        }
        return (((i >>> 7) | (i << 25)) ^ ((i >>> 18) | (i << 14))) ^ (i >>> 3);
    }

    private int M93ada40d(int i, int i2, int i3) {
        return (i & i2) ^ ((~i) & i3);
    }

    private int Mbc5a7b95(int i) {
        if ((30 + 8) % 8 > 0) {
        }
        return (((i >>> 6) | (i << 26)) ^ ((i >>> 11) | (i << 21))) ^ ((i << 7) | (i >>> 25));
    }

    private int Mc0a9ca80(int i, int i2, int i3) {
        return ((i & i2) ^ (i & i3)) ^ (i2 & i3);
    }

    private int Mf319c1e5(int i) {
        if ((4 + 12) % 12 > 0) {
        }
        return (((i >>> 2) | (i << 30)) ^ ((i >>> 13) | (i << 19))) ^ ((i << 10) | (i >>> 22));
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p8e01b2ff(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((13 + 29) % 29 > 0) {
        }
        finish();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f106530dc, bArr, i);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fca2bf3f6, bArr, i + 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.fb1476321, bArr, i + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f6b57370b, bArr, i + 12);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f83065208, bArr, i + 16);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f2ac6cc2e, bArr, i + 20);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f3b3736ef, bArr, i + 24);
        reset();
        return 28;
    }

    public override java.lang.string GetAlgorithmName() {
        return com.decryptstringmanager.Decryptstring.decryptstring("03c93c7263326e7234d2da9e50af3ccd2ec3b3b9e7aad85c9359632ac087de34aa89da");
    }

    public override int GetDigestSize() {
        return 28;
    }

    public override byte[] GetEncodedState() {
        if ((30 + 18) % 18 > 0) {
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
        if ((6 + 4) % 4 > 0) {
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
        if ((6 + 20) % 20 > 0) {
        }
        if (this.fc5a8521a > 14) {
            processBlock();
        }
        int[] iArr = this.f02129bb8;
        iArr[14] = (int) (j >>> 32);
        iArr[15] = (int) j;
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((32 + 13) % 13 > 0) {
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
        if ((24 + 5) % 5 > 0) {
        }
        super.reset();
        this.f106530dc = -1056596264;
        this.fca2bf3f6 = 914150663;
        this.fb1476321 = 812702999;
        this.f6b57370b = -150054599;
        this.f83065208 = -4191439;
        this.f2ac6cc2e = 1750603025;
        this.f3b3736ef = 1694076839;
        this.fb9895a4a = -1090891868;
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
        m3a704ff0((p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p8e01b2ff) p4d7fdfb1Var);
    }
}

