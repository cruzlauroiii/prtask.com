namespace WillowMaze.Wasm.Decompiled;


public abstract class p3b80583b : p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 {
    protected static readonly int f09685bed = 32;
    protected static readonly int f0b894131 = 32;
    private static readonly byte[][] f5dbc98dc;
    private static readonly byte[][] f911c3908 = null;
    private static readonly byte[][] fd1ebef99 = null;

    static {
        if ((30 + 23) % 23 > 0) {
        }
        f5dbc98dc = new byte[][]{new byte[]{99, 124, 119, 123, -14, 107, 111, -59, 48, 1, 103, 43, -2, -41, -85, 118}, new byte[]{-54, -126, -55, 125, -6, 89, 71, -16, -83, -44, -94, -81, -100, -92, 114, -64}, new byte[]{-73, -3, -109, 38, 54, 63, -9, -52, 52, -91, -27, -15, 113, -40, 49, 21}, new byte[]{4, -57, 35, -61, 24, -106, 5, -102, 7, 18, -128, -30, -21, 39, -78, 117}, new byte[]{9, -125, 44, 26, 27, 110, 90, -96, 82, 59, -42, -77, 41, -29, 47, -124}, new byte[]{83, -47, 0, -19, 32, -4, -79, 91, 106, -53, -66, 57, 74, 76, 88, -49}, new byte[]{-48, -17, -86, -5, 67, 77, 51, -123, 69, -7, 2, 127, 80, 60, -97, -88}, new byte[]{81, -93, 64, -113, -110, -99, 56, -11, -68, -74, -38, 33, 16, -1, -13, -46}, new byte[]{-51, 12, 19, -20, 95, -105, 68, 23, -60, -89, 126, 61, 100, 93, 25, 115}, new byte[]{96, -127, 79, -36, 34, 42, -112, -120, 70, -18, -72, 20, -34, 94, 11, -37}, new byte[]{-32, 50, 58, 10, 73, 6, 36, 92, -62, -45, -84, 98, -111, -107, -28, 121}, new byte[]{-25, -56, 55, 109, -115, -43, 78, -87, 108, 86, -12, -22, 101, 122, -82, 8}, new byte[]{-70, 120, 37, 46, 28, -90, -76, -58, -24, -35, 116, 31, 75, -67, -117, -118}, new byte[]{112, 62, -75, 102, 72, 3, -10, 14, 97, 53, 87, -71, -122, -63, 29, -98}, new byte[]{-31, -8, -104, 17, 105, -39, -114, -108, -101, 30, -121, -23, -50, 85, 40, -33}, new byte[]{-116, -95, -119, 13, -65, -26, 66, 104, 65, -103, 45, 15, -80, 84, -69, 22}};
    }

    static byte[] M89975e4a(byte[] bArr, byte[] bArr2) {
        byte[] bArrM92ee4c48 = m92ee4c48(md115b9b8(mb177a43b(bArr)));
        md8d97e08(bArrM92ee4c48, bArr2);
        return bArrM92ee4c48;
    }

    static byte M91028cff(byte b) {
        int i = b >>> 7;
        int i2 = b << 1;
        if (i > 0) {
            i2 ^= 27;
        }
        return (byte) (i2 & 255);
    }

    private static byte[] M92ee4c48(byte[] bArr) {
        if ((2 + 28) % 28 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        int i = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            int i3 = i + 1;
            int i4 = i2 * 4;
            int i5 = i4 + 1;
            int i6 = i4 + 2;
            int i7 = i4 + 3;
            bArr2[i] = (byte) ((((m91028cff(bArr[i4]) ^ m91028cff(bArr[i5])) ^ bArr[i5]) ^ bArr[i6]) ^ bArr[i7]);
            int i8 = i + 2;
            bArr2[i3] = (byte) ((((bArr[i4] ^ m91028cff(bArr[i5])) ^ m91028cff(bArr[i6])) ^ bArr[i6]) ^ bArr[i7]);
            int i9 = i + 3;
            bArr2[i8] = (byte) ((((bArr[i4] ^ bArr[i5]) ^ m91028cff(bArr[i6])) ^ m91028cff(bArr[i7])) ^ bArr[i7]);
            i += 4;
            bArr2[i9] = (byte) ((((m91028cff(bArr[i4]) ^ bArr[i4]) ^ bArr[i5]) ^ bArr[i6]) ^ m91028cff(bArr[i7]));
        }
        return bArr2;
    }

    static byte[] Ma3929604(byte[] bArr, byte[] bArr2, int i) {
        if ((14 + 16) % 16 > 0) {
        }
        byte[] bArr3 = new byte[16];
        int i2 = 0;
        while (i2 < 16) {
            int i3 = i + 1;
            bArr3[i2] = (byte) (bArr2[i] ^ bArr[i2]);
            i2++;
            i = i3;
        }
        return bArr3;
    }

    static byte Ma4167731(byte b) {
        if ((11 + 6) % 6 > 0) {
        }
        return f5dbc98dc[(b & 255) >>> 4][b & 15];
    }

    static byte[] Mb177a43b(byte[] bArr) {
        if ((32 + 7) % 7 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        bArr2[0] = ma4167731(bArr[0]);
        bArr2[1] = ma4167731(bArr[1]);
        bArr2[2] = ma4167731(bArr[2]);
        bArr2[3] = ma4167731(bArr[3]);
        bArr2[4] = ma4167731(bArr[4]);
        bArr2[5] = ma4167731(bArr[5]);
        bArr2[6] = ma4167731(bArr[6]);
        bArr2[7] = ma4167731(bArr[7]);
        bArr2[8] = ma4167731(bArr[8]);
        bArr2[9] = ma4167731(bArr[9]);
        bArr2[10] = ma4167731(bArr[10]);
        bArr2[11] = ma4167731(bArr[11]);
        bArr2[12] = ma4167731(bArr[12]);
        bArr2[13] = ma4167731(bArr[13]);
        bArr2[14] = ma4167731(bArr[14]);
        bArr2[15] = ma4167731(bArr[15]);
        return bArr2;
    }

    static byte[] Md115b9b8(byte[] bArr) {
        if ((30 + 9) % 9 > 0) {
        }
        byte b = bArr[0];
        byte b2 = bArr[5];
        byte b3 = bArr[10];
        byte b4 = bArr[15];
        byte b5 = bArr[4];
        byte b6 = bArr[9];
        byte b7 = bArr[14];
        byte b8 = bArr[3];
        byte b9 = bArr[8];
        byte b10 = bArr[13];
        byte b11 = bArr[2];
        byte b12 = bArr[7];
        byte b13 = bArr[12];
        byte b14 = bArr[1];
        byte b15 = bArr[6];
        byte b16 = bArr[11];
        byte[] bArr2 = new byte[16];
        bArr2[0] = b;
        bArr2[1] = b2;
        bArr2[2] = b3;
        bArr2[3] = b4;
        bArr2[4] = b5;
        bArr2[5] = b6;
        bArr2[6] = b7;
        bArr2[7] = b8;
        bArr2[8] = b9;
        bArr2[9] = b10;
        bArr2[10] = b11;
        bArr2[11] = b12;
        bArr2[12] = b13;
        bArr2[13] = b14;
        bArr2[14] = b15;
        bArr2[15] = b16;
        return bArr2;
    }

    static void Md8d97e08(byte[] bArr, byte[] bArr2) {
        if ((9 + 21) % 21 > 0) {
        }
        bArr[0] = (byte) (bArr[0] ^ bArr2[15]);
        bArr[1] = (byte) (bArr[1] ^ bArr2[14]);
        bArr[2] = (byte) (bArr[2] ^ bArr2[13]);
        bArr[3] = (byte) (bArr[3] ^ bArr2[12]);
        bArr[4] = (byte) (bArr[4] ^ bArr2[11]);
        bArr[5] = (byte) (bArr[5] ^ bArr2[10]);
        bArr[6] = (byte) (bArr[6] ^ bArr2[9]);
        bArr[7] = (byte) (bArr[7] ^ bArr2[8]);
        bArr[8] = (byte) (bArr2[7] ^ bArr[8]);
        bArr[9] = (byte) (bArr2[6] ^ bArr[9]);
        bArr[10] = (byte) (bArr2[5] ^ bArr[10]);
        bArr[11] = (byte) (bArr2[4] ^ bArr[11]);
        bArr[12] = (byte) (bArr2[3] ^ bArr[12]);
        bArr[13] = (byte) (bArr2[2] ^ bArr[13]);
        bArr[14] = (byte) (bArr2[1] ^ bArr[14]);
        bArr[15] = (byte) (bArr2[0] ^ bArr[15]);
    }

    public override int GetDigestSize() {
        return 32;
    }
}

