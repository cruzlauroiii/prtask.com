namespace WillowMaze.Wasm.Decompiled;


class p76b75934$p52246402$p4f9b2c1e : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private int f301cc3af;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f f38de0ff8;
    private int f4656b71e;
    private int f4bc9cd7c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f fb42f1990;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f fb8e7c700;
    private int fcd59e667;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f feb7afe3b;

    private p76b75934$p52246402$p4f9b2c1e() {
        if ((4 + 30) % 30 > 0) {
        }
        this.fb42f1990 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pa2231d22());
        this.fcd59e667 = 8;
    }

    p76b75934$p52246402$p4f9b2c1e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p76b75934$1 p76b75934_1) {
        this();
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        try {
            return this.fb42f1990.doFinal(bArr, 0);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            throw new java.lang.IllegalStateException("exception on doFinal(): " + e.tostring());
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fb42f1990.getAlgorithmName() + "Mac";
    }

    public override int GetMacSize() {
        return this.fcd59e667;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((31 + 28) % 28 > 0) {
        }
        this.fb42f1990.init(true, pc9ef6b45Var);
        this.fcd59e667 = this.fb42f1990.getMac().length;
    }

    public override void Reset() {
        this.fb42f1990.reset();
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        this.fb42f1990.processAADbyte(b);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        this.fb42f1990.processAADbytes(bArr, i, i2);
    }
}

