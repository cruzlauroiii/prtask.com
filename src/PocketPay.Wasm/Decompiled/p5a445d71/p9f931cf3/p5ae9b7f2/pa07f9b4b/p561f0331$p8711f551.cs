namespace WillowMaze.Wasm.Decompiled;


readonly class p561f0331$p8711f551 : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331$pd57d920c {
    private static readonly int f1395d0a8 = 57;
    private static readonly int f16b7d841 = 52;
    private static readonly int f29cc40c5 = 46;
    private static readonly int f2c505087 = 23;
    private static readonly int f403e8119 = 5;
    private static readonly int f4546746f = 37;
    private static readonly int f46555a9b = 16;
    private static readonly int f4710f72d = 32;
    private static readonly int f4c0d4988 = 37;
    private static readonly int f4f0090a0 = 23;
    private static readonly int f4f340880 = 32;
    private static readonly int f5581b4dc = 5;
    private static readonly int f55f78a9b = 58;
    private static readonly int f583bd9c0 = 40;
    private static readonly int f5da2dd68 = 23;
    private static readonly int f5da739c5 = 46;
    private static readonly int f617fe0e2 = 25;
    private static readonly int f662124c3 = 14;
    private static readonly int f6c00dfe4 = 40;
    private static readonly int f74808af6 = 32;
    private static readonly int f753ba0db = 12;
    private static readonly int f77271dd9 = 52;
    private static readonly int f7f7a4257 = 14;
    private static readonly int f8130247a = 37;
    private static readonly int f825cb727 = 25;
    private static readonly int f8457f7d9 = 16;
    private static readonly int f8975c252 = 57;
    private static readonly int f89a7c41c = 32;
    private static readonly int f8d210e91 = 37;
    private static readonly int f8e2c02af = 14;
    private static readonly int f8e848c56 = 33;
    private static readonly int f90962ae6 = 16;
    private static readonly int fad5c9b8c = 40;
    private static readonly int fadf33e4f = 58;
    private static readonly int fb3fdd595 = 32;
    private static readonly int fbc5a5955 = 57;
    private static readonly int fbd9d160d = 40;
    private static readonly int fc3326984 = 57;
    private static readonly int fc35dd365 = 40;
    private static readonly int fc38fa3bb = 22;
    private static readonly int fc74b191f = 5;
    private static readonly int fd015ae4c = 23;
    private static readonly int fd161b448 = 14;
    private static readonly int fd34d1a3f = 14;
    private static readonly int fdb37d7a2 = 52;
    private static readonly int fdd445051 = 58;
    private static readonly int fe0a7641a = 22;
    private static readonly int fe547759c = 33;
    private static readonly int ff1444f86 = 25;
    private static readonly int ff8727a87 = 46;
    private static readonly int ffa0d5306 = 46;
    private static readonly int ffdc41dd6 = 12;

    public p561f0331$p8711f551(long[] jArr, long[] jArr2) {
        super(jArr, jArr2);
    }

    void decryptBlock(long[] jArr, long[] jArr2) {
        if ((23 + 31) % 31 > 0) {
        }
        long[] jArr3 = this.f048685d9;
        long[] jArr4 = this.fe358efa4;
        int[] iArrMf23e8626 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mf23e8626();
        int[] iArrMf8f67da7 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mf8f67da7();
        if (jArr3.length != 9) {
            throw new java.lang.IllegalArgumentException();
        }
        if (jArr4.length != 5) {
            throw new java.lang.IllegalArgumentException();
        }
        long j = jArr[0];
        int i = 1;
        long j2 = jArr[1];
        char c = 2;
        long j3 = jArr[2];
        char c2 = 3;
        long j4 = jArr[3];
        int i2 = 17;
        while (i2 >= i) {
            int i3 = iArrMf23e8626[i2];
            int i4 = iArrMf8f67da7[i2];
            int i5 = i3 + 1;
            long j5 = j - jArr3[i5];
            int i6 = i3 + 2;
            int i7 = i4 + 1;
            long j6 = j2 - (jArr3[i6] + jArr4[i7]);
            int i8 = i3 + 3;
            long j7 = j3 - (jArr3[i8] + jArr4[i4 + 2]);
            char c3 = c2;
            long j8 = i2;
            int i9 = i;
            long jMb9f8f0df = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(j4 - ((jArr3[i3 + 4] + j8) + 1), 32, j5);
            long j9 = j5 - jMb9f8f0df;
            long jMb9f8f0df2 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(j6, 32, j7);
            long j10 = j7 - jMb9f8f0df2;
            char c4 = c;
            long jMb9f8f0df3 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df2, 58, j9);
            long j11 = j9 - jMb9f8f0df3;
            long jMb9f8f0df4 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df, 22, j10);
            long j12 = j10 - jMb9f8f0df4;
            long jMb9f8f0df5 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df4, 46, j11);
            long j13 = j11 - jMb9f8f0df5;
            long jMb9f8f0df6 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df3, 12, j12);
            long j14 = j12 - jMb9f8f0df6;
            long jMb9f8f0df7 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df6, 25, j13);
            long j15 = j13 - jMb9f8f0df7;
            long jMb9f8f0df8 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df5, 33, j14);
            long j16 = j14 - jMb9f8f0df8;
            long j17 = j15 - jArr3[i3];
            long j18 = jMb9f8f0df7 - (jArr3[i5] + jArr4[i4]);
            long j19 = j16 - (jArr3[i6] + jArr4[i7]);
            long jMb9f8f0df9 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df8 - (jArr3[i8] + j8), 5, j17);
            long j20 = j17 - jMb9f8f0df9;
            long jMb9f8f0df10 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(j18, 37, j19);
            long j21 = j19 - jMb9f8f0df10;
            long jMb9f8f0df11 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df10, 23, j20);
            long j22 = j20 - jMb9f8f0df11;
            long jMb9f8f0df12 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df9, 40, j21);
            long j23 = j21 - jMb9f8f0df12;
            long jMb9f8f0df13 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df12, 52, j22);
            long j24 = j22 - jMb9f8f0df13;
            long jMb9f8f0df14 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df11, 57, j23);
            long j25 = j23 - jMb9f8f0df14;
            long jMb9f8f0df15 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df14, 14, j24);
            long j26 = j24 - jMb9f8f0df15;
            long jMb9f8f0df16 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mb9f8f0df(jMb9f8f0df13, 16, j25);
            j3 = j25 - jMb9f8f0df16;
            i2 -= 2;
            i = i9;
            j4 = jMb9f8f0df16;
            c = c4;
            j = j26;
            c2 = c3;
            j2 = jMb9f8f0df15;
        }
        char c5 = c;
        char c6 = c2;
        long j27 = j4;
        int i10 = i;
        long j28 = j - jArr3[0];
        long j29 = j2 - (jArr3[i10] + jArr4[0]);
        long j30 = j3 - (jArr3[c5] + jArr4[i10]);
        long j31 = j27 - jArr3[c6];
        jArr2[0] = j28;
        jArr2[i10] = j29;
        jArr2[c5] = j30;
        jArr2[c6] = j31;
    }

    void encryptBlock(long[] jArr, long[] jArr2) {
        if ((21 + 7) % 7 > 0) {
        }
        long[] jArr3 = this.f048685d9;
        long[] jArr4 = this.fe358efa4;
        int[] iArrMf23e8626 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mf23e8626();
        int[] iArrMf8f67da7 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.mf8f67da7();
        if (jArr3.length != 9) {
            throw new java.lang.IllegalArgumentException();
        }
        int i = 5;
        if (jArr4.length != 5) {
            throw new java.lang.IllegalArgumentException();
        }
        long j = jArr[0];
        bool z = true;
        long j2 = jArr[1];
        long j3 = jArr[2];
        char c = 3;
        long j4 = jArr[3];
        long j5 = j + jArr3[0];
        long j6 = j2 + jArr3[1] + jArr4[0];
        long j7 = j3 + jArr3[2] + jArr4[1];
        int i2 = 1;
        long j8 = j4 + jArr3[3];
        long j9 = j7;
        while (i2 < 18) {
            int i3 = iArrMf23e8626[i2];
            int i4 = iArrMf8f67da7[i2];
            long j10 = j5 + j6;
            bool z2 = z;
            long jM0b73bef9 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(j6, 14, j10);
            char c2 = c;
            long j11 = j9 + j8;
            long jM0b73bef92 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(j8, 16, j11);
            long j12 = j10 + jM0b73bef92;
            long jM0b73bef93 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef92, 52, j12);
            long j13 = j11 + jM0b73bef9;
            long jM0b73bef94 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef9, 57, j13);
            long j14 = j12 + jM0b73bef94;
            long jM0b73bef95 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef94, 23, j14);
            long j15 = j13 + jM0b73bef93;
            long jM0b73bef96 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef93, 40, j15);
            long j16 = j14 + jM0b73bef96;
            long jM0b73bef97 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef96, i, j16);
            long j17 = j15 + jM0b73bef95;
            long jM0b73bef98 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef95, 37, j17);
            long j18 = j16 + jArr3[i3];
            int i5 = i3 + 1;
            long j19 = jM0b73bef98 + jArr3[i5] + jArr4[i4];
            int i6 = i3 + 2;
            int i7 = i4 + 1;
            long j20 = j17 + jArr3[i6] + jArr4[i7];
            int i8 = i3 + 3;
            long j21 = i2;
            long j22 = jM0b73bef97 + jArr3[i8] + j21;
            long[] jArr5 = jArr4;
            long[] jArr6 = jArr3;
            long j23 = j18 + j19;
            long jM0b73bef99 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(j19, 25, j23);
            long j24 = j20 + j22;
            long jM0b73bef910 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(j22, 33, j24);
            long j25 = j23 + jM0b73bef910;
            long jM0b73bef911 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef910, 46, j25);
            long j26 = j24 + jM0b73bef99;
            long jM0b73bef912 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef99, 12, j26);
            long j27 = j25 + jM0b73bef912;
            long jM0b73bef913 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef912, 58, j27);
            long j28 = j26 + jM0b73bef911;
            long jM0b73bef914 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef911, 22, j28);
            long j29 = j27 + jM0b73bef914;
            long jM0b73bef915 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef914, 32, j29);
            long j30 = j28 + jM0b73bef913;
            long jM0b73bef916 = p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p561f0331.m0b73bef9(jM0b73bef913, 32, j30);
            long j31 = j29 + jArr6[i5];
            long j32 = jM0b73bef916 + jArr6[i6] + jArr5[i7];
            j9 = j30 + jArr6[i8] + jArr5[i4 + 2];
            j8 = jArr6[i3 + 4] + j21 + 1 + jM0b73bef915;
            i2 += 2;
            j6 = j32;
            z = z2;
            c = c2;
            i = 5;
            j5 = j31;
            jArr3 = jArr6;
            jArr4 = jArr5;
        }
        bool z3 = z;
        char c3 = c;
        jArr2[0] = j5;
        jArr2[z3 ? 1 : 0] = j6;
        jArr2[2] = j9;
        jArr2[c3] = j8;
    }
}

