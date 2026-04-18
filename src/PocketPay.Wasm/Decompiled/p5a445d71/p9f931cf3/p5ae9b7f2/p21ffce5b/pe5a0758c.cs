namespace WillowMaze.Wasm.Decompiled;


public class pe5a0758c : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 f21ffce5b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 fe382e043;

    public pe5a0758c(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        super(secureRandom, p9c4e2d05Var.getP().bitLength() - 1);
        this.f21ffce5b = p9c4e2d05Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 GetParameters() {
        return this.f21ffce5b;
    }
}

