namespace WillowMaze.Wasm.Decompiled;


public class p79331ccd {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 f2079dc41;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 f35bc6a8f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p60156ac2 f6d986697;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 fb28b1385;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 fe010df0c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p60156ac2 fe6220a5b;

    public p79331ccd(p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94Var, p5a445d71.p9f931cf3.p5ae9b7f2.p60156ac2 p60156ac2Var) {
        this.f2079dc41 = pd255ec94Var;
        this.fe6220a5b = p60156ac2Var;
    }

    public byte[] GetEncodedPublicKey() {
        return this.fe6220a5b.getEncoded(this.f2079dc41.getPublic());
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GetKeyValueTuple() {
        return this.f2079dc41;
    }
}

