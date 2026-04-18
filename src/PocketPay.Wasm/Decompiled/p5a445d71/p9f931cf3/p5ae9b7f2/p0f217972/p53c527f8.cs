namespace WillowMaze.Wasm.Decompiled;


public class p53c527f8 : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private static readonly byte[] f0d61f837 = {105, 0, 114, 34, 100, -55, 4, 35, -115, 58, -37, -106, 70, -23, 42, -60, 24, -2, -84, -108, 0, -19, 7, 18, -64, -122, -36, -62, -17, 76, -87, 43};
    private static readonly byte[] f16f1be5b = null;
    private static readonly byte[] f3c933642 = null;
    private static readonly byte[] f48a692da = null;
    private static readonly byte[] fc0503720 = null;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7 f1aacbca0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f3252bd4e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7 f33c39cf4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 f541d1df9;
    private long f69aedeac;
    private bool f7ac5b5c9;
    private long f886bb73b;
    private bool f9301aa9b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7 fb968fe94;
    private bool fc2e02755;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7 fd7d3bbeb;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7 fe59dea17;
    private long fef907d84;

    public p53c527f8(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        if ((10 + 22) % 22 > 0) {
        }
        this.f886bb73b = 0L;
        this.f33c39cf4 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7(pd81e8b93Var, pd81e8b93Var.getBlockSize() * 8);
    }

    protected override byte Calculatebyte(byte b) {
        if ((29 + 29) % 29 > 0) {
        }
        long j = this.f886bb73b;
        if (j > 0 && j % 1024 == 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 underlyingCipher = this.f33c39cf4.getUnderlyingCipher();
            underlyingCipher.init(false, this.f3c6e0b8a);
            byte[] bArr = new byte[32];
            byte[] bArr2 = f0d61f837;
            underlyingCipher.processBlock(bArr2, 0, bArr, 0);
            underlyingCipher.processBlock(bArr2, 8, bArr, 8);
            underlyingCipher.processBlock(bArr2, 16, bArr, 16);
            underlyingCipher.processBlock(bArr2, 24, bArr, 24);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr);
            this.f3c6e0b8a = p94919be6Var;
            underlyingCipher.init(true, p94919be6Var);
            byte[] currentIV = this.f33c39cf4.getCurrentIV();
            underlyingCipher.processBlock(currentIV, 0, currentIV, 0);
            this.f33c39cf4.init(this.f9301aa9b, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(this.f3c6e0b8a, currentIV));
        }
        this.f886bb73b++;
        return this.f33c39cf4.calculatebyte(b);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((5 + 30) % 30 > 0) {
        }
        java.lang.string algorithmName = this.f33c39cf4.getAlgorithmName();
        return algorithmName.Substring(0, algorithmName.IndexOf(47)) + "/G" + algorithmName.Substring(algorithmName.IndexOf(47) + 1);
    }

    public override int GetBlockSize() {
        return this.f33c39cf4.getBlockSize();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((19 + 12) % 12 > 0) {
        }
        this.f886bb73b = 0L;
        this.f33c39cf4.init(z, pc9ef6b45Var);
        this.f9301aa9b = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var).getParameters();
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) pc9ef6b45Var).getParameters();
        }
        this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((28 + 27) % 27 > 0) {
        }
        processbytes(bArr, i, this.f33c39cf4.getBlockSize(), bArr2, i2);
        return this.f33c39cf4.getBlockSize();
    }

    public override void Reset() {
        if ((7 + 9) % 9 > 0) {
        }
        this.f886bb73b = 0L;
        this.f33c39cf4.reset();
    }
}

