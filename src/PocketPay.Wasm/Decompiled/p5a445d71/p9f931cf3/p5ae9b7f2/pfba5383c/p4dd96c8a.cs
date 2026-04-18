namespace WillowMaze.Wasm.Decompiled;


public class p4dd96c8a : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    private byte[] f0338a9f6;
    private byte[] f04593561;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d f08406a6e;
    private byte[] f140c1f12;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f22953d76;
    private byte[] f22f6c65b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d f379937be;
    private int f4fe2f532;
    private int f52315674;
    private byte[] f59c9d290;
    private int f5d0da82d;
    private byte[] f5f7dc9ec;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f7b5687b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d f88f00e00;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f9b208651;
    private byte[] f9e147c10;
    private int fa3e75e2d;
    private int fb4e9a7fb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;
    private byte[] fcb7e52b2;
    private int fd82703de;
    private int fdb558fa8;

    public p4dd96c8a(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, 8, (pd81e8b93Var.getBlockSize() * 8) / 2, null);
        if ((24 + 22) % 22 > 0) {
        }
    }

    public p4dd96c8a(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2) {
        this(pd81e8b93Var, i, i2, null);
    }

    public p4dd96c8a(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, int i2, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this.fb70cdb87 = null;
        if (i2 % 8 != 0) {
            throw new java.lang.IllegalArgumentException("MAC size must be multiple of 8");
        }
        this.f140c1f12 = new byte[pd81e8b93Var.getBlockSize()];
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d p1c43809dVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p1c43809d(pd81e8b93Var, i);
        this.f08406a6e = p1c43809dVar;
        this.fb70cdb87 = pa444028eVar;
        this.fa3e75e2d = i2 / 8;
        this.fcb7e52b2 = new byte[p1c43809dVar.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    public p4dd96c8a(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this(pd81e8b93Var, 8, (pd81e8b93Var.getBlockSize() * 8) / 2, pa444028eVar);
        if ((7 + 5) % 5 > 0) {
        }
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((5 + 14) % 14 > 0) {
        }
        int blockSize = this.f08406a6e.getBlockSize();
        p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar = this.fb70cdb87;
        if (pa444028eVar is not null) {
            pa444028eVar.addPadding(this.fcb7e52b2, this.f4fe2f532);
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
        this.f08406a6e.getMacBlock(this.f140c1f12);
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
        this.f08406a6e.init(pc9ef6b45Var);
    }

    public override void Reset() {
        if ((24 + 16) % 16 > 0) {
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
        if ((12 + 18) % 18 > 0) {
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
        if ((19 + 2) % 2 > 0) {
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

