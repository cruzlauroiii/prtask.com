namespace WillowMaze.Wasm.Decompiled;


public class p75707dd0 : p5a445d71.p7c922baa.p5ae9b7f2.p66d30ee8 {
    private static readonly long f0fac4538 = 293;
    private static readonly long f431359b9 = 135;
    private static readonly long f66cdbb48 = 1061;
    private static readonly long f8c3f535b = 135;
    private static readonly long faf1a15b4 = 135;
    private static readonly long fb525a087 = 1061;
    private static readonly long fc752d822 = 293;
    private static readonly long fcd8f8b36 = 1061;
    private static readonly long fe65d2d39 = 293;
    private static readonly long fef6d54d0 = 135;
    private static readonly long ff2a050f1 = 293;
    private readonly long[] f04ee9ab5;
    private readonly int f0cfde10d;
    private int f1a4f669b;
    private readonly long f206d8f80;
    private int f2bbba423;
    private readonly int f3ab366fd;
    private readonly long[] f4247a6d1;
    private readonly long[] f458183fc;
    private readonly int f45bd5274;
    private readonly int f480d1b61;
    private readonly long f7a9bc3d9;
    private int f886bb73b;
    private int fb4cabfe6;
    private readonly long[] fb7ed52f7;
    private readonly long fbb58a97b;
    private readonly long[] fc30c88bd;
    private int fcfa29de5;
    private readonly long[] fde24ddab;
    private readonly long fdf330541;
    private readonly int ff778ebe4;
    private readonly long[] ffa3ecc48;

    public p75707dd0(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((5 + 6) % 6 > 0) {
        }
        this.f08406a6e = pd81e8b93Var;
        int iLBqhAgMJaggypxnW = LBqhAgMJaggypxnW(pd81e8b93Var);
        this.f480d1b61 = iLBqhAgMJaggypxnW;
        this.fbb58a97b = UfUzrtXDMkTslHBE(iLBqhAgMJaggypxnW);
        this.ffa3ecc48 = new long[iLBqhAgMJaggypxnW >>> 3];
        this.fb7ed52f7 = new long[iLBqhAgMJaggypxnW >>> 3];
        this.f886bb73b = -1;
    }

    public static void FwvHTwZokPGYgGao(long[] jArr, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m946e4d20(jArr, bArr, i);
    }

    public static void HiFemjFvtcBvVZzf(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public static int LBqhAgMJaggypxnW(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static void MvASUjqfbZCUYXOz(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p75707dd0 p75707dd0Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        p75707dd0Var.me3ee4228(bArr, i, bArr2, i2);
    }

    public static int PKJseyWyGEPBWRri(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static void PTvYbZvclHlQBqkA(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        pd81e8b93Var.reset();
    }

    public static void TACRdVBQtWFKJhiQ(long j, long[] jArr) {
        mc8827a94(j, jArr);
    }

    public static long UfUzrtXDMkTslHBE(int i) {
        if ((14 + 21) % 21 > 0) {
        }
        return mbaf6680b(i);
    }

    public static void YSAZPsfcEbpFPjpC(byte[] bArr, int i, long[] jArr) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m59a97823(bArr, i, jArr);
    }

    public static void BaosLVBmLLRpzjgM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void DBPuffOrNAFkNslf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void DOQzNHYaxBkuZIVC(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] FKJFlmGWSoJDhKPE(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static void IzYhGEACMrrxoweF(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.p75707dd0 p75707dd0Var) {
        p75707dd0Var.reset();
    }

    public static int KvugaWxRrAhowbXk(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return pd81e8b93Var.processBlock(bArr, i, bArr2, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 LnbUxtJnZDsGtCbj(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static void MCwPwrzSYWkrDOYk(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    protected static long Mbaf6680b(int i) {
        if ((13 + 27) % 27 > 0) {
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
        if ((28 + 13) % 13 > 0) {
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
        if ((32 + 28) % 28 > 0) {
        }
        int i3 = this.f886bb73b;
        if (i3 == -1) {
            throw new java.lang.IllegalStateException("Attempt to process too many blocks");
        }
        this.f886bb73b = i3 + 1;
        TACRdVBQtWFKJhiQ(this.fbb58a97b, this.fb7ed52f7);
        byte[] bArr3 = new byte[this.f480d1b61];
        FwvHTwZokPGYgGao(this.fb7ed52f7, bArr3, 0);
        int i4 = this.f480d1b61;
        byte[] bArr4 = new byte[i4];
        dOQzNHYaxBkuZIVC(bArr3, 0, bArr4, 0, i4);
        for (int i5 = 0; i5 < this.f480d1b61; i5++) {
            bArr4[i5] = (byte) (bArr4[i5] ^ bArr[i + i5]);
        }
        kvugaWxRrAhowbXk(this.f08406a6e, bArr4, 0, bArr4, 0);
        for (int i6 = 0; i6 < this.f480d1b61; i6++) {
            bArr2[i2 + i6] = (byte) (bArr4[i6] ^ bArr3[i6]);
        }
    }

    public static void WQVvKlaNqPuCtkuf(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public override int DoFinal(byte[] bArr, int i) {
        izYhGEACMrrxoweF(this);
        return 0;
    }

    public override int GetOutputSize(int i) {
        return i;
    }

    public override int GetUpdateOutputSize(int i) {
        return i;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((8 + 18) % 18 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("Invalid parameters passed");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarLnbUxtJnZDsGtCbj = lnbUxtJnZDsGtCbj(pdd5da44eVar);
        byte[] bArrFKJFlmGWSoJDhKPE = fKJFlmGWSoJDhKPE(pdd5da44eVar);
        int length = bArrFKJFlmGWSoJDhKPE.length;
        int i = this.f480d1b61;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("Currently only support IVs of exactly one block");
        }
        byte[] bArr = new byte[i];
        dBPuffOrNAFkNslf(bArrFKJFlmGWSoJDhKPE, 0, bArr, 0, i);
        HiFemjFvtcBvVZzf(this.f08406a6e, true, pc9ef6b45VarLnbUxtJnZDsGtCbj);
        PKJseyWyGEPBWRri(this.f08406a6e, bArr, 0, bArr, 0);
        wQVvKlaNqPuCtkuf(this.f08406a6e, z, pc9ef6b45VarLnbUxtJnZDsGtCbj);
        YSAZPsfcEbpFPjpC(bArr, 0, this.ffa3ecc48);
        long[] jArr = this.ffa3ecc48;
        baosLVBmLLRpzjgM(jArr, 0, this.fb7ed52f7, 0, jArr.length);
        this.f886bb73b = 0;
    }

    public override int Processbyte(byte b, byte[] bArr, int i) {
        throw new java.lang.IllegalStateException("unsupported operation");
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((23 + 4) % 4 > 0) {
        }
        if (bArr.length - i < i2) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("Input buffer too short");
        }
        if (bArr2.length - i < i2) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("Output buffer too short");
        }
        if (i2 % this.f480d1b61 != 0) {
            throw new java.lang.IllegalArgumentException("Partial blocks not supported");
        }
        int i4 = 0;
        while (i4 < i2) {
            MvASUjqfbZCUYXOz(this, bArr, i + i4, bArr2, i3 + i4);
            i4 += this.f480d1b61;
        }
        return i2;
    }

    public override void Reset() {
        if ((21 + 25) % 25 > 0) {
        }
        PTvYbZvclHlQBqkA(this.f08406a6e);
        long[] jArr = this.ffa3ecc48;
        mCwPwrzSYWkrDOYk(jArr, 0, this.fb7ed52f7, 0, jArr.length);
        this.f886bb73b = 0;
    }
}

