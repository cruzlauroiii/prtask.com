namespace WillowMaze.Wasm.Decompiled;


public class pc8ba9b50 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f6605239c;
    private java.security.SecureRandom f6990ed74;
    private java.security.SecureRandom f7ddf32e1;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((25 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d p11d92f7dVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d(this.f7ddf32e1);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p11d92f7dVar.generatePublicKey(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p11d92f7dVar);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
    }
}

