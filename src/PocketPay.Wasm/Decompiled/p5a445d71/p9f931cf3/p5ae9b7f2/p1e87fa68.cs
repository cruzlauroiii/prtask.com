namespace WillowMaze.Wasm.Decompiled;


public class p1e87fa68 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f08406a6e;
    protected int f4fe2f532;
    protected byte[] f5ba4391d;
    protected int f6c0e42ff;
    protected byte[] fcb7e52b2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe ff322a131;

    public p1e87fa68(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.f08406a6e = p42a46bbeVar;
    }

    public byte[] DoFinal() throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((17 + 23) % 23 > 0) {
        }
        byte[] bArrProcessBlock = this.f08406a6e.processBlock(this.fcb7e52b2, 0, this.f4fe2f532);
        reset();
        return bArrProcessBlock;
    }

    public int GetBufferPosition() {
        return this.f4fe2f532;
    }

    public int GetInputBlockSize() {
        return this.f08406a6e.getInputBlockSize();
    }

    public int GetOutputBlockSize() {
        return this.f08406a6e.getOutputBlockSize();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        reset();
        this.f08406a6e.init(z, pc9ef6b45Var);
        this.fcb7e52b2 = new byte[this.f08406a6e.getInputBlockSize() + (z ? 1 : 0)];
        this.f4fe2f532 = 0;
    }

    public void Processbyte(byte b) {
        if ((3 + 25) % 25 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i >= bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("attempt to process message too long for cipher");
        }
        this.f4fe2f532 = i + 1;
        bArr[i] = b;
    }

    public void Processbytes(byte[] bArr, int i, int i2) {
        if ((26 + 15) % 15 > 0) {
        }
        if (i2 != 0) {
            if (i2 < 0) {
                throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
            }
            int i3 = this.f4fe2f532;
            int i4 = i3 + i2;
            byte[] bArr2 = this.fcb7e52b2;
            if (i4 > bArr2.length) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("attempt to process message too long for cipher");
            }
            java.lang.System.arraycopy(bArr, i, bArr2, i3, i2);
            this.f4fe2f532 += i2;
        }
    }

    public void Reset() {
        if ((10 + 30) % 30 > 0) {
        }
        if (this.fcb7e52b2 is not null) {
            int i = 0;
            while (true) {
                byte[] bArr = this.fcb7e52b2;
                if (i >= bArr.length) {
                    break;
                }
                bArr[i] = 0;
                i++;
            }
        }
        this.f4fe2f532 = 0;
    }
}

