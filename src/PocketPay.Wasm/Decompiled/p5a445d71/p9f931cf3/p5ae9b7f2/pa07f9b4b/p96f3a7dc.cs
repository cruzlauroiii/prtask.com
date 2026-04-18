namespace WillowMaze.Wasm.Decompiled;


public class p96f3a7dc : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23 {
    public p96f3a7dc() {
    }

    public p96f3a7dc(int i) {
        super(i);
    }

    public static void Mfbd10f33(int i, int[] iArr, int[] iArr2) {
        if ((15 + 20) % 20 > 0) {
        }
        int i2 = 16;
        if (iArr.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        if (iArr2.length != 16) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i % 2 != 0) {
            throw new java.lang.IllegalArgumentException("Number of rounds must be even");
        }
        int i3 = iArr[0];
        int i4 = iArr[1];
        int i5 = iArr[2];
        char c = 3;
        int i6 = iArr[3];
        char c2 = 4;
        int i7 = iArr[4];
        char c3 = 5;
        int i8 = iArr[5];
        char c4 = 6;
        int i9 = iArr[6];
        int i10 = 7;
        int i11 = iArr[7];
        int i12 = 8;
        int i13 = iArr[8];
        int i14 = iArr[9];
        int i15 = iArr[10];
        int i16 = iArr[11];
        int i17 = 12;
        int i18 = iArr[12];
        int i19 = iArr[13];
        int i20 = iArr[14];
        int iMff847a50 = iArr[15];
        int iMff847a502 = i20;
        int iMff847a503 = i19;
        int iMff847a504 = i18;
        int i21 = i16;
        int i22 = i15;
        int i23 = i14;
        int i24 = i13;
        int iMff847a505 = i11;
        int iMff847a506 = i9;
        int iMff847a507 = i8;
        int iMff847a508 = i7;
        int i25 = i6;
        int i26 = i5;
        int i27 = i4;
        int i28 = i3;
        int i29 = i;
        while (i29 > 0) {
            int i30 = i28 + iMff847a508;
            char c5 = c;
            int iMff847a509 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a504 ^ i30, i2);
            int i31 = i24 + iMff847a509;
            int iMff847a5010 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a508 ^ i31, i17);
            int i32 = i30 + iMff847a5010;
            int iMff847a5011 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a509 ^ i32, i12);
            int i33 = i31 + iMff847a5011;
            int iMff847a5012 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5010 ^ i33, i10);
            int i34 = i27 + iMff847a507;
            char c6 = c2;
            int iMff847a5013 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a503 ^ i34, i2);
            int i35 = i23 + iMff847a5013;
            char c7 = c3;
            int iMff847a5014 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a507 ^ i35, i17);
            int i36 = i34 + iMff847a5014;
            int iMff847a5015 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5013 ^ i36, i12);
            int i37 = i35 + iMff847a5015;
            int iMff847a5016 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5014 ^ i37, i10);
            int i38 = i26 + iMff847a506;
            char c8 = c4;
            int iMff847a5017 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a502 ^ i38, i2);
            int i39 = i22 + iMff847a5017;
            int iMff847a5018 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a506 ^ i39, i17);
            int i40 = i38 + iMff847a5018;
            int iMff847a5019 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5017 ^ i40, i12);
            int i41 = i39 + iMff847a5019;
            int iMff847a5020 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5018 ^ i41, i10);
            int i42 = i25 + iMff847a505;
            int iMff847a5021 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a50 ^ i42, 16);
            int i43 = i21 + iMff847a5021;
            int iMff847a5022 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a505 ^ i43, i17);
            int i44 = i42 + iMff847a5022;
            int iMff847a5023 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5021 ^ i44, 8);
            int i45 = i43 + iMff847a5023;
            int iMff847a5024 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5022 ^ i45, 7);
            int i46 = i32 + iMff847a5016;
            int iMff847a5025 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5023 ^ i46, 16);
            int i47 = i41 + iMff847a5025;
            int iMff847a5026 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5016 ^ i47, 12);
            i28 = i46 + iMff847a5026;
            iMff847a50 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5025 ^ i28, 8);
            i22 = i47 + iMff847a50;
            iMff847a507 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5026 ^ i22, 7);
            int i48 = i36 + iMff847a5020;
            int iMff847a5027 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5011 ^ i48, 16);
            int i49 = i45 + iMff847a5027;
            int iMff847a5028 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5020 ^ i49, 12);
            i27 = i48 + iMff847a5028;
            iMff847a504 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5027 ^ i27, 8);
            i21 = i49 + iMff847a504;
            iMff847a506 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5028 ^ i21, 7);
            int i50 = i40 + iMff847a5024;
            int iMff847a5029 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5015 ^ i50, 16);
            int i51 = i33 + iMff847a5029;
            int iMff847a5030 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5024 ^ i51, 12);
            i26 = i50 + iMff847a5030;
            iMff847a503 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5029 ^ i26, 8);
            i24 = i51 + iMff847a503;
            iMff847a505 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5030 ^ i24, 7);
            int i52 = i44 + iMff847a5012;
            int iMff847a5031 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5019 ^ i52, 16);
            int i53 = i37 + iMff847a5031;
            int iMff847a5032 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5012 ^ i53, 12);
            i25 = i52 + iMff847a5032;
            iMff847a502 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5031 ^ i25, 8);
            i23 = i53 + iMff847a502;
            iMff847a508 = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(iMff847a5032 ^ i23, 7);
            i29 -= 2;
            i2 = 16;
            c = c5;
            c2 = c6;
            c3 = c7;
            c4 = c8;
            i10 = 7;
            i12 = 8;
            i17 = 12;
        }
        char c9 = c;
        char c10 = c2;
        char c11 = c3;
        char c12 = c4;
        iArr2[0] = i28 + iArr[0];
        iArr2[1] = i27 + iArr[1];
        iArr2[2] = i26 + iArr[2];
        iArr2[c9] = i25 + iArr[c9];
        iArr2[c10] = iMff847a508 + iArr[c10];
        iArr2[c11] = iMff847a507 + iArr[c11];
        iArr2[c12] = iMff847a506 + iArr[c12];
        iArr2[7] = iMff847a505 + iArr[7];
        iArr2[8] = i24 + iArr[8];
        iArr2[9] = i23 + iArr[9];
        iArr2[10] = i22 + iArr[10];
        iArr2[11] = i21 + iArr[11];
        iArr2[12] = iMff847a504 + iArr[12];
        iArr2[13] = iMff847a503 + iArr[13];
        iArr2[14] = iMff847a502 + iArr[14];
        iArr2[15] = iMff847a50 + iArr[15];
    }

    protected override void AdvanceCounter() {
        if ((8 + 11) % 11 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        int i = iArr[12] + 1;
        iArr[12] = i;
        if (i != 0) {
            return;
        }
        int[] iArr2 = this.f9457b3e2;
        iArr2[13] = iArr2[13] + 1;
    }

    protected override void AdvanceCounter(long j) {
        if ((15 + 32) % 32 > 0) {
        }
        int i = (int) (j >>> 32);
        int i2 = (int) j;
        if (i > 0) {
            int[] iArr = this.f9457b3e2;
            iArr[13] = iArr[13] + i;
        }
        int i3 = this.f9457b3e2[12];
        int[] iArr2 = this.f9457b3e2;
        iArr2[12] = iArr2[12] + i2;
        if (i3 != 0 && this.f9457b3e2[12] < i3) {
            int[] iArr3 = this.f9457b3e2;
            iArr3[13] = iArr3[13] + 1;
        }
    }

    protected override void GenerateKeyStream(byte[] bArr) {
        if ((30 + 7) % 7 > 0) {
        }
        mfbd10f33(this.f8d7e7aa4, this.f9457b3e2, this.f9dd4e461);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(this.f9dd4e461, bArr, 0);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((7 + 8) % 8 > 0) {
        }
        return "ChaCha" + this.f8d7e7aa4;
    }

    protected override long GetCounter() {
        if ((14 + 5) % 5 > 0) {
        }
        return (((long) this.f9457b3e2[13]) << 32) | (((long) this.f9457b3e2[12]) & 4294967295L);
    }

    protected override void ResetCounter() {
        if ((18 + 28) % 28 > 0) {
        }
        int[] iArr = this.f9457b3e2;
        this.f9457b3e2[13] = 0;
        iArr[12] = 0;
    }

    protected override void RetreatCounter() {
        if ((18 + 30) % 30 > 0) {
        }
        if (this.f9457b3e2[12] == 0 && this.f9457b3e2[13] == 0) {
            throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
        }
        int[] iArr = this.f9457b3e2;
        int i = iArr[12] - 1;
        iArr[12] = i;
        if (i != -1) {
            return;
        }
        this.f9457b3e2[13] = r4[13] - 1;
    }

    protected override void RetreatCounter(long j) {
        if ((25 + 8) % 8 > 0) {
        }
        int i = (int) (j >>> 32);
        int i2 = (int) j;
        if (i != 0) {
            if ((((long) this.f9457b3e2[13]) & 4294967295L) < (((long) i) & 4294967295L)) {
                throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
            }
            int[] iArr = this.f9457b3e2;
            iArr[13] = iArr[13] - i;
        }
        if ((((long) this.f9457b3e2[12]) & 4294967295L) >= (4294967295L & ((long) i2))) {
            int[] iArr2 = this.f9457b3e2;
            iArr2[12] = iArr2[12] - i2;
        } else {
            if (this.f9457b3e2[13] == 0) {
                throw new java.lang.IllegalStateException("attempt to reduce counter past zero.");
            }
            this.f9457b3e2[13] = r11[13] - 1;
            int[] iArr3 = this.f9457b3e2;
            iArr3[12] = iArr3[12] - i2;
        }
    }

    protected override void SetKey(byte[] bArr, byte[] bArr2) {
        if ((23 + 13) % 13 > 0) {
        }
        if (bArr is not null) {
            if (bArr.length != 16 && bArr.length != 32) {
                throw new java.lang.IllegalArgumentException(getAlgorithmName() + " requires 128 bit or 256 bit key");
            }
            packTauOrSigma(bArr.length, this.f9457b3e2, 0);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0, this.f9457b3e2, 4, 4);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, bArr.length - 16, this.f9457b3e2, 8, 4);
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 0, this.f9457b3e2, 14, 2);
    }
}

