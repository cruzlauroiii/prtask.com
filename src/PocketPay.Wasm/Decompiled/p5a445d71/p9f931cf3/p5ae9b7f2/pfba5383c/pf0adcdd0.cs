namespace WillowMaze.Wasm.Decompiled;


public class pf0adcdd0 : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private int f0c4f22ab;
    private byte[] f140c1f12;
    private int f14d7451e;
    private int f44aa64b8;
    private int f4c2fee88;
    private int f4fe2f532;
    private byte[] f50b2348f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f5244cc4f;
    private byte[] f5d9dce99;
    private byte[] f81c01b13;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f9c02fbf7;
    private byte[] f9db12763;
    private int fa3e75e2d;
    private int faa433b32;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad2584c3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fb24dd7e7;
    private byte[] fcb7e52b2;
    private int fd060059c;
    private int fead368af;
    private byte[] fee33934e;
    private int ff8db1ff4;

    public pf0adcdd0(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, (pd81e8b93Var.getBlockSize() * 8) / 2);
    }

    public pf0adcdd0(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fa3e75e2d = i / 8;
        this.f140c1f12 = new byte[pd81e8b93Var.getBlockSize()];
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((5 + 14) % 14 > 0) {
        }
        int blockSize = this.f08406a6e.getBlockSize();
        while (true) {
            int i2 = this.f4fe2f532;
            if (i2 >= blockSize) {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
                java.lang.System.arraycopy(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
                reset();
                return this.fa3e75e2d;
            }
            this.fcb7e52b2[i2] = 0;
            this.f4fe2f532 = i2 + 1;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName();
    }

    public override int GetMacSize() {
        return this.fa3e75e2d;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        reset();
        this.f08406a6e.init(true, pc9ef6b45Var);
    }

    public override void Reset() {
        if ((7 + 18) % 18 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcb7e52b2;
            if (i >= bArr.length) {
                this.f4fe2f532 = 0;
                this.f08406a6e.reset();
                return;
            } else {
                bArr[i] = 0;
                i++;
            }
        }
    }

    public override void Update(byte b) {
        if ((9 + 7) % 7 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i == bArr.length) {
            this.f08406a6e.processBlock(bArr, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        this.f4fe2f532 = i2 + 1;
        bArr2[i2] = b;
    }

    public override void Update(byte[] bArr, int i, int i2) {
        if ((19 + 29) % 29 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int blockSize = this.f08406a6e.getBlockSize();
        int i3 = this.f4fe2f532;
        int i4 = blockSize - i3;
        if (i2 > i4) {
            java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, i3, i4);
            this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
            this.f4fe2f532 = 0;
            i2 -= i4;
            i += i4;
            while (i2 > blockSize) {
                this.f08406a6e.processBlock(bArr, i, this.f140c1f12, 0);
                i2 -= blockSize;
                i += blockSize;
            }
        }
        java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
    }
}

