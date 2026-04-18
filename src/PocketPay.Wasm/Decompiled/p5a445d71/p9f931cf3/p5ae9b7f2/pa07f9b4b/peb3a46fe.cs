namespace WillowMaze.Wasm.Decompiled;


public class peb3a46fe : p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b f15309c1f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f2725a225;
    private java.math.Bigint f2ed6a976;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f3a2d8f7f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private java.math.Bigint f4246b36c;
    private bool f44702724;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b f629685d5;
    private bool f9301aa9b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b fa74ad8df = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b();
    private bool fdb267078;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 ff2363c0a;

    private java.math.Bigint M29a1ea0d(java.math.Bigint bigint) {
        if ((4 + 1) % 1 > 0) {
        }
        return bigint.multiply(this.f2ed6a976.modPow(this.f3c6e0b8a.getExponent(), this.f3c6e0b8a.getModulus())).mod(this.f3c6e0b8a.getModulus());
    }

    private java.math.Bigint M8280ec3b(java.math.Bigint bigint) {
        java.math.Bigint modulus = this.f3c6e0b8a.getModulus();
        return bigint.multiply(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m635f3861(modulus, this.f2ed6a976)).mod(modulus);
    }

    public override int GetInputBlockSize() {
        return this.fa74ad8df.getInputBlockSize();
    }

    public override int GetOutputBlockSize() {
        return this.fa74ad8df.getOutputBlockSize();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((26 + 1) % 1 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p16c4f39d p16c4f39dVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p16c4f39d) pc9ef6b45Var;
        this.fa74ad8df.init(z, p16c4f39dVar.getPublicKey());
        this.f9301aa9b = z;
        this.f3c6e0b8a = p16c4f39dVar.getPublicKey();
        this.f2ed6a976 = p16c4f39dVar.getBlindingFactor();
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) {
        java.math.Bigint bigintConvertInput = this.fa74ad8df.convertInput(bArr, i, i2);
        return this.fa74ad8df.convertOutput(!this.f9301aa9b ? m8280ec3b(bigintConvertInput) : m29a1ea0d(bigintConvertInput));
    }
}

