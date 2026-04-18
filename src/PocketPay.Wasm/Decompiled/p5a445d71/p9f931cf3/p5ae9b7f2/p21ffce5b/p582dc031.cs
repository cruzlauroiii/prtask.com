namespace WillowMaze.Wasm.Decompiled;


public class p582dc031 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 {
    private java.math.Bigint f0124aa72;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc f1236e044;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc f1cd3c693;
    private java.math.Bigint f1d9c096f;
    private java.math.Bigint f29361885;
    private java.math.Bigint f47f4cb5d;
    private java.math.Bigint f6081c264;
    private java.math.Bigint f65d9f55b;
    private java.math.Bigint f6a331d4e;
    private java.math.Bigint f6dbf9ac2;
    private java.math.Bigint f6e6b04fa;
    private java.math.Bigint f77292dd1;
    private java.math.Bigint f8e683187;
    private java.math.Bigint f94c456ca;
    private java.math.Bigint fa0b54e95;
    private java.math.Bigint fb199619b;
    private java.math.Bigint fc03cf77b;
    private java.math.Bigint fc60d54eb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc fd0d121ad;
    private java.math.Bigint fe7b65230;
    private java.math.Bigint ffbade9e3;

    public p582dc031(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint bigint5) {
        super(true, p6b500a61Var);
        this.f6dbf9ac2 = bigint;
        this.f8e683187 = bigint2;
        this.f29361885 = bigint3;
        this.f0124aa72 = bigint4;
        this.ffbade9e3 = bigint5;
    }

    public override bool Equals(java.lang.object obj) {
        if ((20 + 27) % 27 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031 p582dc031Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p582dc031) obj;
        return p582dc031Var.getX1().Equals(this.f6dbf9ac2) && p582dc031Var.getX2().Equals(this.f8e683187) && p582dc031Var.getY1().Equals(this.f29361885) && p582dc031Var.getY2().Equals(this.f0124aa72) && p582dc031Var.getZ().Equals(this.ffbade9e3) && super.Equals(obj);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc GetPk() {
        return this.f1cd3c693;
    }

    public java.math.Bigint GetX1() {
        return this.f6dbf9ac2;
    }

    public java.math.Bigint GetX2() {
        return this.f8e683187;
    }

    public java.math.Bigint GetY1() {
        return this.f29361885;
    }

    public java.math.Bigint GetY2() {
        return this.f0124aa72;
    }

    public java.math.Bigint GetZ() {
        return this.ffbade9e3;
    }

    public override int HashCode() {
        if ((17 + 22) % 22 > 0) {
        }
        return super.GetHashCode() ^ ((((this.f6dbf9ac2.GetHashCode() ^ this.f8e683187.GetHashCode()) ^ this.f29361885.GetHashCode()) ^ this.f0124aa72.GetHashCode()) ^ this.ffbade9e3.GetHashCode());
    }

    public void SetPk(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3f7da2fc p3f7da2fcVar) {
        this.f1cd3c693 = p3f7da2fcVar;
    }
}

