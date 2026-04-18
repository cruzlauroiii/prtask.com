namespace WillowMaze.Wasm.Decompiled;


public class pd0939147 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf78f8b44 f04f2c93b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf78f8b44 f0c4115ba;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf78f8b44 f3c807ae1;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf78f8b44 f54088596;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf78f8b44 fced84eb7;

    public pd0939147(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pf78f8b44 pf78f8b44Var) {
        this.f0c4115ba = pf78f8b44Var;
    }

    public override int DoFinal(byte[] bArr, int i) {
        return this.f0c4115ba.doFinal(bArr, i);
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f0c4115ba.getAlgorithmName() + "Mac";
    }

    public override int GetMacSize() {
        return this.f0c4115ba.getDigestSize();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((14 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarM3c6e0b8a = !(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ? pc9ef6b45Var : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815.m3c6e0b8a(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
        if (!(pc9ef6b45VarM3c6e0b8a is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815)) {
            throw new java.lang.IllegalArgumentException("Invalid parameter passed to Blake3Mac init - " + pc9ef6b45Var.GetType().getName());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815 pc3f77815Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc3f77815) pc9ef6b45VarM3c6e0b8a;
        if (pc3f77815Var.getKey() is null) {
            throw new java.lang.IllegalArgumentException("Blake3Mac requires a key parameter.");
        }
        this.f0c4115ba.init(pc3f77815Var);
    }

    public override void Reset() {
        this.f0c4115ba.reset();
    }

    public override void Update(byte b) {
        this.f0c4115ba.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.f0c4115ba.update(bArr, i, i2);
    }
}

