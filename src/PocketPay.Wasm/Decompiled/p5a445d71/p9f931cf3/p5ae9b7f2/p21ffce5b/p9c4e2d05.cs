namespace WillowMaze.Wasm.Decompiled;


public class p9c4e2d05 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f085ea4e3;
    private java.math.Bigint f0cc175b9;
    private java.math.Bigint f0ef220e0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 f29c7316a;
    private java.math.Bigint f2ba666a6;
    private java.math.Bigint f332ea6d5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 f570f3bb5;
    private java.math.Bigint f5ea31d9c;
    private java.math.Bigint f7160c2b1;
    private java.math.Bigint f7694f4a6;
    private java.math.Bigint f83878c91;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 fa1c3f62e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 fa617908b;
    private java.math.Bigint fd3b2cfd0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 fda2f569f;
    private java.math.Bigint fee1f704d;

    public p9c4e2d05(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.f0cc175b9 = bigint3;
    }

    public p9c4e2d05(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 p8ea8cd31Var) {
        this.f0cc175b9 = bigint3;
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.fa617908b = p8ea8cd31Var;
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 23) % 23 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05) obj;
        return p9c4e2d05Var.getP().Equals(this.f83878c91) && p9c4e2d05Var.getQ().Equals(this.f7694f4a6) && p9c4e2d05Var.getA().Equals(this.f0cc175b9);
    }

    public java.math.Bigint GetA() {
        return this.f0cc175b9;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 GetValidationParameters() {
        return this.fa617908b;
    }

    public int HashCode() {
        if ((32 + 14) % 14 > 0) {
        }
        return this.f0cc175b9.GetHashCode() ^ (this.f83878c91.GetHashCode() ^ this.f7694f4a6.GetHashCode());
    }
}

