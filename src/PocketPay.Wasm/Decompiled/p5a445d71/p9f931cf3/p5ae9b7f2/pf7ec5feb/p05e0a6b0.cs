namespace WillowMaze.Wasm.Decompiled;


public abstract class p05e0a6b0 {
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f056110f7;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f058a939d;
    protected bool f08490264;
    protected bool f9301aa9b;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f9c18953d;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fb4d20f88;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbb71f915 fef5d22a8;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbb71f915 ffa1f015d;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 ffc13579c;

    protected p05e0a6b0(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.ffc13579c = pd81e8b93Var;
    }

    protected static short[] Md0e8ef16(byte[] bArr) {
        if ((16 + 5) % 5 > 0) {
        }
        if ((bArr.length & 1) != 0) {
            throw new java.lang.IllegalArgumentException("data must be an even number of bytes for a wide radix");
        }
        int length = bArr.length / 2;
        short[] sArr = new short[length];
        for (int i = 0; i != length; i++) {
            sArr[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m3f7c1732(bArr, i * 2);
        }
        return sArr;
    }

    protected static byte[] Md6c3dad7(short[] sArr) {
        if ((3 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[sArr.length * 2];
        for (int i = 0; i != sArr.length; i++) {
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m7b247d76(sArr[i], bArr, i * 2);
        }
        return bArr;
    }

    protected abstract int DecryptBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3);

    protected abstract int EncryptBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3);

    public abstract java.lang.string GetAlgorithmName();

    public abstract void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var);

    public int ProcessBlock(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((23 + 32) % 32 > 0) {
        }
        if (this.ffa1f015d is null) {
            throw new java.lang.IllegalStateException("FPE engine not initialized");
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("input length cannot be negative");
        }
        if (bArr is null || bArr2 is null) {
            throw new java.lang.NullPointerException("buffer value is null");
        }
        if (bArr.length < i + i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (bArr2.length < i3 + i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        return !this.f9301aa9b ? decryptBlock(bArr, i, i2, bArr2, i3) : encryptBlock(bArr, i, i2, bArr2, i3);
    }
}

