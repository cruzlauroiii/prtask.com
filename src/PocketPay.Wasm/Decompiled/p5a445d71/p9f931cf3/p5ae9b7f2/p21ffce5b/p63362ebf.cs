namespace WillowMaze.Wasm.Decompiled;


public class p63362ebf : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private int f29fb8879;
    private java.math.Bigint f61560cdf;
    private int f6b7b0444;
    private java.math.Bigint f81999bdc;
    private int fe4bddd4e;

    public p63362ebf(java.math.Bigint bigint, java.security.SecureRandom secureRandom, int i, int i2) {
        super(secureRandom, i);
        if (i < 12) {
            throw new java.lang.IllegalArgumentException("key strength too small");
        }
        if (!bigint.testBit(0)) {
            throw new java.lang.IllegalArgumentException("public exponent cannot be even");
        }
        this.f81999bdc = bigint;
        this.f29fb8879 = i2;
    }

    public int GetCertainty() {
        return this.f29fb8879;
    }

    public java.math.Bigint GetPublicExponent() {
        return this.f81999bdc;
    }
}

