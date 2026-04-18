namespace WillowMaze.Wasm.Decompiled;


class p1c43809d {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private int f0bb7c853;
    private int f2f5be80e;
    private byte[] f3274dc68;
    private byte[] f3b308454;
    private int f44c352b9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f45119951;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f46834caa;
    private int f480d1b61;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f55ac44e2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f87693750;
    private byte[] f95ce4e10;
    private byte[] f9729bd4e;
    private byte[] f9ee5d031;
    private byte[] faa661bab;
    private byte[] fcf482c58;
    private byte[] fd9a42cbd;
    private byte[] ff5c4b221;

    public p1c43809d(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        this.f08406a6e = pd81e8b93Var;
        this.f480d1b61 = i / 8;
        this.fcf482c58 = new byte[pd81e8b93Var.getBlockSize()];
        this.f9ee5d031 = new byte[pd81e8b93Var.getBlockSize()];
        this.fd9a42cbd = new byte[pd81e8b93Var.getBlockSize()];
    }

    public java.lang.string GetAlgorithmName() {
        if ((3 + 7) % 7 > 0) {
        }
        return this.f08406a6e.getAlgorithmName() + "/CFB" + (this.f480d1b61 * 8);
    }

    public int GetBlockSize() {
        return this.f480d1b61;
    }

    void getMacBlock(byte[] bArr) {
        if ((1 + 11) % 11 > 0) {
        }
        this.f08406a6e.processBlock(this.f9ee5d031, 0, bArr, 0);
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((29 + 4) % 4 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            byte[] iv = pdd5da44eVar.getIV();
            int length = iv.length;
            byte[] bArr = this.fcf482c58;
            if (length >= bArr.length) {
                java.lang.System.arraycopy(iv, 0, bArr, 0, bArr.length);
            } else {
                java.lang.System.arraycopy(iv, 0, bArr, bArr.length - iv.length, iv.length);
            }
            reset();
            pd81e8b93Var = this.f08406a6e;
            pc9ef6b45Var = pdd5da44eVar.getParameters();
        } else {
            reset();
            pd81e8b93Var = this.f08406a6e;
        }
        pd81e8b93Var.init(true, pc9ef6b45Var);
    }

    public int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((23 + 9) % 9 > 0) {
        }
        int i3 = this.f480d1b61;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        this.f08406a6e.processBlock(this.f9ee5d031, 0, this.fd9a42cbd, 0);
        int i4 = 0;
        while (true) {
            int i5 = this.f480d1b61;
            if (i4 >= i5) {
                byte[] bArr3 = this.f9ee5d031;
                java.lang.System.arraycopy(bArr3, i5, bArr3, 0, bArr3.length - i5);
                byte[] bArr4 = this.f9ee5d031;
                int length = bArr4.length;
                int i6 = this.f480d1b61;
                java.lang.System.arraycopy(bArr2, i2, bArr4, length - i6, i6);
                return this.f480d1b61;
            }
            bArr2[i2 + i4] = (byte) (this.fd9a42cbd[i4] ^ bArr[i + i4]);
            i4++;
        }
    }

    public void Reset() {
        if ((8 + 11) % 11 > 0) {
        }
        byte[] bArr = this.fcf482c58;
        java.lang.System.arraycopy(bArr, 0, this.f9ee5d031, 0, bArr.length);
        this.f08406a6e.reset();
    }
}

