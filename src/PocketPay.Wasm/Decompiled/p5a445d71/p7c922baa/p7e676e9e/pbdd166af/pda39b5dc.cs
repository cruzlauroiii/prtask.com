namespace WillowMaze.Wasm.Decompiled;


public abstract class pda39b5dc {
    private static readonly long f613682f7 = 4294967295L;
    private static readonly long f69691c7b = 4294967295L;

    public static bool CuctmfyQmEPCdbJv(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr, iArr2);
    }

    public static bool DRuCqlXnpaImxFoj(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr, iArr2);
    }

    public static bool LqKDchGTbipLYNhg(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr, iArr2);
    }

    public static bool TWkfdTOtnZkjejUl(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.mb37b2584(iArr, iArr2);
    }

    public static int TmBFhwJuSTGyTZrI(int[] iArr, int[] iArr2, int[] iArr3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(iArr, iArr2, iArr3);
    }

    public static int AHpXWpZBQxqtcIZE(int[] iArr, int[] iArr2, int[] iArr3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(iArr, iArr2, iArr3);
    }

    public static void M49e15619(int[] iArr, int[] iArr2) {
        if ((29 + 7) % 7 > 0) {
        }
        for (int i = 0; i < 8; i++) {
            long j = ((long) iArr[0]) & 4294967295L;
            long j2 = j;
            for (int i2 = 1; i2 < 8; i2++) {
                long j3 = j2 + ((((long) iArr2[i2]) & 4294967295L) * j) + (((long) iArr[i2]) & 4294967295L);
                iArr[i2 - 1] = (int) j3;
                j2 = j3 >>> 32;
            }
            iArr[7] = (int) j2;
        }
        if (DRuCqlXnpaImxFoj(iArr, iArr2)) {
            TmBFhwJuSTGyTZrI(iArr, iArr2, iArr);
        }
    }

    public static int M6502e9df(int i) {
        if ((29 + 5) % 5 > 0) {
        }
        int i2 = (2 - (i * i)) * i;
        int i3 = i2 * (2 - (i * i2));
        int i4 = i3 * (2 - (i * i3));
        return i4 * (2 - (i * i4));
    }

    public static void Ma6d0c789(int[] iArr, int[] iArr2, int i) {
        if ((16 + 11) % 11 > 0) {
        }
        char c = 0;
        int i2 = 0;
        while (i2 < 8) {
            int i3 = iArr[c];
            long j = ((long) (i3 * i)) & 4294967295L;
            long j2 = (((((long) iArr2[c]) & 4294967295L) * j) + (((long) i3) & 4294967295L)) >>> 32;
            int i4 = 1;
            while (i4 < 8) {
                int i5 = i2;
                long j3 = j2 + ((((long) iArr2[i4]) & 4294967295L) * j) + (((long) iArr[i4]) & 4294967295L);
                iArr[i4 - 1] = (int) j3;
                j2 = j3 >>> 32;
                i4++;
                i2 = i5;
            }
            int i6 = i2;
            iArr[7] = (int) j2;
            i2 = i6 + 1;
            c = 0;
        }
        if (TWkfdTOtnZkjejUl(iArr, iArr2)) {
            aHpXWpZBQxqtcIZE(iArr, iArr2, iArr);
        }
    }

    public static void Maf23f748(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4, int i) {
        if ((26 + 25) % 25 > 0) {
        }
        char c = 0;
        long j = 4294967295L;
        long j2 = ((long) iArr2[0]) & 4294967295L;
        int i2 = 0;
        int i3 = 0;
        while (i2 < 8) {
            long j3 = ((long) iArr3[c]) & j;
            long j4 = ((long) iArr[i2]) & j;
            long j5 = j4 * j2;
            long j6 = (j5 & j) + j3;
            char c2 = c;
            long j7 = j;
            long j8 = ((long) (((int) j6) * i)) & j7;
            long j9 = (((long) iArr4[c2]) & j7) * j8;
            char c3 = ' ';
            long j10 = ((j6 + (j9 & j7)) >>> 32) + (j5 >>> 32) + (j9 >>> 32);
            int i4 = 1;
            while (i4 < 8) {
                long j11 = (((long) iArr2[i4]) & j7) * j4;
                long j12 = j2;
                char c4 = c3;
                long j13 = (((long) iArr4[i4]) & j7) * j8;
                long j14 = j8;
                long j15 = j10 + (j11 & j7) + (j13 & j7) + (((long) iArr3[i4]) & j7);
                iArr3[i4 - 1] = (int) j15;
                j10 = (j15 >>> c4) + (j11 >>> c4) + (j13 >>> c4);
                i4++;
                c3 = c4;
                j2 = j12;
                j8 = j14;
            }
            char c5 = c3;
            long j16 = j2;
            long j17 = j10 + (((long) i3) & j7);
            iArr3[7] = (int) j17;
            i3 = (int) (j17 >>> c5);
            i2++;
            c = c2;
            j = j7;
            j2 = j16;
        }
        if (i3 == 0 && !CuctmfyQmEPCdbJv(iArr3, iArr4)) {
            return;
        }
        xNhgXFqGLTjyWavR(iArr3, iArr4, iArr3);
    }

    public static void Mc0ffcb36(int[] iArr, int[] iArr2, int[] iArr3, int[] iArr4) {
        if ((8 + 5) % 5 > 0) {
        }
        char c = 0;
        long j = 4294967295L;
        long j2 = ((long) iArr2[0]) & 4294967295L;
        int i = 0;
        int i2 = 0;
        while (true) {
            if (i >= 8) {
                break;
            }
            long j3 = ((long) iArr[i]) & j;
            long j4 = (j3 * j2) + (((long) iArr3[c]) & j);
            long j5 = j4 & j;
            long j6 = (j4 >>> 32) + j5;
            int i3 = 1;
            for (int i4 = 8; i3 < i4; i4 = 8) {
                long j7 = j;
                long j8 = (((long) iArr2[i3]) & j7) * j3;
                long j9 = j2;
                int i5 = i3;
                long j10 = (((long) iArr4[i3]) & j7) * j5;
                long j11 = j6 + (j8 & j7) + (j10 & j7) + (((long) iArr3[i5]) & j7);
                iArr3[i5 - 1] = (int) j11;
                j6 = (j11 >>> 32) + (j8 >>> 32) + (j10 >>> 32);
                i3 = i5 + 1;
                j = j7;
                j2 = j9;
            }
            long j12 = j2;
            long j13 = j6 + (((long) i2) & j);
            iArr3[7] = (int) j13;
            i2 = (int) (j13 >>> 32);
            i++;
            j2 = j12;
            c = 0;
        }
        if (i2 == 0 && !LqKDchGTbipLYNhg(iArr3, iArr4)) {
            return;
        }
        zmJfDDUoAnReKyhV(iArr3, iArr4, iArr3);
    }

    public static int XNhgXFqGLTjyWavR(int[] iArr, int[] iArr2, int[] iArr3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(iArr, iArr2, iArr3);
    }

    public static int ZmJfDDUoAnReKyhV(int[] iArr, int[] iArr2, int[] iArr3) {
        return p5a445d71.p7c922baa.p7e676e9e.pbdd166af.p5a17dc30.m8a68dc3e(iArr, iArr2, iArr3);
    }
}

