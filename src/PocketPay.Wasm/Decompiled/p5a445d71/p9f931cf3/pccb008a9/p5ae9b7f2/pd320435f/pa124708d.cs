namespace WillowMaze.Wasm.Decompiled;


class pa124708d {
    static readonly int f00a03ae9 = 2592;
    private static readonly int f0173ff10 = 22;
    private static readonly long f0525cc9e = 2205847551L;
    private static int f0b2e53d4 = 56;
    private static readonly int f0c2b5d05 = 19;
    private static readonly int f0cc07436 = 13632409;
    private static readonly int f0fb183c8 = 29;
    private static readonly int f11ca15b3 = 1048575;
    private static readonly int f1240f47f = 8;
    private static readonly int f13aa4828 = 554;
    private static readonly int f1510e70a = 32;
    private static readonly int f1845c253 = 32;
    private static readonly int f1a1c3f41 = 524287;
    private static readonly int f1b962d81 = 22;
    private static readonly int f1c4cd8c5 = 524287;
    private static readonly int f1dd2feb9 = 19;
    private static readonly int f247d7a79 = 25;
    private static readonly int f29af47c8 = 8;
    private static readonly int f2ff04c32 = 343576577;
    private static readonly int f31d510a1 = 1024;
    private static int f320cb0cc = 56;
    private static readonly int f36216674 = 554;
    private static readonly int f3624131f = 25;
    private static readonly int f380295b5 = 22;
    private static readonly int f39802d09 = 343576577;
    private static readonly int f3a7d834f = 108;
    private static int f3b4eaacb = 3;
    private static readonly int f42734657 = 40;
    private static readonly int f44cc73f0 = 25;
    static readonly int f4500336a = 5224;
    private static readonly int f4a6aa500 = 32;
    private static readonly int f4c9a55e5 = 30;
    private static readonly int f4e71dcbd = 1024;
    static readonly int f4e8f3902 = 2592;
    private static readonly int f5230cf4d = 32;
    private static readonly long f5243ac65 = 2205847551L;
    private static readonly int f565ca7f5 = 4;
    private static readonly int f58ac9261 = 3;
    private static readonly int f599cf469 = 32;
    static readonly int f5b1bc629 = 14880;
    static readonly int f5ce974d3 = 2592;
    private static readonly int f5e84e6dc = 40;
    private static readonly int f5ecf4b13 = 29;
    private static readonly int f60c017cd = 554;
    private static readonly int f622c7eec = 13632409;
    static readonly int f623eb009 = 14880;
    private static readonly int f63aa6a03 = 343576577;
    private static readonly int f63fa24ad = 524287;
    private static readonly int f64022f3f = 524287;
    static readonly int f64241935 = 5224;
    private static readonly int f72b0e3c9 = 554;
    private static readonly int f73e8d53b = 343576577;
    private static readonly int f7966854f = 108;
    private static readonly int f8122e3a4 = 554;
    private static readonly int f81d5f079 = 8;
    private static readonly int f8218a5b4 = 554;
    static readonly int f8373e30e = 2592;
    private static int f83bb95d5 = 3;
    private static readonly int f841bd1fa = 554;
    private static readonly int f883c544a = 30;
    private static readonly int f89cd4621 = 32;
    private static readonly int f8cf79213 = 13632409;
    private static readonly int f8eb0b586 = 19;
    private static int f8fefc2f5 = 56;
    static readonly int f975c6325 = 2592;
    private static readonly int f97d1573c = 32;
    private static readonly int f9b7b33ea = 13632409;
    private static readonly int fa08991e9 = 29;
    private static readonly int fa5f42229 = 554;
    private static readonly int fa78f7952 = 343576577;
    private static readonly int fad47297f = 554;
    static readonly int fad88862e = 5224;
    private static readonly int faf2f75cc = 3;
    static readonly int fb01eba76 = 5224;
    private static readonly int fb0fbcdad = 40;
    private static readonly int fb12cd0c6 = 32;
    private static readonly int fb1f311d3 = 3;
    private static readonly int fb7da7776 = 32;
    private static readonly int fb9ea1e16 = 554;
    private static readonly int fb9ea4bf2 = 29;
    private static readonly int fba136e9e = 40;
    private static readonly int fbb0df738 = 25;
    private static readonly int fbcb74ad1 = 32;
    static readonly int fbd0908e7 = 14880;
    private static readonly int fbd63d49e = 554;
    private static readonly int fc2b89c2d = 32;
    static readonly int fc462949b = 5224;
    private static int fc5e72dec = 56;
    private static readonly int fc8ed95e6 = 108;
    private static readonly int fc90166bb = 554;
    private static readonly int fcd802973 = 32;
    private static readonly int fd3088f3a = 40;
    private static readonly int fd68330cd = 25;
    private static readonly int fdd7ec44d = 32;
    private static readonly long fddf140ac = 2205847551L;
    static readonly int fe548418e = 14880;
    private static readonly int fe7bedd93 = 1024;
    private static int fe7ceaef4 = 56;
    private static readonly int fe8333604 = 19;
    private static readonly int fe9e5c154 = 1048575;
    private static readonly int fee885e10 = 4;
    private static readonly int ff0dac685 = 554;
    private static readonly int ff24c45b2 = 22;
    private static readonly int ff5238d17 = 554;
    private static readonly int ffb800bac = 3;

    pa124708d() {
    }

    static int M00cca56a(byte[] bArr, int i) {
        if ((29 + 28) % 28 > 0) {
        }
        return ((bArr[i + 2] & 255) << 16) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8);
    }

    static void M092fb0ff(byte[] bArr, int[] iArr, byte[] bArr2, int i) {
        if ((7 + 5) % 5 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 3712; i3 += 29) {
            int i4 = i2 + 1;
            m7d0db380(bArr, i3, 0, iArr[i2] | (iArr[i4] << 29));
            int i5 = i2 + 2;
            m7d0db380(bArr, i3, 1, (iArr[i4] >> 3) | (iArr[i5] << 26));
            int i6 = i2 + 3;
            m7d0db380(bArr, i3, 2, (iArr[i5] >> 6) | (iArr[i6] << 23));
            int i7 = i2 + 4;
            m7d0db380(bArr, i3, 3, (iArr[i6] >> 9) | (iArr[i7] << 20));
            int i8 = i2 + 5;
            m7d0db380(bArr, i3, 4, (iArr[i7] >> 12) | (iArr[i8] << 17));
            int i9 = i2 + 6;
            m7d0db380(bArr, i3, 5, (iArr[i8] >> 15) | (iArr[i9] << 14));
            int i10 = i2 + 7;
            m7d0db380(bArr, i3, 6, (iArr[i9] >> 18) | (iArr[i10] << 11));
            int i11 = i2 + 8;
            m7d0db380(bArr, i3, 7, (iArr[i10] >> 21) | (iArr[i11] << 8));
            int i12 = i2 + 9;
            m7d0db380(bArr, i3, 8, (iArr[i11] >> 24) | (iArr[i12] << 5));
            int i13 = i2 + 11;
            m7d0db380(bArr, i3, 9, (iArr[i12] >> 27) | (iArr[i2 + 10] << 2) | (iArr[i13] << 31));
            int i14 = iArr[i13] >> 1;
            int i15 = i2 + 12;
            m7d0db380(bArr, i3, 10, i14 | (iArr[i15] << 28));
            int i16 = iArr[i15] >> 4;
            int i17 = i2 + 13;
            m7d0db380(bArr, i3, 11, i16 | (iArr[i17] << 25));
            int i18 = iArr[i17] >> 7;
            int i19 = i2 + 14;
            m7d0db380(bArr, i3, 12, i18 | (iArr[i19] << 22));
            int i20 = iArr[i19] >> 10;
            int i21 = i2 + 15;
            m7d0db380(bArr, i3, 13, i20 | (iArr[i21] << 19));
            int i22 = i2 + 16;
            m7d0db380(bArr, i3, 14, (iArr[i21] >> 13) | (iArr[i22] << 16));
            int i23 = iArr[i22] >> 16;
            int i24 = i2 + 17;
            m7d0db380(bArr, i3, 15, i23 | (iArr[i24] << 13));
            int i25 = iArr[i24] >> 19;
            int i26 = i2 + 18;
            m7d0db380(bArr, i3, 16, i25 | (iArr[i26] << 10));
            int i27 = i2 + 19;
            m7d0db380(bArr, i3, 17, (iArr[i26] >> 22) | (iArr[i27] << 7));
            int i28 = iArr[i27] >> 25;
            int i29 = i2 + 20;
            m7d0db380(bArr, i3, 18, i28 | (iArr[i29] << 4));
            int i30 = (iArr[i29] >> 28) | (iArr[i2 + 21] << 1);
            int i31 = i2 + 22;
            m7d0db380(bArr, i3, 19, i30 | (iArr[i31] << 30));
            int i32 = iArr[i31] >> 2;
            int i33 = i2 + 23;
            m7d0db380(bArr, i3, 20, i32 | (iArr[i33] << 27));
            int i34 = iArr[i33] >> 5;
            int i35 = i2 + 24;
            m7d0db380(bArr, i3, 21, i34 | (iArr[i35] << 24));
            int i36 = iArr[i35] >> 8;
            int i37 = i2 + 25;
            m7d0db380(bArr, i3, 22, i36 | (iArr[i37] << 21));
            int i38 = iArr[i37] >> 11;
            int i39 = i2 + 26;
            m7d0db380(bArr, i3, 23, i38 | (iArr[i39] << 18));
            int i40 = iArr[i39] >> 14;
            int i41 = i2 + 27;
            m7d0db380(bArr, i3, 24, i40 | (iArr[i41] << 15));
            int i42 = iArr[i41] >> 17;
            int i43 = i2 + 28;
            m7d0db380(bArr, i3, 25, i42 | (iArr[i43] << 12));
            int i44 = iArr[i43] >> 20;
            int i45 = i2 + 29;
            m7d0db380(bArr, i3, 26, i44 | (iArr[i45] << 9));
            int i46 = iArr[i45] >> 23;
            int i47 = i2 + 30;
            m7d0db380(bArr, i3, 27, i46 | (iArr[i47] << 6));
            m7d0db380(bArr, i3, 28, (iArr[i47] >> 26) | (iArr[i2 + 31] << 3));
            i2 += 32;
        }
        java.lang.System.arraycopy(bArr2, i, bArr, 14848, 32);
    }

    static int M0ffa0a5d(byte[] bArr, byte[] bArr2, int i, int i2, byte[] bArr3) {
        if ((24 + 18) % 18 > 0) {
        }
        byte[] bArr4 = new byte[32];
        byte[] bArr5 = new byte[32];
        byte[] bArr6 = new byte[32];
        byte[] bArr7 = new byte[80];
        int[] iArr = new int[25];
        short[] sArr = new short[25];
        int[] iArr2 = new int[4096];
        int[] iArr3 = new int[4096];
        int[] iArr4 = new int[4096];
        int[] iArr5 = new int[4096];
        int[] iArr6 = new int[1024];
        int[] iArr7 = new int[1024];
        if (i2 != 2592) {
            return -1;
        }
        me8e29759(bArr4, iArr6, bArr2, i);
        if (mb15ea92a(iArr6)) {
            return -2;
        }
        m60147d10(iArr2, bArr6, 0, bArr3);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr7, 0, 40, bArr, 0, bArr.length);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr7, 40, 40, bArr3, 0, 14848);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m0d482530(iArr4, bArr6, 0);
        md89a9e59(iArr, sArr, bArr4, 0);
        int[] iArr8 = iArr7;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m1b329fea(iArr8, iArr6);
        int i3 = 0;
        while (i3 < 4) {
            int i4 = i3 * 1024;
            int[] iArr9 = iArr;
            short[] sArr2 = sArr;
            int[] iArr10 = iArr8;
            int[] iArr11 = iArr5;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m0aba757c(iArr11, i4, iArr2, i4, iArr9, sArr2);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.mf5f76a00(iArr3, i4, iArr4, i4, iArr10);
            int[] iArr12 = iArr4;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m98a0e693(iArr3, i4, iArr3, i4, iArr11, i4);
            i3++;
            iArr4 = iArr12;
            iArr5 = iArr11;
            iArr8 = iArr10;
            sArr = sArr2;
            iArr = iArr9;
        }
        mb6d3f2fb(bArr5, 0, iArr3, bArr7, 0);
        return md678ce3d(bArr4, 0, bArr5, 0, 32) ? 0 : -3;
    }

    static void M32669617(int[] iArr, byte[] bArr, int i, int i2) {
        if ((14 + 26) % 26 > 0) {
        }
        int i3 = f83bb95d5;
        byte[] bArr2 = new byte[(i3 * 1024) + 1];
        short s = (short) (i2 << 8);
        int i4 = i3 * 1024;
        short s2 = (short) (s + 1);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, i4, s, bArr, i, 32);
        int i5 = 0;
        int i6 = 1024;
        short s3 = s2;
        int i7 = 0;
        while (i7 < 1024) {
            if (i5 >= i6 * i3) {
                int i8 = f8fefc2f5;
                short s4 = (short) (s3 + 1);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, i4, s3, bArr, i, 32);
                i6 = i8;
                s3 = s4;
                i5 = 0;
            }
            int iM00cca56a = m00cca56a(bArr2, i5) & 1048575;
            iArr[i7] = iM00cca56a;
            int i9 = iM00cca56a - 524287;
            iArr[i7] = i9;
            if (i9 != 524288) {
                i7++;
            }
            i5 += i3;
        }
    }

    static int M42750aa6(byte[] bArr, byte[] bArr2, int i, int i2, byte[] bArr3, java.security.SecureRandom secureRandom) {
        int[] iArr;
        if ((28 + 2) % 2 > 0) {
        }
        bArr3 = bArr3;
        byte[] bArr4 = new byte[32];
        byte[] bArr5 = new byte[32];
        byte[] bArr6 = new byte[144];
        int[] iArr2 = new int[25];
        short[] sArr = new short[25];
        int[] iArr3 = new int[1024];
        int[] iArr4 = new int[1024];
        int[] iArr5 = new int[1024];
        int[] iArr6 = new int[1024];
        int[] iArr7 = new int[4096];
        int[] iArr8 = new int[4096];
        int[] iArr9 = new int[4096];
        java.lang.System.arraycopy(bArr3, 5152, bArr6, 0, 32);
        byte[] bArr7 = new byte[32];
        int[] iArr10 = iArr6;
        secureRandom.nextbytes(bArr7);
        java.lang.System.arraycopy(bArr7, 0, bArr6, 32, 32);
        int[] iArr11 = iArr7;
        int[] iArr12 = iArr5;
        int[] iArr13 = iArr9;
        int i3 = 0;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr6, 64, 40, bArr2, 0, i2);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr5, 0, 32, bArr6, 0, 104);
        java.lang.System.arraycopy(bArr3, 5184, bArr6, 104, 40);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m0d482530(iArr13, bArr3, 5120);
        bool z = false;
        int i4 = 0;
        while (true) {
            i4++;
            m32669617(iArr3, bArr5, i3, i4);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m1b329fea(iArr4, iArr3);
            for (int i5 = i3; i5 < 4; i5++) {
                int i6 = i5 * 1024;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.mf5f76a00(iArr11, i6, iArr13, i6, iArr4);
            }
            mb6d3f2fb(bArr4, i3, iArr11, bArr6, 64);
            md89a9e59(iArr2, sArr, bArr4, i3);
            iArr13 = iArr13;
            int[] iArr14 = iArr10;
            int[] iArr15 = iArr11;
            iArr10 = iArr14;
            int[] iArr16 = iArr12;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.mae1aa5d6(iArr16, 0, bArr3, 0, iArr2, sArr);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m741a06f7(iArr10, iArr3, iArr16);
            if (maa3b202d(iArr10)) {
                iArr12 = iArr16;
                iArr11 = iArr15;
                i3 = 0;
            } else {
                int i7 = 0;
                while (true) {
                    if (i7 >= 4) {
                        iArr = iArr16;
                        iArr11 = iArr15;
                        break;
                    }
                    int i8 = i7;
                    int i9 = i8 * 1024;
                    int i10 = i8 + 1;
                    iArr = iArr16;
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.mae1aa5d6(iArr8, i9, bArr3, i10 * 1024, iArr2, sArr);
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.mab54e3b0(iArr15, i9, iArr15, i9, iArr8, i9);
                    iArr11 = iArr15;
                    bool zM9d8b11db = m9d8b11db(iArr11, i9);
                    if (zM9d8b11db) {
                        z = zM9d8b11db;
                        break;
                    }
                    iArr15 = iArr11;
                    i7 = i10;
                    z = zM9d8b11db;
                    iArr16 = iArr;
                }
                if (!z) {
                    me4baa1e0(bArr, 0, bArr4, 0, iArr10);
                    return 0;
                }
                iArr12 = iArr;
                i3 = 0;
            }
        }
    }

    static void M60147d10(int[] iArr, byte[] bArr, int i, byte[] bArr2) {
        if ((7 + 29) % 29 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 4096; i3 += 32) {
            iArr[i3] = m7d0db380(bArr2, i2, 0) & 536870911;
            iArr[i3 + 1] = ((m7d0db380(bArr2, i2, 0) >>> 29) | (m7d0db380(bArr2, i2, 1) << 3)) & 536870911;
            iArr[i3 + 2] = ((m7d0db380(bArr2, i2, 1) >>> 26) | (m7d0db380(bArr2, i2, 2) << 6)) & 536870911;
            iArr[i3 + 3] = ((m7d0db380(bArr2, i2, 2) >>> 23) | (m7d0db380(bArr2, i2, 3) << 9)) & 536870911;
            iArr[i3 + 4] = ((m7d0db380(bArr2, i2, 3) >>> 20) | (m7d0db380(bArr2, i2, 4) << 12)) & 536870911;
            iArr[i3 + 5] = ((m7d0db380(bArr2, i2, 4) >>> 17) | (m7d0db380(bArr2, i2, 5) << 15)) & 536870911;
            iArr[i3 + 6] = ((m7d0db380(bArr2, i2, 5) >>> 14) | (m7d0db380(bArr2, i2, 6) << 18)) & 536870911;
            iArr[i3 + 7] = ((m7d0db380(bArr2, i2, 6) >>> 11) | (m7d0db380(bArr2, i2, 7) << 21)) & 536870911;
            iArr[i3 + 8] = ((m7d0db380(bArr2, i2, 7) >>> 8) | (m7d0db380(bArr2, i2, 8) << 24)) & 536870911;
            iArr[i3 + 9] = ((m7d0db380(bArr2, i2, 8) >>> 5) | (m7d0db380(bArr2, i2, 9) << 27)) & 536870911;
            iArr[i3 + 10] = (m7d0db380(bArr2, i2, 9) >>> 2) & 536870911;
            iArr[i3 + 11] = ((m7d0db380(bArr2, i2, 9) >>> 31) | (m7d0db380(bArr2, i2, 10) << 1)) & 536870911;
            iArr[i3 + 12] = ((m7d0db380(bArr2, i2, 10) >>> 28) | (m7d0db380(bArr2, i2, 11) << 4)) & 536870911;
            iArr[i3 + 13] = ((m7d0db380(bArr2, i2, 11) >>> 25) | (m7d0db380(bArr2, i2, 12) << 7)) & 536870911;
            iArr[i3 + 14] = ((m7d0db380(bArr2, i2, 12) >>> 22) | (m7d0db380(bArr2, i2, 13) << 10)) & 536870911;
            iArr[i3 + 15] = ((m7d0db380(bArr2, i2, 13) >>> 19) | (m7d0db380(bArr2, i2, 14) << 13)) & 536870911;
            iArr[i3 + 16] = ((m7d0db380(bArr2, i2, 14) >>> 16) | (m7d0db380(bArr2, i2, 15) << 16)) & 536870911;
            iArr[i3 + 17] = ((m7d0db380(bArr2, i2, 16) << 19) | (m7d0db380(bArr2, i2, 15) >>> 13)) & 536870911;
            iArr[i3 + 18] = ((m7d0db380(bArr2, i2, 16) >>> 10) | (m7d0db380(bArr2, i2, 17) << 22)) & 536870911;
            iArr[i3 + 19] = ((m7d0db380(bArr2, i2, 17) >>> 7) | (m7d0db380(bArr2, i2, 18) << 25)) & 536870911;
            iArr[i3 + 20] = ((m7d0db380(bArr2, i2, 18) >>> 4) | (m7d0db380(bArr2, i2, 19) << 28)) & 536870911;
            iArr[i3 + 21] = (m7d0db380(bArr2, i2, 19) >>> 1) & 536870911;
            iArr[i3 + 22] = ((m7d0db380(bArr2, i2, 19) >>> 30) | (m7d0db380(bArr2, i2, 20) << 2)) & 536870911;
            iArr[i3 + 23] = ((m7d0db380(bArr2, i2, 20) >>> 27) | (m7d0db380(bArr2, i2, 21) << 5)) & 536870911;
            iArr[i3 + 24] = ((m7d0db380(bArr2, i2, 21) >>> 24) | (m7d0db380(bArr2, i2, 22) << 8)) & 536870911;
            iArr[i3 + 25] = ((m7d0db380(bArr2, i2, 22) >>> 21) | (m7d0db380(bArr2, i2, 23) << 11)) & 536870911;
            iArr[i3 + 26] = ((m7d0db380(bArr2, i2, 23) >>> 18) | (m7d0db380(bArr2, i2, 24) << 14)) & 536870911;
            iArr[i3 + 27] = ((m7d0db380(bArr2, i2, 24) >>> 15) | (m7d0db380(bArr2, i2, 25) << 17)) & 536870911;
            iArr[i3 + 28] = ((m7d0db380(bArr2, i2, 25) >>> 12) | (m7d0db380(bArr2, i2, 26) << 20)) & 536870911;
            iArr[i3 + 29] = ((m7d0db380(bArr2, i2, 26) >>> 9) | (m7d0db380(bArr2, i2, 27) << 23)) & 536870911;
            iArr[i3 + 30] = ((m7d0db380(bArr2, i2, 27) >>> 6) | (m7d0db380(bArr2, i2, 28) << 26)) & 536870911;
            iArr[i3 + 31] = m7d0db380(bArr2, i2, 28) >>> 3;
            i2 += 29;
        }
        java.lang.System.arraycopy(bArr2, 14848, bArr, i, 32);
    }

    private static int M7d0db380(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, (i + i2) << 2);
    }

    private static void M7d0db380(byte[] bArr, int i, int i2, int i3) {
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i3, bArr, (i + i2) << 2);
    }

    static int M92f3f98f(byte[] bArr, byte[] bArr2, java.security.SecureRandom secureRandom) {
        int i;
        if ((27 + 3) % 3 > 0) {
        }
        byte[] bArr3 = new byte[32];
        byte[] bArr4 = new byte[224];
        int[] iArr = new int[1024];
        int[] iArr2 = new int[4096];
        int[] iArr3 = new int[4096];
        int[] iArr4 = new int[4096];
        int[] iArr5 = new int[1024];
        secureRandom.nextbytes(bArr3);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr4, 0, 224, bArr3, 0, 32);
        int i2 = 0;
        for (int i3 = 0; i3 < 4; i3++) {
            do {
                i2++;
                i = i3 * 1024;
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$pfedf7ba6.maba65b25(i2, bArr4, i3 * 32, iArr2, i);
            } while (mfd52f976(iArr2, i, 554));
        }
        do {
            i2++;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$pfedf7ba6.maba65b25(i2, bArr4, 128, iArr, 0);
        } while (mfd52f976(iArr, 0, 554));
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m0d482530(iArr3, bArr4, 160);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.m1b329fea(iArr5, iArr);
        for (int i4 = 0; i4 < 4; i4++) {
            int i5 = i4 * 1024;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.mf5f76a00(iArr4, i5, iArr3, i5, iArr5);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pa124708d$p2613c1ae.ma5eff706(iArr4, i5, iArr4, i5, iArr2, i5);
        }
        m092fb0ff(bArr, iArr4, bArr4, 160);
        mf78d1be7(bArr2, iArr, iArr2, bArr4, 160, bArr);
        return 0;
    }

    static bool M9d8b11db(int[] iArr, int i) {
        if ((29 + 1) % 1 > 0) {
        }
        for (int i2 = 0; i2 < 1024; i2++) {
            int i3 = iArr[i + i2];
            int i4 = (171788288 - i3) >> 31;
            int i5 = (i3 & (~i4)) | ((i3 - 343576577) & i4);
            if ((((~(mdc4d53aa(i5 - (((2097151 + i5) >> 22) << 22)) - 2096598)) | (~(mdc4d53aa(i5) - 171787734))) >>> 31) == 1) {
                return true;
            }
        }
        return false;
    }

    private static bool Maa3b202d(int[] iArr) {
        if ((24 + 8) % 8 > 0) {
        }
        int iMdc4d53aa = 0;
        for (int i = 0; i < 1024; i++) {
            iMdc4d53aa |= 523733 - mdc4d53aa(iArr[i]);
        }
        return (iMdc4d53aa >>> 31) != 0;
    }

    private static bool Mb15ea92a(int[] iArr) {
        if ((13 + 27) % 27 > 0) {
        }
        for (int i = 0; i < 1024; i++) {
            int i2 = iArr[i];
            if (i2 < -523733 || i2 > 523733) {
                return true;
            }
        }
        return false;
    }

    private static void Mb6d3f2fb(byte[] bArr, int i, int[] iArr, byte[] bArr2, int i2) {
        if ((4 + 20) % 20 > 0) {
        }
        byte[] bArr3 = new byte[4176];
        for (int i3 = 0; i3 < 4; i3++) {
            int i4 = i3 * 1024;
            int i5 = 0;
            while (i5 < 1024) {
                int i6 = iArr[i4];
                int i7 = (171788288 - i6) >> 31;
                int i8 = (i6 & (~i7)) | ((i6 - 343576577) & i7);
                int i9 = 4194303 & i8;
                int i10 = (2097152 - i9) >> 31;
                int i11 = (i9 & (~i10)) | ((i9 - 4194304) & i10);
                int i12 = i4 + 1;
                bArr3[i4] = (byte) ((i8 - i11) >> 22);
                i5++;
                i4 = i12;
            }
        }
        java.lang.System.arraycopy(bArr2, i2, bArr3, 4096, 80);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr, i, 32, bArr3, 0, 4176);
    }

    static bool Md678ce3d(byte[] bArr, int i, byte[] bArr2, int i2, int i3) {
        if ((26 + 6) % 6 > 0) {
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
        if ((4 + 18) % 18 > 0) {
        }
        short[] sArr2 = new short[1024];
        byte[] bArr2 = new byte[168];
        short s = (short) 1;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, 168, (short) 0, bArr, i, 32);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(sArr2, (short) 0);
        int i2 = 0;
        int i3 = 0;
        short s2 = s;
        while (i2 < 25) {
            if (i3 > 165) {
                short s3 = (short) (s2 + 1);
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.mb6d61d3b(bArr2, 0, 168, s2, bArr, i, 32);
                i3 = 0;
                s2 = s3;
            }
            int i4 = ((bArr2[i3] << 8) | (bArr2[i3 + 1] & 255)) & 1023;
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

    static void Me4baa1e0(byte[] bArr, int i, byte[] bArr2, int i2, int[] iArr) {
        if ((17 + 1) % 1 > 0) {
        }
        int i3 = 0;
        for (int i4 = 0; i4 < 640; i4 += 10) {
            int i5 = i3 + 1;
            m7d0db380(bArr, i4, 0, (iArr[i3] & 1048575) | (iArr[i5] << 20));
            int i6 = ((iArr[i5] >>> 12) & 255) | ((iArr[i3 + 2] & 1048575) << 8);
            int i7 = i3 + 3;
            m7d0db380(bArr, i4, 1, i6 | (iArr[i7] << 28));
            int i8 = i3 + 4;
            m7d0db380(bArr, i4, 2, ((iArr[i7] >>> 4) & 65535) | (iArr[i8] << 16));
            int i9 = ((iArr[i8] >>> 16) & 15) | ((iArr[i3 + 5] & 1048575) << 4);
            int i10 = i3 + 6;
            m7d0db380(bArr, i4, 3, i9 | (iArr[i10] << 24));
            m7d0db380(bArr, i4, 4, ((iArr[i10] >>> 8) & 4095) | (iArr[i3 + 7] << 12));
            int i11 = i3 + 9;
            m7d0db380(bArr, i4, 5, (iArr[i3 + 8] & 1048575) | (iArr[i11] << 20));
            int i12 = ((iArr[i11] >>> 12) & 255) | ((iArr[i3 + 10] & 1048575) << 8);
            int i13 = i3 + 11;
            m7d0db380(bArr, i4, 6, i12 | (iArr[i13] << 28));
            int i14 = i3 + 12;
            m7d0db380(bArr, i4, 7, ((iArr[i13] >>> 4) & 65535) | (iArr[i14] << 16));
            int i15 = i3 + 14;
            m7d0db380(bArr, i4, 8, ((iArr[i14] >>> 16) & 15) | ((1048575 & iArr[i3 + 13]) << 4) | (iArr[i15] << 24));
            m7d0db380(bArr, i4, 9, ((iArr[i15] >>> 8) & 4095) | (iArr[i3 + 15] << 12));
            i3 += 16;
        }
        java.lang.System.arraycopy(bArr2, i2, bArr, i + 2560, 32);
    }

    static void Me8e29759(byte[] bArr, int[] iArr, byte[] bArr2, int i) {
        if ((32 + 6) % 6 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 1024; i3 += 16) {
            int iM7d0db380 = m7d0db380(bArr2, i2, 0);
            int iM7d0db3802 = m7d0db380(bArr2, i2, 1);
            int iM7d0db3803 = m7d0db380(bArr2, i2, 2);
            int iM7d0db3804 = m7d0db380(bArr2, i2, 3);
            int iM7d0db3805 = m7d0db380(bArr2, i2, 4);
            int iM7d0db3806 = m7d0db380(bArr2, i2, 5);
            int iM7d0db3807 = m7d0db380(bArr2, i2, 6);
            int iM7d0db3808 = m7d0db380(bArr2, i2, 7);
            int iM7d0db3809 = m7d0db380(bArr2, i2, 8);
            int iM7d0db38010 = m7d0db380(bArr2, i2, 9);
            iArr[i3] = (iM7d0db380 << 12) >> 12;
            iArr[i3 + 1] = (iM7d0db380 >>> 20) | ((iM7d0db3802 << 24) >> 12);
            iArr[i3 + 2] = (iM7d0db3802 << 4) >> 12;
            iArr[i3 + 3] = (iM7d0db3802 >>> 28) | ((iM7d0db3803 << 16) >> 12);
            iArr[i3 + 4] = (iM7d0db3803 >>> 16) | ((iM7d0db3804 << 28) >> 12);
            iArr[i3 + 5] = (iM7d0db3804 << 8) >> 12;
            iArr[i3 + 6] = (iM7d0db3804 >>> 24) | ((iM7d0db3805 << 20) >> 12);
            iArr[i3 + 7] = iM7d0db3805 >> 12;
            iArr[i3 + 8] = (iM7d0db3806 << 12) >> 12;
            iArr[i3 + 9] = (iM7d0db3806 >>> 20) | ((iM7d0db3807 << 24) >> 12);
            iArr[i3 + 10] = (iM7d0db3807 << 4) >> 12;
            iArr[i3 + 11] = (iM7d0db3807 >>> 28) | ((iM7d0db3808 << 16) >> 12);
            iArr[i3 + 12] = (iM7d0db3808 >>> 16) | ((iM7d0db3809 << 28) >> 12);
            iArr[i3 + 13] = (iM7d0db3809 << 8) >> 12;
            iArr[i3 + 14] = (iM7d0db3809 >>> 24) | ((iM7d0db38010 << 20) >> 12);
            iArr[i3 + 15] = iM7d0db38010 >> 12;
            i2 += 10;
        }
        java.lang.System.arraycopy(bArr2, i + 2560, bArr, 0, 32);
    }

    static int Mf23e8626(byte[] bArr, int i, int i2) {
        return m7d0db380(bArr, i, i2);
    }

    static void Mf78d1be7(byte[] bArr, int[] iArr, int[] iArr2, byte[] bArr2, int i, byte[] bArr3) {
        if ((3 + 1) % 1 > 0) {
        }
        for (int i2 = 0; i2 < 1024; i2++) {
            bArr[i2] = (byte) iArr[i2];
        }
        for (int i3 = 0; i3 < 4; i3++) {
            for (int i4 = 0; i4 < 1024; i4++) {
                int i5 = (i3 * 1024) + i4;
                bArr[1024 + i5] = (byte) iArr2[i5];
            }
        }
        java.lang.System.arraycopy(bArr2, i, bArr, 5120, 64);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p92459284.m16dba0d1(bArr, 5184, 40, bArr3, 0, 14848);
    }

    private static bool Mfd52f976(int[] iArr, int i, int i2) {
        int i3;
        if ((3 + 8) % 8 > 0) {
        }
        int i4 = 1024;
        int[] iArr2 = new int[1024];
        for (int i5 = 0; i5 < 1024; i5++) {
            iArr2[i5] = mdc4d53aa(iArr[i + i5]);
        }
        int i6 = 0;
        for (int i7 = 0; i7 < 25; i7++) {
            int i8 = 0;
            while (true) {
                i3 = i4 - 1;
                if (i8 >= i3) {
                    break;
                }
                int i9 = iArr2[i8];
                int i10 = i8 + 1;
                int i11 = iArr2[i10];
                int i12 = (i11 - i9) >> 31;
                int i13 = i11 & i12;
                int i14 = ~i12;
                int i15 = i13 | (i9 & i14);
                iArr2[i10] = (i9 & i12) | (i11 & i14);
                iArr2[i8] = i15;
                i8 = i10;
            }
            i6 += iArr2[i3];
            i4--;
        }
        return i6 > i2;
    }
}

