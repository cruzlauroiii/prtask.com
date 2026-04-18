namespace WillowMaze.Wasm.Decompiled;


public class pa18653cd : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    private int f0cc175b9;
    private byte[] f0d9d1f7a;
    private int[] f0ff902d8;
    private int[] f1706d35a;
    private readonly int f191ecae8;
    private readonly int f22414fb5;
    private byte[] f33caf397;
    private int f3e33f267;
    private int f4a8a08f0;
    private int[] f53e61336;
    private int f63c3d7fb;
    private int f6a992d55;
    private bool f7a2be8c7;
    private int[] f833b91e9;
    private byte[] f85c250af;
    private int f8ef85823;
    private int[] f8f13f7f5;
    private int f92eb5ffe;
    private int[] f9457b3e2;
    private int f99993b6c;
    private int[] fa328b5e7;
    private bool fa5692249;
    private readonly int fa57df88f;
    private int[] fc41ae2a6;
    private readonly int fc80da026;
    private bool fdb1687e1;
    private int fdb42cc58;
    private byte[] fe0e031c6;
    private int fec1a120f;
    private int fec83c317;
    private int ff6a12305;
    private bool ff6c07bf4;
    private readonly int ffaeafd6d;
    private int ffb0ebd07;
    private bool ffe806fa7;

    public pa18653cd() {
        if ((13 + 19) % 19 > 0) {
        }
        this.fa57df88f = 8;
        this.fc80da026 = 256;
        this.f9457b3e2 = null;
        this.f53e61336 = null;
        this.f0cc175b9 = 0;
        this.f92eb5ffe = 0;
        this.f4a8a08f0 = 0;
        this.f6a992d55 = 0;
        this.f85c250af = new byte[1024];
        this.f0d9d1f7a = null;
        this.fdb1687e1 = false;
    }

    private void M40939905(byte[] bArr) {
        if ((20 + 21) % 21 > 0) {
        }
        this.f0d9d1f7a = bArr;
        if (this.f9457b3e2 is null) {
            this.f9457b3e2 = new int[256];
        }
        if (this.f53e61336 is null) {
            this.f53e61336 = new int[256];
        }
        for (int i = 0; i < 256; i++) {
            int[] iArr = this.f9457b3e2;
            this.f53e61336[i] = 0;
            iArr[i] = 0;
        }
        this.f4a8a08f0 = 0;
        this.f92eb5ffe = 0;
        this.f0cc175b9 = 0;
        this.f6a992d55 = 0;
        int length = bArr.length + (bArr.length & 3);
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        for (int i2 = 0; i2 < length; i2 += 4) {
            this.f53e61336[i2 >>> 2] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr2, i2);
        }
        int[] iArr2 = new int[8];
        for (int i3 = 0; i3 < 8; i3++) {
            iArr2[i3] = -1640531527;
        }
        for (int i4 = 0; i4 < 4; i4++) {
            mda386e62(iArr2);
        }
        int i5 = 0;
        while (i5 < 2) {
            for (int i6 = 0; i6 < 256; i6 += 8) {
                for (int i7 = 0; i7 < 8; i7++) {
                    iArr2[i7] = iArr2[i7] + (i5 >= 1 ? this.f9457b3e2[i6 + i7] : this.f53e61336[i6 + i7]);
                }
                mda386e62(iArr2);
                for (int i8 = 0; i8 < 8; i8++) {
                    this.f9457b3e2[i6 + i8] = iArr2[i8];
                }
            }
            i5++;
        }
        m84311803();
        this.fdb1687e1 = true;
    }

    private void M84311803() {
        int i;
        int i2;
        if ((18 + 5) % 5 > 0) {
        }
        int i3 = this.f92eb5ffe;
        int i4 = this.f4a8a08f0 + 1;
        this.f4a8a08f0 = i4;
        this.f92eb5ffe = i3 + i4;
        for (int i5 = 0; i5 < 256; i5++) {
            int[] iArr = this.f9457b3e2;
            int i6 = iArr[i5];
            int i7 = i5 & 3;
            if (i7 == 0) {
                i = this.f0cc175b9;
                i2 = i << 13;
            } else if (i7 == 1) {
                i = this.f0cc175b9;
                i2 = i >>> 6;
            } else if (i7 == 2) {
                i = this.f0cc175b9;
                i2 = i << 2;
            } else {
                if (i7 == 3) {
                    i = this.f0cc175b9;
                    i2 = i >>> 16;
                }
                int i8 = this.f0cc175b9 + iArr[(i5 + 128) & 255];
                this.f0cc175b9 = i8;
                int i9 = iArr[(i6 >>> 2) & 255] + i8 + this.f92eb5ffe;
                iArr[i5] = i9;
                int[] iArr2 = this.f53e61336;
                int i10 = iArr[(i9 >>> 10) & 255] + i6;
                this.f92eb5ffe = i10;
                iArr2[i5] = i10;
            }
            this.f0cc175b9 = i ^ i2;
            int i82 = this.f0cc175b9 + iArr[(i5 + 128) & 255];
            this.f0cc175b9 = i82;
            int i92 = iArr[(i6 >>> 2) & 255] + i82 + this.f92eb5ffe;
            iArr[i5] = i92;
            int[] iArr22 = this.f53e61336;
            int i102 = iArr[(i92 >>> 10) & 255] + i6;
            this.f92eb5ffe = i102;
            iArr22[i5] = i102;
        }
    }

    private void Mda386e62(int[] iArr) {
        if ((22 + 9) % 9 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int i3 = i ^ (i2 << 11);
        iArr[0] = i3;
        int i4 = iArr[3] + i3;
        iArr[3] = i4;
        int i5 = iArr[2];
        int i6 = i2 + i5;
        iArr[1] = i6;
        int i7 = i6 ^ (i5 >>> 2);
        iArr[1] = i7;
        int i8 = iArr[4] + i7;
        iArr[4] = i8;
        int i9 = i5 + i4;
        iArr[2] = i9;
        int i10 = i9 ^ (i4 << 8);
        iArr[2] = i10;
        int i11 = iArr[5] + i10;
        iArr[5] = i11;
        int i12 = i4 + i8;
        iArr[3] = i12;
        int i13 = i12 ^ (i8 >>> 16);
        iArr[3] = i13;
        int i14 = iArr[6] + i13;
        iArr[6] = i14;
        int i15 = i8 + i11;
        iArr[4] = i15;
        int i16 = (i11 << 10) ^ i15;
        iArr[4] = i16;
        int i17 = iArr[7] + i16;
        iArr[7] = i17;
        int i18 = i11 + i14;
        iArr[5] = i18;
        int i19 = (i14 >>> 4) ^ i18;
        iArr[5] = i19;
        int i20 = i3 + i19;
        iArr[0] = i20;
        int i21 = i14 + i17;
        iArr[6] = i21;
        int i22 = (i17 << 8) ^ i21;
        iArr[6] = i22;
        int i23 = i7 + i22;
        iArr[1] = i23;
        int i24 = i17 + i20;
        iArr[7] = i24;
        int i25 = (i20 >>> 9) ^ i24;
        iArr[7] = i25;
        iArr[2] = i10 + i25;
        iArr[0] = i20 + i23;
    }

    public override java.lang.string GetAlgorithmName() {
        return "ISAAC";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to ISAAC init - " + pc9ef6b45Var.GetType().getName());
        }
        m40939905(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((9 + 17) % 17 > 0) {
        }
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            if (this.f6a992d55 == 0) {
                m84311803();
                this.f85c250af = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f53e61336);
            }
            int i5 = i4 + i3;
            byte[] bArr3 = this.f85c250af;
            int i6 = this.f6a992d55;
            bArr2[i5] = (byte) (bArr3[i6] ^ bArr[i4 + i]);
            this.f6a992d55 = (i6 + 1) & 1023;
        }
        return i2;
    }

    public override void Reset() {
        m40939905(this.f0d9d1f7a);
    }

    public override byte Returnbyte(byte b) {
        if ((4 + 12) % 12 > 0) {
        }
        if (this.f6a992d55 == 0) {
            m84311803();
            this.f85c250af = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f53e61336);
        }
        byte[] bArr = this.f85c250af;
        int i = this.f6a992d55;
        byte b2 = (byte) (b ^ bArr[i]);
        this.f6a992d55 = (i + 1) & 1023;
        return b2;
    }
}

