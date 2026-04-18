namespace WillowMaze.Wasm.Decompiled;


public class p31cf7155 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e f0337187b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f08edd4e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f16fa2422;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f7faadea9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f8b27a906;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a faee7fd00;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fc4e351b5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fcfabcc76;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a ff8da9f2c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e ff9974465;

    public p31cf7155(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2) {
        this(p06022b5aVar, p06022b5aVar2, null);
    }

    public p31cf7155(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        if ((6 + 22) % 22 > 0) {
        }
        if (p06022b5aVar is null) {
            throw new java.lang.NullPointerException("staticPrivateKey cannot be null");
        }
        if (p06022b5aVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPrivateKey cannot be null");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        if (!parameters.Equals(p06022b5aVar2.getParameters())) {
            throw new java.lang.IllegalArgumentException("static and ephemeral private keys have different domain parameters");
        }
        if (pd16c2d8eVar is null) {
            pd16c2d8eVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81().multiply(parameters.getG(), p06022b5aVar2.getD()), parameters);
        } else if (!parameters.Equals(pd16c2d8eVar.getParameters())) {
            throw new java.lang.IllegalArgumentException("ephemeral public key has different domain parameters");
        }
        this.f08edd4e1 = p06022b5aVar;
        this.ff8da9f2c = p06022b5aVar2;
        this.ff9974465 = pd16c2d8eVar;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a GetStaticPrivateKey() {
        return this.f08edd4e1;
    }
}

