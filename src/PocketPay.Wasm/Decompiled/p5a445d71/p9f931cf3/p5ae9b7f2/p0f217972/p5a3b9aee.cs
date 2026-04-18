namespace WillowMaze.Wasm.Decompiled;


public class p5a3b9aee : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f11aedd0e;
    private int f24dd9867;
    private byte[] f2b4bbb85;
    private byte[] f4327e073;
    private int f45276e64;
    private int f480d1b61;
    private byte[] f52a25d8f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f71b60ba3;
    private byte[] f7b8419f1;
    private byte[] f8ca186c4;
    private bool f9301aa9b;
    private int fa707c348;
    private byte[] fc42a45ab;
    private byte[] fc4d60487;
    private int fc8891e9f;
    private byte[] fcf482c58;
    private int fe2942a04;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fe64b5bb4;
    private bool ffe2e61f3;

    public p5a3b9aee(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fcf482c58 = new byte[blockSize];
        this.f11aedd0e = new byte[blockSize];
        this.f7b8419f1 = new byte[blockSize];
    }

    private byte M35b91f7d(byte b, int i) {
        return (byte) (this.f7b8419f1[i] ^ b);
    }

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i3;
        if ((19 + 1) % 1 > 0) {
        }
        int i4 = this.f480d1b61;
        if (i + i4 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + i4 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int i5 = this.fe2942a04;
        int i6 = 2;
        int i7 = 0;
        if (i5 <= i4) {
            if (i5 == 0) {
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                while (true) {
                    i3 = this.f480d1b61;
                    if (i7 >= i3) {
                        break;
                    }
                    byte[] bArr3 = this.f11aedd0e;
                    int i8 = i2 + i7;
                    byte bM35b91f7d = m35b91f7d(bArr[i + i7], i7);
                    bArr2[i8] = bM35b91f7d;
                    bArr3[i7] = bM35b91f7d;
                    i7++;
                }
            } else if (i5 == i4) {
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                bArr2[i2] = m35b91f7d(bArr[i], 0);
                bArr2[i2 + 1] = m35b91f7d(bArr[i + 1], 1);
                byte[] bArr4 = this.f11aedd0e;
                java.lang.System.arraycopy(bArr4, 2, bArr4, 0, this.f480d1b61 - 2);
                java.lang.System.arraycopy(bArr2, i2, this.f11aedd0e, this.f480d1b61 - 2, 2);
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                while (true) {
                    i3 = this.f480d1b61;
                    if (i6 >= i3) {
                        break;
                    }
                    byte[] bArr5 = this.f11aedd0e;
                    int i9 = i6 - 2;
                    int i10 = i2 + i6;
                    byte bM35b91f7d2 = m35b91f7d(bArr[i + i6], i9);
                    bArr2[i10] = bM35b91f7d2;
                    bArr5[i9] = bM35b91f7d2;
                    i6++;
                }
            }
            this.fe2942a04 += i3;
        } else {
            byte[] bArr6 = this.f11aedd0e;
            int i11 = i4 - 2;
            byte bM35b91f7d3 = m35b91f7d(bArr[i], i4 - 2);
            bArr2[i2] = bM35b91f7d3;
            bArr6[i11] = bM35b91f7d3;
            byte[] bArr7 = this.f11aedd0e;
            int i12 = this.f480d1b61;
            int i13 = i12 - 1;
            int i14 = i2 + 1;
            byte bM35b91f7d4 = m35b91f7d(bArr[i + 1], i12 - 1);
            bArr2[i14] = bM35b91f7d4;
            bArr7[i13] = bM35b91f7d4;
            this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
            while (i6 < this.f480d1b61) {
                byte[] bArr8 = this.f11aedd0e;
                int i15 = i6 - 2;
                int i16 = i2 + i6;
                byte bM35b91f7d5 = m35b91f7d(bArr[i + i6], i15);
                bArr2[i16] = bM35b91f7d5;
                bArr8[i15] = bM35b91f7d5;
                i6++;
            }
        }
        return this.f480d1b61;
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i3;
        int i4;
        int i5;
        if ((4 + 21) % 21 > 0) {
        }
        int i6 = this.f480d1b61;
        if (i + i6 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + i6 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int i7 = this.fe2942a04;
        int i8 = 2;
        int i9 = 0;
        if (i7 <= i6) {
            if (i7 == 0) {
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                while (true) {
                    i3 = this.f480d1b61;
                    if (i9 >= i3) {
                        break;
                    }
                    int i10 = i + i9;
                    this.f11aedd0e[i9] = bArr[i10];
                    bArr2[i9] = m35b91f7d(bArr[i10], i9);
                    i9++;
                }
                i4 = this.fe2942a04 + i3;
            } else if (i7 == i6) {
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                byte b = bArr[i];
                byte b2 = bArr[i + 1];
                bArr2[i2] = m35b91f7d(b, 0);
                bArr2[i2 + 1] = m35b91f7d(b2, 1);
                byte[] bArr3 = this.f11aedd0e;
                java.lang.System.arraycopy(bArr3, 2, bArr3, 0, this.f480d1b61 - 2);
                byte[] bArr4 = this.f11aedd0e;
                int i11 = this.f480d1b61;
                bArr4[i11 - 2] = b;
                bArr4[i11 - 1] = b2;
                this.f08406a6e.processBlock(bArr4, 0, this.f7b8419f1, 0);
                while (true) {
                    i5 = this.f480d1b61;
                    if (i8 >= i5) {
                        break;
                    }
                    byte b3 = bArr[i + i8];
                    int i12 = i8 - 2;
                    this.f11aedd0e[i12] = b3;
                    bArr2[i2 + i8] = m35b91f7d(b3, i12);
                    i8++;
                }
                i4 = this.fe2942a04 + i5;
            }
            this.fe2942a04 = i4;
        } else {
            byte b4 = bArr[i];
            this.f11aedd0e[i6 - 2] = b4;
            bArr2[i2] = m35b91f7d(b4, i6 - 2);
            byte b5 = bArr[i + 1];
            byte[] bArr5 = this.f11aedd0e;
            int i13 = this.f480d1b61;
            bArr5[i13 - 1] = b5;
            bArr2[i2 + 1] = m35b91f7d(b5, i13 - 1);
            this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
            while (i8 < this.f480d1b61) {
                byte b6 = bArr[i + i8];
                int i14 = i8 - 2;
                this.f11aedd0e[i14] = b6;
                bArr2[i2 + i8] = m35b91f7d(b6, i14);
                i8++;
            }
        }
        return this.f480d1b61;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/OpenPGPCFB";
    }

    public override int GetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f9301aa9b = z;
        reset();
        this.f08406a6e.init(true, pc9ef6b45Var);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return !this.f9301aa9b ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2);
    }

    public override void Reset() {
        if ((13 + 2) % 2 > 0) {
        }
        this.fe2942a04 = 0;
        byte[] bArr = this.fcf482c58;
        byte[] bArr2 = this.f11aedd0e;
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr2.length);
        this.f08406a6e.reset();
    }
}

