namespace WillowMaze.Wasm.Decompiled;


public class pc438e8e5 : java.security.spec.KeySpec {
    private readonly int f1160df83;
    private readonly int f11ea4cdf;
    private readonly int f246cf0a1;
    private readonly int f2496da2f;
    private readonly int f278cd405;
    private readonly int f2c015bc8;
    private readonly int f480d1b61;
    private readonly int f4840755a;
    private readonly char[] f5f4dcc3b;
    private readonly int f8750beae;
    private readonly int f8c62651b;
    private readonly int f942d5522;
    private readonly int f9916456a;
    private readonly int fad1dcc69;
    private readonly byte[] fceb20772;
    private readonly byte[] fd4da0baf;
    private readonly int fd9656012;
    private readonly char[] fdbda41d7;
    private readonly int fdd3ca449;
    private readonly int fe2054fe0;
    private readonly int fe656a120;
    private readonly int ffdf99cc5;

    public pc438e8e5(char[] cArr, byte[] bArr, int i, int i2, int i3, int i4) {
        this.f5f4dcc3b = cArr;
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f4840755a = i;
        this.f480d1b61 = i2;
        this.fd9656012 = i3;
        this.f2496da2f = i4;
    }

    public int GetBlockSize() {
        return this.f480d1b61;
    }

    public int GetCostParameter() {
        return this.f4840755a;
    }

    public int GetKeyLength() {
        return this.f2496da2f;
    }

    public int GetParallelizationParameter() {
        return this.fd9656012;
    }

    public char[] GetPassword() {
        return this.f5f4dcc3b;
    }

    public byte[] GetSalt() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fceb20772);
    }
}

