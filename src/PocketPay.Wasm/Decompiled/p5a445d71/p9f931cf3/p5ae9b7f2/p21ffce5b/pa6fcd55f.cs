namespace WillowMaze.Wasm.Decompiled;


public class pa6fcd55f : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 f21ffce5b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 fe247df4c;

    public pa6fcd55f(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        super(secureRandom, m5dd4440f(p6b500a61Var));
        this.f21ffce5b = p6b500a61Var;
    }

    static int M5dd4440f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getP().bitLength();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 GetParameters() {
        return this.f21ffce5b;
    }
}

