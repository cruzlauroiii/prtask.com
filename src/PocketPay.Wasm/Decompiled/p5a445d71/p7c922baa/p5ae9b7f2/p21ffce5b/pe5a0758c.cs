namespace WillowMaze.Wasm.Decompiled;


public class pe5a0758c : p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 f21ffce5b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 fa4a01cd1;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 faaf26533;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 ff0d2bb22;

    public pe5a0758c(java.security.SecureRandom secureRandom, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        super(secureRandom, FCEccPHVRQZnwVda(WgKTWnQrwJfLquBU(p9c4e2d05Var)) - 1);
        this.f21ffce5b = p9c4e2d05Var;
    }

    public static int FCEccPHVRQZnwVda(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint WgKTWnQrwJfLquBU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getP();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 GetParameters() {
        return this.f21ffce5b;
    }
}

