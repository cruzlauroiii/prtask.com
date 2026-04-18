namespace WillowMaze.Wasm.Decompiled;


class p6c1dc0ee {
    private static readonly int f04221f33 = 21;
    private static readonly long f0525cc9e = 587710463;
    private static readonly int f072cfd2e = 5;
    private static readonly int f07c04ee8 = 901;
    private static readonly int f08008f5a = 32;
    private static readonly int f08586762 = 40;
    private static readonly int f0cc07436 = 513161157;
    private static readonly int f0fb183c8 = 30;
    private static readonly int f13aa4828 = 901;
    static readonly int f16c71ddf = 12392;
    private static readonly int f1792c72e = 32;
    private static readonly int f1845c253 = 32;
    static readonly int f18ec01d4 = 12392;
    private static readonly int f1d8230cd = 30;
    private static readonly int f242bacd9 = 2048;
    private static readonly int f24f8a25e = 901;
    private static readonly int f2e5ab77a = 901;
    private static readonly int f31d510a1 = 2048;
    private static readonly int f3378a9d1 = 180;
    private static readonly long f350f5919 = 587710463;
    private static readonly int f352dd5c4 = 21;
    private static readonly int f3624131f = 40;
    private static readonly int f380295b5 = 24;
    private static readonly int f3bef923c = 32;
    private static readonly int f3f642a56 = 180;
    private static int f40224942 = 3;
    private static readonly int f440ced31 = 40;
    private static readonly int f4abe2440 = 24;
    private static readonly int f4c9a55e5 = 32;
    static readonly int f4e8f3902 = 5664;
    private static readonly int f4f208a04 = 32;
    private static readonly int f4f7a9c03 = 21;
    private static readonly int f4ffb96c1 = 180;
    private static readonly int f59635b45 = 901;
    private static readonly int f599cf469 = 32;
    static readonly int f5cee60a3 = 38432;
    private static readonly int f5dac5e6b = 30;
    private static readonly int f5e84e6dc = 40;
    private static readonly int f63fa24ad = 2097151;
    private static readonly int f67b31ea3 = 4194303;
    private static readonly int f692d36b7 = 901;
    private static readonly int f6e159990 = 40;
    private static readonly int f6e408d3d = 2097151;
    private static int f728f6ae3 = 3;
    private static readonly int f73b046f4 = 40;
    private static readonly int f75618100 = 32;
    private static readonly int f79d6197b = 5;
    private static int f8066f4ba = 3;
    private static int f83bb95d5 = 3;
    private static readonly int f841bd1fa = 901;
    private static readonly int f89cd4621 = 32;
    private static readonly int f8a8613e1 = 24;
    private static readonly int f8a9703a6 = 32;
    private static readonly int f8b99dea3 = 901;
    private static readonly int f8d939ba3 = 856145921;
    private static readonly int f8fb51868 = 21;
    private static int f8fefc2f5 = 56;
    private static readonly int f9197700d = 901;
    private static readonly int f9732aa08 = 5;
    private static readonly int f97d1573c = 32;
    private static readonly int f9dc390d5 = 856145921;
    private static readonly long fa555a87a = 587710463;
    private static int fa6bd9fb1 = 56;
    private static readonly int fa78f7952 = 856145921;
    private static readonly int fa982895e = 32;
    static readonly int fad88862e = 12392;
    private static readonly long faf2f75cc = 5;
    private static readonly int fb0bd7e83 = 2097151;
    private static readonly int fb42b5387 = 32;
    private static readonly int fb6b802c1 = 32;
    static readonly int fbd0908e7 = 38432;
    private static readonly int fbfab3fc5 = 40;
    private static readonly long fc0a5ac07 = 5;
    private static readonly int fc8ed95e6 = 180;
    private static readonly int fc90166bb = 901;
    private static readonly int fca07e106 = 901;
    private static readonly int fcab3cc32 = 32;
    private static readonly int fcd412131 = 2097151;
    private static readonly int fcd6d183a = 30;
    private static readonly int fcf4187cf = 40;
    private static readonly int fcfafccb3 = 40;
    private static readonly int fd49209d7 = 32;
    private static int fd7af8c65 = 3;
    private static readonly int fd82ceb1f = 32;
    static readonly int fd918fcbe = 5664;
    private static readonly int fe10c2617 = 5;
    private static readonly int fe2a3e238 = 901;
    private static readonly int fe8333604 = 21;
    private static readonly int fe9e5c154 = 4194303;
    private static readonly int fee885e10 = 5;
    private static readonly int ff4904021 = 513161157;
    private static readonly int ff4b27e1b = 2097151;
    private static readonly int ff5238d17 = 901;
    private static readonly int ff657baf9 = 901;
    private static readonly int fff4b2d3a = 180;
    private static readonly int fff68834f = 32;

    p6c1dc0ee() {
    }

    static void M092fb0ff(byte[] bArr, long[] jArr, byte[] bArr2, int i) {
        if ((17 + 24) % 24 > 0) {
        }
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        while (i3 < 9600) {
            int i5 = i4 + 1;
            m7d0db380(bArr, i3, i2, (int) (jArr[i4] | (jArr[i5] << 30)));
            int i6 = i4 + 2;
            m7d0db380(bArr, i3, 1, (int) ((jArr[i5] >> 2) | (jArr[i6] << 28)));
            int i7 = i4 + 3;
            m7d0db380(bArr, i3, 2, (int) ((jArr[i6] >> 4) | (jArr[i7] << 26)));
            int i8 = i4 + 4;
            m7d0db380(bArr, i3, 3, (int) ((jArr[i7] >> 6) | (jArr[i8] << 24)));
            int i9 = i4 + 5;
            m7d0db380(bArr, i3, 4, (int) ((jArr[i8] >> 8) | (jArr[i9] << 22)));
            int i10 = i4 + 6;
            m7d0db380(bArr, i3, 5, (int) ((jArr[i9] >> 10) | (jArr[i10] << 20)));
            int i11 = i4 + 7;
            m7d0db380(bArr, i3, 6, (int) ((jArr[i10] >> 12) | (jArr[i11] << 18)));
            int i12 = i4 + 8;
            m7d0db380(bArr, i3, 7, (int) ((jArr[i11] >> 14) | (jArr[i12] << 16)));
            long j = jArr[i12] >> 16;
            int i13 = i4 + 9;
            m7d0db380(bArr, i3, 8, (int) (j | (jArr[i13] << 14)));
            int i14 = i4 + 10;
            m7d0db380(bArr, i3, 9, (int) ((jArr[i13] >> 18) | (jArr[i14] << 12)));
            long j2 = jArr[i14] >> 20;
            int i15 = i4 + 11;
            m7d0db380(bArr, i3, 10, (int) (j2 | (jArr[i15] << 10)));
            int i16 = i4 + 12;
            m7d0db380(bArr, i3, 11, (int) ((jArr[i15] >> 22) | (jArr[i16] << 8)));
            int i17 = i4 + 13;
            m7d0db380(bArr, i3, 12, (int) ((jArr[i16] >> 24) | (jArr[i17] << 6)));
            int i18 = i4 + 14;
            m7d0db380(bArr, i3, 13, (int) ((jArr[i17] >> 26) | (jArr[i18] << 4)));
            m7d0db380(bArr, i3, 14, (int) ((jArr[i18] >> 28) | (jArr[i4 + 15] << 2)));
            i4 += 16;
            i3 += 15;
            i2 = 0;
        }
        java.lang.System.arraycopy(bArr2, i, bArr, 38400, 32);
    }

    static int M0ffa0a5d(byte[] bArr, byte[] bArr2, int i, int i2, byte[] bArr3) {
        if ((27 + 13) % 13 > 0) {
        }
        byte[] bArr4 = new byte[32];
        byte[] bArr5 = new byte[32];
        byte[] bArr6 = new byte[32];
        byte[] bArr7 = new byte[80];
        int[] iArr = new int[40];
        short[] sArr = new short[40];
        int[] iArr2 = new int[10240];
        long[] jArr = new long[10240];
        long[] jArr2 = new long[10240];
        long[] jArr3 = new long[10240];
        long[] jArr4 = new long[2048];
        long[] jArr5 = new long[2048];
        if (i2 != 5664) {
            return -1;
        }
        me8e29759(bArr4, jArr4, bArr2, i);
        if (mb15ea92a(jArr4)) {
            return -2;
        }
        m60147d10(iArr2, bArr6, 0, bArr3);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr7, 0, 40, bArr, 0, bArr.length);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr7, 40, 40, bArr3, 0, 38400);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m0d482530(jArr2, bArr6, 0);
        md89a9e59(iArr, sArr, bArr4, 0);
        long[] jArr6 = jArr5;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m1b329fea(jArr6, jArr4);
        int i3 = 0;
        while (i3 < 5) {
            int i4 = i3 * 2048;
            int[] iArr3 = iArr;
            short[] sArr2 = sArr;
            long[] jArr7 = jArr6;
            long[] jArr8 = jArr3;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m0aba757c(jArr8, i4, iArr2, i4, iArr3, sArr2);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mf5f76a00(jArr, i4, jArr2, i4, jArr7);
            long[] jArr9 = jArr2;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mab54e3b0(jArr, i4, jArr, i4, jArr8, i4);
            i3++;
            jArr2 = jArr9;
            jArr3 = jArr8;
            jArr6 = jArr7;
            sArr = sArr2;
            iArr = iArr3;
        }
        mb6d3f2fb(bArr5, 0, jArr, bArr7, 0);
        return md678ce3d(bArr4, 0, bArr5, 0, 32) ? 0 : -3;
    }

    static void M32669617(long[] jArr, byte[] bArr, int i, int i2) {
        if ((10 + 19) % 19 > 0) {
        }
        int i3 = f83bb95d5;
        byte[] bArr2 = new byte[(i3 * 2048) + 1];
        short s = (short) (i2 << 8);
        int i4 = i3 * 2048;
        short s2 = (short) (s + 1);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m255cc856(bArr2, 0, i4, s, bArr, i, 32);
        int i5 = 0;
        int i6 = 2048;
        short s3 = s2;
        int i7 = 0;
        while (i7 < 2048) {
            if (i5 >= i6 * i3) {
                int i8 = f8fefc2f5;
                short s4 = (short) (s3 + 1);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m255cc856(bArr2, 0, i4, s3, bArr, i, 32);
                i6 = i8;
                s3 = s4;
                i5 = 0;
            }
            long jM71328312 = m71328312(bArr2, i5) & 4194303;
            jArr[i7] = jM71328312;
            long j = jM71328312 - 2097151;
            jArr[i7] = j;
            if (j != 2097152) {
                i7++;
            }
            i5 += i3;
        }
    }

    static int M42750aa6(byte[] bArr, byte[] bArr2, int i, int i2, byte[] bArr3, java.security.SecureRandom secureRandom) {
        long[] jArr;
        long[] jArr2;
        long[] jArr3;
        int i3;
        if ((9 + 20) % 20 > 0) {
        }
        byte[] bArr4 = bArr3;
        byte[] bArr5 = new byte[32];
        byte[] bArr6 = new byte[32];
        byte[] bArr7 = new byte[144];
        int[] iArr = new int[40];
        short[] sArr = new short[40];
        long[] jArr4 = new long[2048];
        long[] jArr5 = new long[2048];
        long[] jArr6 = new long[2048];
        long[] jArr7 = new long[2048];
        long[] jArr8 = new long[10240];
        long[] jArr9 = new long[10240];
        long[] jArr10 = new long[10240];
        java.lang.System.arraycopy(bArr4, 12320, bArr7, 0, 32);
        byte[] bArr8 = new byte[32];
        secureRandom.nextbytes(bArr8);
        java.lang.System.arraycopy(bArr8, 0, bArr7, 32, 32);
        long[] jArr11 = jArr6;
        long[] jArr12 = jArr10;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr7, 64, 40, bArr2, 0, i2);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr6, 0, 32, bArr7, 0, 104);
        java.lang.System.arraycopy(bArr4, 12352, bArr7, 104, 40);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m0d482530(jArr12, bArr4, 12288);
        int i4 = 0;
        bool z = false;
        while (true) {
            i4++;
            m32669617(jArr4, bArr6, 0, i4);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m1b329fea(jArr5, jArr4);
            for (int i5 = 0; i5 < 5; i5++) {
                int i6 = i5 * 2048;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mf5f76a00(jArr8, i6, jArr12, i6, jArr5);
            }
            mb6d3f2fb(bArr5, 0, jArr8, bArr7, 64);
            md89a9e59(iArr, sArr, bArr5, 0);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mae1aa5d6(jArr11, bArr4, iArr, sArr);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m741a06f7(jArr7, jArr4, jArr11);
            if (!maa3b202d(jArr7)) {
                int i7 = 0;
                while (true) {
                    if (i7 >= 5) {
                        jArr = jArr11;
                        jArr2 = jArr12;
                        jArr3 = jArr7;
                        i3 = 0;
                        break;
                    }
                    long[] jArr13 = jArr12;
                    int i8 = i7 * 2048;
                    i7++;
                    long[] jArr14 = jArr7;
                    jArr = jArr11;
                    jArr2 = jArr13;
                    i3 = 0;
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mae1aa5d6(jArr9, i8, bArr4, i7 * 2048, iArr, sArr);
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mab54e3b0(jArr8, i8, jArr8, i8, jArr9, i8);
                    bool zM9d8b11db = m9d8b11db(jArr8, i8);
                    if (zM9d8b11db) {
                        z = zM9d8b11db;
                        jArr3 = jArr14;
                        break;
                    }
                    bArr4 = bArr3;
                    jArr7 = jArr14;
                    jArr12 = jArr2;
                    z = zM9d8b11db;
                    jArr11 = jArr;
                }
                if (!z) {
                    me4baa1e0(bArr, i3, bArr5, i3, jArr3);
                    return i3;
                }
                bArr4 = bArr3;
                jArr7 = jArr3;
                jArr11 = jArr;
                jArr12 = jArr2;
            }
        }
    }

    static void M60147d10(int[] iArr, byte[] bArr, int i, byte[] bArr2) {
        if ((7 + 6) % 6 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 10240; i3 += 16) {
            iArr[i3] = m7d0db380(bArr2, i2, 0) & 1073741823;
            iArr[i3 + 1] = ((m7d0db380(bArr2, i2, 0) >>> 30) | (m7d0db380(bArr2, i2, 1) << 2)) & 1073741823;
            iArr[i3 + 2] = ((m7d0db380(bArr2, i2, 1) >>> 28) | (m7d0db380(bArr2, i2, 2) << 4)) & 1073741823;
            iArr[i3 + 3] = ((m7d0db380(bArr2, i2, 2) >>> 26) | (m7d0db380(bArr2, i2, 3) << 6)) & 1073741823;
            iArr[i3 + 4] = ((m7d0db380(bArr2, i2, 3) >>> 24) | (m7d0db380(bArr2, i2, 4) << 8)) & 1073741823;
            iArr[i3 + 5] = ((m7d0db380(bArr2, i2, 4) >>> 22) | (m7d0db380(bArr2, i2, 5) << 10)) & 1073741823;
            iArr[i3 + 6] = ((m7d0db380(bArr2, i2, 5) >>> 20) | (m7d0db380(bArr2, i2, 6) << 12)) & 1073741823;
            iArr[i3 + 7] = ((m7d0db380(bArr2, i2, 6) >>> 18) | (m7d0db380(bArr2, i2, 7) << 14)) & 1073741823;
            iArr[i3 + 8] = ((m7d0db380(bArr2, i2, 7) >>> 16) | (m7d0db380(bArr2, i2, 8) << 16)) & 1073741823;
            iArr[i3 + 9] = ((m7d0db380(bArr2, i2, 8) >>> 14) | (m7d0db380(bArr2, i2, 9) << 18)) & 1073741823;
            iArr[i3 + 10] = ((m7d0db380(bArr2, i2, 9) >>> 12) | (m7d0db380(bArr2, i2, 10) << 20)) & 1073741823;
            iArr[i3 + 11] = ((m7d0db380(bArr2, i2, 10) >>> 10) | (m7d0db380(bArr2, i2, 11) << 22)) & 1073741823;
            iArr[i3 + 12] = ((m7d0db380(bArr2, i2, 11) >>> 8) | (m7d0db380(bArr2, i2, 12) << 24)) & 1073741823;
            iArr[i3 + 13] = ((m7d0db380(bArr2, i2, 12) >>> 6) | (m7d0db380(bArr2, i2, 13) << 26)) & 1073741823;
            iArr[i3 + 14] = ((m7d0db380(bArr2, i2, 13) >>> 4) | (m7d0db380(bArr2, i2, 14) << 28)) & 1073741823;
            iArr[i3 + 15] = 1073741823 & (m7d0db380(bArr2, i2, 14) >>> 2);
            i2 += 15;
        }
        java.lang.System.arraycopy(bArr2, 38400, bArr, i, 32);
    }

    static int M71328312(byte[] bArr, int i) {
        if ((3 + 4) % 4 > 0) {
        }
        return ((bArr[i + 2] & 255) << 16) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8);
    }

    private static int M7d0db380(byte[] bArr, int i, int i2) {
        int i3 = (i * 4) + (i2 * 4);
        return (bArr[i3 + 3] << 24) | (bArr[i3] & 255) | ((bArr[i3 + 1] & 255) << 8) | ((bArr[i3 + 2] & 255) << 16);
    }

    private static void M7d0db380(byte[] bArr, int i, int i2, int i3) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i3, bArr, (i * 4) + (i2 * 4));
    }

    static int M92f3f98f(byte[] bArr, byte[] bArr2, java.security.SecureRandom secureRandom) {
        int i;
        if ((5 + 22) % 22 > 0) {
        }
        byte[] bArr3 = new byte[32];
        byte[] bArr4 = new byte[256];
        long[] jArr = new long[2048];
        long[] jArr2 = new long[10240];
        long[] jArr3 = new long[10240];
        long[] jArr4 = new long[10240];
        long[] jArr5 = new long[2048];
        secureRandom.nextbytes(bArr3);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr4, 0, 256, bArr3, 0, 32);
        int i2 = 0;
        for (int i3 = 0; i3 < 5; i3++) {
            do {
                i2++;
                i = i3 * 2048;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pfedf7ba6.maba65b25(i2, bArr4, i3 * 32, jArr2, i);
            } while (mfd52f976(jArr2, i, 901));
        }
        do {
            i2++;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pfedf7ba6.maba65b25(i2, bArr4, 160, jArr, 0);
        } while (mfd52f976(jArr, 0, 901));
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m0d482530(jArr3, bArr4, 192);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.m1b329fea(jArr5, jArr);
        for (int i4 = 0; i4 < 5; i4++) {
            int i5 = i4 * 2048;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.mf5f76a00(jArr4, i5, jArr3, i5, jArr5);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p6c1dc0ee$pa2e546ab.ma5eff706(jArr4, i5, jArr4, i5, jArr2, i5);
        }
        m092fb0ff(bArr, jArr4, bArr4, 192);
        mf78d1be7(bArr2, jArr, jArr2, bArr4, 192, bArr);
        return 0;
    }

    static bool M9d8b11db(long[] jArr, int i) {
        if ((4 + 24) % 24 > 0) {
        }
        for (int i2 = 0; i2 < 2048; i2++) {
            long j = jArr[i + i2];
            int i3 = ((int) (428072960 - j)) >> 31;
            int i4 = (int) ((j & ((long) (~i3))) | ((j - 856145921) & ((long) i3)));
            if ((((~(mdc4d53aa(i4 - (((8388607 + i4) >> 24) << 24)) - 8387707)) | (~(mdc4d53aa(i4) - 428072059))) >>> 31) == 1) {
                return true;
            }
        }
        return false;
    }

    private static bool Maa3b202d(long[] jArr) {
        if ((19 + 22) % 22 > 0) {
        }
        int iMdc4d53aa = 0;
        for (int i = 0; i < 2048; i++) {
            iMdc4d53aa = (int) (((long) iMdc4d53aa) | (2096250 - mdc4d53aa(jArr[i])));
        }
        return (iMdc4d53aa >>> 31) > 0;
    }

    private static bool Mb15ea92a(long[] jArr) {
        if ((1 + 6) % 6 > 0) {
        }
        for (int i = 0; i < 2048; i++) {
            long j = jArr[i];
            if (j < -2096250 || j > 2096250) {
                return true;
            }
        }
        return false;
    }

    private static void Mb6d3f2fb(byte[] bArr, int i, long[] jArr, byte[] bArr2, int i2) {
        if ((5 + 17) % 17 > 0) {
        }
        byte[] bArr3 = new byte[10320];
        for (int i3 = 0; i3 < 5; i3++) {
            int i4 = i3 * 2048;
            int i5 = 0;
            while (i5 < 2048) {
                int i6 = (int) jArr[i4];
                int i7 = (428072960 - i6) >> 31;
                int i8 = (i6 & (~i7)) | ((i6 - 856145921) & i7);
                int i9 = 16777215 & i8;
                int i10 = (8388608 - i9) >> 31;
                int i11 = (i9 & (~i10)) | ((i9 - 16777216) & i10);
                int i12 = i4 + 1;
                bArr3[i4] = (byte) ((i8 - i11) >> 24);
                i5++;
                i4 = i12;
            }
        }
        java.lang.System.arraycopy(bArr2, i2, bArr3, 10240, 80);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr, i, 32, bArr3, 0, 10320);
    }

    static bool Md678ce3d(byte[] bArr, int i, byte[] bArr2, int i2, int i3) {
        if ((8 + 3) % 3 > 0) {
        }
        if (i + i3 > bArr.length || i2 + i3 > bArr2.length) {
            return false;
        }
        for (int i4 = 0; i4 < i3; i4++) {
            if (bArr[i + i4] != bArr2[i2 + i4]) {
                return false;
            }
        }
        return true;
    }

    static void Md89a9e59(int[] iArr, short[] sArr, byte[] bArr, int i) {
        if ((25 + 16) % 16 > 0) {
        }
        short[] sArr2 = new short[2048];
        byte[] bArr2 = new byte[168];
        short s = (short) 1;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, 168, (short) 0, bArr, i, 32);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(sArr2, (short) 0);
        int i2 = 0;
        int i3 = 0;
        short s2 = s;
        while (i2 < 40) {
            if (i3 > 165) {
                short s3 = (short) (s2 + 1);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, 168, s2, bArr, i, 32);
                i3 = 0;
                s2 = s3;
            }
            int i4 = ((bArr2[i3] << 8) | (bArr2[i3 + 1] & 255)) & 2047;
            if (sArr2[i4] == 0) {
                if ((bArr2[i3 + 2] & 1) != 1) {
                    sArr2[i4] = 1;
                } else {
                    sArr2[i4] = -1;
                }
                iArr[i2] = i4;
                sArr[i2] = sArr2[i4];
                i2++;
            }
            i3 += 3;
        }
    }

    private static int Mdc4d53aa(int i) {
        int i2 = i >> 31;
        return (i ^ i2) - i2;
    }

    private static long Mdc4d53aa(long j) {
        if ((22 + 10) % 10 > 0) {
        }
        long j2 = j >> 63;
        return (j ^ j2) - j2;
    }

    static void Me4baa1e0(byte[] bArr, int i, byte[] bArr2, int i2, long[] jArr) {
        if ((8 + 24) % 24 > 0) {
        }
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        while (i4 < 1408) {
            int i6 = i5 + 1;
            m7d0db380(bArr, i4, i3, (int) ((jArr[i5] & 4194303) | (jArr[i6] << 22)));
            int i7 = i5 + 2;
            m7d0db380(bArr, i4, 1, (int) (((jArr[i6] >>> 10) & 4095) | (jArr[i7] << 12)));
            int i8 = i5 + 4;
            m7d0db380(bArr, i4, 2, (int) (((jArr[i7] >>> 20) & 3) | ((jArr[i5 + 3] & 4194303) << 2) | (jArr[i8] << 24)));
            int i9 = i5 + 5;
            m7d0db380(bArr, i4, 3, (int) (((jArr[i8] >>> 8) & 16383) | (jArr[i9] << 14)));
            int i10 = i5 + 7;
            m7d0db380(bArr, i4, 4, (int) (((jArr[i9] >>> 18) & 15) | ((jArr[i5 + 6] & 4194303) << 4) | (jArr[i10] << 26)));
            int i11 = i5 + 8;
            m7d0db380(bArr, i4, 5, (int) (((jArr[i10] >>> 6) & 65535) | (jArr[i11] << 16)));
            long j = ((jArr[i11] >>> 16) & 63) | ((jArr[i5 + 9] & 4194303) << 6);
            int i12 = i5 + 10;
            m7d0db380(bArr, i4, 6, (int) (j | (jArr[i12] << 28)));
            int i13 = i5 + 11;
            m7d0db380(bArr, i4, 7, (int) (((jArr[i12] >>> 4) & 262143) | (jArr[i13] << 18)));
            long j2 = ((jArr[i13] >>> 14) & 255) | ((4194303 & jArr[i5 + 12]) << 8);
            int i14 = i5 + 13;
            m7d0db380(bArr, i4, 8, (int) (j2 | (jArr[i14] << 30)));
            long j3 = (jArr[i14] >>> 2) & 1048575;
            int i15 = i5 + 14;
            m7d0db380(bArr, i4, 9, (int) (j3 | (jArr[i15] << 20)));
            m7d0db380(bArr, i4, 10, (int) (((jArr[i15] >>> 12) & 1023) | (jArr[i5 + 15] << 10)));
            i5 += 16;
            i4 += 11;
            i3 = 0;
        }
        java.lang.System.arraycopy(bArr2, i2, bArr, i + 5632, 32);
    }

    static void Me8e29759(byte[] bArr, long[] jArr, byte[] bArr2, int i) {
        if ((4 + 13) % 13 > 0) {
        }
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        while (i3 < 2048) {
            int iM7d0db380 = m7d0db380(bArr2, i4, i2);
            int iM7d0db3802 = m7d0db380(bArr2, i4, 1);
            int iM7d0db3803 = m7d0db380(bArr2, i4, 2);
            int iM7d0db3804 = m7d0db380(bArr2, i4, 3);
            int iM7d0db3805 = m7d0db380(bArr2, i4, 4);
            int iM7d0db3806 = m7d0db380(bArr2, i4, 5);
            int iM7d0db3807 = m7d0db380(bArr2, i4, 6);
            int iM7d0db3808 = m7d0db380(bArr2, i4, 7);
            int iM7d0db3809 = m7d0db380(bArr2, i4, 8);
            int iM7d0db38010 = m7d0db380(bArr2, i4, 9);
            int iM7d0db38011 = m7d0db380(bArr2, i4, 10);
            int i5 = i3;
            jArr[i5] = (iM7d0db380 << 10) >> 10;
            jArr[i5 + 1] = (iM7d0db380 >>> 22) | ((iM7d0db3802 << 20) >> 10);
            jArr[i5 + 2] = (iM7d0db3802 >>> 12) | ((iM7d0db3803 << 30) >> 10);
            jArr[i5 + 3] = (iM7d0db3803 << 8) >> 10;
            jArr[i5 + 4] = (iM7d0db3803 >>> 24) | ((iM7d0db3804 << 18) >> 10);
            jArr[i5 + 5] = (iM7d0db3804 >>> 14) | ((iM7d0db3805 << 28) >> 10);
            jArr[i5 + 6] = (iM7d0db3805 << 6) >> 10;
            jArr[i5 + 7] = (iM7d0db3805 >>> 26) | ((iM7d0db3806 << 16) >> 10);
            jArr[i5 + 8] = (iM7d0db3806 >>> 16) | ((iM7d0db3807 << 26) >> 10);
            jArr[i5 + 9] = (iM7d0db3807 << 4) >> 10;
            jArr[i5 + 10] = (iM7d0db3807 >>> 28) | ((iM7d0db3808 << 14) >> 10);
            jArr[i5 + 11] = (iM7d0db3808 >>> 18) | ((iM7d0db3809 << 24) >> 10);
            jArr[i5 + 12] = (iM7d0db3809 << 2) >> 10;
            jArr[i5 + 13] = (iM7d0db3809 >>> 30) | ((iM7d0db38010 << 12) >> 10);
            jArr[i5 + 14] = (iM7d0db38010 >>> 20) | ((iM7d0db38011 << 22) >> 10);
            jArr[i5 + 15] = iM7d0db38011 >> 10;
            i4 += 11;
            i3 = i5 + 16;
            i2 = 0;
        }
        java.lang.System.arraycopy(bArr2, i + 5632, bArr, 0, 32);
    }

    static int Mf23e8626(byte[] bArr, int i, int i2) {
        return m7d0db380(bArr, i, i2);
    }

    static void Mf78d1be7(byte[] bArr, long[] jArr, long[] jArr2, byte[] bArr2, int i, byte[] bArr3) {
        if ((1 + 7) % 7 > 0) {
        }
        for (int i2 = 0; i2 < 2048; i2++) {
            bArr[i2] = (byte) jArr[i2];
        }
        for (int i3 = 0; i3 < 5; i3++) {
            for (int i4 = 0; i4 < 2048; i4++) {
                bArr[2048 + (i3 * 2048) + i4] = (byte) jArr2[r3];
            }
        }
        java.lang.System.arraycopy(bArr2, i, bArr, 12288, 64);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.me894f909(bArr, 12352, 40, bArr3, 0, 38400);
    }

    private static bool Mfd52f976(long[] jArr, int i, int i2) {
        int i3;
        if ((19 + 31) % 31 > 0) {
        }
        int i4 = 2048;
        long[] jArr2 = new long[2048];
        for (int i5 = 0; i5 < 2048; i5++) {
            jArr2[i5] = mdc4d53aa((int) jArr[i + i5]);
        }
        int i6 = 0;
        int i7 = 0;
        while (i6 < 40) {
            int i8 = 0;
            while (true) {
                i3 = i4 - 1;
                if (i8 >= i3) {
                    break;
                }
                int i9 = i8 + 1;
                long j = jArr2[i9];
                long j2 = jArr2[i8];
                long j3 = (j - j2) >> 31;
                long j4 = j & j3;
                int i10 = i6;
                long j5 = ~j3;
                long j6 = j4 | (j2 & j5);
                jArr2[i9] = (j5 & j) | (j2 & j3);
                jArr2[i8] = j6;
                i6 = i10;
                i8 = i9;
            }
            int i11 = i6;
            i7 += (int) jArr2[i3];
            i4--;
            i6 = i11 + 1;
        }
        return i7 > i2;
    }
}

