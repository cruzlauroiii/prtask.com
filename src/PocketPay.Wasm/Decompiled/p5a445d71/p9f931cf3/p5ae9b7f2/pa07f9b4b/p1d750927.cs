namespace WillowMaze.Wasm.Decompiled;


public class p1d750927 : p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b f156636f6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b fa2f2479b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b fa74ad8df;

    public override int GetInputBlockSize() {
        return this.fa74ad8df.getInputBlockSize();
    }

    public override int GetOutputBlockSize() {
        return this.fa74ad8df.getOutputBlockSize();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (this.fa74ad8df is null) {
            this.fa74ad8df = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b();
        }
        this.fa74ad8df.init(z, pc9ef6b45Var);
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b pdfea566bVar = this.fa74ad8df;
        if (pdfea566bVar is null) {
            throw new java.lang.IllegalStateException("RSA engine not initialised");
        }
        return pdfea566bVar.convertOutput(pdfea566bVar.processBlock(pdfea566bVar.convertInput(bArr, i, i2)));
    }
}

