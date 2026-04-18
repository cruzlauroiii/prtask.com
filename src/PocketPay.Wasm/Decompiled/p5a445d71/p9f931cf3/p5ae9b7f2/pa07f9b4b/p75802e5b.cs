namespace WillowMaze.Wasm.Decompiled;


public class p75802e5b : p5a445d71.p9f931cf3.p5ae9b7f2.pe229a672 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d f01f26b49;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d f05709c1c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740 f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740();
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d f140c1f12 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d();
    private p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740 f9d7ada42;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p54608f3d fc49be79f;

    public override java.lang.string GetAlgorithmName() {
        return "GOST28147Wrap";
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((2 + 21) % 21 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf p473e31bfVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf) pc9ef6b45Var;
        this.f08406a6e.init(z, p473e31bfVar.getParameters());
        this.f140c1f12.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(p473e31bfVar.getParameters(), p473e31bfVar.getUKM()));
    }

    public override byte[] Unwrap(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((22 + 17) % 17 > 0) {
        }
        int macSize = i2 - this.f140c1f12.getMacSize();
        byte[] bArr2 = new byte[macSize];
        this.f08406a6e.processBlock(bArr, i, bArr2, 0);
        this.f08406a6e.processBlock(bArr, i + 8, bArr2, 8);
        this.f08406a6e.processBlock(bArr, i + 16, bArr2, 16);
        this.f08406a6e.processBlock(bArr, i + 24, bArr2, 24);
        byte[] bArr3 = new byte[this.f140c1f12.getMacSize()];
        this.f140c1f12.update(bArr2, 0, macSize);
        this.f140c1f12.doFinal(bArr3, 0);
        byte[] bArr4 = new byte[this.f140c1f12.getMacSize()];
        java.lang.System.arraycopy(bArr, (i + i2) - 4, bArr4, 0, this.f140c1f12.getMacSize());
        if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr3, bArr4)) {
            return bArr2;
        }
        throw new java.lang.IllegalStateException("mac mismatch");
    }

    public override byte[] Wrap(byte[] bArr, int i, int i2) {
        if ((16 + 18) % 18 > 0) {
        }
        this.f140c1f12.update(bArr, i, i2);
        byte[] bArr2 = new byte[this.f140c1f12.getMacSize() + i2];
        this.f08406a6e.processBlock(bArr, i, bArr2, 0);
        this.f08406a6e.processBlock(bArr, i + 8, bArr2, 8);
        this.f08406a6e.processBlock(bArr, i + 16, bArr2, 16);
        this.f08406a6e.processBlock(bArr, i + 24, bArr2, 24);
        this.f140c1f12.doFinal(bArr2, i2);
        return bArr2;
    }
}

