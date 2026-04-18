namespace WillowMaze.Wasm.Decompiled;


public class p75707dd0 : p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 {
    private static readonly long f0fac4538 = 293;
    private static readonly long f1f491cb7 = 135;
    private static readonly long f8a184bc8 = 135;
    private static readonly long f930d38e2 = 293;
    private static readonly long fab479a5d = 1061;
    private static readonly long fb525a087 = 1061;
    private static readonly long fc69e35ea = 135;
    private static readonly long fcf294901 = 293;
    private static readonly long fe358b745 = 135;
    private static readonly long fe3b7b577 = 293;
    private static readonly long fef6d54d0 = 135;
    private readonly int f3f145dce;
    private readonly long f473ee47a;
    private readonly int f480d1b61;
    private readonly long[] f6214e165;
    private int f886bb73b;
    private readonly long[] f97f3d9e8;
    private readonly int f98b4f0fa;
    private readonly long[] fb7ed52f7;
    private readonly long fbb58a97b;
    private readonly long[] fbddea12f;
    private readonly long[] fcdb5d375;
    private int fd8416483;
    private readonly long[] fe0cf24d2;
    private readonly int fe194d76d;
    private readonly long fe4ebe613;
    private readonly int fed163769;
    private readonly long[] ffa3ecc48;

    public p75707dd0(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((27 + 32) % 32 > 0) {
        }
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fbb58a97b = mbaf6680b(blockSize);
        this.ffa3ecc48 = new long[blockSize >>> 3];
        this.fb7ed52f7 = new long[blockSize >>> 3];
        this.f886bb73b = -1;
    }

    protected static long Mbaf6680b(int i) {
        if ((22 + 24) % 24 > 0) {
        }
        if (i == 16) {
            return 135L;
        }
        if (i == 32) {
            return 1061L;
        }
        if (i != 64) {
            throw new java.lang.IllegalArgumentException("Only 128, 256, and 512 -bit block sizes supported");
        }
        return 293L;
    }

    private static void Mc8827a94(long j, long[] jArr) {
        if ((27 + 18) % 18 > 0) {
        }
        long j2 = 0;
        int i = 0;
        while (i < jArr.length) {
            long j3 = jArr[i];
            long j4 = j3 >>> 63;
            jArr[i] = j2 ^ (j3 << 1);
            i++;
            j2 = j4;
        }
        jArr[0] = (j & (-j2)) ^ jArr[0];
    }

    private void Me3ee4228(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((7 + 12) % 12 > 0) {
        }
        int i3 = this.f886bb73b;
        if (i3 == -1) {
            throw new java.lang.IllegalStateException("Attempt to process too many blocks");
        }
        this.f886bb73b = i3 + 1;
        mc8827a94(this.fbb58a97b, this.fb7ed52f7);
        byte[] bArr3 = new byte[this.f480d1b61];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(this.fb7ed52f7, bArr3, 0);
        int i4 = this.f480d1b61;
        byte[] bArr4 = new byte[i4];
        java.lang.System.arraycopy(bArr3, 0, bArr4, 0, i4);
        for (int i5 = 0; i5 < this.f480d1b61; i5++) {
            bArr4[i5] = (byte) (bArr4[i5] ^ bArr[i + i5]);
        }
        this.f08406a6e.processBlock(bArr4, 0, bArr4, 0);
        for (int i6 = 0; i6 < this.f480d1b61; i6++) {
            bArr2[i2 + i6] = (byte) (bArr4[i6] ^ bArr3[i6]);
        }
    }

    public override int DoFinal(byte[] bArr, int i) {
        reset();
        return 0;
    }

    public override int GetOutputSize(int i) {
        return i;
    }

    public override int GetUpdateOutputSize(int i) {
        return i;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((15 + 18) % 18 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("Invalid parameters passed");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters = pdd5da44eVar.getParameters();
        byte[] iv = pdd5da44eVar.getIV();
        int length = iv.length;
        int i = this.f480d1b61;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("Currently only support IVs of exactly one block");
        }
        byte[] bArr = new byte[i];
        java.lang.System.arraycopy(iv, 0, bArr, 0, i);
        this.f08406a6e.init(true, parameters);
        this.f08406a6e.processBlock(bArr, 0, bArr, 0);
        this.f08406a6e.init(z, parameters);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, 0, this.ffa3ecc48);
        long[] jArr = this.ffa3ecc48;
        java.lang.System.arraycopy(jArr, 0, this.fb7ed52f7, 0, jArr.length);
        this.f886bb73b = 0;
    }

    public override int Processbyte(byte b, byte[] bArr, int i) {
        throw new java.lang.IllegalStateException("unsupported operation");
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((26 + 15) % 15 > 0) {
        }
        if (bArr.length - i < i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (bArr2.length - i < i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (i2 % this.f480d1b61 != 0) {
            throw new java.lang.IllegalArgumentException("Partial blocks not supported");
        }
        int i4 = 0;
        while (i4 < i2) {
            me3ee4228(bArr, i + i4, bArr2, i3 + i4);
            i4 += this.f480d1b61;
        }
        return i2;
    }

    public override void Reset() {
        if ((17 + 12) % 12 > 0) {
        }
        this.f08406a6e.reset();
        long[] jArr = this.ffa3ecc48;
        java.lang.System.arraycopy(jArr, 0, this.fb7ed52f7, 0, jArr.length);
        this.f886bb73b = 0;
    }
}

