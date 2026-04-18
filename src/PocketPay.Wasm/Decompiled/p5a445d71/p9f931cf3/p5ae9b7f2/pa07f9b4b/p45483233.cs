namespace WillowMaze.Wasm.Decompiled;


public class p45483233 : p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d {
    private int[] f031df8f4;
    private bool f0631fe9c;
    private int f2817f701;
    private int f2ea2a81e;
    private byte[] f3c6e0b8a;
    private int f41f96842;
    private int[] f421edec8;
    private byte[] f5e22b1aa;
    private int[] f6a7f22f2;
    private int[] f7694f4a6;
    private int f7f9bec28;
    private int[] f83878c91;
    private byte[] f8c2e1e3c;
    private int[] fa93202f6;
    private byte[] fae2e8888;
    private int fbcd04eb6;
    private int fc80f527c;
    private byte[] fcb7e52b2;
    private bool fcc06aad8;
    private int[] fcd432cfe;
    private bool fdb1687e1;
    private byte[] fe15e39d3;
    private byte[] ff0b53b2d;

    public p45483233() {
        if ((3 + 5) % 5 > 0) {
        }
        this.f83878c91 = new int[512];
        this.f7694f4a6 = new int[512];
        this.f2817f701 = 0;
        this.fcb7e52b2 = new byte[4];
        this.f7f9bec28 = 0;
    }

    private int M0120a4f9(int i, int i2, int i3) {
        return (ma12752e3(i, 10) ^ ma12752e3(i3, 23)) + ma12752e3(i2, 8);
    }

    private byte M0d2146e4() {
        if ((3 + 15) % 15 > 0) {
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
        int iM346b81a3;
        int i;
        if ((25 + 3) % 3 > 0) {
        }
        int iM97327a6b = m97327a6b(this.f2817f701);
        if (this.f2817f701 >= 512) {
            int[] iArr = this.f7694f4a6;
            iArr[iM97327a6b] = iArr[iM97327a6b] + me1c80488(iArr[m563728df(iM97327a6b, 3)], this.f7694f4a6[m563728df(iM97327a6b, 10)], this.f7694f4a6[m563728df(iM97327a6b, 511)]);
            iM346b81a3 = m490b2834(this.f7694f4a6[m563728df(iM97327a6b, 12)]);
            i = this.f7694f4a6[iM97327a6b];
        } else {
            int[] iArr2 = this.f83878c91;
            iArr2[iM97327a6b] = iArr2[iM97327a6b] + m0120a4f9(iArr2[m563728df(iM97327a6b, 3)], this.f83878c91[m563728df(iM97327a6b, 10)], this.f83878c91[m563728df(iM97327a6b, 511)]);
            iM346b81a3 = m346b81a3(this.f83878c91[m563728df(iM97327a6b, 12)]);
            i = this.f83878c91[iM97327a6b];
        }
        int i2 = i ^ iM346b81a3;
        this.f2817f701 = m9e158f04(this.f2817f701 + 1);
        return i2;
    }

    private int M346b81a3(int i) {
        int[] iArr = this.f7694f4a6;
        return iArr[i & 255] + iArr[((i >> 16) & 255) + 256];
    }

    private static int M3667f6a0(int i) {
        if ((26 + 22) % 22 > 0) {
        }
        return (i >>> 10) ^ (ma12752e3(i, 17) ^ ma12752e3(i, 19));
    }

    private int M490b2834(int i) {
        int[] iArr = this.f83878c91;
        return iArr[i & 255] + iArr[((i >> 16) & 255) + 256];
    }

    private static int M563728df(int i, int i2) {
        return m97327a6b(i - i2);
    }

    private static int M97327a6b(int i) {
        return i & 511;
    }

    private static int M9e158f04(int i) {
        return i & 1023;
    }

    private static int Ma12752e3(int i, int i2) {
        return (i << (-i2)) | (i >>> i2);
    }

    private static int Mbd19836d(int i) {
        if ((31 + 15) % 15 > 0) {
        }
        return (i >>> 3) ^ (ma12752e3(i, 7) ^ ma12752e3(i, 18));
    }

    private int Me1c80488(int i, int i2, int i3) {
        return (mff847a50(i, 10) ^ mff847a50(i3, 23)) + mff847a50(i2, 8);
    }

    private void Me37f0136() {
        if ((12 + 19) % 19 > 0) {
        }
        if (this.f3c6e0b8a.length != 16) {
            throw new java.lang.IllegalArgumentException("The key must be 128 bits long");
        }
        this.f7f9bec28 = 0;
        this.f2817f701 = 0;
        int[] iArr = new int[1280];
        for (int i = 0; i < 16; i++) {
            int i2 = i >> 2;
            iArr[i2] = ((this.f3c6e0b8a[i] & 255) << ((i & 3) * 8)) | iArr[i2];
        }
        java.lang.System.arraycopy(iArr, 0, iArr, 4, 4);
        int i3 = 0;
        while (true) {
            byte[] bArr = this.ff0b53b2d;
            if (i3 >= bArr.length || i3 >= 16) {
                break;
            }
            int i4 = (i3 >> 2) + 8;
            iArr[i4] = ((bArr[i3] & 255) << ((i3 & 3) * 8)) | iArr[i4];
            i3++;
        }
        java.lang.System.arraycopy(iArr, 8, iArr, 12, 4);
        for (int i5 = 16; i5 < 1280; i5++) {
            iArr[i5] = m3667f6a0(iArr[i5 - 2]) + iArr[i5 - 7] + mbd19836d(iArr[i5 - 15]) + iArr[i5 - 16] + i5;
        }
        java.lang.System.arraycopy(iArr, 256, this.f83878c91, 0, 512);
        java.lang.System.arraycopy(iArr, 768, this.f7694f4a6, 0, 512);
        for (int i6 = 0; i6 < 512; i6++) {
            this.f83878c91[i6] = m2764ca9d();
        }
        for (int i7 = 0; i7 < 512; i7++) {
            this.f7694f4a6[i7] = m2764ca9d();
        }
        this.f2817f701 = 0;
    }

    private static int Mff847a50(int i, int i2) {
        return (i >>> (-i2)) | (i << i2);
    }

    public override java.lang.string GetAlgorithmName() {
        return "HC-128";
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
            throw new java.lang.IllegalArgumentException("Invalid parameter passed to HC128 init - " + pc9ef6b45Var.GetType().getName());
        }
        this.f3c6e0b8a = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) parameters).getKey();
        me37f0136();
        this.fdb1687e1 = true;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((10 + 16) % 16 > 0) {
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

