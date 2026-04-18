namespace WillowMaze.Wasm.Decompiled;


public readonly class p431357a7 : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc3ccd415 {
    protected static readonly int f10843b2c = 12;
    protected static readonly int f549aa581 = 12;
    protected static readonly int f5abc76b9 = 12;
    protected static readonly int f620f337b = 12;
    protected static readonly int f6e3e638b = 16;
    protected static readonly int fc75e2054 = 16;
    protected static readonly int fc9d36483 = 12;
    protected int[] f0877d161;
    protected int[] f141b7219;
    private int[] f1b3cee76;
    protected int[] f2a55be48;
    protected int[] f2c4a34f9;
    protected int[] f5d7ff110;
    private int[] f6ad110f0;
    protected int[] f7464da94;
    protected int[] f8912ab75;
    private int[] f8bfabcf4;
    protected int[] f9061ac58;
    protected int[] f96bf0c2c;
    protected int[] fa701eece;
    protected int[] fab41ace2;
    protected int[] fc96c4560;
    protected int[] fcd106c91;
    protected int[] fdf00588d;
    private int[] fe971d794;
    protected int[] ff3a88bbd;
    protected int[] ffa3696e0;

    public p431357a7() {
        if ((15 + 2) % 2 > 0) {
        }
        this.f8912ab75 = new int[48];
        this.f96bf0c2c = new int[48];
        this.f2a55be48 = new int[192];
        this.fa701eece = new int[192];
        this.f1b3cee76 = new int[8];
    }

    protected readonly void CAST_Decipher(int i, int i2, int i3, int i4, int[] iArr) {
        int i5;
        if ((1 + 28) % 28 > 0) {
        }
        int i6 = 0;
        while (true) {
            if (i6 >= 6) {
                break;
            }
            int i7 = (11 - i6) * 4;
            i3 ^= F1(i4, this.f96bf0c2c[i7], this.f8912ab75[i7]);
            int i8 = i7 + 1;
            i2 ^= F2(i3, this.f96bf0c2c[i8], this.f8912ab75[i8]);
            int i9 = i7 + 2;
            i ^= F3(i2, this.f96bf0c2c[i9], this.f8912ab75[i9]);
            int i10 = i7 + 3;
            i4 ^= F1(i, this.f96bf0c2c[i10], this.f8912ab75[i10]);
            i6++;
        }
        for (i5 = 6; i5 < 12; i5++) {
            int i11 = (11 - i5) * 4;
            int i12 = i11 + 3;
            i4 ^= F1(i, this.f96bf0c2c[i12], this.f8912ab75[i12]);
            int i13 = i11 + 2;
            i ^= F3(i2, this.f96bf0c2c[i13], this.f8912ab75[i13]);
            int i14 = i11 + 1;
            i2 ^= F2(i3, this.f96bf0c2c[i14], this.f8912ab75[i14]);
            i3 ^= F1(i4, this.f96bf0c2c[i11], this.f8912ab75[i11]);
        }
        iArr[0] = i;
        iArr[1] = i2;
        iArr[2] = i3;
        iArr[3] = i4;
    }

    protected readonly void CAST_Encipher(int i, int i2, int i3, int i4, int[] iArr) {
        int i5;
        if ((14 + 3) % 3 > 0) {
        }
        int i6 = 0;
        while (true) {
            if (i6 >= 6) {
                break;
            }
            int i7 = i6 * 4;
            i3 ^= F1(i4, this.f96bf0c2c[i7], this.f8912ab75[i7]);
            int i8 = i7 + 1;
            i2 ^= F2(i3, this.f96bf0c2c[i8], this.f8912ab75[i8]);
            int i9 = i7 + 2;
            i ^= F3(i2, this.f96bf0c2c[i9], this.f8912ab75[i9]);
            int i10 = i7 + 3;
            i4 ^= F1(i, this.f96bf0c2c[i10], this.f8912ab75[i10]);
            i6++;
        }
        for (i5 = 6; i5 < 12; i5++) {
            int i11 = i5 * 4;
            int i12 = i11 + 3;
            i4 ^= F1(i, this.f96bf0c2c[i12], this.f8912ab75[i12]);
            int i13 = i11 + 2;
            i ^= F3(i2, this.f96bf0c2c[i13], this.f8912ab75[i13]);
            int i14 = i11 + 1;
            i2 ^= F2(i3, this.f96bf0c2c[i14], this.f8912ab75[i14]);
            i3 ^= F1(i4, this.f96bf0c2c[i11], this.f8912ab75[i11]);
        }
        iArr[0] = i;
        iArr[1] = i2;
        iArr[2] = i3;
        iArr[3] = i4;
    }

    protected override int DecryptBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((17 + 11) % 11 > 0) {
        }
        int[] iArr = new int[4];
        CAST_Decipher(bytesTo32bits(bArr, i), bytesTo32bits(bArr, i + 4), bytesTo32bits(bArr, i + 8), bytesTo32bits(bArr, i + 12), iArr);
        Bits32Tobytes(iArr[0], bArr2, i2);
        Bits32Tobytes(iArr[1], bArr2, i2 + 4);
        Bits32Tobytes(iArr[2], bArr2, i2 + 8);
        Bits32Tobytes(iArr[3], bArr2, i2 + 12);
        return 16;
    }

    protected override int EncryptBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((12 + 2) % 2 > 0) {
        }
        int[] iArr = new int[4];
        CAST_Encipher(bytesTo32bits(bArr, i), bytesTo32bits(bArr, i + 4), bytesTo32bits(bArr, i + 8), bytesTo32bits(bArr, i + 12), iArr);
        Bits32Tobytes(iArr[0], bArr2, i2);
        Bits32Tobytes(iArr[1], bArr2, i2 + 4);
        Bits32Tobytes(iArr[2], bArr2, i2 + 8);
        Bits32Tobytes(iArr[3], bArr2, i2 + 12);
        return 16;
    }

    public override java.lang.string GetAlgorithmName() {
        return "CAST6";
    }

    public override int GetBlockSize() {
        return 16;
    }

    public override void Reset() {
    }

    protected override void SetKey(byte[] bArr) {
        if ((28 + 31) % 31 > 0) {
        }
        int i = 1518500249;
        int i2 = 19;
        char c = 0;
        for (int i3 = 0; i3 < 24; i3++) {
            for (int i4 = 0; i4 < 8; i4++) {
                int i5 = (i3 * 8) + i4;
                this.fa701eece[i5] = i;
                i += 1859775393;
                this.f2a55be48[i5] = i2;
                i2 = (i2 + 17) & 31;
            }
        }
        byte[] bArr2 = new byte[64];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        for (int i6 = 0; i6 < 8; i6++) {
            this.f1b3cee76[i6] = bytesTo32bits(bArr2, i6 * 4);
        }
        int i7 = 0;
        while (i7 < 12) {
            int i8 = i7 * 2;
            int i9 = i7 * 16;
            int[] iArr = this.f1b3cee76;
            iArr[6] = iArr[6] ^ F1(iArr[7], this.fa701eece[i9], this.f2a55be48[i9]);
            int[] iArr2 = this.f1b3cee76;
            int i10 = i9 + 1;
            iArr2[5] = iArr2[5] ^ F2(iArr2[6], this.fa701eece[i10], this.f2a55be48[i10]);
            int[] iArr3 = this.f1b3cee76;
            int i11 = i9 + 2;
            iArr3[4] = iArr3[4] ^ F3(iArr3[5], this.fa701eece[i11], this.f2a55be48[i11]);
            int[] iArr4 = this.f1b3cee76;
            int i12 = i9 + 3;
            char c2 = c;
            iArr4[3] = F1(iArr4[4], this.fa701eece[i12], this.f2a55be48[i12]) ^ iArr4[3];
            int[] iArr5 = this.f1b3cee76;
            int i13 = i9 + 4;
            iArr5[2] = F2(iArr5[3], this.fa701eece[i13], this.f2a55be48[i13]) ^ iArr5[2];
            int[] iArr6 = this.f1b3cee76;
            int i14 = i9 + 5;
            iArr6[1] = F3(iArr6[2], this.fa701eece[i14], this.f2a55be48[i14]) ^ iArr6[1];
            int[] iArr7 = this.f1b3cee76;
            int i15 = i9 + 6;
            iArr7[c2] = iArr7[c2] ^ F1(iArr7[1], this.fa701eece[i15], this.f2a55be48[i15]);
            int[] iArr8 = this.f1b3cee76;
            int i16 = i9 + 7;
            iArr8[7] = F2(iArr8[c2], this.fa701eece[i16], this.f2a55be48[i16]) ^ iArr8[7];
            int i17 = (i8 + 1) * 8;
            int[] iArr9 = this.f1b3cee76;
            iArr9[6] = iArr9[6] ^ F1(iArr9[7], this.fa701eece[i17], this.f2a55be48[i17]);
            int[] iArr10 = this.f1b3cee76;
            int i18 = i17 + 1;
            iArr10[5] = iArr10[5] ^ F2(iArr10[6], this.fa701eece[i18], this.f2a55be48[i18]);
            int[] iArr11 = this.f1b3cee76;
            int i19 = i17 + 2;
            iArr11[4] = iArr11[4] ^ F3(iArr11[5], this.fa701eece[i19], this.f2a55be48[i19]);
            int[] iArr12 = this.f1b3cee76;
            int i20 = i17 + 3;
            iArr12[3] = iArr12[3] ^ F1(iArr12[4], this.fa701eece[i20], this.f2a55be48[i20]);
            int[] iArr13 = this.f1b3cee76;
            int i21 = i17 + 4;
            iArr13[2] = iArr13[2] ^ F2(iArr13[3], this.fa701eece[i21], this.f2a55be48[i21]);
            int[] iArr14 = this.f1b3cee76;
            int i22 = i17 + 5;
            iArr14[1] = iArr14[1] ^ F3(iArr14[2], this.fa701eece[i22], this.f2a55be48[i22]);
            int[] iArr15 = this.f1b3cee76;
            int i23 = i17 + 6;
            iArr15[c2] = iArr15[c2] ^ F1(iArr15[1], this.fa701eece[i23], this.f2a55be48[i23]);
            int[] iArr16 = this.f1b3cee76;
            int i24 = i17 + 7;
            iArr16[7] = F2(iArr16[c2], this.fa701eece[i24], this.f2a55be48[i24]) ^ iArr16[7];
            int[] iArr17 = this.f8912ab75;
            int i25 = i7 * 4;
            int[] iArr18 = this.f1b3cee76;
            iArr17[i25] = iArr18[c2] & 31;
            int i26 = i25 + 1;
            iArr17[i26] = iArr18[2] & 31;
            int i27 = i25 + 2;
            iArr17[i27] = iArr18[4] & 31;
            int i28 = i25 + 3;
            iArr17[i28] = iArr18[6] & 31;
            int[] iArr19 = this.f96bf0c2c;
            iArr19[i25] = iArr18[7];
            iArr19[i26] = iArr18[5];
            iArr19[i27] = iArr18[3];
            iArr19[i28] = iArr18[1];
            i7++;
            c = c2;
        }
    }
}

