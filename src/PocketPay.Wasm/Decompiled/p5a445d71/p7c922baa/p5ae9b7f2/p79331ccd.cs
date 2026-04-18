namespace WillowMaze.Wasm.Decompiled;


public class p79331ccd {
    private p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 f2079dc41;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 f51d8bcce;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 f66a17bfa;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 f794c1a54;
    private p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 fc538f949;
    private p5a445d71.p7c922baa.p5ae9b7f2.p60156ac2 fe23c129a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p60156ac2 fe6220a5b;

    public p79331ccd(p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 pd255ec94Var, p5a445d71.p7c922baa.p5ae9b7f2.p60156ac2 p60156ac2Var) {
        this.f2079dc41 = pd255ec94Var;
        this.fe6220a5b = p60156ac2Var;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a NmfqhEVFTVcBIsvy(p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 pd255ec94Var) {
        return pd255ec94Var.getPublic();
    }

    public static byte[] WnQMgylYPgxbaOQQ(p5a445d71.p7c922baa.p5ae9b7f2.p60156ac2 p60156ac2Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return p60156ac2Var.getEncoded(pcfffbc4aVar);
    }

    public byte[] GetEncodedPublicKey() {
        return WnQMgylYPgxbaOQQ(this.fe6220a5b, NmfqhEVFTVcBIsvy(this.f2079dc41));
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GetKeyValueTuple() {
        return this.f2079dc41;
    }
}

