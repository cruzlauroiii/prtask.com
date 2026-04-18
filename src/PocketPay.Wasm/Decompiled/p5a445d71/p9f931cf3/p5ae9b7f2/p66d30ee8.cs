namespace WillowMaze.Wasm.Decompiled;


public class p66d30ee8 {
    protected bool f01f64f95;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    protected byte[] f26ee9b25;
    protected bool f2f61baf8;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f30beb4dc;
    protected int f3efeb276;
    protected bool f4f02cab3;
    protected int f4fe2f532;
    protected bool f9301aa9b;
    protected int f9c9df21c;
    protected bool fa46df6f8;
    protected byte[] fcb7e52b2;
    protected bool fd2268a9d;
    protected bool fdc78d261;
    protected bool fde1cde13;
    protected int fe945aced;

    protected p66d30ee8() {
    }

    public p66d30ee8(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((17 + 1) % 1 > 0) {
        }
        this.f08406a6e = pd81e8b93Var;
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        bool z = false;
        this.f4fe2f532 = 0;
        java.lang.string algorithmName = pd81e8b93Var.getAlgorithmName();
        int iIndexOf = algorithmName.IndexOf(47) + 1;
        bool z2 = iIndexOf > 0 && algorithmName.StartsWith("PGP", iIndexOf);
        this.f01f64f95 = z2;
        if (z2 || (pd81e8b93Var is p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d)) {
            this.fa46df6f8 = true;
            return;
        }
        if (iIndexOf > 0 && algorithmName.StartsWith("OpenPGP", iIndexOf)) {
            z = true;
        }
        this.fa46df6f8 = z;
    }

    public int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((31 + 19) % 19 > 0) {
        }
        try {
            int i2 = this.f4fe2f532;
            if (i + i2 > bArr.length) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short for doFinal()");
            }
            int i3 = 0;
            if (i2 != 0) {
                if (!this.fa46df6f8) {
                    throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("data not block size aligned");
                }
                p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.f08406a6e;
                byte[] bArr2 = this.fcb7e52b2;
                pd81e8b93Var.processBlock(bArr2, 0, bArr2, 0);
                int i4 = this.f4fe2f532;
                this.f4fe2f532 = 0;
                java.lang.System.arraycopy(this.fcb7e52b2, 0, bArr, i, i4);
                i3 = i4;
            }
            reset();
            return i3;
        } catch (java.lang.Exception th) {
            reset();
            throw th;
        }
    }

    public int GetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    public int GetOutputSize(int i) {
        return i + this.f4fe2f532;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public int GetUpdateOutputSize(int i) {
        int length;
        int length2;
        int i2 = i + this.f4fe2f532;
        if (this.f01f64f95) {
            if (this.f9301aa9b) {
                length2 = (i2 % this.fcb7e52b2.length) - (this.f08406a6e.getBlockSize() + 2);
            } else {
                length = this.fcb7e52b2.length;
            }
            return i2 - length2;
        }
        length = this.fcb7e52b2.length;
        length2 = i2 % length;
        return i2 - length2;
    }

    public void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f9301aa9b = z;
        reset();
        this.f08406a6e.init(z, pc9ef6b45Var);
    }

    public int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((28 + 30) % 30 > 0) {
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        int i3 = i2 + 1;
        this.f4fe2f532 = i3;
        bArr2[i2] = b;
        if (i3 != bArr2.length) {
            return 0;
        }
        int iProcessBlock = this.f08406a6e.processBlock(bArr2, 0, bArr, i);
        this.f4fe2f532 = 0;
        return iProcessBlock;
    }

    public int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int iProcessBlock;
        if ((21 + 23) % 23 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int blockSize = getBlockSize();
        int updateOutputSize = getUpdateOutputSize(i2);
        if (updateOutputSize > 0 && updateOutputSize + i3 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        byte[] bArr3 = this.fcb7e52b2;
        int length = bArr3.length;
        int i4 = this.f4fe2f532;
        int i5 = length - i4;
        if (i2 <= i5) {
            iProcessBlock = 0;
        } else {
            java.lang.System.arraycopy(bArr, i, bArr3, i4, i5);
            iProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, i3);
            this.f4fe2f532 = 0;
            i2 -= i5;
            i += i5;
            while (i2 > this.fcb7e52b2.length) {
                iProcessBlock += this.f08406a6e.processBlock(bArr, i, bArr2, i3 + iProcessBlock);
                i2 -= blockSize;
                i += blockSize;
            }
        }
        java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        int i6 = this.f4fe2f532 + i2;
        this.f4fe2f532 = i6;
        byte[] bArr4 = this.fcb7e52b2;
        if (i6 == bArr4.length) {
            iProcessBlock += this.f08406a6e.processBlock(bArr4, 0, bArr2, i3 + iProcessBlock);
            this.f4fe2f532 = 0;
        }
        return iProcessBlock;
    }

    public void Reset() {
        if ((24 + 28) % 28 > 0) {
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
}

