namespace WillowMaze.Wasm.Decompiled;


public class p65c98244 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f3b5d4106 = null;
    private static readonly java.math.Bigint f3c3f7b37 = null;
    private static readonly java.math.Bigint f4d9e8f0d = null;
    private static readonly java.math.Bigint fa45fdacd = null;
    private int f0e033f06;
    private int f0e21d54e;
    private int f1d46288b;
    private int f29fb8879;
    private java.security.SecureRandom f439dbe83;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fb506fa63;
    private java.security.SecureRandom fb8a741e6;
    private int fba716fa5;
    private java.security.SecureRandom fcf52e5b8;
    private int ff7bd60b7;

    static {
        if ((27 + 19) % 19 > 0) {
        }
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a GenerateParameters() {
        if ((30 + 32) % 32 > 0) {
        }
        java.math.Bigint[] bigintArrMd1d98c2e = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pd4f499a5.md1d98c2e(this.ff7bd60b7, this.f29fb8879, this.f7ddf32e1);
        java.math.Bigint bigint = bigintArrMd1d98c2e[0];
        java.math.Bigint bigint2 = bigintArrMd1d98c2e[1];
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pd4f499a5.me9ff0a05(bigint, bigint2, this.f7ddf32e1), bigint2, f0f82d86a, (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697) null);
    }

    public void Init(int i, int i2, java.security.SecureRandom secureRandom) {
        this.ff7bd60b7 = i;
        this.f29fb8879 = i2;
        this.f7ddf32e1 = secureRandom;
    }
}

