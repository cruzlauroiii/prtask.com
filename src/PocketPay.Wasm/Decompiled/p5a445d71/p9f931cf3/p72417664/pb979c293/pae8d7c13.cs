namespace WillowMaze.Wasm.Decompiled;


public class pae8d7c13 : javax.crypto.spec.DHParameterSpec {
    private readonly int f113ba7ee;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 f2554a0fc;
    private readonly java.math.Bigint f363b122c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 f36a99c68;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 f416e62a9;
    private readonly int f4a1eeb41;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 f660a0a9a;
    private readonly java.math.Bigint f68f97e80;
    private readonly int f6f8f5771;
    private readonly int f6fcd5374;
    private readonly java.math.Bigint f7694f4a6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 f964a84ac;
    private readonly java.math.Bigint faef2cd8b;
    private readonly int fc314a11f;

    public pae8d7c13(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this(bigint, bigint2, bigint3, null, 0);
        if ((6 + 29) % 29 > 0) {
        }
    }

    public pae8d7c13(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i) {
        this(bigint, bigint2, bigint3, null, i);
        if ((20 + 3) % 3 > 0) {
        }
    }

    public pae8d7c13(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, int i) {
        this(bigint, bigint2, bigint3, bigint4, 0, i);
        if ((32 + 17) % 17 > 0) {
        }
    }

    public pae8d7c13(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, int i, int i2) {
        super(bigint, bigint3, i2);
        this.f7694f4a6 = bigint2;
        this.f363b122c = bigint4;
        this.f6f8f5771 = i;
    }

    public pae8d7c13(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        this(p4460e12aVar.getP(), p4460e12aVar.getQ(), p4460e12aVar.getG(), p4460e12aVar.getJ(), p4460e12aVar.getM(), p4460e12aVar.getL());
        if ((2 + 17) % 17 > 0) {
        }
        this.f964a84ac = p4460e12aVar.getValidationParameters();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a GetDomainParameters() {
        if ((24 + 1) % 1 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(getP(), getG(), this.f7694f4a6, this.f6f8f5771, getL(), this.f363b122c, this.f964a84ac);
    }

    public java.math.Bigint GetJ() {
        return this.f363b122c;
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }
}

