namespace WillowMaze.Wasm.Decompiled;


public class p4760c269 : p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f2cc02a89;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f35e26a3a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f534e30df;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 fe4934155;

    public p4760c269(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.security.SecureRandom secureRandom) {
        super(secureRandom, hSRbyqIlYXoisdTa(VsFQoyXkJDEVCWuS(p21c2eb74Var)));
        this.fe4934155 = p21c2eb74Var;
    }

    public static java.math.Bigint VsFQoyXkJDEVCWuS(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getN();
    }

    public static int HSRbyqIlYXoisdTa(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 GetDomainParameters() {
        return this.fe4934155;
    }
}

