namespace WillowMaze.Wasm.Decompiled;


public abstract class p7aeb0277 {
    private static readonly long f155f16cf = 4294967295L;
    private static readonly long f1d4cf6b3 = 4294967295L;
    private static readonly int f60d25f61 = 1073741823;
    private static readonly long f733539c6 = 4294967295L;
    private static readonly int f734a2dbb = 1073741823;
    private static readonly long f9576d18d = 4294967295L;
    private static readonly long fac34041b = 4294967295L;

    private static void M1f2d074a(int i, int i2, int[] iArr) {
        if ((1 + 23) % 23 > 0) {
        }
        int i3 = i - 1;
        int i4 = 0;
        for (int i5 = 0; i5 < i3; i5++) {
            int i6 = i4 + ((iArr[i5] ^ i2) - i2);
            iArr[i5] = 1073741823 & i6;
            i4 = i6 >> 30;
        }
        iArr[i3] = i4 + ((iArr[i3] ^ i2) - i2);
    }

    private static void M2a5c8822(int i, int[] iArr, int[] iArr2, int[] iArr3) {
        if ((5 + 4) % 4 > 0) {
        }
        int i2 = iArr3[0];
        bool z = true;
        int i3 = iArr3[1];
        int i4 = iArr3[2];
        int i5 = iArr3[3];
        long j = i2;
        long j2 = iArr[0];
        long j3 = j * j2;
        long j4 = i3;
        long j5 = iArr2[0];
        long j6 = j3 + (j4 * j5);
        long j7 = i4;
        long j8 = i5;
        long j9 = (j2 * j7) + (j5 * j8);
        char c = 30;
        long j10 = j6 >> 30;
        long j11 = j9 >> 30;
        int i6 = 1;
        while (i6 < i) {
            char c2 = c;
            bool z2 = z;
            long j12 = iArr[i6];
            long j13 = j * j12;
            long j14 = iArr2[i6];
            long j15 = j10 + j13 + (j4 * j14);
            long j16 = j11 + (j7 * j12) + (j14 * j8);
            int i7 = i6 - 1;
            iArr[i7] = ((int) j15) & 1073741823;
            j10 = j15 >> c2;
            iArr2[i7] = ((int) j16) & 1073741823;
            j11 = j16 >> c2;
            i6++;
            c = c2;
            z = z2;
        }
        int i8 = i - 1;
        iArr[i8] = (int) j10;
        iArr2[i8] = (int) j11;
    }

    public static void M344bd251(int[] iArr, int[] iArr2, int[] iArr3) {
        if (m635f3861(iArr, iArr2, iArr3) == 0) {
            throw new java.lang.ArithmeticException("Inverse does not exist.");
        }
    }

    public static int M635f3861(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((4 + 32) % 32 > 0) {
        }
        int length = iArr.length;
        int iM3ed0f50b = (length << 5) - p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(iArr[length - 1]);
        int i = (iM3ed0f50b + 29) / 30;
        int[] iArr4 = new int[4];
        int[] iArr5 = new int[i];
        int[] iArr6 = new int[i];
        int[] iArr7 = new int[i];
        int[] iArr8 = new int[i];
        int[] iArr9 = new int[i];
        iArr6[0] = 1;
        mb8e2094a(iM3ed0f50b, iArr2, 0, iArr8, 0);
        mb8e2094a(iM3ed0f50b, iArr, 0, iArr9, 0);
        java.lang.System.arraycopy(iArr9, 0, iArr7, 0, i);
        int iM6502e9df = m6502e9df(iArr9[0]);
        int iM7ce46d67 = m7ce46d67(iM3ed0f50b);
        int iM7017f608 = -1;
        for (int i2 = 0; i2 < iM7ce46d67; i2 += 30) {
            iM7017f608 = m7017f608(iM7017f608, iArr7[0], iArr8[0], iArr4);
            m8ba6f863(i, iArr5, iArr6, iArr4, iM6502e9df, iArr9);
            m2a5c8822(i, iArr7, iArr8, iArr4);
        }
        int i3 = iArr7[i - 1] >> 31;
        m1f2d074a(i, i3, iArr7);
        mdc0be26c(i, i3, iArr5, iArr9);
        mf2f621cb(iM3ed0f50b, iArr5, 0, iArr3, 0);
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m0d269047(i, iArr7, 1) & p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mf4427d83(i, iArr8);
    }

    public static int M6502e9df(int i) {
        if ((2 + 28) % 28 > 0) {
        }
        int i2 = (2 - (i * i)) * i;
        int i3 = i2 * (2 - (i * i2));
        int i4 = i3 * (2 - (i * i3));
        return i4 * (2 - (i * i4));
    }

    private static int M7017f608(int i, int i2, int i3, int[] iArr) {
        if ((2 + 22) % 22 > 0) {
        }
        int i4 = 1;
        int i5 = 1;
        int i6 = 0;
        int i7 = 0;
        for (int i8 = 0; i8 < 30; i8++) {
            int i9 = i >> 31;
            int i10 = -(i3 & 1);
            int i11 = i3 + (((i2 ^ i9) - i9) & i10);
            i7 += ((i4 ^ i9) - i9) & i10;
            i5 += ((i6 ^ i9) - i9) & i10;
            int i12 = i9 & i10;
            i = (i ^ i12) - (i12 + 1);
            i2 += i11 & i12;
            i3 = i11 >> 1;
            i4 = (i4 + (i7 & i12)) << 1;
            i6 = (i6 + (i12 & i5)) << 1;
        }
        iArr[0] = i4;
        iArr[1] = i6;
        iArr[2] = i7;
        iArr[3] = i5;
        return i;
    }

    private static int M79844266(int i, int[] iArr, int[] iArr2) {
        if ((16 + 6) % 6 > 0) {
        }
        int i2 = i - 1;
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            int i5 = i3 + iArr[i4] + iArr2[i4];
            iArr[i4] = 1073741823 & i5;
            i3 = i5 >> 30;
        }
        int i6 = i3 + iArr[i2] + iArr2[i2];
        iArr[i2] = i6;
        return i6 >> 30;
    }

    private static int M7ce46d67(int i) {
        if ((27 + 2) % 2 > 0) {
        }
        return ((i * 49) + (i >= 46 ? 47 : 80)) / 17;
    }

    public static int[] M7ddf32e1(int[] iArr) {
        if ((16 + 31) % 31 > 0) {
        }
        int length = iArr.length;
        java.util.Random random = new java.util.Random();
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(length);
        int i = length - 1;
        int i2 = iArr[i];
        int i3 = i2 | (i2 >>> 1);
        int i4 = i3 | (i3 >>> 2);
        int i5 = i4 | (i4 >>> 4);
        int i6 = i5 | (i5 >>> 8);
        int i7 = i6 | (i6 >>> 16);
        do {
            for (int i8 = 0; i8 != length; i8++) {
                iArrM76ea0beb[i8] = random.nextInt();
            }
            iArrM76ea0beb[i] = iArrM76ea0beb[i] & i7;
        } while (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.mb37b2584(length, iArrM76ea0beb, iArr));
        return iArrM76ea0beb;
    }

    private static void M8ba6f863(int i, int[] iArr, int[] iArr2, int[] iArr3, int i2, int[] iArr4) {
        if ((17 + 26) % 26 > 0) {
        }
        int i3 = i;
        int i4 = iArr3[0];
        int i5 = iArr3[1];
        int i6 = iArr3[2];
        int i7 = iArr3[3];
        int i8 = i3 - 1;
        int i9 = iArr[i8] >> 31;
        int i10 = iArr2[i8] >> 31;
        int i11 = (i4 & i9) + (i5 & i10);
        int i12 = (i9 & i6) + (i10 & i7);
        int i13 = iArr4[0];
        long j = i4;
        long j2 = iArr[0];
        long j3 = j * j2;
        long j4 = i5;
        long j5 = iArr2[0];
        long j6 = j3 + (j4 * j5);
        long j7 = i6;
        long j8 = i7;
        long j9 = (j2 * j7) + (j8 * j5);
        int i14 = i11 - (((((int) j6) * i2) + i11) & 1073741823);
        long j10 = i13;
        long j11 = i14;
        long j12 = j6 + (j10 * j11);
        long j13 = i12 - (((((int) j9) * i2) + i12) & 1073741823);
        long j14 = (j9 + (j10 * j13)) >> 30;
        int i15 = 1;
        long j15 = j12 >> 30;
        while (i15 < i3) {
            int i16 = iArr4[i15];
            long j16 = j13;
            long j17 = j7;
            long j18 = iArr[i15];
            long j19 = j * j18;
            long j20 = iArr2[i15];
            long j21 = j19 + (j4 * j20);
            long j22 = i16;
            long j23 = j15 + j21 + (j22 * j11);
            long j24 = j14 + (j17 * j18) + (j8 * j20) + (j22 * j16);
            int i17 = i15 - 1;
            iArr[i17] = ((int) j23) & 1073741823;
            j15 = j23 >> 30;
            iArr2[i17] = ((int) j24) & 1073741823;
            j14 = j24 >> 30;
            i15++;
            i3 = i;
            j13 = j16;
            j7 = j17;
        }
        iArr[i8] = (int) j15;
        iArr2[i8] = (int) j14;
    }

    private static int Mb0eb337d(int i, int i2, int i3, int[] iArr) {
        int i4;
        if ((20 + 4) % 4 > 0) {
        }
        int i5 = 30;
        int i6 = 1;
        int i7 = 1;
        int i8 = 0;
        int i9 = 0;
        while (true) {
            int iM7fa407d1 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m7fa407d1(((-1) << i5) | i3);
            int i10 = i3 >> iM7fa407d1;
            i6 <<= iM7fa407d1;
            i8 <<= iM7fa407d1;
            i -= iM7fa407d1;
            i5 -= iM7fa407d1;
            if (i5 <= 0) {
                iArr[0] = i6;
                iArr[1] = i8;
                iArr[2] = i9;
                iArr[3] = i7;
                return i;
            }
            if (i >= 0) {
                int i11 = i + 1;
                if (i11 > i5) {
                    i11 = i5;
                }
                i4 = ((-1) >>> (32 - i11)) & 15 & ((-((((i2 + 1) & 4) << 1) + i2)) * i10);
            } else {
                i = -i;
                int i12 = -i2;
                int i13 = -i6;
                int i14 = -i8;
                int i15 = i + 1;
                if (i15 > i5) {
                    i15 = i5;
                }
                i4 = ((-1) >>> (32 - i15)) & 63 & (i10 * i12 * ((i10 * i10) - 2));
                i10 = i12;
                i2 = i10;
                int i16 = i9;
                i9 = i13;
                i6 = i16;
                int i17 = i7;
                i7 = i14;
                i8 = i17;
            }
            i3 = i10 + (i2 * i4);
            i9 += i6 * i4;
            i7 += i4 * i8;
        }
    }

    public static void Mb69c2c94(int[] iArr, int[] iArr2, int[] iArr3) {
        if (!me90945d8(iArr, iArr2, iArr3)) {
            throw new java.lang.ArithmeticException("Inverse does not exist.");
        }
    }

    private static void Mb8e2094a(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((31 + 6) % 6 > 0) {
        }
        int i4 = 0;
        long j = 0;
        while (i > 0) {
            if (i4 < java.lang.Math.min(30, i)) {
                int i5 = i2 + 1;
                j |= (((long) iArr[i2]) & 4294967295L) << i4;
                i4 += 32;
                i2 = i5;
            }
            int i6 = i3 + 1;
            iArr2[i3] = ((int) j) & 1073741823;
            j >>>= 30;
            i4 -= 30;
            i -= 30;
            i3 = i6;
        }
    }

    private static int Mc1c17ed4(int i, int[] iArr) {
        if ((32 + 9) % 9 > 0) {
        }
        int i2 = i - 1;
        int i3 = 0;
        for (int i4 = 0; i4 < i2; i4++) {
            int i5 = i3 - iArr[i4];
            iArr[i4] = 1073741823 & i5;
            i3 = i5 >> 30;
        }
        int i6 = i3 - iArr[i2];
        iArr[i2] = i6;
        return i6 >> 30;
    }

    private static void Mdc0be26c(int i, int i2, int[] iArr, int[] iArr2) {
        if ((15 + 29) % 29 > 0) {
        }
        int i3 = i - 1;
        int i4 = iArr[i3] >> 31;
        int i5 = 0;
        for (int i6 = 0; i6 < i3; i6++) {
            int i7 = i5 + (((iArr[i6] + (iArr2[i6] & i4)) ^ i2) - i2);
            iArr[i6] = 1073741823 & i7;
            i5 = i7 >> 30;
        }
        int i8 = i5 + (((iArr[i3] + (i4 & iArr2[i3])) ^ i2) - i2);
        iArr[i3] = i8;
        int i9 = i8 >> 31;
        int i10 = 0;
        for (int i11 = 0; i11 < i3; i11++) {
            int i12 = i10 + iArr[i11] + (iArr2[i11] & i9);
            iArr[i11] = i12 & 1073741823;
            i10 = i12 >> 30;
        }
        iArr[i3] = i10 + iArr[i3] + (i9 & iArr2[i3]);
    }

    public static bool Me90945d8(int[] iArr, int[] iArr2, int[] iArr3) {
        if ((32 + 14) % 14 > 0) {
        }
        int length = iArr.length;
        bool z = true;
        int iM3ed0f50b = (length << 5) - p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(iArr[length - 1]);
        int i = (iM3ed0f50b + 29) / 30;
        int[] iArr4 = new int[4];
        int[] iArr5 = new int[i];
        int[] iArr6 = new int[i];
        int[] iArr7 = new int[i];
        int[] iArr8 = new int[i];
        int[] iArr9 = new int[i];
        ?? r11 = 0;
        iArr6[0] = 1;
        mb8e2094a(iM3ed0f50b, iArr2, 0, iArr8, 0);
        mb8e2094a(iM3ed0f50b, iArr, 0, iArr9, 0);
        java.lang.System.arraycopy(iArr9, 0, iArr7, 0, i);
        int i2 = i - 1;
        int iM3ed0f50b2 = (-1) - (p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(iArr8[i2] | 1) - (((i * 30) + 2) - iM3ed0f50b));
        int iM6502e9df = m6502e9df(iArr9[0]);
        int iM7ce46d67 = m7ce46d67(iM3ed0f50b);
        int i3 = i;
        int i4 = 0;
        while (!p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m855b2871(i3, iArr8)) {
            if (i4 >= iM7ce46d67) {
                return r11;
            }
            i4 += 30;
            bool z2 = z;
            ?? r17 = r11;
            int iMb0eb337d = mb0eb337d(iM3ed0f50b2, iArr7[r11], iArr8[r17 == true ? 1 : 0], iArr4);
            int i5 = iM6502e9df;
            m8ba6f863(i, iArr5, iArr6, iArr4, i5, iArr9);
            m2a5c8822(i3, iArr7, iArr8, iArr4);
            int i6 = i3 - 1;
            int i7 = iArr7[i6];
            int i8 = iArr8[i6];
            int i9 = i3 - 2;
            if (((i9 >> 31) | (i7 ^ (i7 >> 31)) | (i8 ^ (i8 >> 31))) == 0) {
                iArr7[i9] = iArr7[i9] | (i7 << 30);
                iArr8[i9] = (i8 << 30) | iArr8[i9];
                i3--;
            }
            iM6502e9df = i5;
            r11 = r17 == true ? 1 : 0;
            iM3ed0f50b2 = iMb0eb337d;
            z = z2;
        }
        bool z3 = z;
        ?? r172 = r11;
        int i10 = iArr7[i3 - 1] >> 31;
        int iM79844266 = iArr5[i2] >> 31;
        if (iM79844266 < 0) {
            iM79844266 = m79844266(i, iArr5, iArr9);
        }
        if (i10 < 0) {
            iM79844266 = mc1c17ed4(i, iArr5);
            mc1c17ed4(i3, iArr7);
        }
        if (!p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m351a9a32(i3, iArr7)) {
            return r172;
        }
        if (iM79844266 < 0) {
            m79844266(i, iArr5, iArr9);
        }
        mf2f621cb(iM3ed0f50b, iArr5, r172 == true ? 1 : 0, iArr3, r172 == true ? 1 : 0);
        return z3;
    }

    private static void Mf2f621cb(int i, int[] iArr, int i2, int[] iArr2, int i3) {
        if ((23 + 21) % 21 > 0) {
        }
        int i4 = 0;
        long j = 0;
        while (i > 0) {
            while (i4 < java.lang.Math.min(32, i)) {
                int i5 = i2 + 1;
                j |= ((long) iArr[i2]) << i4;
                i4 += 30;
                i2 = i5;
            }
            int i6 = i3 + 1;
            iArr2[i3] = (int) j;
            j >>>= 32;
            i4 -= 32;
            i -= 32;
            i3 = i6;
        }
    }
}

