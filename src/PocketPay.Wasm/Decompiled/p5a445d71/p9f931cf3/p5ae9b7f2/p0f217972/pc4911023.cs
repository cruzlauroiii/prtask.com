namespace WillowMaze.Wasm.Decompiled;


public class pc4911023 : p5a445d71.p9f931cf3.p5ae9b7f2.pe3d43295 {
    static readonly int f1a2ddc2d = 16843012;
    static readonly int f67608667 = 16843009;
    static readonly int f7aadd787 = 16843009;
    static readonly int f81245b84 = 16843009;
    static readonly int f8a34dc51 = 16843012;
    static readonly int f90d4695a = 16843012;
    static readonly int f92b732d9 = 16843009;
    static readonly int ff1a543f5 = 16843009;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f08406a6e;
    private readonly int f12a2a3ab;
    private int f1d77e8e4;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f2c870bcb;
    private byte[] f31c27de4;
    private byte[] f31e8dc53;
    private byte[] f38729c39;
    private readonly int f480d1b61;
    private byte[] f52e6fe6e;
    bool f5799c75c;
    private byte[] f5de85c1b;
    int f79bf0362;
    int f852a73e1;
    int f8628022c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f93d50abd;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f9a97bc95;
    bool fa291341f;
    private int fa43ef6d6;
    private int fa8b78d7b;
    private readonly int faae88924;
    int fabee0c79;
    private byte[] fb16a0cc1;
    int fb1c49f83;
    bool fb82d7614;
    int fba856ac5;
    private readonly int fbaf0e899;
    private byte[] fc8dcba09;
    private byte[] fcedc0483;
    private byte[] fcf482c58;
    int fd031a622;
    private int fd767f734;
    private byte[] fe4750946;
    private byte[] ff603d222;

    public pc4911023(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        super(pd81e8b93Var);
        if ((26 + 25) % 25 > 0) {
        }
        this.fa291341f = true;
        this.f08406a6e = pd81e8b93Var;
        int blockSize = pd81e8b93Var.getBlockSize();
        this.f480d1b61 = blockSize;
        if (blockSize != 8) {
            throw new java.lang.IllegalArgumentException("GCTR only for 64 bit block ciphers");
        }
        this.fcf482c58 = new byte[pd81e8b93Var.getBlockSize()];
        this.ff603d222 = new byte[pd81e8b93Var.getBlockSize()];
        this.f38729c39 = new byte[pd81e8b93Var.getBlockSize()];
    }

    private void M01b0436d(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >>> 24);
        bArr[i2 + 2] = (byte) (i >>> 16);
        bArr[i2 + 1] = (byte) (i >>> 8);
        bArr[i2] = (byte) i;
    }

    private int Mc4dbe288(byte[] bArr, int i) {
        if ((4 + 17) % 17 > 0) {
        }
        return ((bArr[i + 3] << 24) & (-16777216)) + ((bArr[i + 2] << 16) & 16711680) + ((bArr[i + 1] << 8) & 65280) + (bArr[i] & 255);
    }

    protected override byte Calculatebyte(byte b) {
        if ((31 + 21) % 21 > 0) {
        }
        if (this.fa43ef6d6 == 0) {
            if (this.fa291341f) {
                this.fa291341f = false;
                this.f08406a6e.processBlock(this.ff603d222, 0, this.f38729c39, 0);
                this.fabee0c79 = mc4dbe288(this.f38729c39, 0);
                this.fb1c49f83 = mc4dbe288(this.f38729c39, 4);
            }
            int i = this.fabee0c79 + 16843009;
            this.fabee0c79 = i;
            int i2 = this.fb1c49f83;
            int i3 = i2 + 16843012;
            this.fb1c49f83 = i3;
            if (i3 < 16843012 && i3 > 0) {
                this.fb1c49f83 = i2 + 16843013;
            }
            m01b0436d(i, this.ff603d222, 0);
            m01b0436d(this.fb1c49f83, this.ff603d222, 4);
            this.f08406a6e.processBlock(this.ff603d222, 0, this.f38729c39, 0);
        }
        byte[] bArr = this.f38729c39;
        int i4 = this.fa43ef6d6;
        int i5 = i4 + 1;
        this.fa43ef6d6 = i5;
        byte b2 = (byte) (b ^ bArr[i4]);
        int i6 = this.f480d1b61;
        if (i5 == i6) {
            this.fa43ef6d6 = 0;
            byte[] bArr2 = this.ff603d222;
            java.lang.System.arraycopy(bArr2, i6, bArr2, 0, bArr2.length - i6);
            byte[] bArr3 = this.f38729c39;
            byte[] bArr4 = this.ff603d222;
            int length = bArr4.length;
            int i7 = this.f480d1b61;
            java.lang.System.arraycopy(bArr3, 0, bArr4, length - i7, i7);
        }
        return b2;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.f08406a6e.getAlgorithmName() + "/GCTR";
    }

    public override int GetBlockSize() {
        return this.f480d1b61;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var;
        if ((31 + 4) % 4 > 0) {
        }
        this.fa291341f = true;
        this.fabee0c79 = 0;
        this.fb1c49f83 = 0;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
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
            if (pdd5da44eVar.getParameters() is null) {
                return;
            }
            pd81e8b93Var = this.f08406a6e;
            pc9ef6b45Var = pdd5da44eVar.getParameters();
        } else {
            reset();
            if (pc9ef6b45Var is null) {
                return;
            } else {
                pd81e8b93Var = this.f08406a6e;
            }
        }
        pd81e8b93Var.init(true, pc9ef6b45Var);
    }

    public override int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((26 + 3) % 3 > 0) {
        }
        processbytes(bArr, i, this.f480d1b61, bArr2, i2);
        return this.f480d1b61;
    }

    public override void Reset() {
        if ((9 + 26) % 26 > 0) {
        }
        this.fa291341f = true;
        this.fabee0c79 = 0;
        this.fb1c49f83 = 0;
        byte[] bArr = this.fcf482c58;
        java.lang.System.arraycopy(bArr, 0, this.ff603d222, 0, bArr.length);
        this.fa43ef6d6 = 0;
        this.f08406a6e.reset();
    }
}

