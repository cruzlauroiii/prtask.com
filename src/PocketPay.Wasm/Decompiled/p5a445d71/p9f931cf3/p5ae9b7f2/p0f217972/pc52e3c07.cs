namespace WillowMaze.Wasm.Decompiled;


public class pc52e3c07 : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f103d7b0c;
    private byte[] f11aedd0e;
    private bool f12924a1e;
    private bool f1de5dd15;
    private byte[] f1f0410b9;
    private byte[] f32889729;
    private byte[] f432fd1d5;
    private int f480d1b61;
    private int f55a8e73c;
    private int f5d0db23d;
    private byte[] f635c2a66;
    private byte[] f678f5b60;
    private bool f6c2a431c;
    private int f73b13ea7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f73e0e5da;
    private byte[] f79e518b3;
    private byte[] f7b8419f1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f8c79f741;
    private int f90f2dbdc;
    private bool f9301aa9b;
    private bool facf886ee;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fb4b3139b;
    private byte[] fb96ce473;
    private int fc4ff612a;
    private byte[] fcf482c58;
    private bool fd904e01a;
    private int fe2942a04;
    private byte[] feafebac4;
    private bool ff6edbf1a;
    private byte[] ffa816edb;

    public pc52e3c07(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z) {
        this.f08406a6e = pd81e8b93Var;
        this.f1de5dd15 = z;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fcf482c58 = new byte[blockSize];
        this.f11aedd0e = new byte[blockSize];
        this.f7b8419f1 = new byte[blockSize];
        this.ffa816edb = new byte[blockSize];
    }

    private byte M35b91f7d(byte b, int i) {
        return (byte) (this.f7b8419f1[i] ^ b);
    }

    private int M38ba9ce4(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((32 + 25) % 25 > 0) {
        }
        int i3 = this.f480d1b61;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int i4 = 0;
        this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
        for (int i5 = 0; i5 < this.f480d1b61; i5++) {
            bArr2[i2 + i5] = m35b91f7d(bArr[i + i5], i5);
        }
        while (true) {
            int i6 = this.f480d1b61;
            if (i4 >= i6) {
                return i6;
            }
            this.f11aedd0e[i4] = bArr2[i2 + i4];
            i4++;
        }
    }

    private int M54b8c68b(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((6 + 19) % 19 > 0) {
        }
        int i3 = this.f480d1b61;
        if (i + i3 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int i4 = 0;
        this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
        for (int i5 = 0; i5 < this.f480d1b61; i5++) {
            bArr2[i2 + i5] = m35b91f7d(bArr[i + i5], i5);
        }
        while (true) {
            int i6 = this.f480d1b61;
            if (i4 >= i6) {
                return i6;
            }
            this.f11aedd0e[i4] = bArr[i + i4];
            i4++;
        }
    }

    private int M9cd27fce(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i3;
        if ((5 + 4) % 4 > 0) {
        }
        int i4 = this.f480d1b61;
        if (i + i4 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + i4 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        int i5 = this.fe2942a04;
        if (i5 == 0) {
            for (int i6 = 0; i6 < this.f480d1b61; i6++) {
                this.f11aedd0e[i6] = bArr[i + i6];
            }
            this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
            this.fe2942a04 += this.f480d1b61;
            return 0;
        }
        if (i5 != i4) {
            if (i5 >= i4 + 2) {
                java.lang.System.arraycopy(bArr, i, this.ffa816edb, 0, i4);
                bArr2[i2] = m35b91f7d(this.ffa816edb[0], this.f480d1b61 - 2);
                bArr2[i2 + 1] = m35b91f7d(this.ffa816edb[1], this.f480d1b61 - 1);
                java.lang.System.arraycopy(this.ffa816edb, 0, this.f11aedd0e, this.f480d1b61 - 2, 2);
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                int i7 = 0;
                while (true) {
                    i3 = this.f480d1b61;
                    if (i7 >= i3 - 2) {
                        break;
                    }
                    bArr2[i2 + i7 + 2] = m35b91f7d(this.ffa816edb[i7 + 2], i7);
                    i7++;
                }
                java.lang.System.arraycopy(this.ffa816edb, 2, this.f11aedd0e, 0, i3 - 2);
            }
            return this.f480d1b61;
        }
        java.lang.System.arraycopy(bArr, i, this.ffa816edb, 0, i4);
        byte[] bArr3 = this.f11aedd0e;
        java.lang.System.arraycopy(bArr3, 2, bArr3, 0, this.f480d1b61 - 2);
        byte[] bArr4 = this.f11aedd0e;
        int i8 = this.f480d1b61;
        int i9 = i8 - 2;
        byte[] bArr5 = this.ffa816edb;
        bArr4[i9] = bArr5[0];
        bArr4[i8 - 1] = bArr5[1];
        this.f08406a6e.processBlock(bArr4, 0, this.f7b8419f1, 0);
        int i10 = 0;
        while (true) {
            int i11 = this.f480d1b61;
            if (i10 >= i11 - 2) {
                java.lang.System.arraycopy(this.ffa816edb, 2, this.f11aedd0e, 0, i11 - 2);
                this.fe2942a04 += 2;
                return this.f480d1b61 - 2;
            }
            bArr2[i2 + i10] = m35b91f7d(this.ffa816edb[i10 + 2], i10);
            i10++;
        }
    }

    private int Ma9285542(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        int i3;
        int i4;
        if ((31 + 26) % 26 > 0) {
        }
        int i5 = this.f480d1b61;
        if (i + i5 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        int i6 = this.fe2942a04;
        if (i6 != 0) {
            if (i6 >= i5 + 2) {
                if (i5 + i2 > bArr2.length) {
                    throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
                }
                this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
                int i7 = 0;
                while (true) {
                    i4 = this.f480d1b61;
                    if (i7 >= i4) {
                        break;
                    }
                    bArr2[i2 + i7] = m35b91f7d(bArr[i + i7], i7);
                    i7++;
                }
                java.lang.System.arraycopy(bArr2, i2, this.f11aedd0e, 0, i4);
            }
            return this.f480d1b61;
        }
        if ((i5 * 2) + i2 + 2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
        int i8 = 0;
        while (true) {
            i3 = this.f480d1b61;
            if (i8 >= i3) {
                break;
            }
            bArr2[i2 + i8] = m35b91f7d(this.fcf482c58[i8], i8);
            i8++;
        }
        java.lang.System.arraycopy(bArr2, i2, this.f11aedd0e, 0, i3);
        this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
        int i9 = this.f480d1b61;
        bArr2[i2 + i9] = m35b91f7d(this.fcf482c58[i9 - 2], 0);
        int i10 = this.f480d1b61;
        bArr2[i2 + i10 + 1] = m35b91f7d(this.fcf482c58[i10 - 1], 1);
        java.lang.System.arraycopy(bArr2, i2 + 2, this.f11aedd0e, 0, this.f480d1b61);
        this.f08406a6e.processBlock(this.f11aedd0e, 0, this.f7b8419f1, 0);
        int i11 = 0;
        while (true) {
            int i12 = this.f480d1b61;
            if (i11 >= i12) {
                java.lang.System.arraycopy(bArr2, i2 + i12 + 2, this.f11aedd0e, 0, i12);
                int i13 = this.fe2942a04;
                int i14 = this.f480d1b61;
                this.fe2942a04 = i13 + (i14 * 2) + 2;
                return (i14 * 2) + 2;
            }
            bArr2[i12 + i2 + 2 + i11] = m35b91f7d(bArr[i + i11], i11);
            i11++;
        }
    }

    public override java.lang.string GetAlgorithmName() {
        java.lang.stringBuilder sbAppend;
        java.lang.string str;
        if (this.f1de5dd15) {
            sbAppend = new java.lang.stringBuilder().append(this.f08406a6e.getAlgorithmName());
            str = "/PGPCFBwithIV";
        } else {
            sbAppend = new java.lang.stringBuilder().append(this.f08406a6e.getAlgorithmName());
            str = "/PGPCFB";
        }
        return sbAppend.append(str).tostring();
    }

    public override int GetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((26 + 13) % 13 > 0) {
        }
        this.f9301aa9b = z;
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            reset();
            this.f08406a6e.init(true, pc9ef6b45Var);
            return;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] iv = pdd5da44eVar.getIV();
        int length = iv.length;
        byte[] bArr = this.fcf482c58;
        if (length >= bArr.length) {
            java.lang.System.arraycopy(iv, 0, bArr, 0, bArr.length);
        } else {
            java.lang.System.arraycopy(iv, 0, bArr, bArr.length - iv.length, iv.length);
            int i = 0;
            while (true) {
                byte[] bArr2 = this.fcf482c58;
                if (i >= bArr2.length - iv.length) {
                    break;
                }
                bArr2[i] = 0;
                i++;
            }
        }
        reset();
        this.f08406a6e.init(true, pdd5da44eVar.getParameters());
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return !this.f1de5dd15 ? !this.f9301aa9b ? m54b8c68b(bArr, i, bArr2, i2) : m38ba9ce4(bArr, i, bArr2, i2) : !this.f9301aa9b ? m9cd27fce(bArr, i, bArr2, i2) : ma9285542(bArr, i, bArr2, i2);
    }

    public override void Reset() {
        if ((23 + 30) % 30 > 0) {
        }
        this.fe2942a04 = 0;
        int i = 0;
        while (true) {
            byte[] bArr = this.f11aedd0e;
            if (i == bArr.length) {
                this.f08406a6e.reset();
                return;
            }
            if (this.f1de5dd15) {
                bArr[i] = 0;
            } else {
                bArr[i] = this.fcf482c58[i];
            }
            i++;
        }
    }
}

