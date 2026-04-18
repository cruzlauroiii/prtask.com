namespace WillowMaze.Wasm.Decompiled;


public class p85d5a073 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private int f123e7b43;
    private java.math.Bigint f244872a6;
    private int f2db95e8e;
    private java.math.Bigint f83878c91;
    private java.math.Bigint f83927f2e;
    private java.math.Bigint fb2f5ff47;
    private int ff9b4c685;
    private int ffae4afe7;

    public p85d5a073(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(bigint, bigint2, 0);
    }

    public p85d5a073(java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        this.fb2f5ff47 = bigint2;
        this.f83878c91 = bigint;
        this.f2db95e8e = i;
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 27) % 27 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073) obj;
        return p85d5a073Var.getP().Equals(this.f83878c91) && p85d5a073Var.getG().Equals(this.fb2f5ff47) && p85d5a073Var.getL() == this.f2db95e8e;
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public int GetL() {
        return this.f2db95e8e;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public int HashCode() {
        if ((2 + 12) % 12 > 0) {
        }
        return (getP().GetHashCode() ^ getG().GetHashCode()) + this.f2db95e8e;
    }
}

