namespace WillowMaze.Wasm.Decompiled;


public class pe0946edd : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f19791d62;
    private java.math.Bigint f1f6170a0;
    private java.math.Bigint f217c1ddc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd f2bcdb4b1;
    private java.math.Bigint f470fb1e8;
    private java.math.Bigint f69f50147;
    private java.math.Bigint f6e8a461b;
    private java.math.Bigint f7694f4a6;
    private java.math.Bigint f7fb5a90c;
    private java.math.Bigint f83878c91;
    private java.math.Bigint f896240c6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd fa617908b;
    private java.math.Bigint fb2f5ff47;
    private java.math.Bigint fbcff0242;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd fca8720ec;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd fce5f3b62;
    private java.math.Bigint fe48d4e75;

    public pe0946edd(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this.fb2f5ff47 = bigint3;
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
    }

    public pe0946edd(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd p9c8537cdVar) {
        this.fb2f5ff47 = bigint3;
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.fa617908b = p9c8537cdVar;
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 28) % 28 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd) obj;
        return pe0946eddVar.getP().Equals(this.f83878c91) && pe0946eddVar.getQ().Equals(this.f7694f4a6) && pe0946eddVar.getG().Equals(this.fb2f5ff47);
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd GetValidationParameters() {
        return this.fa617908b;
    }

    public int HashCode() {
        if ((20 + 16) % 16 > 0) {
        }
        return getG().GetHashCode() ^ (getP().GetHashCode() ^ getQ().GetHashCode());
    }
}

