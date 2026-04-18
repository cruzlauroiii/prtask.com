namespace WillowMaze.Wasm.Decompiled;


public class p5b6165f0 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f282e5f0e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f2a47b1a6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f5b09a4f2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f9933de1e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fb6a7f769;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ff40dbce2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ff92cc543;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ff9974465;

    public p5b6165f0(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar2) {
        if ((8 + 25) % 25 > 0) {
        }
        if (pcfffbc4aVar is null) {
            throw new java.lang.NullPointerException("staticPublicKey cannot be null");
        }
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) && !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50)) {
            throw new java.lang.IllegalArgumentException("only X25519 and X448 paramaters can be used");
        }
        if (pcfffbc4aVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPublicKey cannot be null");
        }
        if (!pcfffbc4aVar.GetType().isAssignableFrom(pcfffbc4aVar2.GetType())) {
            throw new java.lang.IllegalArgumentException("static and ephemeral public keys have different domain parameters");
        }
        this.ff40dbce2 = pcfffbc4aVar;
        this.ff9974465 = pcfffbc4aVar2;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetStaticPublicKey() {
        return this.ff40dbce2;
    }
}

