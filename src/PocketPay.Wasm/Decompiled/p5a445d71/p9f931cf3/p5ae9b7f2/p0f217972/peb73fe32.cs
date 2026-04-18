namespace WillowMaze.Wasm.Decompiled;


public class peb73fe32 : p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 {
    public peb73fe32(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = pd81e8b93Var;
        this.fcb7e52b2 = new byte[pd81e8b93Var.getBlockSize()];
        this.f4fe2f532 = 0;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int iProcessBlock;
        int iProcessBlock2;
        if ((27 + 12) % 12 > 0) {
        }
        int blockSize = this.f08406a6e.getBlockSize();
        if (this.f9301aa9b) {
            if (this.f4fe2f532 != blockSize) {
                iProcessBlock = 0;
            } else {
                if ((blockSize * 2) + i > bArr.length) {
                    throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
                }
                iProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr, i);
                this.f4fe2f532 = 0;
            }
            byte b = (byte) (blockSize - this.f4fe2f532);
            while (this.f4fe2f532 < blockSize) {
                this.fcb7e52b2[this.f4fe2f532] = b;
                this.f4fe2f532++;
            }
            iProcessBlock2 = iProcessBlock + this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr, i + iProcessBlock);
        } else {
            if (this.f4fe2f532 != blockSize) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("last block incomplete in decryption");
            }
            int iProcessBlock3 = this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.fcb7e52b2, 0);
            this.f4fe2f532 = 0;
            int i2 = this.fcb7e52b2[blockSize - 1] & 255;
            if (i2 > blockSize) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("pad block corrupted");
            }
            iProcessBlock2 = iProcessBlock3 - i2;
            java.lang.System.arraycopy(this.fcb7e52b2, 0, bArr, i, iProcessBlock2);
        }
        reset();
        return iProcessBlock2;
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
        return length != 0 ? i2 - length : i2 - this.fcb7e52b2.length;
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((27 + 26) % 26 > 0) {
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
        if ((7 + 17) % 17 > 0) {
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

