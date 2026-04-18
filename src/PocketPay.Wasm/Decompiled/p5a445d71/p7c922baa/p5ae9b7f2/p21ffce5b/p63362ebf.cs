namespace WillowMaze.Wasm.Decompiled;


public class p63362ebf : p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 {
    private int f185a9e58;
    private int f29fb8879;
    private java.math.Bigint f81999bdc;
    private int fa48cfdf8;
    private java.math.Bigint fbab9f7c9;
    private int fc736470c;
    private java.math.Bigint fca5044c7;

    public p63362ebf(java.math.Bigint bigint, java.security.SecureRandom secureRandom, int i, int i2) {
        super(secureRandom, i);
        if (i < 12) {
            throw new java.lang.IllegalArgumentException("key strength too small");
        }
        if (!JRoXwYNOocBOpSAE(bigint, 0)) {
            throw new java.lang.IllegalArgumentException("public exponent cannot be even");
        }
        this.f81999bdc = bigint;
        this.f29fb8879 = i2;
    }

    public static bool JRoXwYNOocBOpSAE(java.math.Bigint bigint, int i) {
        return bigint.testBit(i);
    }

    public int GetCertainty() {
        return this.f29fb8879;
    }

    public java.math.Bigint GetPublicExponent() {
        return this.f81999bdc;
    }
}

