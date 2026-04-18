namespace WillowMaze.Wasm.Decompiled;


public class p80d89765 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 {
    private static long[] f92d95fb7;
    private static long[] f9609f5f3;
    private static long[] fb6032342 = {1, 32898, -9223372036854742902L, -9223372034707259392L, 32907, 2147483649L, -9223372034707259263L, -9223372036854743031L, 138, 136, 2147516425L, 2147483658L, 2147516555L, -9223372036854775669L, -9223372036854742903L, -9223372036854743037L, -9223372036854743038L, -9223372036854775680L, 32778, -9223372034707292150L, -9223372034707259263L, -9223372036854742912L, 2147483649L, -9223372034707259384L};
    protected int f05e7eb79;
    protected bool f192cbebd;
    protected long[] f4883c6cb;
    protected long[] f49f148af;
    protected int f67942503;
    protected int f808f248f;
    protected int f81862f5c;
    protected int f82db2382;
    protected long[] f89c6db6a;
    protected long[] f9ed39e2e;
    protected byte[] fa0131083;
    protected byte[] fc0ba87d2;
    protected bool fcd857418;
    protected bool fcda5259c;
    protected bool fce4bb0f9;
    protected long[] fdb6b30dd;
    protected int feb047a92;
    protected bool ff8425ec5;

    public p80d89765() {
        this(288);
    }

    public p80d89765(int i) {
        this.f9ed39e2e = new long[25];
        this.fc0ba87d2 = new byte[192];
        me37f0136(i);
    }

    public p80d89765(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80d89765 p80d89765Var) {
        if ((1 + 17) % 17 > 0) {
        }
        long[] jArr = new long[25];
        this.f9ed39e2e = jArr;
        this.fc0ba87d2 = new byte[192];
        long[] jArr2 = p80d89765Var.f9ed39e2e;
        java.lang.System.arraycopy(jArr2, 0, jArr, 0, jArr2.length);
        byte[] bArr = p80d89765Var.fc0ba87d2;
        java.lang.System.arraycopy(bArr, 0, this.fc0ba87d2, 0, bArr.length);
        this.f67942503 = p80d89765Var.f67942503;
        this.f82db2382 = p80d89765Var.f82db2382;
        this.f808f248f = p80d89765Var.f808f248f;
        this.fce4bb0f9 = p80d89765Var.fce4bb0f9;
    }

    private void M367545bc(int i) {
        if ((12 + 8) % 8 > 0) {
        }
        if (i <= 0 || i >= 1600 || i % 64 != 0) {
            throw new java.lang.IllegalStateException("invalid rate value");
        }
        this.f67942503 = i;
        int i2 = 0;
        while (true) {
            long[] jArr = this.f9ed39e2e;
            if (i2 >= jArr.length) {
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fc0ba87d2, (byte) 0);
                this.f82db2382 = 0;
                this.fce4bb0f9 = false;
                this.f808f248f = (1600 - i) / 2;
                return;
            }
            jArr[i2] = 0;
            i2++;
        }
    }

    private void M3f03ce6c() {
        if ((8 + 16) % 16 > 0) {
        }
        byte[] bArr = this.fc0ba87d2;
        int i = this.f82db2382;
        int i2 = i >>> 3;
        bArr[i2] = (byte) (bArr[i2] | ((byte) (1 << (i & 7))));
        int i3 = i + 1;
        this.f82db2382 = i3;
        if (i3 != this.f67942503) {
            int i4 = i3 >>> 6;
            int i5 = i3 & 63;
            int i6 = 0;
            for (int i7 = 0; i7 < i4; i7++) {
                long[] jArr = this.f9ed39e2e;
                jArr[i7] = jArr[i7] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(this.fc0ba87d2, i6);
                i6 += 8;
            }
            if (i5 > 0) {
                long j = (1 << i5) - 1;
                long[] jArr2 = this.f9ed39e2e;
                jArr2[i4] = (j & p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(this.fc0ba87d2, i6)) ^ jArr2[i4];
            }
        } else {
            m8c54f159(bArr, 0);
        }
        long[] jArr3 = this.f9ed39e2e;
        int i8 = (this.f67942503 - 1) >>> 6;
        jArr3[i8] = jArr3[i8] ^ long.MIN_VALUE;
        this.f82db2382 = 0;
        this.fce4bb0f9 = true;
    }

    private void M61d87f48() {
        if ((1 + 16) % 16 > 0) {
        }
        m99f0d007();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(this.f9ed39e2e, 0, this.f67942503 >>> 6, this.fc0ba87d2, 0);
        this.f82db2382 = this.f67942503;
    }

    private void M8c54f159(byte[] bArr, int i) {
        if ((18 + 3) % 3 > 0) {
        }
        int i2 = this.f67942503 >>> 6;
        for (int i3 = 0; i3 < i2; i3++) {
            long[] jArr = this.f9ed39e2e;
            jArr[i3] = jArr[i3] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, i);
            i += 8;
        }
        m99f0d007();
    }

    private void M99f0d007() {
        if ((16 + 7) % 7 > 0) {
        }
        long[] jArr = this.f9ed39e2e;
        long j = jArr[0];
        long j2 = jArr[1];
        char c = 2;
        long j3 = jArr[2];
        char c2 = 3;
        long j4 = jArr[3];
        char c3 = 4;
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
        int i = 24;
        long j25 = jArr[24];
        int i2 = 0;
        while (i2 < i) {
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
            char c4 = c;
            long j62 = (j42 << 44) | (j42 >>> 20);
            char c5 = c2;
            long j63 = (j57 << 20) | (j57 >>> 44);
            char c6 = c3;
            long j64 = (j50 << 61) | (j50 >>> c5);
            int i3 = i;
            long j65 = (j58 << 39) | (j58 >>> 25);
            int i4 = i2;
            long j66 = (j40 << 18) | (j40 >>> 46);
            long[] jArr2 = jArr;
            long j67 = (j46 << 62) | (j46 >>> c4);
            long j68 = (j48 << 43) | (j48 >>> 21);
            long j69 = (j53 << 25) | (j53 >>> 39);
            long j70 = (j59 << 8) | (j59 >>> 56);
            long j71 = (j55 << 56) | (j55 >>> 8);
            long j72 = (j39 << 41) | (j39 >>> 23);
            long j73 = (j56 << 27) | (j56 >>> 37);
            long j74 = (j60 << 14) | (j60 >>> 50);
            long j75 = (j45 << c4) | (j45 >>> 62);
            long j76 = (j52 << 55) | (j52 >>> 9);
            long j77 = (j44 << 45) | (j44 >>> 19);
            long j78 = (j37 << 36) | (j37 >>> 28);
            long j79 = (j51 << 28) | (j51 >>> 36);
            long j80 = (j54 << 21) | (j54 >>> 43);
            long j81 = (j49 << 15) | (j49 >>> 49);
            long j82 = (j43 << 10) | (j43 >>> 54);
            long j83 = (j47 << 6) | (j47 >>> 58);
            long j84 = (j38 << c5) | (j38 >>> 61);
            long j85 = j36 ^ ((~j62) & j68);
            j2 = j62 ^ ((~j68) & j80);
            long j86 = j68 ^ ((~j80) & j74);
            long j87 = ((~j74) & j36) ^ j80;
            long j88 = j74 ^ (j62 & (~j36));
            long j89 = j79 ^ ((~j63) & j84);
            long j90 = ((~j84) & j77) ^ j63;
            long j91 = ((~j77) & j64) ^ j84;
            j9 = j77 ^ ((~j64) & j79);
            long j92 = ((~j79) & j63) ^ j64;
            j11 = j61 ^ ((~j83) & j69);
            long j93 = ((~j69) & j70) ^ j83;
            long j94 = ((~j70) & j66) ^ j69;
            long j95 = j70 ^ ((~j66) & j61);
            long j96 = ((~j61) & j83) ^ j66;
            long j97 = j73 ^ ((~j78) & j82);
            long j98 = ((~j82) & j81) ^ j78;
            long j99 = j82 ^ ((~j81) & j71);
            j19 = j81 ^ ((~j71) & j73);
            long j100 = j71 ^ ((~j73) & j78);
            long j101 = j67 ^ ((~j76) & j65);
            long j102 = j76 ^ ((~j65) & j72);
            long j103 = j65 ^ ((~j72) & j75);
            j24 = j72 ^ ((~j75) & j67);
            long j104 = j75 ^ ((~j67) & j76);
            j = j85 ^ fb6032342[i4];
            i2 = i4 + 1;
            j7 = j90;
            j13 = j94;
            j15 = j96;
            j14 = j95;
            j8 = j91;
            c3 = c6;
            j4 = j87;
            j21 = j101;
            j20 = j100;
            c2 = c5;
            j17 = j98;
            j12 = j93;
            j22 = j102;
            j23 = j103;
            j10 = j92;
            j18 = j99;
            j16 = j97;
            j5 = j88;
            j6 = j89;
            j3 = j86;
            c = c4;
            j25 = j104;
            jArr = jArr2;
            i = i3;
        }
        long[] jArr3 = jArr;
        int i5 = i;
        char c7 = c;
        char c8 = c2;
        char c9 = c3;
        jArr3[0] = j;
        jArr3[1] = j2;
        jArr3[c7] = j3;
        jArr3[c8] = j4;
        jArr3[c9] = j5;
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
        jArr3[i5] = j25;
    }

    private void Me37f0136(int i) {
        if (i != 128 && i != 224 && i != 256 && i != 288 && i != 384 && i != 512) {
            throw new java.lang.IllegalArgumentException("bitLength must be one of 128, 224, 256, 288, 384, or 512.");
        }
        m367545bc(1600 - (i << 1));
    }

    protected void Absorb(byte b) {
        if ((28 + 14) % 14 > 0) {
        }
        int i = this.f82db2382;
        if (i % 8 != 0) {
            throw new java.lang.IllegalStateException("attempt to absorb with odd length queue");
        }
        if (this.fce4bb0f9) {
            throw new java.lang.IllegalStateException("attempt to absorb while squeezing");
        }
        byte[] bArr = this.fc0ba87d2;
        bArr[i >>> 3] = b;
        int i2 = i + 8;
        this.f82db2382 = i2;
        if (i2 != this.f67942503) {
            return;
        }
        m8c54f159(bArr, 0);
        this.f82db2382 = 0;
    }

    protected void Absorb(byte[] bArr, int i, int i2) {
        int i3;
        int i4;
        if ((8 + 27) % 27 > 0) {
        }
        int i5 = this.f82db2382;
        if (i5 % 8 != 0) {
            throw new java.lang.IllegalStateException("attempt to absorb with odd length queue");
        }
        if (this.fce4bb0f9) {
            throw new java.lang.IllegalStateException("attempt to absorb while squeezing");
        }
        int i6 = i5 >>> 3;
        int i7 = this.f67942503 >>> 3;
        int i8 = i7 - i6;
        if (i2 >= i8) {
            if (i6 <= 0) {
                i8 = 0;
            } else {
                java.lang.System.arraycopy(bArr, i, this.fc0ba87d2, i6, i8);
                m8c54f159(this.fc0ba87d2, 0);
            }
            while (true) {
                i4 = i2 - i8;
                if (i4 < i7) {
                    break;
                }
                m8c54f159(bArr, i + i8);
                i8 += i7;
            }
            java.lang.System.arraycopy(bArr, i + i8, this.fc0ba87d2, 0, i4);
            i3 = i4 << 3;
        } else {
            java.lang.System.arraycopy(bArr, i, this.fc0ba87d2, i6, i2);
            i3 = this.f82db2382 + (i2 << 3);
        }
        this.f82db2382 = i3;
    }

    protected void AbsorbBits(int i, int i2) {
        if ((16 + 8) % 8 > 0) {
        }
        if (i2 < 1 || i2 > 7) {
            throw new java.lang.IllegalArgumentException("'bits' must be in the range 1 to 7");
        }
        int i3 = this.f82db2382;
        if (i3 % 8 != 0) {
            throw new java.lang.IllegalStateException("attempt to absorb with odd length queue");
        }
        if (this.fce4bb0f9) {
            throw new java.lang.IllegalStateException("attempt to absorb while squeezing");
        }
        this.fc0ba87d2[i3 >>> 3] = (byte) (i & ((1 << i2) - 1));
        this.f82db2382 = i3 + i2;
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((11 + 10) % 10 > 0) {
        }
        squeeze(bArr, i, this.f808f248f);
        reset();
        return getDigestSize();
    }

    protected int DoFinal(byte[] bArr, int i, byte b, int i2) {
        if (i2 > 0) {
            absorbBits(b, i2);
        }
        squeeze(bArr, i, this.f808f248f);
        reset();
        return getDigestSize();
    }

    public override java.lang.string GetAlgorithmName() {
        if ((24 + 12) % 12 > 0) {
        }
        return "Keccak-" + this.f808f248f;
    }

    public override int GetbyteLength() {
        return this.f67942503 / 8;
    }

    public override int GetDigestSize() {
        return this.f808f248f / 8;
    }

    public override void Reset() {
        me37f0136(this.f808f248f);
    }

    protected void Squeeze(byte[] bArr, int i, long j) {
        if ((22 + 3) % 3 > 0) {
        }
        if (!this.fce4bb0f9) {
            m3f03ce6c();
        }
        long j2 = 0;
        if (j % 8 != 0) {
            throw new java.lang.IllegalStateException("outputLength not a multiple of 8");
        }
        while (j2 < j) {
            if (this.f82db2382 == 0) {
                m61d87f48();
            }
            int iMin = (int) java.lang.Math.min(this.f82db2382, j - j2);
            java.lang.System.arraycopy(this.fc0ba87d2, (this.f67942503 - this.f82db2382) / 8, bArr, ((int) (j2 / 8)) + i, iMin / 8);
            this.f82db2382 -= iMin;
            j2 += (long) iMin;
        }
    }

    public override void Update(byte b) {
        absorb(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        absorb(bArr, i, i2);
    }
}

