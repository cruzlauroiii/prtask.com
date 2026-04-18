namespace WillowMaze.Wasm.Decompiled;


public class p48da044a {
    private long[] f1b9ecd1e;
    private long[] f228aa3ee;
    private int f344ba0a5;
    private int f3dcab507;
    private int f404bad0f;
    private int f44705db2;
    private long[] f50b25ced;
    private long[] f59ddbf2a;

    public p48da044a(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        if ((10 + 20) % 20 > 0) {
        }
        int length = p78b04208Var.f228aa3ee.length;
        this.f404bad0f = length;
        this.f228aa3ee = new long[(length + 4) / 5];
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < this.f404bad0f; i3++) {
            long[] jArr = this.f228aa3ee;
            jArr[i] = jArr[i] | (((long) p78b04208Var.f228aa3ee[i3]) << i2);
            i2 += 12;
            if (i2 >= 60) {
                i++;
                i2 = 0;
            }
        }
    }

    private p48da044a(long[] jArr, int i) {
        this.f228aa3ee = jArr;
        this.f404bad0f = i;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p48da044a Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pea3db07a pea3db07aVar) {
        long j;
        int i;
        if ((21 + 28) % 28 > 0) {
        }
        int[] iArr = new int[2];
        iArr[1] = (this.f228aa3ee.length + ((pea3db07aVar.Count + 4) / 5)) - 1;
        iArr[0] = 5;
        long[][] jArr = (long[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.long.TYPE, iArr);
        int[] ones = pea3db07aVar.getOnes();
        for (int i2 = 0; i2 != ones.length; i2++) {
            int i3 = ones[i2];
            int i4 = i3 / 5;
            int i5 = i3 - (i4 * 5);
            int i6 = 0;
            while (true) {
                long[] jArr2 = this.f228aa3ee;
                if (i6 >= jArr2.length) {
                    break;
                }
                long[] jArr3 = jArr[i5];
                jArr3[i4] = (jArr3[i4] + jArr2[i6]) & 576319980446939135L;
                i4++;
                i6++;
            }
        }
        int[] negOnes = pea3db07aVar.getNegOnes();
        for (int i7 = 0; i7 != negOnes.length; i7++) {
            int i8 = negOnes[i7];
            int i9 = i8 / 5;
            int i10 = i8 - (i9 * 5);
            int i11 = 0;
            while (true) {
                long[] jArr4 = this.f228aa3ee;
                if (i11 >= jArr4.length) {
                    break;
                }
                long[] jArr5 = jArr[i10];
                jArr5[i9] = ((jArr5[i9] + 576601524159907840L) - jArr4[i11]) & 576319980446939135L;
                i9++;
                i11++;
            }
        }
        long[] jArr6 = jArr[0];
        long[] jArrM405b6268 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(jArr6, jArr6.length + 1);
        for (int i12 = 1; i12 <= 4; i12++) {
            int i13 = i12 * 12;
            int i14 = 60 - i13;
            long j2 = (1 << i14) - 1;
            int length = jArr[i12].length;
            int i15 = 0;
            while (i15 < length) {
                long j3 = jArr[i12][i15];
                long j4 = j3 >> i14;
                jArrM405b6268[i15] = (jArrM405b6268[i15] + ((j3 & j2) << i13)) & 576319980446939135L;
                i15++;
                jArrM405b6268[i15] = (jArrM405b6268[i15] + j4) & 576319980446939135L;
            }
        }
        int i16 = (this.f404bad0f % 5) * 12;
        for (int length2 = this.f228aa3ee.length - 1; length2 < jArrM405b6268.length; length2++) {
            long[] jArr7 = this.f228aa3ee;
            if (length2 != jArr7.length - 1) {
                j = jArrM405b6268[length2];
                i = (length2 * 5) - this.f404bad0f;
            } else {
                j = this.f404bad0f != 5 ? jArrM405b6268[length2] >> i16 : 0L;
                i = 0;
            }
            int i17 = i / 5;
            int i18 = i - (i17 * 5);
            long j5 = j << (i18 * 12);
            long j6 = j >> ((5 - i18) * 12);
            jArrM405b6268[i17] = (jArrM405b6268[i17] + j5) & 576319980446939135L;
            int i19 = i17 + 1;
            if (i19 < jArr7.length) {
                jArrM405b6268[i19] = (jArrM405b6268[i19] + j6) & 576319980446939135L;
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p48da044a(jArrM405b6268, this.f404bad0f);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 TointPolynomial() {
        if ((3 + 3) % 3 > 0) {
        }
        int[] iArr = new int[this.f404bad0f];
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < this.f404bad0f; i3++) {
            iArr[i3] = (int) ((this.f228aa3ee[i] >> i2) & 2047);
            i2 += 12;
            if (i2 >= 60) {
                i++;
                i2 = 0;
            }
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(iArr);
    }
}

