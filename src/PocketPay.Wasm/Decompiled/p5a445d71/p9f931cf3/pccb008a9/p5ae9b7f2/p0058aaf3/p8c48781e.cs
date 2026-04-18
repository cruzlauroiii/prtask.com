namespace WillowMaze.Wasm.Decompiled;


public class p8c48781e : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 f091bef2c;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 f15a36434;
    private byte[] f2c129c5b;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 f7e0d342f;
    private byte[] f8c469d2d;
    private byte[] fbea713fc;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 fc248e173;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 fcb1cb021;
    private byte[] ffbe14519;

    public p8c48781e(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2) {
        if ((29 + 10) % 10 > 0) {
        }
        if (pe5cfc515Var.getDigestSize() != 32) {
            throw new java.lang.IllegalArgumentException("n-digest needs to produce 32 bytes of output");
        }
        if (pe5cfc515Var2.getDigestSize() != 64) {
            throw new java.lang.IllegalArgumentException("2n-digest needs to produce 64 bytes of output");
        }
        this.f15a36434 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111(pe5cfc515Var, pe5cfc515Var2);
    }

    static void M749dcc1b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2, int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4, byte[] bArr3, byte[] bArr4, int i2) {
        if ((22 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a42 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4(p3b0c1477_p4e9e06a4);
        byte[] bArr5 = new byte[2048];
        byte[] bArr6 = new byte[1024];
        byte[] bArr7 = new byte[68608];
        long j = 0;
        p3b0c1477_p4e9e06a42.f0aae9c6b = 0L;
        while (p3b0c1477_p4e9e06a42.f0aae9c6b < 32) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.m2e50e764(paa3a1111Var, bArr6, (int) (p3b0c1477_p4e9e06a42.f0aae9c6b * 32), bArr3, p3b0c1477_p4e9e06a42);
            p3b0c1477_p4e9e06a42.f0aae9c6b++;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d p44105f8dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d();
        p3b0c1477_p4e9e06a42.f0aae9c6b = 0L;
        while (p3b0c1477_p4e9e06a42.f0aae9c6b < 32) {
            byte[] bArr8 = bArr7;
            p44105f8dVar.wots_pkgen(paa3a1111Var, bArr8, (int) (p3b0c1477_p4e9e06a42.f0aae9c6b * 2144), bArr6, (int) (p3b0c1477_p4e9e06a42.f0aae9c6b * 32), bArr4, 0);
            bArr7 = bArr8;
            p3b0c1477_p4e9e06a42.f0aae9c6b++;
        }
        while (true) {
            p3b0c1477_p4e9e06a42.f0aae9c6b = j;
            if (p3b0c1477_p4e9e06a42.f0aae9c6b >= 32) {
                break;
            }
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477.ma24479f8(paa3a1111Var, bArr5, (int) ((p3b0c1477_p4e9e06a42.f0aae9c6b * 32) + 1024), bArr7, (int) (p3b0c1477_p4e9e06a42.f0aae9c6b * 2144), bArr4, 0);
            j = p3b0c1477_p4e9e06a42.f0aae9c6b + 1;
        }
        int i3 = 0;
        for (int i4 = 32; i4 > 0; i4 >>>= 1) {
            for (int i5 = 0; i5 < i4; i5 += 2) {
                paa3a1111Var.hash_2n_n_mask(bArr5, ((i5 >>> 1) * 32) + ((i4 >>> 1) * 32), bArr5, (i4 * 32) + (i5 * 32), bArr4, (i3 + 7) * 64);
            }
            i3++;
        }
        int i6 = (int) p3b0c1477_p4e9e06a4.f0aae9c6b;
        for (int i7 = 0; i7 < i2; i7++) {
            java.lang.System.arraycopy(bArr5, ((32 >>> i7) * 32) + (((i6 >>> i7) ^ 1) * 32), bArr2, i + (i7 * 32), 32);
        }
        java.lang.System.arraycopy(bArr5, 32, bArr, 0, 32);
    }

    private void Mb1ad070c(byte[] bArr, int i, int i2) {
        if ((28 + 8) % 8 > 0) {
        }
        for (int i3 = 0; i3 != i2; i3++) {
            bArr[i + i3] = 0;
        }
    }

    static void Mfc40c7d9(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2, int i, byte[] bArr3, int i2, byte[] bArr4, int i3) {
        if ((21 + 24) % 24 > 0) {
        }
        byte[] bArr5 = new byte[64];
        if ((i & 1) == 0) {
            for (int i4 = 0; i4 < 32; i4++) {
                bArr5[i4] = bArr2[i4];
            }
            for (int i5 = 0; i5 < 32; i5++) {
                bArr5[i5 + 32] = bArr3[i2 + i5];
            }
        } else {
            for (int i6 = 0; i6 < 32; i6++) {
                bArr5[i6 + 32] = bArr2[i6];
            }
            for (int i7 = 0; i7 < 32; i7++) {
                bArr5[i7] = bArr3[i2 + i7];
            }
        }
        int i8 = i2 + 32;
        int i9 = i;
        int i10 = 0;
        while (i10 < i3 - 1) {
            int i11 = i9 >>> 1;
            if ((i11 & 1) == 0) {
                paa3a1111Var.hash_2n_n_mask(bArr5, 0, bArr5, 0, bArr4, (i10 + 7) * 64);
                for (int i12 = 0; i12 < 32; i12++) {
                    bArr5[i12 + 32] = bArr3[i8 + i12];
                }
            } else {
                paa3a1111Var.hash_2n_n_mask(bArr5, 32, bArr5, 0, bArr4, (i10 + 7) * 64);
                for (int i13 = 0; i13 < 32; i13++) {
                    bArr5[i13] = bArr3[i8 + i13];
                }
            }
            i8 += 32;
            i10++;
            i9 = i11;
        }
        paa3a1111Var.hash_2n_n_mask(bArr, 0, bArr5, 0, bArr4, (i3 + 6) * 64);
    }

    byte[] crypto_sign(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2) {
        if ((2 + 13) % 13 > 0) {
        }
        byte[] bArr3 = new byte[41000];
        byte[] bArr4 = new byte[32];
        byte[] bArr5 = new byte[64];
        long[] jArr = new long[8];
        byte[] bArr6 = new byte[32];
        byte[] bArr7 = new byte[32];
        byte[] bArr8 = new byte[1024];
        byte[] bArr9 = new byte[1088];
        for (int i = 0; i < 1088; i++) {
            bArr9[i] = bArr2[i];
        }
        java.lang.System.arraycopy(bArr9, 1056, bArr3, 40968, 32);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 messageHash = paa3a1111Var.getMessageHash();
        byte[] bArr10 = new byte[messageHash.getDigestSize()];
        messageHash.update(bArr3, 40968, 32);
        messageHash.update(bArr, 0, bArr.length);
        messageHash.doFinal(bArr10, 0);
        mb1ad070c(bArr3, 40968, 32);
        for (int i2 = 0; i2 != 8; i2++) {
            jArr[i2] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr10, i2 * 8);
        }
        long j = jArr[0] & 1152921504606846975L;
        java.lang.System.arraycopy(bArr10, 16, bArr4, 0, 32);
        java.lang.System.arraycopy(bArr4, 0, bArr3, 39912, 32);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4();
        p3b0c1477_p4e9e06a4.fc9e9a848 = 11;
        p3b0c1477_p4e9e06a4.f12f1774e = 0L;
        p3b0c1477_p4e9e06a4.f0aae9c6b = 0L;
        java.lang.System.arraycopy(bArr9, 32, bArr3, 39944, 1024);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var2 = paa3a1111Var;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477.m42339e1e(paa3a1111Var2, bArr3, 40968, 5, bArr9, p3b0c1477_p4e9e06a4, bArr3, 39944);
        byte[] bArr11 = bArr9;
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 messageHash2 = paa3a1111Var2.getMessageHash();
        messageHash2.update(bArr3, 39912, 1088);
        messageHash2.update(bArr, 0, bArr.length);
        messageHash2.doFinal(bArr5, 0);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a42 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4();
        p3b0c1477_p4e9e06a42.fc9e9a848 = 12;
        p3b0c1477_p4e9e06a42.f0aae9c6b = (int) (r19 & 31);
        p3b0c1477_p4e9e06a42.f12f1774e = j >>> 5;
        int i3 = 32;
        for (int i4 = 0; i4 < 32; i4++) {
            bArr3[i4] = bArr4[i4];
        }
        java.lang.System.arraycopy(bArr11, 32, bArr8, 0, 1024);
        int i5 = 0;
        while (i5 < 8) {
            int i6 = i5;
            bArr3[i3 + i5] = (byte) ((j >>> (i5 * 8)) & 255);
            i5 = i6 + 1;
            i3 = 32;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.m2e50e764(paa3a1111Var2, bArr7, 0, bArr11, p3b0c1477_p4e9e06a42);
        new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd8716f14();
        byte[] bArr12 = bArr8;
        byte[] bArr13 = bArr6;
        byte[] bArr14 = bArr7;
        int i7 = 0;
        int iM1f6b8626 = 40 + p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd8716f14.m1f6b8626(paa3a1111Var2, bArr3, 40, bArr13, bArr14, bArr12, bArr5);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d p44105f8dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d();
        int i8 = 0;
        while (i8 < 12) {
            p3b0c1477_p4e9e06a42.fc9e9a848 = i8;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.m2e50e764(paa3a1111Var2, bArr14, i7, bArr11, p3b0c1477_p4e9e06a42);
            byte[] bArr15 = bArr3;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var3 = paa3a1111Var2;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d p44105f8dVar2 = p44105f8dVar;
            byte[] bArr16 = bArr12;
            byte[] bArr17 = bArr14;
            byte[] bArr18 = bArr13;
            int i9 = iM1f6b8626;
            p44105f8dVar2.wots_sign(paa3a1111Var3, bArr15, i9, bArr18, bArr17, bArr16);
            byte[] bArr19 = bArr11;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a43 = p3b0c1477_p4e9e06a42;
            m749dcc1b(paa3a1111Var, bArr18, bArr15, i9 + 2144, p3b0c1477_p4e9e06a43, bArr19, bArr16, 5);
            bArr13 = bArr18;
            bArr3 = bArr15;
            iM1f6b8626 = i9 + 2304;
            p3b0c1477_p4e9e06a43.f0aae9c6b = (int) (p3b0c1477_p4e9e06a43.f12f1774e & 31);
            p3b0c1477_p4e9e06a43.f12f1774e >>>= 5;
            i8++;
            p3b0c1477_p4e9e06a42 = p3b0c1477_p4e9e06a43;
            bArr11 = bArr19;
            bArr12 = bArr16;
            bArr14 = bArr17;
            p44105f8dVar = p44105f8dVar2;
            i7 = 0;
            paa3a1111Var2 = paa3a1111Var;
        }
        mb1ad070c(bArr11, i7, 1088);
        return bArr3;
    }

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((24 + 32) % 32 > 0) {
        }
        return crypto_sign(this.f15a36434, bArr, this.ffbe14519);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!z) {
            this.ffbe14519 = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a) pc9ef6b45Var).getKeyData();
        } else if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            this.ffbe14519 = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters()).getKeyData();
        } else {
            this.ffbe14519 = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa) pc9ef6b45Var).getKeyData();
        }
    }

    bool verify(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((7 + 19) % 19 > 0) {
        }
        byte[] bArr4 = new byte[2144];
        byte[] bArr5 = new byte[32];
        byte[] bArr6 = new byte[32];
        byte[] bArr7 = new byte[41000];
        byte[] bArr8 = new byte[1056];
        if (bArr2.length != 41000) {
            throw new java.lang.IllegalArgumentException("signature wrong size");
        }
        byte[] bArr9 = new byte[64];
        for (int i = 0; i < 1056; i++) {
            bArr8[i] = bArr3[i];
        }
        byte[] bArr10 = new byte[32];
        for (int i2 = 0; i2 < 32; i2++) {
            bArr10[i2] = bArr2[i2];
        }
        java.lang.System.arraycopy(bArr2, 0, bArr7, 0, 41000);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 messageHash = paa3a1111Var.getMessageHash();
        messageHash.update(bArr10, 0, 32);
        messageHash.update(bArr8, 0, 1056);
        messageHash.update(bArr, 0, bArr.length);
        messageHash.doFinal(bArr9, 0);
        long j = 0;
        int i3 = 0;
        while (i3 < 8) {
            j ^= ((long) (bArr7[32 + i3] & 255)) << (i3 * 8);
            i3++;
        }
        new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd8716f14();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pd8716f14.mcabdc04c(paa3a1111Var, bArr6, bArr7, 40, bArr8, bArr9);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d p44105f8dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d();
        int i4 = 13352;
        int i5 = 0;
        while (i5 < 12) {
            p44105f8dVar.wots_verify(paa3a1111Var, bArr4, bArr7, i4, bArr6, bArr8);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d p44105f8dVar2 = p44105f8dVar;
            int i6 = i4;
            int i7 = i6 + 2144;
            byte[] bArr11 = bArr4;
            byte[] bArr12 = bArr5;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477.ma24479f8(paa3a1111Var, bArr12, 0, bArr11, 0, bArr8, 0);
            bArr4 = bArr11;
            byte[] bArr13 = bArr7;
            byte[] bArr14 = bArr6;
            mfc40c7d9(paa3a1111Var, bArr14, bArr12, (int) (31 & j), bArr13, i7, bArr8, 5);
            bArr7 = bArr13;
            bArr6 = bArr14;
            j >>= 5;
            i4 = i6 + 2304;
            i5++;
            bArr5 = bArr12;
            p44105f8dVar = p44105f8dVar2;
        }
        bool z = true;
        for (int i8 = 0; i8 < 32; i8++) {
            if (bArr6[i8] != bArr8[i8 + 1024]) {
                z = false;
            }
        }
        return z;
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        if ((7 + 21) % 21 > 0) {
        }
        return verify(this.f15a36434, bArr, bArr2, this.ffbe14519);
    }
}

