namespace WillowMaze.Wasm.Decompiled;


public class p774bd99b : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    protected static readonly int f3fa36c63 = 1;
    protected static readonly int f752cb047 = 1;
    protected static readonly int fa481a724 = 1;
    protected static readonly int fa8ecd0ce = 1;
    protected static readonly int fa9a0dd72 = 1;
    private bool f0b3ac2b2;
    private readonly int f0fdf829b;
    private bool f113ba9f1;
    private readonly int f480d1b61;
    private bool fdb1687e1;
    private bool fdda42886;
    private bool fdf555a26;
    private readonly int fe3b007a1;

    public p774bd99b() {
        this(1);
    }

    public p774bd99b(int i) {
        this.f480d1b61 = i;
    }

    public override java.lang.string GetAlgorithmName() {
        return "Null";
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.fdb1687e1 = true;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((8 + 5) % 5 > 0) {
        }
        if (!this.fdb1687e1) {
            throw new java.lang.IllegalStateException("Null engine not initialised");
        }
        int i3 = this.f480d1b61;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int i4 = 0;
        while (true) {
            int i5 = this.f480d1b61;
            if (i4 >= i5) {
                return i5;
            }
            bArr2[i2 + i4] = bArr[i + i4];
            i4++;
        }
    }

    public override void Reset() {
    }
}

