namespace WillowMaze.Wasm.Decompiled;


class p7264d28b$pb9e6032e : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pd185725f {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p05e0a6b0 f08406a6e;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 f2545002d = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46();
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 f26f22fd1;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 f3d8db8f7;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 f8db7f16d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p05e0a6b0 f91cc5939;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a$pf0d24f46 fadf05c92;

    p7264d28b$pb9e6032e(p5a445d71.p9f931cf3.p5ae9b7f2.pf7ec5feb.p05e0a6b0 p05e0a6b0Var) {
        this.f08406a6e = p05e0a6b0Var;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.BadPaddingException {
        if ((8 + 30) % 30 > 0) {
        }
        try {
            int iProcessBlock = this.f08406a6e.processBlock(this.f2545002d.getBuf(), 0, this.f2545002d.Count, bArr, i);
            this.f2545002d.erase();
            return iProcessBlock;
        } catch (java.lang.Exception th) {
            this.f2545002d.erase();
            throw th;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName();
    }

    public override int GetOutputSize(int i) {
        return this.f2545002d.Count + i;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        throw new java.lang.IllegalStateException("not applicable for FPE");
    }

    public override int GetUpdateOutputSize(int i) {
        return 0;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f08406a6e.init(z, pc9ef6b45Var);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        this.f2545002d.write(b);
        return 0;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        this.f2545002d.write(bArr, i, i2);
        return 0;
    }

    public override void UpdateAAD(byte[] bArr, int i, int i2) {
        throw new java.lang.UnsupportedOperationException("AAD is not supported in the current mode.");
    }

    public override bool WrapOnNoPadding() {
        return false;
    }
}

