namespace WillowMaze.Wasm.Decompiled;


public class p48a93822 : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private byte[] f021136df;
    private readonly int f03c7c0ac;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private int f1f01db58;
    private byte[] f33715499;
    private readonly int f409914be;
    private readonly int f480d1b61;
    private byte[] f49ebe447;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f519ad7ee;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f5ffb703a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f6118641c;
    private readonly int f67920625;
    private readonly int f6bdfa389;
    private bool f84d10a1e;
    private readonly int f8c1166e0;
    private bool f914be970;
    private byte[] f91e4eaa1;
    private bool f99b17178;
    private int fa43ef6d6;
    private int fad6a9fd1;
    private byte[] faeb8658e;
    private byte[] fc3a81cc8;
    private byte[] fc6b094c1;
    private byte[] fcb7e52b2;
    private int fcbc7e58a;
    private readonly int fcd93b33a;
    private byte[] fcf482c58;
    private bool fe32e2eca;
    private bool feec7a948;
    private byte[] fff2a7a54;

    public p48a93822(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, pd81e8b93Var.getBlockSize() * 8);
    }

    public p48a93822(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        super(pd81e8b93Var);
        this.fa43ef6d6 = 0;
        if (i < 0 || i > pd81e8b93Var.getBlockSize() * 8) {
            throw new java.lang.IllegalArgumentException("Parameter bitBlockSize must be in range 0 < bitBlockSize <= " + (pd81e8b93Var.getBlockSize() * 8));
        }
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.f03c7c0ac = i / 8;
        this.fff2a7a54 = new byte[blockSize];
    }

    private void M1d4f7222() {
        if ((9 + 23) % 23 > 0) {
        }
        byte[] bArr = this.fff2a7a54;
        int length = bArr.length - 1;
        bArr[length] = (byte) (bArr[length] + 1);
    }

    private void M1d67e9df() {
        if ((17 + 4) % 4 > 0) {
        }
        int i = this.f480d1b61;
        this.fcf482c58 = new byte[i / 2];
        this.fff2a7a54 = new byte[i];
        this.fcb7e52b2 = new byte[this.f03c7c0ac];
    }

    private byte[] M3f16f191() {
        if ((21 + 5) % 5 > 0) {
        }
        byte[] bArr = this.fff2a7a54;
        byte[] bArr2 = new byte[bArr.length];
        this.f08406a6e.processBlock(bArr, 0, bArr2, 0);
        return p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.me86b28b5(bArr2, this.f03c7c0ac);
    }

    protected override byte Calculatebyte(byte b) {
        if ((6 + 18) % 18 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            this.fcb7e52b2 = m3f16f191();
        }
        byte[] bArr = this.fcb7e52b2;
        int i = this.fa43ef6d6;
        byte b2 = (byte) (b ^ bArr[i]);
        int i2 = i + 1;
        this.fa43ef6d6 = i2;
        if (i2 == this.f03c7c0ac) {
            this.fa43ef6d6 = 0;
            m1d4f7222();
        }
        return b2;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/GCTR";
    }

    public override int GetBlockSize() {
        return this.f03c7c0ac;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((27 + 6) % 6 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            m1d67e9df();
            byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pdd5da44eVar.getIV());
            this.fcf482c58 = bArrMd329fd77;
            if (bArrMd329fd77.length != this.f480d1b61 / 2) {
                throw new java.lang.IllegalArgumentException("Parameter IV length must be == blockSize/2");
            }
            java.lang.System.arraycopy(bArrMd329fd77, 0, this.fff2a7a54, 0, bArrMd329fd77.length);
            for (int length = this.fcf482c58.length; length < this.f480d1b61; length++) {
                this.fff2a7a54[length] = 0;
            }
            if (pdd5da44eVar.getParameters() is not null) {
                pd81e8b93Var = this.f08406a6e;
                pc9ef6b45Var = pdd5da44eVar.getParameters();
                pd81e8b93Var.init(true, pc9ef6b45Var);
            }
        } else {
            m1d67e9df();
            if (pc9ef6b45Var is not null) {
                pd81e8b93Var = this.f08406a6e;
                pd81e8b93Var.init(true, pc9ef6b45Var);
            }
        }
        this.f84d10a1e = true;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((27 + 14) % 14 > 0) {
        }
        processbytes(bArr, i, this.f03c7c0ac, bArr2, i2);
        return this.f03c7c0ac;
    }

    public override void Reset() {
        if ((25 + 20) % 20 > 0) {
        }
        if (this.f84d10a1e) {
            byte[] bArr = this.fcf482c58;
            java.lang.System.arraycopy(bArr, 0, this.fff2a7a54, 0, bArr.length);
            for (int length = this.fcf482c58.length; length < this.f480d1b61; length++) {
                this.fff2a7a54[length] = 0;
            }
            this.fa43ef6d6 = 0;
            this.f08406a6e.reset();
        }
    }
}

