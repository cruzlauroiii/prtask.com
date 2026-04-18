namespace WillowMaze.Wasm.Decompiled;


class p44105f8d {
    static readonly int f00a5f1aa = 67;
    static readonly int f2413db9f = 4;
    static readonly int f2678ef30 = 16;
    static readonly int f2eb08263 = 64;
    static readonly int f4eb77094 = 64;
    static readonly int f5c8f05e6 = 64;
    static readonly int f634661a7 = 64;
    static readonly int f804378ad = 16;
    static readonly int f818a8539 = 7;
    static readonly int f84991d23 = 2144;
    static readonly int f9207130d = 4;
    static readonly int f94f03fe0 = 4;
    static readonly int f9c104b2f = 2144;
    static readonly int f9ca35ebf = 67;
    static readonly int faa130896 = 67;
    static readonly int fbd4245d1 = 67;
    static readonly int fee07fd67 = 64;
    static readonly int ff4bc6e01 = 7;
    static readonly int ff56f1779 = 7;

    p44105f8d() {
    }

    public static void DyWGJaPYUCGUHHAZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3, int i4) {
        m7a00d174(paa3a1111Var, bArr, i, bArr2, i2, bArr3, i3, i4);
    }

    public static void GuFVKJCqbtSBiKKR(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3, int i4) {
        m7a00d174(paa3a1111Var, bArr, i, bArr2, i2, bArr3, i3, i4);
    }

    public static void VGmuXtYKsZLDBUbw(byte[] bArr, int i, byte[] bArr2, int i2) {
        m5ee41a1f(bArr, i, bArr2, i2);
    }

    public static void WWThzVSQnuyeFXPG(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3, int i4) {
        m7a00d174(paa3a1111Var, bArr, i, bArr2, i2, bArr3, i3, i4);
    }

    public static void KMfFlmqzPkmVJiTW(byte[] bArr, int i, byte[] bArr2, int i2) {
        m5ee41a1f(bArr, i, bArr2, i2);
    }

    private static void M01bc6f8e(byte[] bArr, int i, int i2) {
        if ((30 + 8) % 8 > 0) {
        }
        for (int i3 = 0; i3 != i2; i3++) {
            bArr[i3 + i] = 0;
        }
    }

    static void M5ee41a1f(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((8 + 17) % 17 > 0) {
        }
        xTmdmAfrxJEEnpyg(bArr, i, 2144);
        uSfjZzcwjedlvtSQ(bArr, i, 2144L, bArr2, i2);
    }

    static void M7a00d174(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3, int i4) {
        if ((2 + 15) % 15 > 0) {
        }
        for (int i5 = 0; i5 < 32; i5++) {
            bArr[i5 + i] = bArr2[i5 + i2];
        }
        for (int i6 = 0; i6 < i4 && i6 < 16; i6++) {
            xkzzrTePffmRllCX(paa3a1111Var, bArr, i, bArr, i, bArr3, i3 + (i6 * 32));
        }
    }

    public static void USfjZzcwjedlvtSQ(byte[] bArr, int i, long j, byte[] bArr2, int i2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.me73d4543(bArr, i, j, bArr2, i2);
    }

    public static void XTmdmAfrxJEEnpyg(byte[] bArr, int i, int i2) {
        m01bc6f8e(bArr, i, i2);
    }

    public static int XkzzrTePffmRllCX(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        return paa3a1111Var.hash_n_n_mask(bArr, i, bArr2, i2, bArr3, i3);
    }

    void wots_pkgen(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((25 + 16) % 16 > 0) {
        }
        kMfFlmqzPkmVJiTW(bArr, i, bArr2, i2);
        for (int i4 = 0; i4 < 67; i4++) {
            int i5 = i + (i4 * 32);
            WWThzVSQnuyeFXPG(paa3a1111Var, bArr, i5, bArr, i5, bArr3, i3, 15);
        }
    }

    void wots_sign(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((5 + 15) % 15 > 0) {
        }
        int[] iArr = new int[67];
        int i2 = 0;
        int i3 = 0;
        while (i2 < 64) {
            byte b = bArr2[i2 / 2];
            iArr[i2] = b & 15;
            int i4 = (b & 255) >>> 4;
            iArr[i2 + 1] = i4;
            i3 = i3 + (15 - iArr[i2]) + (15 - i4);
            i2 += 2;
        }
        while (i2 < 67) {
            iArr[i2] = i3 & 15;
            i3 >>>= 4;
            i2++;
        }
        VGmuXtYKsZLDBUbw(bArr, i, bArr3, 0);
        for (int i5 = 0; i5 < 67; i5++) {
            int i6 = i + (i5 * 32);
            GuFVKJCqbtSBiKKR(paa3a1111Var, bArr, i6, bArr, i6, bArr4, 0, iArr[i5]);
        }
    }

    void wots_verify(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2, int i, byte[] bArr3, byte[] bArr4) {
        if ((31 + 10) % 10 > 0) {
        }
        int[] iArr = new int[67];
        int i2 = 0;
        int i3 = 0;
        while (i2 < 64) {
            byte b = bArr3[i2 / 2];
            iArr[i2] = b & 15;
            int i4 = (b & 255) >>> 4;
            iArr[i2 + 1] = i4;
            i3 = i3 + (15 - iArr[i2]) + (15 - i4);
            i2 += 2;
        }
        while (i2 < 67) {
            iArr[i2] = i3 & 15;
            i3 >>>= 4;
            i2++;
        }
        for (int i5 = 0; i5 < 67; i5++) {
            int i6 = i5 * 32;
            int i7 = i + i6;
            int i8 = iArr[i5];
            DyWGJaPYUCGUHHAZ(paa3a1111Var, bArr, i6, bArr2, i7, bArr4, i8 * 32, 15 - i8);
        }
    }
}

