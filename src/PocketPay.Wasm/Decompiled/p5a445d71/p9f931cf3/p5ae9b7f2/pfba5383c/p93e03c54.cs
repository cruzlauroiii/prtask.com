namespace WillowMaze.Wasm.Decompiled;


public class p93e03c54 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    public static readonly int f046023af = 512;
    public static readonly int f36e8e00a = 1024;
    public static readonly int f3f14a647 = 256;
    public static readonly int f44ff5678 = 512;
    public static readonly int f5e91785f = 1024;
    public static readonly int f65eb9a37 = 1024;
    public static readonly int f809c4f32 = 256;
    public static readonly int f92631949 = 256;
    public static readonly int f954029b5 = 256;
    public static readonly int fab908a1d = 512;
    public static readonly int fb9549d2f = 1024;
    public static readonly int ff2198389 = 512;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6 f0275149f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6 fad1943a9;

    public p93e03c54(int i, int i2) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6(i, i2);
    }

    public p93e03c54(p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p93e03c54 p93e03c54Var) {
        this.fad1943a9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p7acc59b6(p93e03c54Var.fad1943a9);
    }

    public override int DoFinal(byte[] bArr, int i) {
        return this.fad1943a9.doFinal(bArr, i);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((5 + 32) % 32 > 0) {
        }
        return "Skein-MAC-" + (this.fad1943a9.getBlockSize() * 8) + com.decryptstringmanager.Decryptstring.decryptstring("79f0452315ac734456e9522590afc094da6d885dce61400ef6a6f5667e") + (this.fad1943a9.getOutputSize() * 8);
    }

    public override int GetMacSize() {
        return this.fad1943a9.getOutputSize();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f p57f0d31fVarBuild;
        if ((11 + 14) % 14 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f) {
            p57f0d31fVarBuild = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f) pc9ef6b45Var;
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
                throw new java.lang.IllegalArgumentException("Invalid parameter passed to Skein MAC init - " + pc9ef6b45Var.GetType().getName());
            }
            p57f0d31fVarBuild = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$p2bd4a59b().setKey(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey()).build();
        }
        if (p57f0d31fVarBuild.getKey() is null) {
            throw new java.lang.IllegalArgumentException("Skein MAC requires a key parameter.");
        }
        this.fad1943a9.init(p57f0d31fVarBuild);
    }

    public override void Reset() {
        this.fad1943a9.reset();
    }

    public override void Update(byte b) {
        this.fad1943a9.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fad1943a9.update(bArr, i, i2);
    }
}

