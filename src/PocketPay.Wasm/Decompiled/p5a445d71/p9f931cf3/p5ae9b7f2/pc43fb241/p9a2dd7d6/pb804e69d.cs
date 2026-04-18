namespace WillowMaze.Wasm.Decompiled;


public class pb804e69d {
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f1967fdd1;
    private readonly int f28a1e282;
    private readonly int f29b03cbe;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f33fc2b1d;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f5fffcb97;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f7694f4a6;
    private readonly int f7ff3b5c0;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f83878c91;
    private readonly int f8ae19c03;
    private readonly int fa1b54edd;
    private readonly int faf032e3d;
    private readonly int fba292e10;
    private readonly int fddeca761;
    private readonly int ff89ed0d1;

    public pb804e69d(int i, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, int i2) {
        if ((19 + 17) % 17 > 0) {
        }
        if (!p53a5793fVar.getCurve().Equals(p53a5793fVar2.getCurve())) {
            throw new java.lang.IllegalArgumentException("points need to be on the same curve");
        }
        this.f28a1e282 = i;
        this.f83878c91 = p53a5793fVar;
        this.f7694f4a6 = p53a5793fVar2;
        this.ff89ed0d1 = i2;
    }

    private static int M7b1a5a4d(int i) {
        int i2 = 0;
        while (true) {
            i >>= 1;
            if (i == 0) {
                return i2;
            }
            i2++;
        }
    }

    public int GetCofactor() {
        return this.ff89ed0d1;
    }

    public int GetMaxOutlen() {
        return ((this.f83878c91.getCurve().getFieldSize() - (m7b1a5a4d(this.ff89ed0d1) + 13)) / 8) * 8;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetP() {
        return this.f83878c91;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetQ() {
        return this.f7694f4a6;
    }

    public int GetSecurityStrength() {
        return this.f28a1e282;
    }

    public int GetSeedLen() {
        return this.f83878c91.getCurve().getFieldSize();
    }
}

