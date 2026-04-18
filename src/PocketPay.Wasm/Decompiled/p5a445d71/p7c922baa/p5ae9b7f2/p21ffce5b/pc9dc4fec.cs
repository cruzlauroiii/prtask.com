namespace WillowMaze.Wasm.Decompiled;


public class pc9dc4fec : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83d23d10 {
    private java.math.Bigint f4aeddb65;
    private java.math.Bigint f9dd4e461;

    public pc9dc4fec(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        super(true, p4460e12aVar);
        this.f9dd4e461 = bigint;
    }

    public static int QuthyofStrFqkZmq(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static java.math.Bigint TMkdNUAgMRnsfHzh(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar) {
        return pc9dc4fecVar.getX();
    }

    public static int ILslVqjvITjsLUjj(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83d23d10 p83d23d10Var) {
        return super.GetHashCode();
    }

    public static bool KOnhaPKxkPuNcurQ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83d23d10 p83d23d10Var, java.lang.object obj) {
        return super.Equals(obj);
    }

    public static bool MtChhvUYZbjjsydx(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public override bool Equals(java.lang.object obj) {
        if ((9 + 20) % 20 > 0) {
        }
        return (obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc9dc4fec) && mtChhvUYZbjjsydx(TMkdNUAgMRnsfHzh((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc9dc4fec) obj), this.f9dd4e461) && kOnhaPKxkPuNcurQ(this, obj);
    }

    public java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public override int HashCode() {
        return iLslVqjvITjsLUjj(this) ^ QuthyofStrFqkZmq(this.f9dd4e461);
    }
}

