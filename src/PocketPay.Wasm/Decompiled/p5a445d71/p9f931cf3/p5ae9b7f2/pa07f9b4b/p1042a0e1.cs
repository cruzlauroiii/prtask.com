namespace WillowMaze.Wasm.Decompiled;


public class p1042a0e1 : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    private int f0d3a2b3f;
    private byte[] f0f36a74d;
    private int[] f1d52cc4d;
    private int[] f23228289;
    private int f2817f701;
    private bool f34f20fe7;
    private bool f3c6630e9;
    private byte[] f3c6e0b8a;
    private int[] f40ecc087;
    private byte[] f459981d8;
    private byte[] f671ae024;
    private int[] f7694f4a6;
    private int f7f9bec28;
    private int f811b06de;
    private int[] f83878c91;
    private byte[] f8442f198;
    private byte[] fb0646cd3;
    private byte[] fcb7e52b2;
    private int[] fd4c128c6;
    private byte[] fd64b8382;
    private bool fdb1687e1;
    private int fe4db5398;
    private byte[] feca26d1e;
    private byte[] ff0b53b2d;
    private byte[] ff0ea04d7;
    private int[] ff75286b0;

    public p1042a0e1() {
        if ((25 + 7) % 7 > 0) {
        }
        this.f83878c91 = new int[1024];
        this.f7694f4a6 = new int[1024];
        this.f2817f701 = 0;
        this.fcb7e52b2 = new byte[4];
        this.f7f9bec28 = 0;
    }

    private byte M0d2146e4() {
        if ((9 + 7) % 7 > 0) {
        }
        if (this.f7f9bec28 == 0) {
            int iM2764ca9d = m2764ca9d();
            byte[] bArr = this.fcb7e52b2;
            bArr[0] = (byte) (iM2764ca9d & 255);
            bArr[1] = (byte) ((iM2764ca9d >> 8) & 255);
            bArr[2] = (byte) ((iM2764ca9d >> 16) & 255);
            bArr[3] = (byte) ((iM2764ca9d >> 24) & 255);
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i = this.f7f9bec28;
        byte b = bArr2[i];
        this.f7f9bec28 = 3 & (i + 1);
        return b;
    }

    private int M2764ca9d() {
        int i;
        int i2;
        if ((5 + 11) % 11 > 0) {
        }
        int i3 = this.f2817f701;
        int i4 = i3 & 1023;
        if (i3 >= 1024) {
            int[] iArr = this.f7694f4a6;
            int i5 = iArr[(i4 - 3) & 1023];
            int i6 = iArr[(i4 - 1023) & 1023];
            int i7 = iArr[i4];
            int iMa12752e3 = iArr[(i4 - 10) & 1023] + (ma12752e3(i6, 23) ^ ma12752e3(i5, 10));
            int[] iArr2 = this.f83878c91;
            iArr[i4] = i7 + iMa12752e3 + iArr2[(i5 ^ i6) & 1023];
            int[] iArr3 = this.f7694f4a6;
            int i8 = iArr3[(i4 - 12) & 1023];
            i = iArr2[i8 & 255] + iArr2[((i8 >> 8) & 255) + 256] + iArr2[((i8 >> 16) & 255) + 512] + iArr2[((i8 >> 24) & 255) + 768];
            i2 = iArr3[i4];
        } else {
            int[] iArr4 = this.f83878c91;
            int i9 = iArr4[(i4 - 3) & 1023];
            int i10 = iArr4[(i4 - 1023) & 1023];
            int i11 = iArr4[i4];
            int iMa12752e32 = iArr4[(i4 - 10) & 1023] + (ma12752e3(i10, 23) ^ ma12752e3(i9, 10));
            int[] iArr5 = this.f7694f4a6;
            iArr4[i4] = i11 + iMa12752e32 + iArr5[(i9 ^ i10) & 1023];
            int[] iArr6 = this.f83878c91;
            int i12 = iArr6[(i4 - 12) & 1023];
            i = iArr5[i12 & 255] + iArr5[((i12 >> 8) & 255) + 256] + iArr5[((i12 >> 16) & 255) + 512] + iArr5[((i12 >> 24) & 255) + 768];
            i2 = iArr6[i4];
        }
        int i13 = i2 ^ i;
        this.f2817f701 = (this.f2817f701 + 1) & 2047;
        return i13;
    }

    private static int Ma12752e3(int i, int i2) {
        return (i << (-i2)) | (i >>> i2);
    }

    private void Me37f0136() {
        if ((20 + 1) % 1 > 0) {
        }
        byte[] bArr = this.f3c6e0b8a;
        if (bArr.length != 32 && bArr.length != 16) {
            throw new java.lang.IllegalArgumentException("The key must be 128/256 bits long");
        }
        if (this.ff0b53b2d.length < 16) {
            throw new java.lang.IllegalArgumentException("The IV must be at least 128 bits long");
        }
        if (bArr.length != 32) {
            byte[] bArr2 = new byte[32];
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
            byte[] bArr3 = this.f3c6e0b8a;
            java.lang.System.arraycopy(bArr3, 0, bArr2, 16, bArr3.length);
            this.f3c6e0b8a = bArr2;
        }
        byte[] bArr4 = this.ff0b53b2d;
        if (bArr4.length < 32) {
            byte[] bArr5 = new byte[32];
            java.lang.System.arraycopy(bArr4, 0, bArr5, 0, bArr4.length);
            byte[] bArr6 = this.ff0b53b2d;
            java.lang.System.arraycopy(bArr6, 0, bArr5, bArr6.length, 32 - bArr6.length);
            this.ff0b53b2d = bArr5;
        }
        this.f7f9bec28 = 0;
        this.f2817f701 = 0;
        int[] iArr = new int[2560];
        for (int i = 0; i < 32; i++) {
            int i2 = i >> 2;
            iArr[i2] = iArr[i2] | ((this.f3c6e0b8a[i] & 255) << ((i & 3) * 8));
        }
        for (int i3 = 0; i3 < 32; i3++) {
            int i4 = (i3 >> 2) + 8;
            iArr[i4] = iArr[i4] | ((this.ff0b53b2d[i3] & 255) << ((i3 & 3) * 8));
        }
        for (int i5 = 16; i5 < 2560; i5++) {
            int i6 = iArr[i5 - 2];
            int i7 = iArr[i5 - 15];
            iArr[i5] = ((i6 >>> 10) ^ (ma12752e3(i6, 17) ^ ma12752e3(i6, 19))) + iArr[i5 - 7] + ((i7 >>> 3) ^ (ma12752e3(i7, 7) ^ ma12752e3(i7, 18))) + iArr[i5 - 16] + i5;
        }
        java.lang.System.arraycopy(iArr, 512, this.f83878c91, 0, 1024);
        java.lang.System.arraycopy(iArr, 1536, this.f7694f4a6, 0, 1024);
        for (int i8 = 0; i8 < 4096; i8++) {
            m2764ca9d();
        }
        this.f2817f701 = 0;
    }

    public override java.lang.string GetAlgorithmName() {
        return "HC-256";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            this.ff0b53b2d = pdd5da44eVar.getIV();
            parameters = pdd5da44eVar.getParameters();
        } else {
            this.ff0b53b2d = new byte[0];
            parameters = pc9ef6b45Var;
        }
        if (!(parameters is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("Invalid parameter passed to HC256 init - " + pc9ef6b45Var.GetType().getName());
        }
        this.f3c6e0b8a = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) parameters).getKey();
        me37f0136();
        this.fdb1687e1 = true;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((13 + 26) % 26 > 0) {
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
            bArr2[i3 + i4] = (byte) (bArr[i + i4] ^ m0d2146e4());
        }
        return i2;
    }

    public override void Reset() {
        me37f0136();
    }

    public override byte Returnbyte(byte b) {
        return (byte) (m0d2146e4() ^ b);
    }
}

