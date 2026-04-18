namespace WillowMaze.Wasm.Decompiled;


public class p8d0590d4 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbbfd3590 {
    private java.math.Bigint f117d14a4;
    private java.math.Bigint f3d348899;
    private java.math.Bigint f51bacfb0;
    private java.math.Bigint f95c4837e;
    private java.math.Bigint f9dd4e461;

    public p8d0590d4(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        super(true, p85d5a073Var);
        this.f9dd4e461 = bigint;
    }

    public static java.math.Bigint BIZuZISuDzKblKYz(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8d0590d4 p8d0590d4Var) {
        return p8d0590d4Var.getX();
    }

    public static bool GsoZAgoNVSUtAJGA(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int YiRKwsrMVWVIpFFC(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static java.math.Bigint LjAvmhnlYkhQZgLv(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8d0590d4 p8d0590d4Var) {
        return p8d0590d4Var.getX();
    }

    public static bool ROMfOhJYjSJkMMfu(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pbbfd3590 pbbfd3590Var, java.lang.object obj) {
        return super.Equals(obj);
    }

    public override bool Equals(java.lang.object obj) {
        if ((28 + 20) % 20 > 0) {
        }
        if ((obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8d0590d4) && GsoZAgoNVSUtAJGA(BIZuZISuDzKblKYz((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8d0590d4) obj), this.f9dd4e461)) {
            return rOMfOhJYjSJkMMfu(this, obj);
        }
        return false;
    }

    public java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public override int HashCode() {
        return YiRKwsrMVWVIpFFC(ljAvmhnlYkhQZgLv(this));
    }
}

