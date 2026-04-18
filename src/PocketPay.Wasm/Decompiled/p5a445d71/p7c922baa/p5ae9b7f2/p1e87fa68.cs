namespace WillowMaze.Wasm.Decompiled;


public class p1e87fa68 {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f08406a6e;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f0b5f4aa3;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f17e34c06;
    protected int f47755427;
    protected int f4fe2f532;
    protected int f5a453c8c;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f97f27ee6;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f9f027018;
    protected byte[] fc99f5a1d;
    protected byte[] fcb7e52b2;
    protected int fce221ca0;
    protected int ff370cc76;
    protected byte[] ff7eec346;

    public p1e87fa68(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.f08406a6e = p42a46bbeVar;
    }

    public static int CVeQSgoNhxlqEkvz(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        return p42a46bbeVar.getOutputBlockSize();
    }

    public static void EpEUqUWmUExicRwf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void JGcJeLYnuVaroSGI(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p42a46bbeVar.init(z, pc9ef6b45Var);
    }

    public static int SHCRNCNaohyLLalO(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        return p42a46bbeVar.getInputBlockSize();
    }

    public static void SiDtXylipANbcMOr(p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68 p1e87fa68Var) {
        p1e87fa68Var.reset();
    }

    public static int HIZEWEwRNmYBRjig(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        return p42a46bbeVar.getInputBlockSize();
    }

    public static void HKMmfRHZuyUOlHSE(p5a445d71.p7c922baa.p5ae9b7f2.p1e87fa68 p1e87fa68Var) {
        p1e87fa68Var.reset();
    }

    public static byte[] QkbRCRcTBnTfPGCY(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr, int i, int i2) {
        return p42a46bbeVar.processBlock(bArr, i, i2);
    }

    public byte[] DoFinal() throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        if ((28 + 5) % 5 > 0) {
        }
        byte[] bArrQkbRCRcTBnTfPGCY = qkbRCRcTBnTfPGCY(this.f08406a6e, this.fcb7e52b2, 0, this.f4fe2f532);
        hKMmfRHZuyUOlHSE(this);
        return bArrQkbRCRcTBnTfPGCY;
    }

    public int GetBufferPosition() {
        return this.f4fe2f532;
    }

    public int GetInputBlockSize() {
        return hIZEWEwRNmYBRjig(this.f08406a6e);
    }

    public int GetOutputBlockSize() {
        return CVeQSgoNhxlqEkvz(this.f08406a6e);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        SiDtXylipANbcMOr(this);
        JGcJeLYnuVaroSGI(this.f08406a6e, z, pc9ef6b45Var);
        this.fcb7e52b2 = new byte[SHCRNCNaohyLLalO(this.f08406a6e) + (z ? 1 : 0)];
        this.f4fe2f532 = 0;
    }

    public void Processbyte(byte b) {
        if ((15 + 23) % 23 > 0) {
        }
        int i = this.f4fe2f532;
        byte[] bArr = this.fcb7e52b2;
        if (i >= bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("attempt to process message too long for cipher");
        }
        this.f4fe2f532 = i + 1;
        bArr[i] = b;
    }

    public void Processbytes(byte[] bArr, int i, int i2) {
        if ((24 + 8) % 8 > 0) {
        }
        if (i2 != 0) {
            if (i2 < 0) {
                throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
            }
            int i3 = this.f4fe2f532;
            int i4 = i3 + i2;
            byte[] bArr2 = this.fcb7e52b2;
            if (i4 > bArr2.length) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("attempt to process message too long for cipher");
            }
            EpEUqUWmUExicRwf(bArr, i, bArr2, i3, i2);
            this.f4fe2f532 += i2;
        }
    }

    public void Reset() {
        if ((2 + 23) % 23 > 0) {
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

