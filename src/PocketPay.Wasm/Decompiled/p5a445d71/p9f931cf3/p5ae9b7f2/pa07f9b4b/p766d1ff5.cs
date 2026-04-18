namespace WillowMaze.Wasm.Decompiled;


public class p766d1ff5 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static byte[] f14749d7a = {-39, 120, -7, -60, 25, -35, -75, -19, 40, -23, -3, 121, 74, -96, -40, -99, -58, 126, 55, -125, 43, 118, 83, -114, 98, 76, 100, -120, 68, -117, -5, -94, 23, -102, 89, -11, -121, -77, 79, 19, 97, 69, 109, -115, 9, -127, 125, 50, -67, -113, 64, -21, -122, -73, 123, 11, -16, -107, 33, 34, 92, 107, 78, -126, 84, -42, 101, -109, -50, 96, -78, 28, 115, 86, -64, 20, -89, -116, -15, -36, 18, 117, -54, 31, 59, -66, -28, -47, 66, 61, -44, 48, -93, 60, -74, 38, 111, -65, 14, -38, 70, 105, 7, 87, 39, -14, 29, -101, -68, -108, 67, 3, -8, 17, -57, -10, -112, -17, 62, -25, 6, -61, -43, 47, -56, 102, 30, -41, 8, -24, -22, -34, -128, 82, -18, -9, -124, -86, 114, -84, 53, 77, 106, 42, -106, 26, -46, 113, 90, 21, 73, 116, 75, -97, -48, 94, 4, 24, -92, -20, -62, -32, 65, 110, 15, 81, -53, -52, 36, -111, -81, 80, -95, -12, 112, 57, -103, 124, 58, -123, 35, -72, -76, 122, -4, 2, 54, 91, 37, 85, -105, 49, 45, 93, -6, -104, -29, -118, -110, -82, 5, -33, 41, 16, 103, 108, -70, -55, -45, 0, -26, -49, -31, -98, -88, 44, 99, 22, 1, 63, 88, -30, -119, -87, 13, 56, 52, 27, -85, 51, -1, -80, -69, 72, 12, 95, -71, -79, -51, 46, -59, -13, -37, 71, -27, -91, -100, 119, 10, -90, 32, 104, -2, 127, -63, -83};
    private static readonly int f1a94fb60 = 8;
    private static byte[] f2c9da57d = null;
    private static byte[] f7309eb25 = null;
    private static byte[] f813f7d6a = null;
    private static readonly int fc75e2054 = 8;
    private int[] f0d9d1f7a;
    private int[] f1ebdb8c5;
    private bool f78e3449f;
    private bool f817ff03a;
    private int[] fa6fefe02;
    private bool fb8d78156;
    private int[] fe82aade8;

    private void M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((32 + 9) % 9 > 0) {
        }
        int iM648b0931 = ((bArr[i + 7] & 255) << 8) + (bArr[i + 6] & 255);
        int iM648b09312 = ((bArr[i + 5] & 255) << 8) + (bArr[i + 4] & 255);
        int iM648b09313 = ((bArr[i + 3] & 255) << 8) + (bArr[i + 2] & 255);
        int iM648b09314 = ((bArr[i + 1] & 255) << 8) + (bArr[i] & 255);
        for (int i3 = 0; i3 <= 16; i3 += 4) {
            iM648b09314 = m648b0931(iM648b09314 + ((~iM648b0931) & iM648b09313) + (iM648b09312 & iM648b0931) + this.f0d9d1f7a[i3], 1);
            iM648b09313 = m648b0931(iM648b09313 + ((~iM648b09314) & iM648b09312) + (iM648b0931 & iM648b09314) + this.f0d9d1f7a[i3 + 1], 2);
            iM648b09312 = m648b0931(iM648b09312 + ((~iM648b09313) & iM648b0931) + (iM648b09314 & iM648b09313) + this.f0d9d1f7a[i3 + 2], 3);
            iM648b0931 = m648b0931(iM648b0931 + ((~iM648b09312) & iM648b09314) + (iM648b09313 & iM648b09312) + this.f0d9d1f7a[i3 + 3], 5);
        }
        int[] iArr = this.f0d9d1f7a;
        int iM648b09315 = iM648b09314 + iArr[iM648b0931 & 63];
        int iM648b09316 = iM648b09313 + iArr[iM648b09315 & 63];
        int iM648b09317 = iM648b09312 + iArr[iM648b09316 & 63];
        int iM648b09318 = iM648b0931 + iArr[iM648b09317 & 63];
        for (int i4 = 20; i4 <= 40; i4 += 4) {
            iM648b09315 = m648b0931(iM648b09315 + ((~iM648b09318) & iM648b09316) + (iM648b09317 & iM648b09318) + this.f0d9d1f7a[i4], 1);
            iM648b09316 = m648b0931(iM648b09316 + ((~iM648b09315) & iM648b09317) + (iM648b09318 & iM648b09315) + this.f0d9d1f7a[i4 + 1], 2);
            iM648b09317 = m648b0931(iM648b09317 + ((~iM648b09316) & iM648b09318) + (iM648b09315 & iM648b09316) + this.f0d9d1f7a[i4 + 2], 3);
            iM648b09318 = m648b0931(iM648b09318 + ((~iM648b09317) & iM648b09315) + (iM648b09316 & iM648b09317) + this.f0d9d1f7a[i4 + 3], 5);
        }
        int[] iArr2 = this.f0d9d1f7a;
        int iM648b09319 = iM648b09315 + iArr2[iM648b09318 & 63];
        int iM648b093110 = iM648b09316 + iArr2[iM648b09319 & 63];
        int iM648b093111 = iM648b09317 + iArr2[iM648b093110 & 63];
        int iM648b093112 = iM648b09318 + iArr2[iM648b093111 & 63];
        for (int i5 = 44; i5 < 64; i5 += 4) {
            iM648b09319 = m648b0931(iM648b09319 + ((~iM648b093112) & iM648b093110) + (iM648b093111 & iM648b093112) + this.f0d9d1f7a[i5], 1);
            iM648b093110 = m648b0931(iM648b093110 + ((~iM648b09319) & iM648b093111) + (iM648b093112 & iM648b09319) + this.f0d9d1f7a[i5 + 1], 2);
            iM648b093111 = m648b0931(iM648b093111 + ((~iM648b093110) & iM648b093112) + (iM648b09319 & iM648b093110) + this.f0d9d1f7a[i5 + 2], 3);
            iM648b093112 = m648b0931(iM648b093112 + ((~iM648b093111) & iM648b09319) + (iM648b093110 & iM648b093111) + this.f0d9d1f7a[i5 + 3], 5);
        }
        bArr2[i2] = (byte) iM648b09319;
        bArr2[i2 + 1] = (byte) (iM648b09319 >> 8);
        bArr2[i2 + 2] = (byte) iM648b093110;
        bArr2[i2 + 3] = (byte) (iM648b093110 >> 8);
        bArr2[i2 + 4] = (byte) iM648b093111;
        bArr2[i2 + 5] = (byte) (iM648b093111 >> 8);
        bArr2[i2 + 6] = (byte) iM648b093112;
        bArr2[i2 + 7] = (byte) (iM648b093112 >> 8);
    }

    private void M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((16 + 8) % 8 > 0) {
        }
        int iM648b0931 = ((bArr[i + 7] & 255) << 8) + (bArr[i + 6] & 255);
        int iM648b09312 = ((bArr[i + 5] & 255) << 8) + (bArr[i + 4] & 255);
        int iM648b09313 = ((bArr[i + 3] & 255) << 8) + (bArr[i + 2] & 255);
        int iM648b09314 = ((bArr[i + 1] & 255) << 8) + (bArr[i] & 255);
        for (int i3 = 60; i3 >= 44; i3 -= 4) {
            iM648b0931 = m648b0931(iM648b0931, 11) - ((((~iM648b09312) & iM648b09314) + (iM648b09313 & iM648b09312)) + this.f0d9d1f7a[i3 + 3]);
            iM648b09312 = m648b0931(iM648b09312, 13) - ((((~iM648b09313) & iM648b0931) + (iM648b09314 & iM648b09313)) + this.f0d9d1f7a[i3 + 2]);
            iM648b09313 = m648b0931(iM648b09313, 14) - ((((~iM648b09314) & iM648b09312) + (iM648b0931 & iM648b09314)) + this.f0d9d1f7a[i3 + 1]);
            iM648b09314 = m648b0931(iM648b09314, 15) - ((((~iM648b0931) & iM648b09313) + (iM648b09312 & iM648b0931)) + this.f0d9d1f7a[i3]);
        }
        int[] iArr = this.f0d9d1f7a;
        int iM648b09315 = iM648b0931 - iArr[iM648b09312 & 63];
        int iM648b09316 = iM648b09312 - iArr[iM648b09313 & 63];
        int iM648b09317 = iM648b09313 - iArr[iM648b09314 & 63];
        int iM648b09318 = iM648b09314 - iArr[iM648b09315 & 63];
        for (int i4 = 40; i4 >= 20; i4 -= 4) {
            iM648b09315 = m648b0931(iM648b09315, 11) - ((((~iM648b09316) & iM648b09318) + (iM648b09317 & iM648b09316)) + this.f0d9d1f7a[i4 + 3]);
            iM648b09316 = m648b0931(iM648b09316, 13) - ((((~iM648b09317) & iM648b09315) + (iM648b09318 & iM648b09317)) + this.f0d9d1f7a[i4 + 2]);
            iM648b09317 = m648b0931(iM648b09317, 14) - ((((~iM648b09318) & iM648b09316) + (iM648b09315 & iM648b09318)) + this.f0d9d1f7a[i4 + 1]);
            iM648b09318 = m648b0931(iM648b09318, 15) - ((((~iM648b09315) & iM648b09317) + (iM648b09316 & iM648b09315)) + this.f0d9d1f7a[i4]);
        }
        int[] iArr2 = this.f0d9d1f7a;
        int iM648b09319 = iM648b09315 - iArr2[iM648b09316 & 63];
        int iM648b093110 = iM648b09316 - iArr2[iM648b09317 & 63];
        int iM648b093111 = iM648b09317 - iArr2[iM648b09318 & 63];
        int iM648b093112 = iM648b09318 - iArr2[iM648b09319 & 63];
        for (int i5 = 16; i5 >= 0; i5 -= 4) {
            iM648b09319 = m648b0931(iM648b09319, 11) - ((((~iM648b093110) & iM648b093112) + (iM648b093111 & iM648b093110)) + this.f0d9d1f7a[i5 + 3]);
            iM648b093110 = m648b0931(iM648b093110, 13) - ((((~iM648b093111) & iM648b09319) + (iM648b093112 & iM648b093111)) + this.f0d9d1f7a[i5 + 2]);
            iM648b093111 = m648b0931(iM648b093111, 14) - ((((~iM648b093112) & iM648b093110) + (iM648b09319 & iM648b093112)) + this.f0d9d1f7a[i5 + 1]);
            iM648b093112 = m648b0931(iM648b093112, 15) - ((((~iM648b09319) & iM648b093111) + (iM648b093110 & iM648b09319)) + this.f0d9d1f7a[i5]);
        }
        bArr2[i2] = (byte) iM648b093112;
        bArr2[i2 + 1] = (byte) (iM648b093112 >> 8);
        bArr2[i2 + 2] = (byte) iM648b093111;
        bArr2[i2 + 3] = (byte) (iM648b093111 >> 8);
        bArr2[i2 + 4] = (byte) iM648b093110;
        bArr2[i2 + 5] = (byte) (iM648b093110 >> 8);
        bArr2[i2 + 6] = (byte) iM648b09319;
        bArr2[i2 + 7] = (byte) (iM648b09319 >> 8);
    }

    private int M648b0931(int i, int i2) {
        int i3 = 65535 & i;
        return (i3 >> (16 - i2)) | (i3 << i2);
    }

    private int[] M9e03abad(byte[] bArr, int i) {
        if ((20 + 17) % 17 > 0) {
        }
        int[] iArr = new int[128];
        for (int i2 = 0; i2 != bArr.length; i2++) {
            iArr[i2] = bArr[i2] & 255;
        }
        int length = bArr.length;
        if (length < 128) {
            int i3 = iArr[length - 1];
            int i4 = 0;
            while (true) {
                int i5 = i4 + 1;
                i3 = f14749d7a[(i3 + iArr[i4]) & 255] & 255;
                int i6 = length + 1;
                iArr[length] = i3;
                if (i6 >= 128) {
                    break;
                }
                length = i6;
                i4 = i5;
            }
        }
        int i7 = (i + 7) >> 3;
        int i8 = 128 - i7;
        int i9 = f14749d7a[(255 >> ((-i) & 7)) & iArr[i8]] & 255;
        iArr[i8] = i9;
        for (int i10 = 127 - i7; i10 >= 0; i10--) {
            i9 = f14749d7a[i9 ^ iArr[i10 + i7]] & 255;
            iArr[i10] = i9;
        }
        int[] iArr2 = new int[64];
        for (int i11 = 0; i11 != 64; i11++) {
            int i12 = i11 * 2;
            iArr2[i11] = iArr[i12] + (iArr[i12 + 1] << 8);
        }
        return iArr2;
    }

    public override java.lang.string GetAlgorithmName() {
        return "RC2";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f78e3449f = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p397c291f) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p397c291f p397c291fVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p397c291f) pc9ef6b45Var;
            this.f0d9d1f7a = m9e03abad(p397c291fVar.getKey(), p397c291fVar.getEffectiveKeyBits());
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
                throw new java.lang.IllegalArgumentException("invalid parameter passed to RC2 init - " + pc9ef6b45Var.GetType().getName());
            }
            byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
            this.f0d9d1f7a = m9e03abad(key, key.length * 8);
        }
    }

    public override readonly int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((3 + 14) % 14 > 0) {
        }
        if (this.f0d9d1f7a is null) {
            throw new java.lang.IllegalStateException("RC2 engine not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (this.f78e3449f) {
            m38ba9ce4(bArr, i, bArr2, i2);
            return 8;
        }
        m54b8c68b(bArr, i, bArr2, i2);
        return 8;
    }

    public override void Reset() {
    }
}

