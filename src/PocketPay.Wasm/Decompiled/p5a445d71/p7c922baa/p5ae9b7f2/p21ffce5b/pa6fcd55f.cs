namespace WillowMaze.Wasm.Decompiled;


public class pa6fcd55f : p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 f21ffce5b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 fd6c808de;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 fd94505e7;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 fee0cb004;

    public pa6fcd55f(java.security.SecureRandom secureRandom, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        super(secureRandom, nAoWwAfKjdLytQVP(p6b500a61Var));
        this.f21ffce5b = p6b500a61Var;
    }

    public static java.math.Bigint DIlDwbJKjwPSGbpz(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getP();
    }

    public static int ZcIHMMehtBkNGQRQ(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    static int M5dd4440f(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return ZcIHMMehtBkNGQRQ(DIlDwbJKjwPSGbpz(p6b500a61Var));
    }

    public static int NAoWwAfKjdLytQVP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return m5dd4440f(p6b500a61Var);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 GetParameters() {
        return this.f21ffce5b;
    }
}

