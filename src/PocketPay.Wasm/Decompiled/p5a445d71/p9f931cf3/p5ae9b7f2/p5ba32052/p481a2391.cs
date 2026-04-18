namespace WillowMaze.Wasm.Decompiled;


public readonly class p481a2391 : p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d f141adcec;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d fa2d8e7ed;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d fbd0c8e3b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d fe7af73a2;

    public override void CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i) {
        this.fbd0c8e3b.generateSecret((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50) pc9ef6b45Var, bArr, i);
    }

    public override int GetAgreementSize() {
        return 32;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.fbd0c8e3b = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) pc9ef6b45Var;
    }
}

