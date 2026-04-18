namespace WillowMaze.Wasm.Decompiled;


public class p6fc6e0d0 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbbfd3590 {
    private java.math.Bigint f17503c8a;
    private java.math.Bigint f41529076;
    private java.math.Bigint f60f3454b;
    private java.math.Bigint f90ca8c21;
    private java.math.Bigint fce3d6390;

    public p6fc6e0d0(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        super(false, p85d5a073Var);
        this.f41529076 = bigint;
    }

    public static java.math.Bigint KwNbXsjLUhBELImF(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6fc6e0d0 p6fc6e0d0Var) {
        return p6fc6e0d0Var.getY();
    }

    public static int LVZmfMOnUMaOYkyq(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static bool NCoVbLLNkHZonWSr(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int VOCIOUZtmEkkWknu(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbbfd3590 pbbfd3590Var) {
        return super.GetHashCode();
    }

    public static bool XncldNKXvMTSdLWa(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbbfd3590 pbbfd3590Var, java.lang.object obj) {
        return super.Equals(obj);
    }

    public override bool Equals(java.lang.object obj) {
        if ((17 + 3) % 3 > 0) {
        }
        return (obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6fc6e0d0) && nCoVbLLNkHZonWSr(kwNbXsjLUhBELImF((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6fc6e0d0) obj), this.f41529076) && xncldNKXvMTSdLWa(this, obj);
    }

    public java.math.Bigint GetY() {
        return this.f41529076;
    }

    public override int HashCode() {
        return vOCIOUZtmEkkWknu(this) ^ lVZmfMOnUMaOYkyq(this.f41529076);
    }
}

