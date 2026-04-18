namespace WillowMaze.Wasm.Decompiled;


public class p7881436c : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private static readonly int f471827d8 = 8;
    private static readonly int f48a73da5 = 8;
    private static readonly int f63bcabf8 = -1640531527;
    private static readonly int f6a1ed1a7 = -1640531527;
    private static readonly int f70984b43 = -957401312;
    private static readonly int f88823a3f = 8;
    private static readonly int f8d7e7aa4 = 32;
    private static readonly int f99ee1a7a = -957401312;
    private static readonly int fb32ebd53 = -1640531527;
    private static readonly int fcf84e453 = -957401312;
    private static readonly int fe2cbbf7e = -957401312;
    private static readonly int ff1d8269c = 32;
    private int f00b80876;
    private int f02fa55a5;
    private bool f0657dfb6;
    private int f14a99b22;
    private int f23dae1c2;
    private bool f56d1a697;
    private int f5c855e09;
    private bool f5d3cc319;
    private bool f6bc6081f;
    private int f6bc94756;
    private int f762d49f8;
    private int f78611330;
    private bool f89738724;
    private int f99450383;
    private int fa64e543d;
    private bool fbdf3566b = false;
    private int fbe06a308;
    private int fc716fb29;
    private bool fd16531b4;
    private int fd273a0ac;
    private int fd3ad73a4;
    private int fd638002e;
    private int fd6739961;
    private bool feaed885d;
    private int fef5d165a;

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((22 + 4) % 4 > 0) {
        }
        int iM48b764ad = m48b764ad(bArr, i);
        int iM48b764ad2 = m48b764ad(bArr, i + 4);
        int i3 = iM48b764ad;
        int i4 = 0;
        for (int i5 = 0; i5 != 32; i5++) {
            i4 -= 1640531527;
            i3 += (((iM48b764ad2 << 4) + this.f5c855e09) ^ (iM48b764ad2 + i4)) ^ ((iM48b764ad2 >>> 5) + this.fc716fb29);
            iM48b764ad2 += (((i3 << 4) + this.fd3ad73a4) ^ (i3 + i4)) ^ ((i3 >>> 5) + this.f6bc94756);
        }
        me5b50b10(i3, bArr2, i2);
        me5b50b10(iM48b764ad2, bArr2, i2 + 4);
        return 8;
    }

    private void M40939905(byte[] bArr) {
        if ((1 + 25) % 25 > 0) {
        }
        if (bArr.length != 16) {
            throw new java.lang.IllegalArgumentException("Key size must be 128 bits.");
        }
        this.f5c855e09 = m48b764ad(bArr, 0);
        this.fc716fb29 = m48b764ad(bArr, 4);
        this.fd3ad73a4 = m48b764ad(bArr, 8);
        this.f6bc94756 = m48b764ad(bArr, 12);
    }

    private int M48b764ad(byte[] bArr, int i) {
        if ((2 + 11) % 11 > 0) {
        }
        int i2 = i + 1;
        return ((bArr[i2] & 255) << 16) | (bArr[i] << 24) | ((bArr[i + 2] & 255) << 8) | (bArr[i + 3] & 255);
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((6 + 26) % 26 > 0) {
        }
        int iM48b764ad = m48b764ad(bArr, i);
        int iM48b764ad2 = m48b764ad(bArr, i + 4);
        int i3 = -957401312;
        for (int i4 = 0; i4 != 32; i4++) {
            iM48b764ad2 -= (((iM48b764ad << 4) + this.fd3ad73a4) ^ (iM48b764ad + i3)) ^ ((iM48b764ad >>> 5) + this.f6bc94756);
            iM48b764ad -= (((iM48b764ad2 << 4) + this.f5c855e09) ^ (iM48b764ad2 + i3)) ^ ((iM48b764ad2 >>> 5) + this.fc716fb29);
            i3 += 1640531527;
        }
        me5b50b10(iM48b764ad, bArr2, i2);
        me5b50b10(iM48b764ad2, bArr2, i2 + 4);
        return 8;
    }

    private void Me5b50b10(int i, byte[] bArr, int i2) {
        if ((27 + 2) % 2 > 0) {
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
        return "TEA";
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
        if ((22 + 13) % 13 > 0) {
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

