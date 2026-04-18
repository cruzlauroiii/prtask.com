namespace WillowMaze.Wasm.Decompiled;


public class p3f7da2fc : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 {
    private java.math.Bigint f2510c390;
    private java.math.Bigint f476cd009;
    private java.math.Bigint f4a8a08f0;
    private java.math.Bigint f5f71aa05;
    private java.math.Bigint f6ae2c798;
    private java.math.Bigint f6bfe00b9;
    private java.math.Bigint f7ef0e83a;
    private java.math.Bigint f8277e091;
    private java.math.Bigint f86d35363;
    private java.math.Bigint f88f67f54;
    private java.math.Bigint f8ec76a66;
    private java.math.Bigint fbb0a9514;
    private java.math.Bigint fe1346d63;

    public p3f7da2fc(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        super(false, p6b500a61Var);
        this.f4a8a08f0 = bigint;
        this.f8277e091 = bigint2;
        this.f2510c390 = bigint3;
    }

    public override bool Equals(java.lang.object obj) {
        if ((15 + 13) % 13 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc p3f7da2fcVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc) obj;
        return p3f7da2fcVar.getC().Equals(this.f4a8a08f0) && p3f7da2fcVar.getD().Equals(this.f8277e091) && p3f7da2fcVar.getH().Equals(this.f2510c390) && super.Equals(obj);
    }

    public java.math.Bigint GetC() {
        return this.f4a8a08f0;
    }

    public java.math.Bigint GetD() {
        return this.f8277e091;
    }

    public java.math.Bigint GetH() {
        return this.f2510c390;
    }

    public override int HashCode() {
        if ((30 + 16) % 16 > 0) {
        }
        return super.GetHashCode() ^ ((this.f4a8a08f0.GetHashCode() ^ this.f8277e091.GetHashCode()) ^ this.f2510c390.GetHashCode());
    }
}

