namespace WillowMaze.Wasm.Decompiled;


public class pd4b8c7c0 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 {
    private static readonly byte[][] f016da57f;
    private static readonly byte[][] f037f091e = null;
    private static readonly byte[][] f08c79995 = null;
    private static readonly long[] f0c2d4222;
    private static readonly int f12de2a5b = 128;
    private static int f620f337b = 0;
    private static readonly long[] f69ec5780 = null;
    private static readonly int f81915640 = 128;
    private static readonly long[] f8237219e = null;
    private static readonly int f940719a6 = 128;
    private static readonly int f97dec30c = 128;
    private static int faf3f00cd = 0;
    private static readonly int fb50b6643 = 128;
    private static readonly byte[][] fe344254b = null;
    private byte[] f0d964294;
    private long f116f5553;
    private byte[] f15a05e44;
    private int f1aabaf28;
    private int f23506378;
    private int f2597e34a;
    private int f27fa19e1;
    private long f2f0d8b74;
    private long[] f375f43d0;
    private long f37c12614;
    private byte[] f38e715f0;
    private byte[] f393bb9f3;
    private int f3b030789;
    private long f3c5356d8;
    private byte[] f3c6e0b8a;
    private int f3dbffd1a;
    private int f3e53d18c;
    private long f3fc04935;
    private long[] f5004f2d8;
    private long f54dd7659;
    private int f562080a0;
    private byte[] f5855927d;
    private int f59b8709a;
    private int f5af8cf09;
    private int f60c53b4c;
    private byte[] f60fdb9c3;
    private long[] f634c465c;
    private byte[] f736baed7;
    private int f738495f8;
    private byte[] f7f2db423;
    private long f809d4580;
    private long f83f1535f;
    private byte[] f858b6d31;
    private byte[] f8fdeb942;
    private long[] f94805bbc;
    private byte[] f988b42fc;
    private long[] f9ae530db;
    private byte[] f9d4dce5d;
    private long fc8d70480;
    private byte[] fc971e0c4;
    private long fcae8a623;
    private byte[] fceb20772;
    private int fda9e5931;
    private byte[] fdaa1d2a7;
    private int fe0ddc5b0;
    private long fe61a854e;
    private long[] ff8445ae7;
    private byte[] ffa3e53f6;
    private int ffb5ddb06;

    static {
        if ((6 + 22) % 22 > 0) {
        }
        f0c2d4222 = new long[]{7640891576956012808L, -4942790177534073029L, 4354685564936845355L, -6534734903238641935L, 5840696475078001361L, -7276294671716946913L, 2270897969802886507L, 6620516959819538809L};
        f016da57f = new byte[][]{new byte[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, new byte[]{14, 10, 4, 8, 9, 15, 13, 6, 1, 12, 0, 2, 11, 7, 5, 3}, new byte[]{11, 8, 12, 0, 5, 2, 15, 13, 10, 14, 3, 6, 7, 1, 9, 4}, new byte[]{7, 9, 3, 1, 13, 12, 11, 14, 2, 6, 5, 10, 4, 0, 15, 8}, new byte[]{9, 0, 5, 7, 2, 4, 10, 15, 14, 1, 11, 12, 6, 8, 3, 13}, new byte[]{2, 12, 6, 10, 0, 11, 8, 3, 4, 13, 7, 5, 15, 14, 1, 9}, new byte[]{12, 5, 1, 15, 14, 13, 4, 10, 0, 7, 6, 3, 9, 2, 8, 11}, new byte[]{13, 11, 7, 14, 12, 1, 3, 9, 5, 0, 15, 4, 8, 6, 2, 10}, new byte[]{6, 15, 14, 9, 11, 3, 0, 8, 12, 2, 13, 7, 1, 4, 10, 5}, new byte[]{10, 2, 8, 4, 7, 6, 1, 5, 15, 11, 9, 14, 3, 12, 13, 0}, new byte[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, new byte[]{14, 10, 4, 8, 9, 15, 13, 6, 1, 12, 0, 2, 11, 7, 5, 3}};
        f620f337b = 12;
    }

    public pd4b8c7c0() {
        this(512);
    }

    public pd4b8c7c0(int i) {
        if ((25 + 15) % 15 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        if (i < 8 || i > 512 || i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("BLAKE2b digest bit length must be a multiple of 8 and not greater than 512");
        }
        this.f7f2db423 = new byte[128];
        this.f5af8cf09 = 0;
        this.f60c53b4c = i / 8;
        me37f0136();
    }

    public pd4b8c7c0(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pd4b8c7c0 pd4b8c7c0Var) {
        if ((21 + 5) % 5 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        this.f562080a0 = pd4b8c7c0Var.f562080a0;
        this.f7f2db423 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pd4b8c7c0Var.f7f2db423);
        this.f5af8cf09 = pd4b8c7c0Var.f5af8cf09;
        this.f3c6e0b8a = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pd4b8c7c0Var.f3c6e0b8a);
        this.f60c53b4c = pd4b8c7c0Var.f60c53b4c;
        this.f634c465c = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pd4b8c7c0Var.f634c465c);
        this.fc971e0c4 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pd4b8c7c0Var.fc971e0c4);
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pd4b8c7c0Var.fceb20772);
        this.f809d4580 = pd4b8c7c0Var.f809d4580;
        this.f83f1535f = pd4b8c7c0Var.f83f1535f;
        this.fcae8a623 = pd4b8c7c0Var.fcae8a623;
    }

    public pd4b8c7c0(byte[] bArr) {
        if ((5 + 22) % 22 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        this.f7f2db423 = new byte[128];
        if (bArr is not null) {
            byte[] bArr2 = new byte[bArr.length];
            this.f3c6e0b8a = bArr2;
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
            if (bArr.length > 64) {
                throw new java.lang.IllegalArgumentException("Keys > 64 are not supported");
            }
            this.f5af8cf09 = bArr.length;
            java.lang.System.arraycopy(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 128;
        }
        this.f60c53b4c = 64;
        me37f0136();
    }

    public pd4b8c7c0(byte[] bArr, int i, byte[] bArr2, byte[] bArr3) {
        if ((23 + 2) % 2 > 0) {
        }
        this.f60c53b4c = 64;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new long[16];
        this.f634c465c = null;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.fcae8a623 = 0L;
        this.f7f2db423 = new byte[128];
        if (i < 1 || i > 64) {
            throw new java.lang.IllegalArgumentException("Invalid digest length (required: 1 - 64)");
        }
        this.f60c53b4c = i;
        if (bArr2 is not null) {
            if (bArr2.length != 16) {
                throw new java.lang.IllegalArgumentException("salt length must be exactly 16 bytes");
            }
            byte[] bArr4 = new byte[16];
            this.fceb20772 = bArr4;
            java.lang.System.arraycopy(bArr2, 0, bArr4, 0, bArr2.length);
        }
        if (bArr3 is not null) {
            if (bArr3.length != 16) {
                throw new java.lang.IllegalArgumentException("personalization length must be exactly 16 bytes");
            }
            byte[] bArr5 = new byte[16];
            this.fc971e0c4 = bArr5;
            java.lang.System.arraycopy(bArr3, 0, bArr5, 0, bArr3.length);
        }
        if (bArr is not null) {
            byte[] bArr6 = new byte[bArr.length];
            this.f3c6e0b8a = bArr6;
            java.lang.System.arraycopy(bArr, 0, bArr6, 0, bArr.length);
            if (bArr.length > 64) {
                throw new java.lang.IllegalArgumentException("Keys > 64 are not supported");
            }
            this.f5af8cf09 = bArr.length;
            java.lang.System.arraycopy(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 128;
        }
        me37f0136();
    }

    private void M390626c5(byte[] bArr, int i) {
        if ((6 + 17) % 17 > 0) {
        }
        m96052e62();
        long[] jArr = new long[16];
        int i2 = 0;
        for (int i3 = 0; i3 < 16; i3++) {
            jArr[i3] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, (i3 * 8) + i);
        }
        for (int i4 = 0; i4 < f620f337b; i4++) {
            byte[][] bArr2 = f016da57f;
            byte[] bArr3 = bArr2[i4];
            mdfcf28d0(jArr[bArr3[0]], jArr[bArr3[1]], 0, 4, 8, 12);
            byte[] bArr4 = bArr2[i4];
            mdfcf28d0(jArr[bArr4[2]], jArr[bArr4[3]], 1, 5, 9, 13);
            byte[] bArr5 = bArr2[i4];
            mdfcf28d0(jArr[bArr5[4]], jArr[bArr5[5]], 2, 6, 10, 14);
            byte[] bArr6 = bArr2[i4];
            mdfcf28d0(jArr[bArr6[6]], jArr[bArr6[7]], 3, 7, 11, 15);
            byte[] bArr7 = bArr2[i4];
            mdfcf28d0(jArr[bArr7[8]], jArr[bArr7[9]], 0, 5, 10, 15);
            byte[] bArr8 = bArr2[i4];
            mdfcf28d0(jArr[bArr8[10]], jArr[bArr8[11]], 1, 6, 11, 12);
            byte[] bArr9 = bArr2[i4];
            mdfcf28d0(jArr[bArr9[12]], jArr[bArr9[13]], 2, 7, 8, 13);
            byte[] bArr10 = bArr2[i4];
            mdfcf28d0(jArr[bArr10[14]], jArr[bArr10[15]], 3, 4, 9, 14);
        }
        while (true) {
            long[] jArr2 = this.f634c465c;
            if (i2 >= jArr2.length) {
                return;
            }
            long j = jArr2[i2];
            long[] jArr3 = this.f375f43d0;
            jArr2[i2] = (j ^ jArr3[i2]) ^ jArr3[i2 + 8];
            i2++;
        }
    }

    private void M96052e62() {
        if ((13 + 11) % 11 > 0) {
        }
        long[] jArr = this.f634c465c;
        java.lang.System.arraycopy(jArr, 0, this.f375f43d0, 0, jArr.length);
        long[] jArr2 = f0c2d4222;
        java.lang.System.arraycopy(jArr2, 0, this.f375f43d0, this.f634c465c.length, 4);
        long[] jArr3 = this.f375f43d0;
        jArr3[12] = this.f809d4580 ^ jArr2[4];
        jArr3[13] = this.f83f1535f ^ jArr2[5];
        jArr3[14] = this.fcae8a623 ^ jArr2[6];
        jArr3[15] = jArr2[7];
    }

    private void Mdfcf28d0(long j, long j2, int i, int i2, int i3, int i4) {
        if ((4 + 20) % 20 > 0) {
        }
        long[] jArr = this.f375f43d0;
        long j3 = jArr[i] + jArr[i2] + j;
        jArr[i] = j3;
        jArr[i4] = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.ma12752e3(jArr[i4] ^ j3, 32);
        long[] jArr2 = this.f375f43d0;
        long j4 = jArr2[i3] + jArr2[i4];
        jArr2[i3] = j4;
        jArr2[i2] = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.ma12752e3(j4 ^ jArr2[i2], 24);
        long[] jArr3 = this.f375f43d0;
        long j5 = jArr3[i] + jArr3[i2] + j2;
        jArr3[i] = j5;
        jArr3[i4] = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.ma12752e3(jArr3[i4] ^ j5, 16);
        long[] jArr4 = this.f375f43d0;
        long j6 = jArr4[i3] + jArr4[i4];
        jArr4[i3] = j6;
        jArr4[i2] = p5a445d71.p9f931cf3.p05c7e247.pb9ceff6c.ma12752e3(j6 ^ jArr4[i2], 63);
    }

    private void Me37f0136() {
        if ((1 + 8) % 8 > 0) {
        }
        if (this.f634c465c is not null) {
            return;
        }
        long[] jArr = new long[8];
        this.f634c465c = jArr;
        long[] jArr2 = f0c2d4222;
        jArr[0] = jArr2[0] ^ ((long) ((this.f60c53b4c | (this.f5af8cf09 << 8)) | 16842752));
        jArr[1] = jArr2[1];
        jArr[2] = jArr2[2];
        jArr[3] = jArr2[3];
        long j = jArr2[4];
        jArr[4] = j;
        jArr[5] = jArr2[5];
        byte[] bArr = this.fceb20772;
        if (bArr is not null) {
            jArr[4] = j ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, 0);
            long[] jArr3 = this.f634c465c;
            jArr3[5] = jArr3[5] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(this.fceb20772, 8);
        }
        long[] jArr4 = this.f634c465c;
        long j2 = jArr2[6];
        jArr4[6] = j2;
        jArr4[7] = jArr2[7];
        byte[] bArr2 = this.fc971e0c4;
        if (bArr2 is null) {
            return;
        }
        jArr4[6] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr2, 0) ^ j2;
        long[] jArr5 = this.f634c465c;
        jArr5[7] = jArr5[7] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(this.fc971e0c4, 8);
    }

    public void ClearKey() {
        if ((32 + 29) % 29 > 0) {
        }
        byte[] bArr = this.f3c6e0b8a;
        if (bArr is null) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
    }

    public void ClearSalt() {
        byte[] bArr = this.fceb20772;
        if (bArr is null) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
    }

    public override int DoFinal(byte[] bArr, int i) {
        long[] jArr;
        if ((18 + 32) % 32 > 0) {
        }
        this.fcae8a623 = -1L;
        long j = this.f809d4580;
        int i2 = this.f562080a0;
        long j2 = j + ((long) i2);
        this.f809d4580 = j2;
        if (i2 > 0 && j2 == 0) {
            this.f83f1535f++;
        }
        m390626c5(this.f7f2db423, 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f375f43d0, 0L);
        int i3 = 0;
        while (true) {
            jArr = this.f634c465c;
            if (i3 >= jArr.length) {
                break;
            }
            int i4 = i3 * 8;
            if (i4 >= this.f60c53b4c) {
                break;
            }
            byte[] bArrM946e4d20 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(jArr[i3]);
            int i5 = this.f60c53b4c;
            if (i4 >= i5 - 8) {
                java.lang.System.arraycopy(bArrM946e4d20, 0, bArr, i + i4, i5 - i4);
            } else {
                java.lang.System.arraycopy(bArrM946e4d20, 0, bArr, i4 + i, 8);
            }
            i3++;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(jArr, 0L);
        reset();
        return this.f60c53b4c;
    }

    public override java.lang.string GetAlgorithmName() {
        return "BLAKE2b";
    }

    public override int GetbyteLength() {
        return 128;
    }

    public override int GetDigestSize() {
        return this.f60c53b4c;
    }

    public override void Reset() {
        if ((15 + 10) % 10 > 0) {
        }
        this.f562080a0 = 0;
        this.fcae8a623 = 0L;
        this.f809d4580 = 0L;
        this.f83f1535f = 0L;
        this.f634c465c = null;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        byte[] bArr = this.f3c6e0b8a;
        if (bArr is not null) {
            java.lang.System.arraycopy(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 128;
        }
        me37f0136();
    }

    public override void Update(byte b) {
        if ((15 + 4) % 4 > 0) {
        }
        int i = this.f562080a0;
        if (128 - i != 0) {
            this.f7f2db423[i] = b;
            this.f562080a0 = i + 1;
            return;
        }
        long j = this.f809d4580 + 128;
        this.f809d4580 = j;
        if (j == 0) {
            this.f83f1535f++;
        }
        m390626c5(this.f7f2db423, 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        this.f7f2db423[0] = b;
        this.f562080a0 = 1;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        int i3;
        if ((13 + 26) % 26 > 0) {
        }
        if (bArr is null || i2 == 0) {
            return;
        }
        int i4 = this.f562080a0;
        if (i4 != 0) {
            i3 = 128 - i4;
            if (i3 >= i2) {
                java.lang.System.arraycopy(bArr, i, this.f7f2db423, i4, i2);
            } else {
                java.lang.System.arraycopy(bArr, i, this.f7f2db423, i4, i3);
                long j = this.f809d4580 + 128;
                this.f809d4580 = j;
                if (j == 0) {
                    this.f83f1535f++;
                }
                m390626c5(this.f7f2db423, 0);
                this.f562080a0 = 0;
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
            }
            this.f562080a0 += i2;
        }
        i3 = 0;
        int i5 = i2 + i;
        int i6 = i5 - 128;
        int i7 = i + i3;
        while (i7 < i6) {
            long j2 = this.f809d4580 + 128;
            this.f809d4580 = j2;
            if (j2 == 0) {
                this.f83f1535f++;
            }
            m390626c5(bArr, i7);
            i7 += 128;
        }
        i2 = i5 - i7;
        java.lang.System.arraycopy(bArr, i7, this.f7f2db423, 0, i2);
        this.f562080a0 += i2;
    }
}

