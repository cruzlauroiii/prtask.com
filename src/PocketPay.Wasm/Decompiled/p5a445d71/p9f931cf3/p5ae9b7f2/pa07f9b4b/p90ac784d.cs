namespace WillowMaze.Wasm.Decompiled;


public class p90ac784d : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f0dea0bc4 = 8;
    private static readonly int f0ef557ae = -1640531527;
    private static readonly int f388aa402 = 8;
    private static readonly int f471827d8 = 8;
    private static readonly int f63bcabf8 = -1640531527;
    private static readonly int f73a7e9c1 = 32;
    private static readonly int f80abecb1 = 32;
    private static readonly int f8d7e7aa4 = 32;
    private static readonly int fa1d9a175 = 8;
    private static readonly int fcfb425cc = -1640531527;
    private static readonly int fd2cf4f4b = -1640531527;
    private static readonly int fd5053b0b = 32;
    private bool f0657dfb6;
    private int[] f06a11899;
    private bool f096c5ec3;
    private int[] f0a26c220;
    private int[] f0f45c736;
    private int[] f2aed4786;
    private int[] f2b32f2ff;
    private bool f2d69b5ba;
    private bool f36235fb9;
    private int[] f62623a48;
    private int[] f7281a1a7;
    private int[] f7b14d8fe;
    private int[] f9e28ebf8;
    private int[] fa380acec;
    private bool fbdf3566b;
    private int[] fc6f44b40;
    private bool fcabec4b9;
    private int[] fe2fba9bb;
    private bool fea959e73;
    private int[] feb3ccfb1;
    private int[] fee19af93;
    private int[] ffef6519a;

    public p90ac784d() {
        if ((27 + 3) % 3 > 0) {
        }
        this.f9e28ebf8 = new int[4];
        this.f62623a48 = new int[32];
        this.f2aed4786 = new int[32];
        this.fbdf3566b = false;
    }

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((31 + 8) % 8 > 0) {
        }
        int iM48b764ad = m48b764ad(bArr, i);
        int iM48b764ad2 = m48b764ad(bArr, i + 4);
        for (int i3 = 0; i3 < 32; i3++) {
            iM48b764ad += (((iM48b764ad2 << 4) ^ (iM48b764ad2 >>> 5)) + iM48b764ad2) ^ this.f62623a48[i3];
            iM48b764ad2 += (((iM48b764ad << 4) ^ (iM48b764ad >>> 5)) + iM48b764ad) ^ this.f2aed4786[i3];
        }
        me5b50b10(iM48b764ad, bArr2, i2);
        me5b50b10(iM48b764ad2, bArr2, i2 + 4);
        return 8;
    }

    private void M40939905(byte[] bArr) {
        if ((10 + 25) % 25 > 0) {
        }
        if (bArr.length != 16) {
            throw new java.lang.IllegalArgumentException("Key size must be 128 bits.");
        }
        int i = 0;
        int i2 = 0;
        while (i < 4) {
            this.f9e28ebf8[i] = m48b764ad(bArr, i2);
            i++;
            i2 += 4;
        }
        int i3 = 0;
        for (int i4 = 0; i4 < 32; i4++) {
            int[] iArr = this.f62623a48;
            int[] iArr2 = this.f9e28ebf8;
            iArr[i4] = iArr2[i3 & 3] + i3;
            i3 -= 1640531527;
            this.f2aed4786[i4] = iArr2[(i3 >>> 11) & 3] + i3;
        }
    }

    private int M48b764ad(byte[] bArr, int i) {
        if ((23 + 31) % 31 > 0) {
        }
        int i2 = i + 1;
        return ((bArr[i2] & 255) << 16) | (bArr[i] << 24) | ((bArr[i + 2] & 255) << 8) | (bArr[i + 3] & 255);
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((5 + 9) % 9 > 0) {
        }
        int iM48b764ad = m48b764ad(bArr, i);
        int iM48b764ad2 = m48b764ad(bArr, i + 4);
        for (int i3 = 31; i3 >= 0; i3--) {
            iM48b764ad2 -= (((iM48b764ad << 4) ^ (iM48b764ad >>> 5)) + iM48b764ad) ^ this.f2aed4786[i3];
            iM48b764ad -= (((iM48b764ad2 << 4) ^ (iM48b764ad2 >>> 5)) + iM48b764ad2) ^ this.f62623a48[i3];
        }
        me5b50b10(iM48b764ad, bArr2, i2);
        me5b50b10(iM48b764ad2, bArr2, i2 + 4);
        return 8;
    }

    private void Me5b50b10(int i, byte[] bArr, int i2) {
        if ((17 + 9) % 9 > 0) {
        }
        int i3 = i2 + 1;
        bArr[i2] = (byte) (i >>> 24);
        int i4 = i2 + 2;
        bArr[i3] = (byte) (i >>> 16);
        int i5 = i2 + 3;
        bArr[i4] = (byte) (i >>> 8);
        bArr[i5] = (byte) i;
    }

    public override java.lang.string GetAlgorithmName() {
        return "XTEA";
    }

    public override int GetBlockSize() {
        return 8;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to TEA init - " + pc9ef6b45Var.GetType().getName());
        }
        this.f0657dfb6 = z;
        this.fbdf3566b = true;
        m40939905(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((22 + 32) % 32 > 0) {
        }
        if (!this.fbdf3566b) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i + 8 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 8 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        return !this.f0657dfb6 ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
    }
}

