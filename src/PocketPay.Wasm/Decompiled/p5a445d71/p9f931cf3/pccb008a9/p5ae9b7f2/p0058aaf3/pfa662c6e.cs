namespace WillowMaze.Wasm.Decompiled;


class pfa662c6e {
    private static readonly int fae2be54d = 12;
    private static readonly int ff2ef6194 = 12;
    private static readonly int ff81cf234 = 12;

    pfa662c6e() {
    }

    public static void M3f6f0a4f(int i, int[] iArr) {
        if ((29 + 15) % 15 > 0) {
        }
        int i2 = 16;
        if (iArr.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i % 2 != 0) {
            throw new java.lang.IllegalArgumentException("Number of rounds must be even");
        }
        int i3 = iArr[0];
        int i4 = iArr[1];
        int i5 = iArr[2];
        char c = 3;
        int i6 = iArr[3];
        char c2 = 4;
        int i7 = iArr[4];
        char c3 = 5;
        int i8 = iArr[5];
        char c4 = 6;
        int i9 = iArr[6];
        int i10 = 7;
        int i11 = iArr[7];
        int i12 = 8;
        int i13 = iArr[8];
        int i14 = iArr[9];
        int i15 = iArr[10];
        int i16 = iArr[11];
        int i17 = iArr[12];
        int i18 = iArr[13];
        int i19 = iArr[14];
        int iM8da2040d = iArr[15];
        int iM8da2040d2 = i19;
        int iM8da2040d3 = i18;
        int iM8da2040d4 = i17;
        int i20 = i16;
        int i21 = i15;
        int i22 = i14;
        int i23 = i13;
        int iM8da2040d5 = i11;
        int iM8da2040d6 = i9;
        int iM8da2040d7 = i8;
        int iM8da2040d8 = i7;
        int i24 = i6;
        int i25 = i5;
        int i26 = i4;
        int i27 = i3;
        int i28 = i;
        while (i28 > 0) {
            int i29 = i27 + iM8da2040d8;
            char c5 = c;
            int iM8da2040d9 = m8da2040d(iM8da2040d4 ^ i29, i2);
            int i30 = i23 + iM8da2040d9;
            int iM8da2040d10 = m8da2040d(iM8da2040d8 ^ i30, 12);
            int i31 = i29 + iM8da2040d10;
            int iM8da2040d11 = m8da2040d(iM8da2040d9 ^ i31, i12);
            int i32 = i30 + iM8da2040d11;
            int iM8da2040d12 = m8da2040d(iM8da2040d10 ^ i32, i10);
            int i33 = i26 + iM8da2040d7;
            char c6 = c2;
            int iM8da2040d13 = m8da2040d(iM8da2040d3 ^ i33, i2);
            int i34 = i22 + iM8da2040d13;
            int iM8da2040d14 = m8da2040d(iM8da2040d7 ^ i34, 12);
            int i35 = i33 + iM8da2040d14;
            int iM8da2040d15 = m8da2040d(iM8da2040d13 ^ i35, i12);
            int i36 = i34 + iM8da2040d15;
            int iM8da2040d16 = m8da2040d(iM8da2040d14 ^ i36, i10);
            int i37 = i25 + iM8da2040d6;
            char c7 = c3;
            int iM8da2040d17 = m8da2040d(iM8da2040d2 ^ i37, i2);
            int i38 = i21 + iM8da2040d17;
            char c8 = c4;
            int iM8da2040d18 = m8da2040d(iM8da2040d6 ^ i38, 12);
            int i39 = i37 + iM8da2040d18;
            int iM8da2040d19 = m8da2040d(iM8da2040d17 ^ i39, i12);
            int i40 = i38 + iM8da2040d19;
            int iM8da2040d20 = m8da2040d(iM8da2040d18 ^ i40, i10);
            int i41 = i24 + iM8da2040d5;
            int iM8da2040d21 = m8da2040d(iM8da2040d ^ i41, i2);
            int i42 = i20 + iM8da2040d21;
            int iM8da2040d22 = m8da2040d(iM8da2040d5 ^ i42, 12);
            int i43 = i41 + iM8da2040d22;
            int iM8da2040d23 = m8da2040d(iM8da2040d21 ^ i43, i12);
            int i44 = i42 + iM8da2040d23;
            int iM8da2040d24 = m8da2040d(iM8da2040d22 ^ i44, 7);
            int i45 = i31 + iM8da2040d16;
            int iM8da2040d25 = m8da2040d(iM8da2040d23 ^ i45, 16);
            int i46 = i40 + iM8da2040d25;
            int iM8da2040d26 = m8da2040d(iM8da2040d16 ^ i46, 12);
            i27 = i45 + iM8da2040d26;
            iM8da2040d = m8da2040d(iM8da2040d25 ^ i27, 8);
            i21 = i46 + iM8da2040d;
            iM8da2040d7 = m8da2040d(iM8da2040d26 ^ i21, 7);
            int i47 = i35 + iM8da2040d20;
            int iM8da2040d27 = m8da2040d(iM8da2040d11 ^ i47, 16);
            int i48 = i44 + iM8da2040d27;
            int iM8da2040d28 = m8da2040d(iM8da2040d20 ^ i48, 12);
            i26 = i47 + iM8da2040d28;
            iM8da2040d4 = m8da2040d(iM8da2040d27 ^ i26, 8);
            i20 = i48 + iM8da2040d4;
            iM8da2040d6 = m8da2040d(iM8da2040d28 ^ i20, 7);
            int i49 = i39 + iM8da2040d24;
            int iM8da2040d29 = m8da2040d(iM8da2040d15 ^ i49, 16);
            int i50 = i32 + iM8da2040d29;
            int iM8da2040d30 = m8da2040d(iM8da2040d24 ^ i50, 12);
            i25 = i49 + iM8da2040d30;
            iM8da2040d3 = m8da2040d(iM8da2040d29 ^ i25, 8);
            i23 = i50 + iM8da2040d3;
            iM8da2040d5 = m8da2040d(iM8da2040d30 ^ i23, 7);
            int i51 = i43 + iM8da2040d12;
            int iM8da2040d31 = m8da2040d(iM8da2040d19 ^ i51, 16);
            int i52 = i36 + iM8da2040d31;
            int iM8da2040d32 = m8da2040d(iM8da2040d12 ^ i52, 12);
            i24 = i51 + iM8da2040d32;
            iM8da2040d2 = m8da2040d(iM8da2040d31 ^ i24, 8);
            i22 = i52 + iM8da2040d2;
            iM8da2040d8 = m8da2040d(iM8da2040d32 ^ i22, 7);
            i28 -= 2;
            i10 = 7;
            i2 = 16;
            c = c5;
            c2 = c6;
            c3 = c7;
            c4 = c8;
            i12 = 8;
        }
        int i53 = i10;
        char c9 = c;
        char c10 = c2;
        char c11 = c3;
        char c12 = c4;
        iArr[0] = i27;
        iArr[1] = i26;
        iArr[2] = i25;
        iArr[c9] = i24;
        iArr[c10] = iM8da2040d8;
        iArr[c11] = iM8da2040d7;
        iArr[c12] = iM8da2040d6;
        iArr[i53] = iM8da2040d5;
        iArr[8] = i23;
        iArr[9] = i22;
        iArr[10] = i21;
        iArr[11] = i20;
        iArr[12] = iM8da2040d4;
        iArr[13] = iM8da2040d3;
        iArr[14] = iM8da2040d2;
        iArr[15] = iM8da2040d;
    }

    protected static int M8da2040d(int i, int i2) {
        return (i >>> (-i2)) | (i << i2);
    }

    void chacha_permute(byte[] bArr, byte[] bArr2) {
        if ((26 + 18) % 18 > 0) {
        }
        int[] iArr = new int[16];
        for (int i = 0; i < 16; i++) {
            iArr[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, i * 4);
        }
        m3f6f0a4f(12, iArr);
        for (int i2 = 0; i2 < 16; i2++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(iArr[i2], bArr, i2 * 4);
        }
    }
}

