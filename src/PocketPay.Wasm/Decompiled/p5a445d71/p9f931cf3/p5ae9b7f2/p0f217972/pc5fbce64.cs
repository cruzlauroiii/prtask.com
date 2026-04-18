namespace WillowMaze.Wasm.Decompiled;


public class pc5fbce64 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f101b660a;
    private int f480d1b61;
    private byte[] f4dd0e646;
    private int f598082c8;
    private int f59afa81b;
    private int f5a27341c;
    private bool f624f2eac;
    private bool f7148bf34;
    private bool f72bab29c;
    private bool f74fa6a33;
    private bool f78e3449f;
    private byte[] f7b9491a1;
    private byte[] f84fe5136;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f852b015d;
    private byte[] f97dce255;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f9b3461e2;
    private byte[] fcc8eb5bb;
    private byte[] fcf482c58;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fe3f1ad1f;
    private byte[] ff7c54bb3;
    private byte[] fffca4608;

    public pc5fbce64(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fcf482c58 = new byte[blockSize];
        this.fcc8eb5bb = new byte[blockSize];
        this.f97dce255 = new byte[blockSize];
    }

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((11 + 22) % 22 > 0) {
        }
        if (this.f480d1b61 + i > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        for (int i3 = 0; i3 < this.f480d1b61; i3++) {
            byte[] bArr3 = this.fcc8eb5bb;
            bArr3[i3] = (byte) (bArr3[i3] ^ bArr[i + i3]);
        }
        int iProcessBlock = this.f08406a6e.processBlock(this.fcc8eb5bb, 0, bArr2, i2);
        byte[] bArr4 = this.fcc8eb5bb;
        java.lang.System.arraycopy(bArr2, i2, bArr4, 0, bArr4.length);
        return iProcessBlock;
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((15 + 11) % 11 > 0) {
        }
        int i3 = this.f480d1b61;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        java.lang.System.arraycopy(bArr, i, this.f97dce255, 0, i3);
        int iProcessBlock = this.f08406a6e.processBlock(bArr, i, bArr2, i2);
        for (int i4 = 0; i4 < this.f480d1b61; i4++) {
            int i5 = i2 + i4;
            bArr2[i5] = (byte) (bArr2[i5] ^ this.fcc8eb5bb[i4]);
        }
        byte[] bArr3 = this.fcc8eb5bb;
        this.fcc8eb5bb = this.f97dce255;
        this.f97dce255 = bArr3;
        return iProcessBlock;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/CBC";
    }

    public override int GetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((31 + 1) % 1 > 0) {
        }
        bool z2 = this.f78e3449f;
        this.f78e3449f = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            byte[] iv = pdd5da44eVar.getIV();
            if (iv.length != this.f480d1b61) {
                throw new java.lang.IllegalArgumentException("initialisation vector must be the same length as block size");
            }
            java.lang.System.arraycopy(iv, 0, this.fcf482c58, 0, iv.length);
            reset();
            if (pdd5da44eVar.getParameters() is null) {
                if (z2 != z) {
                    throw new java.lang.IllegalArgumentException("cannot change encrypting state without providing key.");
                }
                return;
            } else {
                pd81e8b93Var = this.f08406a6e;
                pc9ef6b45Var = pdd5da44eVar.getParameters();
            }
        } else {
            reset();
            if (pc9ef6b45Var is null) {
                if (z2 != z) {
                    throw new java.lang.IllegalArgumentException("cannot change encrypting state without providing key.");
                }
                return;
            }
            pd81e8b93Var = this.f08406a6e;
        }
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return !this.f78e3449f ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
        if ((9 + 19) % 19 > 0) {
        }
        byte[] bArr = this.fcf482c58;
        java.lang.System.arraycopy(bArr, 0, this.fcc8eb5bb, 0, bArr.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f97dce255, (byte) 0);
        this.f08406a6e.reset();
    }
}

