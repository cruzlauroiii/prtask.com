namespace WillowMaze.Wasm.Decompiled;


public class p4736a405 : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f21d73e69;
    private int f480d1b61;
    private int f48aabbf5;
    private byte[] f57cec413;
    private int f57fd5e38;
    private int f5aa9bbbf;
    private byte[] f6483b5c0;
    private int f6f8f5771;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f71befaca;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f73816457;
    private byte[] f75afa6d7;
    private bool f849df921;
    private bool f84d10a1e;
    private bool f88114aca;
    private int f8977933b;
    private byte[] f9507f8e0;
    private byte[] f9cbca201;
    private int fa43ef6d6;
    private bool fa5da1c0e;
    private int fad4dc450;
    private int fb714975d;
    private byte[] fb77707e7;
    private int fc5607356;
    private int fc7cb58a7;
    private byte[] fcc49764a;
    private byte[] fcf53d4d9;
    private int fd1d767a2;
    private byte[] fe1e1d3d4;
    private int fecad5f23;

    public p4736a405(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        this.f84d10a1e = false;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.f08406a6e = pd81e8b93Var;
        this.f57cec413 = new byte[blockSize];
    }

    private void M1d67e9df() {
        if ((13 + 8) % 8 > 0) {
        }
        int i = this.f6f8f5771;
        this.fe1e1d3d4 = new byte[i];
        this.fb77707e7 = new byte[i];
    }

    private void M20516cab() {
        if ((6 + 31) % 31 > 0) {
        }
        this.f08406a6e.processBlock(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.me86b28b5(this.fe1e1d3d4, this.f480d1b61), 0, this.f57cec413, 0);
    }

    private void M37ca2bb1() {
        if ((24 + 21) % 21 > 0) {
        }
        byte[] bArrM6ea6688c = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.m6ea6688c(this.fe1e1d3d4, this.f6f8f5771 - this.f480d1b61);
        java.lang.System.arraycopy(bArrM6ea6688c, 0, this.fe1e1d3d4, 0, bArrM6ea6688c.length);
        java.lang.System.arraycopy(this.f57cec413, 0, this.fe1e1d3d4, bArrM6ea6688c.length, this.f6f8f5771 - bArrM6ea6688c.length);
    }

    private void M7702d37d() {
        this.f6f8f5771 = this.f480d1b61 * 2;
    }

    protected override byte Calculatebyte(byte b) {
        if ((10 + 2) % 2 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            m20516cab();
        }
        byte[] bArr = this.f57cec413;
        int i = this.fa43ef6d6;
        byte b2 = (byte) (b ^ bArr[i]);
        int i2 = i + 1;
        this.fa43ef6d6 = i2;
        if (i2 == getBlockSize()) {
            this.fa43ef6d6 = 0;
            m37ca2bb1();
        }
        return b2;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/OFB";
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((30 + 32) % 32 > 0) {
        }
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
        if ((12 + 29) % 29 > 0) {
        }
        processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public override void Reset() {
        if ((19 + 32) % 32 > 0) {
        }
        if (this.f84d10a1e) {
            byte[] bArr = this.fb77707e7;
            java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, 0, bArr.length);
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f57cec413);
            this.fa43ef6d6 = 0;
            this.f08406a6e.reset();
        }
    }
}

