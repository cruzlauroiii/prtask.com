namespace WillowMaze.Wasm.Decompiled;


public class p1072b2df : p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 {
    private int f2585634a;
    private int f431ced77;
    private int f480d1b61;
    private int f51692b87;
    private int f69b43ba0;

    public p1072b2df(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        if ((pd81e8b93Var is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p8350a7a9) || (pd81e8b93Var is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p469137e7)) {
            throw new java.lang.IllegalArgumentException("CTSBlockCipher can only accept ECB, or CBC ciphers");
        }
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fcb7e52b2 = new byte[blockSize * 2];
        this.f4fe2f532 = 0;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((12 + 21) % 21 > 0) {
        }
        if (this.f4fe2f532 + i > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer to small in doFinal");
        }
        int blockSize = this.f08406a6e.getBlockSize();
        int i2 = this.f4fe2f532 - blockSize;
        byte[] bArr2 = new byte[blockSize];
        if (this.f9301aa9b) {
            this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, 0);
            if (this.f4fe2f532 < blockSize) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("need at least one block of input for CTS");
            }
            for (int i3 = this.f4fe2f532; i3 != this.fcb7e52b2.length; i3++) {
                this.fcb7e52b2[i3] = bArr2[i3 - blockSize];
            }
            for (int i4 = blockSize; i4 != this.f4fe2f532; i4++) {
                byte[] bArr3 = this.fcb7e52b2;
                bArr3[i4] = (byte) (bArr3[i4] ^ bArr2[i4 - blockSize]);
            }
            if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) {
                ((p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e).getUnderlyingCipher().processBlock(this.fcb7e52b2, blockSize, bArr, i);
            } else {
                this.f08406a6e.processBlock(this.fcb7e52b2, blockSize, bArr, i);
            }
            java.lang.System.arraycopy(bArr2, 0, bArr, i + blockSize, i2);
        } else {
            byte[] bArr4 = new byte[blockSize];
            if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) {
                ((p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e).getUnderlyingCipher().processBlock(this.fcb7e52b2, 0, bArr2, 0);
            } else {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, 0);
            }
            for (int i5 = blockSize; i5 != this.f4fe2f532; i5++) {
                int i6 = i5 - blockSize;
                bArr4[i6] = (byte) (bArr2[i6] ^ this.fcb7e52b2[i5]);
            }
            java.lang.System.arraycopy(this.fcb7e52b2, blockSize, bArr2, 0, i2);
            this.f08406a6e.processBlock(bArr2, 0, bArr, i);
            java.lang.System.arraycopy(bArr4, 0, bArr, i + blockSize, i2);
        }
        int i7 = this.f4fe2f532;
        reset();
        return i7;
    }

    public override int GetOutputSize(int i) {
        return i + this.f4fe2f532;
    }

    public override int GetUpdateOutputSize(int i) {
        int i2 = i + this.f4fe2f532;
        int length = i2 % this.fcb7e52b2.length;
        return length != 0 ? i2 - length : i2 - this.fcb7e52b2.length;
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((16 + 21) % 21 > 0) {
        }
        int i2 = 0;
        if (this.f4fe2f532 == this.fcb7e52b2.length) {
            int iProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr, i);
            java.lang.System.arraycopy(this.fcb7e52b2, this.f480d1b61, this.fcb7e52b2, 0, this.f480d1b61);
            this.f4fe2f532 = this.f480d1b61;
            i2 = iProcessBlock;
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i3 = this.f4fe2f532;
        this.f4fe2f532 = i3 + 1;
        bArr2[i3] = b;
        return i2;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((29 + 12) % 12 > 0) {
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
        int i4 = 0;
        if (i2 > length) {
            java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, length);
            int iProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, i3);
            java.lang.System.arraycopy(this.fcb7e52b2, blockSize, this.fcb7e52b2, 0, blockSize);
            this.f4fe2f532 = blockSize;
            i2 -= length;
            i += length;
            while (i2 > blockSize) {
                java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, blockSize);
                iProcessBlock += this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, i3 + iProcessBlock);
                java.lang.System.arraycopy(this.fcb7e52b2, blockSize, this.fcb7e52b2, 0, blockSize);
                i2 -= blockSize;
                i += blockSize;
            }
            i4 = iProcessBlock;
        }
        java.lang.System.arraycopy(bArr, i, this.fcb7e52b2, this.f4fe2f532, i2);
        this.f4fe2f532 += i2;
        return i4;
    }
}

