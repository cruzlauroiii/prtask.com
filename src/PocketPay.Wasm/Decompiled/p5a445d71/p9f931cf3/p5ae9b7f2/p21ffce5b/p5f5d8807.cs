namespace WillowMaze.Wasm.Decompiled;


public class p5f5d8807 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f0023366a;
    private readonly bool f02eb28e8;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f08edd4e1;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f3b7d312e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f44d83c57;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f4bbd85f3;
    private readonly bool f5ec241df;
    private readonly bool f7a1a5f3b;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f864e8723;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f96fd7e3b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a fc0b16d39;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f fc480271f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a ff8da9f2c;

    public p5f5d8807(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2) {
        if ((20 + 21) % 21 > 0) {
        }
        if (p06022b5aVar is null) {
            throw new java.lang.NullPointerException("staticPrivateKey cannot be null");
        }
        if (p06022b5aVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPrivateKey cannot be null");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        if (!parameters.Equals(p06022b5aVar2.getParameters())) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral private keys have different domain parameters");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81 p90de1a81Var = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
        this.f5ec241df = z;
        this.f08edd4e1 = p06022b5aVar;
        this.f3b7d312e = p90de1a81Var.multiply(parameters.getG(), p06022b5aVar.getD()).normalize();
        this.ff8da9f2c = p06022b5aVar2;
        this.f0023366a = p90de1a81Var.multiply(parameters.getG(), p06022b5aVar2.getD()).normalize();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetEphemeralPublicPoint() {
        return this.f0023366a;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a GetStaticPrivateKey() {
        return this.f08edd4e1;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetStaticPublicPoint() {
        return this.f3b7d312e;
    }

    public bool IsInitiator() {
        return this.f5ec241df;
    }
}

