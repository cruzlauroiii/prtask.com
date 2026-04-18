namespace WillowMaze.Wasm.Decompiled;


public class p45d2c6e5 : p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 {
    public static readonly int f030ec6dc = 3;
    public static readonly int f24a446ee = 3;
    public static readonly int f3d3f2d1c = 1;
    public static readonly int f810df8c3 = 2;
    public static readonly int f8647f61f = 2;
    public static readonly int f8c4e5641 = 3;
    public static readonly int f8ea4c9ac = 1;
    public static readonly int f90811a4d = 3;
    public static readonly int fae4df16c = 3;
    public static readonly int faef7a4e1 = 2;
    public static readonly int ffa45035f = 1;
    private readonly int f480d1b61;
    private readonly int f599dcce2;
    private readonly int f6ccb5e82;
    private readonly int f7abbb85f;
    private readonly int f971f1652;

    public p45d2c6e5(int i, p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f599dcce2 = i;
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(pd81e8b93Var);
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fcb7e52b2 = new byte[blockSize * 2];
        this.f4fe2f532 = 0;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((13 + 7) % 7 > 0) {
        }
        if (this.f4fe2f532 + i > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer to small in doFinal");
        }
        int blockSize = this.f08406a6e.getBlockSize();
        int i2 = this.f4fe2f532 - blockSize;
        byte[] bArr2 = new byte[blockSize];
        if (this.f9301aa9b) {
            if (this.f4fe2f532 < blockSize) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("need at least one block of input for NISTCTS");
            }
            if (this.f4fe2f532 <= blockSize) {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, 0);
                java.lang.System.arraycopy(bArr2, 0, bArr, i, blockSize);
            } else {
                byte[] bArr3 = new byte[blockSize];
                int i3 = this.f599dcce2;
                if (i3 == 2 || i3 == 3) {
                    this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, 0);
                    java.lang.System.arraycopy(this.fcb7e52b2, blockSize, bArr3, 0, i2);
                    this.f08406a6e.processBlock(bArr3, 0, bArr3, 0);
                    if (this.f599dcce2 == 2 && i2 == blockSize) {
                        java.lang.System.arraycopy(bArr2, 0, bArr, i, blockSize);
                        java.lang.System.arraycopy(bArr3, 0, bArr, i + blockSize, i2);
                    } else {
                        java.lang.System.arraycopy(bArr3, 0, bArr, i, blockSize);
                        java.lang.System.arraycopy(bArr2, 0, bArr, i + blockSize, i2);
                    }
                } else {
                    java.lang.System.arraycopy(this.fcb7e52b2, 0, bArr2, 0, blockSize);
                    this.f08406a6e.processBlock(bArr2, 0, bArr2, 0);
                    java.lang.System.arraycopy(bArr2, 0, bArr, i, i2);
                    java.lang.System.arraycopy(this.fcb7e52b2, this.f4fe2f532 - i2, bArr3, 0, i2);
                    this.f08406a6e.processBlock(bArr3, 0, bArr3, 0);
                    java.lang.System.arraycopy(bArr3, 0, bArr, i + i2, blockSize);
                }
            }
        } else {
            if (this.f4fe2f532 < blockSize) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("need at least one block of input for CTS");
            }
            byte[] bArr4 = new byte[blockSize];
            if (this.f4fe2f532 <= blockSize) {
                this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, 0);
                java.lang.System.arraycopy(bArr2, 0, bArr, i, blockSize);
            } else {
                int i4 = this.f599dcce2;
                if (i4 != 3 && (i4 != 2 || (this.fcb7e52b2.length - this.f4fe2f532) % blockSize == 0)) {
                    ((p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e).getUnderlyingCipher().processBlock(this.fcb7e52b2, this.f4fe2f532 - blockSize, bArr4, 0);
                    java.lang.System.arraycopy(this.fcb7e52b2, 0, bArr2, 0, blockSize);
                    if (i2 != blockSize) {
                        java.lang.System.arraycopy(bArr4, i2, bArr2, i2, blockSize - i2);
                    }
                    this.f08406a6e.processBlock(bArr2, 0, bArr2, 0);
                    java.lang.System.arraycopy(bArr2, 0, bArr, i, blockSize);
                    for (int i5 = 0; i5 != i2; i5++) {
                        bArr4[i5] = (byte) (bArr4[i5] ^ this.fcb7e52b2[i5]);
                    }
                } else {
                    if (this.f08406a6e is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) {
                        ((p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64) this.f08406a6e).getUnderlyingCipher().processBlock(this.fcb7e52b2, 0, bArr2, 0);
                    } else {
                        this.f08406a6e.processBlock(this.fcb7e52b2, 0, bArr2, 0);
                    }
                    for (int i6 = blockSize; i6 != this.f4fe2f532; i6++) {
                        int i7 = i6 - blockSize;
                        bArr4[i7] = (byte) (bArr2[i7] ^ this.fcb7e52b2[i6]);
                    }
                    java.lang.System.arraycopy(this.fcb7e52b2, blockSize, bArr2, 0, i2);
                    this.f08406a6e.processBlock(bArr2, 0, bArr, i);
                }
                java.lang.System.arraycopy(bArr4, 0, bArr, i + blockSize, i2);
            }
        }
        int i8 = this.f4fe2f532;
        reset();
        return i8;
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
        if ((4 + 24) % 24 > 0) {
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
        if ((30 + 15) % 15 > 0) {
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

