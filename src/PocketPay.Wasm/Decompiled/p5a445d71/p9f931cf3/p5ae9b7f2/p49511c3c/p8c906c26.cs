namespace WillowMaze.Wasm.Decompiled;


public class p8c906c26 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f1113449e;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f9e40b81a;
    private java.security.SecureRandom fa27389fa;
    private java.security.SecureRandom fa5a4b240;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((25 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 p62f08e75Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75(this.f7ddf32e1);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p62f08e75Var.generatePublicKey(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p62f08e75Var);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
    }
}

