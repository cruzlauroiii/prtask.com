namespace WillowMaze.Wasm.Decompiled;


public class p6fc6e0d0 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 {
    private java.math.Bigint f0cf8d78c;
    private java.math.Bigint f41529076;
    private java.math.Bigint f961091e8;
    private java.math.Bigint fb4b6bc4c;
    private java.math.Bigint ffba0c418;

    public p6fc6e0d0(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        super(false, p85d5a073Var);
        this.f41529076 = bigint;
    }

    public override bool Equals(java.lang.object obj) {
        if ((16 + 13) % 13 > 0) {
        }
        return (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0) && ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0) obj).getY().Equals(this.f41529076) && super.Equals(obj);
    }

    public java.math.Bigint GetY() {
        return this.f41529076;
    }

    public override int HashCode() {
        return super.GetHashCode() ^ this.f41529076.GetHashCode();
    }
}

