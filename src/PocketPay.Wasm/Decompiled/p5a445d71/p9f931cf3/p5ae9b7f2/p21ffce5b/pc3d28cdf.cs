namespace WillowMaze.Wasm.Decompiled;


public class pc3d28cdf : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private int f29fb8879;
    private int f570c4f02;
    private int f5b239bae;
    private int f6d6479ef;
    private int f70a7254f;
    private bool f7f1877e2;
    private int f913d0f39;
    private int fa038f5b5;
    private bool fad42f669;
    private bool fc4ed8ca0;
    private int fd834cd92;
    private bool ff0331975;
    private int ffd56250d;

    public pc3d28cdf(java.security.SecureRandom secureRandom, int i, int i2, int i3) {
        this(secureRandom, i, i2, i3, false);
        if ((31 + 21) % 21 > 0) {
        }
    }

    public pc3d28cdf(java.security.SecureRandom secureRandom, int i, int i2, int i3, bool z) {
        super(secureRandom, i);
        this.fad42f669 = false;
        this.f29fb8879 = i2;
        if (i3 % 2 == 1) {
            throw new java.lang.IllegalArgumentException("cntSmallPrimes must be a multiple of 2");
        }
        if (i3 < 30) {
            throw new java.lang.IllegalArgumentException("cntSmallPrimes must be >= 30 for security reasons");
        }
        this.f570c4f02 = i3;
        this.fad42f669 = z;
    }

    public int GetCertainty() {
        return this.f29fb8879;
    }

    public int GetCntSmallPrimes() {
        return this.f570c4f02;
    }

    public bool IsDebug() {
        return this.fad42f669;
    }
}

