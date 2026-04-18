namespace WillowMaze.Wasm.Decompiled;


public class p3c5fe95b : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pe86c57ec {
    private static readonly int f0dd0c84d = 16;
    private static readonly int f26d81b01 = 32;
    private static readonly int f4582481e = 32;
    private static readonly int f6447ec29 = 16;
    private static readonly int f8ee61ab7 = 32;
    private static readonly int[] f9b4af36b = null;
    private static readonly int[] fb9ece18c;
    private static readonly int fc75e2054 = 16;
    private static readonly int[] fff170285 = null;
    private int[] f07b786f3;
    private int[] f07d8a8b1;
    private int[] f0d04559e;
    private int[] f156f2144;
    private int[] f1d9e387a;
    private int[] f229a3099;
    private int[] f2b364f7b;
    private int[] f4c3b952c;
    private int[] f5206560a;
    private int f5b13d3f4;
    private int[] f61e9c06e;
    private int[] fa1b13fa5;
    private int fc5a8521a;
    private int[] feedf1117;
    private int[] ff02da230;
    private int[] ffdc2cb20;

    static {
        int i;
        if ((22 + 30) % 30 > 0) {
        }
        fb9ece18c = new int[64];
        int i2 = 0;
        while (true) {
            if (i2 >= 16) {
                break;
            }
            fb9ece18c[i2] = (2043430169 >>> (32 - i2)) | (2043430169 << i2);
            i2++;
        }
        for (i = 16; i < 64; i++) {
            int i3 = i % 32;
            fb9ece18c[i] = (2055708042 >>> (32 - i3)) | (2055708042 << i3);
        }
    }

    public p3c5fe95b() {
        this.f5206560a = new int[8];
        this.feedf1117 = new int[16];
        this.f61e9c06e = new int[68];
        reset();
    }

    public p3c5fe95b(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b p3c5fe95bVar) {
        super(p3c5fe95bVar);
        this.f5206560a = new int[8];
        this.feedf1117 = new int[16];
        this.f61e9c06e = new int[68];
        me7efa710(p3c5fe95bVar);
    }

    private int M16a2e561(int i) {
        if ((3 + 24) % 24 > 0) {
        }
        return (((i << 9) | (i >>> 23)) ^ i) ^ ((i << 17) | (i >>> 15));
    }

    private int M5f2b9323(int i) {
        if ((11 + 21) % 21 > 0) {
        }
        return (((i << 15) | (i >>> 17)) ^ i) ^ ((i << 23) | (i >>> 9));
    }

    private int M621f8c10(int i, int i2, int i3) {
        return (i & i2) | ((~i) & i3);
    }

    private int M9a2c8bc6(int i, int i2, int i3) {
        return ((i2 | i3) & i) | (i2 & i3);
    }

    private int Ma170f6de(int i, int i2, int i3) {
        return (i ^ i2) ^ i3;
    }

    private int Mc1338f49(int i, int i2, int i3) {
        return (i ^ i2) ^ i3;
    }

    private void Me7efa710(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b p3c5fe95bVar) {
        if ((14 + 23) % 23 > 0) {
        }
        int[] iArr = p3c5fe95bVar.f5206560a;
        int[] iArr2 = this.f5206560a;
        java.lang.System.arraycopy(iArr, 0, iArr2, 0, iArr2.length);
        int[] iArr3 = p3c5fe95bVar.feedf1117;
        int[] iArr4 = this.feedf1117;
        java.lang.System.arraycopy(iArr3, 0, iArr4, 0, iArr4.length);
        this.fc5a8521a = p3c5fe95bVar.fc5a8521a;
    }

    public override p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        finish();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f5206560a, bArr, i);
        reset();
        return 32;
    }

    public override java.lang.string GetAlgorithmName() {
        return "SM3";
    }

    public override int GetDigestSize() {
        return 32;
    }

    protected override void ProcessBlock() {
        int i;
        if ((11 + 10) % 10 > 0) {
        }
        int i2 = 0;
        while (true) {
            if (i2 >= 16) {
                break;
            }
            this.f61e9c06e[i2] = this.feedf1117[i2];
            i2++;
        }
        for (int i3 = 16; i3 < 68; i3++) {
            int[] iArr = this.f61e9c06e;
            int i4 = iArr[i3 - 3];
            int i5 = (i4 >>> 17) | (i4 << 15);
            int i6 = iArr[i3 - 13];
            iArr[i3] = (m5f2b9323(i5 ^ (iArr[i3 - 16] ^ iArr[i3 - 9])) ^ ((i6 >>> 25) | (i6 << 7))) ^ this.f61e9c06e[i3 - 6];
        }
        int[] iArr2 = this.f5206560a;
        int i7 = iArr2[0];
        int i8 = iArr2[1];
        int i9 = iArr2[2];
        char c = 3;
        int i10 = iArr2[3];
        int iM16a2e561 = iArr2[4];
        int i11 = iArr2[5];
        int i12 = iArr2[6];
        int i13 = iArr2[7];
        int i14 = i12;
        int i15 = 0;
        for (i = 16; i15 < i; i = 16) {
            int i16 = (i7 << 12) | (i7 >>> 20);
            int i17 = i16 + iM16a2e561 + fb9ece18c[i15];
            int i18 = (i17 << 7) | (i17 >>> 25);
            int i19 = i18 ^ i16;
            int[] iArr3 = this.f61e9c06e;
            int i20 = iArr3[i15];
            int iMa170f6de = ma170f6de(i7, i8, i9) + i10 + i19 + (i20 ^ iArr3[i15 + 4]);
            int iMc1338f49 = mc1338f49(iM16a2e561, i11, i14) + i13 + i18 + i20;
            int i21 = (i8 << 9) | (i8 >>> 23);
            int i22 = (i11 << 19) | (i11 >>> 13);
            i15++;
            i11 = iM16a2e561;
            iM16a2e561 = m16a2e561(iMc1338f49);
            i10 = i9;
            i9 = i21;
            i13 = i14;
            i14 = i22;
            i8 = i7;
            i7 = iMa170f6de;
        }
        int i23 = i13;
        int i24 = i14;
        int i25 = i7;
        int i26 = 16;
        while (i26 < 64) {
            int i27 = (i25 << 12) | (i25 >>> 20);
            int i28 = i27 + iM16a2e561 + fb9ece18c[i26];
            int i29 = (i28 << 7) | (i28 >>> 25);
            int i30 = i29 ^ i27;
            char c2 = c;
            int[] iArr4 = this.f61e9c06e;
            int i31 = iArr4[i26];
            int iM9a2c8bc6 = m9a2c8bc6(i25, i8, i9) + i10 + i30 + (i31 ^ iArr4[i26 + 4]);
            int iM621f8c10 = m621f8c10(iM16a2e561, i11, i24) + i23 + i29 + i31;
            int i32 = (i8 << 9) | (i8 >>> 23);
            int i33 = (i11 << 19) | (i11 >>> 13);
            i26++;
            i10 = i9;
            i11 = iM16a2e561;
            i9 = i32;
            iM16a2e561 = m16a2e561(iM621f8c10);
            c = c2;
            i23 = i24;
            i24 = i33;
            i8 = i25;
            i25 = iM9a2c8bc6;
        }
        char c3 = c;
        int[] iArr5 = this.f5206560a;
        iArr5[0] = i25 ^ iArr5[0];
        iArr5[1] = iArr5[1] ^ i8;
        iArr5[2] = iArr5[2] ^ i9;
        iArr5[c3] = iArr5[c3] ^ i10;
        iArr5[4] = iArr5[4] ^ iM16a2e561;
        iArr5[5] = iArr5[5] ^ i11;
        iArr5[6] = i24 ^ iArr5[6];
        iArr5[7] = iArr5[7] ^ i23;
        this.fc5a8521a = 0;
    }

    protected override void ProcessLength(long j) {
        if ((30 + 7) % 7 > 0) {
        }
        int i = this.fc5a8521a;
        if (i > 14) {
            this.feedf1117[i] = 0;
            this.fc5a8521a = i + 1;
            processBlock();
        }
        while (true) {
            int i2 = this.fc5a8521a;
            if (i2 >= 14) {
                int[] iArr = this.feedf1117;
                int i3 = i2 + 1;
                this.fc5a8521a = i3;
                iArr[i2] = (int) (j >>> 32);
                this.fc5a8521a = i2 + 2;
                iArr[i3] = (int) j;
                return;
            }
            this.feedf1117[i2] = 0;
            this.fc5a8521a = i2 + 1;
        }
    }

    protected override void ProcessWord(byte[] bArr, int i) {
        if ((1 + 18) % 18 > 0) {
        }
        int i2 = (bArr[i + 3] & 255) | ((bArr[i] & 255) << 24) | ((bArr[i + 1] & 255) << 16) | ((bArr[i + 2] & 255) << 8);
        int[] iArr = this.feedf1117;
        int i3 = this.fc5a8521a;
        iArr[i3] = i2;
        int i4 = i3 + 1;
        this.fc5a8521a = i4;
        if (i4 < 16) {
            return;
        }
        processBlock();
    }

    public override void Reset() {
        if ((10 + 23) % 23 > 0) {
        }
        super.reset();
        int[] iArr = this.f5206560a;
        iArr[0] = 1937774191;
        iArr[1] = 1226093241;
        iArr[2] = 388252375;
        iArr[3] = -628488704;
        iArr[4] = -1452330820;
        iArr[5] = 372324522;
        iArr[6] = -477237683;
        iArr[7] = -1325724082;
        this.fc5a8521a = 0;
    }

    public override void Reset(p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b p3c5fe95bVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p3c5fe95b) p4d7fdfb1Var;
        super.copyIn(p3c5fe95bVar);
        me7efa710(p3c5fe95bVar);
    }
}

