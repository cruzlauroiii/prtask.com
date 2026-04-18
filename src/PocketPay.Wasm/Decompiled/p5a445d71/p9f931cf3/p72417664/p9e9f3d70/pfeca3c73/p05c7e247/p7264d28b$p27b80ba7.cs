namespace WillowMaze.Wasm.Decompiled;


class p7264d28b$p27b80ba7 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pd185725f {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f6fbf3359;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f9f34558a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fcca27ee9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fd964f22f;

    p7264d28b$p27b80ba7(p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        this.f08406a6e = p66d30ee8Var;
    }

    p7264d28b$p27b80ba7(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(pd81e8b93Var);
    }

    p7264d28b$p27b80ba7(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(pd81e8b93Var, pa444028eVar);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.BadPaddingException {
        try {
            return this.f08406a6e.doFinal(bArr, i);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new javax.crypto.BadPaddingException(e.getMessage());
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getUnderlyingCipher().getAlgorithmName();
    }

    public override int GetOutputSize(int i) {
        return this.f08406a6e.getOutputSize(i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e.getUnderlyingCipher();
    }

    public override int GetUpdateOutputSize(int i) {
        return this.f08406a6e.getUpdateOutputSize(i);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f08406a6e.init(z, pc9ef6b45Var);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return this.f08406a6e.processbyte(b, bArr, i);
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return this.f08406a6e.processbytes(bArr, i, i2, bArr2, i3);
    }

    public override void UpdateAAD(byte[] bArr, int i, int i2) {
        throw new java.lang.UnsupportedOperationException("AAD is not supported in the current mode.");
    }

    public override bool WrapOnNoPadding() {
        return !(this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p37d1254e);
    }
}

