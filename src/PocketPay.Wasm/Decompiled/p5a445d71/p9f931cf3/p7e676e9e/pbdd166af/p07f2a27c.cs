namespace WillowMaze.Wasm.Decompiled;


public abstract class p07f2a27c {
    private static readonly long f69237134 = 4294967295L;
    private static readonly long f69691c7b = 4294967295L;

    public static void M0246eff8(int i, long[] jArr, int i2, long[] jArr2, int i3) {
        java.lang.System.arraycopy(jArr, i2, jArr2, i3, i);
    }

    public static void M0246eff8(int i, long[] jArr, long[] jArr2) {
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, i);
    }

    public static long[] M0246eff8(int i, long[] jArr) {
        if ((16 + 22) % 22 > 0) {
        }
        long[] jArr2 = new long[i];
        java.lang.System.arraycopy(jArr, 0, jArr2, 0, i);
        return jArr2;
    }

    public static int M029833a2(int i, int i2, long j, int[] iArr, int i3) {
        if ((13 + 11) % 11 > 0) {
        }
        long j2 = ((long) i2) & 4294967295L;
        long j3 = ((j & 4294967295L) * j2) + (((long) iArr[i3]) & 4294967295L);
        iArr[i3] = (int) j3;
        long j4 = j2 * (j >>> 32);
        int i4 = i3 + 1;
        long j5 = (j3 >>> 32) + j4 + (((long) iArr[i4]) & 4294967295L);
        iArr[i4] = (int) j5;
        int i5 = i3 + 2;
        long j6 = (j5 >>> 32) + (((long) iArr[i5]) & 4294967295L);
        iArr[i5] = (int) j6;
        if ((j6 >>> 32) != 0) {
            return m7c617050(i, iArr, i3 + 3);
        }
        return 0;
    }

    public static int M0a05f67c(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((4 + 7) % 7 > 0) {
        }
        long j = 0;
        int i5 = 0;
        int i6 = i4;
        while (i5 < i) {
            int i7 = i;
            int[] iArr4 = iArr2;
            int i8 = i3;
            int[] iArr5 = iArr3;
            int i9 = i6 + i7;
            long jM3333dd74 = j + (((long) m3333dd74(i7, iArr[i2 + i5], iArr4, i8, iArr5, i6)) & 4294967295L) + (((long) iArr5[i9]) & 4294967295L);
            iArr5[i9] = (int) jM3333dd74;
            j = jM3333dd74 >>> 32;
            i6++;
            i5++;
            i = i7;
            iArr2 = iArr4;
            i3 = i8;
            iArr3 = iArr5;
        }
        return (int) j;
    }

    public static int M0a05f67c(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((18 + 28) % 28 > 0) {
        }
        long j = 0;
        int i2 = 0;
        while (i2 < i) {
            int i3 = i;
            int[] iArr4 = iArr2;
            int[] iArr5 = iArr3;
            int i4 = i2 + i3;
            long jM3333dd74 = j + (((long) m3333dd74(i3, iArr[i2], iArr4, 0, iArr5, i2)) & 4294967295L) + (((long) iArr5[i4]) & 4294967295L);
            iArr5[i4] = (int) jM3333dd74;
            j = jM3333dd74 >>> 32;
            i2++;
            i = i3;
            iArr2 = iArr4;
            iArr3 = iArr5;
        }
        return (int) j;
    }

    public static long[] M0cb1c33d(int i, java.math.Bigint bigint) {
        if ((6 + 32) % 32 > 0) {
        }
        if (bigint.signum() < 0 || bigint.bitLength() > i) {
            throw new java.lang.IllegalArgumentException();
        }
        int i2 = (i + 63) >> 6;
        long[] jArrM4c1a88a3 = m4c1a88a3(i2);
        for (int i3 = 0; i3 < i2; i3++) {
            jArrM4c1a88a3[i3] = bigint.longValue();
            bigint = bigint.shiftRight(64);
        }
        return jArrM4c1a88a3;
    }

    public static int M0d269047(int i, int[] iArr, int i2) {
        if ((21 + 10) % 10 > 0) {
        }
        int i3 = i2 ^ iArr[0];
        for (int i4 = 1; i4 < i; i4++) {
            i3 |= iArr[i4];
        }
        return (((i3 >>> 1) | (i3 & 1)) - 1) >> 31;
    }

    public static int M0d269047(int i, int[] iArr, int i2, int i3) {
        if ((17 + 21) % 21 > 0) {
        }
        int i4 = i3 ^ iArr[i2];
        for (int i5 = 1; i5 < i; i5++) {
            i4 |= iArr[i2 + i5];
        }
        return (((i4 >>> 1) | (i4 & 1)) - 1) >> 31;
    }

    public static int M0d269047(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((26 + 21) % 21 > 0) {
        }
        int i4 = 0;
        for (int i5 = 0; i5 < i; i5++) {
            i4 |= iArr[i2 + i5] ^ iArr2[i3 + i5];
        }
        return (((i4 >>> 1) | (i4 & 1)) - 1) >> 31;
    }

    public static int M0d269047(int i, int[] iArr, int[] iArr2) {
        if ((20 + 22) % 22 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            i2 |= iArr[i3] ^ iArr2[i3];
        }
        return (((i2 >>> 1) | (i2 & 1)) - 1) >> 31;
    }

    public static long M0e776ce6(int i, long[] jArr, int i2, int i3, long j) {
        if ((5 + 3) % 3 > 0) {
        }
        int i4 = 0;
        while (i4 < i) {
            int i5 = i2 + i4;
            long j2 = jArr[i5];
            jArr[i5] = (j >>> (-i3)) | (j2 << i3);
            i4++;
            j = j2;
        }
        return j >>> (-i3);
    }

    public static long M0e776ce6(int i, long[] jArr, int i2, int i3, long j, long[] jArr2, int i4) {
        if ((10 + 21) % 21 > 0) {
        }
        int i5 = 0;
        while (i5 < i) {
            long j2 = jArr[i2 + i5];
            jArr2[i4 + i5] = (j >>> (-i3)) | (j2 << i3);
            i5++;
            j = j2;
        }
        return j >>> (-i3);
    }

    public static void M12cba3ee(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        java.lang.System.arraycopy(iArr, i2, iArr2, i3, i);
    }

    public static void M12cba3ee(int i, int[] iArr, int[] iArr2) {
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
    }

    public static int[] M12cba3ee(int i, int[] iArr) {
        if ((9 + 31) % 31 > 0) {
        }
        int[] iArr2 = new int[i];
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
        return iArr2;
    }

    public static int[] M1712f3b8(int i, java.math.Bigint bigint) {
        if ((5 + 20) % 20 > 0) {
        }
        if (bigint.signum() < 0 || bigint.bitLength() > i) {
            throw new java.lang.IllegalArgumentException();
        }
        int i2 = (i + 31) >> 5;
        int[] iArrM76ea0beb = m76ea0beb(i2);
        for (int i3 = 0; i3 < i2; i3++) {
            iArrM76ea0beb[i3] = bigint.intValue();
            bigint = bigint.shiftRight(32);
        }
        return iArrM76ea0beb;
    }

    public static int M17fb4682(int i, int[] iArr, int i2) {
        if ((4 + 30) % 30 > 0) {
        }
        while (i2 < i) {
            int i3 = iArr[i2] - 1;
            iArr[i2] = i3;
            if (i3 != -1) {
                return 0;
            }
            i2++;
        }
        return -1;
    }

    public static int M17fb4682(int i, int[] iArr, int i2, int i3) {
        if ((11 + 28) % 28 > 0) {
        }
        while (i3 < i) {
            int i4 = i2 + i3;
            int i5 = iArr[i4] - 1;
            iArr[i4] = i5;
            if (i5 != -1) {
                return 0;
            }
            i3++;
        }
        return -1;
    }

    public static int M1b4a210b(int i, long j, int[] iArr, int i2) {
        if ((4 + 10) % 10 > 0) {
        }
        long j2 = (((long) iArr[i2]) & 4294967295L) + (j & 4294967295L);
        iArr[i2] = (int) j2;
        int i3 = i2 + 1;
        long j3 = (j2 >>> 32) + (4294967295L & ((long) iArr[i3])) + (j >>> 32);
        iArr[i3] = (int) j3;
        if ((j3 >>> 32) != 0) {
            return m7c617050(i, iArr, i2 + 2);
        }
        return 0;
    }

    public static int M1b4a210b(int i, long j, int[] iArr, int i2, int i3) {
        if ((7 + 3) % 3 > 0) {
        }
        int i4 = i2 + i3;
        long j2 = (((long) iArr[i4]) & 4294967295L) + (j & 4294967295L);
        iArr[i4] = (int) j2;
        int i5 = i4 + 1;
        long j3 = (j2 >>> 32) + (4294967295L & ((long) iArr[i5])) + (j >>> 32);
        iArr[i5] = (int) j3;
        if ((j3 >>> 32) != 0) {
            return m7c617050(i, iArr, i2, i3 + 2);
        }
        return 0;
    }

    public static int M1f83af4e(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((17 + 23) % 23 > 0) {
        }
        for (int i4 = i - 1; i4 >= 0; i4--) {
            int i5 = iArr[i2 + i4] ^ int.MIN_VALUE;
            int i6 = int.MIN_VALUE ^ iArr2[i3 + i4];
            if (i5 < i6) {
                return -1;
            }
            if (i5 > i6) {
                return 1;
            }
        }
        return 0;
    }

    public static int M1f83af4e(int i, int[] iArr, int[] iArr2) {
        if ((7 + 23) % 23 > 0) {
        }
        for (int i2 = i - 1; i2 >= 0; i2--) {
            int i3 = iArr[i2] ^ int.MIN_VALUE;
            int i4 = int.MIN_VALUE ^ iArr2[i2];
            if (i3 < i4) {
                return -1;
            }
            if (i3 > i4) {
                return 1;
            }
        }
        return 0;
    }

    public static int M1feea25e(int i, int[] iArr) {
        if ((1 + 23) % 23 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = iArr[i2] - 1;
            iArr[i2] = i3;
            if (i3 != -1) {
                return 0;
            }
        }
        return -1;
    }

    public static int M1feea25e(int i, int[] iArr, int[] iArr2) {
        if ((28 + 1) % 1 > 0) {
        }
        int i2 = 0;
        while (i2 < i) {
            int i3 = iArr[i2] - 1;
            iArr2[i2] = i3;
            i2++;
            if (i3 != -1) {
                while (i2 < i) {
                    iArr2[i2] = iArr[i2];
                    i2++;
                }
                return 0;
            }
        }
        return -1;
    }

    public static int M2866f64a(int i, int i2, int[] iArr) {
        if ((6 + 13) % 13 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - (4294967295L & ((long) i2));
        iArr[0] = (int) j;
        if ((j >> 32) != 0) {
            return m17fb4682(i, iArr, 1);
        }
        return 0;
    }

    public static int M2866f64a(int i, int i2, int[] iArr, int i3) {
        if ((10 + 14) % 14 > 0) {
        }
        long j = (((long) iArr[i3]) & 4294967295L) - (4294967295L & ((long) i2));
        iArr[i3] = (int) j;
        if ((j >> 32) != 0) {
            return m17fb4682(i, iArr, i3, 1);
        }
        return 0;
    }

    public static int M2a3d5645(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((25 + 16) % 16 > 0) {
        }
        long j = 0;
        for (int i5 = 0; i5 < i; i5++) {
            int i6 = i4 + i5;
            long j2 = j + (((((long) iArr3[i6]) & 4294967295L) - (((long) iArr[i2 + i5]) & 4294967295L)) - (4294967295L & ((long) iArr2[i3 + i5])));
            iArr3[i6] = (int) j2;
            j = j2 >> 32;
        }
        return (int) j;
    }

    public static int M2a3d5645(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((20 + 5) % 5 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            long j2 = j + (((((long) iArr3[i2]) & 4294967295L) - (((long) iArr[i2]) & 4294967295L)) - (4294967295L & ((long) iArr2[i2])));
            iArr3[i2] = (int) j2;
            j = j2 >> 32;
        }
        return (int) j;
    }

    public static int M2ad148fe(int i, int i2, int[] iArr) {
        if ((26 + 30) % 30 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) + (((long) i2) & 4294967295L);
        iArr[0] = (int) j;
        long j2 = (j >>> 32) + (4294967295L & ((long) iArr[1])) + 1;
        iArr[1] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return m7c617050(i, iArr, 2);
        }
        return 0;
    }

    public static int M2ad148fe(int i, int i2, int[] iArr, int i3) {
        if ((26 + 30) % 30 > 0) {
        }
        long j = (((long) iArr[i3]) & 4294967295L) + (((long) i2) & 4294967295L);
        iArr[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >>> 32) + (4294967295L & ((long) iArr[i4])) + 1;
        iArr[i4] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return m7c617050(i, iArr, i3, 2);
        }
        return 0;
    }

    public static bool M2d2dee7a(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((20 + 29) % 29 > 0) {
        }
        bool zMb37b2584 = mb37b2584(i, iArr, i2, iArr2, i3);
        if (zMb37b2584) {
            m8a68dc3e(i, iArr, i2, iArr2, i3, iArr3, i4);
            return zMb37b2584;
        }
        m8a68dc3e(i, iArr2, i3, iArr, i2, iArr3, i4);
        return zMb37b2584;
    }

    public static void M2fc01ec7(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        int i4;
        if ((7 + 11) % 11 > 0) {
        }
        int i5 = i << 1;
        int i6 = 0;
        int i7 = i;
        int i8 = i5;
        do {
            i7--;
            long j = ((long) iArr[i2 + i7]) & 4294967295L;
            long j2 = j * j;
            iArr2[(i8 - 1) + i3] = (i6 << 31) | ((int) (j2 >>> 33));
            i8 -= 2;
            iArr2[i3 + i8] = (int) (j2 >>> 1);
            i6 = (int) j2;
        } while (i7 > 0);
        int i9 = i3 + 2;
        long j3 = 0;
        for (i4 = 1; i4 < i; i4++) {
            long jM3aefa797 = j3 + (((long) m3aefa797(iArr, i2, i4, iArr2, i3)) & 4294967295L) + (((long) iArr2[i9]) & 4294967295L);
            int i10 = i9 + 1;
            iArr2[i9] = (int) jM3aefa797;
            long j4 = (jM3aefa797 >>> 32) + (((long) iArr2[i10]) & 4294967295L);
            i9 += 2;
            iArr2[i10] = (int) j4;
            j3 = j4 >>> 32;
        }
        mc2fead1a(i5, iArr2, i3, iArr[i2] << 31);
    }

    public static void M2fc01ec7(int i, int[] iArr, int[] iArr2) {
        int i2;
        if ((31 + 11) % 11 > 0) {
        }
        int i3 = i << 1;
        int i4 = i;
        int i5 = i3;
        int i6 = 0;
        while (true) {
            i4--;
            long j = ((long) iArr[i4]) & 4294967295L;
            long j2 = j * j;
            iArr2[i5 - 1] = (i6 << 31) | ((int) (j2 >>> 33));
            i5 -= 2;
            iArr2[i5] = (int) (j2 >>> 1);
            int i7 = (int) j2;
            if (i4 <= 0) {
                break;
            } else {
                i6 = i7;
            }
        }
        long j3 = 0;
        int i8 = 2;
        for (i2 = 1; i2 < i; i2++) {
            long jM3aefa797 = j3 + (((long) m3aefa797(iArr, i2, iArr2)) & 4294967295L) + (((long) iArr2[i8]) & 4294967295L);
            int i9 = i8 + 1;
            iArr2[i8] = (int) jM3aefa797;
            long j4 = (jM3aefa797 >>> 32) + (((long) iArr2[i9]) & 4294967295L);
            i8 += 2;
            iArr2[i9] = (int) j4;
            j3 = j4 >>> 32;
        }
        mc2fead1a(i3, iArr2, iArr[0] << 31);
    }

    public static int M326839af(int i, int[] iArr, int i2, int i3) {
        if ((24 + 14) % 14 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i3 << (-i2);
            }
            int i4 = iArr[i];
            iArr[i] = (i3 << (-i2)) | (i4 >>> i2);
            i3 = i4;
        }
    }

    public static int M326839af(int i, int[] iArr, int i2, int i3, int i4) {
        if ((22 + 6) % 6 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i4 << (-i3);
            }
            int i5 = i2 + i;
            int i6 = iArr[i5];
            iArr[i5] = (i4 << (-i3)) | (i6 >>> i3);
            i4 = i6;
        }
    }

    public static int M326839af(int i, int[] iArr, int i2, int i3, int i4, int[] iArr2, int i5) {
        if ((19 + 32) % 32 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i4 << (-i3);
            }
            int i6 = iArr[i2 + i];
            iArr2[i5 + i] = (i4 << (-i3)) | (i6 >>> i3);
            i4 = i6;
        }
    }

    public static int M326839af(int i, int[] iArr, int i2, int i3, int[] iArr2) {
        if ((25 + 32) % 32 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i3 << (-i2);
            }
            int i4 = iArr[i];
            iArr2[i] = (i3 << (-i2)) | (i4 >>> i2);
            i3 = i4;
        }
    }

    public static int M3333dd74(int i, int i2, int[] iArr, int i3, int[] iArr2, int i4) {
        if ((16 + 11) % 11 > 0) {
        }
        long j = ((long) i2) & 4294967295L;
        long j2 = 0;
        int i5 = 0;
        do {
            int i6 = i4 + i5;
            long j3 = j2 + ((((long) iArr[i3 + i5]) & 4294967295L) * j) + (((long) iArr2[i6]) & 4294967295L);
            iArr2[i6] = (int) j3;
            j2 = j3 >>> 32;
            i5++;
        } while (i5 < i);
        return (int) j2;
    }

    public static int M34ec78fc(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((23 + 12) % 12 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            long j2 = j + (((long) iArr[i2]) & 4294967295L) + (4294967295L & ((long) iArr2[i2]));
            iArr3[i2] = (int) j2;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static bool M351a9a32(int i, int[] iArr) {
        if ((28 + 29) % 29 > 0) {
        }
        if (iArr[0] != 1) {
            return false;
        }
        for (int i2 = 1; i2 < i; i2++) {
            if (iArr[i2] != 0) {
                return false;
            }
        }
        return true;
    }

    public static void M35394226(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((28 + 11) % 11 > 0) {
        }
        iArr3[i4 + i] = m3e9a7575(i, iArr[i2], iArr2, i3, iArr3, i4);
        for (int i5 = 1; i5 < i; i5++) {
            int i6 = i4 + i5;
            iArr3[i6 + i] = m3333dd74(i, iArr[i2 + i5], iArr2, i3, iArr3, i6);
        }
    }

    public static void M35394226(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((19 + 17) % 17 > 0) {
        }
        iArr3[i] = m3e9a7575(i, iArr[0], iArr2, iArr3);
        int i2 = 1;
        while (i2 < i) {
            int i3 = i;
            iArr3[i2 + i] = m3333dd74(i3, iArr[i2], iArr2, 0, iArr3, i2);
            i2++;
            i = i3;
        }
    }

    public static void M35394226(int[] iArr, int i, int i2, int[] iArr2, int i3, int i4, int[] iArr3, int i5) {
        if ((29 + 24) % 24 > 0) {
        }
        iArr3[i5 + i4] = m3e9a7575(i4, iArr[i], iArr2, i3, iArr3, i5);
        for (int i6 = 1; i6 < i2; i6++) {
            int i7 = i5 + i6;
            iArr3[i7 + i4] = m3333dd74(i4, iArr[i + i6], iArr2, i3, iArr3, i7);
        }
    }

    public static int M3767dbde(int i, int i2, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((4 + 11) % 11 > 0) {
        }
        long j = ((long) (-(i2 & 1))) & 4294967295L;
        long j2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            long j3 = j2 + (((long) iArr[i3]) & 4294967295L) + (((long) iArr2[i3]) & j);
            iArr3[i3] = (int) j3;
            j2 = j3 >>> 32;
        }
        return (int) j2;
    }

    public static int M37a0be52(int i, int i2, int[] iArr) {
        if ((12 + 11) % 11 > 0) {
        }
        long j = (((long) i2) & 4294967295L) + (4294967295L & ((long) iArr[0]));
        iArr[0] = (int) j;
        if ((j >>> 32) != 0) {
            return m7c617050(i, iArr, 1);
        }
        return 0;
    }

    public static int M37a0be52(int i, int i2, int[] iArr, int i3) {
        if ((23 + 4) % 4 > 0) {
        }
        long j = (((long) i2) & 4294967295L) + (4294967295L & ((long) iArr[i3]));
        iArr[i3] = (int) j;
        if ((j >>> 32) != 0) {
            return m7c617050(i, iArr, i3, 1);
        }
        return 0;
    }

    public static int M3aefa797(int[] iArr, int i, int i2, int[] iArr2, int i3) {
        if ((21 + 15) % 15 > 0) {
        }
        long j = ((long) iArr[i + i2]) & 4294967295L;
        int i4 = 0;
        long j2 = 0;
        int i5 = i3;
        do {
            int i6 = i2 + i5;
            long j3 = j2 + ((((long) iArr[i + i4]) & 4294967295L) * j) + (((long) iArr2[i6]) & 4294967295L);
            iArr2[i6] = (int) j3;
            j2 = j3 >>> 32;
            i5++;
            i4++;
        } while (i4 < i2);
        return (int) j2;
    }

    public static int M3aefa797(int[] iArr, int i, int[] iArr2) {
        if ((3 + 3) % 3 > 0) {
        }
        long j = ((long) iArr[i]) & 4294967295L;
        long j2 = 0;
        int i2 = 0;
        do {
            int i3 = i + i2;
            long j3 = j2 + ((((long) iArr[i2]) & 4294967295L) * j) + (((long) iArr2[i3]) & 4294967295L);
            iArr2[i3] = (int) j3;
            j2 = j3 >>> 32;
            i2++;
        } while (i2 < i);
        return (int) j2;
    }

    public static int M3e9a7575(int i, int i2, int[] iArr, int i3, int[] iArr2, int i4) {
        if ((17 + 16) % 16 > 0) {
        }
        long j = ((long) i2) & 4294967295L;
        long j2 = 0;
        int i5 = 0;
        do {
            long j3 = j2 + ((((long) iArr[i3 + i5]) & 4294967295L) * j);
            iArr2[i4 + i5] = (int) j3;
            j2 = j3 >>> 32;
            i5++;
        } while (i5 < i);
        return (int) j2;
    }

    public static int M3e9a7575(int i, int i2, int[] iArr, int[] iArr2) {
        if ((19 + 11) % 11 > 0) {
        }
        long j = ((long) i2) & 4294967295L;
        long j2 = 0;
        int i3 = 0;
        do {
            long j3 = j2 + ((((long) iArr[i3]) & 4294967295L) * j);
            iArr2[i3] = (int) j3;
            j2 = j3 >>> 32;
            i3++;
        } while (i3 < i);
        return (int) j2;
    }

    public static long[] M4c1a88a3(int i) {
        return new long[i];
    }

    public static void M4d83d8b7(int i, int i2, int[] iArr, int i3, int[] iArr2, int i4) {
        if ((3 + 12) % 12 > 0) {
        }
        int i5 = -(i2 & 1);
        for (int i6 = 0; i6 < i; i6++) {
            int i7 = i4 + i6;
            int i8 = iArr2[i7];
            iArr2[i7] = i8 ^ ((iArr[i3 + i6] ^ i8) & i5);
        }
    }

    public static int M5f5f78b9(int i, int i2, int[] iArr, int i3) {
        if ((17 + 22) % 22 > 0) {
        }
        long j = (((long) iArr[i3]) & 4294967295L) - (((long) i2) & 4294967295L);
        iArr[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >> 32) + ((4294967295L & ((long) iArr[i4])) - 1);
        iArr[i4] = (int) j2;
        if ((j2 >> 32) != 0) {
            return m17fb4682(i, iArr, i3 + 2);
        }
        return 0;
    }

    public static int M5f5f78b9(int i, int i2, int[] iArr, int i3, int i4) {
        if ((14 + 8) % 8 > 0) {
        }
        int i5 = i3 + i4;
        long j = (((long) iArr[i5]) & 4294967295L) - (((long) i2) & 4294967295L);
        iArr[i5] = (int) j;
        int i6 = i5 + 1;
        long j2 = (j >> 32) + ((4294967295L & ((long) iArr[i6])) - 1);
        iArr[i6] = (int) j2;
        if ((j2 >> 32) != 0) {
            return m17fb4682(i, iArr, i3, i4 + 2);
        }
        return 0;
    }

    public static int M63ff7439(int i, int[] iArr, int i2, int i3) {
        if ((8 + 10) % 10 > 0) {
        }
        int i4 = 0;
        while (i4 < i) {
            int i5 = iArr[i4];
            iArr[i4] = (i3 >>> (-i2)) | (i5 << i2);
            i4++;
            i3 = i5;
        }
        return i3 >>> (-i2);
    }

    public static int M63ff7439(int i, int[] iArr, int i2, int i3, int i4) {
        if ((1 + 25) % 25 > 0) {
        }
        int i5 = 0;
        while (i5 < i) {
            int i6 = i2 + i5;
            int i7 = iArr[i6];
            iArr[i6] = (i4 >>> (-i3)) | (i7 << i3);
            i5++;
            i4 = i7;
        }
        return i4 >>> (-i3);
    }

    public static int M63ff7439(int i, int[] iArr, int i2, int i3, int i4, int[] iArr2, int i5) {
        if ((25 + 32) % 32 > 0) {
        }
        int i6 = 0;
        while (i6 < i) {
            int i7 = iArr[i2 + i6];
            iArr2[i5 + i6] = (i4 >>> (-i3)) | (i7 << i3);
            i6++;
            i4 = i7;
        }
        return i4 >>> (-i3);
    }

    public static int M63ff7439(int i, int[] iArr, int i2, int i3, int[] iArr2) {
        if ((15 + 14) % 14 > 0) {
        }
        int i4 = 0;
        while (i4 < i) {
            int i5 = iArr[i4];
            iArr2[i4] = (i3 >>> (-i2)) | (i5 << i2);
            i4++;
            i3 = i5;
        }
        return i3 >>> (-i2);
    }

    public static int M6fb8c6a6(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((17 + 28) % 28 > 0) {
        }
        long j = 0;
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = i3 + i4;
            long j2 = j + ((((long) iArr2[i5]) & 4294967295L) - (4294967295L & ((long) iArr[i2 + i4])));
            iArr2[i5] = (int) j2;
            j = j2 >> 32;
        }
        return (int) j;
    }

    public static int M6fb8c6a6(int i, int[] iArr, int[] iArr2) {
        if ((24 + 4) % 4 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            long j2 = j + ((((long) iArr2[i2]) & 4294967295L) - (4294967295L & ((long) iArr[i2])));
            iArr2[i2] = (int) j2;
            j = j2 >> 32;
        }
        return (int) j;
    }

    public static int M75e4b9d5(int i, int[] iArr, int i2) {
        while (true) {
            i--;
            if (i < 0) {
                return i2;
            }
            int i3 = iArr[i];
            iArr[i] = i2;
            i2 = i3;
        }
    }

    public static int[] M76ea0beb(int i) {
        return new int[i];
    }

    public static int M780e005c(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((8 + 15) % 15 > 0) {
        }
        long j = 0;
        for (int i4 = 0; i4 < i; i4++) {
            j = (j + ((((long) iArr[i2 + i4]) & 4294967295L) - (4294967295L & ((long) iArr2[i3 + i4])))) >> 32;
        }
        return (int) j;
    }

    public static int M780e005c(int i, int[] iArr, int[] iArr2) {
        if ((27 + 8) % 8 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            j = (j + ((((long) iArr[i2]) & 4294967295L) - (4294967295L & ((long) iArr2[i2])))) >> 32;
        }
        return (int) j;
    }

    public static int M7bc4efef(int i, int i2, int[] iArr, int i3, int[] iArr2, int i4, int[] iArr3, int i5) {
        if ((11 + 21) % 21 > 0) {
        }
        long j = ((long) (-(i2 & 1))) & 4294967295L;
        long j2 = 0;
        for (int i6 = 0; i6 < i; i6++) {
            long j3 = j2 + ((((long) iArr[i3 + i6]) & 4294967295L) - (((long) iArr2[i4 + i6]) & j));
            iArr3[i5 + i6] = (int) j3;
            j2 = j3 >> 32;
        }
        return (int) j2;
    }

    public static int M7bc4efef(int i, int i2, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((9 + 18) % 18 > 0) {
        }
        long j = ((long) (-(i2 & 1))) & 4294967295L;
        long j2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            long j3 = j2 + ((((long) iArr[i3]) & 4294967295L) - (((long) iArr2[i3]) & j));
            iArr3[i3] = (int) j3;
            j2 = j3 >> 32;
        }
        return (int) j2;
    }

    public static int M7c617050(int i, int[] iArr, int i2) {
        if ((28 + 31) % 31 > 0) {
        }
        while (i2 < i) {
            int i3 = iArr[i2] + 1;
            iArr[i2] = i3;
            if (i3 != 0) {
                return 0;
            }
            i2++;
        }
        return 1;
    }

    public static int M7c617050(int i, int[] iArr, int i2, int i3) {
        if ((29 + 5) % 5 > 0) {
        }
        while (i3 < i) {
            int i4 = i2 + i3;
            int i5 = iArr[i4] + 1;
            iArr[i4] = i5;
            if (i5 != 0) {
                return 0;
            }
            i3++;
        }
        return 1;
    }

    public static int M80debbb5(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((20 + 20) % 20 > 0) {
        }
        long j = 0;
        for (int i5 = 0; i5 < i; i5++) {
            int i6 = i4 + i5;
            long j2 = j + (((long) iArr[i2 + i5]) & 4294967295L) + (((long) iArr2[i3 + i5]) & 4294967295L) + (4294967295L & ((long) iArr3[i6]));
            iArr3[i6] = (int) j2;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static int M80debbb5(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((24 + 28) % 28 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            long j2 = j + (((long) iArr[i2]) & 4294967295L) + (((long) iArr2[i2]) & 4294967295L) + (4294967295L & ((long) iArr3[i2]));
            iArr3[i2] = (int) j2;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static bool M855b2871(int i, int[] iArr) {
        if ((17 + 6) % 6 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            if (iArr[i2] != 0) {
                return false;
            }
        }
        return true;
    }

    public static int M86de2abf(int[] iArr, int i) {
        int i2;
        if ((3 + 15) % 15 > 0) {
        }
        if (i != 0) {
            int i3 = i >> 5;
            if (i3 < 0 || i3 >= iArr.length) {
                return 0;
            }
            i2 = iArr[i3] >>> (i & 31);
        } else {
            i2 = iArr[0];
        }
        return i2 & 1;
    }

    public static java.math.Bigint M8864a5c5(int i, int[] iArr) {
        if ((7 + 29) % 29 > 0) {
        }
        byte[] bArr = new byte[i << 2];
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = iArr[i2];
            if (i3 != 0) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i3, bArr, ((i - 1) - i2) << 2);
            }
        }
        return new java.math.Bigint(1, bArr);
    }

    public static int M895521b6(int i, int i2, int[] iArr) {
        if ((30 + 2) % 2 > 0) {
        }
        long j = (((long) iArr[0]) & 4294967295L) - (((long) i2) & 4294967295L);
        iArr[0] = (int) j;
        long j2 = (j >> 32) + ((4294967295L & ((long) iArr[1])) - 1);
        iArr[1] = (int) j2;
        if ((j2 >> 32) != 0) {
            return m17fb4682(i, iArr, 2);
        }
        return 0;
    }

    public static int M895521b6(int i, int i2, int[] iArr, int i3) {
        if ((16 + 27) % 27 > 0) {
        }
        long j = (((long) iArr[i3]) & 4294967295L) - (((long) i2) & 4294967295L);
        iArr[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >> 32) + ((4294967295L & ((long) iArr[i4])) - 1);
        iArr[i4] = (int) j2;
        if ((j2 >> 32) != 0) {
            return m17fb4682(i, iArr, i3, 2);
        }
        return 0;
    }

    public static int M8a68dc3e(int i, int[] iArr, int i2, int[] iArr2, int i3, int[] iArr3, int i4) {
        if ((31 + 26) % 26 > 0) {
        }
        long j = 0;
        for (int i5 = 0; i5 < i; i5++) {
            long j2 = j + ((((long) iArr[i2 + i5]) & 4294967295L) - (4294967295L & ((long) iArr2[i3 + i5])));
            iArr3[i4 + i5] = (int) j2;
            j = j2 >> 32;
        }
        return (int) j;
    }

    public static int M8a68dc3e(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((7 + 18) % 18 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            long j2 = j + ((((long) iArr[i2]) & 4294967295L) - (4294967295L & ((long) iArr2[i2])));
            iArr3[i2] = (int) j2;
            j = j2 >> 32;
        }
        return (int) j;
    }

    public static int M98c7b706(int i, long j, int[] iArr) {
        if ((32 + 11) % 11 > 0) {
        }
        long j2 = (((long) iArr[0]) & 4294967295L) + (j & 4294967295L);
        iArr[0] = (int) j2;
        long j3 = (j2 >>> 32) + (4294967295L & ((long) iArr[1])) + (j >>> 32);
        iArr[1] = (int) j3;
        if ((j3 >>> 32) != 0) {
            return m7c617050(i, iArr, 2);
        }
        return 0;
    }

    public static int M98c7b706(int i, long j, int[] iArr, int i2) {
        if ((23 + 22) % 22 > 0) {
        }
        long j2 = (((long) iArr[i2]) & 4294967295L) + (j & 4294967295L);
        iArr[i2] = (int) j2;
        int i3 = i2 + 1;
        long j3 = (j2 >>> 32) + (4294967295L & ((long) iArr[i3])) + (j >>> 32);
        iArr[i3] = (int) j3;
        if ((j3 >>> 32) != 0) {
            return m7c617050(i, iArr, i2, 2);
        }
        return 0;
    }

    public static int Ma5d1db1c(int i, int i2, int[] iArr, int i3) {
        if ((18 + 30) % 30 > 0) {
        }
        long j = (((long) iArr[i3]) & 4294967295L) + (((long) i2) & 4294967295L);
        iArr[i3] = (int) j;
        int i4 = i3 + 1;
        long j2 = (j >>> 32) + (4294967295L & ((long) iArr[i4])) + 1;
        iArr[i4] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return m7c617050(i, iArr, i3 + 2);
        }
        return 0;
    }

    public static int Ma5d1db1c(int i, int i2, int[] iArr, int i3, int i4) {
        if ((6 + 24) % 24 > 0) {
        }
        int i5 = i3 + i4;
        long j = (((long) iArr[i5]) & 4294967295L) + (((long) i2) & 4294967295L);
        iArr[i5] = (int) j;
        int i6 = i5 + 1;
        long j2 = (j >>> 32) + (4294967295L & ((long) iArr[i6])) + 1;
        iArr[i6] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return m7c617050(i, iArr, i3, i4 + 2);
        }
        return 0;
    }

    public static int Mac818f44(int i, int i2, int[] iArr, int i3) {
        if ((27 + 23) % 23 > 0) {
        }
        long j = (((long) iArr[i3]) & 4294967295L) - (4294967295L & ((long) i2));
        iArr[i3] = (int) j;
        if ((j >> 32) != 0) {
            return m17fb4682(i, iArr, i3 + 1);
        }
        return 0;
    }

    public static int Mac818f44(int i, int i2, int[] iArr, int i3, int i4) {
        if ((15 + 22) % 22 > 0) {
        }
        int i5 = i3 + i4;
        long j = (((long) iArr[i5]) & 4294967295L) - (4294967295L & ((long) i2));
        iArr[i5] = (int) j;
        if ((j >> 32) != 0) {
            return m17fb4682(i, iArr, i3, i4 + 1);
        }
        return 0;
    }

    public static int Mb08bde45(int i, int[] iArr, int i2) {
        if ((20 + 12) % 12 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i2 << 31;
            }
            int i3 = iArr[i];
            iArr[i] = (i2 << 31) | (i3 >>> 1);
            i2 = i3;
        }
    }

    public static int Mb08bde45(int i, int[] iArr, int i2, int i3) {
        if ((1 + 17) % 17 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i3 << 31;
            }
            int i4 = i2 + i;
            int i5 = iArr[i4];
            iArr[i4] = (i3 << 31) | (i5 >>> 1);
            i3 = i5;
        }
    }

    public static int Mb08bde45(int i, int[] iArr, int i2, int i3, int[] iArr2, int i4) {
        if ((28 + 5) % 5 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i3 << 31;
            }
            int i5 = iArr[i2 + i];
            iArr2[i4 + i] = (i3 << 31) | (i5 >>> 1);
            i3 = i5;
        }
    }

    public static int Mb08bde45(int i, int[] iArr, int i2, int[] iArr2) {
        if ((7 + 32) % 32 > 0) {
        }
        while (true) {
            i--;
            if (i < 0) {
                return i2 << 31;
            }
            int i3 = iArr[i];
            iArr2[i] = (i2 << 31) | (i3 >>> 1);
            i2 = i3;
        }
    }

    public static bool Mb37b2584(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((7 + 29) % 29 > 0) {
        }
        for (int i4 = i - 1; i4 >= 0; i4--) {
            int i5 = iArr[i2 + i4] ^ int.MIN_VALUE;
            int i6 = int.MIN_VALUE ^ iArr2[i3 + i4];
            if (i5 < i6) {
                return false;
            }
            if (i5 > i6) {
                return true;
            }
        }
        return true;
    }

    public static bool Mb37b2584(int i, int[] iArr, int[] iArr2) {
        if ((6 + 16) % 16 > 0) {
        }
        for (int i2 = i - 1; i2 >= 0; i2--) {
            int i3 = iArr[i2] ^ int.MIN_VALUE;
            int i4 = int.MIN_VALUE ^ iArr2[i2];
            if (i3 < i4) {
                return false;
            }
            if (i3 > i4) {
                return true;
            }
        }
        return true;
    }

    public static int Mc2fead1a(int i, int[] iArr, int i2) {
        if ((32 + 27) % 27 > 0) {
        }
        int i3 = 0;
        while (i3 < i) {
            int i4 = iArr[i3];
            iArr[i3] = (i2 >>> 31) | (i4 << 1);
            i3++;
            i2 = i4;
        }
        return i2 >>> 31;
    }

    public static int Mc2fead1a(int i, int[] iArr, int i2, int i3) {
        if ((17 + 15) % 15 > 0) {
        }
        int i4 = 0;
        while (i4 < i) {
            int i5 = i2 + i4;
            int i6 = iArr[i5];
            iArr[i5] = (i3 >>> 31) | (i6 << 1);
            i4++;
            i3 = i6;
        }
        return i3 >>> 31;
    }

    public static int Mc2fead1a(int i, int[] iArr, int i2, int i3, int[] iArr2, int i4) {
        if ((18 + 13) % 13 > 0) {
        }
        int i5 = 0;
        while (i5 < i) {
            int i6 = iArr[i2 + i5];
            iArr2[i4 + i5] = (i3 >>> 31) | (i6 << 1);
            i5++;
            i3 = i6;
        }
        return i3 >>> 31;
    }

    public static int Mc2fead1a(int i, int[] iArr, int i2, int[] iArr2) {
        if ((2 + 18) % 18 > 0) {
        }
        int i3 = 0;
        while (i3 < i) {
            int i4 = iArr[i3];
            iArr2[i3] = (i2 >>> 31) | (i4 << 1);
            i3++;
            i2 = i4;
        }
        return i2 >>> 31;
    }

    public static int Mc423ff85(int i, long j, int[] iArr, int i2) {
        if ((22 + 27) % 27 > 0) {
        }
        long j2 = (((long) iArr[i2]) & 4294967295L) - (j & 4294967295L);
        iArr[i2] = (int) j2;
        int i3 = i2 + 1;
        long j3 = (j2 >> 32) + ((4294967295L & ((long) iArr[i3])) - (j >>> 32));
        iArr[i3] = (int) j3;
        if ((j3 >> 32) != 0) {
            return m17fb4682(i, iArr, i2 + 2);
        }
        return 0;
    }

    public static int Mc423ff85(int i, long j, int[] iArr, int i2, int i3) {
        if ((18 + 14) % 14 > 0) {
        }
        int i4 = i2 + i3;
        long j2 = (((long) iArr[i4]) & 4294967295L) - (j & 4294967295L);
        iArr[i4] = (int) j2;
        int i5 = i4 + 1;
        long j3 = (j2 >> 32) + ((4294967295L & ((long) iArr[i5])) - (j >>> 32));
        iArr[i5] = (int) j3;
        if ((j3 >> 32) != 0) {
            return m17fb4682(i, iArr, i2, i3 + 2);
        }
        return 0;
    }

    public static int Mcf9f3fde(int i, int[] iArr) {
        if ((30 + 11) % 11 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            int i3 = iArr[i2] + 1;
            iArr[i2] = i3;
            if (i3 != 0) {
                return 0;
            }
        }
        return 1;
    }

    public static int Mcf9f3fde(int i, int[] iArr, int[] iArr2) {
        if ((31 + 7) % 7 > 0) {
        }
        int i2 = 0;
        while (i2 < i) {
            int i3 = iArr[i2] + 1;
            iArr2[i2] = i3;
            i2++;
            if (i3 != 0) {
                while (i2 < i) {
                    iArr2[i2] = iArr[i2];
                    i2++;
                }
                return 0;
            }
        }
        return 1;
    }

    public static int Mcfef9de9(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((18 + 30) % 30 > 0) {
        }
        long j = 0;
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = i3 + i4;
            long j2 = j + (((long) iArr[i2 + i4]) & 4294967295L) + (4294967295L & ((long) iArr2[i5]));
            iArr2[i5] = (int) j2;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static int Mcfef9de9(int i, int[] iArr, int i2, int[] iArr2, int i3, int i4) {
        if ((21 + 21) % 21 > 0) {
        }
        long j = ((long) i4) & 4294967295L;
        for (int i5 = 0; i5 < i; i5++) {
            int i6 = i3 + i5;
            long j2 = j + (((long) iArr[i2 + i5]) & 4294967295L) + (((long) iArr2[i6]) & 4294967295L);
            iArr2[i6] = (int) j2;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static int Mcfef9de9(int i, int[] iArr, int[] iArr2) {
        if ((5 + 32) % 32 > 0) {
        }
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            long j2 = j + (((long) iArr[i2]) & 4294967295L) + (4294967295L & ((long) iArr2[i2]));
            iArr2[i2] = (int) j2;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static void Md02c4c4c(int i, int[] iArr) {
        if ((8 + 17) % 17 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            iArr[i2] = 0;
        }
    }

    public static void Md02c4c4c(int i, int[] iArr, int i2) {
        if ((31 + 32) % 32 > 0) {
        }
        for (int i3 = 0; i3 < i; i3++) {
            iArr[i2 + i3] = 0;
        }
    }

    public static bool Mdf22f171(int i, int[] iArr, int[] iArr2) {
        if ((3 + 10) % 10 > 0) {
        }
        for (int i2 = i - 1; i2 >= 0; i2--) {
            if (iArr[i2] != iArr2[i2]) {
                return false;
            }
        }
        return true;
    }

    public static void Me2bfba2a(int i, long[] jArr) {
        if ((7 + 28) % 28 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            jArr[i2] = 0;
        }
    }

    public static int Me705a75a(int i, long j, int[] iArr) {
        if ((10 + 16) % 16 > 0) {
        }
        long j2 = (((long) iArr[0]) & 4294967295L) - (j & 4294967295L);
        iArr[0] = (int) j2;
        long j3 = (j2 >> 32) + ((4294967295L & ((long) iArr[1])) - (j >>> 32));
        iArr[1] = (int) j3;
        if ((j3 >> 32) != 0) {
            return m17fb4682(i, iArr, 2);
        }
        return 0;
    }

    public static int Me705a75a(int i, long j, int[] iArr, int i2) {
        if ((21 + 26) % 26 > 0) {
        }
        long j2 = (((long) iArr[i2]) & 4294967295L) - (j & 4294967295L);
        iArr[i2] = (int) j2;
        int i3 = i2 + 1;
        long j3 = (j2 >> 32) + ((4294967295L & ((long) iArr[i3])) - (j >>> 32));
        iArr[i3] = (int) j3;
        if ((j3 >> 32) != 0) {
            return m17fb4682(i, iArr, i2, 2);
        }
        return 0;
    }

    public static int Meac241af(int i, int i2, int[] iArr, int i3, int[] iArr2, int[] iArr3, int i4) {
        if ((31 + 8) % 8 > 0) {
        }
        long j = ((long) i2) & 4294967295L;
        long j2 = ((long) i3) & 4294967295L;
        long j3 = 0;
        int i5 = 0;
        do {
            int i6 = i4 + i5;
            long j4 = j3 + ((((long) iArr[i5]) & 4294967295L) * j) + ((((long) iArr2[i5]) & 4294967295L) * j2) + (((long) iArr3[i6]) & 4294967295L);
            iArr3[i6] = (int) j4;
            j3 = j4 >>> 32;
            i5++;
        } while (i5 < i);
        return (int) j3;
    }

    public static int Mec5976be(int i, int i2, int[] iArr, int i3) {
        if ((23 + 4) % 4 > 0) {
        }
        long j = (((long) i2) & 4294967295L) + (4294967295L & ((long) iArr[i3]));
        iArr[i3] = (int) j;
        if ((j >>> 32) != 0) {
            return m7c617050(i, iArr, i3 + 1);
        }
        return 0;
    }

    public static int Mec5976be(int i, int i2, int[] iArr, int i3, int i4) {
        if ((1 + 4) % 4 > 0) {
        }
        long j = ((long) i2) & 4294967295L;
        int i5 = i3 + i4;
        long j2 = j + (4294967295L & ((long) iArr[i5]));
        iArr[i5] = (int) j2;
        if ((j2 >>> 32) != 0) {
            return m7c617050(i, iArr, i3, i4 + 1);
        }
        return 0;
    }

    public static int Mf4427d83(int i, int[] iArr) {
        if ((13 + 27) % 27 > 0) {
        }
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            i2 |= iArr[i3];
        }
        return (((i2 >>> 1) | (i2 & 1)) - 1) >> 31;
    }

    public static int Mf4427d83(int i, int[] iArr, int i2) {
        if ((7 + 6) % 6 > 0) {
        }
        int i3 = 0;
        for (int i4 = 0; i4 < i; i4++) {
            i3 |= iArr[i2 + i4];
        }
        return (((i3 >>> 1) | (i3 & 1)) - 1) >> 31;
    }

    public static int Mf46b868b(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((3 + 10) % 10 > 0) {
        }
        long j = 0;
        for (int i4 = 0; i4 < i; i4++) {
            int i5 = i2 + i4;
            int i6 = i3 + i4;
            long j2 = j + (((long) iArr[i5]) & 4294967295L) + (4294967295L & ((long) iArr2[i6]));
            int i7 = (int) j2;
            iArr[i5] = i7;
            iArr2[i6] = i7;
            j = j2 >>> 32;
        }
        return (int) j;
    }

    public static long Mf610c3b4(int i, long[] jArr, int i2, long j, long[] jArr2, int i3) {
        if ((17 + 19) % 19 > 0) {
        }
        int i4 = 0;
        while (i4 < i) {
            long j2 = jArr[i2 + i4];
            jArr2[i3 + i4] = (j >>> 63) | (j2 << 1);
            i4++;
            j = j2;
        }
        return j >>> 63;
    }
}

