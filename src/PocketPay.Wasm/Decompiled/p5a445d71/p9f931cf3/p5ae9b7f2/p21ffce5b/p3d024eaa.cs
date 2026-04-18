namespace WillowMaze.Wasm.Decompiled;


public class p3d024eaa : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 f1c4d4287;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 f21ffce5b;

    public p3d024eaa(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        super(secureRandom, m5dd4440f(p85d5a073Var));
        this.f21ffce5b = p85d5a073Var;
    }

    static int M5dd4440f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getL() == 0 ? p85d5a073Var.getP().bitLength() : p85d5a073Var.getL();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 GetParameters() {
        return this.f21ffce5b;
    }
}

