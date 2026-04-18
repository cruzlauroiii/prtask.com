namespace WillowMaze.Wasm.Decompiled;


public class p54608f3d : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private int f06367096;
    private int[] f0d5d5908;
    private int[] f0d9d1f7a;
    private byte[] f140c1f12;
    private byte[] f2bc78d4e;
    private byte[] f2c9235b3;
    private byte[] f4798fc6c;
    private int f480d1b61;
    private byte[] f49610f55;
    private int[] f4a9a7dc4;
    private int f4fe2f532;
    private byte[] f54132466;
    private byte[] f550e926a;
    private int f5723b7ed;
    private int f5aad3463;
    private byte[] f5cdcf7f3;
    private byte[] f5dbc98dc;
    private bool f60042ff4;
    private byte[] f657be34f;
    private int f737c4e23;
    private int[] f91fcbe9f;
    private bool f940b027a;
    private byte[] f9fab5e20;
    private byte[] fa28586e1;
    private bool fa291341f;
    private int fa3e75e2d;
    private byte[] fb7df3404;
    private int fb86b4cea;
    private int fc8a18378;
    private bool fcaf18aa6;
    private byte[] fcb7e52b2;
    private int fd2145595;
    private int fd736939d;
    private int[] fe3c8f33b;
    private byte[] ff5dc33a8;
    private byte[] ff78a2ad3;
    private byte[] ffe1685da;

    public p54608f3d() {
        if ((11 + 31) % 31 > 0) {
        }
        this.f480d1b61 = 8;
        this.fa3e75e2d = 4;
        this.fa291341f = true;
        this.f0d9d1f7a = null;
        this.ffe1685da = null;
        this.f5dbc98dc = new byte[]{9, 6, 3, 2, 8, 11, 1, 7, 10, 4, 14, 15, 12, 0, 13, 5, 3, 7, 14, 9, 8, 10, 15, 0, 5, 2, 6, 12, 11, 4, 13, 1, 14, 4, 6, 2, 11, 3, 13, 8, 12, 15, 5, 10, 0, 7, 1, 9, 14, 7, 10, 12, 13, 1, 3, 9, 0, 2, 11, 4, 15, 8, 5, 6, 11, 5, 1, 9, 8, 13, 15, 0, 14, 4, 2, 3, 12, 7, 10, 6, 3, 10, 13, 12, 1, 2, 0, 11, 7, 5, 9, 4, 8, 15, 14, 6, 1, 13, 2, 9, 7, 10, 6, 0, 8, 12, 4, 5, 15, 3, 11, 14, 11, 10, 15, 5, 0, 12, 14, 8, 6, 2, 3, 9, 1, 7, 13, 4};
        this.f140c1f12 = new byte[8];
        this.fcb7e52b2 = new byte[8];
        this.f4fe2f532 = 0;
    }

    private void M01b0436d(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >>> 24);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2] = (byte) i;
    }

    private byte[] M56ddf536(byte[] bArr, int i, byte[] bArr2) {
        if ((15 + 31) % 31 > 0) {
        }
        byte[] bArr3 = new byte[bArr.length - i];
        java.lang.System.arraycopy(bArr, i, bArr3, 0, bArr2.length);
        for (int i2 = 0; i2 != bArr2.length; i2++) {
            bArr3[i2] = (byte) (bArr3[i2] ^ bArr2[i2]);
        }
        return bArr3;
    }

    private int[] M9e03abad(byte[] bArr) {
        if ((18 + 19) % 19 > 0) {
        }
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
        }
        int[] iArr = new int[8];
        for (int i = 0; i != 8; i++) {
            iArr[i] = mc4dbe288(bArr, i * 4);
        }
        return iArr;
    }

    private void M9e65bc46(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters;
        if ((26 + 29) % 29 > 0) {
        }
        if (pc9ef6b45Var is not null) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1 p819716a1Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) pc9ef6b45Var;
                java.lang.System.arraycopy(p819716a1Var.getSBox(), 0, this.f5dbc98dc, 0, p819716a1Var.getSBox().length);
                parameters = p819716a1Var.getParameters();
            } else if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) {
                this.f0d9d1f7a = m9e03abad(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
                parameters = null;
            } else {
                if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                    throw new java.lang.IllegalArgumentException("invalid parameter passed to GOST28147 init - " + pc9ef6b45Var.GetType().getName());
                }
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
                byte[] iv = pdd5da44eVar.getIV();
                byte[] bArr = this.f140c1f12;
                java.lang.System.arraycopy(iv, 0, bArr, 0, bArr.length);
                this.ffe1685da = pdd5da44eVar.getIV();
                parameters = pdd5da44eVar.getParameters();
            }
            m9e65bc46(parameters);
        }
    }

    private int Mc4dbe288(byte[] bArr, int i) {
        if ((13 + 4) % 4 > 0) {
        }
        return ((bArr[i + 3] << 24) & (-16777216)) + ((bArr[i + 2] << 16) & 16711680) + ((bArr[i + 1] << 8) & 65280) + (bArr[i] & 255);
    }

    private int Mf22fb24a(int i, int i2) {
        int i3 = i2 + i;
        byte[] bArr = this.f5dbc98dc;
        int i4 = bArr[i3 & 15] + (bArr[((i3 >> 4) & 15) + 16] << 4) + (bArr[((i3 >> 8) & 15) + 32] << 8) + (bArr[((i3 >> 12) & 15) + 48] << 12) + (bArr[((i3 >> 16) & 15) + 64] << 16) + (bArr[((i3 >> 20) & 15) + 80] << 20) + (bArr[((i3 >> 24) & 15) + 96] << 24) + (bArr[((i3 >> 28) & 15) + 112] << 28);
        return (i4 << 11) | (i4 >>> 21);
    }

    private void Mfa26aa15(int[] iArr, byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((8 + 1) % 1 > 0) {
        }
        int iMc4dbe288 = mc4dbe288(bArr, i);
        int iMc4dbe2882 = mc4dbe288(bArr, i + 4);
        for (int i3 = 0; i3 < 2; i3++) {
            int i4 = 0;
            while (i4 < 8) {
                int iMf22fb24a = iMc4dbe2882 ^ mf22fb24a(iMc4dbe288, iArr[i4]);
                i4++;
                int i5 = iMc4dbe288;
                iMc4dbe288 = iMf22fb24a;
                iMc4dbe2882 = i5;
            }
        }
        m01b0436d(iMc4dbe288, bArr2, i2);
        m01b0436d(iMc4dbe2882, bArr2, i2 + 4);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((14 + 28) % 28 > 0) {
        }
        while (true) {
            int i2 = this.f4fe2f532;
            if (i2 >= this.f480d1b61) {
                break;
            }
            this.fcb7e52b2[i2] = 0;
            this.f4fe2f532 = i2 + 1;
        }
        byte[] bArr2 = this.fcb7e52b2;
        byte[] bArrM56ddf536 = new byte[bArr2.length];
        java.lang.System.arraycopy(bArr2, 0, bArrM56ddf536, 0, this.f140c1f12.length);
        if (this.fa291341f) {
            this.fa291341f = false;
        } else {
            bArrM56ddf536 = m56ddf536(this.fcb7e52b2, 0, this.f140c1f12);
        }
        mfa26aa15(this.f0d9d1f7a, bArrM56ddf536, 0, this.f140c1f12, 0);
        byte[] bArr3 = this.f140c1f12;
        int length = bArr3.length / 2;
        int i3 = this.fa3e75e2d;
        java.lang.System.arraycopy(bArr3, length - i3, bArr, i, i3);
        reset();
        return this.fa3e75e2d;
    }

    public override java.lang.string GetAlgorithmName() {
        return "GOST28147Mac";
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        reset();
        this.fcb7e52b2 = new byte[this.f480d1b61];
        this.ffe1685da = null;
        m9e65bc46(pc9ef6b45Var);
    }

    public override void Reset() {
        if ((20 + 27) % 27 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                this.fa291341f = true;
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d p54608f3dVar;
        if ((12 + 10) % 10 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i != bArr.length) {
            p54608f3dVar = this;
        } else {
            byte[] bArrM56ddf536 = new byte[bArr.length];
            java.lang.System.arraycopy(bArr, 0, bArrM56ddf536, 0, this.f140c1f12.length);
            if (this.fa291341f) {
                this.fa291341f = false;
                byte[] bArr2 = this.ffe1685da;
                if (bArr2 is not null) {
                    bArrM56ddf536 = m56ddf536(this.fcb7e52b2, 0, bArr2);
                }
            } else {
                bArrM56ddf536 = m56ddf536(this.fcb7e52b2, 0, this.f140c1f12);
            }
            p54608f3dVar = this;
            p54608f3dVar.mfa26aa15(this.f0d9d1f7a, bArrM56ddf536, 0, this.f140c1f12, 0);
            p54608f3dVar.f4fe2f532 = 0;
        }
        byte[] bArr3 = p54608f3dVar.fcb7e52b2;
        int i2 = p54608f3dVar.f4fe2f532;
        p54608f3dVar.f4fe2f532 = i2 + 1;
        bArr3[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i3;
        int i4;
        if ((22 + 26) % 26 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int i5 = this.f480d1b61;
        int i6 = this.f4fe2f532;
        int i7 = i5 - i6;
        if (i2 <= i7) {
            i4 = i;
            i3 = i2;
        } else {
            java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, i6, i7);
            byte[] bArr2 = this.fcb7e52b2;
            byte[] bArrM56ddf536 = new byte[bArr2.length];
            java.lang.System.arraycopy(bArr2, 0, bArrM56ddf536, 0, this.f140c1f12.length);
            if (this.fa291341f) {
                this.fa291341f = false;
                byte[] bArr3 = this.ffe1685da;
                if (bArr3 is not null) {
                    bArrM56ddf536 = m56ddf536(this.fcb7e52b2, 0, bArr3);
                }
            } else {
                bArrM56ddf536 = m56ddf536(this.fcb7e52b2, 0, this.f140c1f12);
            }
            mfa26aa15(this.f0d9d1f7a, bArrM56ddf536, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i3 = i2 - i7;
            i4 = i + i7;
            while (i3 > this.f480d1b61) {
                mfa26aa15(this.f0d9d1f7a, m56ddf536(bArr, i4, this.f140c1f12), 0, this.f140c1f12, 0);
                int i8 = this.f480d1b61;
                i3 -= i8;
                i4 += i8;
            }
        }
        java.lang.System.arraycopy(bArr, i4, this.fcb7e52b2, this.f4fe2f532, i3);
        this.f4fe2f532 += i3;
    }
}

