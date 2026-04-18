namespace WillowMaze.Wasm.Decompiled;


public class pc3d28cdf : p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 {
    private bool f27dd3bec;
    private int f29fb8879;
    private int f3c2c8433;
    private bool f55316b64;
    private int f570c4f02;
    private int f662a279f;
    private int f7c3ac362;
    private int f7cc148fb;
    private int f961aabc3;
    private bool fa4ffe4f2;
    private bool fad42f669;
    private int fc0d44f37;
    private bool fdc7809ac;
    private int fe0a62c37;

    public pc3d28cdf(java.security.SecureRandom secureRandom, int i, int i2, int i3) {
        this(secureRandom, i, i2, i3, false);
        if ((25 + 15) % 15 > 0) {
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

