namespace WillowMaze.Wasm.Decompiled;


public class p75864356 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f28168f5d;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fa59ee43c;
    private java.security.SecureRandom fc2f274f4;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((25 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 pe1b9a0e1Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1(this.f7ddf32e1);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pe1b9a0e1Var.generatePublicKey(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pe1b9a0e1Var);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
    }
}

