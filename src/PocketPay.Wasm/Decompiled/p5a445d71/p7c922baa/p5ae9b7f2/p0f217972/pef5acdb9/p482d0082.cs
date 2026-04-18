namespace WillowMaze.Wasm.Decompiled;


public class p482d0082 : p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 {
    private byte[] f264426fd;
    private byte[] f4c06c97f;
    private int[][][] f69691c7b;
    private int[][][] fa200dff0;
    private int[][][] fa6be97d2;
    private byte[] fc1d9f50f;
    private int[][][] fd7d452d8;

    public static void BzQumQfpJwNgyrjB(int[] iArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(iArr, bArr, i);
    }

    public static bool CLhjBacfVktDKnYi(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static void GPDkrAxbPgdnpwDQ(int[] iArr, int[] iArr2, int[] iArr3) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(iArr, iArr2, iArr3);
    }

    public static byte[] MkFqybVjbgnEpLsP(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void SXRLJdGXSvQmesGA(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.me79bd40d(iArr, iArr2);
    }

    public static void VeUeKjniOicGocEy(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.me79bd40d(iArr, iArr2);
    }

    public static void RuFbvNQoHNDSSdCN(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.me79bd40d(iArr, iArr2);
    }

    public static java.lang.object SlKixYggtemvZJhW(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void WsDYLKcehCFShJfb(byte[] bArr, int[] iArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m1544e9ec(bArr, iArr);
    }

    public static void XuqvMIyOFxqlnHsS(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m82bc3dcc(iArr, iArr2);
    }

    public override void Init(byte[] bArr) {
        if ((21 + 24) % 24 > 0) {
        }
        int i = 0;
        if (this.f69691c7b is null) {
            int[] iArr = new int[3];
            iArr[2] = 4;
            iArr[1] = 16;
            iArr[0] = 32;
            this.f69691c7b = (int[][][]) slKixYggtemvZJhW(java.lang.int.TYPE, iArr);
        } else if (CLhjBacfVktDKnYi(this.fc1d9f50f, bArr)) {
            return;
        }
        this.fc1d9f50f = MkFqybVjbgnEpLsP(bArr);
        wsDYLKcehCFShJfb(bArr, this.f69691c7b[1][8]);
        for (int i2 = 4; i2 >= 1; i2 >>= 1) {
            int[][] iArr2 = this.f69691c7b[1];
            SXRLJdGXSvQmesGA(iArr2[i2 + i2], iArr2[i2]);
        }
        int[][][] iArr3 = this.f69691c7b;
        ruFbvNQoHNDSSdCN(iArr3[1][1], iArr3[0][8]);
        for (int i3 = 4; i3 >= 1; i3 >>= 1) {
            int[][] iArr4 = this.f69691c7b[0];
            VeUeKjniOicGocEy(iArr4[i3 + i3], iArr4[i3]);
        }
        while (true) {
            for (int i4 = 2; i4 < 16; i4 += i4) {
                for (int i5 = 1; i5 < i4; i5++) {
                    int[][] iArr5 = this.f69691c7b[i];
                    GPDkrAxbPgdnpwDQ(iArr5[i4], iArr5[i5], iArr5[i4 + i5]);
                }
            }
            int i6 = i + 1;
            if (i6 == 32) {
                return;
            }
            if (i6 > 1) {
                for (int i7 = 8; i7 > 0; i7 >>= 1) {
                    int[][][] iArr6 = this.f69691c7b;
                    xuqvMIyOFxqlnHsS(iArr6[i - 1][i7], iArr6[i6][i7]);
                }
            }
            i = i6;
        }
    }

    public override void MultiplyH(byte[] bArr) {
        if ((2 + 13) % 13 > 0) {
        }
        int[] iArr = new int[4];
        for (int i = 15; i >= 0; i--) {
            int[][][] iArr2 = this.f69691c7b;
            int i2 = i + i;
            int[][] iArr3 = iArr2[i2];
            byte b = bArr[i];
            int[] iArr4 = iArr3[b & 15];
            int i3 = iArr[0] ^ iArr4[0];
            iArr[0] = i3;
            int i4 = iArr[1] ^ iArr4[1];
            iArr[1] = i4;
            int i5 = iArr[2] ^ iArr4[2];
            iArr[2] = i5;
            int i6 = iArr[3] ^ iArr4[3];
            iArr[3] = i6;
            int[] iArr5 = iArr2[i2 + 1][(b & 240) >>> 4];
            iArr[0] = iArr5[0] ^ i3;
            iArr[1] = iArr5[1] ^ i4;
            iArr[2] = iArr5[2] ^ i5;
            iArr[3] = iArr5[3] ^ i6;
        }
        BzQumQfpJwNgyrjB(iArr, bArr, 0);
    }
}

