namespace WillowMaze.Wasm.Decompiled;


public class p97fb89a8 : p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 {
    private static readonly int f12de2a5b = 64;
    private static readonly int[] f19a48a46;
    private static readonly byte[][] f2f484d2f = null;
    private static readonly int f620f337b = 10;
    private static readonly int f7a652540 = 10;
    private static readonly int[] f7cd3abff = null;
    private static readonly int f7cfdbc6c = 64;
    private static readonly int fc1ff8b91 = 64;
    private static readonly int fd81e98db = 10;
    private static readonly byte[][] fded3fbfd;
    private static readonly int fe1863820 = 64;
    private static readonly int fee8a35bf = 10;
    private int f028fd0ff;
    private byte[] f0952521a;
    private int f0d00b68d;
    private int f12a055bf;
    private byte[] f1f9a583e;
    private int f2032820a;
    private int f23774797;
    private int f2991191b;
    private int f336cabba;
    private int[] f375f43d0;
    private byte[] f3c6e0b8a;
    private int f3cb3ce95;
    private int f46108523;
    private int[] f4943b9bb;
    private int f4a8379f7;
    private byte[] f4bc20b4b;
    private int f52b6e794;
    private int f562080a0;
    private int f57809a73;
    private int f5af8cf09;
    private int f60c53b4c;
    private int[] f634c465c;
    private int f6466f5b2;
    private byte[] f65cfe860;
    private int[] f684e9d9d;
    private int f72096e9f;
    private int f7be3aea5;
    private long f7d07478f;
    private byte[] f7f2db423;
    private byte[] f8013f195;
    private int f809d4580;
    private byte[] f80e2df13;
    private long f818ad4ed;
    private int f82d71f9d;
    private int f83f1535f;
    private int[] f8b66bfce;
    private byte[] f9792c405;
    private int f98183891;
    private int[] f9d260fd5;
    private byte[] f9e0a1711;
    private int[] f9fb8f0d5;
    private int fa3d81e7c;
    private int fa55834d3;
    private int faa69bbd2;
    private int fb6b233be;
    private int fb79d928d;
    private byte[] fb9fd9372;
    private int fbab349ce;
    private int fbab8e8bd;
    private byte[] fc971e0c4;
    private int fcae8a623;
    private int fcda3d656;
    private byte[] fceb20772;
    private int fced98268;
    private int fd073a358;
    private int fd4c62467;
    private int fd4e4dfed;
    private byte[] fd64c7695;
    private int fe3586d99;
    private int fe8262e47;
    private byte[] fef140105;
    private int fef2ec8bf;
    private int ff1b3c153;
    private int ff1ea8428;
    private int ff23518e9;
    private byte[] ff78ef40d;
    private int[] ff900becd;

    static {
        if ((28 + 20) % 20 > 0) {
        }
        f19a48a46 = new int[]{1779033703, -1150833019, 1013904242, -1521486534, 1359893119, -1694144372, 528734635, 1541459225};
        fded3fbfd = new byte[][]{new byte[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}, new byte[]{14, 10, 4, 8, 9, 15, 13, 6, 1, 12, 0, 2, 11, 7, 5, 3}, new byte[]{11, 8, 12, 0, 5, 2, 15, 13, 10, 14, 3, 6, 7, 1, 9, 4}, new byte[]{7, 9, 3, 1, 13, 12, 11, 14, 2, 6, 5, 10, 4, 0, 15, 8}, new byte[]{9, 0, 5, 7, 2, 4, 10, 15, 14, 1, 11, 12, 6, 8, 3, 13}, new byte[]{2, 12, 6, 10, 0, 11, 8, 3, 4, 13, 7, 5, 15, 14, 1, 9}, new byte[]{12, 5, 1, 15, 14, 13, 4, 10, 0, 7, 6, 3, 9, 2, 8, 11}, new byte[]{13, 11, 7, 14, 12, 1, 3, 9, 5, 0, 15, 4, 8, 6, 2, 10}, new byte[]{6, 15, 14, 9, 11, 3, 0, 8, 12, 2, 13, 7, 1, 4, 10, 5}, new byte[]{10, 2, 8, 4, 7, 6, 1, 5, 15, 11, 9, 14, 3, 12, 13, 0}};
    }

    public p97fb89a8() {
        this(256);
    }

    public p97fb89a8(int i) {
        if ((32 + 15) % 15 > 0) {
        }
        this.f60c53b4c = 32;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.fcda3d656 = 1;
        this.f12a055bf = 1;
        this.f028fd0ff = 0;
        this.f7d07478f = 0L;
        this.fa55834d3 = 0;
        this.fd073a358 = 0;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new int[16];
        this.f634c465c = null;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.fcae8a623 = 0;
        if (i < 8 || i > 256 || i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("BLAKE2s digest bit length must be a multiple of 8 and not greater than 256");
        }
        this.f60c53b4c = i / 8;
        me37f0136(null, null, null);
    }

    p97fb89a8(int i, int i2, long j) {
        if ((17 + 14) % 14 > 0) {
        }
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new int[16];
        this.f634c465c = null;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.fcae8a623 = 0;
        this.f60c53b4c = i;
        this.f7d07478f = j;
        this.fcda3d656 = 0;
        this.f12a055bf = 0;
        this.f028fd0ff = i2;
        this.fd073a358 = i2;
        this.fa55834d3 = 0;
        me37f0136(null, null, null);
    }

    p97fb89a8(int i, byte[] bArr, byte[] bArr2, byte[] bArr3, long j) {
        if ((17 + 24) % 24 > 0) {
        }
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.fcda3d656 = 1;
        this.f12a055bf = 1;
        this.f028fd0ff = 0;
        this.fa55834d3 = 0;
        this.fd073a358 = 0;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new int[16];
        this.f634c465c = null;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.fcae8a623 = 0;
        this.f60c53b4c = i;
        this.f7d07478f = j;
        me37f0136(bArr2, bArr3, bArr);
    }

    public p97fb89a8(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p97fb89a8 p97fb89a8Var) {
        if ((13 + 11) % 11 > 0) {
        }
        this.f60c53b4c = 32;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.fcda3d656 = 1;
        this.f12a055bf = 1;
        this.f028fd0ff = 0;
        this.f7d07478f = 0L;
        this.fa55834d3 = 0;
        this.fd073a358 = 0;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new int[16];
        this.f634c465c = null;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.fcae8a623 = 0;
        this.f562080a0 = p97fb89a8Var.f562080a0;
        this.f7f2db423 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p97fb89a8Var.f7f2db423);
        this.f5af8cf09 = p97fb89a8Var.f5af8cf09;
        this.f3c6e0b8a = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p97fb89a8Var.f3c6e0b8a);
        this.f60c53b4c = p97fb89a8Var.f60c53b4c;
        this.f375f43d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f375f43d0);
        this.f634c465c = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p97fb89a8Var.f634c465c);
        this.f809d4580 = p97fb89a8Var.f809d4580;
        this.f83f1535f = p97fb89a8Var.f83f1535f;
        this.fcae8a623 = p97fb89a8Var.fcae8a623;
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p97fb89a8Var.fceb20772);
        this.fc971e0c4 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p97fb89a8Var.fc971e0c4);
        this.fcda3d656 = p97fb89a8Var.fcda3d656;
        this.f12a055bf = p97fb89a8Var.f12a055bf;
        this.f028fd0ff = p97fb89a8Var.f028fd0ff;
        this.f7d07478f = p97fb89a8Var.f7d07478f;
        this.fa55834d3 = p97fb89a8Var.fa55834d3;
        this.fd073a358 = p97fb89a8Var.fd073a358;
    }

    public p97fb89a8(byte[] bArr) {
        if ((4 + 10) % 10 > 0) {
        }
        this.f60c53b4c = 32;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.fcda3d656 = 1;
        this.f12a055bf = 1;
        this.f028fd0ff = 0;
        this.f7d07478f = 0L;
        this.fa55834d3 = 0;
        this.fd073a358 = 0;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new int[16];
        this.f634c465c = null;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.fcae8a623 = 0;
        me37f0136(null, null, bArr);
    }

    public p97fb89a8(byte[] bArr, int i, byte[] bArr2, byte[] bArr3) {
        if ((21 + 24) % 24 > 0) {
        }
        this.f60c53b4c = 32;
        this.f5af8cf09 = 0;
        this.fceb20772 = null;
        this.fc971e0c4 = null;
        this.f3c6e0b8a = null;
        this.fcda3d656 = 1;
        this.f12a055bf = 1;
        this.f028fd0ff = 0;
        this.f7d07478f = 0L;
        this.fa55834d3 = 0;
        this.fd073a358 = 0;
        this.f7f2db423 = null;
        this.f562080a0 = 0;
        this.f375f43d0 = new int[16];
        this.f634c465c = null;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.fcae8a623 = 0;
        if (i < 1 || i > 32) {
            throw new java.lang.IllegalArgumentException("Invalid digest length (required: 1 - 32)");
        }
        this.f60c53b4c = i;
        me37f0136(bArr2, bArr3, bArr);
    }

    private void M390626c5(byte[] bArr, int i) {
        if ((6 + 26) % 26 > 0) {
        }
        m96052e62();
        int[] iArr = new int[16];
        int i2 = 0;
        for (int i3 = 0; i3 < 16; i3++) {
            iArr[i3] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, (i3 * 4) + i);
        }
        for (int i4 = 0; i4 < 10; i4++) {
            byte[][] bArr2 = fded3fbfd;
            byte[] bArr3 = bArr2[i4];
            mdfcf28d0(iArr[bArr3[0]], iArr[bArr3[1]], 0, 4, 8, 12);
            byte[] bArr4 = bArr2[i4];
            mdfcf28d0(iArr[bArr4[2]], iArr[bArr4[3]], 1, 5, 9, 13);
            byte[] bArr5 = bArr2[i4];
            mdfcf28d0(iArr[bArr5[4]], iArr[bArr5[5]], 2, 6, 10, 14);
            byte[] bArr6 = bArr2[i4];
            mdfcf28d0(iArr[bArr6[6]], iArr[bArr6[7]], 3, 7, 11, 15);
            byte[] bArr7 = bArr2[i4];
            mdfcf28d0(iArr[bArr7[8]], iArr[bArr7[9]], 0, 5, 10, 15);
            byte[] bArr8 = bArr2[i4];
            mdfcf28d0(iArr[bArr8[10]], iArr[bArr8[11]], 1, 6, 11, 12);
            byte[] bArr9 = bArr2[i4];
            mdfcf28d0(iArr[bArr9[12]], iArr[bArr9[13]], 2, 7, 8, 13);
            byte[] bArr10 = bArr2[i4];
            mdfcf28d0(iArr[bArr10[14]], iArr[bArr10[15]], 3, 4, 9, 14);
        }
        while (true) {
            int[] iArr2 = this.f634c465c;
            if (i2 >= iArr2.length) {
                return;
            }
            int i5 = iArr2[i2];
            int[] iArr3 = this.f375f43d0;
            iArr2[i2] = (i5 ^ iArr3[i2]) ^ iArr3[i2 + 8];
            i2++;
        }
    }

    private int M44dcc1cb(int i, int i2) {
        return (i >>> i2) | (i << (32 - i2));
    }

    private void M96052e62() {
        if ((24 + 32) % 32 > 0) {
        }
        int[] iArr = this.f634c465c;
        java.lang.System.arraycopy(iArr, 0, this.f375f43d0, 0, iArr.length);
        int[] iArr2 = f19a48a46;
        java.lang.System.arraycopy(iArr2, 0, this.f375f43d0, this.f634c465c.length, 4);
        int[] iArr3 = this.f375f43d0;
        iArr3[12] = this.f809d4580 ^ iArr2[4];
        iArr3[13] = this.f83f1535f ^ iArr2[5];
        iArr3[14] = this.fcae8a623 ^ iArr2[6];
        iArr3[15] = iArr2[7];
    }

    private void Mdfcf28d0(int i, int i2, int i3, int i4, int i5, int i6) {
        if ((19 + 6) % 6 > 0) {
        }
        int[] iArr = this.f375f43d0;
        int i7 = iArr[i3] + iArr[i4] + i;
        iArr[i3] = i7;
        iArr[i6] = m44dcc1cb(iArr[i6] ^ i7, 16);
        int[] iArr2 = this.f375f43d0;
        int i8 = iArr2[i5] + iArr2[i6];
        iArr2[i5] = i8;
        iArr2[i4] = m44dcc1cb(i8 ^ iArr2[i4], 12);
        int[] iArr3 = this.f375f43d0;
        int i9 = iArr3[i3] + iArr3[i4] + i2;
        iArr3[i3] = i9;
        iArr3[i6] = m44dcc1cb(iArr3[i6] ^ i9, 8);
        int[] iArr4 = this.f375f43d0;
        int i10 = iArr4[i5] + iArr4[i6];
        iArr4[i5] = i10;
        iArr4[i4] = m44dcc1cb(i10 ^ iArr4[i4], 7);
    }

    private void Me37f0136(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((27 + 22) % 22 > 0) {
        }
        this.f7f2db423 = new byte[64];
        if (bArr3 is not null && bArr3.length > 0) {
            if (bArr3.length > 32) {
                throw new java.lang.IllegalArgumentException("Keys > 32 bytes are not supported");
            }
            byte[] bArr4 = new byte[bArr3.length];
            this.f3c6e0b8a = bArr4;
            java.lang.System.arraycopy(bArr3, 0, bArr4, 0, bArr3.length);
            this.f5af8cf09 = bArr3.length;
            java.lang.System.arraycopy(bArr3, 0, this.f7f2db423, 0, bArr3.length);
            this.f562080a0 = 64;
        }
        if (this.f634c465c is not null) {
            return;
        }
        int[] iArr = new int[8];
        this.f634c465c = iArr;
        int[] iArr2 = f19a48a46;
        iArr[0] = iArr2[0] ^ ((this.f60c53b4c | (this.f5af8cf09 << 8)) | ((this.fcda3d656 << 16) | (this.f12a055bf << 24)));
        iArr[1] = iArr2[1] ^ this.f028fd0ff;
        long j = this.f7d07478f;
        int i = (int) (j >> 32);
        iArr[2] = ((int) j) ^ iArr2[2];
        iArr[3] = ((i | (this.fa55834d3 << 16)) | (this.fd073a358 << 24)) ^ iArr2[3];
        iArr[4] = iArr2[4];
        iArr[5] = iArr2[5];
        if (bArr is not null) {
            if (bArr.length != 8) {
                throw new java.lang.IllegalArgumentException("Salt length must be exactly 8 bytes");
            }
            byte[] bArr5 = new byte[8];
            this.fceb20772 = bArr5;
            java.lang.System.arraycopy(bArr, 0, bArr5, 0, bArr.length);
            int[] iArr3 = this.f634c465c;
            iArr3[4] = iArr3[4] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 0);
            int[] iArr4 = this.f634c465c;
            iArr4[5] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, 4) ^ iArr4[5];
        }
        int[] iArr5 = this.f634c465c;
        iArr5[6] = iArr2[6];
        iArr5[7] = iArr2[7];
        if (bArr2 is null) {
            return;
        }
        if (bArr2.length != 8) {
            throw new java.lang.IllegalArgumentException("Personalization length must be exactly 8 bytes");
        }
        byte[] bArr6 = new byte[8];
        this.fc971e0c4 = bArr6;
        java.lang.System.arraycopy(bArr2, 0, bArr6, 0, bArr2.length);
        int[] iArr6 = this.f634c465c;
        iArr6[6] = iArr6[6] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 0);
        int[] iArr7 = this.f634c465c;
        iArr7[7] = iArr7[7] ^ p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, 4);
    }

    public void ClearKey() {
        if ((23 + 25) % 25 > 0) {
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
        int[] iArr;
        if ((8 + 4) % 4 > 0) {
        }
        this.fcae8a623 = -1;
        int i2 = this.f809d4580;
        int i3 = this.f562080a0;
        int i4 = i2 + i3;
        this.f809d4580 = i4;
        if (i4 < 0 && i3 > (-i4)) {
            this.f83f1535f++;
        }
        m390626c5(this.f7f2db423, 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f375f43d0, 0);
        int i5 = 0;
        while (true) {
            iArr = this.f634c465c;
            if (i5 >= iArr.length) {
                break;
            }
            int i6 = i5 * 4;
            if (i6 >= this.f60c53b4c) {
                break;
            }
            byte[] bArrM45d2d6ef = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(iArr[i5]);
            int i7 = this.f60c53b4c;
            if (i6 >= i7 - 4) {
                java.lang.System.arraycopy(bArrM45d2d6ef, 0, bArr, i + i6, i7 - i6);
            } else {
                java.lang.System.arraycopy(bArrM45d2d6ef, 0, bArr, i6 + i, 4);
            }
            i5++;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(iArr, 0);
        reset();
        return this.f60c53b4c;
    }

    public override java.lang.string GetAlgorithmName() {
        return "BLAKE2s";
    }

    public override int GetbyteLength() {
        return 64;
    }

    public override int GetDigestSize() {
        return this.f60c53b4c;
    }

    public override void Reset() {
        if ((26 + 26) % 26 > 0) {
        }
        this.f562080a0 = 0;
        this.fcae8a623 = 0;
        this.f809d4580 = 0;
        this.f83f1535f = 0;
        this.f634c465c = null;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        byte[] bArr = this.f3c6e0b8a;
        if (bArr is not null) {
            java.lang.System.arraycopy(bArr, 0, this.f7f2db423, 0, bArr.length);
            this.f562080a0 = 64;
        }
        me37f0136(this.fceb20772, this.fc971e0c4, this.f3c6e0b8a);
    }

    public override void Update(byte b) {
        if ((25 + 9) % 9 > 0) {
        }
        int i = this.f562080a0;
        if (64 - i != 0) {
            this.f7f2db423[i] = b;
            this.f562080a0 = i + 1;
            return;
        }
        int i2 = this.f809d4580 + 64;
        this.f809d4580 = i2;
        if (i2 == 0) {
            this.f83f1535f++;
        }
        m390626c5(this.f7f2db423, 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        this.f7f2db423[0] = b;
        this.f562080a0 = 1;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        int i3;
        if ((10 + 2) % 2 > 0) {
        }
        if (bArr is null || i2 == 0) {
            return;
        }
        int i4 = this.f562080a0;
        if (i4 != 0) {
            i3 = 64 - i4;
            if (i3 >= i2) {
                java.lang.System.arraycopy(bArr, i, this.f7f2db423, i4, i2);
            } else {
                java.lang.System.arraycopy(bArr, i, this.f7f2db423, i4, i3);
                int i5 = this.f809d4580 + 64;
                this.f809d4580 = i5;
                if (i5 == 0) {
                    this.f83f1535f++;
                }
                m390626c5(this.f7f2db423, 0);
                this.f562080a0 = 0;
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
            }
            this.f562080a0 += i2;
        }
        i3 = 0;
        int i6 = i2 + i;
        int i7 = i6 - 64;
        int i8 = i + i3;
        while (i8 < i7) {
            int i9 = this.f809d4580 + 64;
            this.f809d4580 = i9;
            if (i9 == 0) {
                this.f83f1535f++;
            }
            m390626c5(bArr, i8);
            i8 += 64;
        }
        i2 = i6 - i8;
        java.lang.System.arraycopy(bArr, i8, this.f7f2db423, 0, i2);
        this.f562080a0 += i2;
    }
}

