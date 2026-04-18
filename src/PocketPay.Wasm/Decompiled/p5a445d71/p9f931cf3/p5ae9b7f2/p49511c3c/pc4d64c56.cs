namespace WillowMaze.Wasm.Decompiled;


public class pc4d64c56 : p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p2c69f81a {
    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((28 + 32) % 32 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) super.generateKeyValueTuple().getPublic();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(pd16c2d8eVar.getQ().negate(), pd16c2d8eVar.getParameters()), r3.getPrivate());
    }
}

