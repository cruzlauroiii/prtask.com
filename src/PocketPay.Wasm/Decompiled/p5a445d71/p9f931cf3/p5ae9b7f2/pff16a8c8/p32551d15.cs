namespace WillowMaze.Wasm.Decompiled;


public class p32551d15 : p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 {
    p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e f134e21b8;
    p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e fb70cdb87;

    public p32551d15(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pd2c01e0e());
    }

    public p32551d15(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e pa444028eVar) {
        this.f08406a6e = pd81e8b93Var;
        this.fb70cdb87 = pa444028eVar;
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int iProcessBlock;
        if ((32 + 13) % 13 > 0) {
        }
        int blockSize = this.f08406a6e.getBlockSize();
        if (this.f9301aa9b) {
            if (this.f4fe2f532 != blockSize) {
                iProcessBlock = 0;
            } else {
                if ((blockSize * 2) + i > bArr.length) {
                    reset();
                    throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
                }
                iProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr, i);
                this.f4fe2f532 = 0;
            }
            this.fb70cdb87.addPadding(this.fcb7e52b2, this.f4fe2f532);
            int iProcessBlock2 = iProcessBlock + this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr, i + iProcessBlock);
            reset();
            return iProcessBlock2;
        }
        if (this.f4fe2f532 != blockSize) {
            reset();
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("last block incomplete in decryption");
        }
        int iProcessBlock3 = this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.fcb7e52b2, 0);
        this.f4fe2f532 = 0;
        try {
            int iPadCount = iProcessBlock3 - this.fb70cdb87.padCount(this.fcb7e52b2);
            java.lang.System.arraycopy(this.fcb7e52b2, 0, bArr, i, iPadCount);
            reset();
            return iPadCount;
        } catch (java.lang.Exception th) {
            reset();
            throw th;
        }
    }

    public override int GetOutputSize(int i) {
        int length;
        int i2 = i + this.f4fe2f532;
        int length2 = i2 % this.fcb7e52b2.length;
        if (length2 != 0) {
            i2 -= length2;
            length = this.fcb7e52b2.length;
        } else {
            if (!this.f9301aa9b) {
                return i2;
            }
            length = this.fcb7e52b2.length;
        }
        return i2 + length;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        int length = i2 % this.fcb7e52b2.length;
        return length != 0 ? i2 - length : java.lang.Math.max(0, i2 - this.fcb7e52b2.length);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((28 + 1) % 1 > 0) {
        }
        this.f9301aa9b = z;
        reset();
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.fb70cdb87.init(p4715f007Var.getRandom());
            pd81e8b93Var = this.f08406a6e;
            pc9ef6b45Var = p4715f007Var.getParameters();
        } else {
            this.fb70cdb87.init(null);
            pd81e8b93Var = this.f08406a6e;
        }
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((14 + 26) % 26 > 0) {
        }
        int i2 = 0;
        if (this.f4fe2f532 == this.fcb7e52b2.length) {
            int iProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr, i);
            this.f4fe2f532 = 0;
            i2 = iProcessBlock;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i3 = this.f4fe2f532;
        this.f4fe2f532 = i3 + 1;
        bArr2[i3] = b;
        return i2;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((28 + 19) % 19 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        int blockSize = getBlockSize();
        int updateOutputSize = getUpdateOutputSize(i2);
        if (updateOutputSize > 0 && updateOutputSize + i3 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int length = this.fcb7e52b2.length - this.f4fe2f532;
        int iProcessBlock = 0;
        if (i2 > length) {
            java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, length);
            int iProcessBlock2 = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, i3);
            this.f4fe2f532 = 0;
            i2 -= length;
            i += length;
            iProcessBlock = iProcessBlock2;
            while (i2 > this.fcb7e52b2.length) {
                iProcessBlock += this.f08406a6e.processBlock(bArr, i, bArr2, i3 + iProcessBlock);
                i2 -= blockSize;
                i += blockSize;
            }
        }
        java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
        return iProcessBlock;
    }
}

