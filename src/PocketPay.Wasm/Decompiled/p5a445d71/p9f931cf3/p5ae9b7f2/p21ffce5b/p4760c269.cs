namespace WillowMaze.Wasm.Decompiled;


public class p4760c269 : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fbddcb344;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fe3ec7149;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fe4934155;

    public p4760c269(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.security.SecureRandom secureRandom) {
        super(secureRandom, p21c2eb74Var.getN().bitLength());
        this.fe4934155 = p21c2eb74Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 GetDomainParameters() {
        return this.fe4934155;
    }
}

