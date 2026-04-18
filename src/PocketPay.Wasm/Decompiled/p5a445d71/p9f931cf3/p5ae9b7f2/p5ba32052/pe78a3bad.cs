namespace WillowMaze.Wasm.Decompiled;


public readonly class pe78a3bad : p5a445d71.p9f931cf3.p5ae9b7f2.pd0a4c378 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 f03335609;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 f20b54622;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 fbd0c8e3b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 fe2e8e992;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 ff8aa95fc;

    public override void CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i) {
        this.fbd0c8e3b.generateSecret((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5) pc9ef6b45Var, bArr, i);
    }

    public override int GetAgreementSize() {
        return 56;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.fbd0c8e3b = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) pc9ef6b45Var;
    }
}

