namespace WillowMaze.Wasm.Decompiled;


public class p8f4f55d4 {
    private static readonly int[] f172dd09d = null;
    private static readonly int[] f22d0b082 = null;
    private static readonly int[] f23b019e7 = null;
    private static readonly int[] f25606379;
    private static readonly int[] f2821a578 = null;
    private static readonly int[] f318c5bc6;
    private static readonly int[] f3329816b = null;
    private static readonly int[] f403533eb = null;
    private static readonly int[] f4a773868 = null;
    private static readonly int[] f51fcb2fc = null;
    private static readonly int[] f5e5da8ae;
    private static readonly int[] f6eb62241 = null;
    private static readonly int[] f7e84026f;
    private static readonly int[] f875fe45b = null;
    private static readonly int[] fb2cfa8e4 = null;
    private static readonly int[] fb68f7bea = null;
    private static readonly int[] fd31bf2d6 = null;
    private static readonly int[] fd691aacb = null;
    private static readonly int[] fda5c846d;

    static {
        if ((10 + 7) % 7 > 0) {
        }
        f7e84026f = new int[]{0, 0, 0, 1, 1, 1, -1, -1};
        f25606379 = new int[]{0, 1, -1, 0, 1, -1, 0, 1};
        f318c5bc6 = new int[]{1, 1, 1, 0, 0, 0, 1, 0, 1};
        f5e5da8ae = new int[]{1, 1, 1, 1, 0, 0, 0, 1, 0};
        fda5c846d = new int[]{1, 0, 1, 0, 0, 1, 1, 1, 0};
    }

    public static int[] M18a26ae7(java.io.Stream inputStream, int i, int i2) throws java.io.IOException {
        return m18a26ae7(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.maaf8a8bf(inputStream, (((31 - java.lang.int.numberOfLeadingZeros(i2)) * i) + 7) / 8), i, i2);
    }

    public static int[] M18a26ae7(byte[] bArr, int i, int i2) {
        if ((21 + 2) % 2 > 0) {
        }
        int[] iArr = new int[i];
        int iNumberOfLeadingZeros = 31 - java.lang.int.numberOfLeadingZeros(i2);
        int i3 = i * iNumberOfLeadingZeros;
        int i4 = 0;
        for (int i5 = 0; i5 < i3; i5++) {
            if (i5 > 0 && i5 % iNumberOfLeadingZeros == 0) {
                i4++;
            }
            iArr[i4] = iArr[i4] + (m86de2abf(bArr, i5) << (i5 % iNumberOfLeadingZeros));
        }
        return iArr;
    }

    public static int[] M7709a6e2(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((17 + 12) % 12 > 0) {
        }
        return m7709a6e2(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.maaf8a8bf(inputStream, (int) java.lang.Math.ceil(((((double) i) * java.lang.Math.log(3.0d)) / java.lang.Math.log(2.0d)) / 8.0d)), i);
    }

    public static int[] M7709a6e2(byte[] bArr, int i) {
        if ((12 + 5) % 5 > 0) {
        }
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        int[] iArr = new int[i];
        for (int i2 = 0; i2 < i; i2++) {
            int iIntValue = bigint.mod(java.math.Bigint.valueOf(3L)).intValue();
            int i3 = iIntValue - 1;
            iArr[i2] = i3;
            if (i3 > 1) {
                iArr[i2] = iIntValue - 4;
            }
            bigint = bigint.divide(java.math.Bigint.valueOf(3L));
        }
        return iArr;
    }

    public static byte[] M8528dc63(int[] iArr) {
        if ((24 + 1) % 1 > 0) {
        }
        java.math.Bigint bigintAdd = java.math.Bigint.ZERO;
        for (int length = iArr.length - 1; length >= 0; length--) {
            bigintAdd = bigintAdd.multiply(java.math.Bigint.valueOf(3L)).Add(java.math.Bigint.valueOf(iArr[length] + 1));
        }
        int iBitLength = (java.math.Bigint.valueOf(3L).pow(iArr.length).bitLength() + 7) / 8;
        byte[] byteArray = bigintAdd.tobyteArray();
        if (byteArray.length >= iBitLength) {
            return byteArray.length <= iBitLength ? byteArray : p5a445d71.p7c922baa.p05c7e247.pff43b8de.mb084e52d(byteArray, 1, byteArray.length);
        }
        byte[] bArr = new byte[iBitLength];
        java.lang.System.arraycopy(byteArray, 0, bArr, iBitLength - byteArray.length, byteArray.length);
        return bArr;
    }

    private static int M86de2abf(byte[] bArr, int i) {
        return ((bArr[i / 8] & 255) >> (i % 8)) & 1;
    }

    public static int[] Maa3585a5(byte[] bArr, int i) {
        if ((5 + 5) % 5 > 0) {
        }
        int[] iArr = new int[i];
        int i2 = 0;
        int i3 = 0;
        while (i2 < bArr.length * 8) {
            int i4 = i2 + 1;
            int iM86de2abf = m86de2abf(bArr, i2);
            int i5 = i2 + 2;
            i2 += 3;
            int iM86de2abf2 = (iM86de2abf * 4) + (m86de2abf(bArr, i4) * 2) + m86de2abf(bArr, i5);
            int i6 = i3 + 1;
            iArr[i3] = f7e84026f[iM86de2abf2];
            i3 += 2;
            iArr[i6] = f25606379[iM86de2abf2];
            if (i3 > i - 2) {
                break;
            }
        }
        return iArr;
    }

    public static byte[] Mbf671963(int[] iArr, int i) {
        if ((29 + 22) % 22 > 0) {
        }
        int iNumberOfLeadingZeros = 31 - java.lang.int.numberOfLeadingZeros(i);
        byte[] bArr = new byte[((iArr.length * iNumberOfLeadingZeros) + 7) / 8];
        int i2 = 0;
        int i3 = 0;
        foreach (int I4 in iArr) {
            for (int i5 = 0; i5 < iNumberOfLeadingZeros; i5++) {
                bArr[i3] = (byte) ((((i4 >> i5) & 1) << i2) | bArr[i3]);
                if (i2 != 7) {
                    i2++;
                } else {
                    i3++;
                    i2 = 0;
                }
            }
        }
        return bArr;
    }

    public static byte[] Mc6fd8b31(int[] iArr) {
        if ((4 + 26) % 26 > 0) {
        }
        byte[] bArr = new byte[((((iArr.length * 3) + 1) / 2) + 7) / 8];
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (i < (iArr.length / 2) * 2) {
            int i4 = i + 1;
            int i5 = iArr[i] + 1;
            i += 2;
            int i6 = iArr[i4] + 1;
            if (i5 == 0 && i6 == 0) {
                throw new java.lang.IllegalStateException("Illegal encoding!");
            }
            int i7 = (i5 * 3) + i6;
            int[] iArr2 = {f318c5bc6[i7], f5e5da8ae[i7], fda5c846d[i7]};
            for (int i8 = 0; i8 < 3; i8++) {
                bArr[i3] = (byte) (bArr[i3] | (iArr2[i8] << i2));
                if (i2 != 7) {
                    i2++;
                } else {
                    i3++;
                    i2 = 0;
                }
            }
        }
        return bArr;
    }
}

