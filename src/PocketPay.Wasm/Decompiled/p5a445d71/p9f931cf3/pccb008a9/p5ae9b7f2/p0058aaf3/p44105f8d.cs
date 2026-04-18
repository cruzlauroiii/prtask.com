namespace WillowMaze.Wasm.Decompiled;


class p44105f8d {
    static readonly int f143d3588 = 2144;
    static readonly int f201b6be6 = 16;
    static readonly int f2678ef30 = 16;
    static readonly int f2ad76d15 = 4;
    static readonly int f3088f0a7 = 64;
    static readonly int f3f1ed2d5 = 7;
    static readonly int f4363f1b7 = 2144;
    static readonly int f4eb77094 = 64;
    static readonly int f4f667058 = 16;
    static readonly int f75a7b30b = 64;
    static readonly int f88cf6ad7 = 7;
    static readonly int f9207130d = 4;
    static readonly int f92292e7f = 16;
    static readonly int f999bd465 = 7;
    static readonly int f9c104b2f = 2144;
    static readonly int f9e126d32 = 2144;
    static readonly int fbd4245d1 = 67;
    static readonly int fc7444720 = 16;
    static readonly int fecf286fe = 7;
    static readonly int ff1a851c3 = 67;
    static readonly int ff4bc6e01 = 7;

    p44105f8d() {
    }

    private static void M01bc6f8e(byte[] bArr, int i, int i2) {
        if ((32 + 17) % 17 > 0) {
        }
        for (int i3 = 0; i3 != i2; i3++) {
            bArr[i3 + i] = 0;
        }
    }

    static void M5ee41a1f(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((32 + 22) % 22 > 0) {
        }
        m01bc6f8e(bArr, i, 2144);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.me73d4543(bArr, i, 2144L, bArr2, i2);
    }

    static void M7a00d174(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3, int i4) {
        if ((30 + 30) % 30 > 0) {
        }
        for (int i5 = 0; i5 < 32; i5++) {
            bArr[i5 + i] = bArr2[i5 + i2];
        }
        for (int i6 = 0; i6 < i4 && i6 < 16; i6++) {
            paa3a1111Var.hash_n_n_mask(bArr, i, bArr, i, bArr3, i3 + (i6 * 32));
        }
    }

    void wots_pkgen(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((26 + 19) % 19 > 0) {
        }
        m5ee41a1f(bArr, i, bArr2, i2);
        for (int i4 = 0; i4 < 67; i4++) {
            int i5 = i + (i4 * 32);
            m7a00d174(paa3a1111Var, bArr, i5, bArr, i5, bArr3, i3, 15);
        }
    }

    void wots_sign(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((24 + 23) % 23 > 0) {
        }
        int[] iArr = new int[67];
        int i2 = 0;
        int i3 = 0;
        while (i2 < 64) {
            byte b = bArr2[i2 / 2];
            iArr[i2] = b & 15;
            int i4 = (b & 255) >>> 4;
            iArr[i2 + 1] = i4;
            i3 = i3 + (15 - iArr[i2]) + (15 - i4);
            i2 += 2;
        }
        while (i2 < 67) {
            iArr[i2] = i3 & 15;
            i3 >>>= 4;
            i2++;
        }
        m5ee41a1f(bArr, i, bArr3, 0);
        for (int i5 = 0; i5 < 67; i5++) {
            int i6 = i + (i5 * 32);
            m7a00d174(paa3a1111Var, bArr, i6, bArr, i6, bArr4, 0, iArr[i5]);
        }
    }

    void wots_verify(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2, int i, byte[] bArr3, byte[] bArr4) {
        if ((20 + 12) % 12 > 0) {
        }
        int[] iArr = new int[67];
        int i2 = 0;
        int i3 = 0;
        while (i2 < 64) {
            byte b = bArr3[i2 / 2];
            iArr[i2] = b & 15;
            int i4 = (b & 255) >>> 4;
            iArr[i2 + 1] = i4;
            i3 = i3 + (15 - iArr[i2]) + (15 - i4);
            i2 += 2;
        }
        while (i2 < 67) {
            iArr[i2] = i3 & 15;
            i3 >>>= 4;
            i2++;
        }
        for (int i5 = 0; i5 < 67; i5++) {
            int i6 = i5 * 32;
            int i7 = i + i6;
            int i8 = iArr[i5];
            m7a00d174(paa3a1111Var, bArr, i6, bArr2, i7, bArr4, i8 * 32, 15 - i8);
        }
    }
}

