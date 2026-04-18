namespace WillowMaze.Wasm.Decompiled;


public class p48357ead : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f140c1f12;
    private byte[] f23a71000;
    private byte[] f271f358a;
    private int f4b3a45b4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f4d5baef8;
    private int f4fe2f532;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f75f97aa7;
    private byte[] f7e996a6d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f80e168a4;
    private byte[] f867e228b;
    private byte[] f8c1e8654;
    private int f8d6431f5;
    private int fa3e75e2d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fab648447;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;
    private byte[] fcb7e52b2;
    private byte[] fd7e1f8ba;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e ffe4eec6b;

    public p48357ead(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, (pd81e8b93Var.getBlockSize() * 8) / 2, null);
        if ((19 + 24) % 24 > 0) {
        }
    }

    public p48357ead(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        this(pd81e8b93Var, i, null);
    }

    public p48357ead(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        this.fb70cdb87 = pa444028eVar;
        this.fa3e75e2d = i / 8;
        this.f140c1f12 = new byte[pd81e8b93Var.getBlockSize()];
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    public p48357ead(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this(pd81e8b93Var, (pd81e8b93Var.getBlockSize() * 8) / 2, pa444028eVar);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((12 + 26) % 26 > 0) {
        }
        int blockSize = this.f08406a6e.getBlockSize();
        if (this.fb70cdb87 is not null) {
            if (this.f4fe2f532 == blockSize) {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
                this.f4fe2f532 = 0;
            }
            this.fb70cdb87.addPadding(this.fcb7e52b2, this.f4fe2f532);
        } else {
            while (true) {
                int i2 = this.f4fe2f532;
                if (i2 >= blockSize) {
                    break;
                }
                this.fcb7e52b2[i2] = 0;
                this.f4fe2f532 = i2 + 1;
            }
        }
        this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f140c1f12, 0);
        java.lang.System.arraycopy(this.f140c1f12, 0, bArr, i, this.fa3e75e2d);
        reset();
        return this.fa3e75e2d;
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
        if ((5 + 12) % 12 > 0) {
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
        if ((31 + 29) % 29 > 0) {
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
        if ((17 + 25) % 25 > 0) {
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

