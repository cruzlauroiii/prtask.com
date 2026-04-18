namespace WillowMaze.Wasm.Decompiled;


public class p362dd0e1 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 f932a03f8;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 fba6be571;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621 feca07335;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((2 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62.f76425f17;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a parameters = this.feca07335.getParameters();
        java.math.Bigint bigintCalculatePrivate = p4af08f62Var.calculatePrivate(parameters, this.feca07335.getRandom());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(p4af08f62Var.calculatePublic(parameters, bigintCalculatePrivate), parameters), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(bigintCalculatePrivate, parameters));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621) pf7bb6344Var;
    }
}

