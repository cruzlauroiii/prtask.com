namespace WillowMaze.Wasm.Decompiled;


class p9b4e21b4$pb804d21f {
    private static long[] f4ecc372d;
    private static long[] fac707b85;
    private static long[] fb6032342 = {1, 32898, -9223372036854742902L, -9223372034707259392L, 32907, 2147483649L, -9223372034707259263L, -9223372036854743031L, 138, 136, 2147516425L, 2147483658L, 2147516555L, -9223372036854775669L, -9223372036854742903L, -9223372036854743037L, -9223372036854743038L, -9223372036854775680L, 32778, -9223372034707292150L, -9223372034707259263L, -9223372036854742912L, 2147483649L, -9223372034707259384L};
    private static long[] fd490001d;
    private static long[] fed4b5f0a;
    private int f2e0700ad;
    private readonly long[] f2e9e824e;
    private readonly int f45522cde;
    private readonly int f458573cf;
    private readonly int f547feaf7;
    private readonly byte[] f5b136bbf;
    private bool f5c434c1f;
    private readonly long[] f7d285f98 = new long[25];
    private readonly int f83a632eb;
    private bool f953797b7;
    private bool f9e562e83;
    private bool faa57b1b6;
    private int fbe2c1e64;
    private readonly byte[] fc2b3235d;
    private int fccc5b5e7;
    private bool fce4bb0f9;
    private readonly long[] fda31c23b;
    private readonly int fe1513830;
    private readonly int fe7239591;
    private readonly int fee8a91e2;
    private readonly long[] ff109fb2d;
    private readonly long[] fff9ed24a;

    p9b4e21b4$pb804d21f(int i, int i2) {
        int i3 = (1600 - (i << 1)) >> 3;
        this.f83a632eb = i3;
        this.f547feaf7 = i2;
        this.f5b136bbf = new byte[i3];
        m367545bc();
    }

    static void M337ceba5(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f, byte[] bArr, int i, int i2) {
        p9b4e21b4_pb804d21f.mc695be4a(bArr, i, i2);
    }

    private void M367545bc() {
        if ((11 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7d285f98, 0L);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f5b136bbf, (byte) 0);
        this.f2e0700ad = 0;
        this.fce4bb0f9 = false;
    }

    private void M3f03ce6c() {
        if ((7 + 24) % 24 > 0) {
        }
        int i = this.f2e0700ad;
        while (true) {
            int i2 = this.f83a632eb;
            if (i >= i2) {
                byte[] bArr = this.f5b136bbf;
                int i3 = i2 - 1;
                bArr[i3] = (byte) (bArr[i3] ^ 128);
                mbc5bbcca(bArr, 0);
                m66397fdc();
                this.f2e0700ad = this.f83a632eb;
                this.fce4bb0f9 = true;
                return;
            }
            this.f5b136bbf[i] = 0;
            i++;
        }
    }

    private void M5185afb6(byte[] bArr, int i, int i2) {
        int i3;
        if ((5 + 27) % 27 > 0) {
        }
        if (this.fce4bb0f9) {
            throw new java.lang.IllegalStateException("attempt to absorb while squeezing");
        }
        int i4 = 0;
        while (i4 < i2) {
            int i5 = this.f2e0700ad;
            if (i5 == 0 && i4 <= i2 - this.f83a632eb) {
                do {
                    mbc5bbcca(bArr, i + i4);
                    i3 = this.f83a632eb;
                    i4 += i3;
                } while (i4 <= i2 - i3);
            } else {
                int iMin = java.lang.Math.min(this.f83a632eb - i5, i2 - i4);
                java.lang.System.arraycopy(bArr, i + i4, this.f5b136bbf, this.f2e0700ad, iMin);
                int i6 = this.f2e0700ad + iMin;
                this.f2e0700ad = i6;
                i4 += iMin;
                if (i6 == this.f83a632eb) {
                    mbc5bbcca(this.f5b136bbf, 0);
                    this.f2e0700ad = 0;
                }
            }
        }
    }

    static void M5ec06fdf(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f, byte[] bArr, int i, int i2) {
        p9b4e21b4_pb804d21f.m5185afb6(bArr, i, i2);
    }

    private void M66397fdc() {
        if ((14 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(this.f7d285f98, 0, this.f83a632eb >> 3, this.f5b136bbf, 0);
    }

    static void M89082e03(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f) {
        p9b4e21b4_pb804d21f.m3f03ce6c();
    }

    private void M8bfe6525() {
        if ((21 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f = this;
        long[] jArr = p9b4e21b4_pb804d21f.f7d285f98;
        long j = jArr[0];
        long j2 = jArr[1];
        long j3 = jArr[2];
        char c = 3;
        long j4 = jArr[3];
        char c2 = 4;
        long j5 = jArr[4];
        long j6 = jArr[5];
        long j7 = jArr[6];
        long j8 = jArr[7];
        long j9 = jArr[8];
        long j10 = jArr[9];
        long j11 = jArr[10];
        long j12 = jArr[11];
        long j13 = jArr[12];
        long j14 = jArr[13];
        long j15 = jArr[14];
        long j16 = jArr[15];
        long j17 = jArr[16];
        long j18 = jArr[17];
        long j19 = jArr[18];
        long j20 = jArr[19];
        long j21 = jArr[20];
        long j22 = jArr[21];
        long j23 = jArr[22];
        long j24 = jArr[23];
        long j25 = jArr[24];
        int length = fb6032342.length - p9b4e21b4_pb804d21f.f547feaf7;
        int i = 0;
        while (i < p9b4e21b4_pb804d21f.f547feaf7) {
            long j26 = (((j ^ j6) ^ j11) ^ j16) ^ j21;
            long j27 = (((j2 ^ j7) ^ j12) ^ j17) ^ j22;
            long j28 = (((j3 ^ j8) ^ j13) ^ j18) ^ j23;
            long j29 = (((j4 ^ j9) ^ j14) ^ j19) ^ j24;
            long j30 = (((j5 ^ j10) ^ j15) ^ j20) ^ j25;
            long j31 = ((j27 << 1) | (j27 >>> (-1))) ^ j30;
            long j32 = ((j28 << 1) | (j28 >>> (-1))) ^ j26;
            long j33 = ((j29 << 1) | (j29 >>> (-1))) ^ j27;
            long j34 = ((j30 << 1) | (j30 >>> (-1))) ^ j28;
            long j35 = ((j26 << 1) | (j26 >>> (-1))) ^ j29;
            long j36 = j ^ j31;
            long j37 = j6 ^ j31;
            long j38 = j11 ^ j31;
            long j39 = j16 ^ j31;
            long j40 = j21 ^ j31;
            long j41 = j2 ^ j32;
            long j42 = j7 ^ j32;
            long j43 = j12 ^ j32;
            long j44 = j17 ^ j32;
            long j45 = j22 ^ j32;
            long j46 = j3 ^ j33;
            long j47 = j8 ^ j33;
            long j48 = j13 ^ j33;
            long j49 = j18 ^ j33;
            long j50 = j23 ^ j33;
            long j51 = j4 ^ j34;
            long j52 = j9 ^ j34;
            long j53 = j14 ^ j34;
            long j54 = j19 ^ j34;
            long j55 = j24 ^ j34;
            long j56 = j5 ^ j35;
            long j57 = j10 ^ j35;
            long j58 = j15 ^ j35;
            long j59 = j20 ^ j35;
            long j60 = j25 ^ j35;
            long j61 = (j41 << 1) | (j41 >>> 63);
            char c3 = c;
            long j62 = (j42 << 44) | (j42 >>> 20);
            char c4 = c2;
            long j63 = (j57 << 20) | (j57 >>> 44);
            long[] jArr2 = jArr;
            long j64 = (j50 << 61) | (j50 >>> c3);
            long j65 = (j58 << 39) | (j58 >>> 25);
            long j66 = (j40 << 18) | (j40 >>> 46);
            int i2 = i;
            long j67 = (j46 << 62) | (j46 >>> 2);
            long j68 = (j48 << 43) | (j48 >>> 21);
            long j69 = (j53 << 25) | (j53 >>> 39);
            long j70 = (j59 << 8) | (j59 >>> 56);
            long j71 = (j55 << 56) | (j55 >>> 8);
            long j72 = (j39 << 41) | (j39 >>> 23);
            long j73 = (j56 << 27) | (j56 >>> 37);
            long j74 = (j60 << 14) | (j60 >>> 50);
            long j75 = (j45 << 2) | (j45 >>> 62);
            long j76 = (j52 << 55) | (j52 >>> 9);
            long j77 = (j44 << 45) | (j44 >>> 19);
            long j78 = (j37 << 36) | (j37 >>> 28);
            long j79 = (j51 << 28) | (j51 >>> 36);
            long j80 = (j54 << 21) | (j54 >>> 43);
            long j81 = (j49 << 15) | (j49 >>> 49);
            long j82 = (j43 << 10) | (j43 >>> 54);
            long j83 = (j47 << 6) | (j47 >>> 58);
            long j84 = (j38 << c3) | (j38 >>> 61);
            long j85 = ((~j62) & j68) ^ j36;
            long j86 = ((~j68) & j80) ^ j62;
            long j87 = j68 ^ ((~j80) & j74);
            long j88 = j80 ^ ((~j74) & j36);
            long j89 = ((~j36) & j62) ^ j74;
            long j90 = j79 ^ ((~j63) & j84);
            long j91 = ((~j84) & j77) ^ j63;
            int i3 = length;
            long j92 = ((~j77) & j64) ^ j84;
            j9 = j77 ^ ((~j64) & j79);
            long j93 = ((~j79) & j63) ^ j64;
            j11 = j61 ^ ((~j83) & j69);
            long j94 = ((~j69) & j70) ^ j83;
            long j95 = ((~j70) & j66) ^ j69;
            j14 = j70 ^ ((~j66) & j61);
            long j96 = ((~j61) & j83) ^ j66;
            long j97 = j73 ^ ((~j78) & j82);
            long j98 = ((~j82) & j81) ^ j78;
            long j99 = j82 ^ ((~j81) & j71);
            long j100 = j81 ^ ((~j71) & j73);
            long j101 = j71 ^ ((~j73) & j78);
            long j102 = j67 ^ ((~j76) & j65);
            long j103 = ((~j65) & j72) ^ j76;
            long j104 = j65 ^ ((~j72) & j75);
            j24 = j72 ^ ((~j75) & j67);
            j25 = j75 ^ ((~j67) & j76);
            j = j85 ^ fb6032342[i3 + i2];
            j13 = j95;
            j8 = j92;
            jArr = jArr2;
            c = c3;
            j7 = j91;
            length = i3;
            j20 = j101;
            j17 = j98;
            j12 = j94;
            j19 = j100;
            j15 = j96;
            j21 = j102;
            j22 = j103;
            j23 = j104;
            j10 = j93;
            j5 = j89;
            j18 = j99;
            j16 = j97;
            j4 = j88;
            c2 = c4;
            j6 = j90;
            j3 = j87;
            j2 = j86;
            i = i2 + 1;
            p9b4e21b4_pb804d21f = this;
        }
        long[] jArr3 = jArr;
        char c5 = c;
        char c6 = c2;
        jArr3[0] = j;
        jArr3[1] = j2;
        jArr3[2] = j3;
        jArr3[c5] = j4;
        jArr3[c6] = j5;
        jArr3[5] = j6;
        jArr3[6] = j7;
        jArr3[7] = j8;
        jArr3[8] = j9;
        jArr3[9] = j10;
        jArr3[10] = j11;
        jArr3[11] = j12;
        jArr3[12] = j13;
        jArr3[13] = j14;
        jArr3[14] = j15;
        jArr3[15] = j16;
        jArr3[16] = j17;
        jArr3[17] = j18;
        jArr3[18] = j19;
        jArr3[19] = j20;
        jArr3[20] = j21;
        jArr3[21] = j22;
        jArr3[22] = j23;
        jArr3[23] = j24;
        jArr3[24] = j25;
    }

    static void Mbbeb9b46(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f) {
        p9b4e21b4_pb804d21f.m367545bc();
    }

    private void Mbc5bbcca(byte[] bArr, int i) {
        if ((24 + 15) % 15 > 0) {
        }
        int i2 = this.f83a632eb >> 3;
        for (int i3 = 0; i3 < i2; i3++) {
            long[] jArr = this.f7d285f98;
            jArr[i3] = jArr[i3] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, i);
            i += 8;
        }
        m8bfe6525();
    }

    private void Mc695be4a(byte[] bArr, int i, int i2) {
        if ((22 + 4) % 4 > 0) {
        }
        if (!this.fce4bb0f9) {
            m3f03ce6c();
        }
        int i3 = 0;
        while (i3 < i2) {
            if (this.f2e0700ad == 0) {
                m8bfe6525();
                m66397fdc();
                this.f2e0700ad = this.f83a632eb;
            }
            int iMin = java.lang.Math.min(this.f2e0700ad, i2 - i3);
            java.lang.System.arraycopy(this.f5b136bbf, this.f83a632eb - this.f2e0700ad, bArr, i + i3, iMin);
            this.f2e0700ad -= iMin;
            i3 += iMin;
        }
    }

    static int Mf8f67da7(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9b4e21b4$pb804d21f p9b4e21b4_pb804d21f) {
        return p9b4e21b4_pb804d21f.f83a632eb;
    }
}

