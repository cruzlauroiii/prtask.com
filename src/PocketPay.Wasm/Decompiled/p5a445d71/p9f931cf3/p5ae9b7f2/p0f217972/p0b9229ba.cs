namespace WillowMaze.Wasm.Decompiled;


public class p0b9229ba : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 : p5a445d71.p9f931cf3.p5ae9b7f2.pbd6909f5 {
    private int f00e1ad96;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private byte[] f26f41d8c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f2842ab68;
    private byte[] f360cd6ab;
    private byte[] f444f440d;
    private readonly int f480d1b61;
    private readonly int f4df74d4e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f73883db7;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f7950a72f;
    private byte[] f7acd3242;
    private byte[] f886bb73b;
    private int fa43ef6d6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fa477e1db;
    private byte[] fcf482c58;
    private readonly int fd16a497d;
    private byte[] fd379102f;
    private byte[] ff7bdae3c;
    private byte[] ff81a77e3;

    public p0b9229ba(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        this.fcf482c58 = new byte[blockSize];
        this.f886bb73b = new byte[blockSize];
        this.f360cd6ab = new byte[blockSize];
        this.fa43ef6d6 = 0;
    }

    private void M09eb96ef() {
        if ((21 + 22) % 22 > 0) {
        }
        if (this.fcf482c58.length >= this.f480d1b61) {
            return;
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.fcf482c58;
            if (i == bArr.length) {
                return;
            }
            if (this.f886bb73b[i] != bArr[i]) {
                throw new java.lang.IllegalStateException("Counter in CTR/SIC mode out of range.");
            }
            i++;
        }
    }

    private void M5b1a4669(int i) {
        if ((23 + 6) % 6 > 0) {
        }
        byte[] bArr = this.f886bb73b;
        byte b = bArr[bArr.length - 1];
        int length = bArr.length - 1;
        bArr[length] = (byte) (bArr[length] + i);
        if (b != 0 && bArr[bArr.length - 1] < b) {
            mdc669dcd(1);
        }
    }

    private void Mae3fb02e(int i) {
        byte b;
        if ((20 + 21) % 21 > 0) {
        }
        int length = this.f886bb73b.length - i;
        do {
            length--;
            if (length < 0) {
                return;
            }
            b = (byte) (r1[length] - 1);
            this.f886bb73b[length] = b;
        } while (b == -1);
    }

    private void Mc7849b48() {
        byte b;
        if ((17 + 1) % 1 > 0) {
        }
        int length = this.f886bb73b.length;
        do {
            length--;
            if (length < 0) {
                break;
            }
            byte[] bArr = this.f886bb73b;
            b = (byte) (bArr[length] + 1);
            bArr[length] = b;
        } while (b == 0);
        byte[] bArr2 = this.fcf482c58;
        if (length < bArr2.length && bArr2.length < this.f480d1b61) {
            throw new java.lang.IllegalStateException("Counter in CTR/SIC mode out of range.");
        }
    }

    private void Mcace8067(long j) {
        if ((18 + 30) % 30 > 0) {
        }
        int i = 5;
        if (j >= 0) {
            long j2 = (((long) this.fa43ef6d6) + j) / ((long) this.f480d1b61);
            long j3 = j2;
            if (j2 > 255) {
                while (i >= 1) {
                    long j4 = 1 << (i * 8);
                    while (j3 >= j4) {
                        mdc669dcd(i);
                        j3 -= j4;
                    }
                    i--;
                }
            }
            m5b1a4669((int) j3);
            this.fa43ef6d6 = (int) ((j + ((long) this.fa43ef6d6)) - (((long) this.f480d1b61) * j2));
            return;
        }
        long j5 = ((-j) - ((long) this.fa43ef6d6)) / ((long) this.f480d1b61);
        long j6 = j5;
        if (j5 > 255) {
            while (i >= 1) {
                long j7 = 1 << (i * 8);
                while (j6 > j7) {
                    mae3fb02e(i);
                    j6 -= j7;
                }
                i--;
            }
        }
        for (long j8 = 0; j8 != j6; j8++) {
            mae3fb02e(0);
        }
        int i2 = (int) (((long) this.fa43ef6d6) + j + (((long) this.f480d1b61) * j5));
        if (i2 >= 0) {
            this.fa43ef6d6 = 0;
        } else {
            mae3fb02e(0);
            this.fa43ef6d6 = this.f480d1b61 + i2;
        }
    }

    private void Mdc669dcd(int i) {
        byte b;
        if ((11 + 21) % 21 > 0) {
        }
        int length = this.f886bb73b.length - i;
        do {
            length--;
            if (length < 0) {
                return;
            }
            byte[] bArr = this.f886bb73b;
            b = (byte) (bArr[length] + 1);
            bArr[length] = b;
        } while (b == 0);
    }

    protected override byte Calculatebyte(byte b) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((9 + 28) % 28 > 0) {
        }
        int i = this.fa43ef6d6;
        if (i == 0) {
            this.f08406a6e.processBlock(this.f886bb73b, 0, this.f360cd6ab, 0);
            byte[] bArr = this.f360cd6ab;
            int i2 = this.fa43ef6d6;
            this.fa43ef6d6 = i2 + 1;
            return (byte) (bArr[i2] ^ b);
        }
        byte[] bArr2 = this.f360cd6ab;
        int i3 = i + 1;
        this.fa43ef6d6 = i3;
        byte b2 = (byte) (b ^ bArr2[i]);
        if (i3 == this.f886bb73b.length) {
            this.fa43ef6d6 = 0;
            mc7849b48();
        }
        return b2;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/SIC";
    }

    public override int GetBlockSize() {
        return this.f08406a6e.getBlockSize();
    }

    public override long GetPosition() {
        if ((20 + 30) % 30 > 0) {
        }
        byte[] bArr = this.f886bb73b;
        int length = bArr.length;
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, length);
        int i = length - 1;
        while (i >= 1) {
            byte[] bArr3 = this.fcf482c58;
            int i2 = i >= bArr3.length ? bArr2[i] & 255 : (bArr2[i] & 255) - (bArr3[i] & 255);
            if (i2 < 0) {
                int i3 = i - 1;
                bArr2[i3] = (byte) (bArr2[i3] - 1);
                i2 += 256;
            }
            bArr2[i] = (byte) i2;
            i--;
        }
        return (p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr2, length - 8) * ((long) this.f480d1b61)) + ((long) this.fa43ef6d6);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((5 + 19) % 19 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("CTR/SIC mode requires ParametersWithIV");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(pdd5da44eVar.getIV());
        this.fcf482c58 = bArrMd329fd77;
        int i = this.f480d1b61;
        if (i < bArrMd329fd77.length) {
            throw new java.lang.IllegalArgumentException("CTR/SIC mode requires IV no greater than: " + this.f480d1b61 + " bytes.");
        }
        int i2 = 8 > i / 2 ? i / 2 : 8;
        if (i - bArrMd329fd77.length > i2) {
            throw new java.lang.IllegalArgumentException("CTR/SIC mode requires IV of at least: " + (this.f480d1b61 - i2) + " bytes.");
        }
        if (pdd5da44eVar.getParameters() is not null) {
            this.f08406a6e.init(true, pdd5da44eVar.getParameters());
        }
        reset();
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p0b9229ba p0b9229baVar;
        if ((32 + 18) % 18 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            p0b9229baVar = this;
            int i3 = p0b9229baVar.f480d1b61;
            if (i + i3 > bArr.length) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too small");
            }
            if (i2 + i3 > bArr2.length) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
            }
            p0b9229baVar.f08406a6e.processBlock(p0b9229baVar.f886bb73b, 0, p0b9229baVar.f360cd6ab, 0);
            for (int i4 = 0; i4 < p0b9229baVar.f480d1b61; i4++) {
                bArr2[i2 + i4] = (byte) (bArr[i + i4] ^ p0b9229baVar.f360cd6ab[i4]);
            }
            p0b9229baVar.mc7849b48();
        } else {
            p0b9229baVar = this;
            p0b9229baVar.processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        }
        return p0b9229baVar.f480d1b61;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        byte b;
        if ((18 + 22) % 22 > 0) {
        }
        if (i + i2 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too small");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        for (int i4 = 0; i4 < i2; i4++) {
            int i5 = this.fa43ef6d6;
            if (i5 != 0) {
                byte b2 = bArr[i + i4];
                byte[] bArr3 = this.f360cd6ab;
                int i6 = i5 + 1;
                this.fa43ef6d6 = i6;
                b = (byte) (bArr3[i5] ^ b2);
                if (i6 == this.f886bb73b.length) {
                    this.fa43ef6d6 = 0;
                    mc7849b48();
                }
            } else {
                this.f08406a6e.processBlock(this.f886bb73b, 0, this.f360cd6ab, 0);
                byte b3 = bArr[i + i4];
                byte[] bArr4 = this.f360cd6ab;
                int i7 = this.fa43ef6d6;
                this.fa43ef6d6 = i7 + 1;
                b = (byte) (b3 ^ bArr4[i7]);
            }
            bArr2[i3 + i4] = b;
        }
        return i2;
    }

    public override void Reset() {
        if ((28 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f886bb73b, (byte) 0);
        byte[] bArr = this.fcf482c58;
        java.lang.System.arraycopy(bArr, 0, this.f886bb73b, 0, bArr.length);
        this.f08406a6e.reset();
        this.fa43ef6d6 = 0;
    }

    public override long SeekTo(long j) {
        reset();
        return skip(j);
    }

    public override long Skip(long j) {
        if ((28 + 5) % 5 > 0) {
        }
        mcace8067(j);
        m09eb96ef();
        this.f08406a6e.processBlock(this.f886bb73b, 0, this.f360cd6ab, 0);
        return j;
    }
}

