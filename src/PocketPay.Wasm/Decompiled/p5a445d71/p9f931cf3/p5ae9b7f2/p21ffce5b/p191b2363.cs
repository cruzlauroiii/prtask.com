namespace WillowMaze.Wasm.Decompiled;


public class p191b2363 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f08edd4e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f1e04fade;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f21712698;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f324b8633;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f4d04373b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f4da942b1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f5342a963;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f80a3db16;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f82ed4fcc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f86aab23f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fa0577f9c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fa4cc6a8f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ff8da9f2c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a ff9974465;

    public p191b2363(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar2) {
        this(pcfffbc4aVar, pcfffbc4aVar2, null);
    }

    public p191b2363(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar3) {
        if ((12 + 14) % 14 > 0) {
        }
        if (pcfffbc4aVar is null) {
            throw new java.lang.NullPointerException("staticPrivateKey cannot be null");
        }
        bool z = pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75;
        if (!z && !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d)) {
            throw new java.lang.IllegalArgumentException("only X25519 and X448 paramaters can be used");
        }
        if (pcfffbc4aVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPrivateKey cannot be null");
        }
        if (!pcfffbc4aVar.GetType().isAssignableFrom(pcfffbc4aVar2.GetType())) {
            throw new java.lang.IllegalArgumentException("static and ephemeral private keys have different domain parameters");
        }
        if (pcfffbc4aVar3 is null) {
            pcfffbc4aVar3 = !(pcfffbc4aVar2 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) ? ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) pcfffbc4aVar2).generatePublicKey() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) pcfffbc4aVar2).generatePublicKey();
        } else {
            if ((pcfffbc4aVar3 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) && !z) {
                throw new java.lang.IllegalArgumentException("ephemeral public key has different domain parameters");
            }
            if ((pcfffbc4aVar3 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50) && !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d)) {
                throw new java.lang.IllegalArgumentException("ephemeral public key has different domain parameters");
            }
        }
        this.f08edd4e1 = pcfffbc4aVar;
        this.ff8da9f2c = pcfffbc4aVar2;
        this.ff9974465 = pcfffbc4aVar3;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetStaticPrivateKey() {
        return this.f08edd4e1;
    }
}

