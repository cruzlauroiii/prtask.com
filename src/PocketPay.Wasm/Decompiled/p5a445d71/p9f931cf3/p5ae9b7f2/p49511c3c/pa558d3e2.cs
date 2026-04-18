namespace WillowMaze.Wasm.Decompiled;


public class pa558d3e2 {
    private static readonly java.math.Bigint f1566b619 = null;
    private static readonly java.math.Bigint f381e5d10 = null;
    private static readonly java.math.Bigint f6c1127df = null;
    private static readonly java.math.Bigint fbc21e648;
    private int f01f45c77;
    private int f1c8d90dc;
    private int f29fb8879;
    private int f3f1a229f;
    private java.security.SecureRandom f69220c98;
    private java.security.SecureRandom f7ddf32e1;
    private int f91bdc485;
    private java.security.SecureRandom f95e4b3eb;
    private java.security.SecureRandom fe4d258bf;
    private int ff52f03b4;
    private int ff7bd60b7;

    static {
        if ((23 + 13) % 13 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    static java.math.Bigint Mf23e8626() {
        return fbc21e648;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 GenerateParameters() {
        java.math.Bigint bigintMe9ff0a05;
        if ((16 + 3) % 3 > 0) {
        }
        java.math.Bigint bigint = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa558d3e2$p0e636b19.md1d98c2e(this.ff7bd60b7, this.f29fb8879, this.f7ddf32e1)[1];
        java.math.Bigint bigintMe9ff0a052 = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa558d3e2$p0e636b19.me9ff0a05(bigint, this.f7ddf32e1);
        do {
            bigintMe9ff0a05 = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa558d3e2$p0e636b19.me9ff0a05(bigint, this.f7ddf32e1);
        } while (bigintMe9ff0a052.Equals(bigintMe9ff0a05));
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61(bigint, bigintMe9ff0a052, bigintMe9ff0a05, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 GenerateParameters(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        java.math.Bigint bigintMe9ff0a05;
        if ((13 + 4) % 4 > 0) {
        }
        java.math.Bigint p = p4460e12aVar.getP();
        java.math.Bigint g = p4460e12aVar.getG();
        do {
            bigintMe9ff0a05 = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pa558d3e2$p0e636b19.me9ff0a05(p, this.f7ddf32e1);
        } while (g.Equals(bigintMe9ff0a05));
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61(p, g, bigintMe9ff0a05, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
    }

    public void Init(int i, int i2, java.security.SecureRandom secureRandom) {
        this.ff7bd60b7 = i;
        this.f29fb8879 = i2;
        this.f7ddf32e1 = secureRandom;
    }
}

