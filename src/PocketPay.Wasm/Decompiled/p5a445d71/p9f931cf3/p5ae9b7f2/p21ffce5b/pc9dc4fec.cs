namespace WillowMaze.Wasm.Decompiled;


public class pc9dc4fec : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83d23d10 {
    private java.math.Bigint f9dd4e461;
    private java.math.Bigint f9e18f81f;

    public pc9dc4fec(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        super(true, p4460e12aVar);
        this.f9dd4e461 = bigint;
    }

    public override bool Equals(java.lang.object obj) {
        if ((27 + 6) % 6 > 0) {
        }
        return (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec) && ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec) obj).getX().Equals(this.f9dd4e461) && super.Equals(obj);
    }

    public java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public override int HashCode() {
        return super.GetHashCode() ^ this.f9dd4e461.GetHashCode();
    }
}

