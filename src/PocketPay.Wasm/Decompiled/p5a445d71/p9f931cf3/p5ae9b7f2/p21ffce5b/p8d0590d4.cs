namespace WillowMaze.Wasm.Decompiled;


public class p8d0590d4 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 {
    private java.math.Bigint f4209e6b1;
    private java.math.Bigint f7bb5698b;
    private java.math.Bigint f9dd4e461;

    public p8d0590d4(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        super(true, p85d5a073Var);
        this.f9dd4e461 = bigint;
    }

    public override bool Equals(java.lang.object obj) {
        if ((1 + 18) % 18 > 0) {
        }
        if ((obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4) && ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4) obj).getX().Equals(this.f9dd4e461)) {
            return super.Equals(obj);
        }
        return false;
    }

    public java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public override int HashCode() {
        return getX().GetHashCode();
    }
}

