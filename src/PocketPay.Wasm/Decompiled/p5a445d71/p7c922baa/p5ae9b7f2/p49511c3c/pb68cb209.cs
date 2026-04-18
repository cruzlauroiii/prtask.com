namespace WillowMaze.Wasm.Decompiled;


public class pb68cb209 {
    private int f29fb8879;
    private int f33d10a5e;
    private java.security.SecureRandom f6912c612;
    private int f6c218af8;
    private java.security.SecureRandom f7ddf32e1;
    private int f8cbae9ef;
    private int fea4c81d4;
    private int fef76d6f3;
    private int ff7bd60b7;

    public static java.math.Bigint[] EbiPfhpiUpwrCrQS(int i, int i2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.pd4f499a5.md1d98c2e(i, i2, secureRandom);
    }

    public static java.math.Bigint IqlvpYwPdJhlaKco(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.pd4f499a5.me9ff0a05(bigint, bigint2, secureRandom);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 GenerateParameters() {
        if ((5 + 1) % 1 > 0) {
        }
        java.math.Bigint[] bigintArrEbiPfhpiUpwrCrQS = EbiPfhpiUpwrCrQS(this.ff7bd60b7, this.f29fb8879, this.f7ddf32e1);
        java.math.Bigint bigint = bigintArrEbiPfhpiUpwrCrQS[0];
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073(bigint, iqlvpYwPdJhlaKco(bigint, bigintArrEbiPfhpiUpwrCrQS[1], this.f7ddf32e1));
    }

    public void Init(int i, int i2, java.security.SecureRandom secureRandom) {
        this.ff7bd60b7 = i;
        this.f29fb8879 = i2;
        this.f7ddf32e1 = secureRandom;
    }
}

