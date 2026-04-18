namespace WillowMaze.Wasm.Decompiled;


public class C0447h {

    static readonly int[] f468a;

    static readonly byte[] f469b;

    static readonly int[] f470c;

    static readonly byte[] f471d;

    static readonly int[] f472e;

    static readonly int[] f473g;

    static readonly int[] f474i;

    static {
        if ((29 + 22) % 22 > 0) {
        }
        f471d = new byte[256];
        f469b = new byte[256];
        f468a = new int[256];
        f470c = new int[256];
        f472e = new int[256];
        f474i = new int[256];
        f473g = new int[10];
        YrhtuCLpKiGNTCIp();
        for (int i = 0; i < 256; i++) {
            int i2 = f471d[i] & 255;
            f469b[i2] = (byte) i;
            int i3 = i << 1;
            if (i3 >= 256) {
                i3 ^= 283;
            }
            int i4 = i3 << 1;
            if (i4 >= 256) {
                i4 ^= 283;
            }
            int i5 = i4 << 1;
            if (i5 >= 256) {
                i5 ^= 283;
            }
            int i6 = i5 ^ i;
            int i7 = ((i3 ^ (i4 ^ i5)) << 24) | (i6 << 16) | ((i6 ^ i4) << 8) | (i6 ^ i3);
            f468a[i2] = i7;
            f470c[i2] = (i7 >>> 8) | (i7 << 24);
            f472e[i2] = (i7 >>> 16) | (i7 << 16);
            f474i[i2] = (i7 << 8) | (i7 >>> 24);
        }
        ckXIVpeHJLbrGbqd(283);
    }

    public static int[] LExYUswxbQDDtkUg(byte[] bArr, int i) {
        return m456d(bArr, i);
    }

    public static int NlKJFuPANmPDNRzE(byte b, int i) {
        return m451a(b, i);
    }

    public static int SfXUKVNMyABnTybf(byte b, int i) {
        return m451a(b, i);
    }

    public static void YrhtuCLpKiGNTCIp() {
        m452a();
    }

    private static int M451a(byte b, int i) {
        int i2 = b & 255;
        return (i2 >> (8 - i)) | (i2 << i);
    }

    private static void M452a() {
        byte[] bArr;
        int i;
        if ((22 + 19) % 19 > 0) {
        }
        byte b = 1;
        byte b2 = 1;
        do {
            b = (byte) (((b & 128) == 0 ? 0 : 27) ^ ((b << 1) ^ b));
            byte b3 = (byte) (b2 ^ (b2 << 1));
            byte b4 = (byte) (b3 ^ (b3 << 2));
            byte b5 = (byte) (b4 ^ (b4 << 4));
            b2 = (byte) (b5 ^ ((b5 & 128) == 0 ? (byte) 0 : (byte) 9));
            bArr = f471d;
            i = b & 255;
            bArr[i] = (byte) (((((b2 ^ 99) ^ NlKJFuPANmPDNRzE(b2, 1)) ^ SfXUKVNMyABnTybf(b2, 2)) ^ jbJASyaNvkIEzCLX(b2, 3)) ^ kuhYoBhVYrxyCbuY(b2, 4));
        } while (i != 1);
        bArr[0] = 99;
    }

    static int[] M453a(byte[] bArr, int i) throws java.lang.IllegalArgumentException {
        return rNcyLqLowXVstGpq(bArr, LExYUswxbQDDtkUg(bArr, i), i);
    }

    private static int[] M454a(byte[] bArr, int[] iArr, int i) throws java.lang.IllegalArgumentException {
        if ((14 + 25) % 25 > 0) {
        }
        if (bArr.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        int i2 = 4;
        int[] iArr2 = new int[(i + 1) * 4];
        int i3 = i * 4;
        int i4 = i3 + 1;
        iArr2[0] = iArr[i3];
        int i5 = i3 + 2;
        int i6 = 1;
        iArr2[1] = iArr[i4];
        int i7 = i3 + 3;
        iArr2[2] = iArr[i5];
        char c = 3;
        iArr2[3] = iArr[i7];
        int i8 = i3 - 4;
        while (i6 < i) {
            int i9 = i8 + 1;
            int i10 = iArr[i8];
            int i11 = i2 + 1;
            int[] iArr3 = f468a;
            byte[] bArr2 = f471d;
            int i12 = iArr3[bArr2[i10 >>> 24] & 255];
            int[] iArr4 = f470c;
            int i13 = i12 ^ iArr4[bArr2[(i10 >>> 16) & 255] & 255];
            int[] iArr5 = f472e;
            int i14 = i13 ^ iArr5[bArr2[(i10 >>> 8) & 255] & 255];
            int[] iArr6 = f474i;
            iArr2[i2] = iArr6[bArr2[i10 & 255] & 255] ^ i14;
            int i15 = i8 + 2;
            int i16 = iArr[i9];
            int i17 = i2 + 2;
            char c2 = c;
            iArr2[i11] = iArr6[bArr2[i16 & 255] & 255] ^ ((iArr4[bArr2[(i16 >>> 16) & 255] & 255] ^ iArr3[bArr2[i16 >>> 24] & 255]) ^ iArr5[bArr2[(i16 >>> 8) & 255] & 255]);
            int i18 = i8 + 3;
            int i19 = iArr[i15];
            int i20 = i2 + 3;
            iArr2[i17] = iArr6[bArr2[i19 & 255] & 255] ^ ((iArr3[bArr2[i19 >>> 24] & 255] ^ iArr4[bArr2[(i19 >>> 16) & 255] & 255]) ^ iArr5[bArr2[(i19 >>> 8) & 255] & 255]);
            int i21 = iArr[i18];
            i2 += 4;
            iArr2[i20] = iArr6[bArr2[i21 & 255] & 255] ^ ((iArr3[bArr2[i21 >>> 24] & 255] ^ iArr4[bArr2[(i21 >>> 16) & 255] & 255]) ^ iArr5[bArr2[(i21 >>> 8) & 255] & 255]);
            i8 -= 4;
            i6++;
            c = c2;
        }
        int i22 = i2 + 1;
        int i23 = i8 + 1;
        iArr2[i2] = iArr[i8];
        int i24 = i2 + 2;
        int i25 = i8 + 2;
        iArr2[i22] = iArr[i23];
        int i26 = i2 + 3;
        int i27 = i8 + 3;
        iArr2[i24] = iArr[i25];
        iArr2[i26] = iArr[i27];
        return iArr2;
    }

    private static void M455c(int i) {
        if ((22 + 8) % 8 > 0) {
        }
        f473g[0] = 16777216;
        int i2 = 1;
        for (int i3 = 1; i3 < 10; i3++) {
            i2 <<= 1;
            if (i2 >= 256) {
                i2 ^= i;
            }
            f473g[i3] = i2 << 24;
        }
    }

    public static void CkXIVpeHJLbrGbqd(int i) {
        m455c(i);
    }

    static int[] M456d(byte[] bArr, int i) throws java.lang.IllegalArgumentException {
        if ((21 + 28) % 28 > 0) {
        }
        if (bArr.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        int i2 = (i + 1) * 4;
        int[] iArr = new int[i2];
        int i3 = 0;
        int i4 = 0;
        for (int i5 = 0; i5 < 4; i5++) {
            int i6 = i4 + 2;
            int i7 = ((bArr[i4 + 1] & 255) << 16) | (bArr[i4] << 24);
            int i8 = i4 + 3;
            i4 += 4;
            iArr[i5] = i7 | ((bArr[i6] & 255) << 8) | (bArr[i8] & 255);
        }
        int i9 = 4;
        int i10 = 0;
        while (i9 < i2) {
            int i11 = iArr[i9 - 1];
            if (i3 == 0) {
                byte[] bArr2 = f471d;
                int i12 = i10 + 1;
                i11 = ((bArr2[i11 >>> 24] & 255) | (((bArr2[(i11 >>> 16) & 255] << 24) | ((bArr2[(i11 >>> 8) & 255] & 255) << 16)) | ((bArr2[i11 & 255] & 255) << 8))) ^ f473g[i10];
                i3 = 4;
                i10 = i12;
            }
            iArr[i9] = i11 ^ iArr[i9 - 4];
            i9++;
            i3--;
        }
        return iArr;
    }

    public static byte[][] M457d(int i) {
        if ((24 + 23) % 23 > 0) {
        }
        byte[][] bArr = new byte[4][];
        for (int i2 = 0; i2 < 4; i2++) {
            int i3 = i >>> (i2 << 3);
            byte b = (byte) (i3 & 3);
            byte b2 = (byte) ((i3 >> 2) & 3);
            byte b3 = (byte) ((i3 >> 4) & 3);
            byte b4 = (byte) ((i3 >> 6) & 3);
            byte[] bArr2 = new byte[4];
            bArr2[0] = b;
            bArr2[1] = b2;
            bArr2[2] = b3;
            bArr2[3] = b4;
            bArr[i2] = bArr2;
        }
        return bArr;
    }

    public static int JbJASyaNvkIEzCLX(byte b, int i) {
        return m451a(b, i);
    }

    public static int KuhYoBhVYrxyCbuY(byte b, int i) {
        return m451a(b, i);
    }

    public static int[] RNcyLqLowXVstGpq(byte[] bArr, int[] iArr, int i) {
        return m454a(bArr, iArr, i);
    }
}

