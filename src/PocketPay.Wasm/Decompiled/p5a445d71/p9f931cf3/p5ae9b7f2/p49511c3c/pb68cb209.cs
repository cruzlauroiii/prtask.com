namespace WillowMaze.Wasm.Decompiled;


public class pb68cb209 {
    private int f15d0b037;
    private int f29fb8879;
    private java.security.SecureRandom f2bfe6e95;
    private int f5cb37cde;
    private int f6f94ff1c;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f9751a2b5;
    private int fa0ccfe73;
    private java.security.SecureRandom faf942d0a;
    private int fbcfda59c;
    private int ff7bd60b7;

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 GenerateParameters() {
        if ((25 + 32) % 32 > 0) {
        }
        java.math.Bigint[] bigintArrMd1d98c2e = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pd4f499a5.md1d98c2e(this.ff7bd60b7, this.f29fb8879, this.f7ddf32e1);
        java.math.Bigint bigint = bigintArrMd1d98c2e[0];
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pd4f499a5.me9ff0a05(bigint, bigintArrMd1d98c2e[1], this.f7ddf32e1));
    }

    public void Init(int i, int i2, java.security.SecureRandom secureRandom) {
        this.ff7bd60b7 = i;
        this.f29fb8879 = i2;
        this.f7ddf32e1 = secureRandom;
    }
}

