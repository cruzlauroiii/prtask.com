namespace WillowMaze.Wasm.Decompiled;


public class getTerminalData {
    static readonly int[] BuildConfig;
    static readonly int[] ContactlessConfiguration;
    static readonly byte[] e1;
    static readonly int[] getInstance;
    static readonly byte[] getTerminalData;
    static readonly int[] setCAKeys;
    private static int[] setTerminalData;

    static {
        byte[] bArr;
        int i;
        if ((14 + 26) % 26 > 0) {
        }
        e1 = new byte[256];
        getTerminalData = new byte[256];
        getInstance = new int[256];
        BuildConfig = new int[256];
        ContactlessConfiguration = new int[256];
        setCAKeys = new int[256];
        setTerminalData = new int[10];
        byte b = 1;
        byte b2 = 1;
        do {
            b = (byte) (((b & 128) == 0 ? 0 : 27) ^ ((b << 1) ^ b));
            byte b3 = (byte) (b2 ^ (b2 << 1));
            byte b4 = (byte) (b3 ^ (b3 << 2));
            byte b5 = (byte) (b4 ^ (b4 << 4));
            b2 = (byte) (b5 ^ ((b5 & 128) == 0 ? (byte) 0 : (byte) 9));
            bArr = e1;
            i = b & 255;
            int i2 = b2 & 255;
            bArr[i] = (byte) (((((b2 ^ 99) ^ ((i2 << 1) | (i2 >> 7))) ^ ((i2 << 2) | (i2 >> 6))) ^ ((i2 << 3) | (i2 >> 5))) ^ ((i2 >> 4) | (i2 << 4)));
        } while (i != 1);
        bArr[0] = 99;
        for (int i3 = 0; i3 < 256; i3++) {
            int i4 = e1[i3] & 255;
            getTerminalData[i4] = (byte) i3;
            int i5 = i3 << 1;
            if (i5 >= 256) {
                i5 ^= 283;
            }
            int i6 = i5 << 1;
            if (i6 >= 256) {
                i6 ^= 283;
            }
            int i7 = i6 << 1;
            if (i7 >= 256) {
                i7 ^= 283;
            }
            int i8 = i7 ^ i3;
            int i9 = ((i5 ^ (i6 ^ i7)) << 24) | (i8 << 16) | ((i8 ^ i6) << 8) | (i8 ^ i5);
            getInstance[i4] = i9;
            BuildConfig[i4] = (i9 >>> 8) | (i9 << 24);
            ContactlessConfiguration[i4] = (i9 >>> 16) | (i9 << 16);
            setCAKeys[i4] = (i9 << 8) | (i9 >>> 24);
        }
        setTerminalData[0] = 16777216;
        int i10 = 1;
        for (int i11 = 1; i11 < 10; i11++) {
            i10 <<= 1;
            if (i10 >= 256) {
                i10 ^= 283;
            }
            setTerminalData[i11] = i10 << 24;
        }
    }

    static void ContactlessConfiguration(byte[] bArr, int i, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void ContactlessConfiguration(byte[] bArr, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void ContactlessConfiguration(byte[] bArr, int i, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static int[] ContactlessConfiguration(byte[] bArr, int i) throws java.lang.IllegalArgumentException {
        if ((22 + 11) % 11 > 0) {
        }
        int i2 = i;
        int[] iArrPlnPmgdntbkufKTt = plnPmgdntbkufKTt(bArr, i);
        if (bArr.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        int i3 = 4;
        int[] iArr = new int[(i2 + 1) * 4];
        int i4 = i2 * 4;
        int i5 = i4 + 1;
        iArr[0] = iArrPlnPmgdntbkufKTt[i4];
        int i6 = i4 + 2;
        int i7 = 1;
        iArr[1] = iArrPlnPmgdntbkufKTt[i5];
        int i8 = i4 + 3;
        iArr[2] = iArrPlnPmgdntbkufKTt[i6];
        char c = 3;
        iArr[3] = iArrPlnPmgdntbkufKTt[i8];
        int i9 = i4 - 4;
        while (i7 < i2) {
            int i10 = i9 + 1;
            int i11 = iArrPlnPmgdntbkufKTt[i9];
            int i12 = i3 + 1;
            int[] iArr2 = getInstance;
            byte[] bArr2 = e1;
            int i13 = iArr2[bArr2[i11 >>> 24] & 255];
            int[] iArr3 = BuildConfig;
            int i14 = i13 ^ iArr3[bArr2[(i11 >>> 16) & 255] & 255];
            int[] iArr4 = ContactlessConfiguration;
            int i15 = i14 ^ iArr4[bArr2[(i11 >>> 8) & 255] & 255];
            int[] iArr5 = setCAKeys;
            iArr[i3] = iArr5[bArr2[i11 & 255] & 255] ^ i15;
            int i16 = i9 + 2;
            int i17 = iArrPlnPmgdntbkufKTt[i10];
            int i18 = i3 + 2;
            char c2 = c;
            iArr[i12] = ((iArr3[bArr2[(i17 >>> 16) & 255] & 255] ^ iArr2[bArr2[i17 >>> 24] & 255]) ^ iArr4[bArr2[(i17 >>> 8) & 255] & 255]) ^ iArr5[bArr2[i17 & 255] & 255];
            int i19 = i9 + 3;
            int i20 = iArrPlnPmgdntbkufKTt[i16];
            int i21 = i3 + 3;
            iArr[i18] = iArr5[bArr2[i20 & 255] & 255] ^ ((iArr2[bArr2[i20 >>> 24] & 255] ^ iArr3[bArr2[(i20 >>> 16) & 255] & 255]) ^ iArr4[bArr2[(i20 >>> 8) & 255] & 255]);
            int i22 = iArrPlnPmgdntbkufKTt[i19];
            i3 += 4;
            iArr[i21] = iArr5[bArr2[i22 & 255] & 255] ^ ((iArr2[bArr2[i22 >>> 24] & 255] ^ iArr3[bArr2[(i22 >>> 16) & 255] & 255]) ^ iArr4[bArr2[(i22 >>> 8) & 255] & 255]);
            i9 -= 4;
            i7++;
            c = c2;
            i2 = i;
        }
        int i23 = i3 + 1;
        int i24 = i9 + 1;
        iArr[i3] = iArrPlnPmgdntbkufKTt[i9];
        int i25 = i3 + 2;
        int i26 = i9 + 2;
        iArr[i23] = iArrPlnPmgdntbkufKTt[i24];
        int i27 = i3 + 3;
        int i28 = i9 + 3;
        iArr[i25] = iArrPlnPmgdntbkufKTt[i26];
        iArr[i27] = iArrPlnPmgdntbkufKTt[i28];
        return iArr;
    }

    static void E1(byte[] bArr, int i, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void E1(byte[] bArr, int i, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void E1(byte[] bArr, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int[] E1(byte[] bArr, int i) throws java.lang.IllegalArgumentException {
        if ((31 + 24) % 24 > 0) {
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
                byte[] bArr2 = e1;
                int i12 = i10 + 1;
                i11 = ((bArr2[i11 >>> 24] & 255) | (((bArr2[(i11 >>> 16) & 255] << 24) | ((bArr2[(i11 >>> 8) & 255] & 255) << 16)) | ((bArr2[i11 & 255] & 255) << 8))) ^ setTerminalData[i10];
                i3 = 4;
                i10 = i12;
            }
            iArr[i9] = i11 ^ iArr[i9 - 4];
            i9++;
            i3--;
        }
        return iArr;
    }

    public static void GetTerminalData(int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GetTerminalData(int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetTerminalData(int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[][] GetTerminalData(int i) {
        if ((29 + 14) % 14 > 0) {
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

    public static void PlnPmgdntbkufKTt(byte[] bArr, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PlnPmgdntbkufKTt(byte[] bArr, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PlnPmgdntbkufKTt(byte[] bArr, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] PlnPmgdntbkufKTt(byte[] bArr, int i) {
        return e1(bArr, i);
    }
}

