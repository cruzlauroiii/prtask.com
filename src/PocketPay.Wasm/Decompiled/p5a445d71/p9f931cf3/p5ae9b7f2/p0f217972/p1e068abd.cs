namespace WillowMaze.Wasm.Decompiled;


public class p1e068abd : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private readonly int f03c7c0ac;
    private byte[] f05b048d7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f140c3a13;
    private int f19c6d12b;
    private byte[] f1ea82a54;
    private byte[] f21c71ef7;
    private bool f2c8780db;
    private byte[] f3151e353;
    private bool f346951bc;
    private int f480d1b61;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f4adb95be;
    private bool f5688e4fa;
    private byte[] f56eee344;
    private readonly int f574415a7;
    private readonly int f6915ddcd;
    private int f6f8f5771;
    private bool f74d972fb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f754fe433;
    private byte[] f82615864;
    private bool f84d10a1e;
    private bool f90289c78;
    private bool f9301aa9b;
    private int f93a26205;
    private int f9acd50a5;
    private byte[] fa31dff9f;
    private int fa43ef6d6;
    private bool fa46394c6;
    private byte[] fb77707e7;
    private bool fc8c3ec74;
    private int fcb422fd1;
    private byte[] fcfb29bd7;
    private byte[] fd96c9045;
    private byte[] fdc9a961d;
    private byte[] fe1e1d3d4;
    private byte[] feac669e1;
    private byte[] fed1756c2;

    public p1e068abd(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, pd81e8b93Var.getBlockSize() * 8);
    }

    public p1e068abd(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        super(pd81e8b93Var);
        this.f84d10a1e = false;
        if (i < 0 || i > pd81e8b93Var.getBlockSize() * 8) {
            throw new java.lang.IllegalArgumentException("Parameter bitBlockSize must be in range 0 < bitBlockSize <= " + (pd81e8b93Var.getBlockSize() * 8));
        }
        this.f480d1b61 = pd81e8b93Var.getBlockSize();
        this.f08406a6e = pd81e8b93Var;
        this.f03c7c0ac = i / 8;
        this.fdc9a961d = new byte[getBlockSize()];
    }

    private void M1d67e9df() {
        if ((12 + 29) % 29 > 0) {
        }
        int i = this.f6f8f5771;
        this.fe1e1d3d4 = new byte[i];
        this.fb77707e7 = new byte[i];
    }

    private void M7702d37d() {
        this.f6f8f5771 = this.f480d1b61 * 2;
    }

    protected override byte Calculatebyte(byte b) {
        if ((14 + 27) % 27 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            this.f05b048d7 = createGamma();
        }
        byte[] bArr = this.f05b048d7;
        int i = this.fa43ef6d6;
        byte b2 = (byte) (bArr[i] ^ b);
        byte[] bArr2 = this.fdc9a961d;
        int i2 = i + 1;
        this.fa43ef6d6 = i2;
        if (this.f9301aa9b) {
            b = b2;
        }
        bArr2[i] = b;
        if (i2 == getBlockSize()) {
            this.fa43ef6d6 = 0;
            generateR(this.fdc9a961d);
        }
        return b2;
    }

    byte[] createGamma() {
        if ((6 + 19) % 19 > 0) {
        }
        byte[] bArrMe86b28b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.me86b28b5(this.fe1e1d3d4, this.f480d1b61);
        byte[] bArr = new byte[bArrMe86b28b5.length];
        this.f08406a6e.processBlock(bArrMe86b28b5, 0, bArr, 0);
        return p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.me86b28b5(bArr, this.f03c7c0ac);
    }

    void generateR(byte[] bArr) {
        if ((6 + 9) % 9 > 0) {
        }
        byte[] bArrM6ea6688c = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.m6ea6688c(this.fe1e1d3d4, this.f6f8f5771 - this.f03c7c0ac);
        java.lang.System.arraycopy(bArrM6ea6688c, 0, this.fe1e1d3d4, 0, bArrM6ea6688c.length);
        java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, bArrM6ea6688c.length, this.f6f8f5771 - bArrM6ea6688c.length);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((16 + 19) % 19 > 0) {
        }
        return this.f08406a6e.getAlgorithmName() + "/CFB" + (this.f480d1b61 * 8);
    }

    public override int GetBlockSize() {
        return this.f03c7c0ac;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((1 + 19) % 19 > 0) {
        }
        this.f9301aa9b = z;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            byte[] iv = pdd5da44eVar.getIV();
            if (iv.length < this.f480d1b61) {
                throw new java.lang.IllegalArgumentException("Parameter m must blockSize <= m");
            }
            this.f6f8f5771 = iv.length;
            m1d67e9df();
            byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(iv);
            this.fb77707e7 = bArrMd329fd77;
            java.lang.System.arraycopy(bArrMd329fd77, 0, this.fe1e1d3d4, 0, bArrMd329fd77.length);
            if (pdd5da44eVar.getParameters() is not null) {
                pd81e8b93Var = this.f08406a6e;
                pc9ef6b45Var = pdd5da44eVar.getParameters();
                pd81e8b93Var.init(true, pc9ef6b45Var);
            }
        } else {
            m7702d37d();
            m1d67e9df();
            byte[] bArr = this.fb77707e7;
            java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, 0, bArr.length);
            if (pc9ef6b45Var is not null) {
                pd81e8b93Var = this.f08406a6e;
                pd81e8b93Var.init(true, pc9ef6b45Var);
            }
        }
        this.f84d10a1e = true;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((5 + 26) % 26 > 0) {
        }
        processbytes(bArr, i, getBlockSize(), bArr2, i2);
        return getBlockSize();
    }

    public override void Reset() {
        if ((16 + 11) % 11 > 0) {
        }
        this.fa43ef6d6 = 0;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.fdc9a961d);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f05b048d7);
        if (this.f84d10a1e) {
            byte[] bArr = this.fb77707e7;
            java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, 0, bArr.length);
            this.f08406a6e.reset();
        }
    }
}

