namespace WillowMaze.Wasm.Decompiled;


public class p9c4e2d05 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f0469278e;
    private java.math.Bigint f0cc175b9;
    private java.math.Bigint f0eb485ae;
    private java.math.Bigint f2e928cb4;
    private java.math.Bigint f4067f23a;
    private java.math.Bigint f4b5de9cf;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31 f6a32b2ad;
    private java.math.Bigint f7694f4a6;
    private java.math.Bigint f83878c91;
    private java.math.Bigint f8874eb5c;
    private java.math.Bigint f8dcb9966;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31 fa617908b;
    private java.math.Bigint fbbcec082;
    private java.math.Bigint ff5074a93;

    public p9c4e2d05(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.f0cc175b9 = bigint3;
    }

    public p9c4e2d05(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31 p8ea8cd31Var) {
        this.f0cc175b9 = bigint3;
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.fa617908b = p8ea8cd31Var;
    }

    public static java.math.Bigint MgXdfghPXwJDJHSV(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getQ();
    }

    public static bool RGQzDaSbzWMytMWf(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static bool SXvWBaWmJxdANELu(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint SvKzyvOLQPyeoVYN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getP();
    }

    public static java.math.Bigint UFHmouqBxnBcabNw(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getA();
    }

    public static int AbXhEELysrshDKOf(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static bool BeNaWUfsIsXUboQf(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int IqIoMNqdPmbEAMNe(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static int QXeqejnchUrnjRNI(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 16) % 16 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05) obj;
        return beNaWUfsIsXUboQf(SvKzyvOLQPyeoVYN(p9c4e2d05Var), this.f83878c91) && SXvWBaWmJxdANELu(MgXdfghPXwJDJHSV(p9c4e2d05Var), this.f7694f4a6) && RGQzDaSbzWMytMWf(UFHmouqBxnBcabNw(p9c4e2d05Var), this.f0cc175b9);
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

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31 GetValidationParameters() {
        return this.fa617908b;
    }

    public int HashCode() {
        if ((32 + 21) % 21 > 0) {
        }
        return qXeqejnchUrnjRNI(this.f0cc175b9) ^ (abXhEELysrshDKOf(this.f83878c91) ^ iqIoMNqdPmbEAMNe(this.f7694f4a6));
    }
}

