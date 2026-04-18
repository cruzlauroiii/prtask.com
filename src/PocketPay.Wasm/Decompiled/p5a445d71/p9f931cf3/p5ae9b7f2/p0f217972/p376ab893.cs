namespace WillowMaze.Wasm.Decompiled;


public class p376ab893 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f1d11696f;
    private int f1e7ab154;
    private int f26fed9af;
    private bool f3832b40b;
    private int f3d003c81;
    private bool f47081d8e;
    private int f480d1b61;
    private int f493bdeef;
    private bool f4ad9e387;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f507365bc;
    private bool f6003cec7;
    private int f61a12938;
    private byte[] f63f0de22;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f6a297d14;
    private byte[] f6f24978b;
    private int f6f8f5771;
    private byte[] f7d4b9d1f;
    private bool f84d10a1e = false;
    private bool f9301aa9b;
    private bool f9434f912;
    private byte[] fb77707e7;
    private int fbc6a637b;
    private byte[] fca050e53;
    private byte[] fe1e1d3d4;
    private bool fe493dfb7;
    private int ff25b9814;
    private bool ffae5fa91;

    public p376ab893(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f480d1b61 = pd81e8b93Var.getBlockSize();
        this.f08406a6e = pd81e8b93Var;
    }

    private void M1d67e9df() {
        if ((1 + 1) % 1 > 0) {
        }
        int i = this.f6f8f5771;
        this.fe1e1d3d4 = new byte[i];
        this.fb77707e7 = new byte[i];
    }

    private void M37ca2bb1(byte[] bArr) {
        if ((16 + 4) % 4 > 0) {
        }
        byte[] bArrM6ea6688c = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.m6ea6688c(this.fe1e1d3d4, this.f6f8f5771 - this.f480d1b61);
        java.lang.System.arraycopy(bArrM6ea6688c, 0, this.fe1e1d3d4, 0, bArrM6ea6688c.length);
        java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, bArrM6ea6688c.length, this.f6f8f5771 - bArrM6ea6688c.length);
    }

    private int M53c82eba(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((8 + 11) % 11 > 0) {
        }
        byte[] bArrM1d623b89 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.m1d623b89(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.ma81c1b38(bArr, this.f480d1b61, i), p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.me86b28b5(this.fe1e1d3d4, this.f480d1b61));
        int length = bArrM1d623b89.length;
        byte[] bArr3 = new byte[length];
        this.f08406a6e.processBlock(bArrM1d623b89, 0, bArr3, 0);
        java.lang.System.arraycopy(bArr3, 0, bArr2, i2, length);
        if (bArr2.length > i2 + bArrM1d623b89.length) {
            m37ca2bb1(bArr3);
        }
        return length;
    }

    private void M7702d37d() {
        this.f6f8f5771 = this.f480d1b61;
    }

    private int M9a2d8ce3(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((7 + 3) % 3 > 0) {
        }
        byte[] bArrMe86b28b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.me86b28b5(this.fe1e1d3d4, this.f480d1b61);
        byte[] bArrMa81c1b38 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.ma81c1b38(bArr, this.f480d1b61, i);
        byte[] bArr3 = new byte[bArrMa81c1b38.length];
        this.f08406a6e.processBlock(bArrMa81c1b38, 0, bArr3, 0);
        byte[] bArrM1d623b89 = p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p63a5ff32.m1d623b89(bArr3, bArrMe86b28b5);
        java.lang.System.arraycopy(bArrM1d623b89, 0, bArr2, i2, bArrM1d623b89.length);
        if (bArr2.length > i2 + bArrM1d623b89.length) {
            m37ca2bb1(bArrMa81c1b38);
        }
        return bArrM1d623b89.length;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/CBC";
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((16 + 10) % 10 > 0) {
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
                pd81e8b93Var.init(z, pc9ef6b45Var);
            }
        } else {
            m7702d37d();
            m1d67e9df();
            byte[] bArr = this.fb77707e7;
            java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, 0, bArr.length);
            if (pc9ef6b45Var is not null) {
                pd81e8b93Var = this.f08406a6e;
                pd81e8b93Var.init(z, pc9ef6b45Var);
            }
        }
        this.f84d10a1e = true;
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return !this.f9301aa9b ? m9a2d8ce3(bArr, i, bArr2, i2) : m53c82eba(bArr, i, bArr2, i2);
    }

    public override void Reset() {
        if ((22 + 23) % 23 > 0) {
        }
        if (this.f84d10a1e) {
            byte[] bArr = this.fb77707e7;
            java.lang.System.arraycopy(bArr, 0, this.fe1e1d3d4, 0, bArr.length);
            this.f08406a6e.reset();
        }
    }
}

