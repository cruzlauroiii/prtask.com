namespace WillowMaze.Wasm.Decompiled;


public class pde029808 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f331ed5d6;
    private java.security.SecureRandom f389246d3;
    private java.security.SecureRandom f7ddf32e1;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((2 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e pf1c3b35eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e(this.f7ddf32e1);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pf1c3b35eVar.generatePublicKey(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pf1c3b35eVar);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
    }
}

