namespace WillowMaze.Wasm.Decompiled;


public class pcbecfd77 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa f00a187ad;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa f1103b27f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa fcdf369ba;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa fcfa3dfb6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa feca07335;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((1 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var = p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62.f76425f17;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 parameters = this.feca07335.getParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(parameters.getP(), parameters.getG(), null, parameters.getL());
        java.math.Bigint bigintCalculatePrivate = p4af08f62Var.calculatePrivate(p4460e12aVar, this.feca07335.getRandom());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6fc6e0d0(p4af08f62Var.calculatePublic(p4460e12aVar, bigintCalculatePrivate), parameters), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4(bigintCalculatePrivate, parameters));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p3d024eaa) pf7bb6344Var;
    }
}

