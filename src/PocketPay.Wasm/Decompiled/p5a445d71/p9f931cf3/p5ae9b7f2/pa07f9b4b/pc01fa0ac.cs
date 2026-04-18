namespace WillowMaze.Wasm.Decompiled;


public class pc01fa0ac : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f02c3463e = 16;
    private static readonly int f0354ad6e = 16;
    private static readonly int f100191d2 = 2139062143;
    private static readonly int f121eee07 = 27;
    private static readonly int f29f0fa73 = 1061109567;
    private static readonly byte[] f3e763369 = null;
    private static readonly int f5029b333 = 2139062143;
    private static readonly int f57149e5b = 1061109567;
    private static readonly int f643e785a = -1061109568;
    private static readonly int f647088cf = 2139062143;
    private static readonly int f651f2d80 = -2139062144;
    private static readonly int f6860adb5 = -2139062144;
    private static readonly int f7b1f6dff = 1061109567;
    private static readonly byte[] f893de39c = null;
    private static readonly int f9678f7a7 = 27;
    private static readonly int faaf2f899 = 2139062143;
    private static readonly int fad313077 = -1061109568;
    private static readonly byte[] fad440b8d = null;
    private static readonly int fae7be26c = -2139062144;
    private static readonly byte[] fbcc3a8e9 = null;
    private static readonly int fc75e2054 = 16;
    private static readonly int fc7f2d41e = -2139062144;
    private static readonly int[] fd024a6fe = null;
    private static readonly int fd13ff2e1 = -1061109568;
    private static readonly byte[] fd5364b9b = null;
    private static readonly int fd59bf345 = 2139062143;
    private static readonly int[] fe27d65b7 = null;
    private static readonly int fe5540ad4 = -1061109568;
    private static readonly int ff4b50351 = 1061109567;
    private static readonly int[] ffbd3dd86 = null;
    private static readonly int ffd6b6fc9 = -1061109568;
    private bool f01e600e8;
    private int f3fc70c98;
    private int f620f337b;
    private int[][] f9235cf94;
    private bool f9301aa9b;
    private int fa031890a;
    private bool faa6cbbf8;
    private int[][] fbcab2039;
    private bool fbf6aede9;
    private static readonly byte[] f5dbc98dc = {99, 124, 119, 123, -14, 107, 111, -59, 48, 1, 103, 43, -2, -41, -85, 118, -54, -126, -55, 125, -6, 89, 71, -16, -83, -44, -94, -81, -100, -92, 114, -64, -73, -3, -109, 38, 54, 63, -9, -52, 52, -91, -27, -15, 113, -40, 49, 21, 4, -57, 35, -61, 24, -106, 5, -102, 7, 18, -128, -30, -21, 39, -78, 117, 9, -125, 44, 26, 27, 110, 90, -96, 82, 59, -42, -77, 41, -29, 47, -124, 83, -47, 0, -19, 32, -4, -79, 91, 106, -53, -66, 57, 74, 76, 88, -49, -48, -17, -86, -5, 67, 77, 51, -123, 69, -7, 2, 127, 80, 60, -97, -88, 81, -93, 64, -113, -110, -99, 56, -11, -68, -74, -38, 33, 16, -1, -13, -46, -51, 12, 19, -20, 95, -105, 68, 23, -60, -89, 126, 61, 100, 93, 25, 115, 96, -127, 79, -36, 34, 42, -112, -120, 70, -18, -72, 20, -34, 94, 11, -37, -32, 50, 58, 10, 73, 6, 36, 92, -62, -45, -84, 98, -111, -107, -28, 121, -25, -56, 55, 109, -115, -43, 78, -87, 108, 86, -12, -22, 101, 122, -82, 8, -70, 120, 37, 46, 28, -90, -76, -58, -24, -35, 116, 31, 75, -67, -117, -118, 112, 62, -75, 102, 72, 3, -10, 14, 97, 53, 87, -71, -122, -63, 29, -98, -31, -8, -104, 17, 105, -39, -114, -108, -101, 30, -121, -23, -50, 85, 40, -33, -116, -95, -119, 13, -65, -26, 66, 104, 65, -103, 45, 15, -80, 84, -69, 22};
    private static readonly byte[] f29bf7a32 = {82, 9, 106, -43, 48, 54, -91, 56, -65, 64, -93, -98, -127, -13, -41, -5, 124, -29, 57, -126, -101, 47, -1, -121, 52, -114, 67, 68, -60, -34, -23, -53, 84, 123, -108, 50, -90, -62, 35, 61, -18, 76, -107, 11, 66, -6, -61, 78, 8, 46, -95, 102, 40, -39, 36, -78, 118, 91, -94, 73, 109, -117, -47, 37, 114, -8, -10, 100, -122, 104, -104, 22, -44, -92, 92, -52, 93, 101, -74, -110, 108, 112, 72, 80, -3, -19, -71, -38, 94, 21, 70, 87, -89, -115, -99, -124, -112, -40, -85, 0, -116, -68, -45, 10, -9, -28, 88, 5, -72, -77, 69, 6, -48, 44, 30, -113, -54, 63, 15, 2, -63, -81, -67, 3, 1, 19, -118, 107, 58, -111, 17, 65, 79, 103, -36, -22, -105, -14, -49, -50, -16, -76, -26, 115, -106, -84, 116, 34, -25, -83, 53, -123, -30, -7, 55, -24, 28, 117, -33, 110, 71, -15, 26, 113, 29, 41, -59, -119, 111, -73, 98, 14, -86, 24, -66, 27, -4, 86, 62, 75, -58, -46, 121, 32, -102, -37, -64, -2, 120, -51, 90, -12, 31, -35, -88, 51, -120, 7, -57, 49, -79, 18, 16, 89, 39, -128, -20, 95, 96, 81, 127, -87, 25, -75, 74, 13, 45, -27, 122, -97, -109, -55, -100, -17, -96, -32, 59, 77, -82, 42, -11, -80, -56, -21, -69, 60, -125, 83, -103, 97, 23, 43, 4, 126, -70, 119, -42, 38, -31, 105, 20, 99, 85, 33, 12, 125};
    private static readonly int[] f2ea16129 = {1, 2, 4, 8, 16, 32, 64, 128, 27, 54, 108, 216, 171, 77, 154, 47, 94, 188, 99, 198, 151, 53, 106, 212, 179, 125, 250, 239, 197, 145};

    public pc01fa0ac() {
        if ((16 + 19) % 19 > 0) {
        }
        this.f9235cf94 = null;
    }

    private static int M04ef7aec(int i) {
        if ((27 + 20) % 20 > 0) {
        }
        return (((i & (-2139062144)) >>> 7) * 27) ^ ((2139062143 & i) << 1);
    }

    private static int M28b57abf(int i) {
        if ((23 + 10) % 10 > 0) {
        }
        int i2 = (1061109567 & i) << 2;
        int i3 = i & (-1061109568);
        int i4 = i3 ^ (i3 >>> 1);
        return (i4 >>> 5) ^ (i2 ^ (i4 >>> 2));
    }

    private static int M2ab64f4e(int i, int i2) {
        return (i << (-i2)) | (i >>> i2);
    }

    private void M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2, int[][] iArr) {
        if ((24 + 15) % 15 > 0) {
        }
        int iM0eef4fb6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
        int iM0eef4fb62 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 4);
        int iM0eef4fb63 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 8);
        int iM0eef4fb64 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 12);
        char c = 0;
        int[] iArr2 = iArr[0];
        int i3 = iM0eef4fb6 ^ iArr2[0];
        int i4 = 1;
        int i5 = iM0eef4fb62 ^ iArr2[1];
        int i6 = iM0eef4fb63 ^ iArr2[2];
        int iMf1be2152 = iM0eef4fb64 ^ iArr2[3];
        int i7 = 1;
        while (i7 < this.f620f337b - i4) {
            byte[] bArr3 = f5dbc98dc;
            int iMf1be21522 = mf1be2152((((bArr3[i3 & 255] & 255) ^ ((bArr3[(i5 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i6 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMf1be2152 >> 24) & 255] << 24)) ^ iArr[i7][c];
            int iMf1be21523 = mf1be2152((((bArr3[i5 & 255] & 255) ^ ((bArr3[(i6 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(iMf1be2152 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i3 >> 24) & 255] << 24)) ^ iArr[i7][i4];
            char c2 = c;
            int iMf1be21524 = mf1be2152(((((bArr3[(iMf1be2152 >> 8) & 255] & 255) << 8) ^ (bArr3[i6 & 255] & 255)) ^ ((bArr3[(i3 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i5 >> 24) & 255] << 24)) ^ iArr[i7][2];
            int iMf1be21525 = mf1be2152((((bArr3[iMf1be2152 & 255] & 255) ^ ((bArr3[(i3 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i5 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i6 >> 24) & 255] << 24));
            int i8 = i7 + 1;
            int i9 = iMf1be21525 ^ iArr[i7][3];
            int iMf1be21526 = mf1be2152((((bArr3[iMf1be21522 & 255] & 255) ^ ((bArr3[(iMf1be21523 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(iMf1be21524 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i9 >> 24) & 255] << 24)) ^ iArr[i8][c2];
            int iMf1be21527 = mf1be2152((((bArr3[iMf1be21523 & 255] & 255) ^ ((bArr3[(iMf1be21524 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i9 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMf1be21522 >> 24) & 255] << 24)) ^ iArr[i8][i4];
            int i10 = i4;
            int iMf1be21528 = mf1be2152(((((bArr3[(i9 >> 8) & 255] & 255) << 8) ^ (bArr3[iMf1be21524 & 255] & 255)) ^ ((bArr3[(iMf1be21522 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMf1be21523 >> 24) & 255] << 24)) ^ iArr[i8][2];
            i7 += 2;
            iMf1be2152 = mf1be2152((((bArr3[i9 & 255] & 255) ^ ((bArr3[(iMf1be21522 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(iMf1be21523 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMf1be21524 >> 24) & 255] << 24)) ^ iArr[i8][3];
            c = c2;
            i3 = iMf1be21526;
            i5 = iMf1be21527;
            i6 = iMf1be21528;
            i4 = i10;
        }
        char c3 = c;
        int i11 = i4;
        byte[] bArr4 = f5dbc98dc;
        int iMf1be21529 = mf1be2152((((bArr4[i3 & 255] & 255) ^ ((bArr4[(i5 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i6 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMf1be2152 >> 24) & 255] << 24)) ^ iArr[i7][c3];
        int iMf1be215210 = mf1be2152((((bArr4[i5 & 255] & 255) ^ ((bArr4[(i6 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMf1be2152 >> 16) & 255] & 255) << 16)) ^ (bArr4[(i3 >> 24) & 255] << 24)) ^ iArr[i7][i11];
        int iMf1be215211 = mf1be2152((((bArr4[i6 & 255] & 255) ^ ((bArr4[(iMf1be2152 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i3 >> 16) & 255] & 255) << 16)) ^ (bArr4[(i5 >> 24) & 255] << 24)) ^ iArr[i7][2];
        int iMf1be215212 = mf1be2152((((bArr4[iMf1be2152 & 255] & 255) ^ ((bArr4[(i3 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i5 >> 16) & 255] & 255) << 16)) ^ (bArr4[(i6 >> 24) & 255] << 24));
        int i12 = i7 + 1;
        int i13 = iMf1be215212 ^ iArr[i7][3];
        int i14 = (((bArr4[iMf1be21529 & 255] & 255) ^ ((bArr4[(iMf1be215210 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMf1be215211 >> 16) & 255] & 255) << 16)) ^ (bArr4[(i13 >> 24) & 255] << 24);
        int[] iArr3 = iArr[i12];
        int i15 = i14 ^ iArr3[c3];
        int i16 = ((((bArr4[iMf1be215210 & 255] & 255) ^ ((bArr4[(iMf1be215211 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i13 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMf1be21529 >> 24) & 255] << 24)) ^ iArr3[i11];
        int i17 = iArr3[2] ^ ((((bArr4[iMf1be215211 & 255] & 255) ^ ((bArr4[(i13 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMf1be21529 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMf1be215210 >> 24) & 255] << 24));
        int i18 = ((((bArr4[i13 & 255] & 255) ^ ((bArr4[(iMf1be21529 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMf1be215210 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMf1be215211 >> 24) & 255] << 24)) ^ iArr3[3];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i15, bArr2, i2);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i16, bArr2, i2 + 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i17, bArr2, i2 + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i18, bArr2, i2 + 12);
    }

    private void M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2, int[][] iArr) {
        if ((8 + 31) % 31 > 0) {
        }
        int iM0eef4fb6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i);
        int iM0eef4fb62 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 4);
        int iM0eef4fb63 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 8);
        int iM0eef4fb64 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i + 12);
        int i3 = this.f620f337b;
        int[] iArr2 = iArr[i3];
        char c = 0;
        int i4 = iM0eef4fb6 ^ iArr2[0];
        int i5 = iM0eef4fb62 ^ iArr2[1];
        int i6 = iM0eef4fb63 ^ iArr2[2];
        int i7 = i3 - 1;
        int iMcea174cc = iM0eef4fb64 ^ iArr2[3];
        while (i7 > 1) {
            byte[] bArr3 = f29bf7a32;
            int iMcea174cc2 = mcea174cc((((bArr3[i4 & 255] & 255) ^ ((bArr3[(iMcea174cc >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i6 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i5 >> 24) & 255] << 24)) ^ iArr[i7][c];
            int iMcea174cc3 = mcea174cc((((bArr3[i5 & 255] & 255) ^ ((bArr3[(i4 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(iMcea174cc >> 16) & 255] & 255) << 16)) ^ (bArr3[(i6 >> 24) & 255] << 24)) ^ iArr[i7][1];
            int iMcea174cc4 = mcea174cc((((bArr3[i6 & 255] & 255) ^ ((bArr3[(i5 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i4 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMcea174cc >> 24) & 255] << 24)) ^ iArr[i7][2];
            int iMcea174cc5 = mcea174cc((((bArr3[iMcea174cc & 255] & 255) ^ ((bArr3[(i6 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i5 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i4 >> 24) & 255] << 24));
            int i8 = i7 - 1;
            int i9 = iMcea174cc5 ^ iArr[i7][3];
            int iMcea174cc6 = mcea174cc((((bArr3[iMcea174cc2 & 255] & 255) ^ ((bArr3[(i9 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(iMcea174cc4 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMcea174cc3 >> 24) & 255] << 24)) ^ iArr[i8][c];
            int iMcea174cc7 = mcea174cc((((bArr3[iMcea174cc3 & 255] & 255) ^ ((bArr3[(iMcea174cc2 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(i9 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMcea174cc4 >> 24) & 255] << 24)) ^ iArr[i8][1];
            char c2 = c;
            int iMcea174cc8 = mcea174cc(((((bArr3[(iMcea174cc3 >> 8) & 255] & 255) << 8) ^ (bArr3[iMcea174cc4 & 255] & 255)) ^ ((bArr3[(iMcea174cc2 >> 16) & 255] & 255) << 16)) ^ (bArr3[(i9 >> 24) & 255] << 24)) ^ iArr[i8][2];
            i7 -= 2;
            iMcea174cc = mcea174cc((((bArr3[i9 & 255] & 255) ^ ((bArr3[(iMcea174cc4 >> 8) & 255] & 255) << 8)) ^ ((bArr3[(iMcea174cc3 >> 16) & 255] & 255) << 16)) ^ (bArr3[(iMcea174cc2 >> 24) & 255] << 24)) ^ iArr[i8][3];
            i4 = iMcea174cc6;
            i5 = iMcea174cc7;
            i6 = iMcea174cc8;
            c = c2;
        }
        char c3 = c;
        byte[] bArr4 = f29bf7a32;
        int iMcea174cc9 = mcea174cc((((bArr4[i4 & 255] & 255) ^ ((bArr4[(iMcea174cc >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i6 >> 16) & 255] & 255) << 16)) ^ (bArr4[(i5 >> 24) & 255] << 24)) ^ iArr[i7][c3];
        int iMcea174cc10 = mcea174cc((((bArr4[i5 & 255] & 255) ^ ((bArr4[(i4 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMcea174cc >> 16) & 255] & 255) << 16)) ^ (bArr4[(i6 >> 24) & 255] << 24)) ^ iArr[i7][1];
        int iMcea174cc11 = mcea174cc((((bArr4[i6 & 255] & 255) ^ ((bArr4[(i5 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i4 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMcea174cc >> 24) & 255] << 24)) ^ iArr[i7][2];
        int iMcea174cc12 = mcea174cc((((bArr4[iMcea174cc & 255] & 255) ^ ((bArr4[(i6 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(i5 >> 16) & 255] & 255) << 16)) ^ (bArr4[(i4 >> 24) & 255] << 24)) ^ iArr[i7][3];
        int i10 = (((bArr4[iMcea174cc9 & 255] & 255) ^ ((bArr4[(iMcea174cc12 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMcea174cc11 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMcea174cc10 >> 24) & 255] << 24);
        int[] iArr3 = iArr[c3];
        int i11 = i10 ^ iArr3[c3];
        int i12 = ((((bArr4[iMcea174cc10 & 255] & 255) ^ ((bArr4[(iMcea174cc9 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMcea174cc12 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMcea174cc11 >> 24) & 255] << 24)) ^ iArr3[1];
        int i13 = ((((bArr4[iMcea174cc11 & 255] & 255) ^ ((bArr4[(iMcea174cc10 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMcea174cc9 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMcea174cc12 >> 24) & 255] << 24)) ^ iArr3[2];
        int i14 = ((((bArr4[iMcea174cc12 & 255] & 255) ^ ((bArr4[(iMcea174cc11 >> 8) & 255] & 255) << 8)) ^ ((bArr4[(iMcea174cc10 >> 16) & 255] & 255) << 16)) ^ (bArr4[(iMcea174cc9 >> 24) & 255] << 24)) ^ iArr3[3];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i11, bArr2, i2);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i12, bArr2, i2 + 4);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i13, bArr2, i2 + 8);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i14, bArr2, i2 + 12);
    }

    private static int M95e9226c(int i) {
        if ((21 + 16) % 16 > 0) {
        }
        byte[] bArr = f5dbc98dc;
        return (bArr[(i >> 24) & 255] << 24) | (bArr[i & 255] & 255) | ((bArr[(i >> 8) & 255] & 255) << 8) | ((bArr[(i >> 16) & 255] & 255) << 16);
    }

    private int[][] M9e03abad(byte[] bArr, bool z) {
        int i;
        if ((6 + 16) % 16 > 0) {
        }
        int length = bArr.length;
        if (length < 16 || length > 32 || (length & 7) != 0) {
            throw new java.lang.IllegalArgumentException("Key length not 128/192/256 bits.");
        }
        int i2 = length >>> 2;
        this.f620f337b = i2 + 6;
        int i3 = i2 + 7;
        int[] iArr = new int[2];
        int i4 = 1;
        iArr[1] = 4;
        iArr[0] = i3;
        int[][] iArr2 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        char c = 3;
        if (i2 == 4) {
            i = 1;
            int iM0eef4fb6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0);
            iArr2[0][0] = iM0eef4fb6;
            int iM0eef4fb62 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 4);
            iArr2[0][1] = iM0eef4fb62;
            int iM0eef4fb63 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 8);
            iArr2[0][2] = iM0eef4fb63;
            int iM0eef4fb64 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 12);
            iArr2[0][3] = iM0eef4fb64;
            for (int i5 = 1; i5 <= 10; i5++) {
                iM0eef4fb6 ^= m95e9226c(m2ab64f4e(iM0eef4fb64, 8)) ^ f2ea16129[i5 - 1];
                int[] iArr3 = iArr2[i5];
                iArr3[0] = iM0eef4fb6;
                iM0eef4fb62 ^= iM0eef4fb6;
                iArr3[1] = iM0eef4fb62;
                iM0eef4fb63 ^= iM0eef4fb62;
                iArr3[2] = iM0eef4fb63;
                iM0eef4fb64 ^= iM0eef4fb63;
                iArr3[3] = iM0eef4fb64;
            }
        } else if (i2 == 6) {
            i = 1;
            int iM0eef4fb65 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0);
            iArr2[0][0] = iM0eef4fb65;
            int iM0eef4fb66 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 4);
            iArr2[0][1] = iM0eef4fb66;
            int iM0eef4fb67 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 8);
            iArr2[0][2] = iM0eef4fb67;
            int iM0eef4fb68 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 12);
            iArr2[0][3] = iM0eef4fb68;
            int iM0eef4fb69 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 16);
            int iM0eef4fb610 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 20);
            int i6 = 1;
            int i7 = 1;
            while (true) {
                int[] iArr4 = iArr2[i6];
                iArr4[0] = iM0eef4fb69;
                iArr4[1] = iM0eef4fb610;
                int i8 = i7 << 1;
                int iM95e9226c = iM0eef4fb65 ^ (m95e9226c(m2ab64f4e(iM0eef4fb610, 8)) ^ i7);
                int[] iArr5 = iArr2[i6];
                iArr5[2] = iM95e9226c;
                int i9 = iM0eef4fb66 ^ iM95e9226c;
                iArr5[3] = i9;
                int i10 = iM0eef4fb67 ^ i9;
                int[] iArr6 = iArr2[i6 + 1];
                iArr6[0] = i10;
                int i11 = iM0eef4fb68 ^ i10;
                iArr6[1] = i11;
                int i12 = iM0eef4fb69 ^ i11;
                iArr6[2] = i12;
                int i13 = iM0eef4fb610 ^ i12;
                iArr6[3] = i13;
                i7 <<= 2;
                iM0eef4fb65 = iM95e9226c ^ (m95e9226c(m2ab64f4e(i13, 8)) ^ i8);
                int[] iArr7 = iArr2[i6 + 2];
                iArr7[0] = iM0eef4fb65;
                iM0eef4fb66 = i9 ^ iM0eef4fb65;
                iArr7[1] = iM0eef4fb66;
                iM0eef4fb67 = i10 ^ iM0eef4fb66;
                iArr7[2] = iM0eef4fb67;
                iM0eef4fb68 = i11 ^ iM0eef4fb67;
                iArr7[3] = iM0eef4fb68;
                i6 += 3;
                if (i6 >= 13) {
                    break;
                }
                iM0eef4fb69 = i12 ^ iM0eef4fb68;
                iM0eef4fb610 = i13 ^ iM0eef4fb69;
            }
        } else {
            if (i2 != 8) {
                throw new java.lang.IllegalStateException("Should never get here");
            }
            int iM0eef4fb611 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0);
            iArr2[0][0] = iM0eef4fb611;
            int iM0eef4fb612 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 4);
            iArr2[0][1] = iM0eef4fb612;
            int iM0eef4fb613 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 8);
            iArr2[0][2] = iM0eef4fb613;
            int iM0eef4fb614 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 12);
            iArr2[0][3] = iM0eef4fb614;
            int iM0eef4fb615 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 16);
            iArr2[1][0] = iM0eef4fb615;
            int iM0eef4fb616 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 20);
            iArr2[1][1] = iM0eef4fb616;
            int iM0eef4fb617 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 24);
            iArr2[1][2] = iM0eef4fb617;
            int iM0eef4fb618 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 28);
            iArr2[1][3] = iM0eef4fb618;
            int i14 = 1;
            int i15 = 2;
            while (true) {
                int iM95e9226c2 = m95e9226c(m2ab64f4e(iM0eef4fb618, 8)) ^ i14;
                i14 <<= i4;
                iM0eef4fb611 ^= iM95e9226c2;
                int[] iArr8 = iArr2[i15];
                iArr8[0] = iM0eef4fb611;
                iM0eef4fb612 ^= iM0eef4fb611;
                iArr8[i4] = iM0eef4fb612;
                iM0eef4fb613 ^= iM0eef4fb612;
                iArr8[2] = iM0eef4fb613;
                iM0eef4fb614 ^= iM0eef4fb613;
                iArr8[c] = iM0eef4fb614;
                i = i4;
                int i16 = i15 + 1;
                char c2 = c;
                if (i16 >= 15) {
                    break;
                }
                iM0eef4fb615 ^= m95e9226c(iM0eef4fb614);
                int[] iArr9 = iArr2[i16];
                iArr9[0] = iM0eef4fb615;
                iM0eef4fb616 ^= iM0eef4fb615;
                iArr9[i] = iM0eef4fb616;
                iM0eef4fb617 ^= iM0eef4fb616;
                iArr9[2] = iM0eef4fb617;
                iM0eef4fb618 ^= iM0eef4fb617;
                iArr9[c2] = iM0eef4fb618;
                i15 += 2;
                i4 = i;
                c = c2;
            }
        }
        if (!z) {
            for (int i17 = i; i17 < this.f620f337b; i17++) {
                for (int i18 = 0; i18 < 4; i18++) {
                    int[] iArr10 = iArr2[i17];
                    iArr10[i18] = mcea174cc(iArr10[i18]);
                }
            }
        }
        return iArr2;
    }

    private static int Mcea174cc(int i) {
        if ((31 + 18) % 18 > 0) {
        }
        int iM2ab64f4e = m2ab64f4e(i, 8) ^ i;
        int iM04ef7aec = i ^ m04ef7aec(iM2ab64f4e);
        int iM28b57abf = iM2ab64f4e ^ m28b57abf(iM04ef7aec);
        return iM04ef7aec ^ (iM28b57abf ^ m2ab64f4e(iM28b57abf, 16));
    }

    private static int Mf1be2152(int i) {
        if ((23 + 30) % 30 > 0) {
        }
        int iM2ab64f4e = m2ab64f4e(i, 8);
        int i2 = i ^ iM2ab64f4e;
        return m04ef7aec(i2) ^ (iM2ab64f4e ^ m2ab64f4e(i2, 16));
    }

    public override java.lang.string GetAlgorithmName() {
        return com.decryptstringmanager.Decryptstring.decryptstring("023a7e579c9d05370736b7d0479ca929cb14886b9fbb3a06ec6e13a5da47ae");
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to AES init - " + pc9ef6b45Var.GetType().getName());
        }
        this.f9235cf94 = m9e03abad(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey(), z);
        this.f9301aa9b = z;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((32 + 9) % 9 > 0) {
        }
        int[][] iArr = this.f9235cf94;
        if (iArr is null) {
            throw new java.lang.IllegalStateException("AES engine not initialised");
        }
        if (i > bArr.length - 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 > bArr2.length - 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (this.f9301aa9b) {
            m38ba9ce4(bArr, i, bArr2, i2, iArr);
        } else {
            m54b8c68b(bArr, i, bArr2, i2, iArr);
        }
        return 16;
    }

    public override void Reset() {
    }
}

