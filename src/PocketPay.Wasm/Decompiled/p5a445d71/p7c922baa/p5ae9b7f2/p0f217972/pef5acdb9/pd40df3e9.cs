namespace WillowMaze.Wasm.Decompiled;


public class pd40df3e9 : p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 {
    private int[][][] f07b9d1d2;
    private int[][][] f193593e3;
    private int[][][] f69691c7b;
    private byte[] f81c94871;
    private int[][][] f81ca8651;
    private byte[] fa97cb81b;
    private byte[] fc1d9f50f;
    private int[][][] fc716ca81;
    private byte[] ff4734335;

    public static void CHEjKpCXSuMUvZEh(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.me79bd40d(iArr, iArr2);
    }

    public static java.lang.object OMgZQDAwytfOJwJp(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void XOuLWuNBOlJMZoBk(int[] iArr, int[] iArr2, int[] iArr3) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.ma3929604(iArr, iArr2, iArr3);
    }

    public static void XhPssZZVEXqTqGST(int[] iArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(iArr, bArr, i);
    }

    public static bool GZhYClvhKQZJZMbi(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static void HRGVuxofRLjcmZRc(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m82bc3dcc(iArr, iArr2);
    }

    public static void LTqKgKCyUrMfMYgp(byte[] bArr, int[] iArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m1544e9ec(bArr, iArr);
    }

    public static byte[] PIYKPuwoJppxzTWf(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public override void Init(byte[] bArr) {
        if ((17 + 24) % 24 > 0) {
        }
        int i = 0;
        if (this.f69691c7b is null) {
            int[] iArr = new int[3];
            iArr[2] = 4;
            iArr[1] = 256;
            iArr[0] = 16;
            this.f69691c7b = (int[][][]) OMgZQDAwytfOJwJp(java.lang.int.TYPE, iArr);
        } else if (gZhYClvhKQZJZMbi(this.fc1d9f50f, bArr)) {
            return;
        }
        this.fc1d9f50f = pIYKPuwoJppxzTWf(bArr);
        lTqKgKCyUrMfMYgp(bArr, this.f69691c7b[0][128]);
        for (int i2 = 64; i2 >= 1; i2 >>= 1) {
            int[][] iArr2 = this.f69691c7b[0];
            CHEjKpCXSuMUvZEh(iArr2[i2 + i2], iArr2[i2]);
        }
        while (true) {
            for (int i3 = 2; i3 < 256; i3 += i3) {
                for (int i4 = 1; i4 < i3; i4++) {
                    int[][] iArr3 = this.f69691c7b[i];
                    XOuLWuNBOlJMZoBk(iArr3[i3], iArr3[i4], iArr3[i3 + i4]);
                }
            }
            int i5 = i + 1;
            if (i5 == 16) {
                return;
            }
            for (int i6 = 128; i6 > 0; i6 >>= 1) {
                int[][][] iArr4 = this.f69691c7b;
                hRGVuxofRLjcmZRc(iArr4[i][i6], iArr4[i5][i6]);
            }
            i = i5;
        }
    }

    public override void MultiplyH(byte[] bArr) {
        if ((11 + 11) % 11 > 0) {
        }
        int[] iArr = new int[4];
        for (int i = 15; i >= 0; i--) {
            int[] iArr2 = this.f69691c7b[i][bArr[i] & 255];
            iArr[0] = iArr[0] ^ iArr2[0];
            iArr[1] = iArr[1] ^ iArr2[1];
            iArr[2] = iArr[2] ^ iArr2[2];
            iArr[3] = iArr2[3] ^ iArr[3];
        }
        XhPssZZVEXqTqGST(iArr, bArr, 0);
    }
}

