namespace WillowMaze.Wasm.Decompiled;


public class p4eed90a0 : p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pb75caf92 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f51f01370;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a f8cd56d46;

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Decrypt(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 pd38c8b22Var) {
        if ((32 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = this.f3c6e0b8a;
        if (p06022b5aVar is null) {
            throw new java.lang.IllegalStateException("ECElGamalDecryptor not initialised");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p06022b5aVar.getParameters().getCurve();
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(curve, pd38c8b22Var.getY()).subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.mcff1d00d(curve, pd38c8b22Var.getX()).multiply(this.f3c6e0b8a.getD())).normalize();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a)) {
            throw new java.lang.IllegalArgumentException("ECPrivateKeyParameters are required for decryption.");
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pc9ef6b45Var;
    }
}

